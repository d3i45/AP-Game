using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class armdoor : MonoBehaviour
{
    public doorarm doorarm;
 
    private void OnTriggerEnter2D(Collider2D other) 
    {
      if(other.CompareTag("Player") && doorarm.sun)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
      if(other.CompareTag("Player") && doorarm.Moon)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
      if(other.CompareTag("Player") && doorarm.flower)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    } 
}
