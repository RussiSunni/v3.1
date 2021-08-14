using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretarySubmitName : MonoBehaviour
{
    public void StoreName()
    {
        Progress.nameString = (Progress.nameArray[0] + Progress.nameArray[1] + Progress.nameArray[2] + Progress.nameArray[3] + Progress.nameArray[4]);
        SecretaryText.UpdateText();
        Progress.nameExerciseComplete = true;
    }
}
