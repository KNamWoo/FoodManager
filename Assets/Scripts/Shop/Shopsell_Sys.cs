using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shopsell_Sys : MonoBehaviour
{
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
    public TextMeshProUGUI carrot_t;
    public TextMeshProUGUI lemon_t;
    public TextMeshProUGUI tomato_t;
    public TextMeshProUGUI mushroom_t;
    public TextMeshProUGUI apple_t;
    public TextMeshProUGUI onion_t;
    public TextMeshProUGUI garlic_t;
    public TextMeshProUGUI fish_t;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;
        cm = Cost_Manager.costman;
    }

    // Update is called once per frame
    void Update()
    {
        rice_t.text = cm.rice_cost/10*9 + "won";
        pepper_t.text = cm.pepper_cost/10*9 + "won";
        sugar_t.text = cm.sugar_cost/10*9 + "won";
        milk_t.text = cm.milk_cost/10*9 + "won";
        salt_t.text = cm.salt_cost/10*9 + "won";
        flour_t.text = cm.flour_cost/10*9 + "won";
        egg_t.text = cm.egg_cost/10*9 + "won";
        butter_t.text = cm.butter_cost/10*9 + "won";
        msg_t.text = cm.msg_cost/10*9 + "won";
        courgette_t.text = cm.courgette_cost/10*9 + "won";
        lettuce_t.text = cm.lettuce_cost/10*9 + "won";
        soda_t.text = cm.soda_cost/10*9 + "won";
        carrot_t.text = cm.carrot_cost/10*9 + "won";
        lemon_t.text = cm.lemon_cost/10*9 + "won";
        tomato_t.text = cm.tomato_cost/10*9 + "won";
        mushroom_t.text = cm.mushroom_cost/10*9 + "won";
        apple_t.text = cm.apple_cost/10*9 + "won";
        onion_t.text = cm.onion_cost/10*9 + "won";
        garlic_t.text = cm.garlic_cost/10*9 + "won";
        rowmeat_t.text = cm.rowmeat_cost/10*9 + "won";
        fish_t.text = cm.fish_cost/10*9 + "won";
    }

    public void Sell_Rowmeat(){
        if(gm.rowmeat_amo > 0){
            gm.rowmeat_amo--;
            gm.money += cm.rowmeat_cost/10*9;
        }
    }

    public void Sell_Rice(){
        if(gm.rice_amo > 0){
            gm.rice_amo--;
            gm.money += cm.rice_cost/10*9;
        }
    }

    public void Sell_Pepper(){
        if(gm.pepper_amo > 0){
            gm.pepper_amo--;
            gm.money += cm.pepper_cost/10*9;
        }
    }

    public void Sell_Sugar(){
        if(gm.sugar_amo > 0){
            gm.sugar_amo--;
            gm.money += cm.sugar_cost/10*9;
        }
    }

    public void Sell_Milk(){
        if(gm.milk_amo > 0){
            gm.milk_amo--;
            gm.money += cm.milk_cost/10*9;
        }
    }

    public void Sell_Salt(){
        if(gm.salt_amo > 0){
            gm.salt_amo--;
            gm.money += cm.salt_cost/10*9;
        }
    }

    public void Sell_Flour(){
        if(gm.flour_amo > 0){
            gm.flour_amo--;
            gm.money += cm.flour_cost/10*9;
        }
    }

    public void Sell_Egg(){
        if(gm.egg_amo > 0){
            gm.egg_amo--;
            gm.money += cm.egg_cost/10*9;
        }
    }

    public void Sell_Butter(){
        if(gm.butter_amo > 0){
            gm.butter_amo--;
            gm.money += cm.butter_cost/10*9;
        }
    }

    public void Sell_MSG(){
        if(gm.msg_amo > 0){
            gm.msg_amo--;
            gm.money += cm.msg_cost/10*9;
        }
    }

    public void Sell_Courgette(){
        if(gm.courgette_amo > 0){
            gm.courgette_amo--;
            gm.money += cm.courgette_cost/10*9;
        }
    }

    public void Sell_Lettuce(){
        if(gm.lettuce_amo > 0){
            gm.lettuce_amo--;
            gm.money += cm.lettuce_cost/10*9;
        }
    }

    public void Sell_Soda(){
        if(gm.soda_amo > 0){
            gm.soda_amo--;
            gm.money += cm.soda_cost/10*9;
        }
    }

    public void Sell_Carrot(){
        if(gm.carrot_amo > 0){
            gm.carrot_amo--;
            gm.money += cm.carrot_cost/10*9;
        }
    }

    public void Sell_Lemon(){
        if(gm.lemon_amo > 0){
            gm.lemon_amo--;
            gm.money += cm.lemon_cost/10*9;
        }
    }

    public void Sell_Tomato(){
        if(gm.tomato_amo > 0){
            gm.tomato_amo--;
            gm.money += cm.tomato_cost/10*9;
        }
    }

    public void Sell_Mushroom(){
        if(gm.mushroom_amo > 0){
            gm.mushroom_amo--;
            gm.money += cm.mushroom_cost/10*9;
        }
    }

    public void Sell_Apple(){
        if(gm.apple_amo > 0){
            gm.apple_amo--;
            gm.money += cm.apple_cost/10*9;
        }
    }

    public void Sell_Onion(){
        if(gm.onion_amo > 0){
            gm.onion_amo--;
            gm.money += cm.onion_cost/10*9;
        }
    }

    public void Sell_Garlic(){
        if(gm.garlic_amo > 0){
            gm.garlic_amo--;
            gm.money += cm.garlic_cost/10*9;
        }
    }

    public void Sell_Fish(){
        if(gm.fish_amo > 0){
            gm.fish_amo--;
            gm.money -= cm.fish_cost/10*9;
        }
    }
}