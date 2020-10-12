using System.Collections;
using System.Collections.Generic;
using QG.Events;
using QG.Help;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace QG.InventorySystem {
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(CanvasGroup))]
    public class InventorySlotIcon : MonoBehaviour, IDragUI {
        private Image icon;
        private CanvasGroup canvasGroup;

        public UnityAction<InventorySlot, PointerEventData> onBeginDrag;
        public UnityAction<InventorySlot, PointerEventData> onDrag;
        public UnityAction<InventorySlot, PointerEventData> onEndDrag;

        private InventorySlot owner;

        private void Awake() {
            icon = GetComponent<Image>();
            canvasGroup = GetComponent<CanvasGroup>();

            owner = GetComponentInParent<InventorySlot>();

            ActiveView(false);
        }
        public InventorySlotIcon SetSprite(Sprite sprite) {
            icon.sprite = sprite;
            return this;
        }

        public void ActiveView(bool trigger) {
            CanvasGroupHelper.ActiveGameObject(canvasGroup, trigger);
        }

        public void OnBeginDrag(PointerEventData eventData) {
            onBeginDrag?.Invoke(owner, eventData);
        }
		public void OnDrag(PointerEventData eventData) {
            onDrag?.Invoke(owner, eventData);
        }
        public void OnEndDrag(PointerEventData eventData) {
            onEndDrag?.Invoke(owner, eventData);
        }
    }
}