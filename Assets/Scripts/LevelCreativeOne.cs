using UnityEngine;
public class LevelCreativeOne : Level
{
    // Fields
    protected int optionCount;
    protected Spine.Unity.SkeletonAnimation optionAnimMain;
    protected Spine.Unity.SkeletonAnimation optionAnimSub;
    protected Spine.Unity.SkeletonAnimation optionAnimOther;
    protected System.Collections.Generic.List<WinLoseAnim> optionAnimLose;
    protected System.Collections.Generic.List<WinLoseAnim> optionAnimWin;
    protected int type;
    private int step;
    private bool isDisplay;
    private int randomLose;
    private float timeScale;
    
    // Methods
    private void Awake()
    {
        mem[1152921513435338564] = 6;
    }
    protected override void Start()
    {
        this.Start();
        mem[1152921513435462848] = 0;
        this.randomLose = 1;
        if(this.type != 2)
        {
                return;
        }
        
        this.timeScale = 2f;
        Spine.TrackEntry val_1 = this.optionAnimMain.state.SetAnimation(trackIndex:  0, animationName:  "idle", loop:  true);
        val_1.timeScale = this.timeScale;
    }
    public void ChoseOption(int index)
    {
        var val_1;
        int val_2;
        if(true == 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        if(this.isDisplay != false)
        {
                return;
        }
        
        SoundManager.Play(fileName:  "Button");
        int val_1 = this.step;
        this.isDisplay = true;
        val_1 = val_1 + 1;
        this.step = val_1;
        if(val_1 > this.randomLose)
        {
                val_1 = 1;
            val_2 = index;
        }
        else
        {
                val_2 = index;
            val_1 = 0;
        }
        
        this.DisplayOption(index:  val_2, isWin:  false);
    }
    public void ChoseOptionDefault()
    {
        if(true == 0)
        {
                return;
        }
        
        if(true != 0)
        {
                return;
        }
        
        if(this.isDisplay != false)
        {
                return;
        }
        
        SoundManager.Play(fileName:  "Button");
        this.isDisplay = true;
        this.ChoseOptionAfterWait();
    }
    public void ChoseOptionAfterWait()
    {
        var val_2;
        var val_3;
        int val_2 = this.step;
        val_2 = val_2 + 1;
        this.step = val_2;
        if(val_2 > this.randomLose)
        {
                val_2 = 1;
            val_3 = 1;
        }
        else
        {
                if((UnityEngine.Random.Range(min:  1, max:  3)) >= 2)
        {
                val_2 = 2;
        }
        else
        {
                val_2 = 3;
        }
        
            val_3 = 0;
        }
        
        this.DisplayOption(index:  3, isWin:  false);
    }
    private void DisplayOption(int index, bool isWin)
    {
        int val_17;
        float val_18;
        int val_2 = (((isWin & true) != 0) ? (-1) : 1) + index;
        val_17 = this.optionCount;
        if(val_2 <= 0)
        {
            goto label_1;
        }
        
        if(val_2 <= val_17)
        {
            goto label_2;
        }
        
        val_17 = 1;
        label_1:
        label_2:
        val_18 = 0f;
        if((UnityEngine.Object.op_Implicit(exists:  this.optionAnimMain)) != false)
        {
                val_18 = (Util.GetSpineAnimDuration(animName:  index.ToString(), anim:  this.optionAnimMain)) / this.timeScale;
            string val_6 = index.ToString();
            val_6.DisplayAnim(animName:  val_6, anim:  this.optionAnimMain, timeScale:  this.timeScale);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.optionAnimSub)) != false)
        {
                if(this.type != 1)
        {
                if(isWin == false)
        {
            goto label_10;
        }
        
        }
        
            if(val_18 <= (Util.GetSpineAnimDuration(animName:  val_17.ToString(), anim:  this.optionAnimSub)))
        {
                val_18 = Util.GetSpineAnimDuration(animName:  val_17.ToString(), anim:  this.optionAnimSub);
        }
        
            string val_12 = val_17.ToString();
            val_12.DisplayAnim(animName:  val_12, anim:  this.optionAnimSub, timeScale:  1f);
        }
        
        label_10:
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.DisplayResultAnim(duration:  val_18, isWin:  isWin));
    }
    private void DisplayAnim(string animName, Spine.Unity.SkeletonAnimation anim, float timeScale = 1)
    {
        Spine.AnimationState val_2;
        if(anim == null)
        {
                throw new NullReferenceException();
        }
        
        val_2 = anim.state;
        if(val_2 == null)
        {
                throw new NullReferenceException();
        }
        
        if((val_2.SetAnimation(trackIndex:  0, animationName:  animName, loop:  false)) == null)
        {
                throw new NullReferenceException();
        }
        
        val_1.timeScale = timeScale;
    }
    private System.Collections.IEnumerator DisplayResultAnim(float duration, bool isWin)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .duration = duration;
        .isWin = isWin;
        return (System.Collections.IEnumerator)new LevelCreativeOne.<DisplayResultAnim>d__18();
    }
    public LevelCreativeOne()
    {
        this.type = 1;
        this.timeScale = 1f;
    }
    private void <DisplayResultAnim>b__18_0()
    {
        if(this != null)
        {
                this.SetActive(value:  false);
            return;
        }
        
        throw new NullReferenceException();
    }

}
