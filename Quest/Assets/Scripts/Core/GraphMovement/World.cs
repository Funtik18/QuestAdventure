using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;

namespace QG {
    public class World : MonoBehaviour {

        [HideInInspector] public Location[] locations;

        [Tooltip("Номер стартовой локации.")]
        public int startLocation = 0;
        [HideInInspector] public int currentLocation = 0;
        public int CurrentLocation {
            get { return currentLocation; }
            set {
                if (value != currentLocation) {
                   /* if (value < minLocation)
                        currentRoom = minLocation;
                    else if (value > maxLocation)
                        currentRoom = maxLocation;
                    else
                        currentRoom = value;
                    UpdateLocation();*/
                }
            }
        }
        [HideInInspector] public int minLocation = 0;
        [HideInInspector] public int maxLocation { get { return locations.Length - 1; } }


        [Tooltip("Номер стартовой комнаты.")]
        public int startRoom = 0;
        [HideInInspector] public int currentRoom = 0;
        public int CurrentRoom {
            get { return currentRoom; }
            set {
                if (value != currentRoom) {
                    if (value < minRoom)
                        currentRoom = minRoom;
                    else if (value > maxRoom)
                        currentRoom = maxRoom;
                    else
                        currentRoom = value;
                    UpdateRoom();
                }
            }
        }

        [HideInInspector] public int minRoom = 0; 
        [HideInInspector] public int maxRoom { get { return locations[currentLocation].rooms.Length-1; } }


		private void Awake() {
            if (locations.Length == 0)
                Init();
		}

		public void Init() {
            locations = GetComponentsInChildren<Location>();
			for (int i = 0; i < locations.Length; i++) {
                locations[i].Init();
            }
        }


        public void UpdateLocation() {
            
        }
        public void UpdateRoom() {
            Room[] rooms = locations[currentLocation].rooms;

			for (int i = 0; i < rooms.Length; i++) {
                rooms[i].ActiveRoom(false);
            }
            rooms[currentRoom].ActiveRoom(true);
		}
    }
}