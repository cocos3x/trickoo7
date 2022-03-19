using UnityEngine;
public static class ObjectPoolExtensions
{
    // Methods
    public static void CreatePool<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void CreatePool<T>(T prefab, int initialPoolSize)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void CreatePool(UnityEngine.GameObject prefab)
    {
        ObjectPool.CreatePool(prefab:  prefab, initialPoolSize:  0);
    }
    public static void CreatePool(UnityEngine.GameObject prefab, int initialPoolSize)
    {
        ObjectPool.CreatePool(prefab:  prefab, initialPoolSize:  initialPoolSize);
    }
    public static T Spawn<T>(T prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T Spawn<T>(T prefab, UnityEngine.Transform parent)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static T Spawn<T>(T prefab)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        return ObjectPool.Spawn(prefab:  prefab, parent:  parent, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        return ObjectPool.Spawn(prefab:  prefab, parent:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Transform parent, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  parent, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Vector3 position)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab, UnityEngine.Transform parent)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  parent, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
    }
    public static UnityEngine.GameObject Spawn(UnityEngine.GameObject prefab)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        return ObjectPool.Spawn(prefab:  prefab, parent:  0, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
    }
    public static void Recycle<T>(T obj)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void Recycle(UnityEngine.GameObject obj)
    {
        ObjectPool.Recycle(obj:  obj);
    }
    public static void RecycleAll<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void RecycleAll(UnityEngine.GameObject prefab)
    {
        ObjectPool.RecycleAll(prefab:  prefab);
    }
    public static int CountPooled<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static int CountPooled(UnityEngine.GameObject prefab)
    {
        return ObjectPool.CountPooled(prefab:  prefab);
    }
    public static int CountSpawned<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static int CountSpawned(UnityEngine.GameObject prefab)
    {
        return ObjectPool.CountSpawned(prefab:  prefab);
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetSpawned(UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list, bool appendList)
    {
        appendList = appendList;
        return ObjectPool.GetSpawned(prefab:  prefab, list:  list, appendList:  appendList);
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetSpawned(UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list)
    {
        return ObjectPool.GetSpawned(prefab:  prefab, list:  list, appendList:  false);
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetSpawned(UnityEngine.GameObject prefab)
    {
        return ObjectPool.GetSpawned(prefab:  prefab, list:  0, appendList:  false);
    }
    public static System.Collections.Generic.List<T> GetSpawned<T>(T prefab, System.Collections.Generic.List<T> list, bool appendList)
    {
        appendList = appendList;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<T> GetSpawned<T>(T prefab, System.Collections.Generic.List<T> list)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<T> GetSpawned<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetPooled(UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list, bool appendList)
    {
        appendList = appendList;
        return ObjectPool.GetPooled(prefab:  prefab, list:  list, appendList:  appendList);
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetPooled(UnityEngine.GameObject prefab, System.Collections.Generic.List<UnityEngine.GameObject> list)
    {
        return ObjectPool.GetPooled(prefab:  prefab, list:  list, appendList:  false);
    }
    public static System.Collections.Generic.List<UnityEngine.GameObject> GetPooled(UnityEngine.GameObject prefab)
    {
        return ObjectPool.GetPooled(prefab:  prefab, list:  0, appendList:  false);
    }
    public static System.Collections.Generic.List<T> GetPooled<T>(T prefab, System.Collections.Generic.List<T> list, bool appendList)
    {
        appendList = appendList;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<T> GetPooled<T>(T prefab, System.Collections.Generic.List<T> list)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static System.Collections.Generic.List<T> GetPooled<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }

}
