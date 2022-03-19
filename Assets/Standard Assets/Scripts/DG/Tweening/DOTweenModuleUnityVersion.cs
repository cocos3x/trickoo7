using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUnityVersion
    {
        // Methods
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(val_2.Length < 1)
            {
                goto label_15;
            }
            
            var val_13 = 0;
            label_16:
            if((val_13 == 0) && (null <= 0f))
            {
                    target.color = new UnityEngine.Color() {r = 28.15952f, g = 28.15952f, b = 28.15952f, a = 28.15952f};
            }
            else
            {
                    if((val_2.Length - 1) == val_13)
            {
                    float val_5 = duration - (DG.Tweening.TweenExtensions.Duration(t:  val_1, includeLoops:  false));
            }
            else
            {
                    if(val_13 != 0)
            {
                    var val_6 = val_13 - 1;
            }
            
            }
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 28.15952f, g = 28.15952f, b = 28.15952f, a = 28.15952f}, duration:  (null - null) * duration), ease:  1));
            }
            
            val_13 = val_13 + 1;
            if(val_13 >= (long)val_2.Length)
            {
                goto label_15;
            }
            
            if(val_13 < val_2.Length)
            {
                goto label_16;
            }
            
            throw new IndexOutOfRangeException();
            label_15:
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Sequence>(t:  val_1, target:  target);
            return val_1;
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(val_2.Length < 1)
            {
                goto label_15;
            }
            
            var val_13 = 0;
            label_16:
            if((val_13 == 0) && (null <= 0f))
            {
                    target.SetColor(name:  property, value:  new UnityEngine.Color() {r = 28.15952f, g = 28.15952f, b = 28.15952f, a = 28.15952f});
            }
            else
            {
                    if((val_2.Length - 1) == val_13)
            {
                    float val_5 = duration - (DG.Tweening.TweenExtensions.Duration(t:  val_1, includeLoops:  false));
            }
            else
            {
                    if(val_13 != 0)
            {
                    var val_6 = val_13 - 1;
            }
            
            }
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 28.15952f, g = 28.15952f, b = 28.15952f, a = 28.15952f}, property:  property, duration:  (null - null) * duration), ease:  1));
            }
            
            val_13 = val_13 + 1;
            if(val_13 >= (long)val_2.Length)
            {
                goto label_15;
            }
            
            if(val_13 < val_2.Length)
            {
                goto label_16;
            }
            
            throw new IndexOutOfRangeException();
            label_15:
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Sequence>(t:  val_1, target:  target);
            return val_1;
        }
        public static UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForCompletion val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForCompletion();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForRewind val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForRewind();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForKill val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForKill();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForElapsedLoops val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForElapsedLoops();
                .t = t;
                .elapsedLoops = elapsedLoops;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForPosition val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForPosition();
                .t = t;
                .position = position;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForStart val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForStart();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration)
        {
            var val_7;
            DOTweenModuleUnityVersion.<>c__DisplayClass8_0 val_1 = new DOTweenModuleUnityVersion.<>c__DisplayClass8_0();
            .target = target;
            .propertyID = propertyID;
            if((target.HasProperty(nameID:  propertyID)) != false)
            {
                    DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUnityVersion.<>c__DisplayClass8_0::<DOOffset>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUnityVersion.<>c__DisplayClass8_0::<DOOffset>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
                val_7 = val_5;
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_5, target:  (DOTweenModuleUnityVersion.<>c__DisplayClass8_0)[1152921513297200448].target);
                return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>)val_7;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyId:  (DOTweenModuleUnityVersion.<>c__DisplayClass8_0)[1152921513297200448].propertyID);
            }
            
            val_7 = 0;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>)val_7;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration)
        {
            var val_7;
            DOTweenModuleUnityVersion.<>c__DisplayClass9_0 val_1 = new DOTweenModuleUnityVersion.<>c__DisplayClass9_0();
            .target = target;
            .propertyID = propertyID;
            if((target.HasProperty(nameID:  propertyID)) != false)
            {
                    DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUnityVersion.<>c__DisplayClass9_0::<DOTiling>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUnityVersion.<>c__DisplayClass9_0::<DOTiling>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
                val_7 = val_5;
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_5, target:  (DOTweenModuleUnityVersion.<>c__DisplayClass9_0)[1152921513297371840].target);
                return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>)val_7;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyId:  (DOTweenModuleUnityVersion.<>c__DisplayClass9_0)[1152921513297371840].propertyID);
            }
            
            val_7 = 0;
            return (DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>)val_7;
        }
        public static System.Threading.Tasks.Task AsyncWaitForCompletion(DG.Tweening.Tween t)
        {
            System.Threading.Tasks.Task<TResult> val_3;
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
            0.Start<<AsyncWaitForCompletion>d__10>(stateMachine: ref  new <AsyncWaitForCompletion>d__10() {<>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = val_3}}, t = val_3, <>u__1 = new YieldAwaitable.YieldAwaiter()});
            return (System.Threading.Tasks.Task)val_3.Task;
        }
        public static System.Threading.Tasks.Task AsyncWaitForRewind(DG.Tweening.Tween t)
        {
            System.Threading.Tasks.Task<TResult> val_3;
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
            0.Start<<AsyncWaitForRewind>d__11>(stateMachine: ref  new <AsyncWaitForRewind>d__11() {<>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = val_3}}, t = val_3, <>u__1 = new YieldAwaitable.YieldAwaiter()});
            return (System.Threading.Tasks.Task)val_3.Task;
        }
        public static System.Threading.Tasks.Task AsyncWaitForKill(DG.Tweening.Tween t)
        {
            System.Threading.Tasks.Task<TResult> val_3;
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
            0.Start<<AsyncWaitForKill>d__12>(stateMachine: ref  new <AsyncWaitForKill>d__12() {<>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = val_3}}, t = val_3, <>u__1 = new YieldAwaitable.YieldAwaiter()});
            return (System.Threading.Tasks.Task)val_3.Task;
        }
        public static System.Threading.Tasks.Task AsyncWaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops)
        {
            int val_2;
            System.Threading.Tasks.Task<TResult> val_3;
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
            0.Start<<AsyncWaitForElapsedLoops>d__13>(stateMachine: ref  new <AsyncWaitForElapsedLoops>d__13() {<>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = val_3}}, t = val_3, elapsedLoops = val_2, <>u__1 = new YieldAwaitable.YieldAwaiter()});
            return (System.Threading.Tasks.Task)val_3.Task;
        }
        public static System.Threading.Tasks.Task AsyncWaitForPosition(DG.Tweening.Tween t, float position)
        {
            float val_2;
            System.Threading.Tasks.Task<TResult> val_3;
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
            0.Start<<AsyncWaitForPosition>d__14>(stateMachine: ref  new <AsyncWaitForPosition>d__14() {<>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = val_3}}, t = val_3, position = val_2, <>u__1 = new YieldAwaitable.YieldAwaiter()});
            return (System.Threading.Tasks.Task)val_3.Task;
        }
        public static System.Threading.Tasks.Task AsyncWaitForStart(DG.Tweening.Tween t)
        {
            System.Threading.Tasks.Task<TResult> val_3;
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
            0.Start<<AsyncWaitForStart>d__15>(stateMachine: ref  new <AsyncWaitForStart>d__15() {<>t__builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder() {m_builder = new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>() {m_task = val_3}}, t = val_3, <>u__1 = new YieldAwaitable.YieldAwaiter()});
            return (System.Threading.Tasks.Task)val_3.Task;
        }
    
    }

}
