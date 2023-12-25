// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ActionBarParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class ActionBarParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Entries;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActionBarParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionBarParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionBarParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ActionBarParent()
    {
      Il2CppClassPointerStore<ActionBarParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ActionBarParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionBarParent>.NativeClassPtr);
      ActionBarParent.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionBarParent>.NativeClassPtr, nameof (Entries));
      ActionBarParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionBarParent>.NativeClassPtr, 100664102);
    }

    public ActionBarParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ActionBarEntry> Entries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionBarParent.NativeFieldInfoPtr_Entries));
        return pointer == IntPtr.Zero ? (List<ActionBarEntry>) null : new List<ActionBarEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionBarParent.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
