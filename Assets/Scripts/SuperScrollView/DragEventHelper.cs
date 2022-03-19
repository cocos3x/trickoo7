using UnityEngine;

namespace SuperScrollView
{
    public class DragEventHelper : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
    {
        // Fields
        public SuperScrollView.DragEventHelper.OnDragEventHandler mOnBeginDragHandler;
        public SuperScrollView.DragEventHelper.OnDragEventHandler mOnDragHandler;
        public SuperScrollView.DragEventHelper.OnDragEventHandler mOnEndDragHandler;
        
        // Methods
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.mOnBeginDragHandler == null)
            {
                    return;
            }
            
            this.mOnBeginDragHandler.Invoke(eventData:  eventData);
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.mOnDragHandler == null)
            {
                    return;
            }
            
            this.mOnDragHandler.Invoke(eventData:  eventData);
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.mOnEndDragHandler == null)
            {
                    return;
            }
            
            this.mOnEndDragHandler.Invoke(eventData:  eventData);
        }
        public DragEventHelper()
        {
        
        }
    
    }

}
