using UnityEngine;
public class LevelFind : Level
{
    // Fields
    private System.Collections.Generic.List<Evidence> listMainEvidence;
    private System.Collections.Generic.List<Evidence> listSubEvidence;
    private System.Collections.Generic.List<Evidence> listFindEvidence;
    
    // Methods
    private void Awake()
    {
        mem[1152921513447976276] = 4;
    }
    protected override void Start()
    {
        var val_4;
        var val_5;
        var val_24;
        int val_25;
        this.Start();
        this.listFindEvidence = new System.Collections.Generic.List<Evidence>();
        mem[1152921513448121040] = 0;
        mem[1152921513448121096] = new System.Collections.Generic.List<MainItem>();
        List.Enumerator<T> val_3 = this.listMainEvidence.GetEnumerator();
        goto label_2;
        label_6:
        MainItem val_6 = null;
        val_25 = 0;
        val_6 = new MainItem();
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_25 = 0;
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
        label_2:
        if(val_5.MoveNext() == true)
        {
            goto label_6;
        }
        
        val_5.Dispose();
        System.Collections.Generic.List<UnityEngine.Vector2> val_9 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        List.Enumerator<T> val_11 = new UnityEngine.Vector2(x:  -0.1f, y:  0.2f).GetEnumerator();
        label_15:
        val_25 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_5.MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_4 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_4 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_25 = (val_4 + 16.childCount) - 1;
        UnityEngine.Transform val_14 = val_4 + 16.GetChild(index:  val_25);
        if(val_14 == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = 0;
        UnityEngine.Vector3 val_15 = val_14.position;
        val_24 = 0;
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        UnityEngine.Vector3 val_17 = val_14.position;
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        UnityEngine.Vector3 val_20 = val_14.position;
        UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.zero;
        val_9.Add(item:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
        goto label_15;
        label_8:
        val_5.Dispose();
        this.HandleTutorial(positions:  val_9);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  30, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelFind::FindEvidenceHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  31, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelFind::CollectEvidenceHandler(object obj)), eventType:  1);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 != null)
        {
                val_1.RemoveListener(eventID:  30, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelFind::FindEvidenceHandler(object obj)));
        }
        
        EventDispatcher val_3 = LazySingleton<EventDispatcher>.Instance;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = new System.Action<System.Object>(object:  this, method:  System.Void LevelFind::CollectEvidenceHandler(object obj));
        val_3.RemoveListener(eventID:  31, callback:  val_3);
    }
    private void FindEvidenceHandler(object obj)
    {
        var val_7;
        var val_8;
        Evidence val_22;
        object val_23;
        val_22 = obj;
        LevelFind.<>c__DisplayClass7_0 val_1 = null;
        val_23 = 0;
        val_1 = new LevelFind.<>c__DisplayClass7_0();
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_22 != null)
        {
                val_23 = null;
        }
        
        .evi = val_22;
        if(val_22 == 0)
        {
                return;
        }
        
        val_22 = this.listMainEvidence;
        System.Predicate<Evidence> val_3 = null;
        val_23 = val_1;
        val_3 = new System.Predicate<Evidence>(object:  val_1, method:  System.Boolean LevelFind.<>c__DisplayClass7_0::<FindEvidenceHandler>b__0(Evidence x));
        if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
        val_22 = val_22.Find(match:  val_3);
        val_23 = 0;
        bool val_5 = UnityEngine.Object.op_Inequality(x:  val_22, y:  val_23);
        if(val_5 == false)
        {
                return;
        }
        
        if(val_5 == false)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_6 = val_5.GetEnumerator();
        label_27:
        val_23 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_8.MoveNext() == false)
        {
            goto label_13;
        }
        
        if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = 0;
        if(val_7 == 0)
        {
                throw new NullReferenceException();
        }
        
        if(val_22.transform != (val_7 + 16))
        {
            goto label_27;
        }
        
        mem2[0] = 256;
        UnityEngine.Transform val_12 = val_22.transform;
        val_23 = 0;
        UnityEngine.Transform val_13 = val_22.transform;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = 0;
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = val_13.childCount - 1;
        UnityEngine.Transform val_15 = val_12.GetChild(index:  val_23);
        if(val_15 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.SpriteRenderer val_16 = val_15.GetComponent<UnityEngine.SpriteRenderer>();
        val_23 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
        {
            goto label_27;
        }
        
        if(val_16 == null)
        {
                throw new NullReferenceException();
        }
        
        val_16.gameObject.SetActive(value:  false);
        goto label_27;
        label_13:
        val_23 = public System.Void List.Enumerator<MainItem>::Dispose();
        val_8.Dispose();
        this.CheckHintChosenAndFinish();
        if(this.listMainEvidence == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = val_22;
        bool val_19 = this.listMainEvidence.Remove(item:  val_23);
        if(this.listFindEvidence == null)
        {
                throw new NullReferenceException();
        }
        
        this.listFindEvidence.Add(item:  val_22);
    }
    private void CollectEvidenceHandler(object obj)
    {
        var val_5;
        var val_6;
        Evidence val_22;
        UnityEngine.Object val_23;
        UnityEngine.Object val_24;
        val_22 = obj;
        .<>4__this = this;
        if(val_22 != null)
        {
                val_23 = null;
        }
        
        .evi = val_22;
        if(val_22 == 0)
        {
                return;
        }
        
        bool val_3 = UnityEngine.Object.op_Implicit(exists:  val_22);
        if(val_3 == false)
        {
            goto label_10;
        }
        
        List.Enumerator<T> val_4 = val_3.GetEnumerator();
        label_20:
        val_23 = public System.Boolean List.Enumerator<MainItem>::MoveNext();
        if(val_6.MoveNext() == false)
        {
            goto label_12;
        }
        
        if(((LevelFind.<>c__DisplayClass8_0)[1152921513448830368].evi) == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = 0;
        if(val_5 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_24 = (LevelFind.<>c__DisplayClass8_0)[1152921513448830368].evi.transform;
        val_23 = val_5 + 16;
        if(val_24 != val_23)
        {
            goto label_20;
        }
        
        if((val_5 + 16) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_23 = 0;
        UnityEngine.GameObject val_10 = val_5 + 16.gameObject;
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        val_10.SetActive(value:  false);
        this.CollectItem(index:  val_5 + 24);
        goto label_20;
        label_12:
        val_6.Dispose();
        goto label_21;
        label_10:
        SoundManager.Play(fileName:  "Collect");
        label_21:
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  40);
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
    public LevelFind()
    {
    
    }

}
