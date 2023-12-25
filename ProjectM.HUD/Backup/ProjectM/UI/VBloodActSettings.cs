// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodActSettings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class VBloodActSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ActLevelStartingPoints;
    private static readonly IntPtr NativeMethodInfoPtr_GetGearLevelAct_Public_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1263390, RefRangeEnd = 1263391, XrefRangeStart = 1263390, XrefRangeEnd = 1263390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetGearLevelAct(int gearLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &gearLevel;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodActSettings.NativeMethodInfoPtr_GetGearLevelAct_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodActSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodActSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodActSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodActSettings()
    {
      Il2CppClassPointerStore<VBloodActSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodActSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodActSettings>.NativeClassPtr);
      VBloodActSettings.NativeFieldInfoPtr_ActLevelStartingPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodActSettings>.NativeClassPtr, nameof (ActLevelStartingPoints));
      VBloodActSettings.NativeMethodInfoPtr_GetGearLevelAct_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodActSettings>.NativeClassPtr, 100667456);
      VBloodActSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodActSettings>.NativeClassPtr, 100667457);
    }

    public VBloodActSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<int> ActLevelStartingPoints
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodActSettings.NativeFieldInfoPtr_ActLevelStartingPoints));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodActSettings.NativeFieldInfoPtr_ActLevelStartingPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
