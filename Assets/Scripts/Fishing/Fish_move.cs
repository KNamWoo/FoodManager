using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_move : MonoBehaviour
{
    public float h;

    public float speed;
    public float currentmovespeed;
    public float leadspeed;

    public GameObject fish;

    private Rigidbody2D rbody;
    public KeyCode leadkey;//물고기 끌어오는 키

    private Vector2 leadDirection;

    private int direction = 1;
    private System.DateTime currentTime;//현재 시간 가져오기

    public bool posmove;
    Fishing fishing;
    FishingManager fiman;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.instance;
        fiman = FishingManager.fishman;
        rbody = GetComponent<Rigidbody2D>();
        currentTime = System.DateTime.Now;
        //StartCoroutine(speedcool(5f));
        h = Random.Range(0, 2);//a <= (a, b) < b
        if(h == 0){
            h = -1;
        }
    }

    void Update(){
        currentTime = System.DateTime.Now;

        if (h < 0){//오른쪽으로 이동
            direction = 1;
            leadDirection = Vector2.right;
            transform.localScale = new Vector3(direction, 1, 1);
        }
        if (h > 0){//왼쪽으로 이동
            direction = -1;
            leadDirection = Vector2.left;
            transform.localScale = new Vector3(direction, 1, 1);
        }

        rbody.velocity = new Vector2(h*speed, rbody.velocity.y);

        /*if(posmove){
            StartCoroutine(speedcool(5f));
        }*/

        if(Input.GetKey(leadkey)){
            rbody.AddForce(leadDirection * leadspeed, ForceMode2D.Impulse);
        }

        if(Fishing.fishing.beforevalue != Fishing.fishing.aftervalue){
            Fishing.fishing.beforevalue = Fishing.fishing.aftervalue;

            if(Fishing.fishing.aftervalue == 0){
                h = -h;
            }
        }

        if(Fishing.fishing.degree.value >= Fishing.fishing.degree.maxValue){//물고기 잡는 코드
            fiman.getWin.SetActive(false);
            fiman.capWin.SetActive(false);
            fiman.posCreFish = true;
            gm.fish_amo++;
            Fishing.fishing.degree.value = Fishing.fishing.degree.minValue;
            Destroy(fish);
        }
    }

    void Awake() {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    /*IEnumerator speedcool(float cool){
        Debug.Log("?떆?옉 ?떆媛? : "+currentTime.ToString());
        h = Random.Range(0, 2);//a <= (a, b) < b
        if(h == 0){
            h = -1;
        }
        posmove = false;
        yield return new WaitForSeconds(cool);
        posmove = true;
        Debug.Log("醫낅즺 ?떆媛? : "+currentTime.ToString());
    }*/

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag.Equals("Fzone")){//Fzone = fishing zone
            Fishing.fishing.pospercentup = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        Fishing.fishing.pospercentup = false;
    }
}
