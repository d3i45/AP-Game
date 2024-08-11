using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorarm : MonoBehaviour
{
    public bool sun = true;
    public bool Moon = false;
    public bool flower = false;

    public GameObject Left; 
    public GameObject center;
    public GameObject Right;
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.E) && sun)
        {
          Moon = true;
            Left.SetActive(true);
            center.SetActive(false);
          sun = false;
          return;  
        }
      if(Input.GetKeyDown(KeyCode.E) && Moon)
        {
          flower = true;
            Left.SetActive(false);
            Right.SetActive(true);
          Moon = false;
          return;  
        }
      if(Input.GetKeyDown(KeyCode.E) && flower)
        {
          sun = true;
            Right.SetActive(false);
            center.SetActive(true);
          flower = false;  
          return;
        }
    }
}
