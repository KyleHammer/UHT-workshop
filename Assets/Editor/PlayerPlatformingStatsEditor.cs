using BaseScriptableObjects;
using UnityEditor;
using UnityEngine;

[CustomEditor((typeof(PlayerPlatformingStats)))]
public class PlayerPlatformingStatsEditor : Editor
{
    private PlayerPlatformingStats stats;
    
    private void Awake()
    {
        stats = (PlayerPlatformingStats) target;
    }

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        
        EditorGUILayout.Slider("Max Jump Height", stats.maxJumpHeight, 1f, 8f);
        EditorGUILayout.Slider("Min Jump Height",stats.minJumpHeight, .1f, 4f);
        EditorGUILayout.Slider("Time to Jump Apex",stats.timeToJumpApex, .1f, 2f);
        EditorGUILayout.Slider("Acceleration Time Airborne",stats.accelerationTimeAirborne, .01f, 1f);
        EditorGUILayout.Slider("Acceleration Time Grounded",stats.accelerationTimeGrounded, .01f, 1f);
        EditorGUILayout.Slider("Move Speed",stats.moveSpeed, 1f, 20f);
        
        GUILayout.Space(14f);
        
        GUILayout.Label("WARNING: Will reset your stats");
        if(GUILayout.Button(("Reset Stats")))
        {
            stats.ResetStats();
        }
    }
}
