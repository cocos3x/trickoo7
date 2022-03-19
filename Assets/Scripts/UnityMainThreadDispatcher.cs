using UnityEngine;
public class UnityMainThreadDispatcher : MonoBehaviour
{
    // Fields
    public bool dontDestroyOnLoad;
    private static readonly System.Collections.Generic.Queue<System.Action> _executionQueue;
    private static UnityMainThreadDispatcher _instance;
    
    // Methods
    public void Update()
    {
        var val_3;
        var val_4;
        var val_5;
        System.Collections.Generic.Queue<System.Action> val_6;
        val_3 = 1152921504876814336;
        val_4 = null;
        val_4 = null;
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  UnityMainThreadDispatcher._executionQueue, lockTaken: ref  val_1);
        label_11:
        val_5 = null;
        val_5 = null;
        val_6 = UnityMainThreadDispatcher._executionQueue;
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        if((UnityMainThreadDispatcher._executionQueue + 32) < 1)
        {
            goto label_6;
        }
        
        val_6 = UnityMainThreadDispatcher._executionQueue;
        System.Action val_2 = val_6.Dequeue();
        if(val_2 == null)
        {
                throw new NullReferenceException();
        }
        
        val_2.Invoke();
        goto label_11;
        label_6:
        val_3 = 0;
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  UnityMainThreadDispatcher._executionQueue);
        }
        
        if(val_3 != 0)
        {
                throw val_3;
        }
    
    }
    public void Enqueue(System.Collections.IEnumerator action)
    {
        object val_4;
        var val_5;
        var val_6;
        UnityMainThreadDispatcher.<>c__DisplayClass3_0 val_1 = null;
        val_4 = val_1;
        val_1 = new UnityMainThreadDispatcher.<>c__DisplayClass3_0();
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        .<>4__this = this;
        .action = action;
        val_5 = null;
        val_5 = null;
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  UnityMainThreadDispatcher._executionQueue, lockTaken: ref  val_2);
        val_6 = null;
        val_6 = null;
        UnityMainThreadDispatcher._executionQueue.Enqueue(item:  new System.Action(object:  val_1, method:  System.Void UnityMainThreadDispatcher.<>c__DisplayClass3_0::<Enqueue>b__0()));
        val_4 = 0;
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  UnityMainThreadDispatcher._executionQueue);
        }
        
        if(val_4 != 0)
        {
                throw val_4;
        }
    
    }
    public void Enqueue(System.Action action)
    {
        this.Enqueue(action:  this.ActionWrapper(a:  action));
    }
    private System.Collections.IEnumerator ActionWrapper(System.Action a)
    {
        .<>1__state = 0;
        .a = a;
        return (System.Collections.IEnumerator)new UnityMainThreadDispatcher.<ActionWrapper>d__5();
    }
    public static bool Exists()
    {
        null = null;
        return UnityEngine.Object.op_Inequality(x:  UnityMainThreadDispatcher._instance, y:  0);
    }
    public static UnityMainThreadDispatcher Instance()
    {
        var val_3;
        var val_4;
        val_3 = null;
        if(UnityMainThreadDispatcher.Exists() == false)
        {
                throw new System.Exception(message:  "UnityMainThreadDispatcher could not find the UnityMainThreadDispatcher object. Please ensure you have added the MainThreadExecutor Prefab to your scene.");
        }
        
        val_4 = null;
        val_4 = null;
        return (UnityMainThreadDispatcher)UnityMainThreadDispatcher._instance;
    }
    private void Awake()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(UnityMainThreadDispatcher._instance != 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        UnityMainThreadDispatcher._instance = this;
        if(this.dontDestroyOnLoad == false)
        {
                return;
        }
        
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnDestroy()
    {
        null = null;
        UnityMainThreadDispatcher._instance = 0;
    }
    public UnityMainThreadDispatcher()
    {
        this.dontDestroyOnLoad = true;
    }
    private static UnityMainThreadDispatcher()
    {
        UnityMainThreadDispatcher._executionQueue = new System.Collections.Generic.Queue<System.Action>();
        UnityMainThreadDispatcher._instance = 0;
    }

}
