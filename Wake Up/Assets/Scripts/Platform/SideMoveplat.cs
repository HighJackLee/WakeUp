using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMoveplat : MonoBehaviour
{
    float RightMax = 5.0f;
    float LeftMax = -7.0f;
    float currentXPosition;
    float currentYPosition;
    float direction = 1.0f;
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
