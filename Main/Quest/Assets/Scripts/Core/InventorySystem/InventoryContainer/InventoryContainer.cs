using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
    public class InventoryContainer : MonoBehaviour {
		private Inventory inventory;
		private List<Item> items { get { return inventory.items; } }

		private List<InventorySlot> slots;
		
		private void Awake() {
			if (inventory == null)
				inventory = GetComponentInParent<Inventory>();
			overSeer = inventory.overSeer;
			buffer = DragBuffer._instance;
			slots = GetComponentsInChildren<InventorySlot>().ToList();

			foreach (InventorySlot slot in slots) {
				slot.icon.onBeginDrag = OnBeginDrag;
				slot.icon.onDrag = OnDrag;
				slot.icon.onEndDrag = OnEndDrag;

				slot.dropPlace.onDropSlot = OnDropSlot;
			}
		}

		public void AddItem(Item item) {
			items.Add(item);
			for (int i = 0; i < slots.Count; i++) {
				if (slots[i].isEmpty) {
					slots[i].SetItem(item);
					slots[i].dropPlace.EnableView(false);
					return;
				}
			}
			Debug.LogError("Inventory Full");
		}

		public void RemoveItem(Item item) {
			items.Remove(item);
			RefreshContainer();
		}

		public void RefreshContainer() {
			ClearContainer();

			for (int i = 0; i < items.Count; i++) {
				slots[i].SetItem(items[i]);
				slots[i].dropPlace.EnableView(false);
			}
		}
		private void ClearContainer() {
			for (int i = 0; i < slots.Count; i++) {
				slots[i].SetItem(null);
			}
		}

		#region Events
		private InventoryOverSeer overSeer;
		private Canvas parentCanvasOfImageToMove;
		DragBuffer buffer;
		public void OnBeginDrag(InventorySlot slot, PointerEventData eventData) {
			if (slot.isEmpty) return;

			buffer.SetTrack(slot);
			eventData.selectedObject = buffer.gameObject;//сохранили ссылку на то что взяли
			SetParentCanvas();
			buffer.ActiveView(true);
		}
		public void OnDrag(InventorySlot slot, PointerEventData eventData) {
			if (slot.isEmpty) return;

			Vector2 pos;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvasOfImageToMove.transform as RectTransform, eventData.position, parentCanvasOfImageToMove.worldCamera, out pos);
			buffer.transform.position = parentCanvasOfImageToMove.transform.TransformPoint(pos);
		}
		public void OnEndDrag(InventorySlot slot, PointerEventData eventData) {
			eventData.selectedObject = null;

			buffer.ActiveView(false);

			parentCanvasOfImageToMove = null;
		}


		/// <summary>
		///	Вызывается когда предмет дропается на слот.
		/// </summary>
		/// <param name="slot"></param>
		/// <param name="eventData"></param>
		public void OnDropSlot(InventorySlot slot, PointerEventData eventData) {
			ItemModel model = eventData.selectedObject.GetComponent<ItemModel>();
			if (model == null) {
				Debug.LogError("Error HERE");
				return;
			}
			items.Add(model.item);
			slot.SetItem(model.item);
			slot.dropPlace.EnableView(false);


			DestroyImmediate(model.gameObject);
		}
		#endregion


		private void SetParentCanvas() {
			parentCanvasOfImageToMove = GetComponentInParent<Canvas>();
		}
	}
}