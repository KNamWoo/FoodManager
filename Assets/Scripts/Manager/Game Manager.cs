using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    //public int[] count_item;
    public int money;

    public int carrot_amo;
    public int lemon_amo;
    public int tomato_amo;
    public int mushroom_amo;
    public int apple_amo;
    public int onion_amo;
    public int garlic_amo;
    public int rice_amo;
    public int pepper_amo;
    public int sugar_amo;
    public int milk_amo;
    public int salt_amo;
    public int flour_amo;
    public int egg_amo;
    public int butter_amo;
    public int msg_amo;
    public int courgette_amo;
    public int lettuce_amo;
    public int rowmeat_amo;
    public int fish_amo;
    public int soda_amo;

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
            if(Input.GetKey(KeyCode.Escape)){}

            if(Input.GetKey(KeyCode.Home)){}

            if(Input.GetKey(KeyCode.Menu)){}
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

    public void LoadButton(){
        LoadGame();
        LoadingSceneManager.LoadScene("FirstLoading","dorp");
    }

    public void NewGame(){
        Debug.Log("새 게임");
        Save();
    }

    public void LoadGame(){
        Debug.Log("게임 불러오기");
        Load();
    }

    public void Save() {
        SaveData saveData = new SaveData();

        saveData.money = money;
        saveData.carrot_amo = carrot_amo;
        saveData.lemon_amo = lemon_amo;
        saveData.tomato_amo = tomato_amo;
        saveData.mushroom_amo = mushroom_amo;
        saveData.apple_amo = apple_amo;
        saveData.onion_amo = onion_amo;
        saveData.garlic_amo = garlic_amo;
        saveData.rice_amo = rice_amo;
        saveData.pepper_amo = pepper_amo;
        saveData.sugar_amo = sugar_amo;
        saveData.milk_amo = milk_amo;
        saveData.salt_amo = salt_amo;
        saveData.flour_amo = flour_amo;
        saveData.egg_amo = egg_amo;
        saveData.butter_amo = butter_amo;
        saveData.msg_amo = msg_amo;
        saveData.courgette_amo = courgette_amo;
        saveData.lettuce_amo = lettuce_amo;
        saveData.rowmeat_amo = rowmeat_amo;
        saveData.fish_amo = fish_amo;
        saveData.soda_amo = soda_amo;

        string path = "save/gamesave.xml";
        XmlManager.XmlSave<SaveData>(saveData, path);
        print("저장경로 >> " + path);//C:\Users\nam\AppData\LocalLow\DefaultCompany
        Debug.Log("저장");
    }

    public void Load() {
        SaveData saveData = new SaveData();

        string path = "save/gamesave.xml";
        if (File.Exists(path) != true) {
            NewGame();
        }
        saveData = XmlManager.XmlLoad<SaveData>(path);
        
        money = saveData.money;
        carrot_amo = saveData.carrot_amo;
        lemon_amo = saveData.lemon_amo;
        tomato_amo = saveData.tomato_amo;
        mushroom_amo = saveData.mushroom_amo;
        apple_amo = saveData.apple_amo;
        onion_amo = saveData.onion_amo;
        garlic_amo = saveData.garlic_amo;
        rice_amo = saveData.rice_amo;
        pepper_amo = saveData.pepper_amo;
        sugar_amo = saveData.sugar_amo;
        milk_amo = saveData.milk_amo;
        salt_amo = saveData.salt_amo;
        flour_amo = saveData.flour_amo;
        egg_amo = saveData.egg_amo;
        butter_amo = saveData.butter_amo;
        msg_amo = saveData.msg_amo;
        courgette_amo = saveData.courgette_amo;
        lettuce_amo = saveData.lettuce_amo;
        rowmeat_amo = saveData.rowmeat_amo;
        fish_amo = saveData.fish_amo;
        soda_amo = saveData.soda_amo;

        print("저장되어있는 경로 >> " + Application.persistentDataPath);
        Debug.Log("불러오기");
    }
}
