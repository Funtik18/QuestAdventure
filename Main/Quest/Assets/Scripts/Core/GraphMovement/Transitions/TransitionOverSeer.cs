using System.Collections.Generic;
using UnityEngine;

namespace QG {
	public class TransitionOverSeer : MonoBehaviour {
		public List<Transition> transitions;

		private Room mainRoom;

		private void Awake() {
			mainRoom = GetComponentInParent<Room>();
			if(mainRoom == null) {
				Debug.LogError("Current Transition doesn't have Room");
				return;
			}
			if (transitions.Count == 0) {
				Debug.LogError(mainRoom.roomName + " doesn't have transitions");
				return;
			}

			for (int i = 0; i < transitions.Count; i++) {
				transitions[i].onClick += ChangeRoom;
			}
		}

		private void ChangeRoom(Transition sender) {
			mainRoom.RoomSwitchEnable(false);
			sender.to.RoomSwitchEnable(true);
		}
	}
}