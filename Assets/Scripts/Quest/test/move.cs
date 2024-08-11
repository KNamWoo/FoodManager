using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Manager manager;
    public float h;
    public float v;

    public float speed;

    public Rigidbody2D rbody;

    private Animator anim;

    private int direction = 1;

    public GameObject scanObject;

    Vector3 dirRay;//Ray를 그릴때 사용

    public KeyCode NextDialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        if (h < 0){//왼쪽
            direction = 1;
            dirRay = Vector3.left;

            transform.localScale = new Vector3(direction, 1, 1);
            anim.Play("Player_Left");

        }
        if (h > 0){//오른쪽
            direction = -1;
            dirRay = Vector3.right;

            transform.localScale = new Vector3(direction, 1, 1);
            anim.Play("Player_Left");
        }
        if(h==0&&v>0){//위로
            anim.Play("Player_Up");
            dirRay = Vector3.up;
        }
        if(h==0&&v<0){//아래로
            anim.Play("Player_Down");
            dirRay = Vector3.down;
        }
        if(h==0&&v==0){//정지
            anim.Play("Player_Idle");
        }

        if(Input.GetKeyDown(NextDialogue)&&scanObject != null){
            manager.Action(scanObject);
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

        Debug.DrawRay(rbody.position, dirRay *0.7f, new Color(0,1,0));//선을 그려 앞의 물체를 인식함
        RaycastHit2D rayHit = Physics2D.Raycast(rbody.position, dirRay, 0.7f, LayerMask.GetMask("Object"));
        
        if(rayHit.collider != null){
            scanObject = rayHit.collider.gameObject;
        }else{
            scanObject = null;
        }
    }
}
