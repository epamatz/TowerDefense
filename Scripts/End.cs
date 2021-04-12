using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Timers;

public class End : MonoBehaviour
{
    public static float BaseHealth=3;
  void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Enemy")
        {
            BaseHealth-=1;
            if(BaseHealth<=0){
            SceneManager.LoadScene("TowerDefense");
             }
    }
  }
}
