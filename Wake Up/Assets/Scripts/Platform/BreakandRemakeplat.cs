using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakandRemakeplat : MonoBehaviour
{
    public GameObject BRPlatPrefab;
    float currentXPosition;
    float currentYPosition;
    float timer;
    float spawn = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentXPosition = transform.position.x;
        currentYPosition = transform.position.y;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (PlayerControll.isBreak != false)
        //{
        //    Destroy(gameObject);
        //    PlayerControll.isBreak = false;
        //    timer += Time.deltaTime;
        //}

        if(timer >= this.spawn)
        {
            GameObject BRP = Instantiate(BRPlatPrefab) as GameObject;
            BRP.transform.position = new Vector3(currentXPosition, currentYPosition, 0);
        }
    }
}
