// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantMissionSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ServantMissionSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Missions;
    private static readonly IntPtr NativeFieldInfoPtr_ServantInjuries;
    private static readonly IntPtr NativeFieldInfoPtr_StaticPartyBonus;
    private static readonly IntPtr NativeFieldInfoPtr_MissionLootVariance;
    private static readonly IntPtr NativeFieldInfoPtr_MissionBuff;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_MissionStarted;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_MissionSuccess;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_MissionFailed;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034091, XrefRangeEnd = 1034137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantMissionSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantMissionSettings()
    {
      Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantMissionSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr);
      ServantMissionSettings.NativeFieldInfoPtr_Missions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (Missions));
      ServantMissionSettings.NativeFieldInfoPtr_ServantInjuries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (ServantInjuries));
      ServantMissionSettings.NativeFieldInfoPtr_StaticPartyBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (StaticPartyBonus));
      ServantMissionSettings.NativeFieldInfoPtr_MissionLootVariance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (MissionLootVariance));
      ServantMissionSettings.NativeFieldInfoPtr_MissionBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (MissionBuff));
      ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (LKey_MissionStarted));
      ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (LKey_MissionSuccess));
      ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, nameof (LKey_MissionFailed));
      ServantMissionSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, 100680798);
      ServantMissionSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSettings>.NativeClassPtr, 100680799);
    }

    public ServantMissionSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ServantMissionSetting> Missions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_Missions));
        return pointer == IntPtr.Zero ? (List<ServantMissionSetting>) null : new List<ServantMissionSetting>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_Missions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ServantInjuredChanceComponent> ServantInjuries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_ServantInjuries));
        return pointer == IntPtr.Zero ? (List<ServantInjuredChanceComponent>) null : new List<ServantInjuredChanceComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_ServantInjuries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int StaticPartyBonus
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_StaticPartyBonus));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_StaticPartyBonus)) = value;
      }
    }

    public unsafe float MissionLootVariance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_MissionLootVariance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_MissionLootVariance)) = value;
      }
    }

    public unsafe PrefabGuidComponent MissionBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_MissionBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_MissionBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_MissionStarted
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionStarted));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionStarted)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissionSuccess
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionSuccess));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionSuccess)) = value;
      }
    }

    public unsafe LocalizationKey LKey_MissionFailed
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionFailed));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSettings.NativeFieldInfoPtr_LKey_MissionFailed)) = value;
      }
    }
  }
}
