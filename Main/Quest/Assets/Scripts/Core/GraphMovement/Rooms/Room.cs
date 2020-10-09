using QG.Help;
using UnityEngine;

namespace QG {
	[RequireComponent(typeof(CanvasGroup))]
    public class Room : MonoBehaviour {
		public string roomName;

		private CanvasGroup canvasGroup;

		private void Awake() {
			canvasGroup = GetComponent<CanvasGroup>();
		}
		public void RoomSwitchEnable(bool triger = false) {
			CanvasGroupHelper.ActiveGameObject(canvasGroup, triger);
		}
	}
}