using UnityEngine;
public class LevelManager : MonoBehaviour
{
    // Fields
    private Level currentLevel;
    private Level nextLevel;
    private Level levelInstance;
    private UnityEngine.Transform levelTransform;
    private UnityEngine.SpriteRenderer mask;
    private UnityEngine.GameObject WrongEffect;
    private System.Collections.Generic.List<UnityEngine.Sprite> listMaskSpr;
    private string Adrress;
    
    // Methods
    private void Start()
    {
        var val_2 = null;
        UnityEngine.ResourceManagement.ResourceManager.<ExceptionHandler>k__BackingField = new System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception>(object:  this, method:  System.Void LevelManager::CustomExceptionHandler(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, System.Exception exception));
    }
    private void Awake()
    {
        null = null;
        System.Delegate val_2 = System.Delegate.Combine(a:  DataManager.OnDataLoaded, b:  new System.Action(object:  this, method:  System.Void LevelManager::DataManager_OnLoaded()));
        if(val_2 != null)
        {
                if(null != null)
        {
            goto label_4;
        }
        
        }
        
        DataManager.OnDataLoaded = val_2;
        return;
        label_4:
    }
    private void OnEnable()
    {
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  10, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelManager::InitLevelHandler(object obj)), eventType:  1);
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  50, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelManager::IngameWarningHandler(object obj)), eventType:  1);
    }
    private void DataManager_OnLoaded()
    {
        EventDispatcherExtension.PostEvent(sender:  this, eventID:  10);
        MusicManager.Play(actionOnDone:  0, time:  0f, loop:  true, fadeTime:  0.5f, audioSourceRealDelay:  0f);
    }
    private void OnDisable()
    {
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 != null)
        {
                val_1.RemoveListener(eventID:  10, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelManager::InitLevelHandler(object obj)));
        }
        
        EventDispatcher val_3 = LazySingleton<EventDispatcher>.Instance;
        if(val_3 == null)
        {
                return;
        }
        
        val_3.RemoveListener(eventID:  50, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelManager::IngameWarningHandler(object obj)));
    }
    private void InitLevelHandler(object obj)
    {
        var val_23;
        System.Func<UnityEngine.Sprite, System.Guid> val_25;
        var val_28;
        val_23 = null;
        val_23 = null;
        val_25 = LevelManager.<>c.<>9__13_0;
        if(val_25 == null)
        {
                System.Func<UnityEngine.Sprite, System.Guid> val_1 = null;
            val_25 = val_1;
            val_1 = new System.Func<UnityEngine.Sprite, System.Guid>(object:  LevelManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Guid LevelManager.<>c::<InitLevelHandler>b__13_0(UnityEngine.Sprite x));
            LevelManager.<>c.<>9__13_0 = val_25;
        }
        
        if(this.mask == null)
        {
                throw new NullReferenceException();
        }
        
        this.mask.sprite = System.Linq.Enumerable.FirstOrDefault<UnityEngine.Sprite>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.Sprite, System.Guid>(source:  this.listMaskSpr, keySelector:  val_1));
        DataManager val_4 = LazySingleton<DataManager>.Instance;
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_4.CurrentStage == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Debug.Log(message:  "INIT " + 0);
        if((UnityEngine.Object.op_Implicit(exists:  this.currentLevel)) != false)
        {
                if(this.currentLevel == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.AddressableAssets.Addressables.Release<UnityEngine.GameObject>(obj:  this.currentLevel.gameObject);
        }
        
        if(this.levelTransform == null)
        {
                throw new NullReferenceException();
        }
        
        System.Collections.IEnumerator val_9 = this.levelTransform.GetEnumerator();
        label_33:
        var val_24 = 0;
        val_24 = val_24 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_23;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        object val_13 = val_9.Current;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Object.Destroy(obj:  val_13.gameObject);
        goto label_33;
        label_23:
        val_25 = 0;
        if(X0 == false)
        {
            goto label_34;
        }
        
        var val_28 = X0;
        if((X0 + 294) == 0)
        {
            goto label_38;
        }
        
        var val_26 = X0 + 176;
        var val_27 = 0;
        val_26 = val_26 + 8;
        label_37:
        if(((X0 + 176 + 8) + -8) == null)
        {
            goto label_36;
        }
        
        val_27 = val_27 + 1;
        val_26 = val_26 + 16;
        if(val_27 < (X0 + 294))
        {
            goto label_37;
        }
        
        goto label_38;
        label_36:
        val_28 = val_28 + (((X0 + 176 + 8)) << 4);
        val_28 = val_28 + 304;
        label_38:
        X0.Dispose();
        label_34:
        if(val_25 != 0)
        {
                throw val_25;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.nextLevel)) != false)
        {
                if(this.nextLevel == null)
        {
                throw new NullReferenceException();
        }
        
            DataManager val_17 = LazySingleton<DataManager>.Instance;
            if(val_17 == null)
        {
                throw new NullReferenceException();
        }
        
            if(val_17.CurrentStage == null)
        {
                throw new NullReferenceException();
        }
        
            if((System.String.op_Equality(a:  this.nextLevel.name, b:  0)) != false)
        {
                this.currentLevel = this.nextLevel;
            this.nextLevel = 0;
            this.InitLevel();
            return;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.nextLevel)) != false)
        {
                if(this.nextLevel == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.AddressableAssets.Addressables.Release<UnityEngine.GameObject>(obj:  this.nextLevel.gameObject);
        }
        
        this.nextLevel = 0;
        UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.LoadLevelAddressable());
    }
    private void IngameWarningHandler(object obj)
    {
        this.WrongEffect.SetActive(value:  (null != 0) ? 1 : 0);
        if(null == null)
        {
                return;
        }
        
        DG.Tweening.Tween val_3 = DG.Tweening.DOVirtual.DelayedCall(delay:  2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void LevelManager::<IngameWarningHandler>b__14_0()), ignoreTimeScale:  true);
    }
    private void InitLevel()
    {
        Level val_1 = UnityEngine.Object.Instantiate<Level>(original:  this.currentLevel, parent:  this.levelTransform);
        this.levelInstance = val_1;
        val_1.name = this.currentLevel.name;
        this.AfterInitLevel();
    }
    private void AfterInitLevel()
    {
        null = null;
        FirebaseManager.<Instance>k__BackingField.LogEvent(eventName:  "Level_start");
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  11, param:  this.levelInstance);
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void LevelManager::<AfterInitLevel>b__16_0()), ignoreTimeScale:  true);
    }
    private StageData getUnlimitedLevel()
    {
        var val_17;
        var val_18;
        DG.Tweening.TweenCallback val_20;
        var val_21;
        StageData val_22;
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        var val_3 = W23 - 199;
        val_18 = null;
        int val_19 = 0;
        val_18 = null;
        val_19 = val_19 * 50;
        val_20 = LevelManager.<>c.<>9__17_0;
        if(val_20 == null)
        {
                DG.Tweening.TweenCallback val_5 = null;
            val_20 = val_5;
            val_5 = new DG.Tweening.TweenCallback(object:  LevelManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LevelManager.<>c::<getUnlimitedLevel>b__17_0());
            LevelManager.<>c.<>9__17_0 = val_20;
        }
        
        DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  1f, callback:  val_5, ignoreTimeScale:  true);
        val_21 = 0;
        val_22 = 0;
        goto label_16;
        label_18:
        DataManager val_11 = LazySingleton<DataManager>.Instance;
        val_17 = val_11.stagesAsset.StageStatus(index:  UnityEngine.Random.Range(min:  val_19, max:  val_19 + 50));
        StageData val_14 = LazySingleton<DataManager>.Instance.CurrentStage;
        DataManager val_15 = LazySingleton<DataManager>.Instance;
        if((val_15.stagesAsset.FindStage(name:  0, indexMin:  val_19 + 200, indexMax:  W24)) == null)
        {
                StageData val_17 = null;
            val_22 = val_17;
            val_17 = new StageData();
            val_21 = 1;
            mem[1152921513460694704] = 1152921504884428800;
            mem[1152921513460694728] = W23 + 1;
            .level = W23 + 2;
            .failCount = 4294967295;
            .winCount = 0;
            mem[1152921513460694752] = 0;
            mem[1152921513460694712] = 1152921504884428800;
        }
        
        label_16:
        if((val_21 & 1) == 0)
        {
            goto label_18;
        }
        
        LazySingleton<DataManager>.Instance.Add(item:  val_17);
        return val_22;
    }
    private System.Collections.IEnumerator LoadLevelAddressable()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LevelManager.<LoadLevelAddressable>d__18();
    }
    private void OnCompletedCurrentLevel(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> obj)
    {
        this.currentLevel = obj.Result.GetComponent<Level>();
        this.InitLevel();
    }
    private void PreloadLevel()
    {
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        DataManager val_3 = LazySingleton<DataManager>.Instance;
        int val_4 = W21 + 1;
        if(val_4 >= val_3.stagesAsset)
        {
                return;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.PreLoadLevelAddressable(index:  val_4));
    }
    private System.Collections.IEnumerator PreLoadLevelAddressable(int index)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .index = index;
        return (System.Collections.IEnumerator)new LevelManager.<PreLoadLevelAddressable>d__21();
    }
    private void OnCompletedNextLevel(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> obj)
    {
        if((UnityEngine.Object.op_Implicit(exists:  obj.Result)) == false)
        {
                return;
        }
        
        this.nextLevel = obj.Result.GetComponent<Level>();
    }
    private void CustomExceptionHandler(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, System.Exception exception)
    {
        if((System.Type.op_Inequality(left:  exception.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
                return;
        }
        
        UnityEngine.AddressableAssets.Addressables.LogException(op:  new UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle() {m_InternalOp = handle.m_InternalOp, m_Version = 264733504, m_LocationName = handle.m_LocationName}, ex:  exception);
    }
    public LevelManager()
    {
        this.Adrress = "";
    }
    private void <IngameWarningHandler>b__14_0()
    {
        if(this.WrongEffect != null)
        {
                this.WrongEffect.SetActive(value:  false);
            return;
        }
        
        throw new NullReferenceException();
    }
    private void <AfterInitLevel>b__16_0()
    {
        StageData val_2 = LazySingleton<DataManager>.Instance.CurrentStage;
        if((W21 + 1) >= val_3.stagesAsset)
        {
                StageData val_5 = LazySingleton<DataManager>.Instance.getUnlimitedLevel();
        }
        
        this.PreloadLevel();
    }

}
