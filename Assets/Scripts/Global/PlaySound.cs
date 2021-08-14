using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySound : MonoBehaviour
{
    private string sceneName;
    private void OnMouseDown()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "HelloExercise")
        {
            SoundManagerScript.playHELLOWordSound();
        }

        else if (scene.name == "SecretaryExercise")
        {
            SoundManagerScript.playWHAT_IS_YOUR_NAME_Sound();
        }
    }
}
