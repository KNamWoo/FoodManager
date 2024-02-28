using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class Fishing : MonoBehaviour
{
    public static Fishing fishing;

    private void Awake(){
        if(fishing == null){
            fishing = this;
        }
    }

    public bool pospercentup;

    public Slider degree;

    public int beforevalue;
    public int aftervalue;

    // Start is called before the first frame update
    void Start()
    {
        degree.value = degree.minValue;
        
        pospercentup = false;
    }

    // Update is called once per frame
    void Update()
    {
        aftervalue = ((int)(degree.value*10f))%2;

        if(pospercentup){
            degree.value += Time.deltaTime*0.05f;
        }
    }
}
