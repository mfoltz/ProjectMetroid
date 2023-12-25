// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellbookMenu_JewelSelectionGroup
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
  public class SpellbookMenu_JewelSelectionGroup : 
    GenericSelectionGroup<SpellbookMenu_JewelEntry, SpellbookMenu_JewelEntry.Data>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263348, XrefRangeEnd = 1263351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenu_JewelSelectionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenu_JewelSelectionGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellbookMenu_JewelSelectionGroup()
    {
      Il2CppClassPointerStore<SpellbookMenu_JewelSelectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellbookMenu_JewelSelectionGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_JewelSelectionGroup>.NativeClassPtr);
      SpellbookMenu_JewelSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelSelectionGroup>.NativeClassPtr, 100667449);
    }

    public SpellbookMenu_JewelSelectionGroup(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
