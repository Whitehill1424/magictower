using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChickSearch : MonoBehaviour
{
    public Enemy enemy;

    public Text enemyname;
    public Text hp;
    public Text atk;
    public Text dfe;
    public Text agi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Collider2D[] col = Physics2D.OverlapPointAll(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if (col.Length > 0)
            {
                foreach (Collider2D c in col)
                {
                    Showenemy();
                }
            }
            
        }
    }
    public void Showenemy()
    {
        enemyname.text = enemy.objectName;
        hp.text = "Hp: " + enemy.hp;
        atk.text = "Atk: " + enemy.attack; ;
        dfe.text = "Dfe: " + enemy.dfense;
        agi.text = "Agi: " + enemy.agile;
    }
}
