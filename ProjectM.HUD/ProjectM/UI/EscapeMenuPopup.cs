// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.EscapeMenuPopup
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class EscapeMenuPopup : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Button1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button2;
    private static readonly System.IntPtr NativeFieldInfoPtr_PopupText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button1Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button2Text;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnButton1Click;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnButton2Click;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Button1_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Button2_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OpenPopup_Public_Void_LocalizationKey_LocalizationKey_LocalizationKey_Action_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277761, XrefRangeEnd = 1277777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuPopup.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277777, XrefRangeEnd = 1277780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Button1_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuPopup.NativeMethodInfoPtr_Button1_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277780, XrefRangeEnd = 1277783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Button2_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuPopup.NativeMethodInfoPtr_Button2_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277783, XrefRangeEnd = 1277795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OpenPopup(
      LocalizationKey popupTextKey,
      LocalizationKey button1TextKey,
      LocalizationKey button2TextKey,
      Il2CppSystem.Action onButton1Click,
      Il2CppSystem.Action onButton2Click)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &popupTextKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &button1TextKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &button2TextKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onButton1Click);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onButton2Click);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuPopup.NativeMethodInfoPtr_OpenPopup_Public_Void_LocalizationKey_LocalizationKey_LocalizationKey_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1222138, RefRangeEnd = 1222167, XrefRangeStart = 1222138, XrefRangeEnd = 1222167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Close()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuPopup.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EscapeMenuPopup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EscapeMenuPopup()
    {
      Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (EscapeMenuPopup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr);
      EscapeMenuPopup.NativeFieldInfoPtr_Button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, nameof (Button1));
      EscapeMenuPopup.NativeFieldInfoPtr_Button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, nameof (Button2));
      EscapeMenuPopup.NativeFieldInfoPtr_PopupText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, nameof (PopupText));
      EscapeMenuPopup.NativeFieldInfoPtr_Button1Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, nameof (Button1Text));
      EscapeMenuPopup.NativeFieldInfoPtr_Button2Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, nameof (Button2Text));
      EscapeMenuPopup.NativeFieldInfoPtr__OnButton1Click = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, nameof (_OnButton1Click));
      EscapeMenuPopup.NativeFieldInfoPtr__OnButton2Click = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, nameof (_OnButton2Click));
      EscapeMenuPopup.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, 100668734);
      EscapeMenuPopup.NativeMethodInfoPtr_Button1_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, 100668735);
      EscapeMenuPopup.NativeMethodInfoPtr_Button2_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, 100668736);
      EscapeMenuPopup.NativeMethodInfoPtr_OpenPopup_Public_Void_LocalizationKey_LocalizationKey_LocalizationKey_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, 100668737);
      EscapeMenuPopup.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, 100668738);
      EscapeMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuPopup>.NativeClassPtr, 100668739);
    }

    public EscapeMenuPopup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton Button1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button1));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button2));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PopupText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_PopupText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_PopupText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Button1Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button1Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button1Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Button2Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button2Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr_Button2Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action _OnButton1Click
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr__OnButton1Click));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr__OnButton1Click), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action _OnButton2Click
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr__OnButton2Click));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuPopup.NativeFieldInfoPtr__OnButton2Click), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
