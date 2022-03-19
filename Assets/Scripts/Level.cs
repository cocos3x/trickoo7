using UnityEngine;
public class Level : MonoBehaviour
{
    // Fields
    protected float timeAppearPopupWin;
    protected float timeAppearTickSoundWin;
    public int index;
    protected bool isPopup;
    protected bool isPlaying;
    protected bool multipleChoice;
    protected UnityEngine.GameObject tick;
    public bool checkPassCondition;
    protected LevelType levelType;
    protected System.Collections.Generic.List<int> levelTutorial;
    protected System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> showAnim;
    protected System.Collections.Generic.List<Spine.Unity.SkeletonAnimation> hideAnim;
    protected System.Collections.Generic.List<UnityEngine.SpriteRenderer> showArt;
    protected System.Collections.Generic.List<UnityEngine.SpriteRenderer> hideArt;
    protected UnityEngine.GameObject hint;
    protected System.Collections.Generic.List<MainItem> listTarget;
    protected UnityEngine.Transform collectionGroup;
    protected float duration2;
    
    // Methods
    protected virtual void OnEnable()
    {
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        this.index = 1152921513314619296;
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  13, callback:  new System.Action<System.Object>(object:  this, method:  typeof(Level).__il2cppRuntimeField_1A8), eventType:  1);
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  19);
        this.tick.SetActive(value:  false);
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  -0.1f, y:  0.2f);
        if(this.levelType != 1)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_5 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        UnityEngine.Vector3 val_7 = this.hint.transform.position;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_5.Add(item:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
        UnityEngine.Vector3 val_10 = this.hint.transform.position;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        val_5.Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        UnityEngine.Vector3 val_14 = this.hint.transform.position;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        val_5.Add(item:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.zero;
        val_5.Add(item:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
        this.HandleTutorial(positions:  val_5);
    }
    protected virtual void Start()
    {
        var val_4;
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        val_4 = null;
        if(MusicManager.IsOn != false)
        {
                MusicManager.UnPause(fadeTime:  1f);
        }
        
        this.checkPassCondition = true;
    }
    protected virtual void OnDisable()
    {
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        val_1.RemoveListener(eventID:  13, callback:  new System.Action<System.Object>(object:  this, method:  typeof(Level).__il2cppRuntimeField_1A8));
    }
    protected virtual void ShowHintHandler(object obj)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.hint)) != false)
        {
                this.hint.SetActive(value:  true);
        }
        
        if(obj != null)
        {
                if(null == null)
        {
                return;
        }
        
        }
        
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  41);
    }
    protected void DisplayResult()
    {
        var val_2;
        var val_3;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        if(this.showAnim == null)
        {
                throw new NullReferenceException();
        }
        
        val_29 = 1152921513418365264;
        List.Enumerator<T> val_1 = this.showAnim.GetEnumerator();
        label_5:
        if(val_3.MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_5 = val_2.gameObject;
        if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
        val_5.SetActive(value:  true);
        goto label_5;
        label_2:
        val_3.Dispose();
        if(this.showArt == null)
        {
                throw new NullReferenceException();
        }
        
        val_30 = 1152921513418376528;
        List.Enumerator<T> val_6 = this.showArt.GetEnumerator();
        label_10:
        if(val_3.MoveNext() == false)
        {
            goto label_7;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_8 = val_2.gameObject;
        if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
        val_8.SetActive(value:  true);
        goto label_10;
        label_7:
        val_3.Dispose();
        if(this.hideArt == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_9 = this.hideArt.GetEnumerator();
        label_15:
        if(val_3.MoveNext() == false)
        {
            goto label_12;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_11 = val_2.gameObject;
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        val_11.SetActive(value:  false);
        goto label_15;
        label_12:
        val_3.Dispose();
        if(0 != 1)
        {
                var val_12 = (171 == 171) ? 1 : 0;
            val_12 = ((0 >= 0) ? 1 : 0) & val_12;
            val_31 = 0 - val_12;
        }
        else
        {
                val_31 = 0;
        }
        
        if(this.hideAnim == null)
        {
                throw new NullReferenceException();
        }
        
        List.Enumerator<T> val_14 = this.hideAnim.GetEnumerator();
        label_22:
        if(val_3.MoveNext() == false)
        {
            goto label_19;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_16 = val_2.gameObject;
        if(val_16 == null)
        {
                throw new NullReferenceException();
        }
        
        val_16.SetActive(value:  false);
        goto label_22;
        label_19:
        val_3.Dispose();
        if(1 != 1)
        {
                var val_17 = (228 == 228) ? 1 : 0;
            val_17 = ((1 >= 0) ? 1 : 0) & val_17;
            val_17 = 1 - val_17;
            val_17 = val_17 + 1;
            val_32 = (long)val_17;
        }
        else
        {
                val_32 = 0;
        }
        
        LevelType val_27 = this.levelType;
        val_27 = val_27 - 1;
        if(val_27 > 6)
        {
            goto label_66;
        }
        
        var val_28 = 20143304 + ((this.levelType - 1)) << 2;
        val_28 = val_28 + 20143304;
        goto (20143304 + ((this.levelType - 1)) << 2 + 20143304);
        label_49:
        if(val_3.MoveNext() == false)
        {
            goto label_27;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((val_2 + 224) == 0)
        {
                throw new NullReferenceException();
        }
        
        Spine.TrackEntry val_21 = val_2 + 224.SetAnimation(trackIndex:  0, animationName:  "2", loop:  false);
        if(val_2.Skeleton == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_22.data == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_22.data.FindAnimation(animationName:  "2")) == null)
        {
                throw new NullReferenceException();
        }
        
        this.duration2 = (val_23.duration >= this.duration2) ? val_23.duration : this.duration2;
        goto label_49;
        label_27:
        val_3.Dispose();
        label_66:
        UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  this.DisplayAnim(duration:  this.duration2));
    }
    public System.Collections.IEnumerator DisplayAnim(float duration)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .duration = duration;
        return (System.Collections.IEnumerator)new Level.<DisplayAnim>d__23();
    }
    public virtual void RightOption()
    {
        if(this.isPlaying == false)
        {
                return;
        }
        
        if(this.isPopup == true)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "RIGHT " + this.checkPassCondition.ToString());
        if(this.checkPassCondition == false)
        {
            goto label_5;
        }
        
        this.isPlaying = false;
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  50, param:  null);
        SoundManager.Play(fileName:  "Answer_Right");
        if(this.levelType != 3)
        {
            goto label_8;
        }
        
        this.duration2 = 0f;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.DisplayAnim(duration:  0f));
        this.duration2 = 1.5f;
        goto label_9;
        label_5:
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  50, param:  true);
        goto label_10;
        label_8:
        this.DisplayResult();
        label_9:
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.WaitAnimWin());
        label_10:
        if((UnityEngine.Object.op_Implicit(exists:  this.hint)) == false)
        {
                return;
        }
        
        this.hint.SetActive(value:  false);
    }
    public virtual void WrongOption()
    {
        if(this.isPlaying == false)
        {
                return;
        }
        
        if(this.isPopup == true)
        {
                return;
        }
        
        if(this.checkPassCondition != false)
        {
                SoundManager.Play(fileName:  "Answer_Wrong");
        }
        
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  50, param:  true);
    }
    protected void CollectItem(int index)
    {
        SoundManager.Play(fileName:  "Collect");
        this.collectionGroup.GetChild(index:  index).GetChild(index:  0).gameObject.SetActive(value:  true);
    }
    protected System.Collections.IEnumerator WaitAnimWin()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Level.<WaitAnimWin>d__27();
    }
    protected void CheckHintChosenAndFinish()
    {
        var val_6;
        var val_7;
        List.Enumerator<T> val_1 = this.listTarget.GetEnumerator();
        val_6 = 0;
        val_7 = 1;
        goto label_2;
        label_4:
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_6 = val_6 | ((0 != 0) ? 1 : 0);
        val_7 = val_7 & ((0 != 0) ? 1 : 0);
        label_2:
        if(0.MoveNext() == true)
        {
            goto label_4;
        }
        
        0.Dispose();
        if(((val_7 | val_6) & 1) != 0)
        {
                return;
        }
        
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  40);
    }
    public virtual void SetPopup(bool _isPopup)
    {
        this.isPopup = _isPopup;
    }
    public bool canPlay()
    {
        if(this.isPlaying == false)
        {
                return false;
        }
        
        return (bool)(this.isPopup == false) ? 1 : 0;
    }
    public float duration3()
    {
        var val_2;
        var val_3;
        var val_8;
        var val_9;
        List.Enumerator<T> val_1 = this.showAnim.GetEnumerator();
        val_8 = 1152921513418366288;
        float val_8 = 0f;
        val_9 = 1;
        label_21:
        if(val_3.MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_2 == 0)
        {
                throw new NullReferenceException();
        }
        
        if(val_2.Skeleton == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_5.data == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_5.data.FindAnimation(animationName:  "3")) == null)
        {
                throw new NullReferenceException();
        }
        
        val_8 = this.timeAppearPopupWin + ((val_6.duration >= val_8) ? val_6.duration : (val_8));
        goto label_21;
        label_2:
        val_3.Dispose();
        return val_8;
    }
    protected void HandleTutorial(System.Collections.Generic.List<UnityEngine.Vector2> positions)
    {
        var val_10;
        System.Func<System.Int32, System.Boolean> val_12;
        DG.Tweening.TweenCallback val_13;
        var val_14;
        Level.<>c__DisplayClass32_0 val_1 = new Level.<>c__DisplayClass32_0();
        .<>4__this = this;
        .positions = positions;
        val_10 = null;
        val_10 = null;
        val_12 = Level.<>c.<>9__32_0;
        if(val_12 == null)
        {
                System.Func<System.Int32, System.Boolean> val_2 = null;
            val_12 = val_2;
            val_2 = new System.Func<System.Int32, System.Boolean>(object:  Level.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Level.<>c::<HandleTutorial>b__32_0(int x));
            Level.<>c.<>9__32_0 = val_12;
        }
        
        int val_3 = System.Linq.Enumerable.FirstOrDefault<System.Int32>(source:  this.levelTutorial, predicate:  val_2);
        .levelTut = val_3;
        if(val_3 == 0)
        {
            goto label_7;
        }
        
        DataManager val_4 = LazySingleton<DataManager>.Instance;
        StageData val_5 = val_4.stagesAsset.StageStatus(index:  (Level.<>c__DisplayClass32_0)[1152921513419911376].levelTut);
        if((public static DataManager LazySingleton<DataManager>::get_Instance()) == 0)
        {
            goto label_11;
        }
        
        return;
        label_7:
        DG.Tweening.TweenCallback val_6 = null;
        val_13 = val_6;
        val_6 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Level.<>c__DisplayClass32_0::<HandleTutorial>b__2());
        val_14 = 1;
        goto label_12;
        label_11:
        DG.Tweening.TweenCallback val_8 = null;
        val_13 = val_8;
        val_8 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void Level.<>c__DisplayClass32_0::<HandleTutorial>b__1());
        val_14 = 1;
        label_12:
        DG.Tweening.Tween val_9 = DG.Tweening.DOVirtual.DelayedCall(delay:  (((Level.<>c__DisplayClass32_0)[1152921513419911376].levelTut) == 1) ? 0.5f : 10f, callback:  val_8, ignoreTimeScale:  true);
    }
    public Level()
    {
        this.isPlaying = true;
        this.levelType = true;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_1.Add(item:  1);
        val_1.Add(item:  2);
        val_1.Add(item:  3);
        val_1.Add(item:  4);
        val_1.Add(item:  5);
        val_1.Add(item:  6);
        val_1.Add(item:  13);
        this.levelTutorial = val_1;
    }
    private void <WaitAnimWin>b__27_0()
    {
        if(this.tick != null)
        {
                this.tick.SetActive(value:  false);
            return;
        }
        
        throw new NullReferenceException();
    }

}
