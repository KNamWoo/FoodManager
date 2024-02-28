using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItemDatabase : MonoBehaviour
{
    public static PickUpItemDatabase pickdata;

    private void Awake() {
        if (pickdata == null) {
            pickdata = this;
        }
    }

    public List<Item> itemDB = new List<Item>();

    [Space(20)]
    public GameObject PickupItemPrefab;
    public Vector3[] pos;

    // Start is called before the first frame update
    private void Start()
    {
        for(int i = 0; i<20;i++){
            GameObject go = Instantiate(PickupItemPrefab, pos[i], Quaternion.identity);
            go.GetComponent<GetItem>().SetItem(itemDB[Random.Range(0,4)]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
