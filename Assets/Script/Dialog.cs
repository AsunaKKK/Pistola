using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public GameObject ObjDialog;

    private void Start()
    {
        ObjDialog.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ObjDialog.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        //Destroy(ObjDialog);
        //Destroy(gameObject);
        if(other.tag == "Player")
        {
            ObjDialog.SetActive(false);
        }
       
    }

}
