using UnityEngine;
private sealed class StagesAsset.<>c__DisplayClass9_0
{
    // Fields
    public string name;
    public int indexMin;
    public int indexMax;
    
    // Methods
    public StagesAsset.<>c__DisplayClass9_0()
    {
    
    }
    internal bool <FindStage>b__0(StageData x)
    {
        var val_3;
        if((System.String.op_Equality(a:  this, b:  this.name)) != false)
        {
                if(W8 >= this.indexMin)
        {
                return (bool)(W8 <= this.indexMax) ? 1 : 0;
        }
        
        }
        
        val_3 = 0;
        return (bool)(W8 <= this.indexMax) ? 1 : 0;
    }

}
