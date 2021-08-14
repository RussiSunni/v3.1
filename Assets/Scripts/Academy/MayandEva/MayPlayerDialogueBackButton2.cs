using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayPlayerDialogueBackButton2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        MayPlayerDialogue2.DisplayDialogueOff();
        MayDialogue2.DisplayDialogue();
    }
}
