using UnityEngine;
using UnityEngine.UI;

namespace QG.Editor {
    using UnityEditor;
    using UnityEditorInternal;
    [CustomEditor(typeof(World))]
    public class WorldEditor : Editor {

        World world;

        private SerializedProperty startLocation;
        private SerializedProperty startRoom;

        private void OnEnable() {
            world = target as World;
            world.Init();

            startLocation = serializedObject.FindProperty("startLocation");
            startRoom = serializedObject.FindProperty("startRoom");
        }


		public override void OnInspectorGUI() {
            base.OnInspectorGUI();

            serializedObject.Update();

			if (startLocation.intValue < 0) {
                world.startLocation = 0;
            }
            if (startLocation.intValue > world.maxLocation) {
                world.startLocation = world.maxLocation;
            }

            if (startRoom.intValue < 0) {
                world.startRoom = 0;
            }
            if (startRoom.intValue > world.maxRoom) {
                world.startRoom = world.maxRoom;
            }

            DrawNavigationLocationPanel();
            DrawNavigationRoomPanel();

        }

        private void DrawNavigationLocationPanel() {
            GUILayout.Label(new GUIContent("Current Location"));

#if UNITY_5_3_OR_NEWER
            EditorGUILayout.BeginHorizontal(EditorStyles.helpBox);
#else
        EditorGUILayout.BeginHorizontal(EditorStyles.textArea);
#endif
            if (GUILayout.Button("|<")) {
                world.CurrentLocation = 0;
            }
            if (GUILayout.Button("<")) {
                world.CurrentLocation--;
            }
            GUILayout.Label(new GUIContent(world.CurrentLocation.ToString()));
            EditorUtility.SetDirty(world);
            if (GUILayout.Button(">")) {
                world.CurrentLocation++;
            }
            if (GUILayout.Button(">|")) {
                world.CurrentLocation = world.maxLocation;
            }
            EditorGUILayout.EndHorizontal();
        }

        private void DrawNavigationRoomPanel() {
            GUILayout.Label(new GUIContent("Current Room"));
#if UNITY_5_3_OR_NEWER
            EditorGUILayout.BeginHorizontal(EditorStyles.helpBox);
#else
        EditorGUILayout.BeginHorizontal(EditorStyles.textArea);
#endif
            if (GUILayout.Button("|<")) {
                world.CurrentRoom = 0;
            }
            if (GUILayout.Button("<")) {
                world.CurrentRoom--;
            }
            GUILayout.Label(new GUIContent(world.CurrentRoom.ToString()));
            EditorUtility.SetDirty(world);
            //Undo.RecordObject(world, "CurrentWorldChange");
            if (GUILayout.Button(">")) {
                world.CurrentRoom++;
            }
            if (GUILayout.Button(">|")) {
                world.CurrentRoom = world.maxRoom;
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}