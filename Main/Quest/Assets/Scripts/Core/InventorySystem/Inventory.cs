using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {
    public class Inventory : MonoBehaviour {
        public InventoryContainer currentContainer;

		private InventoryOverSeer overSeer;

		public List<Item> items;

		private void Awake() {
			overSeer = InventoryOverSeer.GetInstance();
			if(currentContainer == null) {
				currentContainer = GetComponentInChildren<InventoryContainer>();
			}
			items = new List<Item>();
		}


		public void AddItem(Item item) {
			currentContainer.AddItem(item);
			//items.Add(item);
			//currentContainer.RefreshContainer();
		}
	}
}