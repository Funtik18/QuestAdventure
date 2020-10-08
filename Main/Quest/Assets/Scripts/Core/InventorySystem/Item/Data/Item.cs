using QG.Atributes;
using UnityEngine;

namespace QG.InventorySystem {
    public class Item : ScriptableObject {
        [ReadOnly]
        [SerializeField]
        private string itemID = System.Guid.NewGuid().ToString();

        [Header("Information")]
        public string itemName;

        [TextArea]
        public string itemDescription;

    }
}