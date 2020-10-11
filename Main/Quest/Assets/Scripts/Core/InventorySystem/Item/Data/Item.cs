using System;
using QG.Atributes;
using UnityEngine;

namespace QG.InventorySystem {
    public class Item : ScriptableObject, IComparable {
        [ReadOnly]
        [SerializeField]
        private string itemID = System.Guid.NewGuid().ToString();

        public T GetCopy<T>() where T : Item {
            return Instantiate(this) as T;
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