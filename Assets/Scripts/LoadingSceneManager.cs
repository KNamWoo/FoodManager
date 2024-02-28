using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingSceneManager : MonoBehaviour
{
    static string loadingScenename;
    static string nextScene;

    [SerializeField] Image loadingBar;

    //public Text loadingText;
    public TMP_Text loadingText;

    public static void LoadScene(string loadscene, string nextSceneNumber){
        loadingScenename = loadscene;
        nextScene = nextSceneNumber;
        SceneManager.LoadScene(loadingScenename);
    }

    private void Start() {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene() {
        yield return null;
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;
        float timer = 0.0f;
        while (!op.isDone) {
            yield return null;
            timer = timer + (Time.deltaTime/10);
            if (op.progress < 0.9f) {
                loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount, op.progress, timer);
                if (loadingBar.fillAmount >= op.progress) {
                    timer = 0.0f;
                }
            } else {
                loadingBar.fillAmount = Mathf.Lerp(loadingBar.fillAmount, 1f, timer);
                if (loadingBar.fillAmount >= 1.0f) {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update() {
        loadingText.text = string.Format("{0:N1}",loadingBar.fillAmount*100)+"%";
    }
}
