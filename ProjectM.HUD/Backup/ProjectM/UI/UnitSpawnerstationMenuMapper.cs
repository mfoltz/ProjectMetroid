// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UnitSpawnerstationMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class UnitSpawnerstationMenuMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__GetItemDatasQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnitSpawnerstationSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnitSpawnerstationSubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__Target;
    private static readonly System.IntPtr NativeFieldInfoPtr__InteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnitSpawnerStationContextEntriesCache;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServantText_Private_LocalizationKey_ServantType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalUser_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_UnitSpawnerstationMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_4_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_5_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253753, XrefRangeEnd = 1253775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253775, XrefRangeEnd = 1253794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253794, XrefRangeEnd = 1253839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253839, XrefRangeEnd = 1253854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253854, XrefRangeEnd = 1253881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253881, XrefRangeEnd = 1253888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253888, XrefRangeEnd = 1253905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe LocalizationKey GetServantText(ServantType servantType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &servantType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetServantText_Private_LocalizationKey_ServantType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253905, XrefRangeEnd = 1253909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkId GetTargetInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1243841, RefRangeEnd = 1243843, XrefRangeStart = 1243841, XrefRangeEnd = 1243843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalUser()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1243843, RefRangeEnd = 1243845, XrefRangeStart = 1243843, XrefRangeEnd = 1243845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalPlayer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253909, XrefRangeEnd = 1253919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitSpawnerstationMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253919, XrefRangeEnd = 1253925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_0(
      Entity entity,
      ref UnitSpawnerstationMenu.InitData initData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253925, XrefRangeEnd = 1254059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_1(Entity entity, UnitSpawnerstationMenu stationMenu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stationMenu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_UnitSpawnerstationMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Entity _OnStartRunning_b__16_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254059, XrefRangeEnd = 1254065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_4(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_4_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254065, XrefRangeEnd = 1254067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_5(int itemIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_5_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitSpawnerstationMenuMapper()
    {
      Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UnitSpawnerstationMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr);
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_Query));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_GetItemDatasQuery));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_InventorySubMenu));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_InventorySubMenuEntity));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerstationSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_UnitSpawnerstationSubMenu));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerstationSubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_UnitSpawnerstationSubMenuEntity));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_Target));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_InteractBuff));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerStationContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, nameof (_UnitSpawnerStationContextEntriesCache));
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666770);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666771);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666772);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666773);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666774);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666775);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666776);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetServantText_Private_LocalizationKey_ServantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666777);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666778);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666779);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666780);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666781);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666782);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_UnitSpawnerstationMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666783);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666784);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_4_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666785);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_5_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666786);
      UnitSpawnerstationMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, 100666787);
    }

    public UnitSpawnerstationMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _GetItemDatasQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventorySubMenu _InventorySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InventorySubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _InventorySubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity)) = value;
      }
    }

    public unsafe UnitSpawnerstationSubMenu _UnitSpawnerstationSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerstationSubMenu));
        return pointer == System.IntPtr.Zero ? (UnitSpawnerstationSubMenu) null : new UnitSpawnerstationSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerstationSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _UnitSpawnerstationSubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerstationSubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerstationSubMenuEntity)) = value;
      }
    }

    public unsafe Entity _Target
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__Target));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__Target)) = value;
      }
    }

    public unsafe Entity _InteractBuff
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InteractBuff));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__InteractBuff)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputContextEntry.Data> _UnitSpawnerStationContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerStationContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.NativeFieldInfoPtr__UnitSpawnerStationContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.UnitSpawnerstationMenuMapper/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_3_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253630, XrefRangeEnd = 1253636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnStartRunning_b__16_3()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.__c.NativeMethodInfoPtr__OnStartRunning_b__16_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c>.NativeClassPtr);
        UnitSpawnerstationMenuMapper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c>.NativeClassPtr, "<>9");
        UnitSpawnerstationMenuMapper.__c.NativeFieldInfoPtr___9__16_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c>.NativeClassPtr, "<>9__16_3");
        UnitSpawnerstationMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c>.NativeClassPtr, 100666789);
        UnitSpawnerstationMenuMapper.__c.NativeMethodInfoPtr__OnStartRunning_b__16_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c>.NativeClassPtr, 100666790);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe UnitSpawnerstationMenuMapper.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitSpawnerstationMenuMapper.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnitSpawnerstationMenuMapper.__c) null : new UnitSpawnerstationMenuMapper.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitSpawnerstationMenuMapper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__16_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitSpawnerstationMenuMapper.__c.NativeFieldInfoPtr___9__16_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitSpawnerstationMenuMapper.__c.NativeFieldInfoPtr___9__16_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.UnitSpawnerstationMenuMapper/<>c__DisplayClass18_0")]
    public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_recipeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRequirements;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UnitSpawnerstationMenu_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass18_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253636, XrefRangeEnd = 1253753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, UnitSpawnerstationMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UnitSpawnerstationMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass18_0()
      {
        Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper>.NativeClassPtr, "<>c__DisplayClass18_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr);
        UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
        UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_recipeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, nameof (recipeHashLookupMap));
        UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_getRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, nameof (getRequirements));
        UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, 100666791);
        UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UnitSpawnerstationMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerstationMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, 100666792);
      }

      public __c__DisplayClass18_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe UnitSpawnerstationMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UnitSpawnerstationMenuMapper) null : new UnitSpawnerstationMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, RecipeData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_recipeHashLookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_recipeHashLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, RecipeData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<RecipeRequirementBuffer> getRequirements
      {
        get
        {
          return *(BufferFromEntity<RecipeRequirementBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_getRequirements));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerstationMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_getRequirements), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<RecipeRequirementBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
