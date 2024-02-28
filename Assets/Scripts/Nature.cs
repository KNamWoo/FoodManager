using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nature : MonoBehaviour
{
    public static Nature nat;

    private void Awake() {
        if (nat == null) {
            nat = this;
        }
    }

    public Rigidbody2D rbody;

    //public SpriteRenderer nati;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
