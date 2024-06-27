using System.Collections.Generic;
using UnityEngine;

public enum ItemType {
    Food,//음식
    Tool,//도구 낚시대, 검 등등
    Etc
}

[System.Serializable]
public class Item
{
    public int itemnum;
    public ItemType itemType;
    public string itemName;
    public Sprite FieldImage;//필드에 놓일 사진
    public Sprite InventoryImage;//인벤토리에 들어갈 사진

    //public List<ItemEffect>efts;
    public bool isUsed;

    public bool Use(){
        isUsed = false;
    
        /*foreach(ItemEffect eft in efts){
            isUsed = eft.ExecuteRole();
        }*/
        
        return isUsed;
    }
}