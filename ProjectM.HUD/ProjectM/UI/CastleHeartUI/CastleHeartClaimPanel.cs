// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CastleHeartUI.CastleHeartClaimPanel
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
  public class CastleHeartClaimPanel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ClaimButton;
    private static readonly IntPtr NativeFieldInfoPtr_FreeClaimInfo;
    private static readonly IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimLimitText;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimCost;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleHeartClaimPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartClaimPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartClaimPanel()
    {
      Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI.CastleHeartUI", nameof (CastleHeartClaimPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr);
      CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr, nameof (ClaimButton));
      CastleHeartClaimPanel.NativeFieldInfoPtr_FreeClaimInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr, nameof (FreeClaimInfo));
      CastleHeartClaimPanel.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr, nameof (TooltipAnchor));
      CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimLimitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr, nameof (ClaimLimitText));
      CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr, nameof (ClaimCost));
      CastleHeartClaimPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartClaimPanel>.NativeClassPtr, 100669835);
    }

    public CastleHeartClaimPanel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton ClaimButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform FreeClaimInfo
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_FreeClaimInfo));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_FreeClaimInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipAnchor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ClaimLimitText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimLimitText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimLimitText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CastleHeartShortMenuEntry> ClaimCost
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimCost));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CastleHeartShortMenuEntry>) null : new Il2CppReferenceArray<CastleHeartShortMenuEntry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleHeartClaimPanel.NativeFieldInfoPtr_ClaimCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
