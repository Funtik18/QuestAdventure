using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
    public class InventoryContainer : MonoBehaviour {
		private Inventory inventory;
		private List<Item> items { get { return inventory.items; } }

		private List<InventorySlot> slots;
		
		private void Awake() {
			if (inventory == null)
				inventory = GetComponentInParent<Inventory>();
			slots = GetComponentsInChildren<InventorySlot>().ToList();

			for (int i = 0; i < slots.Count; i++) {
				slots[i].onDropSlot = OnDropSlot;
			}
		}

		public void AddItem(Item item) {
			for (int i = 0; i < slots.Count; i++) {
				if (slots[i].isEmpty) {
					slots[i].SetItem(item);
					slots[i].EnableView(false);
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
	
		/// <summary>
		///	Вызывается когда предмет дропается на слот.
		/// </summary>
		/// <param name="slot"></param>
		/// <param name="eventData"></param>
		public void OnDropSlot(InventorySlot slot, PointerEventData eventData) {
			ItemModel model = eventData.selectedObject.GetComponent<ItemModel>();
			if (model == null) {
				Debug.LogError("Error HERE");
				return;
			}
			items.Add(model.item);
			slot.SetItem(model.item);
			slot.EnableView(false);


			DestroyImmediate(model.gameObject);
		}
	}
}