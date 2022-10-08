using PlayerScripts;
using UnityEditor;
using UnityEngine;

[CustomEditor((typeof(Controller2D)))]
public class Controller2DEditor : Editor
{
    private Controller2D controller;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        controller = (Controller2D) target;
        
        EditorGUILayout.Slider("Horizontal Ray Count", controller.horizontalRayCount, 1, 8);
    }
}
