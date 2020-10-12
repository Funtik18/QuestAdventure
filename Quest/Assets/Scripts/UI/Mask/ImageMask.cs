using QG.Atributes;
using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace QG {
    [RequireComponent(typeof(Image))]
    public class ImageMask : MonoBehaviour, IPointerUI {

        [ReadOnly]
        [SerializeField]
        private bool isPointerIn = false;

        public void OnPointerClick(PointerEventData eventData) { }
		public void OnPointerDown(PointerEventData eventData) { }

        public void OnPointerEnter(PointerEventData eventData) { isPointerIn = true; }
        public void OnPointerExit(PointerEventData eventData) { isPointerIn = false; }

        public void OnPointerUp(PointerEventData eventData) { }

		private void Awake() {
            GetComponent<Image>().alphaHitTestMinimumThreshold = 0.5f;
        }
    }
}