using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuePlayerDialogueBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        SuePlayerDialogue.DisplayDialogueOff();
        SueDialogue.DisplayDialogue();

        Hello_UI.ReturnToInitialPosition();
        Sue_UI.ReturnToInitialPosition();
    }
}
