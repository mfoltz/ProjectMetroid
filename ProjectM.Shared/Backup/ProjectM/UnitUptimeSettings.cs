// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitUptimeSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class UnitUptimeSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ActiveTimeSpace;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveHoursDuration;
    private static readonly IntPtr NativeFieldInfoPtr_ActivePercentage;
    private static readonly IntPtr NativeFieldInfoPtr_RespawnVariancePercentage;
    private static readonly IntPtr NativeFieldInfoPtr_AllowedSpawnTimes;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_UnitUptimeSetting_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 749453, RefRangeEnd = 749454, XrefRangeStart = 749452, XrefRangeEnd = 749453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitUptimeSettings.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749454, XrefRangeEnd = 749456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitUptimeSetting Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitUptimeSettings.NativeMethodInfoPtr_Convert_Public_UnitUptimeSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UnitUptimeSetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749456, XrefRangeEnd = 749480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitUptimeSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749480, XrefRangeEnd = 749481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitUptimeSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitUptimeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitUptimeSettings()
    {
      Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitUptimeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr);
      UnitUptimeSettings.NativeFieldInfoPtr_ActiveTimeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, nameof (ActiveTimeSpace));
      UnitUptimeSettings.NativeFieldInfoPtr_ActiveHoursDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, nameof (ActiveHoursDuration));
      UnitUptimeSettings.NativeFieldInfoPtr_ActivePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, nameof (ActivePercentage));
      UnitUptimeSettings.NativeFieldInfoPtr_RespawnVariancePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, nameof (RespawnVariancePercentage));
      UnitUptimeSettings.NativeFieldInfoPtr_AllowedSpawnTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, nameof (AllowedSpawnTimes));
      UnitUptimeSettings.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, nameof (_Guid));
      UnitUptimeSettings.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, 100666015);
      UnitUptimeSettings.NativeMethodInfoPtr_Convert_Public_UnitUptimeSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, 100666016);
      UnitUptimeSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, 100666017);
      UnitUptimeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitUptimeSettings>.NativeClassPtr, 100666018);
    }

    public UnitUptimeSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TimeSpace ActiveTimeSpace
    {
      get
      {
        return *(TimeSpace*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_ActiveTimeSpace));
      }
      [param: In] set
      {
        *(TimeSpace*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_ActiveTimeSpace)) = value;
      }
    }

    public unsafe float ActiveHoursDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_ActiveHoursDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_ActiveHoursDuration)) = value;
      }
    }

    public unsafe float ActivePercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_ActivePercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_ActivePercentage)) = value;
      }
    }

    public unsafe float RespawnVariancePercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_RespawnVariancePercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_RespawnVariancePercentage)) = value;
      }
    }

    public unsafe DayTimeSpanSettings AllowedSpawnTimes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_AllowedSpawnTimes));
        return pointer == IntPtr.Zero ? (DayTimeSpanSettings) null : new DayTimeSpanSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr_AllowedSpawnTimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitUptimeSettings.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
