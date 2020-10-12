	/*using QG.Help;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
public class ItemModel2D : ItemModel {

		private InventoryOverSeer overSeer;
		private Canvas parentCanvasOfImageToMove;

		protected override void Awake() {
			base.Awake();
			//item.rootPosition = transform.localPosition;//сохрание позиции где предмет находился
			overSeer = InventoryOverSeer.GetInstance();
		}

		public override void OnBeginDrag(PointerEventData eventData) {
			eventData.selectedObject = gameObject;//сохранили ссылку на то что взяли
			overSeer.rootParent = transform.parent;//запомнили прошлого родителя
			CanvasGroupHelper.EnableGameObject(canvasGroup, false);//отключили рэйкасты
			//сменили родителя
			transform.SetParent(DragItems._instance.transform);
			SetParentCanvas();
			transform.localScale = Vector3.one;
		}
		public override void OnDrag(PointerEventData eventData) {
			//big костыль
			Vector2 pos;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvasOfImageToMove.transform as RectTransform, eventData.position, parentCanvasOfImageToMove.worldCamera, out pos);
			transform.position = parentCanvasOfImageToMove.transform.TransformPoint(pos);
		}
		public override void OnEndDrag(PointerEventData eventData) {
			CanvasGroupHelper.EnableGameObject(canvasGroup, true);//включили рейкасты
			eventData.selectedObject = null;

			parentCanvasOfImageToMove = null;

			if (DragItems._instance.transform == transform.parent) {
				ReturnBackToRoot();
			}
		}


		public override void OnPointerClick(PointerEventData eventData) { }
		public override void OnPointerDown(PointerEventData eventData) { }
		public override void OnPointerEnter(PointerEventData eventData) { }
		public override void OnPointerExit(PointerEventData eventData) { }
		public override void OnPointerUp(PointerEventData eventData) { }
		private void ReturnBackToRoot() {
			transform.SetParent(overSeer.rootParent);
			transform.localScale = Vector3.one;
			if (overSeer.rootParent.GetComponent<InventorySlot>())
				transform.localPosition = Vector3.zero;
			//else
				//transform.localPosition = item.rootPosition;
		}
		private void SetParentCanvas() {
			parentCanvasOfImageToMove = GetComponentInParent<Canvas>();
		}
	}
}*/