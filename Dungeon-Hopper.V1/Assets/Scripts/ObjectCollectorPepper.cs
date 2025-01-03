using UnityEngine;

public class ObjectCollectorPepper : ObjectCollector
{
    protected override void CollectObject()
    {
        Debug.Log("Pepper collected!");
        CanvasControl.Instance.CollectPepper();
    }
}
