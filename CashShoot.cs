using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashShoot : MonoBehaviour
{
    public float cashSpeed = 500f;
    public GameObject cash;

    List<GameObject> cashList;

    // Start is called before the first frame update
    void Start()
    {
        cashList = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            GameObject ObjCash = (GameObject)Instantiate(cash);
            ObjCash.SetActive(false);
            cashList.Add(ObjCash);
        }
    }

    void Fire()
    {
        for (int i = 0; i < cashList.Count; i++)
        {
            if (!cashList[i].activeInHierarchy)
            {
                cashList[i].transform.position = transform.position;
                cashList[i].transform.rotation = transform.rotation;
                cashList[i].SetActive(true);
                Rigidbody tempRb = cashList[i].GetComponent<Rigidbody>();
                tempRb.AddForce(cashList[i].transform.forward * cashSpeed);
                break;
            }
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
