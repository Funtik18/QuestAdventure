using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace QG {
    [RequireComponent(typeof(Image))]
    public class ImageMask : MonoBehaviour, IPointerUI {

        public bool InterfacePointer = false;

        public void OnPointerClick(PointerEventData eventData) { }
		public void OnPointerDown(PointerEventData eventData) { }

        public void OnPointerEnter(PointerEventData eventData) { InterfacePointer = true; }
        public void OnPointerExit(PointerEventData eventData) { InterfacePointer = false; }

        public void OnPointerUp(PointerEventData eventData) { }

		private void Awake() {
            GetComponent<Image>().alphaHitTestMinimumThreshold = 0.5f;
        }
    }
}