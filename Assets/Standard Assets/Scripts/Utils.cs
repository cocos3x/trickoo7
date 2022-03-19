using UnityEngine;
public static class DOTweenModuleUI.Utils
{
    // Methods
    public static UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to)
    {
        UnityEngine.Rect val_1 = from.rect;
        UnityEngine.Rect val_3 = from.rect;
        UnityEngine.Rect val_5 = from.rect;
        UnityEngine.Rect val_7 = from.rect;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  (val_1.m_XMin.width * 0.5f) + val_3.m_XMin.xMin, y:  (val_5.m_XMin.height * 0.5f) + val_7.m_XMin.yMin);
        UnityEngine.Vector3 val_14 = from.position;
        UnityEngine.Vector2 val_15 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  0, worldPoint:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        bool val_17 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  to, screenPoint:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, cam:  0, localPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
        UnityEngine.Rect val_18 = to.rect;
        UnityEngine.Rect val_20 = to.rect;
        UnityEngine.Rect val_22 = to.rect;
        UnityEngine.Rect val_24 = to.rect;
        UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  (val_18.m_XMin.width * 0.5f) + val_20.m_XMin.xMin, y:  (val_22.m_XMin.height * 0.5f) + val_24.m_XMin.yMin);
        UnityEngine.Vector2 val_31 = to.anchoredPosition;
        UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, b:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y});
        return new UnityEngine.Vector2() {x = val_33.x, y = val_33.y};
    }

}
