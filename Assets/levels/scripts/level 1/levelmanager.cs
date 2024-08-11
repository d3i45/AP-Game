using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{
    public int level = 1;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    } 
}
