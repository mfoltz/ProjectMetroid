// Decompiled with JetBrains decompiler
// Type: ProjectM.StationMenuHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.UI;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class StationMenuHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FillBonusData_Public_Static_DynamicBuffer_1_StationBonusBuffer_EntityManager_Entity_CastleFloorsLocalizationKeys_NativeHashMap_2_PrefabGUID_StationBonusData_ManagedDataRegistry_CastleWorkstation_List_1_Data_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowVBloodTooltip_Public_Static_Boolean_EntityManager_World_FakeTooltip_Entity_ResearchEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowVBloodTooltip_Public_Static_Boolean_EntityManager_World_FakeTooltip_Entity_ResearchEntry_Vector3_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1209596, RefRangeEnd = 1209607, XrefRangeStart = 1209559, XrefRangeEnd = 1209596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DynamicBuffer<StationBonusBuffer> FillBonusData(
      EntityManager entityManager,
      Entity target,
      CastleFloorsLocalizationKeys castleFloorsLocalizationKeys,
      NativeHashMap<PrefabGUID, StationBonusData> stationBonusLookupMap,
      ManagedDataRegistry managedDataRegistry,
      CastleWorkstation castleWorkstation,
      List<StationBonusEntry.Data> bonusDatas,
      out bool hasBloodSource)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) castleFloorsLocalizationKeys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stationBonusLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) managedDataRegistry));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &castleWorkstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bonusDatas);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref hasBloodSource;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StationMenuHelper.NativeMethodInfoPtr_FillBonusData_Public_Static_DynamicBuffer_1_StationBonusBuffer_EntityManager_Entity_CastleFloorsLocalizationKeys_NativeHashMap_2_PrefabGUID_StationBonusData_ManagedDataRegistry_CastleWorkstation_List_1_Data_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<StationBonusBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1209612, RefRangeEnd = 1209618, XrefRangeStart = 1209607, XrefRangeEnd = 1209612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShowVBloodTooltip(
      EntityManager entityManager,
      World world,
      FakeTooltip fakeTooltip,
      Entity localPlayerEntity,
      ResearchEntry hoveredUnlock)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fakeTooltip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hoveredUnlock);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StationMenuHelper.NativeMethodInfoPtr_ShowVBloodTooltip_Public_Static_Boolean_EntityManager_World_FakeTooltip_Entity_ResearchEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1209747, RefRangeEnd = 1209752, XrefRangeStart = 1209618, XrefRangeEnd = 1209747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShowVBloodTooltip(
      EntityManager entityManager,
      World world,
      FakeTooltip fakeTooltip,
      Entity localPlayerEntity,
      ResearchEntry hoveredUnlock,
      Vector3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fakeTooltip);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayerEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hoveredUnlock);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StationMenuHelper.NativeMethodInfoPtr_ShowVBloodTooltip_Public_Static_Boolean_EntityManager_World_FakeTooltip_Entity_ResearchEntry_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StationMenuHelper()
    {
      Il2CppClassPointerStore<StationMenuHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (StationMenuHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationMenuHelper>.NativeClassPtr);
      StationMenuHelper.NativeMethodInfoPtr_FillBonusData_Public_Static_DynamicBuffer_1_StationBonusBuffer_EntityManager_Entity_CastleFloorsLocalizationKeys_NativeHashMap_2_PrefabGUID_StationBonusData_ManagedDataRegistry_CastleWorkstation_List_1_Data_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationMenuHelper>.NativeClassPtr, 100663640);
      StationMenuHelper.NativeMethodInfoPtr_ShowVBloodTooltip_Public_Static_Boolean_EntityManager_World_FakeTooltip_Entity_ResearchEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationMenuHelper>.NativeClassPtr, 100663641);
      StationMenuHelper.NativeMethodInfoPtr_ShowVBloodTooltip_Public_Static_Boolean_EntityManager_World_FakeTooltip_Entity_ResearchEntry_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationMenuHelper>.NativeClassPtr, 100663642);
    }

    public StationMenuHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
