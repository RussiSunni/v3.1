using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyPlayerDialogueBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        FairyPlayerDialogue.DisplayDialogueOff();
        FairyDialogue.DisplayDialogue();

        Hello_UI.ReturnToInitialPosition();
    }
}
