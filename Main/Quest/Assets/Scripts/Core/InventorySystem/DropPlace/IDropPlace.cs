using System.Collections;
using System.Collections.Generic;
using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	public class IDropPlace : MonoBehaviour, IDropUI {
		public void OnDrop(PointerEventData eventData) {
			ItemModel2D itemModel = eventData.selectedObject.GetComponent<ItemModel2D>();
			if (itemModel) {
				DestroyImmediate(itemModel.gameObject);
			}
		}
	}
}