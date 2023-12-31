// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleWorkstation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleWorkstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFloorType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusServantType;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetProgressSpeedMultiplier_Public_Single_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBloodEssence_Public_Boolean_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceRequirementsMultiplier_Public_Single_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0;
    [FieldOffset(0)]
    public CastleFloorTypes MatchingFloorType;
    [FieldOffset(4)]
    public ServantType BonusServantType;
    [FieldOffset(8)]
    public WorkstationLevel WorkstationLevel;

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 723683, RefRangeEnd = 723699, XrefRangeStart = 723669, XrefRangeEnd = 723683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetProgressSpeedMultiplier(
      DynamicBuffer<StationBonusBuffer> bonuses,
      NativeHashMap<PrefabGUID, StationBonusData> stationBonusLookupMap,
      bool hasBloodSource)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bonuses;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stationBonusLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hasBloodSource;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWorkstation.NativeMethodInfoPtr_GetProgressSpeedMultiplier_Public_Single_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 723710, RefRangeEnd = 723716, XrefRangeStart = 723699, XrefRangeEnd = 723710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasBloodEssence(
      DynamicBuffer<StationBonusBuffer> bonuses,
      NativeHashMap<PrefabGUID, StationBonusData> stationBonusLookupMap,
      bool hasBloodSource)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bonuses;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stationBonusLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hasBloodSource;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWorkstation.NativeMethodInfoPtr_HasBloodEssence_Public_Boolean_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 723738, RefRangeEnd = 723758, XrefRangeStart = 723716, XrefRangeEnd = 723738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetResourceRequirementsMultiplier(
      DynamicBuffer<StationBonusBuffer> bonuses,
      NativeHashMap<PrefabGUID, StationBonusData> stationBonusLookupMap,
      bool hasBloodSource)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bonuses;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stationBonusLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hasBloodSource;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleWorkstation.NativeMethodInfoPtr_GetResourceRequirementsMultiplier_Public_Single_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleWorkstation()
    {
      Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastleWorkstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr);
      CastleWorkstation.NativeFieldInfoPtr_MatchingFloorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr, nameof (MatchingFloorType));
      CastleWorkstation.NativeFieldInfoPtr_BonusServantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr, nameof (BonusServantType));
      CastleWorkstation.NativeFieldInfoPtr_WorkstationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr, nameof (WorkstationLevel));
      CastleWorkstation.NativeMethodInfoPtr_GetProgressSpeedMultiplier_Public_Single_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr, 100663985);
      CastleWorkstation.NativeMethodInfoPtr_HasBloodEssence_Public_Boolean_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr, 100663986);
      CastleWorkstation.NativeMethodInfoPtr_GetResourceRequirementsMultiplier_Public_Single_DynamicBuffer_1_StationBonusBuffer_NativeHashMap_2_PrefabGUID_StationBonusData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr, 100663987);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleWorkstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
