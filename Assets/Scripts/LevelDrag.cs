using UnityEngine;
public class LevelDrag : Level
{
    // Fields
    private DragDrop mainDrag;
    private System.Collections.Generic.List<DragDrop> subDrags;
    private DragInterationInfo InteractionInfo;
    private float distance;
    private bool isNear;
    private int restrictDirection;
    private bool mouseUpDrag;
    private bool isChangePosition;
    private UnityEngine.Transform targetChange;
    private System.Collections.Generic.List<UnityEngine.GameObject> listHint;
    private float interval;
    private float currentInterval;
    private bool isAnimPlaying;
    
    // Methods
    private void Awake()
    {
        mem[1152921513442919444] = 2;
    }
    protected override void Start()
    {
        this.Start();
        mem[1152921513443070352] = 0;
        mem[1152921513443070408] = new System.Collections.Generic.List<MainItem>();
        UnityEngine.Transform val_3 = this.mainDrag.transform;
        .transform = val_3;
        .index = 0;
        val_3.Add(item:  new MainItem());
        System.Collections.Generic.List<UnityEngine.Vector2> val_4 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  -0.1f, y:  0.2f);
        UnityEngine.Vector3 val_6 = (MainItem)[1152921513443106400].transform.position;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        val_4.Add(item:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        UnityEngine.Vector3 val_9 = this.InteractionInfo.target.transform.position;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_4.Add(item:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        this.HandleTutorial(positions:  val_4);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  80, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelDrag::CheckDragHandler(object obj)), eventType:  1);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        val_1.RemoveListener(eventID:  80, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelDrag::CheckDragHandler(object obj)));
    }
    private void Update()
    {
        if(true == 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.currentInterval + val_1;
        this.currentInterval = val_1;
        if(val_1 < 0)
        {
                return;
        }
        
        if(this.mouseUpDrag != false)
        {
                if(this.mainDrag.isDragging == true)
        {
                return;
        }
        
        }
        
        List.Enumerator<T> val_2 = this.subDrags.GetEnumerator();
        label_11:
        if(0.MoveNext() == false)
        {
            goto label_9;
        }
        
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        if(208 == 0)
        {
            goto label_11;
        }
        
        0.Dispose();
        return;
        label_9:
        0.Dispose();
        if(this.isAnimPlaying == true)
        {
                return;
        }
        
        this.currentInterval = 0f;
        this.CheckDrag();
    }
    protected override void ShowHintHandler(object obj)
    {
        var val_2;
        var val_3;
        int val_15;
        UnityEngine.Object val_16;
        this.ShowHintHandler(obj:  obj);
        List.Enumerator<T> val_1 = this.GetEnumerator();
        label_17:
        val_15 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_3.MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 29) != 0)
        {
            goto label_17;
        }
        
        mem2[0] = 1;
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_15 = (val_2 + 16.childCount) - 1;
        UnityEngine.Transform val_6 = val_2 + 16.GetChild(index:  val_15);
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        val_15 = 0;
        UnityEngine.Transform val_7 = val_6.transform;
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.SpriteRenderer val_8 = val_7.GetComponent<UnityEngine.SpriteRenderer>();
        val_16 = val_8;
        val_15 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
        {
            goto label_17;
        }
        
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        val_15 = 0;
        UnityEngine.GameObject val_10 = val_8.gameObject;
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        val_10.SetActive(value:  true);
        val_15 = 0;
        UnityEngine.Transform val_11 = val_8.transform;
        val_16 = mem[val_2 + 16];
        val_16 = val_2 + 16;
        if(val_16 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_15 = val_16.parent;
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        val_11.parent = val_15;
        val_16 = this.listHint;
        if(val_16 == null)
        {
                throw new NullReferenceException();
        }
        
        val_16.Clear();
        val_15 = val_8.gameObject;
        if(this.listHint == null)
        {
                throw new NullReferenceException();
        }
        
        this.listHint.Add(item:  val_15);
        goto label_17;
        label_2:
        val_3.Dispose();
    }
    protected void CheckDragHandler(object obj)
    {
        this.CheckDrag();
    }
    private void CheckDrag()
    {
        var val_6;
        var val_7;
        DragDrop val_26;
        UnityEngine.Object val_27;
        var val_28;
        System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> val_29;
        val_26 = this.mainDrag;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = 0;
        UnityEngine.Transform val_1 = val_26.transform;
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = 0;
        UnityEngine.Vector3 val_2 = val_1.position;
        if(this.InteractionInfo == null)
        {
                throw new NullReferenceException();
        }
        
        val_26 = this.InteractionInfo.target;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = 0;
        UnityEngine.Vector3 val_3 = val_26.position;
        int val_24 = this.restrictDirection;
        val_24 = val_24 - 1;
        if(val_24 > 3)
        {
            goto label_18;
        }
        
        var val_25 = 20143372 + ((this.restrictDirection - 1)) << 2;
        val_25 = val_25 + 20143372;
        goto (20143372 + ((this.restrictDirection - 1)) << 2 + 20143372);
        label_18:
        val_28 = 1;
        float val_4 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        if(val_28 == 0)
        {
                return;
        }
        
        if(this.isNear == false)
        {
            goto label_14;
        }
        
        if(val_4 <= this.distance)
        {
            goto label_15;
        }
        
        return;
        label_14:
        if(val_4 < this.distance)
        {
                return;
        }
        
        label_15:
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_5 = 0.GetEnumerator();
        label_40:
        val_27 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_7.MoveNext() == false)
        {
            goto label_21;
        }
        
        if(this.InteractionInfo == null)
        {
                throw new NullReferenceException();
        }
        
        val_26 = this.InteractionInfo.target;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = 0;
        if(val_6 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_26 = val_26.transform;
        val_27 = val_6 + 16;
        if(val_26 != val_27)
        {
            goto label_40;
        }
        
        mem2[0] = 256;
        if(this.InteractionInfo == null)
        {
                throw new NullReferenceException();
        }
        
        val_26 = this.InteractionInfo.target;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = 0;
        UnityEngine.Transform val_11 = val_26.transform;
        if(this.InteractionInfo == null)
        {
                throw new NullReferenceException();
        }
        
        val_26 = this.InteractionInfo.target;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = 0;
        UnityEngine.Transform val_12 = val_26.transform;
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = 0;
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        val_27 = val_12.childCount - 1;
        UnityEngine.Transform val_14 = val_11.GetChild(index:  val_27);
        if(val_14 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.SpriteRenderer val_15 = val_14.GetComponent<UnityEngine.SpriteRenderer>();
        val_26 = val_15;
        val_27 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_26)) == false)
        {
            goto label_40;
        }
        
        if(val_15 == null)
        {
                throw new NullReferenceException();
        }
        
        val_15.gameObject.SetActive(value:  false);
        goto label_40;
        label_21:
        val_27 = public System.Void List.Enumerator<MainItem>::Dispose();
        val_7.Dispose();
        if(this.isChangePosition != false)
        {
                val_26 = this.mainDrag;
            if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
            val_27 = 0;
            UnityEngine.Transform val_18 = val_26.transform;
            if(this.targetChange == null)
        {
                throw new NullReferenceException();
        }
        
            val_26 = this.targetChange;
            val_27 = 0;
            UnityEngine.Vector3 val_19 = val_26.position;
            if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
            val_27 = 0;
            val_18.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        }
        
        val_26 = this;
        this.CheckHintChosenAndFinish();
        if(this.InteractionInfo == null)
        {
                throw new NullReferenceException();
        }
        
        val_29 = this.InteractionInfo.anims;
        if((val_29 != null) && (this.InteractionInfo >= 1))
        {
                val_29 = this.PlayAnimInOrder(anims:  val_29);
            UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  val_29);
        }
        
        UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.FinishStepByStep(item:  val_29));
    }
    private System.Collections.IEnumerator FinishStepByStep(DragInterationInfo item)
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LevelDrag.<FinishStepByStep>d__21();
    }
    private System.Collections.IEnumerator PlayAnimInOrder(System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> anims)
    {
        .<>1__state = 0;
        .anims = anims;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LevelDrag.<PlayAnimInOrder>d__22();
    }
    public LevelDrag()
    {
        this.distance = 0.3f;
        this.isNear = true;
        this.mouseUpDrag = true;
        this.interval = 1f;
    }

}
