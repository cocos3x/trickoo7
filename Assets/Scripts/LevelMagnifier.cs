using UnityEngine;
public class LevelMagnifier : Level
{
    // Fields
    private DragDrop glass;
    private UnityEngine.Transform magnifier;
    private UnityEngine.LayerMask targetLayer;
    private float interval;
    private float currentInterval;
    private float magnifierScaleUp;
    private float magnifierScale;
    
    // Methods
    private void Awake()
    {
        var val_2;
        var val_3;
        mem[1152921513449733972] = 5;
        List.Enumerator<T> val_1 = 10551.GetEnumerator();
        label_4:
        if(val_3.MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_2.transform, endValue:  this.magnifierScaleUp, duration:  0f);
        goto label_4;
        label_2:
        val_3.Dispose();
        List.Enumerator<T> val_7 = val_3.GetEnumerator();
        goto label_6;
        label_8:
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = 2;
        label_6:
        if(val_3.MoveNext() == true)
        {
            goto label_8;
        }
        
        val_3.Dispose();
        TransformExtend.DoScale(transform:  this.glass.transform, scaleFrom:  this.magnifierScale, scaleTo:  0f, timeAnimation:  0.25f, delayTime:  0.01f, autoRevese:  true);
    }
    protected override void OnEnable()
    {
        var val_5;
        var val_6;
        int val_13;
        this.OnEnable();
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        UnityEngine.Vector3 val_2 = this.magnifier.position;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_1.Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        List.Enumerator<T> val_4 = val_1.GetEnumerator();
        label_12:
        val_13 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_6.MoveNext() == false)
        {
            goto label_6;
        }
        
        if(val_5 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_5 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_13 = (val_5 + 16.childCount) - 1;
        UnityEngine.Transform val_9 = val_5 + 16.GetChild(index:  val_13);
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_10 = val_9.position;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_1.Add(item:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        goto label_12;
        label_6:
        val_6.Dispose();
        this.HandleTutorial(positions:  val_1);
    }
    protected override void Start()
    {
        this.Start();
        mem[1152921513449998928] = 0;
    }
    private void Update()
    {
        var val_12;
        UnityEngine.Transform val_35;
        float val_36;
        float val_37;
        UnityEngine.Object val_38;
        var val_41;
        val_35 = this.magnifier;
        if(val_35 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_1 = val_35.position;
        val_36 = val_1.x;
        val_37 = val_1.z;
        val_38 = 0;
        UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  1f);
        UnityEngine.Color val_3 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_36, y = val_1.y, z = val_37}, dir:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, color:  new UnityEngine.Color() {r = val_3.r, g = val_3.b, a = val_2.x});
        val_36 = this.currentInterval;
        val_35 = 0;
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = val_36 + val_4;
        this.currentInterval = val_4;
        if(val_4 < 0)
        {
                return;
        }
        
        if(this.glass == null)
        {
                throw new NullReferenceException();
        }
        
        if(this.glass.isDragging == true)
        {
                return;
        }
        
        val_35 = this.magnifier;
        this.currentInterval = 0f;
        if(val_35 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_5 = val_35.position;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_36 = val_6.x;
        UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  -1f);
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_37 = val_8.x;
        UnityEngine.RaycastHit2D val_10 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = val_36, y = val_6.y}, direction:  new UnityEngine.Vector2() {x = val_37, y = val_8.y}, distance:  10f, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.targetLayer}));
        if(val_2.x.collider == 0)
        {
                return;
        }
        
        val_38 = 0;
        UnityEngine.Collider2D val_15 = val_2.x.collider;
        if(val_15 == null)
        {
                throw new NullReferenceException();
        }
        
        val_38 = public UnityEngine.Transform UnityEngine.Component::GetComponent<UnityEngine.Transform>();
        UnityEngine.Transform val_16 = val_15.GetComponent<UnityEngine.Transform>();
        List.Enumerator<T> val_17 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished.GetEnumerator();
        label_42:
        val_38 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_2.x.MoveNext() == false)
        {
            goto label_20;
        }
        
        if(val_12 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_35 = val_16;
        val_38 = val_12 + 16;
        if((val_35 != val_38) || ((val_12 + 29) != 0))
        {
            goto label_42;
        }
        
        mem2[0] = 256;
        if(val_16 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Transform val_20 = val_16.transform;
        val_38 = 0;
        UnityEngine.Transform val_21 = val_16.transform;
        if(val_21 == null)
        {
                throw new NullReferenceException();
        }
        
        val_38 = 0;
        if(val_20 == null)
        {
                throw new NullReferenceException();
        }
        
        val_38 = val_21.childCount - 1;
        UnityEngine.Transform val_23 = val_20.GetChild(index:  val_38);
        if(val_23 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.SpriteRenderer val_24 = val_23.GetComponent<UnityEngine.SpriteRenderer>();
        val_35 = val_24;
        val_38 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_35)) != false)
        {
                if(val_24 == null)
        {
                throw new NullReferenceException();
        }
        
            val_38 = 0;
            UnityEngine.GameObject val_26 = val_24.gameObject;
            if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
            val_26.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_24)) == false)
        {
            goto label_37;
        }
        
        val_16.gameObject.SetActive(value:  false);
        this.CollectItem(index:  val_12 + 24);
        goto label_42;
        label_37:
        SoundManager.Play(fileName:  "Collect");
        goto label_42;
        label_20:
        val_38 = public System.Void List.Enumerator<MainItem>::Dispose();
        val_2.x.Dispose();
        this.CheckHintChosenAndFinish();
        if(this == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_29 = this.GetEnumerator();
        val_41 = 0;
        goto label_44;
        label_46:
        if(val_12 == 0)
        {
                throw new NullReferenceException();
        }
        
        var val_33 = val_12 + 29;
        val_33 = val_33 ^ 1;
        val_41 = val_41 + val_33;
        label_44:
        if(val_2.x.MoveNext() == true)
        {
            goto label_46;
        }
        
        val_2.x.Dispose();
        if(val_41 != 0)
        {
                return;
        }
        
        mem[1152921513450173376] = 1;
        this.DisplayResultMagnifier();
        this.DisplayResult();
        if(1 != 0)
        {
                return;
        }
        
        mem[1152921513450173365] = 0;
        UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  this.WaitAnimWin());
    }
    private void DisplayResultMagnifier()
    {
        var val_2;
        var val_3;
        List.Enumerator<T> val_1 = 10552.GetEnumerator();
        goto label_2;
        label_4:
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        mem2[0] = 0;
        label_2:
        if(val_3.MoveNext() == true)
        {
            goto label_4;
        }
        
        val_3.Dispose();
        List.Enumerator<T> val_5 = val_3.GetEnumerator();
        label_8:
        if(0.MoveNext() == false)
        {
            goto label_6;
        }
        
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        0.maskInteraction = 0;
        goto label_8;
        label_6:
        0.Dispose();
        this.glass.gameObject.SetActive(value:  false);
    }
    protected override void ShowHintHandler(object obj)
    {
        var val_2;
        var val_3;
        int val_12;
        UnityEngine.Object val_13;
        this.ShowHintHandler(obj:  obj);
        List.Enumerator<T> val_1 = this.GetEnumerator();
        label_13:
        val_12 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
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
            goto label_13;
        }
        
        mem2[0] = 1;
        if((val_2 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_12 = (val_2 + 16.childCount) - 1;
        UnityEngine.Transform val_6 = val_2 + 16.GetChild(index:  val_12);
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        val_12 = 0;
        UnityEngine.Transform val_7 = val_6.transform;
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.SpriteRenderer val_8 = val_7.GetComponent<UnityEngine.SpriteRenderer>();
        val_13 = val_8;
        val_12 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_13)) == false)
        {
            goto label_13;
        }
        
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        val_12 = 0;
        UnityEngine.GameObject val_10 = val_8.gameObject;
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        val_10.SetActive(value:  true);
        goto label_13;
        label_2:
        val_3.Dispose();
    }
    public LevelMagnifier()
    {
        this.interval = 1.3f;
        this.magnifierScaleUp = 1.02f;
        this.magnifierScale = 0.8f;
    }

}
