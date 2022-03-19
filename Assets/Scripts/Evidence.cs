using UnityEngine;
public class Evidence : MonoBehaviour
{
    // Fields
    private Button2D bgFade;
    private bool isShow;
    private UnityEngine.SpriteRenderer spr;
    private int orderLayer;
    private UnityEngine.Vector3 saveScale;
    private UnityEngine.Vector3 savePos;
    private float timeAnim;
    public bool isDone;
    public bool isAnimating;
    public bool isPlaying;
    private float timeDisable;
    private bool tempDisable;
    
    // Methods
    private void Start()
    {
        UnityEngine.SpriteRenderer val_1 = this.GetComponent<UnityEngine.SpriteRenderer>();
        this.spr = val_1;
        this.orderLayer = val_1.sortingOrder;
        UnityEngine.Vector3 val_4 = this.transform.lossyScale;
        this.saveScale = val_4;
        mem[1152921513432639064] = val_4.y;
        mem[1152921513432639068] = val_4.z;
        UnityEngine.Vector3 val_6 = this.transform.localPosition;
        this.savePos = val_6;
        mem[1152921513432639076] = val_6.y;
        mem[1152921513432639080] = val_6.z;
    }
    public void TouchEvidence()
    {
        if(this.isPlaying == false)
        {
                return;
        }
        
        if(this.isAnimating != false)
        {
                return;
        }
        
        if(this.isShow != false)
        {
                this.bgFade.action.RemoveAllListeners();
            this.Hide();
            return;
        }
        
        this.bgFade.action = new UnityEngine.Events.UnityEvent();
        this.bgFade.action.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void Evidence::Hide()));
        this.Show();
    }
    public void Show()
    {
        this.tempDisable = true;
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  this.timeDisable, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Evidence::<Show>b__14_0()), ignoreTimeScale:  true);
        this.isAnimating = true;
        this.bgFade.gameObject.SetActive(value:  true);
        this.spr.enabled = true;
        this.spr.sortingOrder = 101;
        var val_23 = 0;
        label_14:
        UnityEngine.Transform val_6 = this.transform;
        if(val_23 >= (this.transform.childCount - 1))
        {
            goto label_7;
        }
        
        UnityEngine.Transform val_8 = val_6.GetChild(index:  0);
        if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
        {
                val_8.gameObject.SetActive(value:  true);
            val_8.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = 100;
        }
        
        val_23 = val_23 + 1;
        if(this.transform != null)
        {
            goto label_14;
        }
        
        label_7:
        Spine.Unity.BoneFollower val_14 = val_6.parent.GetComponent<Spine.Unity.BoneFollower>();
        if((UnityEngine.Object.op_Implicit(exists:  val_14)) != false)
        {
                val_14.followXYPosition = false;
            val_14.followBoneRotation = false;
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(x:  1f, y:  1f, z:  1f);
            val_14.transform.localRotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
        }
        
        UnityEngine.Vector3 val_19 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  0f);
        this.transform.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        UnityEngine.Transform val_20 = this.transform;
        TransformExtend.DoScale(transform:  val_20, scaleFrom:  this.saveScale, scaleTo:  1f, timeAnimation:  this.timeAnim, delayTime:  0f, autoRevese:  false);
        if(this.isDone != true)
        {
                EventDispatcherExtension.PostEvent(listener:  val_20, eventID:  30, param:  this);
        }
        
        DG.Tweening.Tween val_22 = DG.Tweening.DOVirtual.DelayedCall(delay:  this.timeAnim, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Evidence::<Show>b__14_1()), ignoreTimeScale:  true);
    }
    public void Hide()
    {
        if(this.tempDisable == true)
        {
                return;
        }
        
        this.isAnimating = true;
        this.bgFade.gameObject.SetActive(value:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.transform.parent.GetComponent<Spine.Unity.BoneFollower>())) != false)
        {
                val_4.followXYPosition = true;
            val_4.followBoneRotation = true;
        }
        
        this.transform.localPosition = new UnityEngine.Vector3() {x = this.savePos};
        float val_10 = 0.01f;
        val_10 = this.timeAnim + val_10;
        TransformExtend.DoScale(transform:  this.transform, scaleFrom:  1f, scaleTo:  this.saveScale, timeAnimation:  val_10, delayTime:  0f, autoRevese:  false);
        if(this.isDone == true)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(listener:  DG.Tweening.DOVirtual.DelayedCall(delay:  this.timeAnim, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Evidence::<Hide>b__15_0()), ignoreTimeScale:  true), eventID:  31, param:  this);
        this.isDone = true;
    }
    public Evidence()
    {
        this.timeAnim = 0.3f;
        this.isPlaying = true;
        this.timeDisable = 0.5f;
    }
    private void <Show>b__14_0()
    {
        this.tempDisable = false;
    }
    private void <Show>b__14_1()
    {
        this.isAnimating = false;
        this.isShow = true;
    }
    private void <Hide>b__15_0()
    {
        this.isAnimating = false;
        this.spr.sortingOrder = this.orderLayer;
        this.spr.enabled = false;
        var val_11 = 0;
        label_12:
        if(val_11 >= (this.transform.childCount - 1))
        {
            goto label_4;
        }
        
        UnityEngine.Transform val_5 = this.transform.GetChild(index:  0);
        if((UnityEngine.Object.op_Implicit(exists:  val_5)) != false)
        {
                val_5.gameObject.SetActive(value:  false);
            val_5.GetComponent<UnityEngine.SpriteRenderer>().sortingOrder = this.orderLayer - 1;
        }
        
        val_11 = val_11 + 1;
        if(this.transform != null)
        {
            goto label_12;
        }
        
        throw new NullReferenceException();
        label_4:
        this.isShow = false;
    }

}
