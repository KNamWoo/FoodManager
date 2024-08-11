using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkManager : MonoBehaviour
{    
    public string playername;

    Dictionary<int, string[]> nameData;//대화에서 나올 이름 저장
    Dictionary<int, string[]> talkData;//대화 데이터 저장

    void Awake(){
        nameData = new Dictionary<int, string[]>();
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData(){
        //일반 대화
        nameData.Add(1000, new string[] {"촌장"});
        talkData.Add(1000, new string[] {"무슨 일인가?"});

        nameData.Add(2000, new string[] {"레스토랑 주인"});
        talkData.Add(2000, new string[] {"흥, 레스토랑을 얻을 생각은 하지도 말게"});

        //퀘스트 대화
        //(퀘스트번호 + 관련 NPC번호, 대사)
        nameData.Add(10 + 1000, new string[] { "???", "촌장", playername, "촌장", playername, "촌장", playername, "촌장", playername, "촌장", "촌장", playername, "촌장", "촌장", playername});
        talkData.Add(10 + 1000, new string[] { "어서오게나 우리 마을에 잘 왔네.", "나는 이 마을의 촌장이네", "안녕하세요", "이 마을에는 무슨 일인가?", "앞으로 이 마을에서 살려구요.", "그래, 그럼 일단 일자리를 알아보게나", "여기서 할 수 있는 일이 뭐가 있죠?", "자네는 무슨 일을 하다 왔나?", "요리를 좀 하다가 왔습니다.", "마침 잘됐구만, 저기 레스토랑에서 가게를 인수할 사람을 찾고 있던데...", "돈은 좀 있는가?", "아니요, 기차 표만 끊어서 돈은 다 놓고 왔습니다.", "그런가...", "어쨌든 한번 레스토랑으로 가보게나 일자리를 줄 수도 있네.", "알겠습니다. 감사합니다."});
        
        nameData.Add(11 + 2000, new string[] { playername, playername, "???", "???", playername, playername, "레스토랑 주인", "레스토랑 주인", playername, playername, "레스토랑 주인", playername, "레스토랑 주인", playername, "레스토랑 주인", playername});
        talkData.Add(11 + 2000, new string[] { "(여기가 촌장님이 말씀하신 레스토랑인가?)", "여기 사장님 계십니까?", "누구냐", "여긴 왜 왔지?", "저는 이 마을로 이사를 온 " + playername + "입니다.", "촌장님께서 이리로 오면 일자리를 찾을 수 있다고 하셔서 왔습니다.", "아이고, 이 레스토랑을 사러 온 사람인가? 나는 이 레스토랑의 주인이네", "좀 가격이 나가는데 살 수 있겠나?", "아... 저기", "지금 돈이 없는데...", "뭐야? 거지였어?", "알바로라도 써주시면 안되겠습니까?", "흠...", "제발 써주십시오.", "안되네 어서 돌아가게.", "(레스토랑 사장님의 마음을 돌릴 무언가가 필요하겠어.)"});
        
        nameData.Add(20 + 1000, new string[]{ playername, playername, "촌장", playername, "촌장", "촌장", "촌장", "촌장", playername});
        talkData.Add(20 + 1000, new string[]{ "(촌장님이 나를 부르신다. 어서 가보자)", "저를 부르셨나요 촌장님", "그래. 일자리는 구했나?", "실패했습니다. 사장님께서 알바자리도, 레스토랑도 줄 수 없다고 하십니다.", "그래...?", "그 사장이 좀 겉으로는 그렇긴 하네.", "그렇구만... 저 사장은 레모네이드를 좋아하네.", "설탕은 내가 줄테니 레몬을 숲에서 얻어서 가져오게.", "알겠습니다. 감사합니다."});

        nameData.Add(30 + 1000, new string[]{ playername, "촌장", "촌장", playername, "촌장", playername});
        talkData.Add(30 + 1000, new string[]{ "레몬을 가져왔습니다.", "그래. 가져왔나.", "이제 사장에게 가져다주면 일자리를 줄거네.", "진짜로 레모네이드로 가능한 겁니까?", "그렇네. 나를 믿고 한 번 가져다 줘보게나.", "알겠습니다. 믿겠습니다."});

        nameData.Add(31 + 2000, new string[]{ "레스토랑 주인", playername, "레스토랑 주인", playername, playername, "레스토랑 주인", playername, "레스토랑 주인", playername, "레스토랑 주인", playername, "레스토랑 주인", playername, "레스토랑 주인", playername, playername, "레스토랑 주인", playername, "레스토랑 주인", playername, "레스토랑 주인"});
        talkData.Add(31 + 2000, new string[]{ "어째서 또 왔지?", "레모네이드의 재료를 가져왔습니다. 일자리를 주시지 않겠습니까?", "오 레모네이드인가? 이리 줘보게.", "여기요.", "(사장이 레모네이드를 즉석제작해서 마신다.)", "그래, 일자리를 달라고 했나?", "그렇습니다.", "그래. 나는 지금 기분이 좋으니 레스토랑을 빌려주도록하지.", "괜찮습니까?", "그래. 대신에 2500만원은 제대로 받겠네", "감사합니다.", "돈이 없다고 했었나?", "맞습니다.", "그래. 100만원을 얹어서 2600만원을 빌려주도록 하지. 이후에 제대로 갚게나.", "네 알겠습니다.", "감사합니다.", "음식은 주방에서 레시피를 보고 필요한 재료를 상점에서 사고, 숲에서 주워서 팔게나.", "네", "돈은 내가 은행 앞에 있을 테니 그리로 가져와서 갚게나.", "알겠습니다.", "필요한게 있으면 나에게 와서 말을 걸게."});
    }

    public string GetTalk(int id, int talkIndex){
        if(!talkData.ContainsKey(id)){
            if(!talkData.ContainsKey(id - id%10)){//퀘스트와 관련없는 것과 상호작용시
                return GetTalk(id - id%100, talkIndex);//사물 혹은 퀘스트가 끝난 이후 기본 대화 출력
            }else{//퀘스트를 진행중에 다시 NPC에 말을 걸면 처음부터 보여줌
                return GetTalk(id - id%10, talkIndex);
            }
        }
        if(talkIndex == talkData[id].Length){//대화 문장이 모두 보여짐
            return null;
        }else{
            return talkData[id][talkIndex];
        }
    }

    public string GetName(int id, int talkIndex){
        if(!talkData.ContainsKey(id)){
            if(!talkData.ContainsKey(id - id%10)){//퀘스트와 관련없는 것과 상호작용시
                return GetName(id - id%100, talkIndex);//사물 혹은 퀘스트가 끝난 이후 기본 대화 출력
            }else{//퀘스트를 진행중에 다시 NPC에 말을 걸면 처음부터 보여줌
                return GetName(id - id%10, talkIndex);
            }
        }
        if(talkIndex == talkData[id].Length){//대화 문장이 모두 보여짐
            return null;
        }else{
            return nameData[id][talkIndex];
        }
    }
}
