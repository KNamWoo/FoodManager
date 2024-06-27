using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class InvenSys : MonoBehaviour
{
    public static InvenSys invs;
    public bool actInven;
    public GameObject invenPanal;
    public Slot[] slots;

    private void Awake() {
        if (invs == null) {
            invs = this;
        }else if(invs != this) {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    
    public Transform slotHolder;
    
    private void Start(){
        actInven = false;
        invenPanal.SetActive(actInven);
        slots = slotHolder.GetComponentsInChildren<Slot>();
        for(int i=0;i<slots.Length;i++){
            slots[i].slotnum = i;
        }
    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            actInven = !actInven;
            invenPanal.SetActive(actInven);
        }
    }
}
