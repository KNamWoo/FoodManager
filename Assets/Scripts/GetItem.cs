using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public GameObject slotItem;
    InvenSys inv;

    void Start(){
        inv = InvenSys.invs;
    }

    public Item item;
    public SpriteRenderer spre;

    public void SetItem(Item _item){
        item.itemnum = _item.itemnum;
        item.itemName = _item.itemName;
        item.FieldImage = _item.FieldImage;
        item.InventoryImage = _item.InventoryImage;
        item.itemType = _item.itemType;
        //item.efts = _item.efts;

        spre.sprite = item.FieldImage;
    }

    public Item GetTem(){
        return item;
    }

    public void DestroyItem(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag.Equals("Player")){
            for(int i = 0;i<inv.slots.Length;i++){
                if(inv.slots[i].item.itemnum == item.itemnum){//인벤토리에 들어있는 이미지랑 같으면 갯수 더하기
                    inv.slots[i].itemamo++;
                    break;
                }else if(i == inv.slots.Length - 1){
                    for(int j = 0; j<inv.slots.Length;j++){
                        if(inv.slots[j].isEmpty){
                            inv.slots[j].item = item;
                            inv.slots[j].imageobj.SetActive(true);
                            inv.slots[j].ima.sprite = item.InventoryImage;
                            inv.slots[j].itemamo++;
                            inv.slots[j].isEmpty = false;
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
