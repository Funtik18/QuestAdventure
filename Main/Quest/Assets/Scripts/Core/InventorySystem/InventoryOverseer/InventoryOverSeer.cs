using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {
	/// <summary>
	/// Класс ссылка, этот класс играет роль наблюдателя между контейнерами в ui.
	/// Сильно помогает при работе инвентарей.
	/// </summary>
    public class InventoryOverSeer : MonoBehaviour {

		private static InventoryOverSeer _instance;

		[HideInInspector] public List<Inventory> containers;

		[HideInInspector] public Transform rootParent;

		//[HideInInspector] public InventorySlot lastSlot;
		//[HideInInspector] public InventorySlot rootSlot;

		[HideInInspector] public ItemModel lastModel;

		[HideInInspector] public bool isDrag = false;

		public Inventory mainInventory;
		[HideInInspector] public Inventory from;//откуда взяли
		[HideInInspector] public Inventory whereNow;//где сейчас находимся

		public virtual void Init() {
			containers = new List<Inventory>();
		}

		public static InventoryOverSeer GetInstance() {
			if (_instance == null) {
				_instance = FindObjectOfType<InventoryOverSeer>();
				_instance.Init();
				if(DragItems._instance == null)
					DragItems.Init();
			}
			return _instance;
		}
	}
}