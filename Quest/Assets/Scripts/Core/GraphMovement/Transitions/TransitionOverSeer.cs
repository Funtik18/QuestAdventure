using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QG {
	public class TransitionOverSeer : MonoBehaviour {
		private List<Transition> transitions;

		private Room rootRoom;

		private void Awake() {
			rootRoom = GetComponentInParent<Room>();
			if(rootRoom == null) {
				Debug.LogError("Current Transition doesn't have root Room");
				return;
			}
			transitions = GetComponentsInChildren<Transition>().ToList();

			for (int i = 0; i < transitions.Count; i++) {
				transitions[i].onClick += ChangeRoom;
			}
		}

		private void ChangeRoom(Transition sender) {
			rootRoom.ActiveRoom(false);
			sender.to.ActiveRoom(true);
		}
	}
}