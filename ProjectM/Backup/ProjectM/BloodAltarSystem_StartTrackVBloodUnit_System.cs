// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodAltarSystem_StartTrackVBloodUnit_System
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class BloodAltarSystem_StartTrackVBloodUnit_System : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Private_Void_StartTrackVBloodUnitEvent_FromCharacter_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999790, XrefRangeEnd = 999813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999813, XrefRangeEnd = 999837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 999861, RefRangeEnd = 999862, XrefRangeStart = 999837, XrefRangeEnd = 999861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleEvent(
      StartTrackVBloodUnitEvent trackVBloodUnitEvent,
      FromCharacter fromCharacter,
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &trackVBloodUnitEvent;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &fromCharacter;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &networkIdToEntityMap;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_HandleEvent_Private_Void_StartTrackVBloodUnitEvent_FromCharacter_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodAltarSystem_StartTrackVBloodUnit_System()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodAltarSystem_StartTrackVBloodUnit_System()
    {
      Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodAltarSystem_StartTrackVBloodUnit_System));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr);
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, nameof (_NetworkIdSystem));
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, nameof (_EventQuery));
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, 100677360);
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, 100677361);
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, 100677362);
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_HandleEvent_Private_Void_StartTrackVBloodUnitEvent_FromCharacter_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, 100677363);
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, 100677364);
      BloodAltarSystem_StartTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System>.NativeClassPtr, 100677365);
    }

    public BloodAltarSystem_StartTrackVBloodUnit_System(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
