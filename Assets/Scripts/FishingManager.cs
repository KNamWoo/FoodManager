using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Splines;

public class FishingManager : MonoBehaviour
{
    public static FishingManager fishman;

    private void Awake(){
        if(fishman == null){
            fishman = this;
        }
    }

    public GameObject fishWin;
    public GameObject fish;
    public GameObject getWin;//Get Slider(second)
    public GameObject capWin;//Capture Slider (first)

    public bool posCreFish;

    // Start is called before the first frame update
    void Start()
    {
        //fishWin.SetActive(false);//잡기 창 비활성
        getWin.SetActive(false);
        capWin.SetActive(false);
        posCreFish = true;//물고기를 생성할 수 있음
    }

    // Update is called once per frame
    void Update()
    {
        if(posCreFish){
            /*if(Input.GetKeyDown(KeyCode.Space)){//키를 누르면 물고기가 생성됨
                posCreFish = false;
                fishWin.SetActive(true);//잡기 창 활성
                Instantiate(fish, new Vector3(0, 0, 0), quaternion.identity);//물고기 생성
            }*/
            if(Input.GetKeyDown(KeyCode.Space)){//키를 누르면 찌를 던지고, 특정 시간 이후에 세로 슬라이드 나옴
                posCreFish = false;
                capWin.SetActive(true);
            }
        }
    }

    public void SpawnFish(){
        getWin.SetActive(true);
        Instantiate(fish, new Vector3(0, 0, 0), quaternion.identity);//물고기 생성
    }
}
