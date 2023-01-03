using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    // 클리어 화면
    public static bool isClear1 = false;
    public static bool isClear2 = false;
    public string beforestage;
    // Start is called before the first frame update
    void Start()
    {
        beforestage = StageDirector.stagename;
    }

    // Update is called once per frame
    void Update()
    {
        if(beforestage == "Stage1")
        {
            isClear1 = true;
        } else if(beforestage == "Stage2")
        {
            isClear2 = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StageSelectScene");
        }
    }
}
