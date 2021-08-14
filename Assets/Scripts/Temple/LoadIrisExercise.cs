using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIrisExercise : MonoBehaviour
{
    // collision
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("IrisExercise");
    }
}





