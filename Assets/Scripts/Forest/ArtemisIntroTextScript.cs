using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtemisIntroTextScript : MonoBehaviour
{
    Text artemisIntroText;

    void Start()
    {
        artemisIntroText = GetComponent<Text>();
        artemisIntroText.text = "You want to speak with me? \n \r \n \r  Come back when you know the names of my friends.";
    }

    // Update is called once per frame
    void Update()
    {
        if (ArtemisIntroScript.numClicks == 1)
        {
            artemisIntroText.text = "You will face my animals. There is only way to pacify them: to call them by name";
        }
    }
}
