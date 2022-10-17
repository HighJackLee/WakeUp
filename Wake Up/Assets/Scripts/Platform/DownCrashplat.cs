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
    float direction = 4.5f;
    float timer;
    float timer2;
    float waiting = 3.5f;
    float wait2 = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        startY = currentYPosition;
        timer = 0;
    }
    // �������� �ӵ��� �ö󰡴� �ӵ��� �ٸ���
    // Update is called once per frame
    void Update()
    {
        DownMax = startY - 8;
        currentYPosition -= Time.deltaTime * direction;
        if (currentYPosition <= DownMax)
        {
            //timer += Time.deltaTime;
            currentYPosition = DownMax;
            timer += Time.deltaTime;
            if (timer >= this.waiting)
            {
                direction = -3.5f;
                //direction *= -1;
            }
            timer2 = 0;
        }
        else if (currentYPosition >= startY)
        {
            //direction = 4.5f;
            //direction *= -1;
            currentYPosition = startY;
            timer2 += Time.deltaTime;
            if (timer2 >= this.wait2)
            {
                direction = 7.0f;
                //direction *= -1;
            }
            timer = 0;
        }
        transform.position = new Vector3(currentXPosition, currentYPosition, 0);
    }
}
