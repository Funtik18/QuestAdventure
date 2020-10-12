using UnityEngine.EventSystems;

namespace QG.Events {
	public interface IPointerUI : IPointerEnterHandler, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerExitHandler { }
}