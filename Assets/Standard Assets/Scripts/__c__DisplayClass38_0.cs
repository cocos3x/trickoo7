using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass38_0
{
    // Fields
    public UnityEngine.Color to;
    public UnityEngine.UI.Graphic target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass38_0()
    {
    
    }
    internal UnityEngine.Color <DOBlendableColor>b__0()
    {
        return new UnityEngine.Color() {r = this.to};
    }
    internal void <DOBlendableColor>b__1(UnityEngine.Color x)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = x.r, g = x.g, b = x.b, a = x.a}, b:  new UnityEngine.Color() {r = this.to});
        this.to = x;
        mem[1152921513295064532] = x.g;
        mem[1152921513295064536] = x.b;
        mem[1152921513295064540] = x.a;
        UnityEngine.Color val_2 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, b:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        goto typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_2A0;
    }

}
