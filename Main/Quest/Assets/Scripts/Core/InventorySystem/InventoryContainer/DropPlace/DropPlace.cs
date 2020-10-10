using System.Collections;
using System.Collections.Generic;
using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	public class DropPlace : MonoBehaviour, IDropUI {
		public void OnDrop(PointerEventData eventData) {
			InventoryOverSeer.GetInstance().mainInventory.RemoveItem(DragBuffer._instance.refFrom.currentItem);


			/*ItemModel2D model = eventData.selectedObject.GetComponent<ItemModel2D>();
			if (model) {
				DestroyImmediate(model.gameObject);
			}*/
		}
	}
}