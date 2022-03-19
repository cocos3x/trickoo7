using UnityEngine;
public sealed class ObjectPool : MonoBehaviour
{
    // Fields
    private static ObjectPool _instance;
    private static System.Collections.Generic.List<UnityEngine.GameObject> tempList;
    private System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>> pooledObjects;
    private System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.GameObject> spawnedObjects;
    public ObjectPool.StartupPoolMode startupPoolMode;
    public ObjectPool.StartupPool[] startupPools;
    private bool startupPoolsCreated;
    
    // Properties
    public static ObjectPool instance { get; }
    
    // Methods
    private void Awake()
    {
        null = null;
        ObjectPool._instance = this;
        if(this.startupPoolMode != 0)
        {
                return;
        }
        
        ObjectPool.CreateStartupPools();
    }
    private void Start()
    {
        if(this.startupPoolMode != 1)
        {
                return;
        }
        
        ObjectPool.CreateStartupPools();
    }
    public static void CreateStartupPools()
    {
        ObjectPool val_1 = ObjectPool.instance;
        if(val_1.startupPoolsCreated != false)
        {
                return;
        }
        
        ObjectPool val_2 = ObjectPool.instance;
        val_2.startupPoolsCreated = true;
        ObjectPool val_3 = ObjectPool.instance;
        if(val_3.startupPools == null)
        {
                return;
        }
        
        if(val_3.startupPools.Length == 0)
        {
                return;
        }
        
        if(val_3.startupPools.Length < 1)
        {
                return;
        }
        
        var val_4 = 0;
        do
        {
            ObjectPool.CreatePool(prefab:  StartupPool[].__il2cppRuntimeField_namespaze, initialPoolSize:  StartupPool[].__il2cppRuntimeField_name);
            val_4 = val_4 + 1;
        }
        while(val_4 < val_3.startupPools.Length);
    
    }
    public static void CreatePool<T>(T prefab, int initialPoolSize)
    {
        ObjectPool.CreatePool(prefab:  prefab.gameObject, initialPoolSize:  initialPoolSize);
    }
    public static void CreatePool(UnityEngine.GameObject prefab, int initialPoolSize)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_12;
        UnityEngine.Transform val_13;
        if(prefab == 0)
        {
                return;
        }
        
        val_13 = 1152921504881233920;
        ObjectPool val_2 = ObjectPool.instance;
        if((val_2.pooledObjects.ContainsKey(key:  prefab)) == true)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.GameObject> val_4 = null;
        val_12 = val_4;
        val_4 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        ObjectPool val_5 = ObjectPool.instance;
        val_5.pooledObjects.Add(key:  prefab, value:  val_4);
        if(initialPoolSize < 1)
        {
                return;
        }
        
        prefab.SetActive(value:  false);
        val_13 = ObjectPool.instance.transform;
        UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  prefab);
        val_9.transform.SetParent(p:  val_13);
        val_4.Add(item:  val_9);
        prefab.SetActive(value:  prefab.activeSelf);
    }
    public static T Spawn<T>(T prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        UnityEngine.GameObject val_2 = ObjectPool.Spawn(prefab:  prefab.gameObject, parent:  parent, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        UnityEngine.GameObject val_2 = ObjectPool.Spawn(prefab:  prefab.gameObject, parent:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_3 = ObjectPool.Spawn(prefab:  prefab.gameObject, parent:  parent, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_3 = ObjectPool.Spawn(prefab:  prefab.gameObject, parent:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Transform parent)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = ObjectPool.Spawn(prefab:  prefab.gameObject, parent:  parent, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public static T Spawn<T>(T prefab)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = ObjectPool.Spawn(prefab:  prefab.gameObject, parent:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        goto __RuntimeMethodHiddenParam + 48 + 8;
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        UnityEngine.GameObject val_13;
        UnityEngine.Object val_14;
        val_13 = prefab;
        ObjectPool val_1 = ObjectPool.instance;
        if((val_1.pooledObjects.TryGetValue(key:  val_13, value: out  0)) == false)
        {
            goto label_5;
        }
        
        if(6178512 < 1)
        {
            goto label_16;
        }
        
        val_14 = 0;
        goto label_8;
        label_13:
        if(6178512 <= 0)
        {
            goto label_10;
        }
        
        val_14 = mem[4306960419];
        val_2.RemoveAt(index:  0);
        label_8:
        if(val_14 == 0)
        {
            goto label_13;
        }
        
        label_10:
        if(val_14 == 0)
        {
            goto label_16;
        }
        
        if(val_14 != 0)
        {
            goto label_17;
        }
        
        label_5:
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_13);
        val_14 = val_6;
        UnityEngine.Transform val_7 = val_6.GetComponent<UnityEngine.Transform>();
        val_13 = val_7;
        val_7.SetParent(p:  parent);
        val_13.localPosition = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        val_13.localRotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        val_13.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        val_14.SetActive(value:  true);
        return val_14;
        label_16:
        val_14 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_13);
        label_17:
        UnityEngine.Transform val_10 = val_14.transform;
        val_10.SetParent(p:  parent);
        val_10.localPosition = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        val_10.localRotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        val_10.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        val_14.SetActive(value:  true);
        ObjectPool val_12 = ObjectPool.instance;
        val_12.spawnedObjects.Add(key:  val_14, value:  val_13);
        return val_14;
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  parent, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        return ObjectPool.Spawn(prefab:  prefab, parent:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Transform parent)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  parent, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  0, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
    }
    public static void Recycle<T>(T obj)
    {
        ObjectPool.Recycle(obj:  obj.gameObject);
    }
    public static void Recycle(UnityEngine.GameObject obj)
    {
        UnityEngine.GameObject val_2 = 0;
        ObjectPool val_1 = ObjectPool.instance;
        if((val_1.spawnedObjects.TryGetValue(key:  obj, value: out  val_2)) != false)
        {
                ObjectPool.Recycle(obj:  obj, prefab:  val_2);
            return;
        }
        
        if(obj == 0)
        {
                return;
        }
        
        if(ObjectPool.instance != 0)
        {
                if(ObjectPool.instance.transform != 0)
        {
                obj.transform.SetParent(p:  ObjectPool.instance.transform);
        }
        
        }
        
        UnityEngine.Object.Destroy(obj:  obj);
    }
    private static void Recycle(UnityEngine.GameObject obj, UnityEngine.GameObject prefab)
    {
        ObjectPool val_1 = ObjectPool.instance;
        if((val_1.pooledObjects.TryGetValue(key:  prefab, value: out  0)) != false)
        {
                val_2.Add(item:  obj);
        }
        
        ObjectPool val_4 = ObjectPool.instance;
        bool val_5 = val_4.spawnedObjects.Remove(key:  obj);
        obj.transform.SetParent(p:  ObjectPool.instance.transform);
        obj.SetActive(value:  false);
    }
    public static void RecycleAll<T>(T prefab)
    {
        if(prefab == 0)
        {
                return;
        }
        
        ObjectPool.RecycleAll(prefab:  prefab.gameObject);
    }
    public static void RecycleAll(UnityEngine.GameObject prefab)
    {
        UnityEngine.Object val_4;
        var val_5;
        var val_8;
        System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.GameObject> val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<UnityEngine.GameObject> val_13;
        if(ObjectPool.instance == null)
        {
                throw new NullReferenceException();
        }
        
        val_10 = val_1.spawnedObjects;
        if(val_10 == null)
        {
                throw new NullReferenceException();
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = val_10.GetEnumerator();
        label_12:
        if(val_5.MoveNext() == false)
        {
            goto label_5;
        }
        
        if(val_4 != prefab)
        {
            goto label_12;
        }
        
        val_11 = null;
        val_11 = null;
        ObjectPool.tempList.Add(item:  val_4);
        goto label_12;
        label_5:
        val_5.Dispose();
        val_12 = 0;
        goto label_13;
        label_21:
        if(((1152921513391091744 & 512) != 0) && (val_8 == 0))
        {
                if(ObjectPool.tempList == null)
        {
                throw new NullReferenceException();
        }
        
        }
        
        if(val_12 >= (ObjectPool.tempList + 24))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = ObjectPool.tempList + 16;
        val_9 = val_9 + 0;
        ObjectPool.Recycle(obj:  (ObjectPool.tempList + 16 + 0) + 32);
        val_12 = 1;
        label_13:
        val_10 = null;
        val_10 = null;
        val_13 = ObjectPool.tempList;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_12 < (ObjectPool.tempList + 24))
        {
            goto label_21;
        }
        
        val_13 = ObjectPool.tempList;
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        val_13.Clear();
    }
    public static void RecycleAll()
    {
        var val_3;
        var val_4;
        var val_5;
        System.Collections.Generic.List<UnityEngine.GameObject> val_6;
        val_3 = null;
        val_3 = null;
        ObjectPool val_1 = ObjectPool.instance;
        ObjectPool.tempList.AddRange(collection:  val_1.spawnedObjects.Keys);
        val_4 = 0;
        goto label_6;
        label_14:
        if(val_4 >= (ObjectPool.tempList + 24))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = ObjectPool.tempList + 16;
        val_3 = val_3 + 0;
        ObjectPool.Recycle(obj:  (ObjectPool.tempList + 16 + 0) + 32);
        val_4 = 1;
        label_6:
        val_5 = null;
        val_5 = null;
        val_6 = ObjectPool.tempList;
        if(val_4 < (ObjectPool.tempList + 24))
        {
            goto label_14;
        }
        
        val_6 = ObjectPool.tempList;
        val_6.Clear();
    }
    public static bool IsSpawned(UnityEngine.GameObject obj)
    {
        ObjectPool val_1 = ObjectPool.instance;
        return val_1.spawnedObjects.ContainsKey(key:  obj);
    }
    public static int CountPooled<T>(T prefab)
    {
        return ObjectPool.CountPooled(prefab:  prefab.gameObject);
    }
    public static int CountPooled(UnityEngine.GameObject prefab)
    {
        var val_4;
        ObjectPool val_1 = ObjectPool.instance;
        if((val_1.pooledObjects.TryGetValue(key:  prefab, value: out  0)) != false)
        {
                val_4 = 6178512;
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }
    public static int CountSpawned<T>(T prefab)
    {
        return ObjectPool.CountSpawned(prefab:  prefab.gameObject);
    }
    public static int CountSpawned(UnityEngine.GameObject prefab)
    {
        var val_7;
        ObjectPool val_1 = ObjectPool.instance;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = val_1.spawnedObjects.Values.GetEnumerator();
        val_7 = 0;
        goto label_6;
        label_9:
        val_7 = val_7 + (UnityEngine.Object.op_Equality(x:  prefab, y:  0));
        label_6:
        if(0.MoveNext() == true)
        {
            goto label_9;
        }
        
        0.Dispose();
        return (int)val_7;
    }
    public static int CountAllPooled()
    {
        var val_5;
        ObjectPool val_1 = ObjectPool.instance;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = val_1.pooledObjects.Values.GetEnumerator();
        val_5 = 0;
        goto label_6;
        label_8:
        if(0 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_5 = 6178512;
        label_6:
        if(0.MoveNext() == true)
        {
            goto label_8;
        }
        
        0.Dispose();
        return (int)val_5;
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetPooled(UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list, bool appendList)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_5 = list;
        System.Collections.Generic.List<UnityEngine.GameObject> val_3 = 0;
        if(val_5 == null)
        {
            goto label_1;
        }
        
        if(appendList == true)
        {
            goto label_4;
        }
        
        label_5:
        val_5.Clear();
        goto label_4;
        label_1:
        System.Collections.Generic.List<UnityEngine.GameObject> val_1 = null;
        val_5 = val_1;
        val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        if(appendList == false)
        {
            goto label_5;
        }
        
        label_4:
        ObjectPool val_2 = ObjectPool.instance;
        if((val_2.pooledObjects.TryGetValue(key:  prefab, value: out  val_3)) == false)
        {
                return (System.Collections.Generic.List<UnityEngine.GameObject>)val_5;
        }
        
        val_1.AddRange(collection:  val_3);
        return (System.Collections.Generic.List<UnityEngine.GameObject>)val_5;
    }
    public static System.Collections.Generic.List<T> GetPooled<T>(T prefab, System.Collections.Generic.List<T> list, bool appendList)
    {
        var val_5;
        var val_6;
        val_5 = list;
        val_6 = prefab;
        System.Collections.Generic.List<UnityEngine.GameObject> val_3 = 0;
        if(val_5 == null)
        {
            goto label_1;
        }
        
        if(appendList == true)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        val_5 = __RuntimeMethodHiddenParam + 48;
        label_4:
        ObjectPool val_1 = ObjectPool.instance;
        if((val_1.pooledObjects.TryGetValue(key:  val_6.gameObject, value: out  val_3)) == false)
        {
                return (System.Collections.Generic.List<T>)val_5;
        }
        
        val_6 = 0;
        do
        {
            if(val_6 >= 6178512)
        {
                return (System.Collections.Generic.List<T>)val_5;
        }
        
            if(6178512 <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_5 = 11993091;
            val_5 = val_5 + 0;
            val_6 = val_6 + 1;
        }
        while(val_3 != 0);
        
        throw new NullReferenceException();
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetPooledByName(string name)
    {
        UnityEngine.GameObject val_12;
        int val_3 = ObjectPool.instance.transform.childCount;
        System.Collections.Generic.List<UnityEngine.GameObject> val_4 = null;
        val_12 = public System.Void System.Collections.Generic.List<UnityEngine.GameObject>::.ctor();
        val_4 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        if(val_3 < 1)
        {
                return val_4;
        }
        
        var val_12 = 0;
        do
        {
            ObjectPool val_5 = ObjectPool.instance;
            if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
            val_12 = 0;
            UnityEngine.Transform val_6 = val_5.transform;
            if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
            val_12 = val_12;
            UnityEngine.Transform val_7 = val_6.GetChild(index:  0);
            if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
            val_12 = 0;
            string val_8 = val_7.name;
            if(val_8 == null)
        {
                throw new NullReferenceException();
        }
        
            if((val_8.Contains(value:  name)) != false)
        {
                val_12 = val_7.gameObject;
            if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
            val_4.Add(item:  val_12);
        }
        
            val_12 = val_12 + 1;
        }
        while(val_12 < val_3);
        
        return val_4;
    }
    public static void RemovePooledByName(string name)
    {
        UnityEngine.Coroutine val_4 = ObjectPool.instance.StartCoroutine(routine:  ObjectPool.instance.RemovePooledByNameCoroutine(objName:  name));
    }
    private System.Collections.IEnumerator RemovePooledByNameCoroutine(string objName)
    {
        .objName = objName;
        return (System.Collections.IEnumerator)new ObjectPool.<RemovePooledByNameCoroutine>d__42(<>1__state:  0);
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetSpawned(UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list, bool appendList)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_6 = list;
        if(val_6 == null)
        {
            goto label_1;
        }
        
        if(appendList == true)
        {
            goto label_4;
        }
        
        label_5:
        val_6.Clear();
        goto label_4;
        label_1:
        System.Collections.Generic.List<UnityEngine.GameObject> val_1 = null;
        val_6 = val_1;
        val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        if(appendList == false)
        {
            goto label_5;
        }
        
        label_4:
        ObjectPool val_2 = ObjectPool.instance;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_2.spawnedObjects.GetEnumerator();
        label_15:
        if(0.MoveNext() == false)
        {
            goto label_10;
        }
        
        if(0 != prefab)
        {
            goto label_15;
        }
        
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        val_1.Add(item:  0);
        goto label_15;
        label_10:
        0.Dispose();
        return (System.Collections.Generic.List<UnityEngine.GameObject>)val_6;
    }
    public static System.Collections.Generic.List<T> GetSpawned<T>(T prefab, System.Collections.Generic.List<T> list, bool appendList)
    {
        var val_4;
        UnityEngine.Object val_5;
        var val_6;
        var val_10;
        var val_11;
        val_10 = __RuntimeMethodHiddenParam;
        val_11 = list;
        if(val_11 == null)
        {
            goto label_1;
        }
        
        if(appendList == true)
        {
            goto label_2;
        }
        
        label_7:
        if(prefab != null)
        {
            goto label_4;
        }
        
        label_1:
        val_11 = __RuntimeMethodHiddenParam + 48;
        if(appendList == false)
        {
            goto label_7;
        }
        
        label_2:
        label_4:
        ObjectPool val_2 = ObjectPool.instance;
        Dictionary.Enumerator<TKey, TValue> val_3 = val_2.spawnedObjects.GetEnumerator();
        label_19:
        if(val_6.MoveNext() == false)
        {
            goto label_13;
        }
        
        if(val_5 != prefab.gameObject)
        {
            goto label_19;
        }
        
        if(val_5 == 0)
        {
                throw new NullReferenceException();
        }
        
        if(val_11 == 0)
        {
                throw new NullReferenceException();
        }
        
        goto label_19;
        label_13:
        val_10 = 0;
        val_4 = val_5;
        val_5 = val_6;
        val_6 = null;
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_6.Dispose();
        if(val_10 != 0)
        {
                throw val_10;
        }
        
        return (System.Collections.Generic.List<T>)val_11;
    }
    public static ObjectPool get_instance()
    {
        var val_12;
        ObjectPool val_13;
        var val_14;
        var val_15;
        var val_16;
        val_12 = null;
        val_12 = null;
        val_13 = ObjectPool._instance;
        if(val_13 != 0)
        {
            goto label_5;
        }
        
        val_14 = null;
        val_13 = UnityEngine.Object.FindObjectOfType<ObjectPool>();
        val_14 = null;
        ObjectPool._instance = val_13;
        if(ObjectPool._instance == 0)
        {
            goto label_10;
        }
        
        label_5:
        val_15 = null;
        goto label_13;
        label_10:
        UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "ObjectPool");
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_4.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        val_4.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        val_16 = null;
        val_13 = val_4.AddComponent<ObjectPool>();
        val_16 = null;
        ObjectPool._instance = val_13;
        label_13:
        val_15 = null;
        return (ObjectPool)ObjectPool._instance;
    }
    public ObjectPool()
    {
        this.pooledObjects = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, System.Collections.Generic.List<UnityEngine.GameObject>>();
        this.spawnedObjects = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.GameObject>();
    }
    private static ObjectPool()
    {
        ObjectPool.tempList = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
