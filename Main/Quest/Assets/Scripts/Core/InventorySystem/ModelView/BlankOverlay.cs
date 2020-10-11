using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    [RequireComponent(typeof(CanvasGroup))]
    [RequireComponent(typeof(Image))]
    public class BlankOverlay : MonoBehaviour {
        private CanvasGroup canvasGroup;
        private CanvasGroup CanvasGroup {
            get {
                if (canvasGroup == null) {
                    canvasGroup = GetComponent<CanvasGroup>();
                }
                return canvasGroup;
            }
        }

        private Image image;

        private void Awake() {
            image = GetComponent<Image>();

            image.color = new Color(1, 1, 1, 0);
        }

        public void EnableView(bool trigger) {
            CanvasGroupHelper.EnableGameObject(CanvasGroup, trigger);
        }
    }
}