using UnityEngine;

namespace SuperScrollView
{
    public class DragChangSizeScript : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
    {
        // Fields
        private bool mIsDragging;
        public UnityEngine.Camera mCamera;
        public float mBorderSize;
        public UnityEngine.Texture2D mCursorTexture;
        public UnityEngine.Vector2 mCursorHotSpot;
        public bool mIsVertical;
        private UnityEngine.RectTransform mCachedRectTransform;
        public System.Action mOnDragBeginAction;
        public System.Action mOnDraggingAction;
        public System.Action mOnDragEndAction;
        
        // Properties
        public UnityEngine.RectTransform CachedRectTransform { get; }
        
        // Methods
        public UnityEngine.RectTransform get_CachedRectTransform()
        {
            UnityEngine.RectTransform val_4;
            if(this.mCachedRectTransform == 0)
            {
                    this.mCachedRectTransform = this.gameObject.GetComponent<UnityEngine.RectTransform>();
                return val_4;
            }
            
            val_4 = this.mCachedRectTransform;
            return val_4;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(UnityEngine.Input.mousePresent == false)
            {
                    return;
            }
            
            UnityEngine.Cursor.SetCursor(texture:  this.mCursorTexture, hotspot:  new UnityEngine.Vector2() {x = this.mCursorHotSpot, y = V9.16B}, cursorMode:  0);
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(UnityEngine.Input.mousePresent == false)
            {
                    return;
            }
            
            UnityEngine.Cursor.SetCursor(texture:  0, hotspot:  new UnityEngine.Vector2() {x = this.mCursorHotSpot, y = V9.16B}, cursorMode:  0);
        }
        private void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode)
        {
            if(UnityEngine.Input.mousePresent == false)
            {
                    return;
            }
            
            UnityEngine.Cursor.SetCursor(texture:  texture, hotspot:  new UnityEngine.Vector2() {x = hotspot.x, y = hotspot.y}, cursorMode:  cursorMode);
        }
        private void LateUpdate()
        {
            UnityEngine.Vector2 val_12;
            UnityEngine.Texture2D val_14;
            float val_17;
            if(this.mCursorTexture == 0)
            {
                    return;
            }
            
            if(this.mIsDragging != false)
            {
                    label_16:
                val_12 = this.mCursorHotSpot;
                if(UnityEngine.Input.mousePresent == false)
            {
                    return;
            }
            
                val_14 = this.mCursorTexture;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  this.CachedRectTransform, screenPoint:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, cam:  this.mCamera, localPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f})) != false)
            {
                    UnityEngine.Rect val_8 = this.CachedRectTransform.rect;
                if(this.mIsVertical != false)
            {
                    val_17 = val_8.m_XMin.height + 0f;
            }
            else
            {
                    val_17 = val_8.m_XMin.width - 0f;
            }
            
                if(val_17 >= 0)
            {
                    if(val_17 <= this.mBorderSize)
            {
                goto label_16;
            }
            
            }
            
            }
            
                val_12 = this.mCursorHotSpot;
                if(UnityEngine.Input.mousePresent == false)
            {
                    return;
            }
            
                val_14 = 0;
            }
            
            UnityEngine.Cursor.SetCursor(texture:  val_14, hotspot:  new UnityEngine.Vector2() {x = val_12, y = val_5.y}, cursorMode:  0);
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mIsDragging = true;
            if(this.mOnDragBeginAction == null)
            {
                    return;
            }
            
            this.mOnDragBeginAction.Invoke();
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mIsDragging = false;
            if(this.mOnDragEndAction == null)
            {
                    return;
            }
            
            this.mOnDragEndAction.Invoke();
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            Axis val_5;
            bool val_2 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  this.CachedRectTransform, screenPoint:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = V8.16B}, cam:  this.mCamera, localPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
            if(this.mIsVertical == false)
            {
                goto label_4;
            }
            
            if(0f >= 0)
            {
                goto label_8;
            }
            
            UnityEngine.RectTransform val_3 = this.CachedRectTransform;
            val_5 = 1;
            goto label_7;
            label_4:
            if(0f <= 0f)
            {
                goto label_8;
            }
            
            val_5 = 0;
            label_7:
            this.CachedRectTransform.SetSizeWithCurrentAnchors(axis:  val_5, size:  0f);
            label_8:
            if(this.mOnDraggingAction == null)
            {
                    return;
            }
            
            this.mOnDraggingAction.Invoke();
        }
        public DragChangSizeScript()
        {
            this.mBorderSize = 10f;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  16f, y:  16f);
            this.mCursorHotSpot = val_1.x;
        }
    
    }

}
