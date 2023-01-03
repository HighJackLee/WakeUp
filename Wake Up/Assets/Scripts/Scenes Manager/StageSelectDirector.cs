using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectDirector : MonoBehaviour
{
    // 스테이지 선택 화면
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage1Down()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Stage2Down()
    {
        if(ClearDirector.isClear1 != false)
        {
            SceneManager.LoadScene("Stage2");
        }
    }

    public void Stage3Down()
    {
        if (ClearDirector.isClear1 != false && ClearDirector.isClear2 != false)
        {
            SceneManager.LoadScene("Stage3");
        }
    }
}
