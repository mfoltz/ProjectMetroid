// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Popup_ServerSettingDetails
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class Popup_ServerSettingDetails : SimplePopupBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CancelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingsLocalizationMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadingRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContentRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContentParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpacingEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Cancel_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSpacing_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddValue_Private_Void_String_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEnabledValue_Private_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOnOffValue_Private_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddValue_Private_Void_String_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddValue_Private_Void_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddValue_Private_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286182, XrefRangeEnd = 1286190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 180802, RefRangeEnd = 180804, XrefRangeStart = 180802, XrefRangeEnd = 180804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Cancel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_OnButtonClick_Cancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnShow()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Popup_ServerSettingDetails.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286190, XrefRangeEnd = 1286198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1286638, RefRangeEnd = 1286639, XrefRangeStart = 1286198, XrefRangeEnd = 1286638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286639, XrefRangeEnd = 1286643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSpacing()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddSpacing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1286651, RefRangeEnd = 1286655, XrefRangeStart = 1286643, XrefRangeEnd = 1286651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader(LocalizationKey headerKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &headerKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1286667, RefRangeEnd = 1286675, XrefRangeStart = 1286655, XrefRangeEnd = 1286667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddValue(string identifier, LocalizationKey valueKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1286688, RefRangeEnd = 1286697, XrefRangeStart = 1286675, XrefRangeEnd = 1286688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddEnabledValue(string identifier, bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddEnabledValue_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286697, XrefRangeEnd = 1286710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOnOffValue(string identifier, bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddOnOffValue_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1286729, RefRangeEnd = 1286736, XrefRangeStart = 1286710, XrefRangeEnd = 1286729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddValue(string identifier, int value, int nameValue = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nameValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(37)]
    [CachedScanResults(RefRangeStart = 1286757, RefRangeEnd = 1286794, XrefRangeStart = 1286736, XrefRangeEnd = 1286757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddValue(string identifier, float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1286806, RefRangeEnd = 1286812, XrefRangeStart = 1286794, XrefRangeEnd = 1286806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddValue(string identifier, string value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(identifier);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286812, XrefRangeEnd = 1286822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnClose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Popup_ServerSettingDetails.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Popup_ServerSettingDetails.NativeMethodInfoPtr_HandleInput_Public_Virtual_Void_InputState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Popup_ServerSettingDetails()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_ServerSettingDetails.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Popup_ServerSettingDetails()
    {
      Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (Popup_ServerSettingDetails));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr);
      Popup_ServerSettingDetails.NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (CancelButton));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_SettingsLocalizationMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (SettingsLocalizationMapping));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_LoadingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (LoadingRect));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (ContentRect));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_ContentParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (ContentParent));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_HeaderEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (HeaderEntry));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_SpacingEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (SpacingEntry));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_SettingEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (SettingEntry));
      Popup_ServerSettingDetails.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (Settings));
      Popup_ServerSettingDetails.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, nameof (_Initialized));
      Popup_ServerSettingDetails.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669467);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_OnButtonClick_Cancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669468);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669469);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669470);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669471);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddSpacing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669472);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669473);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669474);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddEnabledValue_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669475);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddOnOffValue_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669476);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669477);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669478);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_AddValue_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669479);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669480);
      Popup_ServerSettingDetails.NativeMethodInfoPtr_HandleInput_Public_Virtual_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669481);
      Popup_ServerSettingDetails.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_ServerSettingDetails>.NativeClassPtr, 100669482);
    }

    public Popup_ServerSettingDetails(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton CancelButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_CancelButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_CancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameBalanceSettingsMapping SettingsLocalizationMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_SettingsLocalizationMapping));
        return pointer == System.IntPtr.Zero ? (GameBalanceSettingsMapping) null : new GameBalanceSettingsMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_SettingsLocalizationMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform LoadingRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_LoadingRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_LoadingRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ContentRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_ContentRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ContentParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_ContentParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_ContentParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_HeaderEntry));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_HeaderEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SpacingEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_SpacingEntry));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_SpacingEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Popup_ServerSettingDetails_SettingEntry SettingEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_SettingEntry));
        return pointer == System.IntPtr.Zero ? (Popup_ServerSettingDetails_SettingEntry) null : new Popup_ServerSettingDetails_SettingEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_SettingEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<ServerGameBalanceSettings> Settings
    {
      get
      {
        return *(Nullable_Unboxed<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_Settings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_ServerSettingDetails.NativeFieldInfoPtr__Initialized)) = value;
      }
    }
  }
}
