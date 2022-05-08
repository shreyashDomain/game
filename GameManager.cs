using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

     


public class GameManager : MonoBehaviour
{
    public TMP_Text Counter;
    public int moneyValue;
   
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        moneyValue = 0;
     }

    // Update is called once per frame
    void Update()
    {
        Counter.text =  moneyValue + " ";
       
    }

    public void moneyshow(int moneyV)
    {      
        moneyValue = moneyValue + moneyV;
    }

    

}
