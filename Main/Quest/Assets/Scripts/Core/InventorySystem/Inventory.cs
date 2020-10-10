using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {
    public class Inventory : MonoBehaviour {
        public InventoryContainer currentContainer;

		[HideInInspector] public InventoryOverSeer overSeer;

		public List<Item> items = new List<Item>();

		private void Awake() {
			overSeer = InventoryOverSeer.GetInstance();
			if(currentContainer == null) {
				currentContainer = GetComponentInChildren<InventoryContainer>();
			}
			items = new List<Item>(items);
		}


		public void AddItem(Item item) {
			currentContainer.AddItem(item);
		}
		public void RemoveItem(Item item) {
			currentContainer.RemoveItem(item);
		}
	}
}