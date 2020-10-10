using System;
using QG.Atributes;
using UnityEngine;

namespace QG.InventorySystem {
    [CreateAssetMenu(fileName = "Item", menuName = "GQ/Inventory/Items/BaseItem")]
    public class Item : ScriptableObject, IComparable {
        [ReadOnly]
        [SerializeField]
        private string itemID = System.Guid.NewGuid().ToString();

        [Header("Information")]
        public string itemName;

        [TextArea]
        public string itemDescription;

        [Header("Icon")]
        public Sprite itemIcon;
        [SerializeField]
        private Vector3 itemIconOrientation = Vector3.zero;//TODO

        [HideInInspector] public Vector2 rootPosition = Vector2.zero;

        public Item GetCopy() {
            return Instantiate(this);
        }

        public string GetId() {
            return itemID;
        }

        public int CompareTo(object obj) {
            if (obj is Item obj1) {
                return GetId() == obj1.GetId()? 1 : 0;
            }
            return 0;
        }
	}
}