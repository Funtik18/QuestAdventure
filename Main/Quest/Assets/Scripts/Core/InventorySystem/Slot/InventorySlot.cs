using System.Collections;
using System.Collections.Generic;
using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	public class InventorySlot : MonoBehaviour, IDropUI {
		public void OnDrop(PointerEventData eventData) {
			InventoryOverSeer.GetInstance().lastModel.transform.SetParent(transform);
			InventoryOverSeer.GetInstance().lastModel.transform.localPosition = Vector3.zero;
		}
	}
}