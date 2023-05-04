using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativarAndar : MonoBehaviour
{
    public GameObject parede;
    public GameObject chao;
    public GameObject objetos;
    public GameObject luz;
    public GameObject mae;
    public GameObject box;
    public bool boxCima;

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            //StartCoroutine(WaitForSeconds());
            parede.SetActive(!parede.active);
            chao.SetActive(!chao.active);
            objetos.SetActive(!objetos.active);
            luz.SetActive(!luz.active);
            mae.SetActive(!mae.active);
            box.SetActive(!box.active);

            this.transform.position = boxCima? new Vector3 (-5.17999983f,0.75999999f,0.119999997f): new Vector3(-5.17999983f,3.26999998f,-2.43899989f);
            boxCima = !boxCima;
        }
    }

    private IEnumerator WaitForSeconds() {
        yield return new WaitForSeconds(2);
    }
}
