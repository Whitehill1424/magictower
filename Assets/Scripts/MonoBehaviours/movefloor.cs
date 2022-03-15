using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movefloor : MonoBehaviour
{
    public GameObject Father;
    public GameObject nowF;
    public GameObject nextF;
    public GameObject me;
    public GameObject gofloor;
    //private int sceneNumber;
    int level;
    bool goifup;
    bool goifdown;

    void Start()
    {
        goifup = false;
        goifdown = false;
        level = ifActive();
        //Father = GameObject.Find("FloorTotal");
        //sceneNumber = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
    {
        if (Input.GetKeyDown("space")&&goifup == true)
        {
            goifup = false;
            //SceneManager.LoadScene(sceneNumber + 1,LoadSceneMode.Additive);
            goupfloor();
        }
        else if (Input.GetKeyDown("space") && goifdown == true)
        {
            goifdown = false;
            //SceneManager.LoadScene(sceneNumber - 1,LoadSceneMode.Additive);
            godownfloor();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gofloor.tag == "upfloor")
        {
            //if (sceneNumber == 1)
            if(level==1)
            {
                //float x = -3.5f;//不能超出grid边界
                //float y = -4.5f;//注明f，不然被认作double
                //me.transform.position = new Vector3(x, y, 0);
                //SceneManager.LoadScene(sceneNumber + 1);
                goifup = true;
            }
            else goifup = true;
        }
        if (collision.tag == "Player" && gofloor.tag == "downfloor")
        {
            //if (sceneNumber >= 2)
            if (level >= 2)
            {
                goifdown = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        goifup = false;
        goifdown = false;                   
    }
    private void goupfloor()
    {
        if (level == 1)
        {
            float x = -3.5f;//不能超出grid边界
            float y = -4.5f;//注明f，不然被认作double
            me.transform.position = new Vector3(x, y, 0);
            nowF = GameObject.Find("Floor1");
            nextF = Father.transform.Find("Floor2").gameObject;
            nowF.SetActive(false);
            nextF.SetActive(true);
        }
    }
    private void godownfloor()
    {
        if (level == 2)
        {
            float x = 0.5f;//不能超出grid边界
            float y = 2.5f;//注明f，不然被认作double
            me.transform.position = new Vector3(x, y, 0);
            nowF = GameObject.Find("Floor2");
            nextF = Father.transform.Find("Floor1").gameObject;
            nowF.SetActive(false);
            nextF.SetActive(true);
        }
    }
    private int ifActive()
    {
        if (Father.transform.Find("Floor1").gameObject.activeSelf == true) return 1;
        else if (Father.transform.Find("Floor2").gameObject.activeSelf == true) return 2;
        return 0;
    }
}
