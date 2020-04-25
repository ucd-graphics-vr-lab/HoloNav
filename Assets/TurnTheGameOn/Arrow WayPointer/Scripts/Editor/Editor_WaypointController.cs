using UnityEngine;
using System.Collections;
using UnityEditor;

namespace TurnTheGameOn.ArrowWaypointer{

	[CustomEditor(typeof(WaypointController))]
	public class Editor_WaypointController : Editor {

		[MenuItem("Tools/TurnTheGameOn/Waypoint Controller")]
		static void Create(){
			GameObject instance = Instantiate(Resources.Load("Waypoint Controller", typeof(GameObject))) as GameObject;
			instance.name = "Waypoint Controller";
			instance = null;
		}

		public override void OnInspectorGUI(){

			WaypointController waypointController = (WaypointController)target;
			Texture waypointTexture = Resources.Load("Arrow Waypointer") as Texture;
			GUIStyle inspectorStyle = new GUIStyle(GUI.skin.label);
			inspectorStyle.fixedWidth = 256;
			inspectorStyle.fixedHeight = 64;
			inspectorStyle.margin = new RectOffset((Screen.width-256)/2, (Screen.width-256)/2, 0, 0);

			EditorGUILayout.Space();
			GUILayout.Label(waypointTexture,inspectorStyle);

			if(!waypointController.player)	EditorGUILayout.HelpBox ("Assign the Player transform to use the waypoints radius value as a waypoint trigger.", MessageType.Info);
			if(waypointController.configureMode == WaypointController.Switch.On) EditorGUILayout.HelpBox ("Configure Mode is turned on, you must turn it off to complete configuration.", MessageType.Warning);

			EditorGUILayout.Space();


			if (GUILayout.Button ("Cleanup Old Wayponts")) {
				waypointController.CleanUpWaypoints ();
			}

			EditorGUILayout.Space();
			EditorGUILayout.Space();

			DrawDefaultInspector ();

			EditorUtility.SetDirty (waypointController);

		}
		
	}
}