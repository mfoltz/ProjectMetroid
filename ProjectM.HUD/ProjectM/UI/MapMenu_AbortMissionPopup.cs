﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapMenu_AbortMissionPopup
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.UI
{
  public class MapMenu_AbortMissionPopup : GenericPopup
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapMenu_AbortMissionPopup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMenu_AbortMissionPopup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMenu_AbortMissionPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapMenu_AbortMissionPopup()
    {
      Il2CppClassPointerStore<MapMenu_AbortMissionPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapMenu_AbortMissionPopup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMenu_AbortMissionPopup>.NativeClassPtr);
      MapMenu_AbortMissionPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMenu_AbortMissionPopup>.NativeClassPtr, 100667951);
    }

    public MapMenu_AbortMissionPopup(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
