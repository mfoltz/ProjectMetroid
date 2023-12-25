// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ScrollingCombatTextParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class ScrollingCombatTextParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ScrollingCombatTextPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ScrollingCombatTextEntriesParent;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScrollingCombatTextParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollingCombatTextParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScrollingCombatTextParent()
    {
      Il2CppClassPointerStore<ScrollingCombatTextParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ScrollingCombatTextParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatTextParent>.NativeClassPtr);
      ScrollingCombatTextParent.NativeFieldInfoPtr_ScrollingCombatTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParent>.NativeClassPtr, nameof (ScrollingCombatTextPrefab));
      ScrollingCombatTextParent.NativeFieldInfoPtr_ScrollingCombatTextEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextParent>.NativeClassPtr, nameof (ScrollingCombatTextEntriesParent));
      ScrollingCombatTextParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextParent>.NativeClassPtr, 100668434);
    }

    public ScrollingCombatTextParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ScrollingCombatTextEntry ScrollingCombatTextPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParent.NativeFieldInfoPtr_ScrollingCombatTextPrefab));
        return pointer == IntPtr.Zero ? (ScrollingCombatTextEntry) null : new ScrollingCombatTextEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParent.NativeFieldInfoPtr_ScrollingCombatTextPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ScrollingCombatTextEntriesParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParent.NativeFieldInfoPtr_ScrollingCombatTextEntriesParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollingCombatTextParent.NativeFieldInfoPtr_ScrollingCombatTextEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
