using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass35_0
{
    // Fields
    public int v;
    public UnityEngine.UI.Text target;
    public bool addThousandsSeparator;
    public System.Globalization.CultureInfo cInfo;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass35_0()
    {
    
    }
    internal int <DOCounter>b__0()
    {
        return (int)this.v;
    }
    internal void <DOCounter>b__1(int x)
    {
        this.v = x;
        if(this.addThousandsSeparator != false)
        {
                string val_1 = this.v.ToString(format:  "N0", provider:  this.cInfo);
        }
        else
        {
                string val_2 = this.v.ToString();
        }
    
    }

}
