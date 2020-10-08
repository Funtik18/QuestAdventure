using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace QG {
	[RequireComponent(typeof(Button))]
	public class Transition : MonoBehaviour {

		private Button mainButton;

		[Tooltip("Переход в эту комнату.")]
		public Room to;

		public event UnityAction<Transition> onClick;

		private void Awake() {
			if(to == null) {
				Debug.LogError("Transition doesn't have Room");
				return;
			}

			mainButton = GetComponent<Button>();
			mainButton.onClick.AddListener(()=> { onClick.Invoke(this); });
		}
	}
}