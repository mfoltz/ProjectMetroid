// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LinkClickedEvent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class LinkClickedEvent : UnityEvent<string>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287975, RefRangeEnd = 1287976, XrefRangeStart = 1287972, XrefRangeEnd = 1287975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinkClickedEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkClickedEvent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinkClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinkClickedEvent()
    {
      Il2CppClassPointerStore<LinkClickedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (LinkClickedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkClickedEvent>.NativeClassPtr);
      LinkClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkClickedEvent>.NativeClassPtr, 100669609);
    }

    public LinkClickedEvent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
