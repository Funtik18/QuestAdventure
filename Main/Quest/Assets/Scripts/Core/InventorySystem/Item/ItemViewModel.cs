using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	/// <summary>
	/// При нажатии на эту модель включается Model View для детального просмотра.
	/// </summary>
	public class ItemViewModel : ItemModel {

		public override void OnBeginDrag(PointerEventData eventData) { }
		public override void OnDrag(PointerEventData eventData) { }
		public override void OnEndDrag(PointerEventData eventData) { }
		public override void OnPointerClick(PointerEventData eventData) {
			ActiveModel(false);
			ModelView._instance.SetItem(this);
		}
		public override void OnPointerDown(PointerEventData eventData) { }
		public override void OnPointerEnter(PointerEventData eventData) { }
		public override void OnPointerExit(PointerEventData eventData) { }
		public override void OnPointerUp(PointerEventData eventData) { }
	}
}