using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public GameObject actdoor;
    public player me;
    Animator animator;
    string animationState = "openstate";

    bool together;
    int canOpen;

    private void Start()
    {
        together = false;
        canOpen = 0;
        animator = GetComponent<Animator>();
    }
 
    void Update()
    {
        if (Input.GetKeyDown("space") && together == true)
            OpenDoor();
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"&&actdoor.tag == "YWdoor")
        {
            together = true;
            canOpen = 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        together = false;
        canOpen = 0;
    }

    private void disappear()
    {
        actdoor.SetActive(false);
        together = false;
        canOpen = 0;
    }

    private void OpenDoor()
    {
        if (me.yellowkey.value > 0 && canOpen == 1)
        {
            me.yellowkey.value = me.yellowkey.value - 1;
            animator.SetInteger(animationState, 1);
            Invoke("disappear", 1.0f);
        }
    }
}
