using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerUpHandler
{
    public static Slot slotspt;
    public GameObject imageobj;
    public Image ima;
    public GameObject amountobj;
    public Text amount_text;
    public Item item;
    
    private void Awake() {
        if (slotspt == null) {
            slotspt = this;
        }
    }

    public int slotnum;
    public int itemamo;
    public bool isEmpty;

    public GameObject slotObj;

    void Start(){
        itemamo = 0;
        isEmpty = true;
    }

    void Update(){
        if(itemamo > 1){
            amountobj.SetActive(true);
            amount_text.text = itemamo.ToString();
        }else if(itemamo == 1){
            amountobj.SetActive(false);
        }else if(itemamo < 1){
            isEmpty = true;
            ima.sprite = null;
            amountobj.SetActive(false);
            imageobj.SetActive(false);
            item.itemnum = -1;
        }
    }

    public void OnPointerUp(PointerEventData eventData){//슬롯 클릭해서 아이템 사용하기
        if(itemamo > 1){
            itemamo--;
        }else if(itemamo == 1){
            isEmpty = true;
            itemamo = 0;
            ima.sprite = null;
            //아이템의 효과들을 정리한 스크립트를 하나 생성해서, 효과 집어넣기
            imageobj.SetActive(false);
        }
    }
}
