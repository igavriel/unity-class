using UnityEngine;

public class ObjectCollectorCarrot : ObjectCollector
{
    protected override void CollectObject()
    {
        Debug.Log("Carrot collected!");
        CanvasControl.Instance.CollectCarrot();
    }
}
