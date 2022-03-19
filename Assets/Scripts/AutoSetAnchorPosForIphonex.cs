using UnityEngine;
public class AutoSetAnchorPosForIphonex : MonoBehaviour
{
    // Fields
    public UnityEngine.Canvas mCanvas;
    
    // Methods
    private void Awake()
    {
        var val_16;
        float val_17;
        float val_18;
        val_16 = this;
        if((UnityEngine.Screen.width == 1125) && (UnityEngine.Screen.height == 2436))
        {
                UnityEngine.UI.CanvasScaler val_3 = this.mCanvas.GetComponent<UnityEngine.UI.CanvasScaler>();
            val_17 = S0 * 0.05418719f;
            val_16 = this.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  0f, y:  val_17);
            val_16.offsetMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            val_18 = -val_17;
        }
        else
        {
                if(UnityEngine.Screen.height != 1125)
        {
                return;
        }
        
            if(UnityEngine.Screen.width != 2436)
        {
                return;
        }
        
            UnityEngine.UI.CanvasScaler val_8 = this.mCanvas.GetComponent<UnityEngine.UI.CanvasScaler>();
            val_17 = (S0 / 1125f) * 132f;
            val_16 = this.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_17, y:  S0 * 0.056f);
            val_16.offsetMin = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            UnityEngine.Vector2 val_13;
            val_18 = 0f;
        }
        
        val_13 = new UnityEngine.Vector2(x:  -val_17, y:  val_18);
        val_16.offsetMax = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
    }
    public AutoSetAnchorPosForIphonex()
    {
    
    }

}
