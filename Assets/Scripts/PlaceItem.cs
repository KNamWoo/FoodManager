using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    public static PlaceItem pitem;
    ItemDatabase DB;

    private void Awake() {
        if (pitem == null) {
            pitem = this;
        }
    }

    public GameObject FieldItemPrefab;
    public int droppeditemfin;//final dropped itemnumber
    public int allitemfin;
    public int overlabitemamo;

    //public GameObject CollectItemPrefab;

    //public Transform natHolder;
    public Vector3[] pos1;
    public Vector3[] pos2;

    //GetItem = get;

    // Start is called before the first frame update
    private void Start()
    {
        DB = ItemDatabase.itemdata;

        if(DB == null){
            Debug.LogError("아이템 데이터 할당 실패");
        }
        if(DB.itemDB == null){
            Debug.LogError("itemDB리스트 할당실패");
        }else{
            Debug.Log("아이템 할당성공");
        }

        for(int i = 0; i<10;i++){
            GameObject go = Instantiate(FieldItemPrefab, pos1[i], Quaternion.identity);
            go.GetComponent<GetItem>().Getnum(DB.itemDB[Random.Range(0,droppeditemfin+1)]);//0 ~ droppeditemfin까지의 아이템 배치

        }

        //nat = natHolder.GetComponentsInChildren<Nature>();
        for(int num = droppeditemfin+1;num<allitemfin+1;num++){
            for(int i = (num-3)*overlabitemamo;i < (num-3)*overlabitemamo+5;i++){
                //pos2[i] = new Vector3 (nat[i].rbody.position.x, nat[i].rbody.position.y, 0);
                GameObject go = Instantiate(FieldItemPrefab, pos2[i], Quaternion.identity);
                go.GetComponent<GetItem>().Getnum(DB.itemDB[num]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
