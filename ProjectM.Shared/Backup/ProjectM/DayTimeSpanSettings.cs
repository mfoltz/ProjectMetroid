// Decompiled with JetBrains decompiler
// Type: ProjectM.DayTimeSpanSettings
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
  public class DayTimeSpanSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Days;
    private static readonly IntPtr NativeFieldInfoPtr_StartMonth;
    private static readonly IntPtr NativeFieldInfoPtr_EndMonth;
    private static readonly IntPtr NativeFieldInfoPtr_StartHour;
    private static readonly IntPtr NativeFieldInfoPtr_StartMinute;
    private static readonly IntPtr NativeFieldInfoPtr_EndHour;
    private static readonly IntPtr NativeFieldInfoPtr_EndMinute;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_DayTimeSpan_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 748888, RefRangeEnd = 748893, XrefRangeStart = 748887, XrefRangeEnd = 748888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayTimeSpanSettings.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 748893, RefRangeEnd = 748896, XrefRangeStart = 748893, XrefRangeEnd = 748893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DayTimeSpan Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayTimeSpanSettings.NativeMethodInfoPtr_Convert_Public_DayTimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DayTimeSpan*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748896, XrefRangeEnd = 748918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayTimeSpanSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748918, XrefRangeEnd = 748919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DayTimeSpanSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayTimeSpanSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DayTimeSpanSettings()
    {
      Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DayTimeSpanSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr);
      DayTimeSpanSettings.NativeFieldInfoPtr_Days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (Days));
      DayTimeSpanSettings.NativeFieldInfoPtr_StartMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (StartMonth));
      DayTimeSpanSettings.NativeFieldInfoPtr_EndMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (EndMonth));
      DayTimeSpanSettings.NativeFieldInfoPtr_StartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (StartHour));
      DayTimeSpanSettings.NativeFieldInfoPtr_StartMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (StartMinute));
      DayTimeSpanSettings.NativeFieldInfoPtr_EndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (EndHour));
      DayTimeSpanSettings.NativeFieldInfoPtr_EndMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (EndMinute));
      DayTimeSpanSettings.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, nameof (_Guid));
      DayTimeSpanSettings.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, 100665933);
      DayTimeSpanSettings.NativeMethodInfoPtr_Convert_Public_DayTimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, 100665934);
      DayTimeSpanSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, 100665935);
      DayTimeSpanSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpanSettings>.NativeClassPtr, 100665936);
    }

    public DayTimeSpanSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TimeSpanWeekDayFlag Days
    {
      get
      {
        return *(TimeSpanWeekDayFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_Days));
      }
      [param: In] set
      {
        *(TimeSpanWeekDayFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_Days)) = value;
      }
    }

    public unsafe int StartMonth
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_StartMonth));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_StartMonth)) = value;
      }
    }

    public unsafe int EndMonth
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_EndMonth));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_EndMonth)) = value;
      }
    }

    public unsafe int StartHour
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_StartHour));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_StartHour)) = value;
      }
    }

    public unsafe int StartMinute
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_StartMinute));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_StartMinute)) = value;
      }
    }

    public unsafe int EndHour
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_EndHour));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_EndHour)) = value;
      }
    }

    public unsafe int EndMinute
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_EndMinute));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr_EndMinute)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DayTimeSpanSettings.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
