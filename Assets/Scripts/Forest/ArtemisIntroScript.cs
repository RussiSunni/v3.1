using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArtemisIntroScript : MonoBehaviour
{
    public static int numClicks;
    GameObject artemisExerciseArea;

    void Start()
    {
        numClicks = 0;
        artemisExerciseArea = GameObject.Find("ArtemisExerciseArea");
    }

    public void ChangeScene()
    {
        numClicks++;

        if (numClicks == 1)
        {
            artemisExerciseArea.SetActive(false);
            ArtemisIntroSpriteScript.secondClick = true;
        }

        if (numClicks == 2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}



