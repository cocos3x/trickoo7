using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModulePhysics2D
    {
        // Methods
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass0_0(), method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass0_0::<DOMove>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass0_0)[1152921513267622256].target, method:  public System.Void UnityEngine.Rigidbody2D::MovePosition(UnityEngine.Vector2 position)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModulePhysics2D.<>c__DisplayClass0_0)[1152921513267622256].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = False)
        {
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  endValue, y:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass1_0(), method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass1_0::<DOMoveX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass1_0)[1152921513267809008].target, method:  public System.Void UnityEngine.Rigidbody2D::MovePosition(UnityEngine.Vector2 position)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  2, snapping:  snapping), target:  (DOTweenModulePhysics2D.<>c__DisplayClass1_0)[1152921513267809008].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = False)
        {
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  endValue);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass2_0(), method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass2_0::<DOMoveY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass2_0)[1152921513267995760].target, method:  public System.Void UnityEngine.Rigidbody2D::MovePosition(UnityEngine.Vector2 position)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  4, snapping:  snapping), target:  (DOTweenModulePhysics2D.<>c__DisplayClass2_0)[1152921513267995760].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration)
        {
            .target = target;
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass3_0(), method:  System.Single DOTweenModulePhysics2D.<>c__DisplayClass3_0::<DORotate>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass3_0)[1152921513268179440].target, method:  public System.Void UnityEngine.Rigidbody2D::MoveRotation(float angle)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  val_4, target:  (DOTweenModulePhysics2D.<>c__DisplayClass3_0)[1152921513268179440].target);
            return val_4;
        }
        public static DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            DOTweenModulePhysics2D.<>c__DisplayClass4_0 val_1 = new DOTweenModulePhysics2D.<>c__DisplayClass4_0();
            .target = target;
            .endValue = endValue;
            mem[1152921513268445092] = endValue.y;
            .startPosY = 0f;
            .offsetYSet = false;
            .offsetY = -1f;
            int val_2 = (numJumps > 1) ? numJumps : (0 + 1);
            .s = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0f, y:  jumpPower);
            val_2 = val_2 << 1;
            float val_27 = (float)val_2;
            val_27 = duration / val_27;
            bool val_8 = snapping;
            .yTween = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, duration:  val_27), axisConstraint:  4, snapping:  val_8), ease:  6)), loops:  val_2, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__2()));
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921513268445040].endValue, y:  0f);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921513268445040].s, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__3()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__4(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, duration:  duration), axisConstraint:  2, snapping:  val_8), ease:  1)), t:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921513268445040].yTween), target:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921513268445040].target), ease:  DG.Tweening.DOTween.defaultEaseType);
            DG.Tweening.Tween val_26 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tween>(t:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921513268445040].yTween, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__5()));
            return (DG.Tweening.Sequence)(DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921513268445040].s;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType = 0, DG.Tweening.PathMode pathMode = 1, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor)
        {
            DG.Tweening.PathMode val_13 = pathMode;
            DOTweenModulePhysics2D.<>c__DisplayClass5_0 val_1 = new DOTweenModulePhysics2D.<>c__DisplayClass5_0();
            .target = target;
            UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[0];
            if(path.Length >= 1)
            {
                    val_13 = 1152921504726016000;
                var val_12 = 0;
                do
            {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 5.217079f, y = 5.217079f});
                val_12 = val_12 + 1;
                mem2[0] = val_4.x;
                mem2[0] = val_4.y;
                mem2[0] = val_4.z;
            }
            while(val_12 < (long)path.Length);
            
            }
            
            DG.Tweening.Plugins.Core.PathCore.Path val_8 = null;
            val_8 = new DG.Tweening.Plugins.Core.PathCore.Path(type:  pathType, waypoints:  val_3, subdivisionsXSegment:  (resolution > 1) ? resolution : (0 + 1), gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            mem2[0] = 1;
            mem2[0] = val_13;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  DG.Tweening.Plugins.PathPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModulePhysics2D.<>c__DisplayClass5_0::<DOPath>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass5_0::<DOPath>b__1(UnityEngine.Vector3 x)), endValue:  val_8, duration:  duration), target:  (DOTweenModulePhysics2D.<>c__DisplayClass5_0)[1152921513268808944].target), updateType:  2);
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType = 0, DG.Tweening.PathMode pathMode = 1, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor)
        {
            DG.Tweening.PathMode val_14 = pathMode;
            DOTweenModulePhysics2D.<>c__DisplayClass6_0 val_1 = new DOTweenModulePhysics2D.<>c__DisplayClass6_0();
            .target = target;
            UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[0];
            if(path.Length >= 1)
            {
                    val_14 = 1152921504726016000;
                var val_13 = 0;
                do
            {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 5.217079f, y = 5.217079f});
                val_13 = val_13 + 1;
                mem2[0] = val_4.x;
                mem2[0] = val_4.y;
                mem2[0] = val_4.z;
            }
            while(val_13 < (long)path.Length);
            
            }
            
            .trans = (DOTweenModulePhysics2D.<>c__DisplayClass6_0)[1152921513269111408].target.transform;
            DG.Tweening.Plugins.Core.PathCore.Path val_9 = null;
            val_9 = new DG.Tweening.Plugins.Core.PathCore.Path(type:  pathType, waypoints:  val_3, subdivisionsXSegment:  (resolution > 1) ? resolution : (0 + 1), gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            mem2[0] = 1;
            mem2[0] = 1;
            mem2[0] = val_14;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  DG.Tweening.Plugins.PathPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModulePhysics2D.<>c__DisplayClass6_0::<DOLocalPath>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass6_0::<DOLocalPath>b__1(UnityEngine.Vector3 x)), endValue:  val_9, duration:  duration), target:  (DOTweenModulePhysics2D.<>c__DisplayClass6_0)[1152921513269111408].target), updateType:  2);
        }
    
    }

}
