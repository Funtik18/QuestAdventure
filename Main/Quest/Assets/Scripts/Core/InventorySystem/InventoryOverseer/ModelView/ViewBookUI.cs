using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    [RequireComponent(typeof(CanvasGroup))]
    public class ViewBookUI : MonoBehaviour {
        [SerializeField] private Image view;
        [SerializeField] private Button buttonBack;
        private CanvasGroup canvasGroup;
        private CanvasGroup CanvasGroup {
            get {
                if (canvasGroup == null) {
                    canvasGroup = GetComponent<CanvasGroup>();
                }
                return canvasGroup;
            }
        }

        private void Awake() {
            buttonBack.onClick.AddListener(ButtonClick);
        }

        private void ButtonClick() {
            SetSprite(null).ActiveView(false);
            ModelView._instance.EnableOverlay(false);
            ModelView._instance.sender.ActiveModel(true);
            ModelView._instance.sender = null;
        }

        public ViewBookUI SetSprite(Sprite sprite) {
            view.sprite = sprite;
            return this;
        }

        public void ActiveView(bool trigger) {
            CanvasGroupHelper.ActiveGameObject(CanvasGroup, trigger);
        }
    }
}