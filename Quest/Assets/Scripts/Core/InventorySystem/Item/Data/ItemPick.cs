using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {

    [CreateAssetMenu(fileName = "Item", menuName = "GQ/Inventory/Items/ItemPick")]
    public class ItemPick : Item {
        [Header("Information")]
        public string itemName;
        [TextArea]
        public string itemDescription;

        [Header("Icon")]
        public Sprite itemIcon;
        [SerializeField]
        private Vector3 itemIconOrientation = Vector3.zero;//TODO
    }
}