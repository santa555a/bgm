using UnityEngine;

public class Utilities
{
    public static void CreateVectorGameObjectAt(Vector3 startPosition,Vector3 direction,float magnitude,float showTime)
    {
        GameObject go = new GameObject();
        go.name = "GizmosVector";
        DrawVectorGizmos dvg = go.AddComponent<DrawVectorGizmos>();
        dvg.StartPosition = startPosition;
        dvg.Direction = direction;
        dvg.LineColor = Color.red;
        dvg.Length = magnitude;
        GameObject.Destroy(go, showTime);
    }
}
