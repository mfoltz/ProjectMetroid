// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodDistanceSettings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class VBloodDistanceSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Entries;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultEmptyKey;
    private static readonly IntPtr NativeMethodInfoPtr_GetDistanceNameKey_Public_LocalizationKey_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1263393, RefRangeEnd = 1263396, XrefRangeStart = 1263391, XrefRangeEnd = 1263393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizationKey GetDistanceNameKey(int distance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &distance;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodDistanceSettings.NativeMethodInfoPtr_GetDistanceNameKey_Public_LocalizationKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodDistanceSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodDistanceSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodDistanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodDistanceSettings()
    {
      Il2CppClassPointerStore<VBloodDistanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodDistanceSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodDistanceSettings>.NativeClassPtr);
      VBloodDistanceSettings.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodDistanceSettings>.NativeClassPtr, nameof (Entries));
      VBloodDistanceSettings.NativeFieldInfoPtr_DefaultEmptyKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodDistanceSettings>.NativeClassPtr, nameof (DefaultEmptyKey));
      VBloodDistanceSettings.NativeMethodInfoPtr_GetDistanceNameKey_Public_LocalizationKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodDistanceSettings>.NativeClassPtr, 100667458);
      VBloodDistanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodDistanceSettings>.NativeClassPtr, 100667459);
    }

    public VBloodDistanceSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<DistanceName> Entries
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodDistanceSettings.NativeFieldInfoPtr_Entries));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<DistanceName>) null : new Il2CppStructArray<DistanceName>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodDistanceSettings.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey DefaultEmptyKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodDistanceSettings.NativeFieldInfoPtr_DefaultEmptyKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodDistanceSettings.NativeFieldInfoPtr_DefaultEmptyKey)) = value;
      }
    }
  }
}
