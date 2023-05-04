using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boxMinigame : MonoBehaviour
{
    public GameObject painel;
    public Button start, close;

    void Start()
    {
        painel.SetActive(false);

        start.onClick.AddListener(() => StartJogo());
        close.onClick.AddListener(() => FecharJogo());

    }

    void Update()
    {
        transform.Rotate(new Vector3(0,30,0) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            Debug.Log("chegou");
            painel.SetActive(true);
        }
    }

    private void StartJogo(){
        SceneManager.LoadScene("Jogo_da_Memoria");
        Destroy(GameObject.Find("Mochila"));

    }

    private void FecharJogo(){
        painel.SetActive(false);

    }

}
