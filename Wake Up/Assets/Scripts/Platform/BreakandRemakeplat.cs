using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakandRemakeplat : MonoBehaviour
{
    // 닿으면 부서졌다가 재생성 되는 발판
    public static float currentXPosition;
    public static float currentYPosition;
    public static bool isBRPDestroy = false;

    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.isBreak2 != false)
        {
            Destroy(gameObject);
            Player.isBreak2 = false;
            isBRPDestroy = true;
        }
    }
}
