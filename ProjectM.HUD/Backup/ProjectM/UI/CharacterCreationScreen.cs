// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterCreationScreen
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterCreationScreen : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_GenderImages;
    private static readonly IntPtr NativeFieldInfoPtr_CustomizationSettings;
    private static readonly IntPtr NativeFieldInfoPtr_RandomLocalizationKeys;
    private static readonly IntPtr NativeFieldInfoPtr_RandomMaleNames;
    private static readonly IntPtr NativeFieldInfoPtr_RandomFemaleNames;
    private static readonly IntPtr NativeFieldInfoPtr_FaceLeftButton;
    private static readonly IntPtr NativeFieldInfoPtr_FaceRightButton;
    private static readonly IntPtr NativeFieldInfoPtr_HairLeftButton;
    private static readonly IntPtr NativeFieldInfoPtr_HairRightButton;
    private static readonly IntPtr NativeFieldInfoPtr_FeaturesLeftButton;
    private static readonly IntPtr NativeFieldInfoPtr_FeaturesRightButton;
    private static readonly IntPtr NativeFieldInfoPtr_AccessoriesLeftButton;
    private static readonly IntPtr NativeFieldInfoPtr_AccessoriesRightButton;
    private static readonly IntPtr NativeFieldInfoPtr_RandomizeButton;
    private static readonly IntPtr NativeFieldInfoPtr_CreateButton;
    private static readonly IntPtr NativeFieldInfoPtr_BackButton;
    private static readonly IntPtr NativeFieldInfoPtr_DoneButton;
    private static readonly IntPtr NativeFieldInfoPtr_CancelButton;
    private static readonly IntPtr NativeFieldInfoPtr_BodyTypeLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_SkintoneLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_FaceLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_EyeColorLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_HairLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_HairColorLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_FeaturesLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_AccessiroesLockInToggle;
    private static readonly IntPtr NativeFieldInfoPtr_NameRect;
    private static readonly IntPtr NativeFieldInfoPtr_FaceIndexText;
    private static readonly IntPtr NativeFieldInfoPtr_HairIndexText;
    private static readonly IntPtr NativeFieldInfoPtr_FeatureIndexText;
    private static readonly IntPtr NativeFieldInfoPtr_AccessoryIndexText;
    private static readonly IntPtr NativeFieldInfoPtr_NameInputField;
    private static readonly IntPtr NativeFieldInfoPtr_NameResultText;
    private static readonly IntPtr NativeFieldInfoPtr_RandomNameButton;
    private static readonly IntPtr NativeFieldInfoPtr_GenderEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ColorEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_NewColorEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_GenderEntriesParent;
    private static readonly IntPtr NativeFieldInfoPtr_SkintoneColorEntriesParent;
    private static readonly IntPtr NativeFieldInfoPtr_EyeColorEntriesParent;
    private static readonly IntPtr NativeFieldInfoPtr_HairColorEntriesParent;
    private static readonly IntPtr NativeFieldInfoPtr_DragSpin;
    private static readonly IntPtr NativeFieldInfoPtr__ResponsePopup;
    private static readonly IntPtr NativeFieldInfoPtr_ResponseText;
    private static readonly IntPtr NativeFieldInfoPtr_ResponseOkButton;
    private static readonly IntPtr NativeFieldInfoPtr_ValueKey;
    private static readonly IntPtr NativeFieldInfoPtr_LK_NameInvalid;
    private static readonly IntPtr NativeFieldInfoPtr_LK_NameTaken;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Unknown;
    private static readonly IntPtr NativeFieldInfoPtr_LK_DoneButton_Create;
    private static readonly IntPtr NativeFieldInfoPtr_LK_DoneButton_Modify;
    private static readonly IntPtr NativeFieldInfoPtr_GenderImageSelectionGroup;
    private static readonly IntPtr NativeFieldInfoPtr_SkintoneColorSelectionGroup;
    private static readonly IntPtr NativeFieldInfoPtr_EyeColorSelectionGroup;
    private static readonly IntPtr NativeFieldInfoPtr_HairColorSelectionGroup;
    private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowResponse_Public_Void_CreateCharacterFailureReason_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShowResponse_Public_Void_RegisterCharacterNameResult_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__55_0_Private_Void_ImageGridSelectionEntry_Data_0;
    private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__55_1_Private_Void_ColorGridSelectionEntry_Data_0;
    private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__55_2_Private_Void_ColorGridSelectionEntry_Data_0;
    private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__55_3_Private_Void_ColorGridSelectionEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231554, XrefRangeEnd = 1231653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231653, XrefRangeEnd = 1231663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231663, XrefRangeEnd = 1231670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowResponse(CreateCharacterFailureReason failureReason)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &failureReason;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr_ShowResponse_Public_Void_CreateCharacterFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231670, XrefRangeEnd = 1231677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowResponse(RegisterCharacterNameResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &result;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr_ShowResponse_Public_Void_RegisterCharacterNameResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterCreationScreen()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231677, XrefRangeEnd = 1231679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__55_0(
      ImageGridSelectionEntry entry,
      ImageGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_0_Private_Void_ImageGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231679, XrefRangeEnd = 1231681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__55_1(
      ColorGridSelectionEntry entry,
      ColorGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &data;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_1_Private_Void_ColorGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231681, XrefRangeEnd = 1231683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__55_2(
      ColorGridSelectionEntry entry,
      ColorGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &data;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_2_Private_Void_ColorGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231683, XrefRangeEnd = 1231685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _InitializeUI_b__55_3(
      ColorGridSelectionEntry entry,
      ColorGridSelectionEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &data;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_3_Private_Void_ColorGridSelectionEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterCreationScreen()
    {
      Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterCreationScreen));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr);
      CharacterCreationScreen.NativeFieldInfoPtr_GenderImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (GenderImages));
      CharacterCreationScreen.NativeFieldInfoPtr_CustomizationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (CustomizationSettings));
      CharacterCreationScreen.NativeFieldInfoPtr_RandomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (RandomLocalizationKeys));
      CharacterCreationScreen.NativeFieldInfoPtr_RandomMaleNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (RandomMaleNames));
      CharacterCreationScreen.NativeFieldInfoPtr_RandomFemaleNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (RandomFemaleNames));
      CharacterCreationScreen.NativeFieldInfoPtr_FaceLeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FaceLeftButton));
      CharacterCreationScreen.NativeFieldInfoPtr_FaceRightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FaceRightButton));
      CharacterCreationScreen.NativeFieldInfoPtr_HairLeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (HairLeftButton));
      CharacterCreationScreen.NativeFieldInfoPtr_HairRightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (HairRightButton));
      CharacterCreationScreen.NativeFieldInfoPtr_FeaturesLeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FeaturesLeftButton));
      CharacterCreationScreen.NativeFieldInfoPtr_FeaturesRightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FeaturesRightButton));
      CharacterCreationScreen.NativeFieldInfoPtr_AccessoriesLeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (AccessoriesLeftButton));
      CharacterCreationScreen.NativeFieldInfoPtr_AccessoriesRightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (AccessoriesRightButton));
      CharacterCreationScreen.NativeFieldInfoPtr_RandomizeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (RandomizeButton));
      CharacterCreationScreen.NativeFieldInfoPtr_CreateButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (CreateButton));
      CharacterCreationScreen.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (BackButton));
      CharacterCreationScreen.NativeFieldInfoPtr_DoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (DoneButton));
      CharacterCreationScreen.NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (CancelButton));
      CharacterCreationScreen.NativeFieldInfoPtr_BodyTypeLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (BodyTypeLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_SkintoneLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (SkintoneLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_FaceLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FaceLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_EyeColorLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (EyeColorLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_HairLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (HairLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_HairColorLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (HairColorLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_FeaturesLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FeaturesLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_AccessiroesLockInToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (AccessiroesLockInToggle));
      CharacterCreationScreen.NativeFieldInfoPtr_NameRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (NameRect));
      CharacterCreationScreen.NativeFieldInfoPtr_FaceIndexText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FaceIndexText));
      CharacterCreationScreen.NativeFieldInfoPtr_HairIndexText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (HairIndexText));
      CharacterCreationScreen.NativeFieldInfoPtr_FeatureIndexText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (FeatureIndexText));
      CharacterCreationScreen.NativeFieldInfoPtr_AccessoryIndexText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (AccessoryIndexText));
      CharacterCreationScreen.NativeFieldInfoPtr_NameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (NameInputField));
      CharacterCreationScreen.NativeFieldInfoPtr_NameResultText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (NameResultText));
      CharacterCreationScreen.NativeFieldInfoPtr_RandomNameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (RandomNameButton));
      CharacterCreationScreen.NativeFieldInfoPtr_GenderEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (GenderEntryPrefab));
      CharacterCreationScreen.NativeFieldInfoPtr_ColorEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (ColorEntryPrefab));
      CharacterCreationScreen.NativeFieldInfoPtr_NewColorEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (NewColorEntryPrefab));
      CharacterCreationScreen.NativeFieldInfoPtr_GenderEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (GenderEntriesParent));
      CharacterCreationScreen.NativeFieldInfoPtr_SkintoneColorEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (SkintoneColorEntriesParent));
      CharacterCreationScreen.NativeFieldInfoPtr_EyeColorEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (EyeColorEntriesParent));
      CharacterCreationScreen.NativeFieldInfoPtr_HairColorEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (HairColorEntriesParent));
      CharacterCreationScreen.NativeFieldInfoPtr_DragSpin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (DragSpin));
      CharacterCreationScreen.NativeFieldInfoPtr__ResponsePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (_ResponsePopup));
      CharacterCreationScreen.NativeFieldInfoPtr_ResponseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (ResponseText));
      CharacterCreationScreen.NativeFieldInfoPtr_ResponseOkButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (ResponseOkButton));
      CharacterCreationScreen.NativeFieldInfoPtr_ValueKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (ValueKey));
      CharacterCreationScreen.NativeFieldInfoPtr_LK_NameInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (LK_NameInvalid));
      CharacterCreationScreen.NativeFieldInfoPtr_LK_NameTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (LK_NameTaken));
      CharacterCreationScreen.NativeFieldInfoPtr_LK_Unknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (LK_Unknown));
      CharacterCreationScreen.NativeFieldInfoPtr_LK_DoneButton_Create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (LK_DoneButton_Create));
      CharacterCreationScreen.NativeFieldInfoPtr_LK_DoneButton_Modify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (LK_DoneButton_Modify));
      CharacterCreationScreen.NativeFieldInfoPtr_GenderImageSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (GenderImageSelectionGroup));
      CharacterCreationScreen.NativeFieldInfoPtr_SkintoneColorSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (SkintoneColorSelectionGroup));
      CharacterCreationScreen.NativeFieldInfoPtr_EyeColorSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (EyeColorSelectionGroup));
      CharacterCreationScreen.NativeFieldInfoPtr_HairColorSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, nameof (HairColorSelectionGroup));
      CharacterCreationScreen.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665376);
      CharacterCreationScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665377);
      CharacterCreationScreen.NativeMethodInfoPtr_ShowResponse_Public_Void_CreateCharacterFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665378);
      CharacterCreationScreen.NativeMethodInfoPtr_ShowResponse_Public_Void_RegisterCharacterNameResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665379);
      CharacterCreationScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665380);
      CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_0_Private_Void_ImageGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665381);
      CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_1_Private_Void_ColorGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665382);
      CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_2_Private_Void_ColorGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665383);
      CharacterCreationScreen.NativeMethodInfoPtr__InitializeUI_b__55_3_Private_Void_ColorGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreationScreen>.NativeClassPtr, 100665384);
    }

    public CharacterCreationScreen(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SelectableSpriteCollection GenderImages
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderImages));
        return pointer == IntPtr.Zero ? (SelectableSpriteCollection) null : new SelectableSpriteCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterCustomizationSettings CustomizationSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_CustomizationSettings));
        return pointer == IntPtr.Zero ? (CharacterCustomizationSettings) null : new CharacterCustomizationSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_CustomizationSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RandomLocalizationKeys RandomLocalizationKeys
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomLocalizationKeys));
        return pointer == IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextAsset RandomMaleNames
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomMaleNames));
        return pointer == IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomMaleNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextAsset RandomFemaleNames
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomFemaleNames));
        return pointer == IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomFemaleNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton FaceLeftButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceLeftButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceLeftButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton FaceRightButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceRightButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceRightButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HairLeftButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairLeftButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairLeftButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton HairRightButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairRightButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairRightButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton FeaturesLeftButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeaturesLeftButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeaturesLeftButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton FeaturesRightButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeaturesRightButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeaturesRightButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AccessoriesLeftButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessoriesLeftButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessoriesLeftButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AccessoriesRightButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessoriesRightButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessoriesRightButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton RandomizeButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomizeButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomizeButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CreateButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_CreateButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_CreateButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton BackButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_BackButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DoneButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_DoneButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_DoneButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CancelButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_CancelButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_CancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle BodyTypeLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_BodyTypeLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_BodyTypeLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle SkintoneLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_SkintoneLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_SkintoneLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle FaceLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle EyeColorLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_EyeColorLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_EyeColorLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle HairLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle HairColorLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairColorLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairColorLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle FeaturesLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeaturesLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeaturesLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle AccessiroesLockInToggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessiroesLockInToggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessiroesLockInToggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NameRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NameRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NameRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText FaceIndexText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceIndexText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FaceIndexText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HairIndexText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairIndexText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairIndexText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText FeatureIndexText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeatureIndexText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_FeatureIndexText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText AccessoryIndexText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessoryIndexText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_AccessoryIndexText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField NameInputField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NameInputField));
        return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameResultText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NameResultText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NameResultText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton RandomNameButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomNameButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_RandomNameButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ImageGridSelectionEntry GenderEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderEntryPrefab));
        return pointer == IntPtr.Zero ? (ImageGridSelectionEntry) null : new ImageGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorGridSelectionEntry ColorEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ColorEntryPrefab));
        return pointer == IntPtr.Zero ? (ColorGridSelectionEntry) null : new ColorGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ColorEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorGridSelectionEntry NewColorEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NewColorEntryPrefab));
        return pointer == IntPtr.Zero ? (ColorGridSelectionEntry) null : new ColorGridSelectionEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_NewColorEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup GenderEntriesParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderEntriesParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup SkintoneColorEntriesParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_SkintoneColorEntriesParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_SkintoneColorEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup EyeColorEntriesParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_EyeColorEntriesParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_EyeColorEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup HairColorEntriesParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairColorEntriesParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairColorEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapPanAndZoom DragSpin
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_DragSpin));
        return pointer == IntPtr.Zero ? (MapPanAndZoom) null : new MapPanAndZoom(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_DragSpin), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform _ResponsePopup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr__ResponsePopup));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr__ResponsePopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ResponseText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ResponseText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ResponseText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button ResponseOkButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ResponseOkButton));
        return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ResponseOkButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey ValueKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ValueKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_ValueKey)) = value;
      }
    }

    public unsafe LocalizationKey LK_NameInvalid
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_NameInvalid));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_NameInvalid)) = value;
      }
    }

    public unsafe LocalizationKey LK_NameTaken
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_NameTaken));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_NameTaken)) = value;
      }
    }

    public unsafe LocalizationKey LK_Unknown
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_Unknown));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_Unknown)) = value;
      }
    }

    public unsafe LocalizationKey LK_DoneButton_Create
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_DoneButton_Create));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_DoneButton_Create)) = value;
      }
    }

    public unsafe LocalizationKey LK_DoneButton_Modify
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_DoneButton_Modify));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_LK_DoneButton_Modify)) = value;
      }
    }

    public unsafe GridSelectionGroup<ImageGridSelectionEntry, ImageGridSelectionEntry.Data> GenderImageSelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderImageSelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<ImageGridSelectionEntry, ImageGridSelectionEntry.Data>) null : new GridSelectionGroup<ImageGridSelectionEntry, ImageGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_GenderImageSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data> SkintoneColorSelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_SkintoneColorSelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data>) null : new GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_SkintoneColorSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data> EyeColorSelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_EyeColorSelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data>) null : new GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_EyeColorSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data> HairColorSelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairColorSelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data>) null : new GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCreationScreen.NativeFieldInfoPtr_HairColorSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
