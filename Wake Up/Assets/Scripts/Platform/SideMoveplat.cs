using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMoveplat : MonoBehaviour
{
    float RightMax;
    float LeftMax;
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
    }

    // Update is called once per frame
    void Update()
    {
        RightMax = startX + 10;
        LeftMax = startX - 10;
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
