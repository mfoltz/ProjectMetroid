// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodAltarSystem_StartTrackVBloodUnit_System_V2
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
  public class BloodAltarSystem_StartTrackVBloodUnit_System_V2 : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__InitializeSystem;
    private static readonly IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Private_Void_StartTrackVBloodUnitEventV2_FromCharacter_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_EntityCommandBuffer_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999862, XrefRangeEnd = 999900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999900, XrefRangeEnd = 999902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999902, XrefRangeEnd = 999928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 999970, RefRangeEnd = 999971, XrefRangeStart = 999928, XrefRangeEnd = 999970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleEvent(
      StartTrackVBloodUnitEventV2 trackVBloodUnitEvent,
      FromCharacter fromCharacter,
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      EntityCommandBuffer spawnCommandBuffer,
      EntityCommandBuffer destroyCommandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &trackVBloodUnitEvent;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &fromCharacter;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &networkIdToEntityMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &spawnCommandBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &destroyCommandBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_HandleEvent_Private_Void_StartTrackVBloodUnitEventV2_FromCharacter_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodAltarSystem_StartTrackVBloodUnit_System_V2()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodAltarSystem_StartTrackVBloodUnit_System_V2()
    {
      Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodAltarSystem_StartTrackVBloodUnit_System_V2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr);
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__InitializeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, nameof (_InitializeSystem));
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, nameof (_DestroyBarrier));
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, nameof (_NetworkIdSystem));
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, nameof (_GameDataSystem));
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, nameof (_EventQuery));
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, 100677366);
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, 100677367);
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, 100677368);
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_HandleEvent_Private_Void_StartTrackVBloodUnitEventV2_FromCharacter_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, 100677369);
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, 100677370);
      BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StartTrackVBloodUnit_System_V2>.NativeClassPtr, 100677371);
    }

    public BloodAltarSystem_StartTrackVBloodUnit_System_V2(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _InitializeSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__InitializeSystem));
        return pointer == IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__InitializeSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StartTrackVBloodUnit_System_V2.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }
  }
}
