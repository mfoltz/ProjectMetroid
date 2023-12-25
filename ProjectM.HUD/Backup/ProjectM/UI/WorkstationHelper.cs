// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.WorkstationHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public static class WorkstationHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FillStationBonuses_Public_Static_DynamicBuffer_1_StationBonusBuffer_EntityManager_Entity_GameDataSystem_CastleWorkstation_CastleFloorsLocalizationKeys_Boolean_List_1_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStationResourceMultiplier_Public_Static_Single_EntityManager_GameDataSystem_Entity_Single_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255005, XrefRangeEnd = 1255035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DynamicBuffer<StationBonusBuffer> FillStationBonuses(
      EntityManager entityManager,
      Entity target,
      GameDataSystem gameDataSystem,
      CastleWorkstation castleWorkstation,
      CastleFloorsLocalizationKeys castleFloorsLocalizationKeys,
      bool hasBloodSource,
      List<StationBonusEntry.Data> bonusDatas)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castleWorkstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) castleFloorsLocalizationKeys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hasBloodSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bonusDatas);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationHelper.NativeMethodInfoPtr_FillStationBonuses_Public_Static_DynamicBuffer_1_StationBonusBuffer_EntityManager_Entity_GameDataSystem_CastleWorkstation_CastleFloorsLocalizationKeys_Boolean_List_1_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DynamicBuffer<StationBonusBuffer>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1255049, RefRangeEnd = 1255050, XrefRangeStart = 1255035, XrefRangeEnd = 1255049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetStationResourceMultiplier(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity target,
      float defaultValue = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorkstationHelper.NativeMethodInfoPtr_GetStationResourceMultiplier_Public_Static_Single_EntityManager_GameDataSystem_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorkstationHelper()
    {
      Il2CppClassPointerStore<WorkstationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (WorkstationHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationHelper>.NativeClassPtr);
      WorkstationHelper.NativeMethodInfoPtr_FillStationBonuses_Public_Static_DynamicBuffer_1_StationBonusBuffer_EntityManager_Entity_GameDataSystem_CastleWorkstation_CastleFloorsLocalizationKeys_Boolean_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationHelper>.NativeClassPtr, 100666844);
      WorkstationHelper.NativeMethodInfoPtr_GetStationResourceMultiplier_Public_Static_Single_EntityManager_GameDataSystem_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkstationHelper>.NativeClassPtr, 100666845);
    }

    public WorkstationHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
