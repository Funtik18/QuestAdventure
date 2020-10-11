using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderRaycastFilter : MonoBehaviour
{
	Collider2D _collider;

	public bool i;

	void Start() {
		_collider = GetComponent<Collider2D>();
	}
	private void Update() {
		i = IsRaycastLocationValid(Input.mousePosition, Camera.main);
	}
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) {
		return _collider && _collider.OverlapPoint(eventCamera.ScreenToWorldPoint(sp));
	}
}
