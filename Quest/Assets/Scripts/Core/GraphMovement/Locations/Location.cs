using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QG {
	public class Location : MonoBehaviour {

		[SerializeField] private int startIndex = 0;
		private Room currentRoom;

		//[SerializeField] private Room startRoom;

		List<Room> rooms;

		private void Awake() {
			rooms = GetComponentsInChildren<Room>().ToList();

			ActiveRooms(false);


			rooms[startIndex % rooms.Count].ActiveRoom(true);
		}

		private void ActiveRooms(bool triger) {
			for (int i = 0; i < rooms.Count; i++) {
				rooms[i].ActiveRoom(triger);
			}
		}


	}
}