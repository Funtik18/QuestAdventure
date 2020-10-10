using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(CanvasGroup))]
    public class InventorySlotIcon : MonoBehaviour {
        private Image icon;
        private CanvasGroup canvasGroup;

        private void Awake() {
            icon = GetComponent<Image>();
            canvasGroup = GetComponent<CanvasGroup>();

            ActiveView(false);
        }
        public InventorySlotIcon SetSprite(Sprite sprite) {
            icon.sprite = sprite;
            return this;
        }

        public void ActiveView(bool trigger) {
            CanvasGroupHelper.ActiveGameObject(canvasGroup, trigger);
        }
    }
}