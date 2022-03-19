using UnityEngine;
public class SoundManager.SoundObj
{
    // Fields
    public UnityEngine.GameObject gameObject;
    public UnityEngine.AudioSource aSource;
    
    // Methods
    public SoundManager.SoundObj(string name, UnityEngine.Transform parent)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  name);
        this.gameObject = val_1;
        val_1.transform.parent = parent;
        this.aSource = this.gameObject.AddComponent<UnityEngine.AudioSource>();
    }

}
