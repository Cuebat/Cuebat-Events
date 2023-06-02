using UnityEngine;
using UnityEditor;
using Cuebat.Events;

namespace CuebatEditor.Events
{
    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Activate Event"))
            {
                ((GameEvent)target).Raise();
            }
        }

    }
}
