using UnityEngine;
public class DragDrop : MonoBehaviour
{
    // Fields
    public bool isDragging;
    public bool isPlaying;
    public bool alreadyPlaySound;
    public bool autoBack;
    private UnityEngine.Vector3 mouseDragStartPosition;
    private UnityEngine.Vector3 spriteDragStartPosition;
    private UnityEngine.Vector3 originPos;
    private UnityEngine.SpriteRenderer spr;
    private int orderLayer;
    
    // Methods
    private void Start()
    {
        UnityEngine.SpriteRenderer val_1 = this.GetComponent<UnityEngine.SpriteRenderer>();
        this.spr = val_1;
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
        {
                this.orderLayer = this.spr.sortingOrder;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        this.originPos = val_5;
        mem[1152921513431593464] = val_5.y;
        mem[1152921513431593468] = val_5.z;
        this.isPlaying = true;
    }
    public void OnMouseDown()
    {
        UnityEngine.Object val_7;
        this.isDragging = true;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.mouseDragStartPosition = val_3;
        mem[1152921513431734112] = val_3.y;
        mem[1152921513431734116] = val_3.z;
        UnityEngine.Vector3 val_5 = this.transform.position;
        this.spriteDragStartPosition = val_5;
        mem[1152921513431734124] = val_5.y;
        mem[1152921513431734128] = val_5.z;
        val_7 = this.spr;
        if((UnityEngine.Object.op_Implicit(exists:  val_7)) != false)
        {
                val_7 = this.spr;
            val_7.sortingOrder = 100;
        }
        
        EventDispatcherExtension.PostEvent(sender:  val_7, eventID:  81);
    }
    private void OnMouseUp()
    {
        UnityEngine.Object val_4;
        this.isDragging = false;
        this.alreadyPlaySound = false;
        val_4 = this.spr;
        if((UnityEngine.Object.op_Implicit(exists:  val_4)) != false)
        {
                val_4 = this.spr;
            val_4.sortingOrder = this.orderLayer;
        }
        
        if(this.autoBack == false)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(sender:  val_4, eventID:  80);
        DG.Tweening.Tween val_3 = DG.Tweening.DOVirtual.DelayedCall(delay:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void DragDrop::<OnMouseUp>b__11_0()), ignoreTimeScale:  true);
    }
    public void BackToOriginPos()
    {
        this.transform.position = new UnityEngine.Vector3() {x = this.originPos};
        if((this.GetComponent<Spine.Unity.SkeletonAnimation>()) == 0)
        {
                return;
        }
        
        Spine.TrackEntry val_4 = val_2.state.SetAnimation(trackIndex:  0, animationName:  "1", loop:  false);
    }
    private void OnMouseDrag()
    {
        if(this.isDragging == false)
        {
                return;
        }
        
        if(this.isPlaying == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.spriteDragStartPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this.mouseDragStartPosition, y = val_4.y, z = val_4.z});
        this.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.originPos, y = this.spriteDragStartPosition, z = V9.16B});
        UnityEngine.Vector3 val_9 = this.transform.position;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y})) <= 0.1f)
        {
                return;
        }
        
        if(this.alreadyPlaySound == true)
        {
                return;
        }
        
        SoundManager.Play(fileName:  "Move_Drag");
        this.alreadyPlaySound = true;
    }
    public DragDrop()
    {
        this.autoBack = true;
    }
    private void <OnMouseUp>b__11_0()
    {
        this.BackToOriginPos();
    }

}
