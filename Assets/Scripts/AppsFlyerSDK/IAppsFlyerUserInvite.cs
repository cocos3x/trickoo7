using UnityEngine;

namespace AppsFlyerSDK
{
    public interface IAppsFlyerUserInvite
    {
        // Methods
        public abstract void onInviteLinkGenerated(string link); // 0
        public abstract void onInviteLinkGeneratedFailure(string error); // 0
        public abstract void onOpenStoreLinkGenerated(string link); // 0
    
    }

}
