using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 스테이지 선택으로 나가기 위한 버튼

public class GotoStageSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gotoStageSelectDown()
    {
        SceneManager.LoadScene("StageSelectScene");
    }
}
