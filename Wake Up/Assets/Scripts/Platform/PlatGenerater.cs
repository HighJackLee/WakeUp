using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatGenerater : MonoBehaviour
{
    // 발판 재생성기
    public GameObject BRPlatPrefab;
    float timer = 0;
    float spawn = 4.0f;
    public static bool isBRPGenerate = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (BreakandRemakeplat.isBRPDestroy != false)
        {
            this.timer += Time.deltaTime;

            if (this.timer > this.spawn)
            {
                this.timer = 0;
                GameObject BRP = Instantiate(BRPlatPrefab) as GameObject;
                BRP.transform.position = new Vector3(BreakandRemakeplat.currentXPosition, BreakandRemakeplat.currentYPosition, 0);
                isBRPGenerate = true;
            }

            BreakandRemakeplat.isBRPDestroy = false;
        }
    }
}
