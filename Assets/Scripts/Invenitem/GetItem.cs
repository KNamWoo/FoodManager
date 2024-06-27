using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class GetItem : MonoBehaviour//배치된 아이템 지정
{
    ItemDatabase iDB;

    public GameObject slotItem;
    bool isnotget;
    InvenSys inv;
    int itnum;

    void Start(){
        inv = InvenSys.invs;
        iDB = ItemDatabase.itemdata;

        if(iDB == null){
            Debug.LogError("아이템 데이터 할당 실패");
        }
        if(iDB.itemDB == null){
            Debug.LogError("itemDB리스트 할당실패");
        }else{
            Debug.Log("아이템 할당성공");
        }
    }

    public Item item;
    public SpriteRenderer spre;

    public void Getnum(Item dbItem){
        itnum = dbItem.itemnum;
        item.itemnum = itnum;
        item.itemName = dbItem.itemName;
        item.FieldImage = dbItem.FieldImage;
        item.InventoryImage = dbItem.InventoryImage;
        item.itemType = dbItem.itemType;
        //item.efts = _item.efts;
        spre.sprite = dbItem.FieldImage;

        //item.FieldImage = iDB.itemDB[itemnum].FieldImage;
        //item.itemnum = itemnum;
    }

    /*public Item GetTem(){
        return item;
    }*/

    /*public void DestroyItem(){
        Destroy(gameObject);
    }*/

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag.Equals("Player")){
            isnotget = true;
            for(int i = 0;i<inv.slots.Length;i++){
                if(inv.slots[i].item.itemnum == iDB.itemDB[itnum].itemnum && isnotget == true){//인벤토리의 아이템 번호와 같으면 갯수 더하기
                    inv.slots[i].itemamo += 1;
                    Debug.Log("같은 아이템을 또 먹었다");
                    isnotget = false;
                    break;
                }else if(i == inv.slots.Length - 1){
                    for(int j = 0; j<inv.slots.Length;j++){
                        if(inv.slots[j].isEmpty && isnotget == true){
                            inv.slots[j].item = iDB.itemDB[itnum];
                            inv.slots[j].imageobj.SetActive(true);
                            inv.slots[j].ima.sprite = iDB.itemDB[itnum].InventoryImage;
                            inv.slots[j].itemamo += 1;
                            inv.slots[j].isEmpty = false;
                            Debug.Log("같은 아이템을 처음 먹었다");
                            isnotget = false;
                            Destroy(this.gameObject);
                            break;
                        }
                    }
                }
            }
            Destroy(this.gameObject);
        }
    }
}
