using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float playerSpeed = 5;

    Rigidbody2D rigid;

    public float jumpPower;
    public bool isJump = false;
    public static bool isClear1 = false;
    public int key;
    public static bool isSwitch = false;
    public static bool isRSwitch = false;
    public string restart;

    float horizontal;
    public Animator anim;
    public SpriteRenderer rend;
    

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        restart = StageDirector.stagename;
        key = 0;
    }

    private void Update()
    {
        PlayerMove();
        Jump();
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(restart);
        }
    }
    
    void PlayerMove()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (horizontal != 0)
        {
            anim.SetBool("walk", true);
            if(horizontal > 0)
            {
                rend.flipX = false;
            }
            else
            {
                rend.flipX = true;
            }
        }
        else
        {
            anim.SetBool("walk", false);
        }

        Vector3 dir = horizontal * Vector3.right;
        this.transform.Translate(dir * playerSpeed * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (!isJump)
            {
                isJump = true;
                rigid.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("ground"))
        {
            isJump = false;
        }
        if (other.gameObject.tag.Equals("break"))
        {
            isJump = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("key"))
        {
            key++;
        }
        if (other.gameObject.tag.Equals("switch"))
        {
            isSwitch = true;
        }
        if (other.gameObject.tag.Equals("roswitch"))
        {
            isRSwitch = true;
        }
        if (other.gameObject.tag.Equals("clearwarp") && key == 3)
        { 
            isClear1 = true;
            SceneManager.LoadScene("ClearScene");
        }
        if (other.gameObject.tag.Equals("Death"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
        if (other.gameObject.tag.Equals("crash"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
        if (other.gameObject.tag.Equals("spike"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
        
    }
}
