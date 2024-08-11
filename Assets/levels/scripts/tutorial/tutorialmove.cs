using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialmove : MonoBehaviour
{
    public GameObject textE;
    public GameObject textD;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            textE.SetActive(true);
            textD.SetActive(false);
        }
    }
}
