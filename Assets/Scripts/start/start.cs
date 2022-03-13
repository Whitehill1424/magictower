using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    void Update()
    {
        int Index = SceneManager.GetActiveScene().buildIndex;
        if (Input.anyKeyDown)
            SceneManager.LoadScene(Index+1);
//        Debug.Log("ssssss");
    }
}
