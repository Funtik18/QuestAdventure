using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.Help {

    public class CanvasGroupHelper {
		public static void EnableGameObject(CanvasGroup canvasGroup, bool iteract = false) {
			canvasGroup.alpha = 1;
			canvasGroup.blocksRaycasts = iteract;
			canvasGroup.interactable = iteract;

		}
		public static void DisableGameObject(CanvasGroup canvasGroup, bool iteract = false) {
			canvasGroup.alpha = 0;
			canvasGroup.blocksRaycasts = iteract;
			canvasGroup.interactable = iteract;
		}
	}
}