// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapZoneHelperData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class MapZoneHelperData : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LK_Entering;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Discovered;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapZoneHelperData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneHelperData>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneHelperData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapZoneHelperData()
    {
      Il2CppClassPointerStore<MapZoneHelperData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapZoneHelperData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneHelperData>.NativeClassPtr);
      MapZoneHelperData.NativeFieldInfoPtr_LK_Entering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneHelperData>.NativeClassPtr, nameof (LK_Entering));
      MapZoneHelperData.NativeFieldInfoPtr_LK_Discovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneHelperData>.NativeClassPtr, nameof (LK_Discovered));
      MapZoneHelperData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneHelperData>.NativeClassPtr, 100668036);
    }

    public MapZoneHelperData(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey LK_Entering
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneHelperData.NativeFieldInfoPtr_LK_Entering));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneHelperData.NativeFieldInfoPtr_LK_Entering)) = value;
      }
    }

    public unsafe LocalizationKey LK_Discovered
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneHelperData.NativeFieldInfoPtr_LK_Discovered));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneHelperData.NativeFieldInfoPtr_LK_Discovered)) = value;
      }
    }
  }
}
