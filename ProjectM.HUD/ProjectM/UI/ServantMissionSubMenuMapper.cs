// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServantMissionSubMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class ServantMissionSubMenuMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MissionPerkEntryDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__MissionServantEntryDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllServantEntryDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__MissionLootResultEntryDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedMissionData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ThroneTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantList;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantMissionSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantMissionSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Tooltips_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_AllServants_Private_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetConnectedStation_Private_Boolean_Entity_byref_ServantCoffinstation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServantState_Private_State_Entity_Entity_byref_ServantCoffinstation_byref_Single_byref_ManagedMissionInjureDataAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSendServants_Private_Boolean_List_1_Data_byref_Entity_byref_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_MissionSuccessChance_Private_Void_byref_ServantMissionSettingsSingleton_byref_ServantMissionSetting_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_LootResult_Private_Void_ServantMissionSubMenu_PrefabLookupMap_byref_ServantMissionSettingsSingleton_ServantMissionSetting_Single_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_MissionLengthSlider_Private_Void_ServantMissionSubMenu_DynamicBuffer_1_ServantMissionSetting_byref_ServantMissionSetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_SelectedMission_Private_Boolean_ServantMissionSubMenu_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAssignedServantWithPerk_Private_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Servants_Private_Void_ServantMissionSubMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__21_0_Private_Void_Entity_ServantMissionSubMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__21_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__21_2_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__21_3_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__21_5_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249796, XrefRangeEnd = 1249829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249829, XrefRangeEnd = 1249841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249841, XrefRangeEnd = 1249843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249843, XrefRangeEnd = 1249856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249856, XrefRangeEnd = 1249901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249901, XrefRangeEnd = 1249979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250010, RefRangeEnd = 1250011, XrefRangeStart = 1249979, XrefRangeEnd = 1250010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_Tooltips()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_Tooltips_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250121, RefRangeEnd = 1250122, XrefRangeStart = 1250011, XrefRangeEnd = 1250121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_AllServants(EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_AllServants_Private_Void_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250122, XrefRangeEnd = 1250134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetConnectedStation(Entity servantEntity, out ServantCoffinstation result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &servantEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_TryGetConnectedStation_Private_Boolean_Entity_byref_ServantCoffinstation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250205, RefRangeEnd = 1250206, XrefRangeStart = 1250134, XrefRangeEnd = 1250205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantSelectEntry.State GetServantState(
      Entity throne,
      Entity servantEntity,
      [In] ref ServantCoffinstation station,
      out float injuryTimeLeft,
      out ManagedMissionInjureDataAsset injury)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = (System.IntPtr) &throne;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &servantEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref station;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref injuryTimeLeft;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_GetServantState_Private_State_Entity_Entity_byref_ServantCoffinstation_byref_Single_byref_ManagedMissionInjureDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ManagedMissionInjureDataAsset local = ref injury;
      System.IntPtr pointer = zero;
      ManagedMissionInjureDataAsset missionInjureDataAsset = pointer == System.IntPtr.Zero ? (ManagedMissionInjureDataAsset) null : new ManagedMissionInjureDataAsset(pointer);
      local = missionInjureDataAsset;
      return *(ServantSelectEntry.State*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250206, XrefRangeEnd = 1250223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetSendServants(
      List<MissionServantEntry.Data> missionServantEntryDatas,
      out Entity servant1,
      out Entity servant2,
      out Entity servant3)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) missionServantEntryDatas);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref servant1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref servant2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref servant3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_GetSendServants_Private_Boolean_List_1_Data_byref_Entity_byref_Entity_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250281, RefRangeEnd = 1250282, XrefRangeStart = 1250223, XrefRangeEnd = 1250281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_MissionSuccessChance(
      [In] ref ServantMissionSettingsSingleton servantMissionSettings,
      [In] ref ServantMissionSetting servantMissionSetting,
      out float perkLootBonus)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref servantMissionSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantMissionSetting;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref perkLootBonus;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_MissionSuccessChance_Private_Void_byref_ServantMissionSettingsSingleton_byref_ServantMissionSetting_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250365, RefRangeEnd = 1250366, XrefRangeStart = 1250282, XrefRangeEnd = 1250365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_LootResult(
      ServantMissionSubMenu menu,
      PrefabLookupMap prefabMapping,
      [In] ref ServantMissionSettingsSingleton servantMissionSettings,
      ServantMissionSetting servantMissionSetting,
      float perkDropBonus,
      ServerGameBalanceSettings gameBalanceSetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMapping;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantMissionSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &servantMissionSetting;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &perkDropBonus;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &gameBalanceSetting;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_LootResult_Private_Void_ServantMissionSubMenu_PrefabLookupMap_byref_ServantMissionSettingsSingleton_ServantMissionSetting_Single_ServerGameBalanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250416, RefRangeEnd = 1250417, XrefRangeStart = 1250366, XrefRangeEnd = 1250416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_MissionLengthSlider(
      ServantMissionSubMenu menu,
      DynamicBuffer<ServantMissionSetting> servantMissionSettingsBuffer,
      out ServantMissionSetting servantMissionSetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &servantMissionSettingsBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantMissionSetting;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_MissionLengthSlider_Private_Void_ServantMissionSubMenu_DynamicBuffer_1_ServantMissionSetting_byref_ServantMissionSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250526, RefRangeEnd = 1250527, XrefRangeStart = 1250417, XrefRangeEnd = 1250526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Update_SelectedMission(ServantMissionSubMenu menu, out bool newMission)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref newMission;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_SelectedMission_Private_Boolean_ServantMissionSubMenu_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250549, RefRangeEnd = 1250550, XrefRangeStart = 1250527, XrefRangeEnd = 1250549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasAssignedServantWithPerk(PrefabGUID perkId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &perkId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_HasAssignedServantWithPerk_Private_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250550, XrefRangeEnd = 1250567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update_Servants(ServantMissionSubMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_Servants_Private_Void_ServantMissionSubMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250567, XrefRangeEnd = 1250596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantMissionSubMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250600, RefRangeEnd = 1250601, XrefRangeStart = 1250596, XrefRangeEnd = 1250600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__21_0(Entity entity, ServantMissionSubMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_0_Private_Void_Entity_ServantMissionSubMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250601, XrefRangeEnd = 1250623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__21_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250623, XrefRangeEnd = 1250674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__21_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250674, XrefRangeEnd = 1250676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__21_3(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250676, XrefRangeEnd = 1250679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__21_5(int entryIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_5_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250679, XrefRangeEnd = 1250739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250739, XrefRangeEnd = 1250755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnStartRunning_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250755, XrefRangeEnd = 1250771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1250775, RefRangeEnd = 1250776, XrefRangeStart = 1250771, XrefRangeEnd = 1250775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantMissionSubMenuMapper()
    {
      Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServantMissionSubMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr);
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionPerkEntryDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_MissionPerkEntryDatas));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionServantEntryDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_MissionServantEntryDatas));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__AllServantEntryDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_AllServantEntryDatas));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionLootResultEntryDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_MissionLootResultEntryDatas));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_Query));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__SelectedMissionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_SelectedMissionData));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__ThroneTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_ThroneTarget));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_ServantList));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantMissionSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_ServantMissionSettingsAccessor));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_ServerTimeAccessor));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_BalanceSettings));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantMissionSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, nameof (_ServantMissionSubMenu));
      ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_entityQuery");
      ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>OnStartRunning_LambdaJob0_profilerMarker");
      ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666541);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666542);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666543);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666544);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666545);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666546);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666547);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_Tooltips_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666548);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_AllServants_Private_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666549);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_TryGetConnectedStation_Private_Boolean_Entity_byref_ServantCoffinstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666550);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_GetServantState_Private_State_Entity_Entity_byref_ServantCoffinstation_byref_Single_byref_ManagedMissionInjureDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666551);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_GetSendServants_Private_Boolean_List_1_Data_byref_Entity_byref_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666552);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_MissionSuccessChance_Private_Void_byref_ServantMissionSettingsSingleton_byref_ServantMissionSetting_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666553);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_LootResult_Private_Void_ServantMissionSubMenu_PrefabLookupMap_byref_ServantMissionSettingsSingleton_ServantMissionSetting_Single_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666554);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_MissionLengthSlider_Private_Void_ServantMissionSubMenu_DynamicBuffer_1_ServantMissionSetting_byref_ServantMissionSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666555);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_SelectedMission_Private_Boolean_ServantMissionSubMenu_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666556);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_HasAssignedServantWithPerk_Private_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666557);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Update_Servants_Private_Void_ServantMissionSubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666558);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666559);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_0_Private_Void_Entity_ServantMissionSubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666560);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666561);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666562);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666563);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__21_5_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666564);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666565);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnStartRunning_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666566);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666567);
      ServantMissionSubMenuMapper.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, 100666568);
    }

    public ServantMissionSubMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MissionPerkEntry.Data> _MissionPerkEntryDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionPerkEntryDatas));
        return pointer == System.IntPtr.Zero ? (List<MissionPerkEntry.Data>) null : new List<MissionPerkEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionPerkEntryDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MissionServantEntry.Data> _MissionServantEntryDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionServantEntryDatas));
        return pointer == System.IntPtr.Zero ? (List<MissionServantEntry.Data>) null : new List<MissionServantEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionServantEntryDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ServantSelectEntry.Data> _AllServantEntryDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__AllServantEntryDatas));
        return pointer == System.IntPtr.Zero ? (List<ServantSelectEntry.Data>) null : new List<ServantSelectEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__AllServantEntryDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MissionLootResultEntry.Data> _MissionLootResultEntryDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionLootResultEntryDatas));
        return pointer == System.IntPtr.Zero ? (List<MissionLootResultEntry.Data>) null : new List<MissionLootResultEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__MissionLootResultEntryDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe Nullable_Unboxed<MissionData> _SelectedMissionData
    {
      get
      {
        return *(Nullable_Unboxed<MissionData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__SelectedMissionData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__SelectedMissionData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<MissionData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Entity _ThroneTarget
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ThroneTarget));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ThroneTarget)) = value;
      }
    }

    public unsafe NativeList<Entity> _ServantList
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServantMissionSettingsSingleton> _ServantMissionSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServantMissionSettingsSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantMissionSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantMissionSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServantMissionSettingsSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ServantMissionSubMenu _ServantMissionSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantMissionSubMenu));
        return pointer == System.IntPtr.Zero ? (ServantMissionSubMenu) null : new ServantMissionSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr__ServantMissionSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnStartRunning_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnStartRunning_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnStartRunning_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.ServantMissionSubMenuMapper/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__21_4;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__21_4_Internal_Boolean_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249667, XrefRangeEnd = 1249669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _OnStartRunning_b__21_4(MissionServantEntry.Data x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c.NativeMethodInfoPtr__OnStartRunning_b__21_4_Internal_Boolean_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c>.NativeClassPtr);
        ServantMissionSubMenuMapper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c>.NativeClassPtr, "<>9");
        ServantMissionSubMenuMapper.__c.NativeFieldInfoPtr___9__21_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c>.NativeClassPtr, "<>9__21_4");
        ServantMissionSubMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c>.NativeClassPtr, 100666570);
        ServantMissionSubMenuMapper.__c.NativeMethodInfoPtr__OnStartRunning_b__21_4_Internal_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c>.NativeClassPtr, 100666571);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServantMissionSubMenuMapper.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenuMapper.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServantMissionSubMenuMapper.__c) null : new ServantMissionSubMenuMapper.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenuMapper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Predicate<MissionServantEntry.Data> __9__21_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenuMapper.__c.NativeFieldInfoPtr___9__21_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<MissionServantEntry.Data>) null : new Il2CppSystem.Predicate<MissionServantEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenuMapper.__c.NativeFieldInfoPtr___9__21_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServantMissionSubMenuMapper/<>c__DisplayClass22_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass22_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_servantCoffinList;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0;
      [FieldOffset(0)]
      public NativeList<Entity> servantCoffinList;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass22_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass22_0()
      {
        Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass22_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass22_0>.NativeClassPtr);
        ServantMissionSubMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_servantCoffinList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, nameof (servantCoffinList));
        ServantMissionSubMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, 100666572);
        ServantMissionSubMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, 100666573);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.ServantMissionSubMenuMapper/<>c__DisplayClass24_0")]
    public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_perk;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_AllServants_b__0_Internal_Boolean_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass24_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass24_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249669, XrefRangeEnd = 1249670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Update_AllServants_b__0(MissionPerkEntry.Data x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass24_0.NativeMethodInfoPtr__Update_AllServants_b__0_Internal_Boolean_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass24_0()
      {
        Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass24_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass24_0>.NativeClassPtr);
        ServantMissionSubMenuMapper.__c__DisplayClass24_0.NativeFieldInfoPtr_perk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass24_0>.NativeClassPtr, nameof (perk));
        ServantMissionSubMenuMapper.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass24_0>.NativeClassPtr, 100666574);
        ServantMissionSubMenuMapper.__c__DisplayClass24_0.NativeMethodInfoPtr__Update_AllServants_b__0_Internal_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass24_0>.NativeClassPtr, 100666575);
      }

      public __c__DisplayClass24_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PerksBuffer perk
      {
        get
        {
          return *(PerksBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass24_0.NativeFieldInfoPtr_perk));
        }
        [param: In] set
        {
          *(PerksBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass24_0.NativeFieldInfoPtr_perk)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServantMissionSubMenuMapper/ProjectM.UI.<>c__DisplayClass_OnStartRunning_LambdaJob0")]
    public sealed class __c__DisplayClass_OnStartRunning_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_ServantMissionSubMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1249683, RefRangeEnd = 1249684, XrefRangeStart = 1249681, XrefRangeEnd = 1249683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ServantMissionSubMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_ServantMissionSubMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249684, XrefRangeEnd = 1249686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1249692, RefRangeEnd = 1249693, XrefRangeStart = 1249686, XrefRangeEnd = 1249692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1249695, RefRangeEnd = 1249696, XrefRangeStart = 1249693, XrefRangeEnd = 1249695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ServantMissionSubMenuMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249696, XrefRangeEnd = 1249702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnStartRunning_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_ServantMissionSubMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100666576);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100666577);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100666578);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100666579);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, 100666580);
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnStartRunning_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ServantMissionSubMenuMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ServantMissionSubMenuMapper) null : new ServantMissionSubMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menu;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<ServantMissionSubMenu> forParameter_menu;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1249674, RefRangeEnd = 1249675, XrefRangeStart = 1249670, XrefRangeEnd = 1249674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantMissionSubMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1249680, RefRangeEnd = 1249681, XrefRangeStart = 1249675, XrefRangeEnd = 1249680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menu));
          ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666581);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666582);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menu;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menu));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<ServantMissionSubMenu>.Runtime runtime_menu
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu);
              return new LambdaParameterValueProvider_ManagedComponentData<ServantMissionSubMenu>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<ServantMissionSubMenu>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSubMenuMapper.__c__DisplayClass_OnStartRunning_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<ServantMissionSubMenu>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ServantMissionSubMenuMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_servantCoffinList;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<Entity> servantCoffinList;
      [FieldOffset(16)]
      public ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249777, XrefRangeEnd = 1249780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantMissionSubMenuMapper.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantMissionSubMenuMapper.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249780, XrefRangeEnd = 1249782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1249785, RefRangeEnd = 1249786, XrefRangeStart = 1249782, XrefRangeEnd = 1249785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1035887, RefRangeEnd = 1035897, XrefRangeStart = 1035887, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantMissionSubMenuMapper componentSystem,
        ref ServantMissionSubMenuMapper.__c__DisplayClass22_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_byref___c__DisplayClass22_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249786, XrefRangeEnd = 1249790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249790, XrefRangeEnd = 1249796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_servantCoffinList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (servantCoffinList));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666583);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666584);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666585);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666586);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666587);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666588);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666589);
        ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666590);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantMissionSubMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSubMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666591);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666592);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.ServantMissionSubMenuMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.UI.RunWithoutJobSystem_00000BB0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000BB0$PostfixBurstDelegate");
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666593);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666594);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666595);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666596);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.ServantMissionSubMenuMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.UI.RunWithoutJobSystem_00000BB0$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249702, XrefRangeEnd = 1249716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249716, XrefRangeEnd = 1249734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249734, XrefRangeEnd = 1249749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1249776, RefRangeEnd = 1249777, XrefRangeStart = 1249749, XrefRangeEnd = 1249776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000BB0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666597);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666598);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666599);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666600);
          ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666602);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServantMissionSubMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
