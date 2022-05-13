using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolTipSystem : MonoBehaviour
{
    private static toolTipSystem current;

    public toolTip tooltip;

    public void Awake() {
        current = this;
    }

    public static void show(string content, string header = "") {
        current.tooltip.setText(content, header);
        current.tooltip.gameObject.SetActive(true);
    }

    public static void hide() {
        current.tooltip.gameObject.SetActive(false);
    }
}
