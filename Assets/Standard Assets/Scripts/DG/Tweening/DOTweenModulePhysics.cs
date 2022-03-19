using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModulePhysics
    {
        // Methods
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, bool snapping = False)
        {
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenModulePhysics.<>c__DisplayClass0_0(), method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass0_0::<DOMove>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass0_0)[1152921513261711088].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModulePhysics.<>c__DisplayClass0_0)[1152921513261711088].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = False)
        {
            .target = target;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  endValue, y:  0f, z:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenModulePhysics.<>c__DisplayClass1_0(), method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass1_0::<DOMoveX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass1_0)[1152921513261897840].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  2, snapping:  snapping), target:  (DOTweenModulePhysics.<>c__DisplayClass1_0)[1152921513261897840].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = False)
        {
            .target = target;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  0f, y:  endValue, z:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenModulePhysics.<>c__DisplayClass2_0(), method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass2_0::<DOMoveY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass2_0)[1152921513262084592].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  4, snapping:  snapping), target:  (DOTweenModulePhysics.<>c__DisplayClass2_0)[1152921513262084592].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = False)
        {
            .target = target;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  endValue);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenModulePhysics.<>c__DisplayClass3_0(), method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass3_0::<DOMoveZ>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass3_0)[1152921513262271344].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  8, snapping:  snapping), target:  (DOTweenModulePhysics.<>c__DisplayClass3_0)[1152921513262271344].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode = 0)
        {
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Quaternion>(object:  new DOTweenModulePhysics.<>c__DisplayClass4_0(), method:  UnityEngine.Quaternion DOTweenModulePhysics.<>c__DisplayClass4_0::<DORotate>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Quaternion>(object:  (DOTweenModulePhysics.<>c__DisplayClass4_0)[1152921513262463216].target, method:  public System.Void UnityEngine.Rigidbody::MoveRotation(UnityEngine.Quaternion rot)), endValue:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  val_4, target:  (DOTweenModulePhysics.<>c__DisplayClass4_0)[1152921513262463216].target);
            mem2[0] = mode;
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLookAt(UnityEngine.Rigidbody target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint = 0, System.Nullable<UnityEngine.Vector3> up)
        {
            .target = target;
            mem2[0] = axisConstraint;
            if((X3 & 0) == 0)
            {
                    UnityEngine.Vector3 val_7 = up.HasValue.Value;
            }
            else
            {
                    UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            }
            
            mem2[0] = val_8.x;
            mem2[0] = val_8.y;
            mem2[0] = val_8.z;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>)DG.Tweening.Core.Extensions.SetSpecialStartupMode<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Quaternion>(object:  new DOTweenModulePhysics.<>c__DisplayClass5_0(), method:  UnityEngine.Quaternion DOTweenModulePhysics.<>c__DisplayClass5_0::<DOLookAt>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Quaternion>(object:  (DOTweenModulePhysics.<>c__DisplayClass5_0)[1152921513262654064].target, method:  public System.Void UnityEngine.Rigidbody::MoveRotation(UnityEngine.Quaternion rot)), endValue:  new UnityEngine.Vector3() {x = towards.x, y = towards.y, z = towards.z}, duration:  duration), target:  (DOTweenModulePhysics.<>c__DisplayClass5_0)[1152921513262654064].target), mode:  1);
        }
        public static DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            DOTweenModulePhysics.<>c__DisplayClass6_0 val_1 = new DOTweenModulePhysics.<>c__DisplayClass6_0();
            .target = target;
            .endValue = endValue;
            mem[1152921513262959652] = endValue.y;
            mem[1152921513262959656] = endValue.z;
            .startPosY = 0f;
            .offsetYSet = false;
            .offsetY = -1f;
            .s = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  0f, y:  jumpPower, z:  0f);
            int val_7 = ((numJumps > 1) ? numJumps : (0 + 1)) << 1;
            float val_35 = (float)val_7;
            val_35 = duration / val_35;
            bool val_9 = snapping;
            .yTween = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass6_0::<DOJump>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  val_35), axisConstraint:  4, snapping:  val_9), ease:  6)), loops:  val_7, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModulePhysics.<>c__DisplayClass6_0::<DOJump>b__1()));
            UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].endValue, y:  0f, z:  0f);
            UnityEngine.Vector3 val_25 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  val_18.z);
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  DG.Tweening.TweenSettingsExtensions.Join(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].s, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass6_0::<DOJump>b__2()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  duration), axisConstraint:  2, snapping:  val_9), ease:  1)), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass6_0::<DOJump>b__3()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, duration:  duration), axisConstraint:  8, snapping:  val_9), ease:  1)), t:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].yTween), target:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].target), ease:  DG.Tweening.DOTween.defaultEaseType);
            DG.Tweening.Tween val_34 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tween>(t:  (DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].yTween, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModulePhysics.<>c__DisplayClass6_0::<DOJump>b__4()));
            return (DG.Tweening.Sequence)(DOTweenModulePhysics.<>c__DisplayClass6_0)[1152921513262959600].s;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType = 0, DG.Tweening.PathMode pathMode = 1, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor)
        {
            .target = target;
            DG.Tweening.Plugins.Core.PathCore.Path val_6 = null;
            val_6 = new DG.Tweening.Plugins.Core.PathCore.Path(type:  pathType, waypoints:  path, subdivisionsXSegment:  (resolution > 1) ? resolution : (0 + 1), gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = false});
            mem2[0] = 1;
            mem2[0] = pathMode;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  DG.Tweening.Plugins.PathPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenModulePhysics.<>c__DisplayClass7_0(), method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass7_0::<DOPath>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass7_0)[1152921513263359344].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  val_6, duration:  duration), target:  (DOTweenModulePhysics.<>c__DisplayClass7_0)[1152921513263359344].target), updateType:  2);
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType = 0, DG.Tweening.PathMode pathMode = 1, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor)
        {
            DOTweenModulePhysics.<>c__DisplayClass8_0 val_1 = new DOTweenModulePhysics.<>c__DisplayClass8_0();
            .target = target;
            .trans = target.transform;
            DG.Tweening.Plugins.Core.PathCore.Path val_7 = null;
            val_7 = new DG.Tweening.Plugins.Core.PathCore.Path(type:  pathType, waypoints:  path, subdivisionsXSegment:  (resolution > 1) ? resolution : (0 + 1), gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            mem2[0] = pathMode;
            mem2[0] = 1;
            mem2[0] = 1;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  DG.Tweening.Plugins.PathPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass8_0::<DOLocalPath>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModulePhysics.<>c__DisplayClass8_0::<DOLocalPath>b__1(UnityEngine.Vector3 x)), endValue:  val_7, duration:  duration), target:  (DOTweenModulePhysics.<>c__DisplayClass8_0)[1152921513263653616].target), updateType:  2);
        }
        internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = 1)
        {
            .target = target;
            mem2[0] = 1;
            mem2[0] = pathMode;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  DG.Tweening.Plugins.PathPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenModulePhysics.<>c__DisplayClass9_0(), method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass9_0::<DOPath>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenModulePhysics.<>c__DisplayClass9_0)[1152921513263864944].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  path, duration:  duration), target:  (DOTweenModulePhysics.<>c__DisplayClass9_0)[1152921513263864944].target);
        }
        internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = 1)
        {
            DOTweenModulePhysics.<>c__DisplayClass10_0 val_1 = new DOTweenModulePhysics.<>c__DisplayClass10_0();
            .target = target;
            .trans = target.transform;
            mem2[0] = pathMode;
            mem2[0] = 1;
            mem2[0] = 1;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  DG.Tweening.Plugins.PathPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModulePhysics.<>c__DisplayClass10_0::<DOLocalPath>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModulePhysics.<>c__DisplayClass10_0::<DOLocalPath>b__1(UnityEngine.Vector3 x)), endValue:  path, duration:  duration), target:  (DOTweenModulePhysics.<>c__DisplayClass10_0)[1152921513264069104].target);
        }
    
    }

}
