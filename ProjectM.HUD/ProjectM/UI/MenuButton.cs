// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MenuButton
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class MenuButton : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LocalizationKey;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedGameObjects;
    private static readonly IntPtr NativeFieldInfoPtr_StunButton;
    private static readonly IntPtr NativeFieldInfoPtr_ButtonText;
    private static readonly IntPtr NativeFieldInfoPtr_DividerImage;
    private static readonly IntPtr NativeFieldInfoPtr_InAnimation;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedAnimation;
    private static readonly IntPtr NativeFieldInfoPtr__Interactable;
    private static readonly IntPtr NativeFieldInfoPtr__ForceHilight;
    private static readonly IntPtr NativeFieldInfoPtr__RectTransform;
    private static readonly IntPtr NativeFieldInfoPtr__Selected;
    private static readonly IntPtr NativeFieldInfoPtr__FontStandard;
    private static readonly IntPtr NativeFieldInfoPtr__FontHover;
    private static readonly IntPtr NativeFieldInfoPtr__EntryType;
    private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ForceHilight_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_ButtonClickedEvent_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_UnityAction_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MenuButtonData_0;
    private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool Interactable
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool ForceHilight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_get_ForceHilight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279161, XrefRangeEnd = 1279165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Initialize(
      LocalizationKey localizationKey,
      Button.ButtonClickedEvent onClick,
      bool interactable,
      bool forceHilight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &localizationKey;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClick);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &interactable;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &forceHilight;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_ButtonClickedEvent_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279165, XrefRangeEnd = 1279166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(string text, UnityAction onClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClick);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_Initialize_Public_Void_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279172, RefRangeEnd = 1279173, XrefRangeStart = 1279166, XrefRangeEnd = 1279172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(MenuButtonData menuButton)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menuButton);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_Initialize_Public_Void_MenuButtonData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279173, XrefRangeEnd = 1279174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Select()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279174, XrefRangeEnd = 1279176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnDeselect(BaseEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279176, XrefRangeEnd = 1279177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279177, XrefRangeEnd = 1279179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnSelect(BaseEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279179, XrefRangeEnd = 1279184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MenuButton()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuButton>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MenuButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MenuButton()
    {
      Il2CppClassPointerStore<MenuButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MenuButton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuButton>.NativeClassPtr);
      MenuButton.NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (LocalizationKey));
      MenuButton.NativeFieldInfoPtr_SelectedGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (SelectedGameObjects));
      MenuButton.NativeFieldInfoPtr_StunButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (StunButton));
      MenuButton.NativeFieldInfoPtr_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (ButtonText));
      MenuButton.NativeFieldInfoPtr_DividerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (DividerImage));
      MenuButton.NativeFieldInfoPtr_InAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (InAnimation));
      MenuButton.NativeFieldInfoPtr_SelectedAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (SelectedAnimation));
      MenuButton.NativeFieldInfoPtr__Interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (_Interactable));
      MenuButton.NativeFieldInfoPtr__ForceHilight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (_ForceHilight));
      MenuButton.NativeFieldInfoPtr__RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (_RectTransform));
      MenuButton.NativeFieldInfoPtr__Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (_Selected));
      MenuButton.NativeFieldInfoPtr__FontStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (_FontStandard));
      MenuButton.NativeFieldInfoPtr__FontHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (_FontHover));
      MenuButton.NativeFieldInfoPtr__EntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, nameof (_EntryType));
      MenuButton.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668870);
      MenuButton.NativeMethodInfoPtr_get_ForceHilight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668871);
      MenuButton.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668872);
      MenuButton.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_ButtonClickedEvent_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668873);
      MenuButton.NativeMethodInfoPtr_Initialize_Public_Void_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668874);
      MenuButton.NativeMethodInfoPtr_Initialize_Public_Void_MenuButtonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668875);
      MenuButton.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668876);
      MenuButton.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668877);
      MenuButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668878);
      MenuButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668879);
      MenuButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668880);
      MenuButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668881);
      MenuButton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668882);
      MenuButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuButton>.NativeClassPtr, 100668883);
    }

    public MenuButton(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey LocalizationKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_LocalizationKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_LocalizationKey)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> SelectedGameObjects
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_SelectedGameObjects));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_SelectedGameObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton StunButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_StunButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_StunButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI ButtonText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_ButtonText));
        return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_ButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image DividerImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_DividerImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_DividerImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding InAnimation
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_InAnimation));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_InAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding SelectedAnimation
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_SelectedAnimation));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr_SelectedAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Interactable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__Interactable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__Interactable)) = value;
      }
    }

    public unsafe bool _ForceHilight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__ForceHilight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__ForceHilight)) = value;
      }
    }

    public unsafe RectTransform _RectTransform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__RectTransform));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__RectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Selected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__Selected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__Selected)) = value;
      }
    }

    public unsafe TMP_FontAsset _FontStandard
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__FontStandard));
        return pointer == IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__FontStandard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset _FontHover
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__FontHover));
        return pointer == IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__FontHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MenuEntryType _EntryType
    {
      get
      {
        return *(MenuEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__EntryType));
      }
      [param: In] set
      {
        *(MenuEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MenuButton.NativeFieldInfoPtr__EntryType)) = value;
      }
    }
  }
}
