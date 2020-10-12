using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QG.Settings {
    public class GameManager : MonoBehaviour {
		public static GameManager _instance;
		private void Awake() {
			if(_instance == null) {
				_instance = this;
				DontDestroyOnLoad(gameObject);
			}

			//Screen.orientation = ScreenOrientation.LandscapeLeft;
		}
	}
}