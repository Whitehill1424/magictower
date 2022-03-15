using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMovement : MonoBehaviour
{
    Vector2 moveDir;
    public LayerMask detectLayer;

    Animator animator;
    string animationState = "AnimatorState";

    enum CharStates
    {
        walkright = 1,
        walkdown = 2,
        walkleft = 3,
        walkup = 4

    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            moveDir = Vector2.right;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            moveDir = Vector2.left;
        if (Input.GetKeyDown(KeyCode.UpArrow))
            moveDir = Vector2.up;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            moveDir = Vector2.down;
        if(moveDir != Vector2.zero)
        {
            UpdateState();
            if (CanMoveToDir(moveDir))
            {
                Move(moveDir);
            }
        }
        moveDir = Vector2.zero;
    }

    bool CanMoveToDir(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 1.0f, detectLayer);
        if (!hit) return true;
        return false;
    }
    void Move(Vector2 dir)
    {
        transform.Translate(dir);
    }
    private void UpdateState()
    {

        if (moveDir.x > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkright);
        }
        else if (moveDir.x < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkleft);
        }
        else if (moveDir.y > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkup);
        }
        else if (moveDir.y < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkdown);
        }
    }
}
