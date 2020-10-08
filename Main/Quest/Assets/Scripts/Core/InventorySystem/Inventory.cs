using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {
    public class Inventory : MonoBehaviour {
        public InventoryContainer currentContainer;

        private InventoryOverSeer overSeer;

		private void Awake() {
			overSeer = InventoryOverSeer.GetInstance();
			if(currentContainer == null) {
				currentContainer = GetComponentInChildren<InventoryContainer>();
			}
		}
	}
}