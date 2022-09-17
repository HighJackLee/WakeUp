using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatGenerater : MonoBehaviour
{
    // ���� �������
    public GameObject BRPlatPrefab;
    float timer = 0;
    float spawn = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(BreakandRemakeplat.isBRPDestroy != false)
        {
            this.timer += Time.deltaTime;

            if (this.timer > this.spawn)
            {
                this.timer = 0;
                GameObject BRP = Instantiate(BRPlatPrefab) as GameObject;
                BRP.transform.position = new Vector3(BreakandRemakeplat.currentXPosition, BreakandRemakeplat.currentYPosition, 0);
            }

            BreakandRemakeplat.isBRPDestroy = false;
        }
    }
}