using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class botoesMemoria : MonoBehaviour
{
    public Button pause, mute;
    public GameObject painel;

    void Start()
    {
        pause.onClick = new Button.ButtonClickedEvent();
        mute.onClick = new Button.ButtonClickedEvent();

        pause.onClick.AddListener(() => Pause());
        mute.onClick.AddListener(() => Mute());
    }

    public void Pause(){
        Debug.Log("entrou");
        painel.SetActive(true);
    }

    public void Mute(){
        Debug.Log("entrou");
    }

    public void Config(){
        Debug.Log("entrou");
    }
}
