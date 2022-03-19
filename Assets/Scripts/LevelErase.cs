using UnityEngine;
public class LevelErase : Level
{
    // Fields
    private System.Collections.Generic.List<ScratchCardAsset.ScratchCardManager> mainEraseList;
    private System.Collections.Generic.List<ScratchCardAsset.ScratchCardManager> subEraseList;
    private UnityEngine.GameObject eraser;
    private bool displayErase;
    private float percentpass;
    private UnityEngine.Vector3 virtualKeyPosition;
    private int interpolationFramesCount;
    private int elapsedFrames;
    private float DefaultZ;
    private UnityEngine.RuntimePlatform platform;
    
    // Methods
    private void Awake()
    {
        mem[1152921513446457748] = 3;
    }
    protected override void Start()
    {
        var val_4;
        var val_5;
        var val_25;
        int val_26;
        this.Start();
        this.eraser.SetActive(value:  false);
        this.platform = UnityEngine.Application.platform;
        mem[1152921513446605584] = 0;
        mem[1152921513446605640] = new System.Collections.Generic.List<MainItem>();
        List.Enumerator<T> val_3 = this.mainEraseList.GetEnumerator();
        goto label_3;
        label_7:
        MainItem val_6 = null;
        val_26 = 0;
        val_6 = new MainItem();
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_26 = 0;
        UnityEngine.Transform val_7 = val_4.transform;
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        .transform = val_7;
        .index = 0;
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        val_7.Add(item:  val_6);
        label_3:
        if(val_5.MoveNext() == true)
        {
            goto label_7;
        }
        
        val_5.Dispose();
        System.Collections.Generic.List<UnityEngine.Vector2> val_9 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        List.Enumerator<T> val_10 = val_9.GetEnumerator();
        label_16:
        val_26 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_5.MoveNext() == false)
        {
            goto label_9;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_4 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_26 = (val_4 + 16.childCount) - 1;
        UnityEngine.Transform val_13 = val_4 + 16.GetChild(index:  val_26);
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector3 val_14 = val_13.position;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        val_5 = 0;
        val_26 = 0;
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  -0.1f, y:  0.3f);
        val_25 = 0;
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
        UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  0.4f, y:  0.6f);
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  -0.1f, y:  -0.6f);
        UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  0.4f, y:  -0.3f);
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
        goto label_16;
        label_9:
        val_5.Dispose();
        this.HandleTutorial(positions:  val_9);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  81, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelErase::IsDragHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  80, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelErase::CheckDragHandler(object obj)), eventType:  1);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 != null)
        {
                val_1.RemoveListener(eventID:  81, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelErase::IsDragHandler(object obj)));
        }
        
        EventDispatcher val_3 = LazySingleton<EventDispatcher>.Instance;
        if(val_3 == null)
        {
                return;
        }
        
        val_3.RemoveListener(eventID:  80, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelErase::CheckDragHandler(object obj)));
    }
    private void Update()
    {
        var val_24;
        var val_56;
        UnityEngine.Object val_57;
        float val_58;
        float val_61;
        float val_62;
        var val_64;
        var val_65;
        var val_66;
        UnityEngine.Object val_67;
        val_56;
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
        
        if(this.platform != 11)
        {
                if(this.platform != 8)
        {
            goto label_5;
        }
        
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
            goto label_8;
        }
        
        UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
        UnityEngine.Vector2 val_3 = position;
        val_58 = val_3.x;
        UnityEngine.Touch val_4 = UnityEngine.Input.GetTouch(index:  0);
        UnityEngine.Vector2 val_5 = position;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_58, y:  val_5.y);
        val_61 = val_6.x;
        val_62 = val_6.z;
        goto label_7;
        label_5:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
        val_58 = val_8.x;
        UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_58, y:  val_9.y);
        val_61 = val_10.x;
        val_62 = val_10.z;
        label_7:
        this.virtualKeyPosition = val_61;
        mem[1152921513447128168] = val_62;
        label_8:
        if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
        {
                val_57 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  this.virtualKeyPosition, y:  val_9.y, z:  this.DefaultZ);
            if(val_57 == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.Vector3 val_14 = val_57.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            int val_55 = this.interpolationFramesCount;
            UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  0f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            if(this.eraser == null)
        {
                throw new NullReferenceException();
        }
        
            val_58 = val_16.x;
            UnityEngine.Transform val_17 = this.eraser.transform;
            if(val_17 == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.Vector3 val_18 = val_17.position;
            if(this.eraser == null)
        {
                throw new NullReferenceException();
        }
        
            val_55 = (float)this.elapsedFrames / (float)val_55;
            val_57 = this.eraser.transform;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_58, y = val_16.y, z = val_16.z}, t:  val_55);
            if(val_57 == null)
        {
                throw new NullReferenceException();
        }
        
            val_57.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            int val_57 = this.interpolationFramesCount;
            int val_56 = this.elapsedFrames;
            val_56 = val_56 + 1;
            val_57 = val_57 + 1;
            val_56 = val_56 - ((val_56 / val_57) * val_57);
            this.elapsedFrames = val_56;
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
        mem[1152921513447128048] = 1;
        if(this.mainEraseList == null)
        {
                throw new NullReferenceException();
        }
        
        val_64 = 1152921513446562080;
        List.Enumerator<T> val_23 = this.mainEraseList.GetEnumerator();
        val_65 = 1152921513446563104;
        val_66 = 0;
        label_43:
        bool val_25 = val_13.x.MoveNext();
        if(val_25 == false)
        {
            goto label_19;
        }
        
        val_57 = val_24;
        if(this.displayErase != true)
        {
                this.percentpass = 0.001f;
        }
        
        if(val_57 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_24 + 96) == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_24 + 96 + 120) >= 0)
        {
            goto label_23;
        }
        
        mem[1152921513447128048] = 0;
        goto label_43;
        label_23:
        if(val_25 == false)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_26 = val_25.GetEnumerator();
        goto label_29;
        label_31:
        val_67 = val_26.current;
        if(val_67 == 11993091)
        {
                mem[28] = 256;
        }
        
        label_29:
        if(val_13.x.MoveNext() == false)
        {
            goto label_30;
        }
        
        val_66 = val_24;
        UnityEngine.Transform val_29 = val_57.transform;
        if(val_66 != 0)
        {
            goto label_31;
        }
        
        val_64 = val_57;
        throw new NullReferenceException();
        label_30:
        val_67 = 0;
        val_66 = val_66 + 1;
        mem2[0] = 476;
        val_64 = 1152921513446562080;
        val_13.x.Dispose();
        if(val_67 != 0)
        {
                throw X22;
        }
        
        if(val_66 != 1)
        {
                var val_30 = ((1152921513447115456 + ((val_66 + 1)) << 2) == 476) ? 1 : 0;
            val_30 = ((val_66 >= 0) ? 1 : 0) & val_30;
            val_66 = val_66 - val_30;
        }
        
        UnityEngine.Transform val_32 = val_57.transform;
        UnityEngine.Transform val_33 = val_57.transform;
        if(val_33 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_32 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Transform val_36 = val_32.GetChild(index:  val_33.childCount - 1);
        if(val_36 == null)
        {
                throw new NullReferenceException();
        }
        
        val_57 = val_36.GetComponent<UnityEngine.SpriteRenderer>();
        if((UnityEngine.Object.op_Implicit(exists:  val_57)) == false)
        {
            goto label_43;
        }
        
        if(val_57 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_39 = val_57.gameObject;
        if(val_39 == null)
        {
                throw new NullReferenceException();
        }
        
        val_39.SetActive(value:  false);
        goto label_43;
        label_19:
        val_66 = val_66 + 1;
        mem2[0] = 559;
        val_13.x.Dispose();
        if(val_66 != 1)
        {
                var val_40 = ((1152921513447115456 + ((val_66 + 1)) << 2) == 559) ? 1 : 0;
            val_40 = ((val_66 >= 0) ? 1 : 0) & val_40;
            val_67 = val_66 - val_40;
        }
        else
        {
                val_67 = 0;
        }
        
        this.CheckHintChosenAndFinish();
        if(559 == 0)
        {
                return;
        }
        
        if(this.mainEraseList == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_42 = this.mainEraseList.GetEnumerator();
        label_56:
        if(val_13.x.MoveNext() == false)
        {
            goto label_54;
        }
        
        if(val_24 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_24.ClearInstantly();
        goto label_56;
        label_54:
        val_67 = val_67 + 1;
        mem2[0] = 628;
        val_13.x.Dispose();
        if(val_67 != 1)
        {
                var val_44 = ((1152921513447115456 + ((val_67 + 1)) << 2) == 628) ? 1 : 0;
            val_44 = ((val_67 >= 0) ? 1 : 0) & val_44;
            val_67 = val_67 - val_44;
        }
        
        if(this.subEraseList == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_46 = this.subEraseList.GetEnumerator();
        label_61:
        if(val_13.x.MoveNext() == false)
        {
            goto label_59;
        }
        
        if(val_24 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_24.ClearInstantly();
        goto label_61;
        label_59:
        val_67 = val_67 + 1;
        mem2[0] = 680;
        val_13.x.Dispose();
        if(val_67 != 1)
        {
                var val_48 = ((1152921513447115456 + ((((val_67 + 1) - (val_67 >= 0x0 ? 1 : 0 & 1152921513447115456 + ((val_67 + 1)) << 2 == 0x274 ? 1 : 0)) + 1)) << 2) == 680) ? 1 : 0;
            val_48 = ((val_67 >= 0) ? 1 : 0) & val_48;
            val_48 = val_67 - val_48;
            val_48 = val_48 + 1;
            val_67 = (long)val_48;
        }
        else
        {
                val_67 = 0;
        }
        
        if(this.eraser == null)
        {
                throw new NullReferenceException();
        }
        
        this.eraser.SetActive(value:  false);
        if(680 == 0)
        {
                this.DisplayResult();
            UnityEngine.Coroutine val_51 = this.StartCoroutine(routine:  this.WaitAnimWin());
        }
        
        if(this.displayErase == true)
        {
                return;
        }
        
        if(val_51 == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_52 = val_51.GetEnumerator();
        val_65 = 1152921513418366288;
        val_66 = 1152921504721809408;
        val_64 = 1;
        label_80:
        if(val_13.x.MoveNext() == false)
        {
            goto label_68;
        }
        
        if(val_24 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_24 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        Spine.TrackEntry val_54 = val_24 + 224.SetAnimation(trackIndex:  0, animationName:  "2", loop:  false);
        goto label_80;
        label_68:
        val_13.x.Dispose();
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
    private void IsDragHandler(object obj)
    {
        goto typeof(LevelErase).__il2cppRuntimeField_1D0;
    }
    private void CheckDragHandler(object obj)
    {
        goto typeof(LevelErase).__il2cppRuntimeField_1D0;
    }
    public override void SetPopup(bool _isPopup)
    {
        var val_3;
        var val_4;
        var val_12;
        var val_13;
        mem[1152921513447744068] = _isPopup;
        List.Enumerator<T> val_2 = this.mainEraseList.GetEnumerator();
        bool val_5 = _isPopup ^ 1;
        label_4:
        val_12 = public System.Boolean List.Enumerator<ScratchCardAsset.ScratchCardManager>::MoveNext();
        if(val_4.MoveNext() == false)
        {
            goto label_2;
        }
        
        val_13 = val_3;
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_13.SetInputEnable(inputEnable:  val_5);
        goto label_4;
        label_2:
        val_4.Dispose();
        List.Enumerator<T> val_8 = this.subEraseList.GetEnumerator();
        label_8:
        val_12 = public System.Boolean List.Enumerator<ScratchCardAsset.ScratchCardManager>::MoveNext();
        if(val_4.MoveNext() == false)
        {
            goto label_6;
        }
        
        val_13 = val_3;
        if(val_13 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_13.SetInputEnable(inputEnable:  val_5);
        goto label_8;
        label_6:
        val_4.Dispose();
    }
    public LevelErase()
    {
        this.displayErase = true;
        this.percentpass = 0.5f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        this.virtualKeyPosition = val_2;
        mem[1152921513447864388] = val_2.y;
        mem[1152921513447864392] = val_2.z;
        this.interpolationFramesCount = 45;
        this.DefaultZ = 9f;
    }

}
