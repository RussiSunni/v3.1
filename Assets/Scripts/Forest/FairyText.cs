using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FairyText : MonoBehaviour
{
    // Start is called before the first frame update

    Text fairyText;

    public static bool newBlock;

    void Start()
    {
        fairyText = GetComponent<Text>();
        newBlock = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.textNumber == 0)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 1)
        {
            fairyText.text = "Ok, she said something about knowing the animal's names.";

            if (newBlock)
            {
                fairyText.text = "You got a new block!";
            }
        }
        else if (TestExerciseNext.textNumber == 2)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 3)
        {
            fairyText.text = "Hmmm, she referred to him as 'Sir Barksalot'. Maybe that is a clue.";
            if (newBlock)
            {
                fairyText.text = "You got a new block!";
            }
        }
        else if (TestExerciseNext.textNumber == 4)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 5)
        {
            fairyText.text = "I dont give a hoot!";

            if (newBlock)
            {
                fairyText.text = "You got a new block!";
            }
        }
        else if (TestExerciseNext.textNumber == 6)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 7)
        {
            fairyText.text = "I can't bear to watch!";

            if (newBlock)
            {
                fairyText.text = "You got a new block!";
            }
        }
        else if (TestExerciseNext.textNumber == 8)
        {
            fairyText.text = "";
        }
        else if (TestExerciseNext.textNumber == 9)
        {
            fairyText.text = "Wait, isn't this a dog?";

            if (newBlock)
            {
                fairyText.text = "You got a new block!";
            }
        }
        else if (TestExerciseNext.textNumber == 99)
        {
            fairyText.text = "Wait, isnt it 'dog'?";
        }
    }
}
