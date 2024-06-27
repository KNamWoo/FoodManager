using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class InvenData : MonoBehaviour
{
    public int[] invencnt;
    public TextMeshProUGUI[] amotext;
    public GameObject chestman;
    public KeyCode chestopen;
    InvenSys inv;
    GameManager gm;

    private void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    // Start is called be
    void Start()
    {
        chestman.SetActive(false);
        gm = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        inv = InvenSys.invs;
        for(int i=0;i<inv.slots.Length;i++){
            if(inv.slots[i].itemamo >= 0 && inv.slots[i].item.itemnum >= 0){
                amotext[inv.slots[i].item.itemnum].text = inv.slots[i].itemamo.ToString("F0");
            }
        }

        if(Input.GetKeyDown(chestopen)){
            if(chestman.active == false){
                chestman.SetActive(true);
            }else{
                chestman.SetActive(false);
            }
        }
    }

    public void SavetoChest(){
        for(int i=0;i<inv.slots.Length;i++){
            if(inv.slots[i].itemamo > 0){
                switch(inv.slots[i].item.itemnum){
                    case 0:
                        gm.carrot_amo += inv.slots[i].itemamo;
                        break;
                    case 1:
                        gm.lemon_amo += inv.slots[i].itemamo;
                        break;
                    case 2:
                        gm.tomato_amo += inv.slots[i].itemamo;
                        break;
                    case 3:
                        gm.mushroom_amo += inv.slots[i].itemamo;
                        break;
                    case 4:
                        gm.apple_amo += inv.slots[i].itemamo;
                        break;
                    case 5:
                        gm.onion_amo += inv.slots[i].itemamo;
                        break;
                    case 6:
                        gm.garlic_amo += inv.slots[i].itemamo;
                        break;
                }
                inv.slots[i].itemamo = 0;
            }
        }
    }
}
