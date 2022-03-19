using UnityEngine;
private sealed class LevelManager.<PreLoadLevelAddressable>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int index;
    public LevelManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelManager.<PreLoadLevelAddressable>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        DataManager val_1 = LazySingleton<DataManager>.Instance;
        StageData val_2 = val_1.stagesAsset.StageStatus(index:  this.index);
        string val_3 = "Level/"("Level/") + this.index;
        this.<>4__this.Adrress = val_3;
        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> val_4 = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<UnityEngine.GameObject>(key:  val_3);
        0.add_Completed(value:  new System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject>>(object:  this.<>4__this, method:  System.Void LevelManager::OnCompletedNextLevel(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> obj)));
        this.<>2__current = 0;
        val_7 = 1;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        val_7 = 0;
        this.<>1__state = 0;
        return (bool)val_7;
        label_2:
        val_7 = 0;
        return (bool)val_7;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
