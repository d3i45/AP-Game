using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connecter : MonoBehaviour
{
    public GameObject GameObjectE;
    public GameObject GameObjectD;
    public GameObject GameObjectDD;
    public GameObject TextE;
    bool EE = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            TextE.SetActive(true);
            EE =true;
        }

    }
    void Update()
    {
        if(EE)
        {
          if (Input.GetKeyUp(KeyCode.E))
            {
                GameObjectD.SetActive(false);
                GameObjectDD.SetActive(false);
                GameObjectE.SetActive(true);
            }
        }    
    }
}
