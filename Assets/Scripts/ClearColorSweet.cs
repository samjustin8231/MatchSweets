using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearColorSweet : ClearedSweet {

    private ColorSweet.ColorType clearColor;

    public ColorSweet.ColorType ClearColor
    {
        get
        {
            return clearColor;
        }

        set
        {
            clearColor = value;
        }
    }

    public override void Clear()
    {
        base.Clear();
        sweet.gameManager.ClearColor(clearColor);
    }
}
