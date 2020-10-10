using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QG {
	public class TransitionOverSeer : MonoBehaviour {
		private List<Transition> transitions;

		private Room mainRoom;

		private void Awake() {
			mainRoom = GetComponentInParent<Room>();
			if(mainRoom == null) {
				Debug.LogError("Current Transition doesn't have Room");
				return;
			}
			transitions = GetComponentsInChildren<Transition>().ToList();

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