using QG.Help;
using UnityEngine;

namespace QG {
	[RequireComponent(typeof(CanvasGroup))]
    public class Room : MonoBehaviour {
		public string roomName;

		private CanvasGroup canvasGroup;
		private CanvasGroup CanvasGroup {
			get { 
				if(canvasGroup == null) {
					canvasGroup = GetComponent<CanvasGroup>();
				}
				return canvasGroup;
			}
		}
		public void ActiveRoom(bool triger = false) {
			CanvasGroupHelper.ActiveGameObject(CanvasGroup, triger);
		}
	}
}