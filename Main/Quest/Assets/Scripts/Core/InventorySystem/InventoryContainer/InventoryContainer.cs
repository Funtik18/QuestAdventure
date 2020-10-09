using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace QG.InventorySystem {
    public class InventoryContainer : MonoBehaviour {
        [SerializeField] private List<InventorySlot> slots;

		private Inventory inventory;
		[HideInInspector] private List<Item> items { get { return inventory.items; } }
		private void Awake() {
			if (inventory == null)
				inventory = GetComponentInParent<Inventory>();
			if (slots.Count == 0) {
				slots = GetComponentsInChildren<InventorySlot>().ToList();
			}
		}

		public void AddItem(Item item) {
			for (int i = 0; i < slots.Count; i++) {
				if (slots[i].isEmpty) {
					slots[i].SetItem(item);
					return;
				}
			}
			Debug.LogError("Inventory Full");
		}

		public void RefreshContainer() {
			ClearContainer();
			for (int i = 0; i < items.Count; i++) {
				AddItem(items[i]);
			}
		}
		private void ClearContainer() {
			for (int i = 0; i < slots.Count; i++) {
				slots[i].SetItem(null);
			}
		}
	}
}