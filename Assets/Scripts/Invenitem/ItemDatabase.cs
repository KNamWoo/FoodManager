using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase itemdata;

    private void Awake() {
        if (itemdata == null) {
            itemdata = this;
        }else if(itemdata != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public List<Item> itemDB = new List<Item>();
}
