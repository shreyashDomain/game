using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{   
    public TMP_Text text;
    public int money;
    public int moneyTemp;
    public int moneyNew;
    public GameManager gameManager;
    
    
    private void Awake()
    {
        text.color = Color.green;
        moneyTemp = Random.Range(1, 50);
       
       
    }

    void Start()
    {
        money = moneyTemp;
        moneyTemp = moneyNew;
        moneyNew = money;
    }

    // Update is called once per frame
    void Update()
    {    
        text.text = money + "$";     

        if (money == 0)
        {
            gameManager.moneyshow(moneyNew);
            Destroy(gameObject);
        }       
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Cash")
        {
            StartCoroutine(WaitTwoSeconds());
            money = money - 1;
        }
        
    }

   public IEnumerator WaitTwoSeconds()
   {
        text.color = Color.white;
        yield return new WaitForSeconds(0.5f);
        text.color = Color.green;
    }
}
