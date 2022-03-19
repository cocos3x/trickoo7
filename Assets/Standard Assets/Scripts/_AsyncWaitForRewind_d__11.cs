using UnityEngine;
private struct DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11 : IAsyncStateMachine
{
    // Fields
    public int <>1__state;
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
    public DG.Tweening.Tween t;
    private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;
    
    // Methods
    private void MoveNext()
    {
        DG.Tweening.Tween val_5;
        if((new DOTweenModuleUnityVersion.<AsyncWaitForRewind>d__11()) == 0)
        {
            goto label_1;
        }
        
        val_5 = this.t;
        if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.t.<active>k__BackingField) == true)
        {
            goto label_3;
        }
        
        if(DG.Tweening.Core.Debugger._LogPrefix < 1)
        {
            goto label_15;
        }
        
        DG.Tweening.Core.Debugger.LogInvalidTween(t:  this.t);
        goto label_15;
        label_1:
        this.<>u__1 = 0;
        this = 0;
        goto label_7;
        label_17:
        YieldAwaiter val_2 = System.Threading.Tasks.Task.Yield().GetAwaiter();
        if(val_2.IsCompleted == false)
        {
            goto label_13;
        }
        
        label_7:
        val_2.GetResult();
        val_5 = this.t;
        label_3:
        if((this.t.<active>k__BackingField) == false)
        {
            goto label_15;
        }
        
        if((this.t.<playedOnce>k__BackingField) == false)
        {
            goto label_17;
        }
        
        val_5 = (DG.Tweening.TweenExtensions.CompletedLoops(t:  val_5)) + 1;
        float val_5 = (float)val_5;
        val_5 = (this.t.<position>k__BackingField) * val_5;
        if(val_5 > 0f)
        {
            goto label_17;
        }
        
        label_15:
        this.<>t__builder = -2;
        SetResult();
        return;
        label_13:
        this = 0;
        this.<>u__1 = val_2;
        this.<>t__builder.AwaitUnsafeOnCompleted<YieldAwaiter, <AsyncWaitForRewind>d__11>(awaiter: ref  new YieldAwaiter(), stateMachine: ref  new <AsyncWaitForRewind>d__11() {<>1__state = this, <>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder()}}, <>u__1 = new YieldAwaitable.YieldAwaiter()});
    }
    private void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
    {
        this.<>t__builder.SetStateMachine(stateMachine:  stateMachine);
    }

}
