// Decompiled with JetBrains decompiler
// Type: SimpleAlternateMeshesGeneratorAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class SimpleAlternateMeshesGeneratorAsset : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_TargetPrefabs;
  private static readonly IntPtr NativeFieldInfoPtr_Instances;
  private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921767, XrefRangeEnd = 921768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Convert(
    EntityManager dstManager,
    GameObjectConversionSystem conversionSystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &dstManager;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SimpleAlternateMeshesGeneratorAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SimpleAlternateMeshesGeneratorAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleAlternateMeshesGeneratorAsset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SimpleAlternateMeshesGeneratorAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SimpleAlternateMeshesGeneratorAsset()
  {
    Il2CppClassPointerStore<SimpleAlternateMeshesGeneratorAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (SimpleAlternateMeshesGeneratorAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleAlternateMeshesGeneratorAsset>.NativeClassPtr);
    SimpleAlternateMeshesGeneratorAsset.NativeFieldInfoPtr_TargetPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleAlternateMeshesGeneratorAsset>.NativeClassPtr, nameof (TargetPrefabs));
    SimpleAlternateMeshesGeneratorAsset.NativeFieldInfoPtr_Instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleAlternateMeshesGeneratorAsset>.NativeClassPtr, nameof (Instances));
    SimpleAlternateMeshesGeneratorAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleAlternateMeshesGeneratorAsset>.NativeClassPtr, 100663717);
    SimpleAlternateMeshesGeneratorAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleAlternateMeshesGeneratorAsset>.NativeClassPtr, 100663718);
  }

  public SimpleAlternateMeshesGeneratorAsset(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<WeakAssetReference<GameObject>> TargetPrefabs
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleAlternateMeshesGeneratorAsset.NativeFieldInfoPtr_TargetPrefabs));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<GameObject>>) null : new Il2CppReferenceArray<WeakAssetReference<GameObject>>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleAlternateMeshesGeneratorAsset.NativeFieldInfoPtr_TargetPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<WeakAssetReference<WallpaperSetAuthoring>> Instances
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleAlternateMeshesGeneratorAsset.NativeFieldInfoPtr_Instances));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<WallpaperSetAuthoring>>) null : new Il2CppReferenceArray<WeakAssetReference<WallpaperSetAuthoring>>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleAlternateMeshesGeneratorAsset.NativeFieldInfoPtr_Instances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
