using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diagonalplat : MonoBehaviour
{
    // 우상 좌하로 움직이는 발판
    float RightMax;
    float LeftMax;
    float UpMax;
    float DownMax;
    float startY;
    float startX;
    float currentXPosition;
    float currentYPosition;
    float direction = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        startX = currentXPosition;
        startY = currentYPosition;
    }

    // Update is called once per frame
    void Update()
    {
        UpMax = startY + 10;
        DownMax = startY - 10;
        RightMax = startX + 10;
        LeftMax = startX - 10;
        currentXPosition += Time.deltaTime * direction;
        currentYPosition += Time.deltaTime * direction;
        if (currentXPosition >= RightMax && currentYPosition >= UpMax)
        {
            direction *= -1;
            currentXPosition = RightMax;
            currentYPosition = UpMax;
        }
        else if (currentXPosition <= LeftMax && currentYPosition <= DownMax)
        {
            direction *= -1;
            currentXPosition = LeftMax;
            currentYPosition = DownMax;
        }
        transform.position = new Vector3(currentXPosition, currentYPosition, 0);
    }
}
