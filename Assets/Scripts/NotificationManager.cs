using UnityEngine;
public class NotificationManager : MonoBehaviour
{
    // Fields
    private bool dontDestroyOnLoad;
    private static NotificationManager <instance>k__BackingField;
    private static System.Collections.Generic.List<string> normalCotent;
    private static System.Collections.Generic.List<string> dailyrewardCotent;
    private static Unity.Notifications.Android.AndroidNotificationChannel NotificationChannel;
    
    // Properties
    private static NotificationManager instance { get; set; }
    
    // Methods
    private static NotificationManager get_instance()
    {
        return (NotificationManager)NotificationManager.<instance>k__BackingField;
    }
    private static void set_instance(NotificationManager value)
    {
        NotificationManager.<instance>k__BackingField = value;
    }
    private void Awake()
    {
        if((NotificationManager.<instance>k__BackingField) == 0)
        {
                NotificationManager.<instance>k__BackingField = this;
        }
        
        if(this.dontDestroyOnLoad == false)
        {
                return;
        }
        
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    private void Start()
    {
        NotificationManager.Initialize();
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        NotificationManager.normalCotent = val_1;
        val_1.Add(item:  "Yesterday, you pass level {0}, let\'s make new goals!");
        val_1.Add(item:  "Great mind-challenging are waiting for you 🥰");
        val_1.Add(item:  "We just update more level, let\'s explore ❤");
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        NotificationManager.dailyrewardCotent = val_2;
        val_2.Add(item:  "Yesterday, you pass level {0}, let\'s make new goals!");
        val_2.Add(item:  "We just update more level, let\'s explore ❤");
    }
    public static void Initialize()
    {
        bool val_1 = Unity.Notifications.Android.AndroidNotificationCenter.Initialize();
        NotificationManager.<instance>k__BackingField.__il2cppRuntimeField_38 = 0;
        NotificationManager.<instance>k__BackingField.__il2cppRuntimeField_40 = 0;
        NotificationManager.NotificationChannel = "LocalPush";
        NotificationManager.<instance>k__BackingField.__il2cppRuntimeField_20 = "Default Channel";
        NotificationManager.<instance>k__BackingField.__il2cppRuntimeField_28 = "Generic notifications";
        NotificationManager.<instance>k__BackingField.__il2cppRuntimeField_30 = 3;
        Unity.Notifications.Android.AndroidNotificationCenter.RegisterNotificationChannel(channel:  new Unity.Notifications.Android.AndroidNotificationChannel() {<Id>k__BackingField = 1152921513386935280, <Name>k__BackingField = 1152921513386935280, <Description>k__BackingField = 1152921513386935488, <Importance>k__BackingField = 1152921513386935488, <CanBypassDnd>k__BackingField = false, <CanShowBadge>k__BackingField = false, <EnableLights>k__BackingField = false, <EnableVibration>k__BackingField = false, <LockScreenVisibility>k__BackingField = ???});
        Unity.Notifications.Android.AndroidNotificationCenter.CancelAllScheduledNotifications();
    }
    public static void SetupLocalPush()
    {
        NotificationManager.SetupPushNotify(notificationId:  17, days:  1, hours:  8, minutes:  0);
        NotificationManager.SetupPushNotify(notificationId:  18, days:  3, hours:  8, minutes:  0);
        NotificationManager.SetupPushNotify(notificationId:  19, days:  7, hours:  8, minutes:  0);
    }
    public static void SetupPushNotify(int notificationId, int days, int hours, int minutes = 0)
    {
        var val_18;
        System.Collections.Generic.List<System.String> val_19;
        System.Func<System.String, System.Guid> val_21;
        var val_22;
        ulong val_24;
        Unity.Notifications.Android.NotificationStatus val_25;
        int val_27;
        System.Object[] val_28;
        int val_29;
        string val_1 = UnityEngine.Application.productName;
        if(notificationId != 10004)
        {
            goto label_1;
        }
        
        val_18 = null;
        val_19 = NotificationManager.dailyrewardCotent;
        val_18 = null;
        val_21 = NotificationManager.<>c.<>9__12_0;
        if(val_21 != null)
        {
            goto label_10;
        }
        
        System.Func<System.String, System.Guid> val_2 = null;
        val_21 = val_2;
        val_2 = new System.Func<System.String, System.Guid>(object:  NotificationManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Guid NotificationManager.<>c::<SetupPushNotify>b__12_0(string x));
        NotificationManager.<>c.<>9__12_0 = val_21;
        goto label_10;
        label_1:
        val_22 = null;
        val_19 = NotificationManager.normalCotent;
        val_22 = null;
        val_21 = NotificationManager.<>c.<>9__12_1;
        if(val_21 == null)
        {
                System.Func<System.String, System.Guid> val_3 = null;
            val_21 = val_3;
            val_3 = new System.Func<System.String, System.Guid>(object:  NotificationManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Guid NotificationManager.<>c::<SetupPushNotify>b__12_1(string x));
            NotificationManager.<>c.<>9__12_1 = val_21;
        }
        
        label_10:
        StageData val_7 = LazySingleton<DataManager>.Instance.CurrentStage;
        string val_8 = System.String.Format(format:  System.Linq.Enumerable.FirstOrDefault<System.String>(source:  System.Linq.Enumerable.OrderBy<System.String, System.Guid>(source:  val_19, keySelector:  val_3)), arg0:  public static DataManager LazySingleton<DataManager>::get_Instance());
        System.DateTime val_9 = System.DateTime.Today;
        System.DateTime val_10 = val_9.dateData.AddDays(value:  (double)days);
        System.DateTime val_11 = val_10.dateData.AddHours(value:  (double)hours);
        System.DateTime val_12 = val_11.dateData.AddHours(value:  (double)minutes);
        val_24 = val_12.dateData;
        Unity.Notifications.Android.NotificationStatus val_13 = Unity.Notifications.Android.AndroidNotificationCenter.CheckScheduledNotificationStatus(id:  notificationId);
        if(val_13 == 0)
        {
            goto label_19;
        }
        
        val_25 = val_13;
        if(val_13 != 1)
        {
            goto label_20;
        }
        
        Unity.Notifications.Android.AndroidNotificationCenter.UpdateScheduledNotification(id:  notificationId, notification:  new Unity.Notifications.Android.AndroidNotification() {<Title>k__BackingField = val_1, <Text>k__BackingField = val_8, <SmallIcon>k__BackingField = "icon_0", <FireTime>k__BackingField = new System.DateTime() {dateData = val_24}, <LargeIcon>k__BackingField = "icon_1", <ShouldAutoCancel>k__BackingField = false, <UsesStopwatch>k__BackingField = false, <GroupSummary>k__BackingField = false, <ShowTimestamp>k__BackingField = false, <ShowCustomTimestamp>k__BackingField = false, m_Color = new UnityEngine.Color(), m_RepeatInterval = new System.TimeSpan(), m_CustomTimestamp = new System.DateTime() {dateData = 1152921513314619296}}, channelId:  "channel_id");
        object[] val_14 = new object[6];
        val_25 = "[Notify] UpdateScheduled ";
        goto label_24;
        label_19:
        Unity.Notifications.Android.AndroidNotificationCenter.SendNotificationWithExplicitID(notification:  new Unity.Notifications.Android.AndroidNotification() {<Title>k__BackingField = val_1, <Text>k__BackingField = val_8, <SmallIcon>k__BackingField = "icon_0", <FireTime>k__BackingField = new System.DateTime() {dateData = val_24}, <LargeIcon>k__BackingField = "icon_1", <ShouldAutoCancel>k__BackingField = false, <UsesStopwatch>k__BackingField = false, <GroupSummary>k__BackingField = false, <ShowTimestamp>k__BackingField = false, <ShowCustomTimestamp>k__BackingField = false, m_Color = new UnityEngine.Color(), m_RepeatInterval = new System.TimeSpan(), m_CustomTimestamp = new System.DateTime()}, channelId:  NotificationManager.NotificationChannel, id:  notificationId);
        object[] val_15 = new object[6];
        val_25 = "[Notify] SendWithExplicitID ";
        label_24:
        val_15[0] = "[Notify] SendWithExplicitID ";
        val_27 = val_15.Length;
        val_15[1] = notificationId;
        val_27 = val_15.Length;
        val_15[2] = ": ";
        if(val_8 != null)
        {
                val_27 = val_15.Length;
        }
        
        val_15[3] = val_8;
        val_27 = val_15.Length;
        val_15[4] = " ";
        val_15[5] = val_12;
        val_28 = val_15;
        goto label_46;
        label_20:
        object[] val_16 = new object[4];
        val_24 = "[Notify] Status of ";
        val_16[0] = "[Notify] Status of ";
        val_29 = val_16.Length;
        val_16[1] = notificationId;
        val_29 = val_16.Length;
        val_16[2] = ": ";
        val_28 = val_16;
        val_16[3] = val_25;
        label_46:
        UnityEngine.Debug.LogWarning(message:  +val_16);
    }
    public NotificationManager()
    {
        this.dontDestroyOnLoad = true;
    }

}
