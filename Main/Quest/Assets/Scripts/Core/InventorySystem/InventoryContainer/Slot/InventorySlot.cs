using System.Collections;
using System.Collections.Generic;
using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	public class InventorySlot : MonoBehaviour, IDropUI {

		public Item currentItem;

		public bool isEmpty { get { return currentItem == null; } }

		public void SetItem(Item newItem) {
			currentItem = newItem;
		}

		public void OnDrop(PointerEventData eventData) {
			eventData.selectedObject.transform.SetParent(transform);
			eventData.selectedObject.transform.localPosition = Vector3.zero;
		}
	}
}