using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject restartscreen;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void replay()
    {
        restartscreen.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void Restartbutton()
    {
        SceneManager.LoadScene(0);
    }
}
