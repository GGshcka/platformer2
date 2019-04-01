#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(EnemyAI_))]

public class EnemyAIEditor : Editor
{

    public GameObject waypoint; // префаб вейпоинта

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EnemyAI_ t = (EnemyAI_)target;
        if (GUILayout.Button("Generate Waypoints"))
        {
            t.GenerateWaypoints(waypoint);
        }
    }
}
#endif
