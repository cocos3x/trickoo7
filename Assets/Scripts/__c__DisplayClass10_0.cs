using UnityEngine;
private sealed class ListItem2.<>c__DisplayClass10_0
{
    // Fields
    public int index;
    public SuperScrollView.ListItem2 <>4__this;
    
    // Methods
    public ListItem2.<>c__DisplayClass10_0()
    {
    
    }
    internal void <Init>b__0(UnityEngine.GameObject obj)
    {
        if((this.<>4__this) != null)
        {
                this.<>4__this.OnStarClicked(index:  this.index);
            return;
        }
        
        throw new NullReferenceException();
    }

}
