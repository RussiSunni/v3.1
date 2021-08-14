using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadHub : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Hub");
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("Hub");
    }
}







