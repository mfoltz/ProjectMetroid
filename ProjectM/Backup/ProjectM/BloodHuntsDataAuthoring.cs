// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodHuntsDataAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class BloodHuntsDataAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_VBloodDatas;
    private static readonly IntPtr NativeFieldInfoPtr_BloodHuntsPrefabs;
    private static readonly IntPtr NativeFieldInfoPtr_ShardBossHuntsPrefabs;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockGuid;
    private static readonly IntPtr NativeFieldInfoPtr_TrackBuffComponent;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977460, XrefRangeEnd = 977484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodHuntsDataAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977484, XrefRangeEnd = 977492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodHuntsDataAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodHuntsDataAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodHuntsDataAuthoring()
    {
      Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodHuntsDataAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr);
      BloodHuntsDataAuthoring.NativeFieldInfoPtr_VBloodDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr, nameof (VBloodDatas));
      BloodHuntsDataAuthoring.NativeFieldInfoPtr_BloodHuntsPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr, nameof (BloodHuntsPrefabs));
      BloodHuntsDataAuthoring.NativeFieldInfoPtr_ShardBossHuntsPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr, nameof (ShardBossHuntsPrefabs));
      BloodHuntsDataAuthoring.NativeFieldInfoPtr_UnlockGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr, nameof (UnlockGuid));
      BloodHuntsDataAuthoring.NativeFieldInfoPtr_TrackBuffComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr, nameof (TrackBuffComponent));
      BloodHuntsDataAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr, 100675548);
      BloodHuntsDataAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodHuntsDataAuthoring>.NativeClassPtr, 100675549);
    }

    public BloodHuntsDataAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<VBloodData> VBloodDatas
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_VBloodDatas));
        return pointer == IntPtr.Zero ? (List<VBloodData>) null : new List<VBloodData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_VBloodDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>> BloodHuntsPrefabs
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_BloodHuntsPrefabs));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>) null : new Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_BloodHuntsPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>> ShardBossHuntsPrefabs
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_ShardBossHuntsPrefabs));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>) null : new Il2CppReferenceArray<WeakAssetReference<PrefabGuidComponent>>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_ShardBossHuntsPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField UnlockGuid
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_UnlockGuid));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_UnlockGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<BuffComponent> TrackBuffComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_TrackBuffComponent));
        return pointer == IntPtr.Zero ? (WeakAssetReference<BuffComponent>) null : new WeakAssetReference<BuffComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodHuntsDataAuthoring.NativeFieldInfoPtr_TrackBuffComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
