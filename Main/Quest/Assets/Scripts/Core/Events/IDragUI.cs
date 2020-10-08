using UnityEngine.EventSystems;

namespace QG.Events {
	public interface IDragUI : IBeginDragHandler, IDragHandler, IEndDragHandler { }
}