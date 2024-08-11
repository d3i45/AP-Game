using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public charactercontroller2D controller;
    public Animator anim;

    float horizantalMove = 0f;

    public float runspeed = 40f;
    bool jump = false;

    public door door;
    public GameObject textE;
    public GameObject textEE;
    public GameObject textD;
    public float WaitTimeis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(dialogManager.isActive == true)
            return;
   
   
        horizantalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        anim.SetFloat("Speed", Mathf.Abs(horizantalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true; 
            anim.SetBool("Jump", true);
            Destroy(textE.gameObject);
            textEE.SetActive(true);
        }
        if(horizantalMove > 0.1)
        {
            StartCoroutine(WaitAndExecute());
        }
    }

    public void onLand()
    {
        anim.SetBool("Jump", false);
    }

    void FixedUpdate ()
    {
        controller.Move(horizantalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
    public void CollectGem()
    {
        door.collectedGems++;
        Debug.Log("Total Gems: " + door.collectedGems);
    }
        private IEnumerator WaitAndExecute()
    {
        yield return new WaitForSeconds(WaitTimeis);
        textE.SetActive(true);
        textD.SetActive(false);
    }
}
