using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FisrtSceneDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStartDown()
    {
        SceneManager.LoadScene("StageSelectScene");
    }

    public void HTPDown()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void ExitDown()
    {
        Application.Quit();
    }
}
