// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ClanMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Views;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_NameInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_NameInputFieldErrorText;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_MottoInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_MottoInputFieldErrorText;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_CreateClanButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoClan_CreateClanButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_CreateClanButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateOrEditClan_CancelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_ClanNameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_ClanMottoText;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_EditMottoParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_EditMottoInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_EditMottoConfirmButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_EditMottoCancelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_MemberEntryParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_LeaveClanButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_EditClanButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_InvitePlayerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_MemberCountText;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_OnlineMembersText;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_LeaveClanPopupPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_InvitePlayerPopupPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_MemberEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_MemberContextMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CreateClan_Confirm;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_EditClan_Confirm;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_CreateClan;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_EditClan;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ClanName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ClanMotto;
    private static readonly System.IntPtr NativeFieldInfoPtr_InClan_MemberEntries;
    private static readonly System.IntPtr NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__37_0_Private_Void_ClanMenu_MemberEntry_Data_0;

    [CallerCount(0)]
    public unsafe bool AnyInputFieldFocused()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClanMenu.NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231824, XrefRangeEnd = 1231839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231839, XrefRangeEnd = 1231840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__37_0(
      ClanMenu_MemberEntry entry,
      ClanMenu_MemberEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__37_0_Private_Void_ClanMenu_MemberEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanMenu()
    {
      Il2CppClassPointerStore<ClanMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr);
      ClanMenu.NativeFieldInfoPtr_Views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (Views));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_NameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_NameInputField));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_NameInputFieldErrorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_NameInputFieldErrorText));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_MottoInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_MottoInputField));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_MottoInputFieldErrorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_MottoInputFieldErrorText));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_HeaderText));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CreateClanButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_CreateClanButtonText));
      ClanMenu.NativeFieldInfoPtr_NoClan_CreateClanButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (NoClan_CreateClanButton));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CreateClanButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_CreateClanButton));
      ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (CreateOrEditClan_CancelButton));
      ClanMenu.NativeFieldInfoPtr_InClan_ClanNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_ClanNameText));
      ClanMenu.NativeFieldInfoPtr_InClan_ClanMottoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_ClanMottoText));
      ClanMenu.NativeFieldInfoPtr_InClan_EditMottoParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_EditMottoParent));
      ClanMenu.NativeFieldInfoPtr_InClan_EditMottoInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_EditMottoInputField));
      ClanMenu.NativeFieldInfoPtr_InClan_EditMottoConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_EditMottoConfirmButton));
      ClanMenu.NativeFieldInfoPtr_InClan_EditMottoCancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_EditMottoCancelButton));
      ClanMenu.NativeFieldInfoPtr_InClan_MemberEntryParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_MemberEntryParent));
      ClanMenu.NativeFieldInfoPtr_InClan_LeaveClanButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_LeaveClanButton));
      ClanMenu.NativeFieldInfoPtr_InClan_EditClanButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_EditClanButton));
      ClanMenu.NativeFieldInfoPtr_InClan_InvitePlayerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_InvitePlayerButton));
      ClanMenu.NativeFieldInfoPtr_InClan_MemberCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_MemberCountText));
      ClanMenu.NativeFieldInfoPtr_InClan_OnlineMembersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_OnlineMembersText));
      ClanMenu.NativeFieldInfoPtr_InClan_LeaveClanPopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_LeaveClanPopupPrefab));
      ClanMenu.NativeFieldInfoPtr_InClan_InvitePlayerPopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_InvitePlayerPopupPrefab));
      ClanMenu.NativeFieldInfoPtr_InClan_MemberEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_MemberEntryPrefab));
      ClanMenu.NativeFieldInfoPtr_MemberContextMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (MemberContextMenu));
      ClanMenu.NativeFieldInfoPtr_LKey_CreateClan_Confirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (LKey_CreateClan_Confirm));
      ClanMenu.NativeFieldInfoPtr_LKey_EditClan_Confirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (LKey_EditClan_Confirm));
      ClanMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (LKey_InvalidInput_AllSpaces));
      ClanMenu.NativeFieldInfoPtr_LKey_CreateClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (LKey_CreateClan));
      ClanMenu.NativeFieldInfoPtr_LKey_EditClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (LKey_EditClan));
      ClanMenu.NativeFieldInfoPtr_LKey_ClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (LKey_ClanName));
      ClanMenu.NativeFieldInfoPtr_LKey_ClanMotto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (LKey_ClanMotto));
      ClanMenu.NativeFieldInfoPtr_InClan_MemberEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (InClan_MemberEntries));
      ClanMenu.NativeMethodInfoPtr_AnyInputFieldFocused_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, 100665401);
      ClanMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, 100665402);
      ClanMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, 100665403);
      ClanMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__37_0_Private_Void_ClanMenu_MemberEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, 100665404);
    }

    public ClanMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<ClanMenu.StateToView> Views
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_Views));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ClanMenu.StateToView>) null : new Il2CppReferenceArray<ClanMenu.StateToView>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_Views), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField CreateOrEditClan_NameInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_NameInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_NameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CreateOrEditClan_NameInputFieldErrorText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_NameInputFieldErrorText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_NameInputFieldErrorText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField CreateOrEditClan_MottoInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_MottoInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_MottoInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CreateOrEditClan_MottoInputFieldErrorText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_MottoInputFieldErrorText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_MottoInputFieldErrorText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CreateOrEditClan_HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CreateOrEditClan_CreateClanButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CreateClanButtonText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CreateClanButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton NoClan_CreateClanButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_NoClan_CreateClanButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_NoClan_CreateClanButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CreateOrEditClan_CreateClanButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CreateClanButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CreateClanButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CreateOrEditClan_CancelButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CancelButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_CreateOrEditClan_CancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InClan_ClanNameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_ClanNameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_ClanNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InClan_ClanMottoText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_ClanMottoText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_ClanMottoText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject InClan_EditMottoParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField InClan_EditMottoInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InClan_EditMottoConfirmButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoConfirmButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoConfirmButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InClan_EditMottoCancelButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoCancelButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditMottoCancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup InClan_MemberEntryParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberEntryParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberEntryParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InClan_LeaveClanButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_LeaveClanButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_LeaveClanButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InClan_EditClanButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditClanButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_EditClanButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InClan_InvitePlayerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_InvitePlayerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_InvitePlayerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InClan_MemberCountText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberCountText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberCountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText InClan_OnlineMembersText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_OnlineMembersText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_OnlineMembersText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClanMenu_LeaveClanPopup InClan_LeaveClanPopupPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_LeaveClanPopupPrefab));
        return pointer == System.IntPtr.Zero ? (ClanMenu_LeaveClanPopup) null : new ClanMenu_LeaveClanPopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_LeaveClanPopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClanMenu_InvitePlayerPopup InClan_InvitePlayerPopupPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_InvitePlayerPopupPrefab));
        return pointer == System.IntPtr.Zero ? (ClanMenu_InvitePlayerPopup) null : new ClanMenu_InvitePlayerPopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_InvitePlayerPopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClanMenu_MemberEntry InClan_MemberEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ClanMenu_MemberEntry) null : new ClanMenu_MemberEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ClanMenu.MemberContextMenuData MemberContextMenu
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_MemberContextMenu);
        return new ClanMenu.MemberContextMenuData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_MemberContextMenu), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey LKey_CreateClan_Confirm
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_CreateClan_Confirm));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_CreateClan_Confirm)) = value;
      }
    }

    public unsafe LocalizationKey LKey_EditClan_Confirm
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_EditClan_Confirm));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_EditClan_Confirm)) = value;
      }
    }

    public unsafe LocalizationKey LKey_InvalidInput_AllSpaces
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_InvalidInput_AllSpaces)) = value;
      }
    }

    public unsafe LocalizationKey LKey_CreateClan
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_CreateClan));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_CreateClan)) = value;
      }
    }

    public unsafe LocalizationKey LKey_EditClan
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_EditClan));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_EditClan)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ClanName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_ClanName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_ClanName)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ClanMotto
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_ClanMotto));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_LKey_ClanMotto)) = value;
      }
    }

    public unsafe GridSelectionGroup<ClanMenu_MemberEntry, ClanMenu_MemberEntry.Data> InClan_MemberEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberEntries));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<ClanMenu_MemberEntry, ClanMenu_MemberEntry.Data>) null : new GridSelectionGroup<ClanMenu_MemberEntry, ClanMenu_MemberEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.NativeFieldInfoPtr_InClan_MemberEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class StateToView : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_State;
      private static readonly System.IntPtr NativeFieldInfoPtr_View;

      static StateToView()
      {
        Il2CppClassPointerStore<ClanMenu.StateToView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (StateToView));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMenu.StateToView>.NativeClassPtr);
        ClanMenu.StateToView.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.StateToView>.NativeClassPtr, nameof (State));
        ClanMenu.StateToView.NativeFieldInfoPtr_View = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.StateToView>.NativeClassPtr, nameof (View));
      }

      public StateToView(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public StateToView()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClanMenu.StateToView>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanMenu.StateToView>.NativeClassPtr, data));
      }

      public unsafe ClanMenuState State
      {
        get
        {
          return *(ClanMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.StateToView.NativeFieldInfoPtr_State));
        }
        [param: In] set
        {
          *(ClanMenuState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.StateToView.NativeFieldInfoPtr_State)) = value;
        }
      }

      public unsafe GameObject View
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.StateToView.NativeFieldInfoPtr_View));
          return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.StateToView.NativeFieldInfoPtr_View), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [Serializable]
    public sealed class MemberContextMenuData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntryPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntryParent;
      private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PrivateMessage;
      private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PromoteToLeader;
      private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PromoteToOfficer;
      private static readonly System.IntPtr NativeFieldInfoPtr_LKey_DemoteToMember;
      private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Kick;

      static MemberContextMenuData()
      {
        Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanMenu>.NativeClassPtr, nameof (MemberContextMenuData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr);
        ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, nameof (EntryPrefab));
        ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_EntryParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, nameof (EntryParent));
        ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PrivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, nameof (LKey_PrivateMessage));
        ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PromoteToLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, nameof (LKey_PromoteToLeader));
        ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PromoteToOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, nameof (LKey_PromoteToOfficer));
        ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_DemoteToMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, nameof (LKey_DemoteToMember));
        ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_Kick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, nameof (LKey_Kick));
      }

      public MemberContextMenuData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public MemberContextMenuData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanMenu.MemberContextMenuData>.NativeClassPtr, data));
      }

      public unsafe ClanMenu_MemberContextMenuEntry EntryPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_EntryPrefab));
          return pointer == System.IntPtr.Zero ? (ClanMenu_MemberContextMenuEntry) null : new ClanMenu_MemberContextMenuEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ClanMenu_MemberContextMenu EntryParent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_EntryParent));
          return pointer == System.IntPtr.Zero ? (ClanMenu_MemberContextMenu) null : new ClanMenu_MemberContextMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_EntryParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe LocalizationKey LKey_PrivateMessage
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PrivateMessage));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PrivateMessage)) = value;
        }
      }

      public unsafe LocalizationKey LKey_PromoteToLeader
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PromoteToLeader));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PromoteToLeader)) = value;
        }
      }

      public unsafe LocalizationKey LKey_PromoteToOfficer
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PromoteToOfficer));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_PromoteToOfficer)) = value;
        }
      }

      public unsafe LocalizationKey LKey_DemoteToMember
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_DemoteToMember));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_DemoteToMember)) = value;
        }
      }

      public unsafe LocalizationKey LKey_Kick
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_Kick));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu.MemberContextMenuData.NativeFieldInfoPtr_LKey_Kick)) = value;
        }
      }
    }
  }
}
