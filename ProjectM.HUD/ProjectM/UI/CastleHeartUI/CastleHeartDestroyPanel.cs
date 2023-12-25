// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartDestroyPanel
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI.CastleHeartUI
{
  public class CastleHeartDestroyPanel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DestroyButton;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyFreeInfo;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyCost;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartDestroyPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartDestroyPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartDestroyPanel()
    {
      Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartDestroyPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr);
      CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr, nameof (DestroyButton));
      CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyFreeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr, nameof (DestroyFreeInfo));
      CastleHeartDestroyPanel.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr, nameof (TooltipAnchor));
      CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr, nameof (DestroyCost));
      CastleHeartDestroyPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartDestroyPanel>.NativeClassPtr, 100669836);
    }

    public CastleHeartDestroyPanel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton DestroyButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform DestroyFreeInfo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyFreeInfo));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyFreeInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CastleHeartShortMenuEntry> DestroyCost
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyCost));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CastleHeartShortMenuEntry>) null : new Il2CppReferenceArray<CastleHeartShortMenuEntry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartDestroyPanel.NativeFieldInfoPtr_DestroyCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
