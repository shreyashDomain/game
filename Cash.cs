using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cash : MonoBehaviour
{
    private void OnEnable()
    {
        transform.GetComponent<Rigidbody>().WakeUp();
        Invoke("hideCash",0.5f);
    }

    void hideCash()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        transform.GetComponent<Rigidbody>().Sleep();
        CancelInvoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Money")
        {
            Invoke("hideCash",0f);
        }
    }

}
