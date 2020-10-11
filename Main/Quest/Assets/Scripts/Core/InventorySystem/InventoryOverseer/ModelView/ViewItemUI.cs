using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(Button))]
    [RequireComponent(typeof(CanvasGroup))]
    public class ViewItemUI : MonoBehaviour {
        private Image view;
        private Button buttonPickup;
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
            view = GetComponent<Image>();
            buttonPickup = GetComponent<Button>();
            buttonPickup.onClick.AddListener(ButtonClick);
        }

        private void ButtonClick() {
            SetSprite(null).ActiveView(false);
            ModelView._instance.EnableOverlay(false);

            InventoryOverSeer.GetInstance().mainInventory.AddItem(ModelView._instance.sender.item);

            ModelView._instance.sender.DestroyItem();
            ModelView._instance.sender = null;

        }

        public ViewItemUI SetSprite(Sprite sprite) {
            view.sprite = sprite;
            return this;
		}

		public void ActiveView(bool trigger) {
            CanvasGroupHelper.ActiveGameObject(CanvasGroup, trigger);
		}
    }
}