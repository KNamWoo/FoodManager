using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public int[] count_item;

    public static GameManager instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }else if(instance != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android){
            if(Input.GetKey(KeyCode.Escape)){//뒤로가기
                Save();
                GameQuit();
            }

            if(Input.GetKey(KeyCode.Home)){}//홈버튼

            if(Input.GetKey(KeyCode.Menu)){}//최근 앱 버튼
        }

        if(Application.platform == RuntimePlatform.WindowsPlayer||Application.platform == RuntimePlatform.WindowsEditor){
            if(Input.GetKeyDown(KeyCode.Escape)){
                Save();
                GameQuit();
            }
        }
    }

    public void GameQuit(){
        Application.Quit();//game quit
    }

    public void StartButton(){
        NewGame();
        LoadingSceneManager.LoadScene("FirstLoading", "dorp");
    }

    public void NewGame(){
        Debug.Log("새로운 게임을 시작합니다");
        Save();
    }

    public void Save() {
        //Inventory_Data invendata = new Inventory_Data();

        /*for(int i=0;i<48;i++){
            invendata.count_item[i] = count_item[i];
        }*/

        //string path = Application.persistentDataPath + "/gamesave.xml";
        //XmlManager.XmlSave<SaveData>(saveData, path);
        //print(Application.persistentDataPath);
        Debug.Log("저장함");
    }

    public void Load() {
        //Inventory_Data invendata = new Inventory_Data();

        //string path = Application.persistentDataPath + "/gamesave.xml";
        /*if (File.Exists(path) != true) {
            NewGame();
        }*/
        //saveData = XmlManager.XmlLoad<SaveData>(path);

        //count_item[0] = invendata.count_item[0];
        Debug.Log("불러옴");
    }
}
