using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cost_Manager : MonoBehaviour
{
    public static Cost_Manager costman;

    private void Awake(){
        if(costman == null){
            costman = this;
        }
    }

    public int fish_cost = 1700;
    public int rowmeat_cost = 2000;
    public int rice_cost = 800;
    public int pepper_cost = 350;
    public int sugar_cost = 350;
    public int milk_cost = 1500;
    public int salt_cost = 350;
    public int flour_cost = 1250;
    public int egg_cost = 1100;
    public int butter_cost = 500;
    public int msg_cost = 250;
    public int courgette_cost = 1000;
    public int lettuce_cost = 1400;
    public int soda_cost = 800;
    public int carrot_cost = 400;
    public int lemon_cost = 400;
    public int tomato_cost = 400;
    public int mushroom_cost = 400;
    public int apple_cost = 400;
    public int onion_cost = 400;
    public int garlic_cost = 400;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
