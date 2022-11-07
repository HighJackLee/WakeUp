using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageDirector : MonoBehaviour
{
    public static string stagename;
    // Start is called before the first frame update
    void Start()
    {
        stagename = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
