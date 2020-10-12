using System.Collections;
using System.Collections.Generic;
using QG.Help;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    [RequireComponent(typeof(CanvasGroup))]
    public class ViewBookUI : MonoBehaviour {
        private GameObject view;
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
            TransformHelper.DestroyObject(view);
            ActiveView(false);
            ModelView._instance.EnableOverlay(false);
            ModelView._instance.sender.ActiveModel(true);
            ModelView._instance.sender = null;
        }

        public ViewBookUI SetBook(ItemBook item) {
            view = TransformHelper.CreateObjectInParent(transform, item.bookPrefab, "book");
            RectTransform rectParent = transform as RectTransform;
            RectTransform child = view.transform as RectTransform;
            child.anchorMin = new Vector2(0, 0);
            child.anchorMax = new Vector2(1, 1);
            child.pivot = new Vector2(0.5f, 0.5f);
            child.sizeDelta = Vector2.zero;
            return this;
        }

        public void ActiveView(bool trigger) {
            CanvasGroupHelper.ActiveGameObject(CanvasGroup, trigger);
        }
    }
}