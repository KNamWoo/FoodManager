using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public FishingStick fstick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Pass"){
            fstick.startfishing = true;
            Debug.Log("닿기 시작");
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.tag == "Pass"){
            fstick.startfishing = false;
            Debug.Log("닿기 끝");
        }
    }
}
