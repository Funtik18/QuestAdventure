using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.EventSystems;

namespace QG.InventorySystem {
	/// <summary>
	/// Это определёная область, с которой возможно взаимодействие.
	/// При нажатии на эту модель включается Model View для детального просмотра.
	/// </summary>
	[RequireComponent(typeof(ImageMask))]
	public class ItemPickModel : ItemModel {
		public ItemPick item;

		protected override void Awake() {
			base.Awake();
			item = item.GetCopy<ItemPick>();//лучше скопировать объект.
		}
	}
}