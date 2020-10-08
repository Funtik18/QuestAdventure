using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QG.InventorySystem {
    public class InventoryContainer : MonoBehaviour {
        [SerializeField] private List<InventorySlot> slots;

		private void Awake() {
			if(slots.Count == 0) {
				slots = GetComponentsInChildren<InventorySlot>().ToList();
			}
		}
	}
}