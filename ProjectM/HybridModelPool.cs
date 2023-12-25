// Decompiled with JetBrains decompiler
// Type: HybridModelPool
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class HybridModelPool : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_UseHybridModelPooling;
  private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
  private static readonly System.IntPtr NativeFieldInfoPtr__PrefabToInstanceQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr__InstanceToPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr__InstanceIdToGameObject;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Public_GameObject_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnInstance_Public_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstantiatePrefab_Private_GameObject_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915464, XrefRangeEnd = 915487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HybridModelPool(Transform parent)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridModelPool.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915517, RefRangeEnd = 915518, XrefRangeStart = 915487, XrefRangeEnd = 915517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject GetInstance(GameObject prefab)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelPool.NativeMethodInfoPtr_GetInstance_Public_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915548, RefRangeEnd = 915549, XrefRangeStart = 915518, XrefRangeEnd = 915548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReturnInstance(GameObject instance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridModelPool.NativeMethodInfoPtr_ReturnInstance_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915564, RefRangeEnd = 915565, XrefRangeStart = 915549, XrefRangeEnd = 915564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject InstantiatePrefab(GameObject prefab)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelPool.NativeMethodInfoPtr_InstantiatePrefab_Private_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 915605, RefRangeEnd = 915608, XrefRangeStart = 915565, XrefRangeEnd = 915605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridModelPool.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HybridModelPool()
  {
    Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HybridModelPool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr);
    HybridModelPool.NativeFieldInfoPtr_UseHybridModelPooling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, nameof (UseHybridModelPooling));
    HybridModelPool.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, nameof (Parent));
    HybridModelPool.NativeFieldInfoPtr__PrefabToInstanceQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, nameof (_PrefabToInstanceQueue));
    HybridModelPool.NativeFieldInfoPtr__InstanceToPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, nameof (_InstanceToPrefab));
    HybridModelPool.NativeFieldInfoPtr__InstanceIdToGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, nameof (_InstanceIdToGameObject));
    HybridModelPool.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, 100663587);
    HybridModelPool.NativeMethodInfoPtr_GetInstance_Public_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, 100663588);
    HybridModelPool.NativeMethodInfoPtr_ReturnInstance_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, 100663589);
    HybridModelPool.NativeMethodInfoPtr_InstantiatePrefab_Private_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, 100663590);
    HybridModelPool.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelPool>.NativeClassPtr, 100663591);
  }

  public HybridModelPool(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool UseHybridModelPooling
  {
    get
    {
      bool hybridModelPooling;
      IL2CPP.il2cpp_field_static_get_value(HybridModelPool.NativeFieldInfoPtr_UseHybridModelPooling, (void*) &hybridModelPooling);
      return hybridModelPooling;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HybridModelPool.NativeFieldInfoPtr_UseHybridModelPooling, (void*) &value);
    }
  }

  public unsafe Transform Parent
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr_Parent));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, Queue<int>> _PrefabToInstanceQueue
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr__PrefabToInstanceQueue));
      return pointer == System.IntPtr.Zero ? (Dictionary<int, Queue<int>>) null : new Dictionary<int, Queue<int>>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr__PrefabToInstanceQueue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, int> _InstanceToPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr__InstanceToPrefab));
      return pointer == System.IntPtr.Zero ? (Dictionary<int, int>) null : new Dictionary<int, int>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr__InstanceToPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<int, GameObject> _InstanceIdToGameObject
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr__InstanceIdToGameObject));
      return pointer == System.IntPtr.Zero ? (Dictionary<int, GameObject>) null : new Dictionary<int, GameObject>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelPool.NativeFieldInfoPtr__InstanceIdToGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
