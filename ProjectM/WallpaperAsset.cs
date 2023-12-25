// Decompiled with JetBrains decompiler
// Type: WallpaperAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Malee;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class WallpaperAsset : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_WallPrefabs;
  private static readonly System.IntPtr NativeFieldInfoPtr_PillarPrefabs;
  private static readonly System.IntPtr NativeFieldInfoPtr_Instances;
  private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921771, XrefRangeEnd = 921772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Convert(
    EntityManager dstManager,
    GameObjectConversionSystem conversionSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &dstManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WallpaperAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WallpaperAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WallpaperAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WallpaperAsset()
  {
    Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (WallpaperAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr);
    WallpaperAsset.NativeFieldInfoPtr_WallPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, nameof (WallPrefabs));
    WallpaperAsset.NativeFieldInfoPtr_PillarPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, nameof (PillarPrefabs));
    WallpaperAsset.NativeFieldInfoPtr_Instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, nameof (Instances));
    WallpaperAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, 100663719);
    WallpaperAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, 100663720);
  }

  public WallpaperAsset(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe WallpaperAsset.ReorderableArray_ObjectDatas WallPrefabs
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.NativeFieldInfoPtr_WallPrefabs));
      return pointer == System.IntPtr.Zero ? (WallpaperAsset.ReorderableArray_ObjectDatas) null : new WallpaperAsset.ReorderableArray_ObjectDatas(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.NativeFieldInfoPtr_WallPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WallpaperAsset.ReorderableArray_ObjectDatas PillarPrefabs
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.NativeFieldInfoPtr_PillarPrefabs));
      return pointer == System.IntPtr.Zero ? (WallpaperAsset.ReorderableArray_ObjectDatas) null : new WallpaperAsset.ReorderableArray_ObjectDatas(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.NativeFieldInfoPtr_PillarPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<WallpaperAsset.InstanceData> Instances
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.NativeFieldInfoPtr_Instances));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<WallpaperAsset.InstanceData>) null : new Il2CppReferenceArray<WallpaperAsset.InstanceData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.NativeFieldInfoPtr_Instances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ReorderableArray_ObjectDatas : ReorderableArray<WallpaperAsset.ObjectData>
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921768, XrefRangeEnd = 921771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReorderableArray_ObjectDatas()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallpaperAsset.ReorderableArray_ObjectDatas>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WallpaperAsset.ReorderableArray_ObjectDatas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReorderableArray_ObjectDatas()
    {
      Il2CppClassPointerStore<WallpaperAsset.ReorderableArray_ObjectDatas>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, nameof (ReorderableArray_ObjectDatas));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperAsset.ReorderableArray_ObjectDatas>.NativeClassPtr);
      WallpaperAsset.ReorderableArray_ObjectDatas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAsset.ReorderableArray_ObjectDatas>.NativeClassPtr, 100663721);
    }

    public ReorderableArray_ObjectDatas(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  [Serializable]
  public class ObjectData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SplitCount;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ObjectData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallpaperAsset.ObjectData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WallpaperAsset.ObjectData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ObjectData()
    {
      Il2CppClassPointerStore<WallpaperAsset.ObjectData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, nameof (ObjectData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperAsset.ObjectData>.NativeClassPtr);
      WallpaperAsset.ObjectData.NativeFieldInfoPtr_TargetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAsset.ObjectData>.NativeClassPtr, nameof (TargetPrefab));
      WallpaperAsset.ObjectData.NativeFieldInfoPtr_SplitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAsset.ObjectData>.NativeClassPtr, nameof (SplitCount));
      WallpaperAsset.ObjectData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAsset.ObjectData>.NativeClassPtr, 100663722);
    }

    public ObjectData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<GameObject> TargetPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.ObjectData.NativeFieldInfoPtr_TargetPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.ObjectData.NativeFieldInfoPtr_TargetPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ObjectSplits SplitCount
    {
      get
      {
        return *(ObjectSplits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.ObjectData.NativeFieldInfoPtr_SplitCount));
      }
      [param: In] set
      {
        *(ObjectSplits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.ObjectData.NativeFieldInfoPtr_SplitCount)) = value;
      }
    }
  }

  [Serializable]
  public class InstanceData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WallBlueprint;
    private static readonly System.IntPtr NativeFieldInfoPtr_PillarBlueprint;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InstanceData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WallpaperAsset.InstanceData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WallpaperAsset.InstanceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InstanceData()
    {
      Il2CppClassPointerStore<WallpaperAsset.InstanceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WallpaperAsset>.NativeClassPtr, nameof (InstanceData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WallpaperAsset.InstanceData>.NativeClassPtr);
      WallpaperAsset.InstanceData.NativeFieldInfoPtr_WallBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAsset.InstanceData>.NativeClassPtr, nameof (WallBlueprint));
      WallpaperAsset.InstanceData.NativeFieldInfoPtr_PillarBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WallpaperAsset.InstanceData>.NativeClassPtr, nameof (PillarBlueprint));
      WallpaperAsset.InstanceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WallpaperAsset.InstanceData>.NativeClassPtr, 100663723);
    }

    public InstanceData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<WallpaperSetAuthoring> WallBlueprint
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.InstanceData.NativeFieldInfoPtr_WallBlueprint));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<WallpaperSetAuthoring>) null : new WeakAssetReference<WallpaperSetAuthoring>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.InstanceData.NativeFieldInfoPtr_WallBlueprint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<WallpaperSetAuthoring> PillarBlueprint
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.InstanceData.NativeFieldInfoPtr_PillarBlueprint));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<WallpaperSetAuthoring>) null : new WeakAssetReference<WallpaperSetAuthoring>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WallpaperAsset.InstanceData.NativeFieldInfoPtr_PillarBlueprint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
