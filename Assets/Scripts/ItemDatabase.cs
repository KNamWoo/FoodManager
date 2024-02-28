using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase itemdata;
    //public Nature[] nat;

    private void Awake() {
        if (itemdata == null) {
            itemdata = this;
        }
    }

    public List<Item> itemDB = new List<Item>();
    //public List<CollectItem> colitemDB = new List<CollectItem>();

    [Space(20)]
    public GameObject FieldItemPrefab;
    public int droppeditemfin;//final dropped itemnumber
    public int allitemfin;
    public int overlabitemamo;//etc, 사과나무, 양파 등 먹고나면 남는 아이템들의 필드에 존재하는 수

    //public GameObject CollectItemPrefab;

    //public Transform natHolder;
    public Vector3[] pos1;
    public Vector3[] pos2;

    // Start is called before the first frame update
    private void Start()
    {
        for(int i = 0; i<10;i++){
            GameObject go = Instantiate(FieldItemPrefab, pos1[i], Quaternion.identity);
            go.GetComponent<GetItem>().SetItem(itemDB[Random.Range(0,droppeditemfin+1)]);//0 ~ droppeditemfin번호의 아이템까지 생성
        }

        //nat = natHolder.GetComponentsInChildren<Nature>();
        for(int num = droppeditemfin+1;num<allitemfin+1;num++){//num은 아이템 번호
            for(int i = (num-3)*overlabitemamo;i < (num-3)*overlabitemamo+5;i++){//i=위치정보
                //pos2[i] = new Vector3 (nat[i].rbody.position.x, nat[i].rbody.position.y, 0);
                GameObject go = Instantiate(FieldItemPrefab, pos2[i], Quaternion.identity);
                go.GetComponent<GetItem>().SetItem(itemDB[num]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
