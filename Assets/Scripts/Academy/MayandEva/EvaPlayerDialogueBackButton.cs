using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaPlayerDialogueBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        EvaPlayerDialogue.DisplayDialogueOff();
        EvaDialogue.DisplayDialogue();

        Hi_UI.ReturnToInitialPosition();
        Eva_UI.ReturnToInitialPosition();
    }
}
