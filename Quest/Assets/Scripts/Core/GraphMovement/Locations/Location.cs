using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QG {
	public class Location : MonoBehaviour {

		private World world;

		private Room currentRoom;
		[HideInInspector] public Room[] rooms;


		private void Awake() {
			rooms = GetComponentsInChildren<Room>();

			world = GetComponentInParent<World>();
			ActiveRooms(false);
			rooms[world.startRoom].ActiveRoom(true);
		}

		public void Init() {
			rooms = GetComponentsInChildren<Room>();
		}


		private void ActiveRooms(bool triger) {
			for (int i = 0; i < rooms.Length; i++) {
				rooms[i].ActiveRoom(triger);
			}
		}


	}
}