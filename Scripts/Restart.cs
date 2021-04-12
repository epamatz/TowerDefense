using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Timers;
public class Restart : MonoBehaviour
{    
    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.R)){
                
            SceneManager.LoadScene("TowerDefense");
        }
    }
}