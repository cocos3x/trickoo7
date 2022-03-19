using UnityEngine;
public class UICore : MonoBehaviour
{
    // Fields
    protected UIAnimation anim;
    
    // Properties
    public UIAnimStatus state { get; }
    
    // Methods
    public UIAnimStatus get_state()
    {
        if(this.anim != null)
        {
                return (UIAnimStatus)this.anim.status;
        }
        
        throw new NullReferenceException();
    }
    protected virtual void Awake()
    {
        this.anim = this.GetComponent<UIAnimation>();
    }
    public virtual void Show(DG.Tweening.TweenCallback onDone)
    {
        if(this.anim != null)
        {
            
        }
        else
        {
                throw new NullReferenceException();
        }
    
    }
    public virtual void Hide()
    {
        if(this.anim != null)
        {
            
        }
        else
        {
                throw new NullReferenceException();
        }
    
    }
    public UICore()
    {
    
    }

}
