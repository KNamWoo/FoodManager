using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenData : MonoBehaviour
{
    public int[] itemcnt;
    InvenSys inv;

    // Start is called be
    void Start()
    {
        inv = InvenSys.invs;
        for(int i=0;i<inv.slots.Length;i++){
            if(inv.slots[i].itemamo >= 0 && inv.slots[i].item.itemnum >= 0){
                itemcnt[inv.slots[i].item.itemnum] = inv.slots[i].itemamo;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
