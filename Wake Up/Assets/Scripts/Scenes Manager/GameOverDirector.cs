using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverDirector : MonoBehaviour
{
    public string beforestage;
    // 게임오버 화면
    // Start is called before the first frame update
    void Start()
    {
        beforestage = StageDirector.stagename;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //SceneManager.LoadScene("Stage1");
            SceneManager.LoadScene(beforestage);
        }
    }
}
