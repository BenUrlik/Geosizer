using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class toolTipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private static LTDescr delay;
    public string header;
    public string content;
    

    public void OnPointerEnter(PointerEventData eventData) {
        delay = LeanTween.delayedCall(0.5f, () => {
            toolTipSystem.show(content, header);
        });
    }

    public void OnPointerExit(PointerEventData eventData) {
        LeanTween.cancel(delay.uniqueId);
        toolTipSystem.hide();
    }
}
