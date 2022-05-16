using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diagonalplat : MonoBehaviour
{
    float RightMax = 5.0f;
    float LeftMax = -5.0f;
    float UpMax = 5.0f;
    float DownMax = -5.0f;
    float currentXPosition;
    float currentYPosition;
    float direction = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
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
