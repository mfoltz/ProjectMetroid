// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BloodAltarSubMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class BloodAltarSubMenuMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__VBloodUnitsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__BloodAltarOnDemandSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__HuntData;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockPowersData;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockStructuresData;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnlockRecipesData;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_BloodAltarSubMenu_9;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBloodAltarMenu_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AlreadyAdded_Private_Boolean_List_1_Data_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222495, XrefRangeEnd = 1222572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222572, XrefRangeEnd = 1222584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222584, XrefRangeEnd = 1222589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1223110, RefRangeEnd = 1223111, XrefRangeStart = 1222589, XrefRangeEnd = 1223110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateBloodAltarMenu()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenuMapper.NativeMethodInfoPtr_UpdateBloodAltarMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1223128, RefRangeEnd = 1223129, XrefRangeStart = 1223111, XrefRangeEnd = 1223128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AlreadyAdded(List<ResearchEntry.Data> unlockData, PrefabGUID guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unlockData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenuMapper.NativeMethodInfoPtr_AlreadyAdded_Private_Boolean_List_1_Data_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223129, XrefRangeEnd = 1223154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodAltarSubMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223154, XrefRangeEnd = 1223162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodAltarSubMenuMapper()
    {
      Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BloodAltarSubMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr);
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__BuffQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_BuffQuery));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__VBloodUnitsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_VBloodUnitsQuery));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_UIDataSystem));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__BloodAltarOnDemandSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_BloodAltarOnDemandSystem));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__HuntData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_HuntData));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockPowersData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_UnlockPowersData));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockStructuresData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_UnlockStructuresData));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockRecipesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_UnlockRecipesData));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__ServerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_ServerSettings));
      BloodAltarSubMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_BloodAltarSubMenu_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (_SingletonEntityQuery_BloodAltarSubMenu_9));
      BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664767);
      BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664768);
      BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664769);
      BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664770);
      BloodAltarSubMenuMapper.NativeMethodInfoPtr_UpdateBloodAltarMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664771);
      BloodAltarSubMenuMapper.NativeMethodInfoPtr_AlreadyAdded_Private_Boolean_List_1_Data_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664772);
      BloodAltarSubMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664773);
      BloodAltarSubMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, 100664774);
    }

    public BloodAltarSubMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _BuffQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__BuffQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__BuffQuery)) = value;
      }
    }

    public unsafe EntityQuery _VBloodUnitsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__VBloodUnitsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__VBloodUnitsQuery)) = value;
      }
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UIDataSystem));
        return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BloodAltarSystem_ConvertVBloodsOnDemand _BloodAltarOnDemandSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__BloodAltarOnDemandSystem));
        return pointer == System.IntPtr.Zero ? (BloodAltarSystem_ConvertVBloodsOnDemand) null : new BloodAltarSystem_ConvertVBloodsOnDemand(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__BloodAltarOnDemandSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BloodAltarHuntEntry.Data> _HuntData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__HuntData));
        return pointer == System.IntPtr.Zero ? (List<BloodAltarHuntEntry.Data>) null : new List<BloodAltarHuntEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__HuntData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchEntry.Data> _UnlockPowersData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockPowersData));
        return pointer == System.IntPtr.Zero ? (List<ResearchEntry.Data>) null : new List<ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockPowersData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchEntry.Data> _UnlockStructuresData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockStructuresData));
        return pointer == System.IntPtr.Zero ? (List<ResearchEntry.Data>) null : new List<ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockStructuresData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ResearchEntry.Data> _UnlockRecipesData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockRecipesData));
        return pointer == System.IntPtr.Zero ? (List<ResearchEntry.Data>) null : new List<ResearchEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__UnlockRecipesData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__ServerSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__ServerSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_BloodAltarSubMenu_9
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_BloodAltarSubMenu_9));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSubMenuMapper.NativeFieldInfoPtr__SingletonEntityQuery_BloodAltarSubMenu_9)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BloodAltarTarget
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      [FieldOffset(0)]
      public Entity Target;

      static BloodAltarTarget()
      {
        Il2CppClassPointerStore<BloodAltarSubMenuMapper.BloodAltarTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, nameof (BloodAltarTarget));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSubMenuMapper.BloodAltarTarget>.NativeClassPtr);
        BloodAltarSubMenuMapper.BloodAltarTarget.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper.BloodAltarTarget>.NativeClassPtr, nameof (Target));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodAltarSubMenuMapper.BloodAltarTarget>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.BloodAltarSubMenuMapper/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateBloodAltarMenu_b__17_0_Internal_Int32_Data_Data_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSubMenuMapper.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222494, XrefRangeEnd = 1222495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _UpdateBloodAltarMenu_b__17_0(
        BloodAltarHuntEntry.Data x,
        BloodAltarHuntEntry.Data y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSubMenuMapper.__c.NativeMethodInfoPtr__UpdateBloodAltarMenu_b__17_0_Internal_Int32_Data_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<BloodAltarSubMenuMapper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSubMenuMapper>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSubMenuMapper.__c>.NativeClassPtr);
        BloodAltarSubMenuMapper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper.__c>.NativeClassPtr, "<>9");
        BloodAltarSubMenuMapper.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSubMenuMapper.__c>.NativeClassPtr, "<>9__17_0");
        BloodAltarSubMenuMapper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper.__c>.NativeClassPtr, 100664776);
        BloodAltarSubMenuMapper.__c.NativeMethodInfoPtr__UpdateBloodAltarMenu_b__17_0_Internal_Int32_Data_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSubMenuMapper.__c>.NativeClassPtr, 100664777);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BloodAltarSubMenuMapper.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BloodAltarSubMenuMapper.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BloodAltarSubMenuMapper.__c) null : new BloodAltarSubMenuMapper.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BloodAltarSubMenuMapper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<BloodAltarHuntEntry.Data> __9__17_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BloodAltarSubMenuMapper.__c.NativeFieldInfoPtr___9__17_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<BloodAltarHuntEntry.Data>) null : new Il2CppSystem.Comparison<BloodAltarHuntEntry.Data>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BloodAltarSubMenuMapper.__c.NativeFieldInfoPtr___9__17_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
