using UnityEngine;
public static class DOTweenModuleUtils.Physics
{
    // Methods
    public static void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans)
    {
        if(options.useLocalPosition != false)
        {
                t.target.rotation = new UnityEngine.Quaternion() {x = newRot.x, y = newRot.y, z = newRot.z, w = newRot.w};
            return;
        }
        
        trans.rotation = new UnityEngine.Quaternion() {x = newRot.x, y = newRot.y, z = newRot.z, w = newRot.w};
    }
    public static bool HasRigidbody2D(UnityEngine.Component target)
    {
        return UnityEngine.Object.op_Inequality(x:  target.GetComponent<UnityEngine.Rigidbody2D>(), y:  0);
    }
    public static bool HasRigidbody(UnityEngine.Component target)
    {
        return UnityEngine.Object.op_Inequality(x:  target.GetComponent<UnityEngine.Rigidbody>(), y:  0);
    }
    public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode)
    {
        bool val_4 = tweenRigidbody;
        if(val_4 == false)
        {
            goto label_1;
        }
        
        val_4 = target.GetComponent<UnityEngine.Rigidbody>();
        if(val_4 == 0)
        {
            goto label_5;
        }
        
        if(isLocal == false)
        {
                return DG.Tweening.DOTweenModulePhysics.DOPath(target:  val_4, path:  path, duration:  duration, pathMode:  pathMode);
        }
        
        return DG.Tweening.DOTweenModulePhysics.DOLocalPath(target:  val_4, path:  path, duration:  duration, pathMode:  pathMode);
        label_1:
        label_5:
        UnityEngine.Transform val_3 = target.transform;
        if(isLocal == false)
        {
                return DG.Tweening.ShortcutExtensions.DOPath(target:  val_3, path:  path, duration:  duration, pathMode:  pathMode);
        }
        
        return DG.Tweening.ShortcutExtensions.DOLocalPath(target:  val_3, path:  path, duration:  duration, pathMode:  pathMode);
    }

}
