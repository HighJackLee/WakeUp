using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnwall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.isRSwitch != false)
        {
            transform.Rotate(0, 0, 90);
            Player.isRSwitch = false;
        }
    }
}
