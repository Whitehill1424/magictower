using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movefloor : MonoBehaviour
{
    public GameObject gofloor;
    public GameObject me;
    private int sceneNumber;
    bool goifup;
    bool goifdown;

    void Start()
    {
        goifup = false;
        goifdown = false;
        sceneNumber = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        if (Input.GetKeyDown("space")&&goifup == true)
        {
            goifup = false;
            SceneManager.LoadScene(sceneNumber + 1);
        }
        else if (Input.GetKeyDown("space") && goifdown == true)
        {
            goifdown = false;
            SceneManager.LoadScene(sceneNumber - 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gofloor.tag == "upfloor")
        {
            if (sceneNumber == 1)
            {
                float x = -3.5f;//不能超出grid边界
                float y = -4.5f;//注明f，不然被认作double
                me.transform.position = new Vector3(x, y, 0);
                SceneManager.LoadScene(sceneNumber + 1);
            }
            else goifup = true;
        }
        if (collision.tag == "Player" && gofloor.tag == "downfloor")
        {
            if (sceneNumber > 2)
            {
                goifdown = true;
            }
        }
    }
}
