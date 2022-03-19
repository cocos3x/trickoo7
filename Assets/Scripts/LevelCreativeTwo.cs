using UnityEngine;
public class LevelCreativeTwo : Level
{
    // Fields
    protected bool preStart;
    protected string animWrong;
    protected string animRight;
    
    // Methods
    private void Awake()
    {
        mem[1152921513437826628] = 6;
    }
    protected override void Start()
    {
        this.Start();
        if(this.preStart == false)
        {
                return;
        }
        
        mem[1152921513437946805] = 0;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DisplayPreStart());
    }
    private System.Collections.IEnumerator DisplayPreStart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LevelCreativeTwo.<DisplayPreStart>d__5();
    }
    public override void RightOption()
    {
        if(true == 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        mem[1152921513438195381] = 0;
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  50, param:  null);
        SoundManager.Play(fileName:  "Answer_Right");
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DisplayRight());
        bool val_3 = UnityEngine.Object.op_Implicit(exists:  26865664);
        if(val_3 == false)
        {
                return;
        }
        
        val_3.SetActive(value:  false);
    }
    public override void WrongOption()
    {
        if(true == 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        mem[1152921513438328885] = 0;
        SoundManager.Play(fileName:  "Answer_Wrong");
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  50, param:  true);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DisplayWrong());
    }
    private System.Collections.IEnumerator DisplayRight()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LevelCreativeTwo.<DisplayRight>d__8();
    }
    private System.Collections.IEnumerator DisplayWrong()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LevelCreativeTwo.<DisplayWrong>d__9();
    }
    public LevelCreativeTwo()
    {
        this.animWrong = "";
        this.animRight = "";
    }
    private void <DisplayRight>b__8_0()
    {
        if(this != null)
        {
                this.SetActive(value:  false);
            return;
        }
        
        throw new NullReferenceException();
    }

}
