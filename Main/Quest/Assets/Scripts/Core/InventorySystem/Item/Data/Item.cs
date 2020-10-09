using QG.Atributes;
using UnityEngine;

namespace QG.InventorySystem {
    [CreateAssetMenu(fileName = "Item", menuName = "GQ/Inventory/Items/BaseItem")]
    public class Item : ScriptableObject {
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
    }
}