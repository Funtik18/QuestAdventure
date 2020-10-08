using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Transition : MonoBehaviour {


    private Button mainButton;

	private void Awake() {
		mainButton = GetComponent<Button>();
	}
}
