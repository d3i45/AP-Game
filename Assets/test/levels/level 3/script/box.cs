using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject canvase;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            canvase.SetActive(true);
        }
    }
    public void back()
    {
        canvase.SetActive(false);
    }
}
