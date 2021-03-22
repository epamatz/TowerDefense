using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purse : MonoBehaviour
{
   public static float coins = 0;
   public Text amount;
   
    // Start is called before the first frame update
    void Start()
    {
      amount = GetComponent<Text> ();  
    }

    // Update is called once per frame
    void Update()
    {
        amount.text="coins"+coins.ToString("000");
    }
}
