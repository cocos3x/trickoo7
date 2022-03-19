using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUtils
    {
        // Fields
        private static bool _initialized;
        
        // Methods
        public static void Init()
        {
            if(DG.Tweening.DOTweenModuleUtils._initialized != false)
            {
                    return;
            }
            
            DG.Tweening.DOTweenModuleUtils._initialized = true;
            DG.Tweening.Core.DOTweenExternalCommand.add_SetOrientationOnPath(value:  new System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform>(object:  0, method:  public static System.Void DOTweenModuleUtils.Physics::SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans)));
        }
        private static void Preserver()
        {
            System.Reflection.Assembly[] val_2 = System.AppDomain.CurrentDomain.GetAssemblies();
            System.Reflection.MethodInfo val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetMethod(name:  "Stub");
        }
    
    }

}
