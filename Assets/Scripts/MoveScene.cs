using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLoading : MonoBehaviour
{
    public int NextSceneNumber;

    public void FirstLoading(){
        SceneManager.LoadScene("Loading");
    }

    public void Loading(){
        SceneManager.LoadScene("Loading");
    }

    public void MoveNextScene(){
        SceneManager.LoadScene(NextSceneNumber);
    }
}
