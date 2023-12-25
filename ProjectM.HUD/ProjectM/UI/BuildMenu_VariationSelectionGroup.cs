// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu_VariationSelectionGroup
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
  public class BuildMenu_VariationSelectionGroup : 
    GenericSelectionGroup<BuildMenu_VariationEntry, BuildMenu_VariationEntry.Data>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228037, XrefRangeEnd = 1228040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenu_VariationSelectionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu_VariationSelectionGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_VariationSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenu_VariationSelectionGroup()
    {
      Il2CppClassPointerStore<BuildMenu_VariationSelectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenu_VariationSelectionGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_VariationSelectionGroup>.NativeClassPtr);
      BuildMenu_VariationSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_VariationSelectionGroup>.NativeClassPtr, 100665129);
    }

    public BuildMenu_VariationSelectionGroup(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
