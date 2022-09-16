using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCrashplat : MonoBehaviour
{
    // ������ �������� �ε����� ����ϴ� ����
    float DownMax;
    float startY;
    float currentXPosition;
    float currentYPosition;
    float direction = 2.0f;
    float timer;
    float waiting = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        startY = currentYPosition;
        timer = 0;
    }

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
                direction *= -1;
            }
        }
        else if (currentYPosition >= startY)
        {
            direction *= -1;
            currentYPosition = startY;
            timer = 0;
        }
        transform.position = new Vector3(currentXPosition, currentYPosition, 0);
    }
}
