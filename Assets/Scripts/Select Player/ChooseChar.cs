using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseChar : MonoBehaviour
{

    string prefabName;

    // Start is called before the first frame update
    void Start()
    {
        prefabName = "Personagens/" + PlayerPrefs.GetString("charName").Split("(Clone)")[0];
        Instantiate((GameObject) Resources.Load(prefabName, typeof(GameObject)), new Vector3(-7.67F,3.44F,0.5F), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
