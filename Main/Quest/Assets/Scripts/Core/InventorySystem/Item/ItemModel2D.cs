using QG.Events;
using QG.Help;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	[RequireComponent(typeof(CanvasGroup))]
	public class ItemModel2D : MonoBehaviour, IPointerUI, IDragUI {
		public Item item;

		private InventoryOverSeer overSeer;
		private CanvasGroup canvasGroup;
		private Canvas parentCanvasOfImageToMove;

		private void Awake() {
			canvasGroup = GetComponent<CanvasGroup>();
			item.rootPosition = transform.localPosition;
			overSeer = InventoryOverSeer.GetInstance();
		}

		public void OnBeginDrag(PointerEventData eventData) {
			eventData.selectedObject = gameObject;//сохранили ссылку на то что взяли
			overSeer.rootParent = transform.parent;//запомнили прошлого родителя
			CanvasGroupHelper.EnableGameObject(canvasGroup, false);//отключили рэйкасты
			//сменили родителя
			transform.SetParent(DragItems._instance.transform);
			SetParentCanvas();
			transform.localScale = Vector3.one;
		}
		public void OnDrag(PointerEventData eventData) {
			//big костыль
			Vector2 pos;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvasOfImageToMove.transform as RectTransform, eventData.position, parentCanvasOfImageToMove.worldCamera, out pos);
			transform.position = parentCanvasOfImageToMove.transform.TransformPoint(pos);
		}
		public void OnEndDrag(PointerEventData eventData) {
			CanvasGroupHelper.EnableGameObject(canvasGroup, true);//включили рейкасты
			eventData.selectedObject = null;

			parentCanvasOfImageToMove = null;

			if (DragItems._instance.transform == transform.parent) {
				ReturnBackToRoot();
			}
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
		private void ReturnBackToRoot() {
			transform.SetParent(overSeer.rootParent);
			transform.localScale = Vector3.one;
			if (overSeer.rootParent.GetComponent<InventorySlot>())
				transform.localPosition = Vector3.zero;
			else
				transform.localPosition = item.rootPosition;
		}
		private void SetParentCanvas() {
			parentCanvasOfImageToMove = GetComponentInParent<Canvas>();
		}
	}
}