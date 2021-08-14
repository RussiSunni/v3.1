using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseCharacter : MonoBehaviour
{
    public void ChooseCharacter1()
    {
        Progress.playerCharacter = "English";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ChooseCharacter2()
    {
        Progress.playerCharacter = "Japanese";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ChooseCharacter3()
    {
        Progress.playerCharacter = "North African";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ChooseCharacter4()
    {
        Progress.playerCharacter = "South African";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
