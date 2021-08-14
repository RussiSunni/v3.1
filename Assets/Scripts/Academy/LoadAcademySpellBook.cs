using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAcademySpellBook : MonoBehaviour
{
    public Transform player;
    public static Transform previousPlayerPosition;
    public void ChangeScene()
    {
        //previousPlayerPosition = player;
        SceneManager.LoadScene("AcademySpellBook");
    }
}
