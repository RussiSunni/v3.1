using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmotionSystem : MonoBehaviour
{
    private Sprite image1, image2, image3, image4;
    private Image imageComponent;
    GameObject panel;

    public float targetTime = 5.0f;

    void Start()
    {
        image1 = Resources.Load<Sprite>("Global/EmotionSystem/North African happy");
        image2 = Resources.Load<Sprite>("Global/EmotionSystem/North African neutral");
        image3 = Resources.Load<Sprite>("Global/EmotionSystem/North African angry");
        image4 = Resources.Load<Sprite>("Global/EmotionSystem/North African sad");

        imageComponent = this.GetComponent<Image>();

        panel = GameObject.FindWithTag("gameOver");
        panel.SetActive(false);
    }

    void Update()
    {
        if (Progress.emotion == 1)
            imageComponent.sprite = image1;

        else if (Progress.emotion == 2)
            imageComponent.sprite = image2;

        else if (Progress.emotion == 3)
            imageComponent.sprite = image3;

        else if (Progress.emotion == 4)
            imageComponent.sprite = image4;

        else if (Progress.emotion > 4)
        {
            panel.SetActive(true);
            targetTime -= Time.deltaTime;
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
    }

    void timerEnded()
    {
        Application.Quit();
    }
}







