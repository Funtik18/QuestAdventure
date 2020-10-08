using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.InventorySystem {
    /// <summary>
    /// Класс ссылка, в этом объекте создаётся ui.
    /// </summary>
    public class DragItems : MonoBehaviour {
        public static DragItems _instance { get; private set; }

        public static void Init() {
            if (_instance == null)
                _instance = FindObjectOfType<DragItems>();
        }
		private void Awake() {
            if (_instance == null)
                _instance = this;
        }
	}
}