// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TagPrefabCollectionPrefabsOnLoadSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  public class TagPrefabCollectionPrefabsOnLoadSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionQuery;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabGuidQuery;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427889, XrefRangeEnd = 1427913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427913, XrefRangeEnd = 1427918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TagPrefabCollectionPrefabsOnLoadSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TagPrefabCollectionPrefabsOnLoadSystem()
    {
      Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Terrain", nameof (TagPrefabCollectionPrefabsOnLoadSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr);
      TagPrefabCollectionPrefabsOnLoadSystem.NativeFieldInfoPtr__PrefabCollectionQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr, nameof (_PrefabCollectionQuery));
      TagPrefabCollectionPrefabsOnLoadSystem.NativeFieldInfoPtr__PrefabGuidQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr, nameof (_PrefabGuidQuery));
      TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr, 100670405);
      TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr, 100670406);
      TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr, 100670407);
      TagPrefabCollectionPrefabsOnLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagPrefabCollectionPrefabsOnLoadSystem>.NativeClassPtr, 100670408);
    }

    public TagPrefabCollectionPrefabsOnLoadSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _PrefabCollectionQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TagPrefabCollectionPrefabsOnLoadSystem.NativeFieldInfoPtr__PrefabCollectionQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TagPrefabCollectionPrefabsOnLoadSystem.NativeFieldInfoPtr__PrefabCollectionQuery)) = value;
      }
    }

    public unsafe EntityQuery _PrefabGuidQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TagPrefabCollectionPrefabsOnLoadSystem.NativeFieldInfoPtr__PrefabGuidQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TagPrefabCollectionPrefabsOnLoadSystem.NativeFieldInfoPtr__PrefabGuidQuery)) = value;
      }
    }
  }
}
