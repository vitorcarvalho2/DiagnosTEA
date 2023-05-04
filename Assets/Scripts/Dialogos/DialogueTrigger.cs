using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogues dialogueScript;
    private bool playerDetected;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            playerDetected = true;
            Debug.Log("entrou");
            dialogueScript.ToggleIndicator(playerDetected);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            playerDetected = false;
            dialogueScript.ToggleIndicator(playerDetected);
            dialogueScript.EndDialogue();
        }
        
    }

    private void Update()
    {
        if(playerDetected && Input.GetKeyDown(KeyCode.B)){
            Debug.Log("apertou");
            dialogueScript.StartDialogue();
        }
    }

}
