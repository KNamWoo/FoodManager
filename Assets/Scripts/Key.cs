using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Key : MonoBehaviour
{
    public bool isinput;

    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        isinput = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isinput == true){
            foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode))){
                if (Input.GetKey(vKey)){
                    Debug.Log(vKey);
                    text.text = vKey.ToString();
                    isinput = false;
                }
            }
        }
    }

    public void key_input(){
        text.text = "";
        isinput = true;
    }
}
