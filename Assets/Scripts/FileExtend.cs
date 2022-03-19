using UnityEngine;
public class FileExtend : MonoBehaviour
{
    // Fields
    private static FileExtend.ProcessChangedDelegate OnProcessChanged;
    private static bool isConnected;
    private static UnityEngine.NetworkReachability network;
    protected static FileExtend instance;
    
    // Properties
    public static bool IsConnected { get; }
    public static string NetworkType { get; }
    
    // Methods
    public static bool get_IsConnected()
    {
        FileExtend.network = UnityEngine.Application.internetReachability;
        UnityEngine.NetworkReachability val_3 = FileExtend.network;
        val_3 = val_3 - 1;
        FileExtend.isConnected = (val_3 < 2) ? 1 : 0;
        return (bool)FileExtend.isConnected;
    }
    public static string get_NetworkType()
    {
        FileExtend.network = UnityEngine.Application.internetReachability;
        UnityEngine.NetworkReachability val_3 = FileExtend.network;
        val_3 = (val_3 == 1) ? "Mobile" : ((val_3 == 2) ? "Wifi" : "Unknow");
        return (string)val_3;
    }
    public static void add_OnProcessChanged(FileExtend.ProcessChangedDelegate value)
    {
        if((System.Delegate.Combine(a:  FileExtend.OnProcessChanged, b:  value)) == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    public static void remove_OnProcessChanged(FileExtend.ProcessChangedDelegate value)
    {
        if((System.Delegate.Remove(source:  FileExtend.OnProcessChanged, value:  value)) == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    private void Awake()
    {
        FileExtend.instance = this;
    }
    public static System.Collections.IEnumerator DOLoadRes<T>(System.Action<T, FileStatus> result, string fileName)
    {
        mem2[0] = fileName;
        mem2[0] = result;
        return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.IEnumerator DODownloadJson<T>(System.Action<T, FileStatus> result, string url)
    {
        mem2[0] = url;
        mem2[0] = result;
        return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
    }
    private static System.Collections.IEnumerator DOLoadTexture(System.Action<UnityEngine.Texture2D, FileStatus> result, string url)
    {
        .<>1__state = 0;
        .url = url;
        .result = result;
        return (System.Collections.IEnumerator)new FileExtend.<DOLoadTexture>d__10();
    }
    public static System.Collections.IEnumerator DOLoadSprite(string url, System.Action<UnityEngine.Sprite> result)
    {
        .<>1__state = 0;
        .result = result;
        .url = url;
        return (System.Collections.IEnumerator)new FileExtend.<DOLoadSprite>d__11();
    }
    public static void Delete(string path)
    {
        if((System.IO.File.Exists(path:  path)) == false)
        {
                return;
        }
        
        System.IO.File.Delete(path:  path);
    }
    public static void Save(System.Action<FileStatus> status, string path, byte[] fileBytes)
    {
        if((System.IO.Directory.Exists(path:  System.IO.Path.GetDirectoryName(path:  path))) != true)
        {
                System.IO.DirectoryInfo val_4 = System.IO.Directory.CreateDirectory(path:  System.IO.Path.GetDirectoryName(path:  path));
        }
        
        System.IO.File.WriteAllBytes(path:  path, bytes:  fileBytes);
        if(path == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Debug.Log(message:  "Saved Data to: "("Saved Data to: ") + path.Replace(oldValue:  "/", newValue:  "\\")(path.Replace(oldValue:  "/", newValue:  "\\")));
        if(status == null)
        {
                return;
        }
        
        status.Invoke(obj:  1);
    }
    public static void SaveData<T>(string fileName, object data)
    {
        var val_18;
        var val_19;
        string val_20;
        System.String[] val_21;
        object val_22;
        var val_23;
        var val_24;
        int val_25;
        int val_26;
        object val_28;
        val_18 = __RuntimeMethodHiddenParam;
        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter val_1 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        string val_3 = FileExtend.FileNameToPath(fileName:  fileName + ".gd");
        val_20 = val_3;
        if((System.IO.File.Exists(path:  val_3)) == false)
        {
            goto label_35;
        }
        
        System.IO.FileStream val_5 = System.IO.File.Open(path:  val_20, mode:  4);
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_21 = mem[__RuntimeMethodHiddenParam + 48];
        val_21 = __RuntimeMethodHiddenParam + 48;
        if(data == null)
        {
            goto label_4;
        }
        
        val_22 = X0;
        if(X0 == true)
        {
            goto label_5;
        }
        
        label_4:
        val_22 = 0;
        label_5:
        val_1.Serialize(serializationStream:  val_5, graph:  val_22);
        if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
        val_5.Close();
        string[] val_6 = new string[6];
        val_21 = val_6;
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = "[SaveData] Done: ";
        if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        val_25 = val_6.Length;
        if(val_25 == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_21[0] = "[SaveData] Done: ";
        if(fileName != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
            val_25 = val_6.Length;
        }
        
        if(val_25 <= 1)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_21[1] = fileName;
        val_23 = " ";
        if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        val_25 = val_6.Length;
        if(val_25 <= 2)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_21[2] = " ";
        System.DateTime val_7 = System.DateTime.Now;
        string val_8 = val_7.dateData.ToString();
        if(val_8 != null)
        {
                if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        }
        
        val_26 = val_6.Length;
        if(val_26 <= 3)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_21[3] = val_8;
        val_24 = "\n";
        if(X0 == false)
        {
                throw new ArrayTypeMismatchException();
        }
        
        val_26 = val_6.Length;
        if(val_26 <= 4)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_21[4] = "\n";
        if(val_20 != null)
        {
                val_26 = val_6.Length;
        }
        
        val_21[5] = val_20;
        UnityEngine.Debug.Log(message:  +val_6);
        val_21 = 0;
        val_23 = 0;
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_5.Dispose();
        if(val_21 != 0)
        {
            goto label_34;
        }
        
        if(val_23 == 1)
        {
            goto label_35;
        }
        
        if(209 != 209)
        {
            goto label_36;
        }
        
        goto label_50;
        label_35:
        val_23 = 0;
        label_36:
        System.IO.FileStream val_11 = System.IO.File.Create(path:  val_20);
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18 = mem[__RuntimeMethodHiddenParam + 48];
        val_18 = __RuntimeMethodHiddenParam + 48;
        if(data == null)
        {
            goto label_40;
        }
        
        val_28 = X0;
        if(X0 == true)
        {
            goto label_41;
        }
        
        label_40:
        val_28 = 0;
        label_41:
        val_1.Serialize(serializationStream:  val_11, graph:  val_28);
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        val_11.Close();
        UnityEngine.Debug.Log(message:  "[SaveData] Done: "("[SaveData] Done: ") + fileName + "\n" + val_20);
        val_21 = 0;
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_11.Dispose();
        if(val_21 != 0)
        {
                throw val_21 = 0;
        }
        
        if(1 != 1)
        {
                var val_14 = (209 == 209) ? 1 : 0;
            val_14 = ((1 >= 0) ? 1 : 0) & val_14;
            val_14 = 1 - val_14;
            val_14 = val_14 + 1;
            val_19 = 1152921513371738000 + (val_14 << 2);
        }
        
        label_50:
        mem2[0] = 259;
        System.GC.Collect();
        System.GC.WaitForPendingFinalizers();
        System.GC.Collect();
        if(val_21 != 0)
        {
                throw val_21;
        }
        
        return;
        label_34:
        val_24 = val_21;
        val_20 = val_23;
        throw val_24;
    }
    public static object LoadData<T>(string fileName)
    {
        var val_14;
        var val_15;
        object val_16;
        System.IO.Stream val_17;
        var val_18;
        var val_19;
        var val_21;
        object val_22;
        val_14 = __RuntimeMethodHiddenParam;
        string val_2 = FileExtend.FileNameToPath(fileName:  fileName + ".gd");
        if((System.IO.File.Exists(path:  val_2)) == false)
        {
            goto label_1;
        }
        
        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter val_4 = null;
        val_16 = val_4;
        val_4 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        System.IO.FileStream val_5 = System.IO.File.Open(path:  val_2, mode:  3);
        if(val_16 == null)
        {
                throw new NullReferenceException();
        }
        
        val_17 = val_5;
        val_16 = val_4.Deserialize(serializationStream:  val_17);
        val_14 = mem[__RuntimeMethodHiddenParam + 48];
        val_14 = __RuntimeMethodHiddenParam + 48;
        val_18 = mem[__RuntimeMethodHiddenParam + 48 + 302];
        val_18 = __RuntimeMethodHiddenParam + 48 + 302;
        if(val_16 == null)
        {
            goto label_4;
        }
        
        val_17 = val_14;
        val_19 = X0;
        if(X0 == false)
        {
            goto label_5;
        }
        
        if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
        label_16:
        val_5.Close();
        UnityEngine.Debug.Log(message:  "[LoadData] Done: "("[LoadData] Done: ") + fileName);
        val_14 = 0;
        val_16 = 0;
        val_17 = null;
        var val_12 = 0;
        val_12 = val_12 + 1;
        goto label_12;
        label_1:
        UnityEngine.Debug.LogWarning(message:  "[LoadData] Error " + fileName + " NOT found");
        val_19 = 0;
        goto label_18;
        label_4:
        val_19 = 0;
        if(val_5 != null)
        {
            goto label_16;
        }
        
        throw new NullReferenceException();
        label_12:
        val_5.Dispose();
        if(val_14 != 0)
        {
                throw val_14 = 0;
        }
        
        if(val_16 != 1)
        {
                var val_9 = ((1152921513371936592 + (val_6) << 2) == 99) ? 1 : 0;
            val_9 = ((val_16 >= 0) ? 1 : 0) & val_9;
            val_9 = val_16 - val_9;
            val_9 = val_9 + 1;
            val_15 = 1152921513371936592 + (val_9 << 2);
        }
        
        label_18:
        mem2[0] = 183;
        label_47:
        System.GC.Collect();
        System.GC.WaitForPendingFinalizers();
        System.GC.Collect();
        if(val_14 != 0)
        {
                throw val_14;
        }
        
        return (object)val_19;
        label_5:
        val_21 = val_14;
        val_22 = val_16;
        if( != 1)
        {
            goto label_45;
        }
        
        if((null & 1) == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Debug.LogError(message:  "[LoadData]: Exception: "("[LoadData]: Exception: ") + fileName + " " + 1152921504625750016);
        mem2[0] = 183;
        goto label_47;
        label_37:
        mem[8] = null;
        throw new NullReferenceException();
        label_45:
        if( != 1)
        {
            goto label_46;
        }
        
        goto label_47;
        label_46:
    }
    public static void DeleteData(string fileName)
    {
        FileExtend.Delete(path:  fileName);
    }
    public static void SaveItemJson(object data, string path)
    {
        string val_1 = UnityEngine.JsonUtility.ToJson(obj:  data, prettyPrint:  true);
        System.IO.FileStream val_2 = new System.IO.FileStream(path:  path, mode:  2);
        var val_7 = 0;
        val_7 = val_7 + 1;
        new System.IO.StreamWriter(stream:  val_2).Dispose();
        if(0 != 0)
        {
                throw 0;
        }
        
        if(val_2 != null)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            val_2.Dispose();
        }
        
        if(0 != 0)
        {
                throw 0;
        }
        
        UnityEngine.Debug.Log(message:  "File created: "("File created: ") + path);
    }
    private static string HideUrl(string url)
    {
        int val_7;
        char[] val_1 = new char[1];
        val_1[0] = '/';
        System.String[] val_2 = url.Split(separator:  val_1);
        if(val_2 == null)
        {
                return "";
        }
        
        if(val_2.Length < 3)
        {
                return "";
        }
        
        string[] val_3 = new string[5];
        val_7 = val_3.Length;
        val_3[0] = val_2[((-12884901888) + ((val_2.Length) << 32)) >> 29];
        val_7 = val_3.Length;
        val_3[1] = "/";
        string val_8 = val_2[((-8589934592) + ((val_2.Length) << 32)) >> 29];
        if(val_8 != null)
        {
                val_7 = val_3.Length;
        }
        
        val_3[2] = val_8;
        val_7 = val_3.Length;
        val_3[3] = "/";
        string val_9 = val_2[((-4294967296) + ((val_2.Length) << 32)) >> 29];
        if(val_9 != null)
        {
                val_7 = val_3.Length;
        }
        
        val_3[4] = val_9;
        return +val_3;
    }
    public static string FileNameToPath(string fileName)
    {
        return System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  fileName);
    }
    public FileExtend()
    {
    
    }

}
