using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float h;
    public float v;

    public float speed;

    public Rigidbody2D rbody;

    private Animator anim;

    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        if (h < 0){//왼쪽
            direction = 1;

            transform.localScale = new Vector3(direction, 1, 1);
            anim.Play("Player_Left");

        }
        if (h > 0){//오른쪽
            direction = -1;

            transform.localScale = new Vector3(direction, 1, 1);
            anim.Play("Player_Left");
        }
        if(h==0&&v>0){
            anim.Play("Player_Up");
        }
        if(h==0&&v<0){
            anim.Play("Player_Down");
        }
        if(h==0&&v==0){
            anim.Play("Player_Idle");
        }
    }

    void Awake() {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        rbody.velocity = new Vector2(h, v)*speed*Time.deltaTime;
    }
}
