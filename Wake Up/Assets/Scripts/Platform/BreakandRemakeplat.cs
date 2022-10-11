using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakandRemakeplat : MonoBehaviour
{
    // 알아서 부서졌다가 재생성 되는 발판
    public static float currentXPosition;
    public static float currentYPosition;
    //float timer = 0;
    //float dest = 2.0f;
    public static bool isBRPDestroy = false;
    //bool isplayer = false;

    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        Destroy(gameObject);
        isBRPDestroy = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (PlatGenerater.isBRPGenerate != false)
        //{
        //    this.timer += Time.deltaTime;

        //    if (this.timer > dest)
        //    {
        //        Destroy(gameObject);
        //        isBRPDestroy = true;
        //        this.timer = 0;
        //    }
        //    PlatGenerater.isBRPGenerate = false;
        //}
    }

    //void OnCollisionEnter2D(Collision2D other)
    //{
    //    if (other.gameObject.tag.Equals("Player"))
    //    {
    //        isplayer = true;
    //    }
    //}
}
