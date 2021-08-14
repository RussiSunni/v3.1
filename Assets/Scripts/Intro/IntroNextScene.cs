using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroNextScene : MonoBehaviour
{
    public static int numberPresses = 0;

    public void ChangeScene()
    {
        numberPresses++;
        Debug.Log("test");

        if (numberPresses == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
