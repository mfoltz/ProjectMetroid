// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodAltarSystem_InsertBlood_System
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
  public class BloodAltarSystem_InsertBlood_System : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__InitializeSystem;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Private_Void_TryInsertBloodEvent_FromCharacter_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_0;
    private static readonly IntPtr NativeMethodInfoPtr_UnlockProgression_Private_Void_TryInsertBloodEvent_FromCharacter_EntityCommandBuffer_PrefabLookupMap_Entity_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000187, XrefRangeEnd = 1000223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000223, XrefRangeEnd = 1000248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1000294, RefRangeEnd = 1000295, XrefRangeStart = 1000248, XrefRangeEnd = 1000294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleEvent(
      TryInsertBloodEvent insertBloodEvent,
      FromCharacter fromCharacter,
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      EntityCommandBuffer commandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &insertBloodEvent;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &fromCharacter;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &networkIdToEntityMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &commandBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_HandleEvent_Private_Void_TryInsertBloodEvent_FromCharacter_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1000380, RefRangeEnd = 1000381, XrefRangeStart = 1000295, XrefRangeEnd = 1000380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockProgression(
      TryInsertBloodEvent insertBloodEvent,
      FromCharacter fromCharacter,
      EntityCommandBuffer commandBuffer,
      PrefabLookupMap prefabMapping,
      Entity targetBloodAltar,
      Entity progressionEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) &insertBloodEvent;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &fromCharacter;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &commandBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &prefabMapping;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &targetBloodAltar;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &progressionEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_UnlockProgression_Private_Void_TryInsertBloodEvent_FromCharacter_EntityCommandBuffer_PrefabLookupMap_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodAltarSystem_InsertBlood_System()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodAltarSystem_InsertBlood_System()
    {
      Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodAltarSystem_InsertBlood_System));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr);
      BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__InitializeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, nameof (_InitializeSystem));
      BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, nameof (_NetworkIdSystem));
      BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, nameof (_GameDataSystem));
      BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, nameof (_EventQuery));
      BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, 100677401);
      BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, 100677402);
      BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_HandleEvent_Private_Void_TryInsertBloodEvent_FromCharacter_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, 100677403);
      BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_UnlockProgression_Private_Void_TryInsertBloodEvent_FromCharacter_EntityCommandBuffer_PrefabLookupMap_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, 100677404);
      BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, 100677405);
      BloodAltarSystem_InsertBlood_System.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_InsertBlood_System>.NativeClassPtr, 100677406);
    }

    public BloodAltarSystem_InsertBlood_System(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _InitializeSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__InitializeSystem));
        return pointer == IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__InitializeSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_InsertBlood_System.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }
  }
}
