using UnityEngine;
private sealed class StagesAsset.<>c__DisplayClass12_0
{
    // Fields
    public StageData stage;
    
    // Methods
    public StagesAsset.<>c__DisplayClass12_0()
    {
    
    }
    internal bool <LoadLevelFromData>b__0(StageData x)
    {
        return (bool)(x.level == this.stage.level) ? 1 : 0;
    }

}
