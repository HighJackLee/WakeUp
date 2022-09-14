using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakplat : MonoBehaviour
{
    float timer;
    float waiting = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.isBreak != false)
        {
            timer += Time.deltaTime;
            if(timer >= this.waiting)
            {
                Destroy(gameObject);
                Player.isBreak = false;
                timer = 0;
            }
        }
    }
}
