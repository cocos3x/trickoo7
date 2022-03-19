using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenProShortcuts
    {
        // Methods
        private static DOTweenProShortcuts()
        {
            DG.Tweening.Plugins.SpiralPlugin val_1 = new DG.Tweening.Plugins.SpiralPlugin();
        }
        public static DG.Tweening.Tweener DOSpiral(UnityEngine.Transform target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = False)
        {
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            val_16 = depth;
            val_17 = frequency;
            val_18 = duration;
            DOTweenProShortcuts.<>c__DisplayClass1_0 val_1 = new DOTweenProShortcuts.<>c__DisplayClass1_0();
            .target = target;
            val_19 = 0f;
            val_20 = 1f;
            if((mode & 0) != 0)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_20 = axis.HasValue;
            val_19 = axis.HasValue >> 32;
            val_16 = val_16;
            val_17 = val_17;
            val_21 = ((UnityEngine.Mathf.Approximately(a:  speed, b:  val_19)) != true) ? (val_20) : speed;
            val_18 = val_18;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_20, y = val_19, z = mode}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
            {
                goto label_9;
            }
            
            label_4:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            System.Nullable<UnityEngine.Vector3> val_8 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            label_9:
            UnityEngine.Vector3 val_12 = val_8.HasValue.Value;
            mem2[0] = snapping;
            mem2[0] = val_21;
            mem2[0] = val_17;
            mem2[0] = val_16;
            mem2[0] = W4 & 1;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>(plugin:  DG.Tweening.Plugins.SpiralPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenProShortcuts.<>c__DisplayClass1_0::<DOSpiral>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenProShortcuts.<>c__DisplayClass1_0::<DOSpiral>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  val_18), target:  (DOTweenProShortcuts.<>c__DisplayClass1_0)[1152921513309201248].target);
        }
        public static DG.Tweening.Tweener DOSpiral(UnityEngine.Rigidbody target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = False)
        {
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            val_16 = depth;
            val_17 = frequency;
            val_18 = duration;
            .target = target;
            val_19 = 0f;
            val_20 = 1f;
            if((mode & 0) != 0)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_20 = axis.HasValue;
            val_19 = axis.HasValue >> 32;
            val_16 = val_16;
            val_17 = val_17;
            val_21 = ((UnityEngine.Mathf.Approximately(a:  speed, b:  val_19)) != true) ? (val_20) : speed;
            val_18 = val_18;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_20, y = val_19, z = mode}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
            {
                goto label_9;
            }
            
            label_4:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            System.Nullable<UnityEngine.Vector3> val_8 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            label_9:
            UnityEngine.Vector3 val_12 = val_8.HasValue.Value;
            mem2[0] = snapping;
            mem2[0] = val_21;
            mem2[0] = val_17;
            mem2[0] = val_16;
            mem2[0] = W4 & 1;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>(plugin:  DG.Tweening.Plugins.SpiralPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenProShortcuts.<>c__DisplayClass2_0(), method:  UnityEngine.Vector3 DOTweenProShortcuts.<>c__DisplayClass2_0::<DOSpiral>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenProShortcuts.<>c__DisplayClass2_0)[1152921513309392096].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  val_18), target:  (DOTweenProShortcuts.<>c__DisplayClass2_0)[1152921513309392096].target);
        }
    
    }

}
