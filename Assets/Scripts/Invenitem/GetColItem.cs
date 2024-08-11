using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
//using Unity.Android.Gradle;
using UnityEngine;

public class GetColItem : MonoBehaviour
{
    public GameObject slotItem;
    InvenSys inv;

    void Start(){
        inv = InvenSys.invs;
    }

    public CollectItem item;
    public SpriteRenderer spre;

    public void SetItem(CollectItem _item){
        item.itemName = _item.itemName;
        item.colitemImage = _item.colitemImage;
        item.itemImage = _item.itemImage;
        item.itemType = _item.itemType;

        //item.efts = _item.efts;

        spre.sprite = item.itemImage;
        //nat.nati.sprite = item.colitemImage;
    }

    public CollectItem GetTem(){
        return item;
    }

    public void ChangeItem(){
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag.Equals("Player")){
            for(int i = 0;i<inv.slots.Length;i++){
                if(inv.slots[i].ima.sprite == item.colitemImage){//이미지랑 같으면 갯수 추가
                    inv.slots[i].itemamo++;
                    break;
                }else if(i == inv.slots.Length - 1){
                    for(int j = 0; j<inv.slots.Length;j++){
                        if(inv.slots[j].isEmpty){
                            inv.slots[j].imageobj.SetActive(true);
                            inv.slots[j].ima.sprite = item.colitemImage;//슬롯에 colitemImage로 집어넣기
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
