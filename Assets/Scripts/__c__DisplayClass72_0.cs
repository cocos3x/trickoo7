using UnityEngine;
private sealed class UIAnimation.<>c__DisplayClass72_0
{
    // Fields
    public int tempValue;
    public int nextValue;
    public UnityEngine.UI.Text text;
    public string fomat;
    public int endValue;
    public DG.Tweening.TweenCallback onDone;
    
    // Methods
    public UIAnimation.<>c__DisplayClass72_0()
    {
    
    }
    internal void <DoNumber>b__0(float e)
    {
        int val_1 = UnityEngine.Mathf.FloorToInt(f:  e);
        this.tempValue = val_1;
        if(val_1 == this.nextValue)
        {
                return;
        }
        
        this.nextValue = val_1;
        this = this.fomat;
        string val_2 = System.String.Format(format:  this, arg0:  val_1);
    }
    internal void <DoNumber>b__1()
    {
        string val_1 = System.String.Format(format:  this.fomat, arg0:  this.endValue);
        if(this.onDone == null)
        {
                return;
        }
        
        this.onDone.Invoke();
    }

}
