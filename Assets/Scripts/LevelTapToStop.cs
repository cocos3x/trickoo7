using UnityEngine;
public class LevelTapToStop : Level
{
    // Fields
    protected string animIdle;
    protected string animWin;
    protected string animLose;
    protected PowerBar powerBar;
    
    // Methods
    private void Awake()
    {
        mem[1152921513441172244] = 8;
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  -0.1f, y:  0.2f);
        UnityEngine.Vector3 val_4 = this.powerBar.transform.position;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_1.Add(item:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        UnityEngine.Vector3 val_7 = this.powerBar.transform.position;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        val_1.Add(item:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        UnityEngine.Vector3 val_11 = this.powerBar.transform.position;
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_1.Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        this.HandleTutorial(positions:  val_1);
    }
    protected override void Start()
    {
        this.Start();
        mem[1152921513441317008] = 0;
        List.Enumerator<T> val_1 = this.GetEnumerator();
        label_3:
        if(0.MoveNext() == false)
        {
            goto label_2;
        }
        
        Util.DisplaySpineAnim(animName:  this.animIdle, anim:  0, isLoop:  true, timeScale:  1f);
        goto label_3;
        label_2:
        0.Dispose();
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        EventDispatcherExtension.RegisterListener(listener:  this, eventID:  111, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelTapToStop::OnCheckPowerBarHandler(object obj)), eventType:  1);
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        EventDispatcher val_1 = LazySingleton<EventDispatcher>.Instance;
        if(val_1 == null)
        {
                return;
        }
        
        val_1.RemoveListener(eventID:  111, callback:  new System.Action<System.Object>(object:  this, method:  System.Void LevelTapToStop::OnCheckPowerBarHandler(object obj)));
    }
    private void OnCheckPowerBarHandler(object obj)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DisplayResultAnim(isWin:  false));
    }
    private System.Collections.IEnumerator DisplayResultAnim(bool isWin)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .isWin = isWin;
        return (System.Collections.IEnumerator)new LevelTapToStop.<DisplayResultAnim>d__9();
    }
    public LevelTapToStop()
    {
        this.animIdle = "1";
        this.animWin = "2";
        this.animLose = "3";
    }
    private void <DisplayResultAnim>b__9_0()
    {
        if(this != null)
        {
                this.SetActive(value:  false);
            return;
        }
        
        throw new NullReferenceException();
    }

}
