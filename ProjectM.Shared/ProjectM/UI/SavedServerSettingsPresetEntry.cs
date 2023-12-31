// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SavedServerSettingsPresetEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SavedServerSettingsPresetEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Background;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimestampText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeleteButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_OfficialButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundSelected;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorHover;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClickSoundType;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverSoundType;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnSelected;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDeleteClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hovered;
    private static readonly System.IntPtr NativeFieldInfoPtr__Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr__FullFilePath;
    private static readonly System.IntPtr NativeFieldInfoPtr__Name;
    private static readonly System.IntPtr NativeFieldInfoPtr__Description;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hash;
    private static readonly System.IntPtr NativeFieldInfoPtr__Type;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_ServerGameSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Hash_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FullFilePath_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_String_ServerGameSettingsTemplate_ServerSettingsPresetType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnClick_DeleteButton_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryDeletePreset_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe ServerGameSettings Settings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Settings_Public_get_ServerGameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
    }

    public unsafe string Hash
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Hash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string Name
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string Description
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string FullFilePath
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_FullFilePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795311, XrefRangeEnd = 795321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795321, XrefRangeEnd = 795329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795329, XrefRangeEnd = 795340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 795367, RefRangeEnd = 795369, XrefRangeStart = 795340, XrefRangeEnd = 795367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init(
      string fullFilePath,
      ServerGameSettingsTemplate template,
      ServerSettingsPresetType presetType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fullFilePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) template);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &presetType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_Init_Public_Void_String_ServerGameSettingsTemplate_ServerSettingsPresetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795369, XrefRangeEnd = 795372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnClick_DeleteButton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnClick_DeleteButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795372, XrefRangeEnd = 795377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryDeletePreset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_TryDeletePreset_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795377, RefRangeEnd = 795378, XrefRangeStart = 795377, XrefRangeEnd = 795377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Deselect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr_Deselect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SavedServerSettingsPresetEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SavedServerSettingsPresetEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SavedServerSettingsPresetEntry()
    {
      Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (SavedServerSettingsPresetEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr);
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (Background));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (NameText));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_TimestampText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (TimestampText));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_DeleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (DeleteButton));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OfficialButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (OfficialButton));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_BackgroundNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (BackgroundNormal));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_BackgroundSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (BackgroundSelected));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ColorNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (ColorNormal));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ColorHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (ColorHover));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_SoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (SoundMapping));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ClickSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (ClickSoundType));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_HoverSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (HoverSoundType));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (OnSelected));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OnDeleteClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (OnDeleteClicked));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_Hovered));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_Selected));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__FullFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_FullFilePath));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_Name));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_Description));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_Settings));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_Hash));
      SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, nameof (_Type));
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Settings_Public_get_ServerGameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670157);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Hash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670158);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670159);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670160);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_get_FullFilePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670161);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670162);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670163);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670164);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670165);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_Init_Public_Void_String_ServerGameSettingsTemplate_ServerSettingsPresetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670166);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_OnClick_DeleteButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670167);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_TryDeletePreset_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670168);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr_Deselect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670169);
      SavedServerSettingsPresetEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedServerSettingsPresetEntry>.NativeClassPtr, 100670170);
    }

    public SavedServerSettingsPresetEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Background
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_Background));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text NameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_NameText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text TimestampText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_TimestampText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_TimestampText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DeleteButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_DeleteButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_DeleteButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton OfficialButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OfficialButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OfficialButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite BackgroundNormal
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_BackgroundNormal));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_BackgroundNormal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite BackgroundSelected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_BackgroundSelected));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_BackgroundSelected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color ColorNormal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ColorNormal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ColorNormal)) = value;
      }
    }

    public unsafe Color ColorHover
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ColorHover));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ColorHover)) = value;
      }
    }

    public unsafe UISoundMapping SoundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_SoundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_SoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType ClickSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ClickSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_ClickSoundType)) = value;
      }
    }

    public unsafe UISoundType HoverSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_HoverSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_HoverSoundType)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<SavedServerSettingsPresetEntry> OnSelected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OnSelected));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SavedServerSettingsPresetEntry>) null : new Il2CppSystem.Action<SavedServerSettingsPresetEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<SavedServerSettingsPresetEntry> OnDeleteClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OnDeleteClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SavedServerSettingsPresetEntry>) null : new Il2CppSystem.Action<SavedServerSettingsPresetEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr_OnDeleteClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Hovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Hovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Hovered)) = value;
      }
    }

    public unsafe bool _Selected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Selected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Selected)) = value;
      }
    }

    public unsafe string _FullFilePath
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__FullFilePath)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__FullFilePath), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _Description
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Description)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Description), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ServerGameSettings _Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Settings));
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Hash
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Hash)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Hash), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ServerSettingsPresetType _Type
    {
      get
      {
        return *(ServerSettingsPresetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Type));
      }
      [param: In] set
      {
        *(ServerSettingsPresetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SavedServerSettingsPresetEntry.NativeFieldInfoPtr__Type)) = value;
      }
    }
  }
}
