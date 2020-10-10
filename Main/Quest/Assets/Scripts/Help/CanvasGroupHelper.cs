using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.Help {
    public class CanvasGroupHelper {
		public static void ActiveGameObject(CanvasGroup canvasGroup, bool iteract = false) {
			canvasGroup.alpha = Convert.ToInt32(iteract);
			EnableGameObject(canvasGroup, iteract);
		}

		public static void EnableGameObject(CanvasGroup canvasGroup, bool iteract = false) {
			canvasGroup.blocksRaycasts = iteract;
			canvasGroup.interactable = iteract;
		}
	}
}