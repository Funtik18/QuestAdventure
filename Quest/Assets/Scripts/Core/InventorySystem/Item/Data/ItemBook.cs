using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {
    [CreateAssetMenu(fileName = "Item", menuName = "GQ/Inventory/Items/ItemBook")]
    public class ItemBook : Item {
        public GameObject bookPrefab;
    }
}