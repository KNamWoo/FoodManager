using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemData : MonoBehaviour
{
    public static CollectItemData coldata;

    public Nature[] nat;

    private void Awake() {
        if (coldata == null) {
            coldata = this;
        }
    }

    public List<CollectItem> colitemDB = new List<CollectItem>();

    [Space(20)]
    
    public GameObject CollectItemPrefab;

    public Transform natHolder;

    public Vector3[] pos;

    // Start is called before the first frame update
    private void Start()
    {
        nat = natHolder.GetComponentsInChildren<Nature>();
        for(int i = 0; i<5;i++){
            pos[i] = new Vector3 (nat[i].rbody.position.x, nat[i].rbody.position.y, 0);
            GameObject co = Instantiate(CollectItemPrefab, pos[i], Quaternion.identity);
            co.GetComponent<GetColItem>().SetItem(colitemDB[0]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}