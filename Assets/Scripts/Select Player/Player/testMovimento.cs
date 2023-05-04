using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMovimento : MonoBehaviour//, IDataPersistence
{
    public Vector3 direcao;
    public Vector3 cameraOffSet;
    public Animator animator;
    public Camera mainCamera;
    public Rigidbody rb;

    public float velocidade;
    float inputX;
    float inputZ;

    public bool readyToSpeak;
    public bool startDialogue;
    
    void Start()
    {
        GameObject.Find("Main Camera").SendMessage("setPlayer");
    }
    
    void Update()
    {

        if(inputX != 0 || inputZ != 0){
            transform.Translate(0,0, velocidade * Time.deltaTime);
            animator.SetBool("walk", true);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direcao), 5*Time.deltaTime);
        }
        if(inputX == 0 && inputZ == 0){
            animator.SetBool("walk", false);
        } 

    }

    private void FixedUpdate() {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        direcao = new Vector3(inputX,0,inputZ);
       /*float mov_horizontal = Input.GetAxis("Horizontal"); 
       float mov_vertical = Input.GetAxis("Vertical");

       Vector3 movimento = new Vector3(mov_horizontal,0,mov_vertical);

       rb.AddForce(movimento * velocidade);*/

    }

   /* public void LoadData(GameData data){
        this.transform.position = data.playerPosition;
    }

    public void SaveData(ref GameData data){
       data.playerPosition = this.transform.position;
    }
*/
}
