using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPanel : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static DraggableBlock d;

    void Start()
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    public void OnDrop(PointerEventData eventData)
    {
        d = eventData.pointerDrag.GetComponent<DraggableBlock>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }
    }
}
