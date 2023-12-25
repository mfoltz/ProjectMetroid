// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu_TagSelectionGroup
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
  public class BuildMenu_TagSelectionGroup : 
    GenericSelectionGroup<BuildMenu_TagEntry, BuildMenu_TagEntry.Data>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227874, XrefRangeEnd = 1227877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenu_TagSelectionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu_TagSelectionGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_TagSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenu_TagSelectionGroup()
    {
      Il2CppClassPointerStore<BuildMenu_TagSelectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenu_TagSelectionGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_TagSelectionGroup>.NativeClassPtr);
      BuildMenu_TagSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TagSelectionGroup>.NativeClassPtr, 100665111);
    }

    public BuildMenu_TagSelectionGroup(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
