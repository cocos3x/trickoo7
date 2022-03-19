using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUI
    {
        // Methods
        public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.CanvasGroup target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass0_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass0_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass0_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass0_0::<DOFade>b__1(float x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass0_0)[1152921513273646832].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass1_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass1_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass1_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass1_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass1_0)[1152921513273818224].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Graphic target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass2_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass2_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass2_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass2_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass2_0)[1152921513273989616].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass3_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass3_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass3_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass3_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass3_0)[1152921513274161008].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Image target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass4_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass4_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass4_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass4_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass4_0)[1152921513274332400].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration)
        {
            float val_6;
            DOTweenModuleUI.<>c__DisplayClass5_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass5_0();
            val_6 = 1f;
            .target = target;
            if(endValue <= val_6)
            {
                    val_6 = endValue;
                if(endValue < 0)
            {
                    val_6 = 0f;
            }
            
            }
            
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__1(float x)), endValue:  val_6, duration:  duration);
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass5_0)[1152921513274503792].target);
            return val_4;
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration)
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
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 28.15952f, g = 28.15952f, b = 28.15952f, a = 28.15952f}, duration:  (null - null) * duration), ease:  1));
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
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass7_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass7_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass7_0::<DOFlexibleSize>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass7_0::<DOFlexibleSize>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass7_0)[1152921513274922352].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass8_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass8_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass8_0::<DOMinSize>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass8_0::<DOMinSize>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass8_0)[1152921513275101936].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass9_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass9_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass9_0::<DOPreferredSize>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass9_0::<DOPreferredSize>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass9_0)[1152921513275281520].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass10_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass10_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass10_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass10_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass10_0)[1152921513275457008].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Outline target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass11_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass11_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass11_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass11_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass11_0)[1152921513275628400].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass12_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass12_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass12_0::<DOScale>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass12_0::<DOScale>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass12_0)[1152921513275799792].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass13_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass13_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass13_0::<DOAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass13_0::<DOAnchorPos>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass13_0)[1152921513275975280].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass14_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass14_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  endValue, y:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass14_0::<DOAnchorPosX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass14_0::<DOAnchorPosX>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  2, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass14_0)[1152921513276154864].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass15_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass15_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  endValue);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass15_0::<DOAnchorPosY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass15_0::<DOAnchorPosY>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass15_0)[1152921513276334448].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass16_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass16_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass16_0::<DOAnchorPos3D>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass16_0::<DOAnchorPos3D>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass16_0)[1152921513276514032].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass17_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass17_0();
            .target = target;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  endValue, y:  0f, z:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass17_0::<DOAnchorPos3DX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass17_0::<DOAnchorPos3DX>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  2, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass17_0)[1152921513276693616].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass18_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass18_0();
            .target = target;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  0f, y:  endValue, z:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass18_0::<DOAnchorPos3DY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass18_0::<DOAnchorPos3DY>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass18_0)[1152921513276873200].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass19_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass19_0();
            .target = target;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  0f, y:  0f, z:  endValue);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass19_0::<DOAnchorPos3DZ>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass19_0::<DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  8, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass19_0)[1152921513277052784].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass20_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass20_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass20_0::<DOAnchorMax>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass20_0::<DOAnchorMax>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass20_0)[1152921513277232368].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass21_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass21_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass21_0::<DOAnchorMin>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass21_0::<DOAnchorMin>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass21_0)[1152921513277411952].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass22_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass22_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass22_0::<DOPivot>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass22_0::<DOPivot>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass22_0)[1152921513277587440].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotX(UnityEngine.RectTransform target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass23_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass23_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  endValue, y:  0f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass23_0::<DOPivotX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass23_0::<DOPivotX>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  2, snapping:  false), target:  (DOTweenModuleUI.<>c__DisplayClass23_0)[1152921513277762928].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotY(UnityEngine.RectTransform target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass24_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass24_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  endValue);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass24_0::<DOPivotY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass24_0::<DOPivotY>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_5, axisConstraint:  4, snapping:  false), target:  (DOTweenModuleUI.<>c__DisplayClass24_0)[1152921513277942512].target);
            return val_5;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass25_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass25_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass25_0::<DOSizeDelta>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass25_0::<DOSizeDelta>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass25_0)[1152921513278122096].target);
            return val_4;
        }
        public static DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato = 10, float elasticity = 1, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass26_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass26_0();
            .target = target;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = punch.x, y = punch.y});
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.DOTween.Punch(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass26_0::<DOPunchAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass26_0::<DOPunchAnchorPos>b__1(UnityEngine.Vector3 x)), direction:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration, vibrato:  vibrato, elasticity:  elasticity), target:  (DOTweenModuleUI.<>c__DisplayClass26_0)[1152921513278297584].target), snapping:  snapping);
        }
        public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength = 100, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True)
        {
            DOTweenModuleUI.<>c__DisplayClass27_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass27_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.Core.Extensions.SetSpecialStartupMode<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.DOTween.Shake(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass27_0::<DOShakeAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass27_0::<DOShakeAnchorPos>b__1(UnityEngine.Vector3 x)), duration:  duration, strength:  strength, vibrato:  vibrato, randomness:  randomness, ignoreZAxis:  true, fadeOut:  fadeOut), target:  (DOTweenModuleUI.<>c__DisplayClass27_0)[1152921513278473072].target), mode:  2), snapping:  snapping);
        }
        public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True)
        {
            DOTweenModuleUI.<>c__DisplayClass28_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass28_0();
            .target = target;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = strength.x, y = strength.y});
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.Core.Extensions.SetSpecialStartupMode<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.DOTween.Shake(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass28_0::<DOShakeAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass28_0::<DOShakeAnchorPos>b__1(UnityEngine.Vector3 x)), duration:  duration, strength:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, vibrato:  vibrato, randomness:  randomness, fadeOut:  fadeOut), target:  (DOTweenModuleUI.<>c__DisplayClass28_0)[1152921513278652656].target), mode:  2), snapping:  snapping);
        }
        public static DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass29_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass29_0();
            .target = target;
            .endValue = endValue;
            mem[1152921513278914212] = endValue.y;
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
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921513278914160].endValue, y:  0f);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921513278914160].s, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__3()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__4(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, duration:  duration), axisConstraint:  2, snapping:  val_8), ease:  1)), t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, duration:  val_27), axisConstraint:  4, snapping:  val_8), ease:  6)), loops:  val_2, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__2()))), target:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921513278914160].target), ease:  DG.Tweening.DOTween.defaultEaseType);
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Sequence>(t:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921513278914160].s, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__5()));
            return (DG.Tweening.Sequence)(DOTweenModuleUI.<>c__DisplayClass29_0)[1152921513278914160].s;
        }
        public static DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass30_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass30_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass30_0::<DONormalizedPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass30_0::<DONormalizedPos>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass30_0)[1152921513279167472].target);
        }
        public static DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass31_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass31_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass31_0::<DOHorizontalNormalizedPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass31_0::<DOHorizontalNormalizedPos>b__1(float x)), endValue:  endValue, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass31_0)[1152921513279338864].target);
        }
        public static DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass32_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass32_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass32_0::<DOVerticalNormalizedPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass32_0::<DOVerticalNormalizedPos>b__1(float x)), endValue:  endValue, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass32_0)[1152921513279510256].target);
        }
        public static DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass33_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass33_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass33_0::<DOValue>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass33_0::<DOValue>b__1(float x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass33_0)[1152921513279685744].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass34_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass34_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass34_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass34_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass34_0)[1152921513279861232].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> DOCounter(UnityEngine.UI.Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = True, System.Globalization.CultureInfo culture)
        {
            System.Globalization.CultureInfo val_8 = culture;
            DOTweenModuleUI.<>c__DisplayClass35_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass35_0();
            .target = target;
            .addThousandsSeparator = addThousandsSeparator;
            .v = fromValue;
            if(addThousandsSeparator == false)
            {
                goto label_2;
            }
            
            if(val_8 != null)
            {
                goto label_6;
            }
            
            val_8 = System.Globalization.CultureInfo.InvariantCulture;
            goto label_6;
            label_2:
            val_8 = 0;
            label_6:
            .cInfo = val_8;
            DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions> val_6 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 DOTweenModuleUI.<>c__DisplayClass35_0::<DOCounter>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass35_0::<DOCounter>b__1(int x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  val_6, target:  (DOTweenModuleUI.<>c__DisplayClass35_0)[1152921513280047984].target);
            return val_6;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Text target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass36_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass36_0();
            .target = target;
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass36_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass36_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  val_4, target:  (DOTweenModuleUI.<>c__DisplayClass36_0)[1152921513280223472].target);
            return val_4;
        }
        public static DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled = True, DG.Tweening.ScrambleMode scrambleMode = 0, string scrambleChars)
        {
            string val_8 = endValue;
            DOTweenModuleUI.<>c__DisplayClass37_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass37_0();
            .target = target;
            if(val_8 == null)
            {
                    if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogWarning(message:  "You can\'t pass a NULL string to DOText: an empty string will be used instead to avoid errors", t:  0);
            }
            
                val_8 = "";
            }
            
            DG.Tweening.Core.TweenerCore<System.String, System.String, DG.Tweening.Plugins.Options.StringOptions> val_4 = DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.String>(object:  val_1, method:  System.String DOTweenModuleUI.<>c__DisplayClass37_0::<DOText>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.String>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass37_0::<DOText>b__1(string x)), endValue:  val_8, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  val_4, richTextEnabled:  richTextEnabled, scrambleMode:  scrambleMode, scrambleChars:  scrambleChars), target:  (DOTweenModuleUI.<>c__DisplayClass37_0)[1152921513280425840].target);
            return val_4;
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass38_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass38_0();
            .target = target;
            UnityEngine.Color val_2 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a});
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  0f, g:  0f, b:  0f, a:  0f);
            .to = val_3.r;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass38_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass38_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, duration:  duration)), target:  (DOTweenModuleUI.<>c__DisplayClass38_0)[1152921513280605424].target);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass39_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass39_0();
            .target = target;
            UnityEngine.Color val_2 = target.color;
            UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  0f, g:  0f, b:  0f, a:  0f);
            .to = val_4.r;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass39_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass39_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, duration:  duration)), target:  (DOTweenModuleUI.<>c__DisplayClass39_0)[1152921513280786032].target);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass40_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass40_0();
            .target = target;
            UnityEngine.Color val_2 = target.color;
            UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  0f, g:  0f, b:  0f, a:  0f);
            .to = val_4.r;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass40_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass40_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, duration:  duration)), target:  (DOTweenModuleUI.<>c__DisplayClass40_0)[1152921513280965616].target);
        }
    
    }

}
