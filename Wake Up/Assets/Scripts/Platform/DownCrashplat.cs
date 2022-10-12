using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCrashplat : MonoBehaviour
{
    // 위에서 내려오는 부딪히면 사망하는 발판
    float DownMax;
    float startY;
    float currentXPosition;
    float currentYPosition;
    float direction = 4.5f;
    float timer;
    float waiting = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        startY = currentYPosition;
        timer = 0;
    }
    // 내려오는 속도와 올라가는 속도를 다르게
    // Update is called once per frame
    void Update()
    {
        DownMax = startY - 5;
        currentYPosition -= Time.deltaTime * direction;
        if (currentYPosition <= DownMax)
        {
            timer += Time.deltaTime;
            currentYPosition = DownMax;
            if(timer >= this.waiting)
            {
                direction = -3.0f;
                //direction *= -1;
            }
        }
        else if (currentYPosition >= startY)
        {
            direction = 4.5f;
            //direction *= -1;
            currentYPosition = startY;
            timer = 0;
        }
        transform.position = new Vector3(currentXPosition, currentYPosition, 0);
    }
}
