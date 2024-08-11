using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questId;
    public int questActionIndex;//퀘스트 NPC 순번
    public int questobj;

    public int cur_finquest;

    Dictionary<int, QuestData> questList;

    // Start is called before the first frame update
    void Awake()
    {
        questList = new Dictionary<int, QuestData>();
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        questList.Add(10, new QuestData("일자리를 구하기", new int[]{1000, 2000}));
        questList.Add(20, new QuestData("사장의 마음을 바꿀 방법 찾기", new int[]{1000}));
        questList.Add(30, new QuestData("촌장님과 다시 이야기하기", new int[]{1000, 2000}));
    }

    public int GetQuestTalkIndex(int id){
        return questId + questActionIndex;
    }

    public void CheckQuest(int id){
        if(questId < cur_finquest){
            //이전퀘스트 종료, 다음 퀘스트 준비
            if(id == questList[questId].NPCid[questActionIndex]){
                questActionIndex++;
            }

            //퀘스트 아이템 목록 확인
            ControlObject();

            //다음 퀘스트로 이동하기
            if(questActionIndex == questList[questId].NPCid.Length){
                NextQuest();
            }
        }else{
            Debug.Log("다음 퀘스트는 준비되어있지 않음");
        }
    }

    void NextQuest(){
        questId += 10;
        questActionIndex = 0;
    }

    void ControlObject(){//퀘스트 아이템 관리
        switch(questId){
            case 10:{
                break;
            }
            case 20:{
                if(questActionIndex == 1){//해당 퀘스트에서 1명과 대화했을때
                    questobj = 2;
                }
                break;
            }
            case 30:{
                break;
            }
            default:{
                break;
            }
        }
    }
}
