using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadArtemisExercise : MonoBehaviour
{
    // collision
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("ArtemisHello");
    }
}





