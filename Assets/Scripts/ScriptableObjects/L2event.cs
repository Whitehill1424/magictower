using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2event : MonoBehaviour
{
    public GameObject dialog;
    public GameObject eventblock;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            dialog.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            dialog.SetActive(false);
            eventblock.SetActive(false);
        }
    }
}
