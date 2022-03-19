using UnityEngine;
public static class TransformExtend
{
    // Methods
    public static void DoScale(UnityEngine.Transform transform, float scaleFrom = 1, float scaleTo = 1.05, float timeAnimation = 0.25, float delayTime = 0.01, bool autoRevese = True)
    {
        .transform = transform;
        .scaleFrom = scaleFrom;
        .timeAnimation = timeAnimation;
        if(transform == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TransformExtend] DoScale: "("[TransformExtend] DoScale: ") + (TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].transform.name((TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].transform.name) + " NULL");
            return;
        }
        
        (TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].transform.hasChanged = true;
        if(autoRevese != false)
        {
                int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  (TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].transform, complete:  false);
            float val_13 = 0.35f;
            val_13 = ((TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].timeAnimation) * val_13;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].transform, endValue:  scaleTo, duration:  val_13), action:  new DG.Tweening.TweenCallback(object:  new TransformExtend.<>c__DisplayClass0_0(), method:  System.Void TransformExtend.<>c__DisplayClass0_0::<DoScale>b__0())), ease:  8), delay:  delayTime);
            return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].transform, endValue:  scaleTo, duration:  (TransformExtend.<>c__DisplayClass0_0)[1152921513362597248].timeAnimation), ease:  8);
    }
    public static void DoMoveZ(UnityEngine.Transform transform, float from = 0, float to = -100, float timeAnimation = 0.25, float delayTime = 0.01, bool autoRevese = False, DG.Tweening.TweenCallback onDone)
    {
        float val_19;
        UnityEngine.Transform val_20;
        object val_21;
        val_19 = timeAnimation;
        val_20 = transform;
        TransformExtend.<>c__DisplayClass1_0 val_1 = null;
        val_21 = val_1;
        val_1 = new TransformExtend.<>c__DisplayClass1_0();
        .onDone = onDone;
        .transform = val_20;
        .from = from;
        .timeAnimation = val_19;
        if(val_20 == 0)
        {
                val_21 = "[TransformExtend] DoMoveZ: "("[TransformExtend] DoMoveZ: ") + (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform.name((TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform.name) + " NULL";
            UnityEngine.Debug.LogError(message:  val_21);
            return;
        }
        
        int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform, complete:  false);
        UnityEngine.Vector3 val_6 = (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform.localPosition;
        UnityEngine.Vector3 val_7 = (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform.localPosition;
        val_19 = val_7.x;
        if(autoRevese != false)
        {
                UnityEngine.Vector3 val_8 = (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform.localPosition;
            val_6.x.Set(newX:  val_19, newY:  val_8.y, newZ:  (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].from);
            float val_19 = 0.7f;
            val_19 = ((TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].timeAnimation) * val_19;
            DG.Tweening.TweenCallback val_10 = null;
            val_20 = val_10;
            val_10 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TransformExtend.<>c__DisplayClass1_0::<DoMoveZ>b__0());
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveZ(target:  (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform, endValue:  to, duration:  val_19, snapping:  false), action:  val_10), ease:  8), delay:  delayTime);
            return;
        }
        
        UnityEngine.Vector3 val_14 = (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform.localPosition;
        val_6.x.Set(newX:  val_19, newY:  val_14.y, newZ:  (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].from);
        if(((TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].onDone) == null)
        {
                return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveZ(target:  (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].transform, endValue:  to, duration:  (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].timeAnimation, snapping:  false), ease:  9), delay:  delayTime), action:  (TransformExtend.<>c__DisplayClass1_0)[1152921513362861952].onDone);
    }
    public static void DoRotateZ(UnityEngine.Transform transform, float to = 90, float timeAnimation = 0.25, float delayTime = 0.01, DG.Tweening.TweenCallback onDone)
    {
        .onDone = onDone;
        if(transform == 0)
        {
                UnityEngine.Debug.LogError(message:  "[TransformExtend] DoRotateZ: "("[TransformExtend] DoRotateZ: ") + transform.name + " NULL");
            return;
        }
        
        int val_5 = DG.Tweening.ShortcutExtensions.DOKill(target:  transform, complete:  false);
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  to);
        float val_12 = 0.7f;
        val_12 = timeAnimation * val_12;
        DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  val_12, mode:  0), action:  new DG.Tweening.TweenCallback(object:  new TransformExtend.<>c__DisplayClass2_0(), method:  System.Void TransformExtend.<>c__DisplayClass2_0::<DoRotateZ>b__0())), ease:  10), delay:  delayTime);
    }
    public static void DoShakeScreen(UnityEngine.Transform transform, float timeAnimation, float strength, float timeDelay = 0.01, DG.Tweening.TweenCallback onDone)
    {
        if(onDone != null)
        {
                return;
        }
        
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOShakePosition(target:  transform, duration:  timeAnimation, strength:  strength, vibrato:  10, randomness:  90f, snapping:  false, fadeOut:  true), delay:  timeDelay), action:  0);
    }
    public static void DoRotate(UnityEngine.Transform transform, float timeAnimation = 0.5, int loop = -1, DG.Tweening.TweenCallback onAnimationDone, bool resetLocal = False)
    {
        .onAnimationDone = onAnimationDone;
        if((UnityEngine.Object.op_Implicit(exists:  transform)) == false)
        {
                return;
        }
        
        int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  transform, complete:  false);
        if(resetLocal != false)
        {
                TransformExtend.SetLocalY(transform:  transform, y:  0f);
            TransformExtend.SetLocalRotation2D(transform:  transform, angle:  0f);
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  360f);
        DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  timeAnimation, mode:  1), ease:  1), loops:  loop, loopType:  2), action:  new DG.Tweening.TweenCallback(object:  new TransformExtend.<>c__DisplayClass4_0(), method:  System.Void TransformExtend.<>c__DisplayClass4_0::<DoRotate>b__0()));
    }
    public static void DoJump(UnityEngine.Transform transform, float timeAnimation = 0.5, int loop = -1, float detalY = 0.35, DG.Tweening.TweenCallback onAnimationDone, bool resetLocal = False)
    {
        .onAnimationDone = onAnimationDone;
        if((UnityEngine.Object.op_Implicit(exists:  transform)) == false)
        {
                return;
        }
        
        int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  transform, complete:  false);
        if(resetLocal != false)
        {
                TransformExtend.SetLocalY(transform:  transform, y:  0f);
            TransformExtend.SetLocalRotation2D(transform:  transform, angle:  0f);
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  transform, endValue:  detalY, duration:  timeAnimation, snapping:  false), loops:  loop, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  new TransformExtend.<>c__DisplayClass5_0(), method:  System.Void TransformExtend.<>c__DisplayClass5_0::<DoJump>b__0()));
    }
    public static UnityEngine.Transform ClearChild(UnityEngine.Transform transform)
    {
        int val_2 = transform.childCount - 1;
        if(<0)
        {
                return (UnityEngine.Transform)transform;
        }
        
        do
        {
            ObjectPoolExtensions.Recycle(obj:  transform.GetChild(index:  val_2).gameObject);
            val_2 = val_2 - 1;
        }
        while(>=0);
        
        return (UnityEngine.Transform)transform;
    }
    public static UnityEngine.Transform RecycleChild(UnityEngine.Transform transform)
    {
        int val_2 = transform.childCount - 1;
        if(<0)
        {
                return (UnityEngine.Transform)transform;
        }
        
        do
        {
            ObjectPoolExtensions.Recycle<UnityEngine.Transform>(obj:  transform.GetChild(index:  val_2));
            val_2 = val_2 - 1;
        }
        while(>=0);
        
        return (UnityEngine.Transform)transform;
    }
    public static System.Collections.Generic.List<UnityEngine.Transform> GetChilds(UnityEngine.Transform transform)
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_1 = new System.Collections.Generic.List<UnityEngine.Transform>();
        int val_2 = transform.childCount;
        if(val_2 < 1)
        {
                return val_1;
        }
        
        var val_4 = 0;
        do
        {
            val_1.Add(item:  transform.GetChild(index:  0));
            val_4 = val_4 + 1;
        }
        while(val_4 < val_2);
        
        return val_1;
    }
    public static float GetPosX(UnityEngine.Transform transform)
    {
        if(transform != null)
        {
                return transform.position;
        }
        
        throw new NullReferenceException();
    }
    public static float GetPosY(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.position;
        return (float)val_1.y;
    }
    public static float GetPosZ(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.position;
        return (float)val_1.z;
    }
    public static float GetLocalPosX(UnityEngine.Transform transform)
    {
        if(transform != null)
        {
                return transform.localPosition;
        }
        
        throw new NullReferenceException();
    }
    public static float GetLocalPosY(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        return (float)val_1.y;
    }
    public static float GetLocalPosZ(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        return (float)val_1.z;
    }
    public static void SetPosition(UnityEngine.Transform transform, UnityEngine.Vector3 pos)
    {
        if(transform != null)
        {
                transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            return;
        }
        
        throw new NullReferenceException();
    }
    public static void SetPosition(UnityEngine.Transform transform, float x, float y, float z = 0)
    {
        UnityEngine.Vector3 val_1 = transform.position;
        transform.position = new UnityEngine.Vector3() {x = x, y = y, z = z};
    }
    public static void SetX(UnityEngine.Transform transform, float x)
    {
        UnityEngine.Vector3 val_1 = transform.position;
        transform.position = new UnityEngine.Vector3() {x = x, y = val_1.y, z = val_1.z};
    }
    public static void SetY(UnityEngine.Transform transform, float y)
    {
        UnityEngine.Vector3 val_1 = transform.position;
        transform.position = new UnityEngine.Vector3() {x = val_1.x, y = y, z = val_1.z};
    }
    public static void SetZ(UnityEngine.Transform transform, float z)
    {
        UnityEngine.Vector3 val_1 = transform.position;
        transform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = z};
    }
    public static void SetLocalPosition(UnityEngine.Transform transform, UnityEngine.Vector3 pos)
    {
        if(transform != null)
        {
                transform.localPosition = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
            return;
        }
        
        throw new NullReferenceException();
    }
    public static void SetLocalPosition(UnityEngine.Transform transform, float x, float y, float z = 0)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        transform.localPosition = new UnityEngine.Vector3() {x = x, y = y, z = z};
    }
    public static void SetLocalX(UnityEngine.Transform transform, float x)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        transform.localPosition = new UnityEngine.Vector3() {x = x, y = val_1.y, z = val_1.z};
    }
    public static void SetLocalY(UnityEngine.Transform transform, float y)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = y, z = val_1.z};
    }
    public static void SetLocalZ(UnityEngine.Transform transform, float z)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = z};
    }
    public static void AddLocalX(UnityEngine.Transform transform, float x)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        val_1.x = val_1.x + x;
        transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public static void AddLocalY(UnityEngine.Transform transform, float y)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        val_1.y = val_1.y + y;
        transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public static void AddLocalZ(UnityEngine.Transform transform, float z)
    {
        UnityEngine.Vector3 val_1 = transform.localPosition;
        val_1.z = val_1.z + z;
        transform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public static float GetScaleX(UnityEngine.Transform transform)
    {
        if(transform != null)
        {
                return transform.localScale;
        }
        
        throw new NullReferenceException();
    }
    public static float GetScaleY(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.localScale;
        return (float)val_1.y;
    }
    public static float GetScaleZ(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.localScale;
        return (float)val_1.z;
    }
    public static void SetScale(UnityEngine.Transform transform, float scale)
    {
        TransformExtend.SetScale(transform:  transform, x:  scale, y:  scale, z:  scale);
    }
    public static void SetScale(UnityEngine.Transform transform, UnityEngine.Vector3 scale)
    {
        if(transform != null)
        {
                transform.localScale = new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z};
            return;
        }
        
        throw new NullReferenceException();
    }
    public static void SetScale(UnityEngine.Transform transform, float x, float y, float z = 1)
    {
        UnityEngine.Vector3 val_1 = transform.localScale;
        transform.localScale = new UnityEngine.Vector3() {x = x, y = y, z = z};
    }
    public static void SetScaleX(UnityEngine.Transform transform, float x)
    {
        UnityEngine.Vector3 val_1 = transform.localScale;
        transform.localScale = new UnityEngine.Vector3() {x = x, y = val_1.y, z = val_1.z};
    }
    public static void SetScaleY(UnityEngine.Transform transform, float y)
    {
        UnityEngine.Vector3 val_1 = transform.localScale;
        transform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = y, z = val_1.z};
    }
    public static void SetScaleZ(UnityEngine.Transform transform, float z)
    {
        UnityEngine.Vector3 val_1 = transform.localScale;
        transform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = z};
    }
    public static UnityEngine.Vector3 GetRotation(UnityEngine.Transform transform)
    {
        if(transform != null)
        {
                return transform.eulerAngles;
        }
        
        throw new NullReferenceException();
    }
    public static UnityEngine.Vector3 GetLocalRotation(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.localEulerAngles;
        float val_2 = -360f;
        val_2 = val_1.z + val_2;
        val_1.z = (val_1.z > 180f) ? (val_2) : val_1.z;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public static float GetRotation2D(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.eulerAngles;
        return (float)val_1.z;
    }
    public static float GetLocalRotation2D(UnityEngine.Transform transform)
    {
        UnityEngine.Vector3 val_1 = transform.localEulerAngles;
        return (float)val_1.z;
    }
    public static void SetRotation(UnityEngine.Transform transform, UnityEngine.Vector3 rot)
    {
        if(transform != null)
        {
                transform.eulerAngles = new UnityEngine.Vector3() {x = rot.x, y = rot.y, z = rot.z};
            return;
        }
        
        throw new NullReferenceException();
    }
    public static void SetLocalRotation(UnityEngine.Transform transform, UnityEngine.Vector3 rot)
    {
        if(transform != null)
        {
                transform.localEulerAngles = new UnityEngine.Vector3() {x = rot.x, y = rot.y, z = rot.z};
            return;
        }
        
        throw new NullReferenceException();
    }
    public static void SetRotation2D(UnityEngine.Transform transform, float angle)
    {
        UnityEngine.Vector3 val_1 = transform.eulerAngles;
        transform.eulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = angle};
    }
    public static void SetLocalRotation2D(UnityEngine.Transform transform, float angle)
    {
        UnityEngine.Vector3 val_1 = transform.localEulerAngles;
        transform.localEulerAngles = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = angle};
    }
    public static void SetLayer(UnityEngine.Transform trans, int layer)
    {
        int val_6;
        var val_7;
        var val_10;
        val_6 = layer;
        if(trans == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GameObject val_1 = trans.gameObject;
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_1.layer = val_6;
        val_7 = trans.GetEnumerator();
        label_17:
        var val_7 = 0;
        val_7 = val_7 + 1;
        if(val_7.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        if(val_7.Current == null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_8:
        val_6 = 0;
        if(X0 == false)
        {
            goto label_18;
        }
        
        var val_11 = X0;
        val_7 = X0;
        if((X0 + 294) == 0)
        {
            goto label_22;
        }
        
        var val_9 = X0 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_21:
        if(((X0 + 176 + 8) + -8) == null)
        {
            goto label_20;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X0 + 294))
        {
            goto label_21;
        }
        
        goto label_22;
        label_20:
        val_11 = val_11 + (((X0 + 176 + 8)) << 4);
        val_10 = val_11 + 304;
        label_22:
        val_7.Dispose();
        label_18:
        if(val_6 != 0)
        {
                throw val_6;
        }
    
    }

}
