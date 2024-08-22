using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerSelect : MonoBehaviour
{

    GameObject player, playerCena;

    int i;

    public GameObject[] players;
    public Button next, previous, select, home;

    void Start()
    {
        Camera cameraCena = Camera.main;
        i = 0;

        next.onClick = new Button.ButtonClickedEvent();
        previous.onClick = new Button.ButtonClickedEvent();
        select.onClick = new Button.ButtonClickedEvent();
        home.onClick = new Button.ButtonClickedEvent();

        next.onClick.AddListener(() => Next());
        previous.onClick.AddListener(() => Previous());
        select.onClick.AddListener(() => Select());
        home.onClick.AddListener(() => Home());

    }

    void Update()
    {
        if(!player){
            player = GameObject.Find("Player");
            player = Instantiate(players[i], player.transform.position, player.transform.rotation);

        }
    }
    void Next(){
        i++;
        if(i>=players.Length){
            i=0;
        }
        
        Destroy(player);
    }

    void Previous(){
        i--;
        if(i < 0){
            i = players.Length-1;
        }
        
        Destroy(player);
    }

    void Select(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //    DontDestroyOnLoad(player);
       player.transform.position = new Vector3 (-7.67f,3.44f,1.66f);
    //    cameraCena.enabled = true;
       Debug.Log("entrou");
       PlayerPrefs.SetString("charName", player.name);
    }

    public void Home (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("voltou");
        Application.Quit();
   }
}
