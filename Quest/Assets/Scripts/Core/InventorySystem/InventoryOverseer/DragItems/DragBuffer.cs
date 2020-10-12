using QG.Help;
using UnityEngine;
using UnityEngine.UI;

namespace QG.InventorySystem {
    /// <summary>
    /// Класс ссылка, этот объект играет роль drag && drop буфера.
    /// Именно этот объект перетаскиваем.
    /// </summary>
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(CanvasGroup))]
    public class DragBuffer : MonoBehaviour {
        public static DragBuffer _instance { get; private set; }

        private Image image;
        private CanvasGroup canvasGroup;

        [HideInInspector]public InventorySlot refFrom;

        public static DragBuffer GetInstance() {
            if (_instance == null)
                _instance = FindObjectOfType<DragBuffer>();
            return _instance;
        }
        private void Awake() {
            if (_instance == null)
                _instance = this;
        
            image = GetComponent<Image>();
            canvasGroup = GetComponent<CanvasGroup>();

            ActiveView(false);
        }
        public DragBuffer SetTrack(InventorySlot slot) {
            refFrom = slot;
            image.sprite = refFrom.currentItem.itemIcon;
            return this;
        }

        public void ActiveView(bool trigger) {
            CanvasGroupHelper.ActiveGameObject(canvasGroup, trigger);
            CanvasGroupHelper.EnableGameObject(canvasGroup, false);
        }
    }
}