using System.Collections;
using System.Collections.Generic;
using QG.Events;
using UnityEngine;
using UnityEngine.EventSystems;

public class TEST : MonoBehaviour, IPointerUI {
	public void OnPointerClick(PointerEventData eventData) {
		print("+");

	}
	public void OnPointerDown(PointerEventData eventData) => throw new System.NotImplementedException();
	public void OnPointerEnter(PointerEventData eventData) => throw new System.NotImplementedException();
	public void OnPointerExit(PointerEventData eventData) => throw new System.NotImplementedException();
	public void OnPointerUp(PointerEventData eventData) => throw new System.NotImplementedException();
}
