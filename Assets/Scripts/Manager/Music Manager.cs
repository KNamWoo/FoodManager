using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource bgmso;
    public AudioClip[] bgmList;
    // Start is called before the first frame update
    void Start()
    {
        bgmso.loop = true;
        bgmso.clip = bgmList[0];
        bgmso.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            bgmso.clip = bgmList[1];
            bgmso.Play();
        }
    }
}
