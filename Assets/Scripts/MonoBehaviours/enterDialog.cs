using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterDialog : MonoBehaviour
{
    public GameObject enterdialog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enterdialog.SetActive(true);
            //Hptips.SetActive(true);
            Invoke("disappear", 3.0f);
        }
    }
    private void disappear()
    {
        enterdialog.SetActive(false);
    }
}
