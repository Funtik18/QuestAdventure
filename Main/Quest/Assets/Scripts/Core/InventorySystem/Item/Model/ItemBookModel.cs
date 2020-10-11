using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	/// <summary>
	/// Это определёная область, с которой возможно взаимодействие.
	/// При нажатии на эту модель включается Model View для детального просмотра.
	/// </summary>
	[RequireComponent(typeof(ImageMask))]
	public class ItemBookModel : ItemModel {
		public ItemBook item;

		protected override void Awake() {
			base.Awake();
			item = item.GetCopy<ItemBook>();//лучше скопировать объект.
		}

		public override void OnPointerClick(PointerEventData eventData) {
			ActiveModel(false);
			ModelView._instance.SetModel(this);
		}
	}
}