using UnityEngine;
private struct DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15 : IAsyncStateMachine
{
    // Fields
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
    public DG.Tweening.Tween t;
    private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;
    
    // Methods
    private void MoveNext()
    {
        DG.Tweening.Tween val_4;
        if((new DOTweenModuleUnityVersion.<AsyncWaitForStart>d__15()) == 0)
        {
            goto label_1;
        }
        
        val_4 = this.t;
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.t.<active>k__BackingField) == true)
        {
            goto label_3;
        }
        
        if(DG.Tweening.Core.Debugger._LogPrefix < 1)
        {
            goto label_11;
        }
        
        DG.Tweening.Core.Debugger.LogInvalidTween(t:  this.t);
        goto label_11;
        label_1:
        this.<>u__1 = 0;
        this = 0;
        goto label_7;
        label_16:
        if((this.t.<playedOnce>k__BackingField) == true)
        {
            goto label_11;
        }
        
        YieldAwaiter val_2 = System.Threading.Tasks.Task.Yield().GetAwaiter();
        if(val_2.IsCompleted == false)
        {
            goto label_14;
        }
        
        label_7:
        val_2.GetResult();
        val_4 = this.t;
        label_3:
        if((this.t.<active>k__BackingField) == true)
        {
            goto label_16;
        }
        
        label_11:
        this.<>t__builder = -2;
        SetResult();
        return;
        label_14:
        this = 0;
        this.<>u__1 = val_2;
        this.<>t__builder.AwaitUnsafeOnCompleted<YieldAwaiter, <AsyncWaitForStart>d__15>(awaiter: ref  new YieldAwaiter(), stateMachine: ref  new <AsyncWaitForStart>d__15() {<>1__state = this, <>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder()}}, <>u__1 = new YieldAwaitable.YieldAwaiter()});
    }
    private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
    {
        this.<>t__builder.SetStateMachine(stateMachine:  stateMachine);
    }

}
