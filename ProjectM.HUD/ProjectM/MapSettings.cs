// Decompiled with JetBrains decompiler
// Type: ProjectM.MapSettings
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class MapSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_MapIconMappings;
    private static readonly IntPtr NativeMethodInfoPtr_TryGetSettings_Public_Boolean_MapIconType_byref_MapIcon_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211418, XrefRangeEnd = 1211435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSettings(MapIconType type, out MapIcon setting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[2];
      numPtr1[0] = (IntPtr) &type;
      IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr2 = &zero;
      *(IntPtr*) num1 = (IntPtr) numPtr2;
      IntPtr exc;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MapSettings.NativeMethodInfoPtr_TryGetSettings_Public_Boolean_MapIconType_byref_MapIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref MapIcon local = ref setting;
      IntPtr pointer = zero;
      MapIcon mapIcon = pointer == IntPtr.Zero ? (MapIcon) null : new MapIcon(pointer);
      local = mapIcon;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211435, XrefRangeEnd = 1211443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapSettings()
    {
      Il2CppClassPointerStore<MapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (MapSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapSettings>.NativeClassPtr);
      MapSettings.NativeFieldInfoPtr_MapIconMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapSettings>.NativeClassPtr, nameof (MapIconMappings));
      MapSettings.NativeMethodInfoPtr_TryGetSettings_Public_Boolean_MapIconType_byref_MapIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapSettings>.NativeClassPtr, 100663752);
      MapSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapSettings>.NativeClassPtr, 100663753);
    }

    public MapSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<MapIcon> MapIconMappings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapSettings.NativeFieldInfoPtr_MapIconMappings));
        return pointer == IntPtr.Zero ? (List<MapIcon>) null : new List<MapIcon>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapSettings.NativeFieldInfoPtr_MapIconMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
