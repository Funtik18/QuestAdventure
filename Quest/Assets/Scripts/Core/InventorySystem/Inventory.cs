using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {
    public class Inventory : MonoBehaviour {
        public InventoryContainer currentContainer;

		[HideInInspector] public InventoryOverSeer overSeer;

		public List<ItemPick> items = new List<ItemPick>();

		private void Awake() {
			overSeer = InventoryOverSeer.GetInstance();
			if(currentContainer == null) {
				currentContainer = GetComponentInChildren<InventoryContainer>();
			}
			items = new List<ItemPick>(items);
		}


		public void AddItem(ItemPick item) {
			currentContainer.AddItem(item);
		}
		public void RemoveItem(ItemPick item) {
			currentContainer.RemoveItem(item);
		}
	}
}