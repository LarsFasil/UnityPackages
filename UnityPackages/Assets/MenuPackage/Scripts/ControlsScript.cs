using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlsScript : MonoBehaviour
{ 
    //private SceneChanger cs_sceneChanger;

    void Start()
    {
       // cs_sceneChanger = GetComponent<SceneChanger>();
    }

    void Update()
    {
        Controls();
    }

    void Controls()
    {
        //start callibration
        if (Input.GetKeyDown(KeyCode.C))
        {
            
        }
        //quit application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //cs_sceneChanger.Quit();
        }
        //reload scene
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            //cs_sceneChanger.MenuScene();
        }
    }
}
