using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public GameObject actdoor;
    public GameObject blockdoor;
    public player me;
    Animator animator;
    string animationState = "openstate";

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"&&actdoor.tag == "YWdoor")
        {
            if (me.yellowkey.value>0)
            {
                me.yellowkey.value = me.yellowkey.value - 1;
                animator.SetInteger(animationState, 1);
                Invoke("disappear", 1.0f);
            }
        }
    }
    private void disappear()
    {
        actdoor.SetActive(false);
        blockdoor.SetActive(false);
    }
}
