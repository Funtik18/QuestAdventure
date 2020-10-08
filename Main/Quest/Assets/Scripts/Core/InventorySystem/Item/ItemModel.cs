using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
    public class ItemModel : MonoBehaviour, IPointerUI, IDragUI {
        public Item item;

		private Canvas parentCanvasOfImageToMove;

		private void Awake() {
		}

		public void OnBeginDrag(PointerEventData eventData) {
			InventoryOverSeer.GetInstance().rootParent = transform.parent;
			SetParent(DragItems._instance.transform);
		}
		public void OnDrag(PointerEventData eventData) {
			//big костыль
			Vector2 pos;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvasOfImageToMove.transform as RectTransform, eventData.position, parentCanvasOfImageToMove.worldCamera, out pos);
			transform.position = parentCanvasOfImageToMove.transform.TransformPoint(pos);
		}
		public void OnEndDrag(PointerEventData eventData) {
			ReturnBackToRoot();
		}
		public void OnPointerClick(PointerEventData eventData) {

		}
		public void OnPointerDown(PointerEventData eventData) {

		}
		public void OnPointerEnter(PointerEventData eventData) {

		}
		public void OnPointerExit(PointerEventData eventData) {

		}
		public void OnPointerUp(PointerEventData eventData) {

		}

		private void SetParentCanvas() {
			parentCanvasOfImageToMove = GetComponentInParent<Canvas>();
		}

		private void SetParent(Transform newParent) {
			transform.SetParent(newParent);
			SetParentCanvas();
			transform.localScale = Vector3.one;

		}
		private void ReturnBackToRoot() {
			transform.SetParent(InventoryOverSeer.GetInstance().rootParent);
			transform.localScale = Vector3.one;
			parentCanvasOfImageToMove = null;
		}
	}
}