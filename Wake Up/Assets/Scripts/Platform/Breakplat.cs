using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakplat : MonoBehaviour
{
    // 닿으면 부서지는 발판
    float timer;
    float waiting = 3.0f;
    bool isplayertouch = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isplayertouch != false)
        {
            timer += Time.deltaTime;
            if(timer >= this.waiting)
            {
                Destroy(gameObject);
                isplayertouch = false;
                timer = 0;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            isplayertouch = true;
        }
    }
}
