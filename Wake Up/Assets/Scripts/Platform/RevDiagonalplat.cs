using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevDiagonalplat : MonoBehaviour
{
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
        UpMax = startY + 5;
        DownMax = startY - 5;
        RightMax = startX - 5;
        LeftMax = startX + 5;
        currentXPosition -= Time.deltaTime * direction;
        currentYPosition += Time.deltaTime * direction;
        if (currentXPosition <= RightMax && currentYPosition >= UpMax)
        {
            direction *= -1;
            currentXPosition = RightMax;
            currentYPosition = UpMax;
        }
        else if (currentXPosition >= LeftMax && currentYPosition <= DownMax)
        {
            direction *= -1;
            currentXPosition = LeftMax;
            currentYPosition = DownMax;
        }
        transform.position = new Vector3(currentXPosition, currentYPosition, 0);
    }
}
