// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ClanParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ClanPlayerParent;
    private static readonly IntPtr NativeFieldInfoPtr_ClanInvitedEntry;
    private static readonly IntPtr NativeFieldInfoPtr_ClanBackground;
    private static readonly IntPtr NativeFieldInfoPtr_Motions;
    private static readonly IntPtr NativeFieldInfoPtr_ClanPlayerEntries;
    private static readonly IntPtr NativeFieldInfoPtr_ClanPlayerEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ClanInvitePlayerEntry;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanParent()
    {
      Il2CppClassPointerStore<ClanParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanParent>.NativeClassPtr);
      ClanParent.NativeFieldInfoPtr_ClanPlayerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, nameof (ClanPlayerParent));
      ClanParent.NativeFieldInfoPtr_ClanInvitedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, nameof (ClanInvitedEntry));
      ClanParent.NativeFieldInfoPtr_ClanBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, nameof (ClanBackground));
      ClanParent.NativeFieldInfoPtr_Motions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, nameof (Motions));
      ClanParent.NativeFieldInfoPtr_ClanPlayerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, nameof (ClanPlayerEntries));
      ClanParent.NativeFieldInfoPtr_ClanPlayerEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, nameof (ClanPlayerEntryPrefab));
      ClanParent.NativeFieldInfoPtr_ClanInvitePlayerEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, nameof (ClanInvitePlayerEntry));
      ClanParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanParent>.NativeClassPtr, 100664660);
    }

    public ClanParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GridLayoutGroup ClanPlayerParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanPlayerParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanPlayerParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClanInvitedEntry ClanInvitedEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanInvitedEntry));
        return pointer == IntPtr.Zero ? (ClanInvitedEntry) null : new ClanInvitedEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanInvitedEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionEntry ClanBackground
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanBackground));
        return pointer == IntPtr.Zero ? (GridSelectionEntry) null : new GridSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanBackground), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_Motions));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_Motions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ClanPlayerEntry, ClanPlayerEntry.Data> ClanPlayerEntries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanPlayerEntries));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<ClanPlayerEntry, ClanPlayerEntry.Data>) null : new GridSelectionGroup<ClanPlayerEntry, ClanPlayerEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanPlayerEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClanPlayerEntry ClanPlayerEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanPlayerEntryPrefab));
        return pointer == IntPtr.Zero ? (ClanPlayerEntry) null : new ClanPlayerEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanPlayerEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClanInvitePlayerEntry ClanInvitePlayerEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanInvitePlayerEntry));
        return pointer == IntPtr.Zero ? (ClanInvitePlayerEntry) null : new ClanInvitePlayerEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanParent.NativeFieldInfoPtr_ClanInvitePlayerEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
