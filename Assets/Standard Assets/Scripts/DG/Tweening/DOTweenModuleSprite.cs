using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleSprite
    {
        // Methods
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleSprite.<>c__DisplayClass0_0 val_1 = new DOTweenModuleSprite.<>c__DisplayClass0_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleSprite.<>c__DisplayClass0_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleSprite.<>c__DisplayClass0_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleSprite.<>c__DisplayClass0_0)[1152921513271831408].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration)
        {
            DOTweenModuleSprite.<>c__DisplayClass1_0 val_1 = new DOTweenModuleSprite.<>c__DisplayClass1_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleSprite.<>c__DisplayClass1_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleSprite.<>c__DisplayClass1_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleSprite.<>c__DisplayClass1_0)[1152921513272002800].target);
            return val_4;
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration)
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
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 28.15952f, g = 28.15952f, b = 28.15952f, a = 28.15952f}, duration:  (null - null) * duration), ease:  1));
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
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleSprite.<>c__DisplayClass3_0 val_1 = new DOTweenModuleSprite.<>c__DisplayClass3_0();
            .target = target;
            UnityEngine.Color val_2 = target.color;
            UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  0f, g:  0f, b:  0f, a:  0f);
            .to = val_4.r;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleSprite.<>c__DisplayClass3_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleSprite.<>c__DisplayClass3_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, duration:  duration)), target:  (DOTweenModuleSprite.<>c__DisplayClass3_0)[1152921513272422384].target);
        }
    
    }

}
