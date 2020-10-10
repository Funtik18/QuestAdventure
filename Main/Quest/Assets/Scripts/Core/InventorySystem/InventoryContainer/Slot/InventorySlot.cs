using QG.Help;
using UnityEngine;

namespace QG.InventorySystem {
	public class InventorySlot : MonoBehaviour {

		[HideInInspector] public Item currentItem;

		[HideInInspector] public InventorySlotDropPlace dropPlace;
		[HideInInspector] public InventorySlotIcon icon;

		public bool isEmpty { get { return currentItem == null; } }

		private void Awake() {
			dropPlace = GetComponentInChildren<InventorySlotDropPlace>();
			icon = GetComponentInChildren<InventorySlotIcon>();
		}

		public void SetItem(Item newItem) {
			currentItem = newItem;
			if (currentItem != null)
				icon.SetSprite(currentItem.itemIcon).ActiveView(true);
			else
				icon.ActiveView(false);
		}
	}
}