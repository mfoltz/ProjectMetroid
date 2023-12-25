﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.RepairstationAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class RepairstationAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RepairData;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnOnRepairPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_TransferTeamToRepairerTeam;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimCastleAreaOnRepair;
    private static readonly IntPtr NativeFieldInfoPtr_RepairSequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065244, XrefRangeEnd = 1065309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RepairstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065309, XrefRangeEnd = 1065313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RepairstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065313, XrefRangeEnd = 1065314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RepairstationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RepairstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RepairstationAuthoring()
    {
      Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RepairstationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr);
      RepairstationAuthoring.NativeFieldInfoPtr_RepairData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, nameof (RepairData));
      RepairstationAuthoring.NativeFieldInfoPtr_SpawnOnRepairPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, nameof (SpawnOnRepairPrefab));
      RepairstationAuthoring.NativeFieldInfoPtr_TransferTeamToRepairerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, nameof (TransferTeamToRepairerTeam));
      RepairstationAuthoring.NativeFieldInfoPtr_ClaimCastleAreaOnRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, nameof (ClaimCastleAreaOnRepair));
      RepairstationAuthoring.NativeFieldInfoPtr_RepairSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, nameof (RepairSequence));
      RepairstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, 100683716);
      RepairstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, 100683717);
      RepairstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairstationAuthoring>.NativeClassPtr, 100683718);
    }

    public RepairstationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RepairDataComponent RepairData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_RepairData));
        return pointer == IntPtr.Zero ? (RepairDataComponent) null : new RepairDataComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_RepairData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent SpawnOnRepairPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_SpawnOnRepairPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_SpawnOnRepairPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool TransferTeamToRepairerTeam
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_TransferTeamToRepairerTeam));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_TransferTeamToRepairerTeam)) = value;
      }
    }

    public unsafe bool ClaimCastleAreaOnRepair
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_ClaimCastleAreaOnRepair));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_ClaimCastleAreaOnRepair)) = value;
      }
    }

    public unsafe SequenceField RepairSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_RepairSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairstationAuthoring.NativeFieldInfoPtr_RepairSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
