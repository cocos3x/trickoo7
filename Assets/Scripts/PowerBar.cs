using UnityEngine;
public class PowerBar : MonoBehaviour
{
    // Fields
    private Level level;
    private UnityEngine.Transform startPoint;
    private UnityEngine.Transform endPoint;
    private UnityEngine.Transform powerBar;
    private float barChangeSpeed;
    private float startWin;
    private float endWin;
    private UnityEngine.Transform winBar;
    private float maxPowerBarValue;
    private float currentPowerBarValue;
    private bool powerIsIncreasing;
    private bool powerBarOn;
    private UnityEngine.Vector2 offset;
    private float distance;
    private UnityEngine.RuntimePlatform platform;
    
    // Methods
    private void Start()
    {
        this.platform = UnityEngine.Application.platform;
        this.currentPowerBarValue = 0f;
        this.powerIsIncreasing = true;
        this.powerBarOn = true;
        UnityEngine.Vector3 val_2 = this.startPoint.localPosition;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.offset = val_3;
        mem[1152921513451428832] = val_3.y;
        UnityEngine.Vector3 val_4 = this.startPoint.localPosition;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = this.endPoint.localPosition;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.distance = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
        this.SetupWinBar();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.UpdatePowerBar());
    }
    public void EnablePowerBar()
    {
        if(this.powerBarOn != false)
        {
                return;
        }
        
        this.powerBarOn = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.UpdatePowerBar());
    }
    private void SetupWinBar()
    {
        UnityEngine.Vector3 val_1 = this.winBar.localPosition;
        float val_4 = this.startWin;
        val_4 = this.endWin + val_4;
        val_4 = val_4 * 0.5f;
        val_4 = this.distance * val_4;
        val_4 = this.offset + val_4;
        this.winBar.localPosition = new UnityEngine.Vector3() {x = val_4, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = this.winBar.localScale;
        float val_5 = 1.28f;
        float val_3 = this.endWin - this.startWin;
        val_3 = this.distance * val_3;
        val_5 = val_3 / val_5;
        this.winBar.localScale = new UnityEngine.Vector3() {x = val_5, y = val_2.y, z = val_2.z};
    }
    private System.Collections.IEnumerator UpdatePowerBar()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new PowerBar.<UpdatePowerBar>d__18();
    }
    private void SetPowerBarValue(float value)
    {
        UnityEngine.Vector3 val_1 = this.powerBar.localPosition;
        UnityEngine.Vector2 val_3 = this.offset;
        val_3 = (this.distance * value) + val_3;
        this.powerBar.localPosition = new UnityEngine.Vector3() {x = val_3, y = val_1.y, z = val_1.z};
    }
    public void StopPowerBar()
    {
        bool val_2;
        if(this.powerBarOn == false)
        {
                return;
        }
        
        if(this.level.canPlay() == false)
        {
                return;
        }
        
        this.powerBarOn = false;
        SoundManager.Play(fileName:  "Button");
        float val_2 = this.maxPowerBarValue;
        val_2 = this.currentPowerBarValue / val_2;
        if(val_2 >= this.startWin)
        {
                if(val_2 <= this.endWin)
        {
            goto label_7;
        }
        
        }
        
        val_2 = 0;
        goto label_8;
        label_7:
        val_2 = true;
        label_8:
        EventDispatcherExtension.PostEvent(listener:  this, eventID:  111, param:  val_2);
    }
    public PowerBar()
    {
        this.maxPowerBarValue = 100f;
    }

}
