using UnityEngine;
public class SelfRecycle : MonoBehaviour
{
    // Fields
    private float timeExist;
    private float currentTime;
    
    // Methods
    private void OnEnable()
    {
        this.currentTime = this.timeExist;
    }
    private void LateUpdate()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.currentTime - val_1;
        this.currentTime = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        ObjectPoolExtensions.Recycle(obj:  this.gameObject);
    }
    public SelfRecycle()
    {
    
    }

}
