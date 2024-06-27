using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Restaurant_Chest : MonoBehaviour
{
    GameManager gm;
    public GameObject reschest;
    public KeyCode reschkey;

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
        reschest.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(reschkey)) {
            if(reschest.active == true) {
                reschest.SetActive(false);
            } else {
                reschest.SetActive(true);
            }
        }
        rice_t.text = gm.rice_amo + "";
        pepper_t.text = gm.pepper_amo + "";
        sugar_t.text = gm.sugar_amo + "";
        milk_t.text = gm.milk_amo + "";
        salt_t.text = gm.salt_amo + "";
        flour_t.text = gm.flour_amo + "";
        egg_t.text = gm.egg_amo + "";
        butter_t.text = gm.butter_amo + "";
        msg_t.text = gm.msg_amo + "";
        courgette_t.text = gm.courgette_amo + "";
        lettuce_t.text = gm.lettuce_amo + "";
        soda_t.text = gm.soda_amo + "";
        carrot_t.text = gm.carrot_amo + "";
        lemon_t.text = gm.lemon_amo + "";
        tomato_t.text = gm.tomato_amo + "";
        mushroom_t.text = gm.mushroom_amo + "";
        apple_t.text = gm.apple_amo + "";
        onion_t.text = gm.onion_amo + "";
        garlic_t.text = gm.garlic_amo + "";
        rowmeat_t.text = gm.rowmeat_amo + "";
        fish_t.text = gm.fish_amo + "";
    }
}
