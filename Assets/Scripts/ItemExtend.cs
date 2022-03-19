using UnityEngine;
public static class ItemExtend
{
    // Methods
    public static bool IsCanUnlock(SaveData item)
    {
        if(item != null)
        {
                return true;
        }
        
        throw new NullReferenceException();
    }

}
