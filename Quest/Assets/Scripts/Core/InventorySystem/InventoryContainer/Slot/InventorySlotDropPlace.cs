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
    public class InventorySlotDropPlace : MonoBehaviour, IDropUI {
        private Image image;
        private CanvasGroup canvasGroup;

        public UnityAction<InventorySlot, PointerEventData> onDropSlot;

        private void Awake() {
            image = GetComponent<Image>();
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public void OnDrop(PointerEventData eventData) {
            onDropSlot?.Invoke(GetComponentInParent<InventorySlot>(), eventData);
        }

        public void EnableView(bool trigger) {
            CanvasGroupHelper.EnableGameObject(canvasGroup, trigger);
        }
    }
}