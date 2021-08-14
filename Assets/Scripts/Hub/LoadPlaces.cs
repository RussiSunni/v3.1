using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPlaces : MonoBehaviour
{
    private string sceneName;

    public void LoadAcademy()
    {
        Scene scene = SceneManager.GetActiveScene();
        Progress.previousScene = scene.name;
        SceneManager.LoadScene("Outside Academy");
    }

    public void LoadForest()
    {
        SceneManager.LoadScene("Forest");
    }

    public void LoadTemple()
    {
        SceneManager.LoadScene("Temple");
    }

    public void LoadVillage()
    {
        SceneManager.LoadScene("Village");
    }

    public void LoadTown()
    {
        SceneManager.LoadScene("Town");
    }
}
