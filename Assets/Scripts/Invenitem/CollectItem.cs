using System.Collections.Generic;
using UnityEngine;

public enum ColItemType {
    Food,//음식
    Tool,//도구 낚시대, 검 등등
    Etc
}

[System.Serializable]
public class CollectItem
{
    public int colitemnum;
    public ColItemType itemType;
    public string itemName;
    public Sprite colitemImage;//인벤토리로 들어갈 사진
    public Sprite itemImage;

    //public List<ItemEffect>efts;
    public bool isUsed;

    public bool Use(){
        /*foreach(ItemEffect eft in efts){
            isUsed = eft.ExecuteRole();
        }*/
        
        return isUsed;
    }
}