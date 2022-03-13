using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Battle : MonoBehaviour
{
    public GameObject act;
    public GameObject block;
    public playerData me;
    public Enemy enemy;
    Animator animator;
    string animationState = "boomb";

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && act.tag == "enemy")
        {
            bool win = false;
            win = battlenum();
            if (win)
            {
                animator.SetInteger(animationState, 1);
                Invoke("disappear", 0.8f);
            }
            else if(!win)
            {
                print("you lose");
                Invoke("loser", 1.0f);
                
            }
        }
    }

    private void disappear()
    {
        act.SetActive(false);
        block.SetActive(false);
    }
    private bool battlenum()
    {
        int pa = me.attack.value;
        int pd = me.dfense.value;
        int ea = enemy.attack;
        int ed = enemy.dfense;
        int hp = enemy.hp;
        if (pa == ed) pa++;
        if (ea == pd) ea++;
        while (me.hitPoints.value >0 && hp >0)
        {
            hp -= (pa-ed);
            if (hp <= 0) return true;
            me.hitPoints.value -= (ea-pd);
            if (me.hitPoints.value <= 0) return false;
        }
        return false;
    }
    public void loser()
    {
        SceneManager.LoadScene("SceneOver");
    }
}
