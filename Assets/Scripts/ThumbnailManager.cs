using UnityEngine;
public class ThumbnailManager : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.Sprite> thumbnailsLevel;
    
    // Methods
    public UnityEngine.Sprite getSpriteByLevel(string level)
    {
        var val_8;
        List.Enumerator<T> val_3 = this.thumbnailsLevel.GetEnumerator();
        label_6:
        if(0.MoveNext() == false)
        {
            goto label_4;
        }
        
        val_8 = 0;
        if(val_8 == 0)
        {
                throw new NullReferenceException();
        }
        
        if((System.String.op_Equality(a:  val_8.name, b:  level.Replace(oldValue:  "L", newValue:  "l").Replace(oldValue:  "_b", newValue:  System.String.alignConst))) == false)
        {
            goto label_6;
        }
        
        0.Dispose();
        return (UnityEngine.Sprite)val_8;
        label_4:
        0.Dispose();
        val_8 = System.Linq.Enumerable.FirstOrDefault<UnityEngine.Sprite>(source:  this.thumbnailsLevel);
        return (UnityEngine.Sprite)val_8;
    }
    public ThumbnailManager()
    {
        this.thumbnailsLevel = new System.Collections.Generic.List<UnityEngine.Sprite>();
    }

}
