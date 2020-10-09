using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    [RequireComponent(typeof(CanvasGroup))]
    public class ViewItemUI : MonoBehaviour {
        [SerializeField] private Image view;
        [SerializeField] private Button buttonPickup;
        private CanvasGroup canvasGroup;

		private void Awake() {
            canvasGroup = GetComponent<CanvasGroup>();

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
            CanvasGroupHelper.ActiveGameObject(canvasGroup, trigger);
		}
    }
}