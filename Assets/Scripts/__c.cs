using UnityEngine;
[Serializable]
private sealed class LocalizationManager.<>c
{
    // Fields
    public static readonly Assets.SimpleLocalization.LocalizationManager.<>c <>9;
    public static System.Func<string, string> <>9__9_0;
    public static System.Func<string, string> <>9__9_1;
    public static System.Func<string, string> <>9__9_2;
    
    // Methods
    private static LocalizationManager.<>c()
    {
        LocalizationManager.<>c.<>9 = new LocalizationManager.<>c();
    }
    public LocalizationManager.<>c()
    {
    
    }
    internal string <Read>b__9_0(string i)
    {
        if(i != null)
        {
                return i.Trim();
        }
        
        throw new NullReferenceException();
    }
    internal string <Read>b__9_1(string j)
    {
        if(j != null)
        {
                return j.Trim();
        }
        
        throw new NullReferenceException();
    }
    internal string <Read>b__9_2(string j)
    {
        return j.Replace(oldValue:  "[comma]", newValue:  ",").Replace(oldValue:  "[newline]", newValue:  "\n").Replace(oldValue:  "[quotes]", newValue:  "\"");
    }
    internal void <.cctor>b__15_0()
    {
    
    }

}
