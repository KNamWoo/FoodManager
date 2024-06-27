using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.UIElements;

public class Restaurant_Sys : MonoBehaviour
{
    public KeyCode resKey;
    public GameObject resWin;
    GameManager gm;
    Cost_Manager cm;

    public TextMeshProUGUI steak_t;
    public TextMeshProUGUI ice_t;
    public TextMeshProUGUI pie_t;
    public TextMeshProUGUI hambuger_t;
    public TextMeshProUGUI pap_t;
    public TextMeshProUGUI bakedfish_t;
    public TextMeshProUGUI lemonade_t;
    public TextMeshProUGUI soda_t;

    public int steak_cost;
    public int ice_cost;
    public int pie_cost;
    public int hambuger_cost;
    public int pap_cost;
    public int bakedfish_cost;
    public int lemonade_cost;
    public int soda_cost;

    // Start is called before the first frame update
    void Start()
    {
        resWin.SetActive(false);
        gm = GameManager.instance;
        cm = Cost_Manager.costman;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(resKey)){
            if(resWin.active == false){
                resWin.SetActive(true);
            }else{
                resWin.SetActive(false);
            }
        }

        steak_cost = cm.rowmeat_cost+cm.pepper_cost;
        ice_cost = cm.sugar_cost+cm.milk_cost+cm.salt_cost;
        pie_cost = cm.apple_cost+cm.flour_cost+cm.milk_cost+cm.egg_cost+cm.sugar_cost+cm.butter_cost+cm.salt_cost;
        hambuger_cost = cm.flour_cost+cm.rowmeat_cost+cm.lettuce_cost+cm.tomato_cost+cm.onion_cost+cm.msg_cost;
        pap_cost = cm.rice_cost+cm.garlic_cost+cm.onion_cost+cm.courgette_cost+cm.carrot_cost+cm.mushroom_cost;
        bakedfish_cost = cm.fish_cost+cm.lemon_cost;
        lemonade_cost = cm.lemon_cost+cm.sugar_cost;
        soda_cost = cm.soda_cost;

        steak_t.text = steak_cost*1.1 + "won";
        ice_t.text = ice_cost*1.1 + "won";
        pie_t.text = pie_cost*1.1 + "won";
        hambuger_t.text = hambuger_cost*1.1 + "won";
        pap_t.text = pap_cost*1.1 + "won";
        bakedfish_t.text = bakedfish_cost*1.1 + "won";
        lemonade_t.text = lemonade_cost*1.1 + "won";
        soda_t.text = soda_cost*1.1 + "won";
    }

    public void Sell_Steak(){
        if(gm.rowmeat_amo>0 && gm.pepper_amo>0){
            gm.rowmeat_amo--;
            gm.pepper_amo--;
            gm.money += steak_cost;
        }
    }

    public void Sell_Ice(){
        if(gm.sugar_amo>0 && gm.milk_amo>0 && gm.salt_amo>0){
            gm.sugar_amo--;
            gm.milk_amo--;
            gm.salt_amo--;
            gm.money += ice_cost;
        }
    }

    public void Sell_Pie(){
        if(gm.apple_amo>0 && gm.flour_amo>0 && gm.milk_amo>0 && gm.egg_amo>0 && gm.sugar_amo>0 && gm.butter_amo>0 && gm.salt_amo>0){
            gm.apple_amo--;
            gm.flour_amo--;
            gm.milk_amo--;
            gm.egg_amo--;
            gm.sugar_amo--; 
            gm.butter_amo--;
            gm.salt_amo--;
            gm.money += pie_cost;
        }
    }

    public void Sell_Burger(){
        if(gm.flour_amo>0 && gm.rowmeat_amo>0 && gm.lettuce_amo>0 && gm.tomato_amo>0 && gm.onion_amo>0 && gm.msg_amo>0){
            gm.flour_amo--;
            gm.rowmeat_amo--;
            gm.lettuce_amo--;
            gm.tomato_amo--;
            gm.onion_amo--;
            gm.msg_amo--;
            gm.money += hambuger_cost;
        }
    }

    public void Sell_Pap(){
        if(gm.rice_amo>0 && gm.garlic_amo>0 && gm.onion_amo>0 && gm.courgette_amo>0 && gm.carrot_amo>0 && gm.mushroom_amo>0){
            gm.rice_amo--;
            gm.garlic_amo--;
            gm.onion_amo--;
            gm.courgette_amo--;
            gm.carrot_amo--;
            gm.mushroom_amo--;
            gm.money += pap_cost;
        }
    }

    public void Sell_Bakedfish(){
        if(gm.fish_amo>0 && gm.lemon_amo>0){
            gm.fish_amo--;
            gm.lemon_amo--;
            gm.money += bakedfish_cost;
        }
    }

    public void Sell_Lemonade(){
        if(gm.lemon_amo>0 && gm.sugar_amo>0){
            gm.lemon_amo--;
            gm.sugar_amo--;
            gm.money += lemonade_cost;
        }
    }

    public void Sell_Soda(){
        if(gm.soda_amo>0){
            gm.soda_amo--;
            gm.money += soda_cost;
        }
    }
}