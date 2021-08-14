using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    Text results;
    int score, questionsCompleted;
    void Start()
    {
        // score = PlayerPrefs.GetInt("cat") + PlayerPrefs.GetInt("dog") + PlayerPrefs.GetInt("horse") + PlayerPrefs.GetInt("bear") + PlayerPrefs.GetInt("wolf") + PlayerPrefs.GetInt("zebra")
        //        + PlayerPrefs.GetInt("owl") + PlayerPrefs.GetInt("monkey") + PlayerPrefs.GetInt("squirrel") + PlayerPrefs.GetInt("giraffe") + PlayerPrefs.GetInt("lion")
        //        + PlayerPrefs.GetInt("alligator") + PlayerPrefs.GetInt("rhinoceros") + PlayerPrefs.GetInt("duck") + PlayerPrefs.GetInt("pig") + PlayerPrefs.GetInt("donkey")
        //        + PlayerPrefs.GetInt("rabbit") + PlayerPrefs.GetInt("frog") + PlayerPrefs.GetInt("tiger") + PlayerPrefs.GetInt("goat") + PlayerPrefs.GetInt("chicken") + PlayerPrefs.GetInt("Elephant");

        // results = GameObject.Find("Results").GetComponent<Text>();

        // questionsCompleted = 0;

        // for (int i = 0; i < AnimalNamesQuestionBank.questions.Count; i++)
        // {
        //     if (AnimalNamesQuestionBank.questions[i].answered)
        //     {
        //         questionsCompleted++;
        //     }
        // }

        // results.text = score + " / " + questionsCompleted;
    }

    public void Save()
    {
        GameControl.control.Save();
    }
    public void Resume()
    {
        SceneManager.LoadScene("Scene001");
    }
    public void Quit()
    {
        Application.Quit();
    }

    // void OnGUI()
    // {
    //     GUI.Label(new Rect(10, 40, 100, 30), "Name: " + GameControl.control.playerName);
    //     GUI.Label(new Rect(10, 70, 200, 30), "animal q1 known: " + GameControl.animal001known);
    //     GUI.Label(new Rect(10, 100, 200, 30), "animal q1 known: " + GameControl.animal002known);
    //     GUI.Label(new Rect(10, 130, 200, 30), "animal q1 known: " + GameControl.animal003known);
    //     GUI.Label(new Rect(10, 160, 200, 30), "animal q1 known: " + GameControl.animal004known);
    //     GUI.Label(new Rect(10, 190, 200, 30), "animal q1 known: " + GameControl.animal005known);
    //     GUI.Label(new Rect(10, 220, 200, 30), "animal q1 known: " + GameControl.animal006known);
    //     GUI.Label(new Rect(10, 250, 200, 30), "animal q1 known: " + GameControl.animal007known);
    //     GUI.Label(new Rect(10, 280, 200, 30), "animal q1 known: " + GameControl.animal008known);
    //     GUI.Label(new Rect(10, 310, 200, 30), "animal q1 known: " + GameControl.animal009known);
    //     GUI.Label(new Rect(10, 340, 200, 30), "animal q1 known: " + GameControl.animal010known);
    // }
}