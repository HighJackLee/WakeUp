using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownplat : MonoBehaviour
{
    float UpMax;
    float DownMax;
    float startY;
    float currentXPosition;
    float currentYPosition;
    float direction = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        startY = currentYPosition;
    }

    // Update is called once per frame
    void Update()
    {
        UpMax = startY + 10;
        DownMax = startY - 10;
        currentYPosition += Time.deltaTime * direction;
        if (currentYPosition >= UpMax)
        {
            direction *= -1;
            currentYPosition = UpMax;
        }
        else if (currentYPosition <= DownMax)
        {
            direction *= -1;
            currentYPosition = DownMax;
        }
        transform.position = new Vector3(currentXPosition, currentYPosition, 0);
    }
}
