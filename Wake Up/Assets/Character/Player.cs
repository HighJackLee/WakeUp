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
    public static bool isBreak = false;
    public static bool isBreak2 = false;
    public static bool isClear1 = false;

    float horizontal;
    public Animator anim;
    public SpriteRenderer rend;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        PlayerMove();
        Jump();
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
            isBreak = true;
        }
        if (other.gameObject.tag.Equals("break2"))
        {
            isBreak2 = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("clearwarp"))
        {
            isClear1 = true;
            SceneManager.LoadScene("ClearScene");
        }
        if (other.gameObject.name.Equals("Death"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
