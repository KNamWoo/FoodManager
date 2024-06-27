using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishingStick : MonoBehaviour
{
    public Rigidbody2D rbody;
    public Slider stick;
    public GameObject stickobj;

    public bool startfishing;
    public bool upvalue;//찌 값 상하 true:up, false:down

    FishingManager fm;

    // Start is called before the first frame update
    void Start()
    {
        fm = FishingManager.fishman;
        startfishing = false;
        upvalue = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(startfishing){
            if(Input.GetKeyDown(KeyCode.Space)){
                stick.value = stick.minValue;
                fm.SpawnFish();
                stickobj.SetActive(false);
            }
        }

        if(stick.value == stick.minValue){
            upvalue = true;
        }else if(stick.value == stick.maxValue){
            upvalue = false;
        }

        if(upvalue){
            stick.value += Time.deltaTime/10;
        }else{
            stick.value -= Time.deltaTime/10;
        }
    }
}
