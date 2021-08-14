using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyFamilyNext : MonoBehaviour
{
    public static int questionNumber = 1;

    public void ChangeQuestion()
    {
        questionNumber++;
    }
}
