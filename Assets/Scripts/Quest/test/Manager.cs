using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Mathematics;

public class Manager : MonoBehaviour
{
    public TalkManager talkManager;
    public QuestManager questmanager;
    public GameObject DialoguePanel;
    public TMP_Text DialogueText;
    public GameObject NamePanel;
    public TMP_Text NameText;
    public GameObject scanObject;
    public KeyCode key;

    public int talkIndex;

    public bool isAction;

    void Start(){
        NamePanel.SetActive(false);
        DialoguePanel.SetActive(false);
    }

    public void Action(GameObject scanObj){//대사를 보기 시작함
        scanObject = scanObj;
        objdata objData = scanObject.GetComponent<objdata>();
        Talk(objData.id, objData.isNPC);

        NamePanel.SetActive(isAction);
        DialoguePanel.SetActive(isAction);
    }

    void Talk(int id, bool isNPC){
        int questTalkIndex = questmanager.GetQuestTalkIndex(id);

        string nameData = talkManager.GetName(id + questTalkIndex, talkIndex);
        string talkData = talkManager.GetTalk(id + questTalkIndex, talkIndex);
        
        if(talkData == null){//대화 문장이 더 없음
            isAction = false;
            talkIndex = 0;
            questmanager.CheckQuest(id);
            return;
        }

        if(isNPC){
            NameText.text = nameData;
            DialogueText.text = talkData;
        }else{
            NameText.text = nameData;
            DialogueText.text = talkData;
        }

        isAction = true;
        talkIndex++;
    }
}
