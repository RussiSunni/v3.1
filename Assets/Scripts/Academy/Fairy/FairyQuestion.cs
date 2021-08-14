using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite question27;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question27 = Resources.Load<Sprite>("academy/old-book-sprite");
    }

    // Update is called once per frame
    void Update()
    {
        if (FairyNext.questionNumber == 0)
        {
        }
        else if (FairyNext.questionNumber == 2)
        {
        }
        else if (FairyNext.questionNumber == 4)
        {
        }
        else if (FairyNext.questionNumber == 6)
        {
        }
        else if (FairyNext.questionNumber == 8)
        {
        }
        else if (FairyNext.questionNumber == 27)
        {
            rend.sprite = question27;
            Progress.lettersExerciseComplete = true;
        }
    }
}
