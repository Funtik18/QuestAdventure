
using UnityEngine;
using QG.Events;
using UnityEngine.EventSystems;
using QG.Help;

namespace QG.InventorySystem {
	[RequireComponent(typeof(CanvasGroup))]
	public class ItemModel : MonoBehaviour, IPointerUI, IDragUI {
		public Item item;

		protected CanvasGroup canvasGroup;

		protected virtual void Awake() {
			canvasGroup = GetComponent<CanvasGroup>();
		}

		public virtual void OnBeginDrag(PointerEventData eventData) { }
		public virtual void OnDrag(PointerEventData eventData) { }
		public virtual void OnEndDrag(PointerEventData eventData) { }
		public virtual void OnPointerClick(PointerEventData eventData) { }
		public virtual void OnPointerDown(PointerEventData eventData) { }
		public virtual void OnPointerEnter(PointerEventData eventData) { }
		public virtual void OnPointerExit(PointerEventData eventData) { }
		public virtual void OnPointerUp(PointerEventData eventData) { }

		public void DestroyItem() {
			DestroyImmediate(gameObject);
		}

		public void ActiveModel(bool triger) {
			CanvasGroupHelper.ActiveGameObject(canvasGroup, triger);
		}
	}
}
