using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shopbuy_Sys : MonoBehaviour
{
    public GameObject Buy_Win;
    public GameObject Sell_Win;
    public KeyCode shopkey;
    GameManager gm;
    Cost_Manager cm;

    public TextMeshProUGUI rowmeat_t;
    public TextMeshProUGUI rice_t;
    public TextMeshProUGUI pepper_t;
    public TextMeshProUGUI sugar_t;
    public TextMeshProUGUI milk_t;
    public TextMeshProUGUI salt_t;
    public TextMeshProUGUI flour_t;
    public TextMeshProUGUI egg_t;
    public TextMeshProUGUI butter_t;
    public TextMeshProUGUI msg_t;
    public TextMeshProUGUI courgette_t;
    public TextMeshProUGUI lettuce_t;
    public TextMeshProUGUI soda_t;

    // Start is called before the first frame update
    void Start()
    {
        Buy_Win.SetActive(false);
        Sell_Win.SetActive(false);
        gm = GameManager.instance;
        cm = Cost_Manager.costman;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(shopkey)){
            if(Buy_Win.active == true||Sell_Win.active == true){
                Buy_Win.SetActive(false);
                Sell_Win.SetActive(false);
            }else{
                Buy_Win.SetActive(true);
            }
        }

        rowmeat_t.text = cm.rowmeat_cost + "won";
        rice_t.text = cm.rice_cost + "won";
        pepper_t.text = cm.pepper_cost + "won";
        sugar_t.text = cm.sugar_cost + "won";
        milk_t.text = cm.milk_cost + "won";
        salt_t.text = cm.salt_cost + "won";
        flour_t.text = cm.flour_cost + "won";
        egg_t.text = cm.egg_cost + "won";
        butter_t.text = cm.butter_cost + "won";
        msg_t.text = cm.msg_cost + "won";
        courgette_t.text = cm.courgette_cost + "won";
        lettuce_t.text = cm.lettuce_cost + "won";
        soda_t.text = cm.soda_cost + "won";
    }

    public void Buy_rowmeat(){
        if(gm.money >= cm.rowmeat_cost){
            gm.money -= cm.rowmeat_cost;
            gm.rowmeat_amo++;
        }
    }

    public void Buy_Rice(){
        if(gm.money >= cm.rice_cost){
            gm.money -= cm.rice_cost;
            gm.rice_amo++;
        }
    }

    public void Buy_Pepper(){
        if(gm.money >= cm.pepper_cost){
            gm.money -= cm.pepper_cost;
            gm.pepper_amo++;
        }
    }

    public void Buy_Sugar(){
        if(gm.money >= cm.sugar_cost){
            gm.money -= cm.sugar_cost;
            gm.sugar_amo++;
        }
    }

    public void Buy_Milk(){
        if(gm.money >= cm.milk_cost){
            gm.money -= cm.milk_cost;
            gm.milk_amo++;
        }
    }

    public void Buy_Salt(){
        if(gm.money >= cm.salt_cost){
            gm.money -= cm.salt_cost;
            gm.salt_amo++;
        }
    }

    public void Buy_Flour(){
        if(gm.money >= cm.flour_cost){
            gm.money -= cm.flour_cost;
            gm.flour_amo++;
        }
    }

    public void Buy_Egg(){
        if(gm.money >= cm.egg_cost){
            gm.money -= cm.egg_cost;
            gm.egg_amo++;
        }
    }

    public void Buy_Butter(){
        if(gm.money >= cm.butter_cost){
            gm.money -= cm.butter_cost;
            gm.butter_amo++;
        }
    }

    public void Buy_MSG(){
        if(gm.money >= cm.msg_cost){
            gm.money -= cm.msg_cost;
            gm.msg_amo++;
        }
    }

    public void Buy_Courgette(){
        if(gm.money >= cm.courgette_cost){
            gm.money -= cm.courgette_cost;
            gm.courgette_amo++;
        }
    }

    public void Buy_Lettuce(){
        if(gm.money >= cm.lettuce_cost){
            gm.money -= cm.lettuce_cost;
            gm.lettuce_amo++;
        }
    }

    public void Buy_Soda(){
        if(gm.money >= cm.soda_cost){
            gm.money -= cm.soda_cost;
            gm.soda_amo++;
        }
    }
}