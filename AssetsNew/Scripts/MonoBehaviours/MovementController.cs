using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float movementSpeed;
    Vector2 movement = new Vector2();
    Animator animator;
    string animationState = "AnimatorState";
    Rigidbody2D rb2D;
    enum CharStates
    {
        walkright = 1,
        walkdown = 2,
        walkleft = 3,
        walkup = 4
        
    }
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        MoveCharacter();
        UpdateState();
    }
    void FixedUpdate()
    {

    }
    private void MoveCharacter()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();
        rb2D.velocity = movement * movementSpeed;
    }
    private void UpdateState()
    {
        if(movement.x > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkright);
        }
        else if(movement.x < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkleft);
        }
        else if (movement.y > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkup);
        }
        else if (movement.y < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkdown);
        }
    }
}
