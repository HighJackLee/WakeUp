using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMoveplat : MonoBehaviour
{
    // 오른쪽 왼쪽으로 움직이는 발판
    float RightMax;
    float LeftMax;
    float startX;
    float currentXPosition;
    float currentYPosition;
    float direction = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        startX = currentXPosition;
    }

    // Update is called once per frame
    void Update()
    {
        RightMax = startX + 5;
        LeftMax = startX - 5;
        currentXPosition += Time.deltaTime * direction;
        if (currentXPosition >= RightMax)
        {
            direction *= -1;
            currentXPosition = RightMax;
        }
        else if (currentXPosition <= LeftMax)
        {
            direction *= -1;
            currentXPosition = LeftMax;
        }
        transform.position = new Vector3(currentXPosition, currentYPosition, 0);
    }
}
