using System.Collections;
using System.Collections.Generic;
using QG.Events;
using QG.Help;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace QG.InventorySystem {
	[RequireComponent(typeof(CanvasGroup))]
	public class InventorySlot : MonoBehaviour, IDropUI {

		[HideInInspector] public Item currentItem;

		[HideInInspector] public InventorySlotIcon icon;

		public UnityAction<InventorySlot, PointerEventData> onDropSlot;

		private CanvasGroup canvasGroup;

		public bool isEmpty { get { return currentItem == null; } }

		private void Awake() {
			canvasGroup = GetComponent<CanvasGroup>();
			icon = GetComponentInChildren<InventorySlotIcon>();
		}

		public void SetItem(Item newItem) {
			currentItem = newItem;
			if (currentItem != null)
				icon.SetSprite(currentItem.itemIcon).ActiveView(true);
			else
				icon.ActiveView(false);
		}

		public void OnDrop(PointerEventData eventData) {
			onDropSlot?.Invoke(this, eventData);
		}

		public void EnableView(bool trigger) {
			CanvasGroupHelper.EnableGameObject(canvasGroup, trigger);
		}
	}
}