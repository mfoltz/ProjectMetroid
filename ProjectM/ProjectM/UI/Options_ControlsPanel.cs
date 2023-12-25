// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Options_ControlsPanel
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Fmod;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class Options_ControlsPanel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CategoryHeaderPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ControlsInputEntryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ContentNode;
    private static readonly IntPtr NativeFieldInfoPtr_PopupPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_PopupRect;
    private static readonly IntPtr NativeFieldInfoPtr_AssignSound;
    private static readonly IntPtr NativeFieldInfoPtr_ClearSound;
    private static readonly IntPtr NativeFieldInfoPtr_CancelSound;
    private static readonly IntPtr NativeFieldInfoPtr_ResetButton;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Category_Movement;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Category_SkillsAndAttacks;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Category_General;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Category_Camera;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Category_Panels;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Category_ActionBar;
    private static readonly IntPtr NativeFieldInfoPtr_LK_Category_Building;
    private static readonly IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly IntPtr NativeFieldInfoPtr_CurrentState;
    private static readonly IntPtr NativeFieldInfoPtr__Values;
    private static readonly IntPtr NativeFieldInfoPtr__Keys;
    private static readonly IntPtr NativeFieldInfoPtr__Popup;
    private static readonly IntPtr NativeFieldInfoPtr__SavedEntry;
    private static readonly IntPtr NativeFieldInfoPtr__SavedPrimary;
    private static readonly IntPtr NativeFieldInfoPtr__SavedPositive;
    private static readonly IntPtr NativeFieldInfoPtr__Entries;
    private static readonly IntPtr NativeFieldInfoPtr__SavedInputFlag;
    private static readonly IntPtr NativeFieldInfoPtr__SavedAnalog;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Private_Void_InputFlag_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Private_Void_AnalogInput_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnEntryButtonClicked_Private_Void_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_State_0;
    private static readonly IntPtr NativeMethodInfoPtr_InitPopup_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClosePopup_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateEntry_Private_Void_KeyCode_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnResetButtonClicked_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RefreshAll_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164343, XrefRangeEnd = 1164377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164377, XrefRangeEnd = 1164475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164475, XrefRangeEnd = 1164479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader(LocalizationKey localizationKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &localizationKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 1164495, RefRangeEnd = 1164560, XrefRangeStart = 1164479, XrefRangeEnd = 1164495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddEntry(InputFlag inputFlag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &inputFlag;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_AddEntry_Private_Void_InputFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1164576, RefRangeEnd = 1164580, XrefRangeStart = 1164560, XrefRangeEnd = 1164576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddEntry(AnalogInput inputFlag, bool positive)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &inputFlag;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positive;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_AddEntry_Private_Void_AnalogInput_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164580, XrefRangeEnd = 1164582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEntryButtonClicked(
      ControlsInputEntry entry,
      bool primary,
      InputFlag inputFlag,
      AnalogInput analogInput,
      bool positive)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &primary;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &inputFlag;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &analogInput;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &positive;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_OnEntryButtonClicked_Private_Void_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164584, RefRangeEnd = 1164585, XrefRangeStart = 1164582, XrefRangeEnd = 1164584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetState(Options_ControlsPanel.State newState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &newState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_SetState_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164585, XrefRangeEnd = 1164596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_InitPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164596, XrefRangeEnd = 1164599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClosePopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_ClosePopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164599, XrefRangeEnd = 1164614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164652, RefRangeEnd = 1164653, XrefRangeStart = 1164614, XrefRangeEnd = 1164652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateEntry(KeyCode pressedKeyCode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &pressedKeyCode;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_UpdateEntry_Private_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164653, XrefRangeEnd = 1164655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnResetButtonClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_OnResetButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164670, RefRangeEnd = 1164671, XrefRangeStart = 1164655, XrefRangeEnd = 1164670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshAll()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr_RefreshAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164671, XrefRangeEnd = 1164679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_ControlsPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_ControlsPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Options_ControlsPanel()
    {
      Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (Options_ControlsPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr);
      Options_ControlsPanel.NativeFieldInfoPtr_CategoryHeaderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (CategoryHeaderPrefab));
      Options_ControlsPanel.NativeFieldInfoPtr_ControlsInputEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (ControlsInputEntryPrefab));
      Options_ControlsPanel.NativeFieldInfoPtr_ContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (ContentNode));
      Options_ControlsPanel.NativeFieldInfoPtr_PopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (PopupPrefab));
      Options_ControlsPanel.NativeFieldInfoPtr_PopupRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (PopupRect));
      Options_ControlsPanel.NativeFieldInfoPtr_AssignSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (AssignSound));
      Options_ControlsPanel.NativeFieldInfoPtr_ClearSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (ClearSound));
      Options_ControlsPanel.NativeFieldInfoPtr_CancelSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (CancelSound));
      Options_ControlsPanel.NativeFieldInfoPtr_ResetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (ResetButton));
      Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (LK_Category_Movement));
      Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_SkillsAndAttacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (LK_Category_SkillsAndAttacks));
      Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_General = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (LK_Category_General));
      Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (LK_Category_Camera));
      Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (LK_Category_Panels));
      Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_ActionBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (LK_Category_ActionBar));
      Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (LK_Category_Building));
      Options_ControlsPanel.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_InputSystem));
      Options_ControlsPanel.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (CurrentState));
      Options_ControlsPanel.NativeFieldInfoPtr__Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_Values));
      Options_ControlsPanel.NativeFieldInfoPtr__Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_Keys));
      Options_ControlsPanel.NativeFieldInfoPtr__Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_Popup));
      Options_ControlsPanel.NativeFieldInfoPtr__SavedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_SavedEntry));
      Options_ControlsPanel.NativeFieldInfoPtr__SavedPrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_SavedPrimary));
      Options_ControlsPanel.NativeFieldInfoPtr__SavedPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_SavedPositive));
      Options_ControlsPanel.NativeFieldInfoPtr__Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_Entries));
      Options_ControlsPanel.NativeFieldInfoPtr__SavedInputFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_SavedInputFlag));
      Options_ControlsPanel.NativeFieldInfoPtr__SavedAnalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, nameof (_SavedAnalog));
      Options_ControlsPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692599);
      Options_ControlsPanel.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692600);
      Options_ControlsPanel.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692601);
      Options_ControlsPanel.NativeMethodInfoPtr_AddEntry_Private_Void_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692602);
      Options_ControlsPanel.NativeMethodInfoPtr_AddEntry_Private_Void_AnalogInput_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692603);
      Options_ControlsPanel.NativeMethodInfoPtr_OnEntryButtonClicked_Private_Void_ControlsInputEntry_Boolean_InputFlag_AnalogInput_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692604);
      Options_ControlsPanel.NativeMethodInfoPtr_SetState_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692605);
      Options_ControlsPanel.NativeMethodInfoPtr_InitPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692606);
      Options_ControlsPanel.NativeMethodInfoPtr_ClosePopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692607);
      Options_ControlsPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692608);
      Options_ControlsPanel.NativeMethodInfoPtr_UpdateEntry_Private_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692609);
      Options_ControlsPanel.NativeMethodInfoPtr_OnResetButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692610);
      Options_ControlsPanel.NativeMethodInfoPtr_RefreshAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692611);
      Options_ControlsPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_ControlsPanel>.NativeClassPtr, 100692612);
    }

    public Options_ControlsPanel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe OptionsCategoryHeader CategoryHeaderPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_CategoryHeaderPrefab));
        return pointer == IntPtr.Zero ? (OptionsCategoryHeader) null : new OptionsCategoryHeader(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_CategoryHeaderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ControlsInputEntry ControlsInputEntryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ControlsInputEntryPrefab));
        return pointer == IntPtr.Zero ? (ControlsInputEntry) null : new ControlsInputEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ControlsInputEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ContentNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ContentNode));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MonoBehaviour PopupPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_PopupPrefab));
        return pointer == IntPtr.Zero ? (MonoBehaviour) null : new MonoBehaviour(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_PopupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PopupRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_PopupRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_PopupRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public FmodEvent AssignSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_AssignSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_AssignSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent ClearSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ClearSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ClearSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent CancelSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_CancelSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_CancelSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe SimpleStunButton ResetButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ResetButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_ResetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Category_Movement
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Movement));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Movement)) = value;
      }
    }

    public unsafe LocalizationKey LK_Category_SkillsAndAttacks
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_SkillsAndAttacks));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_SkillsAndAttacks)) = value;
      }
    }

    public unsafe LocalizationKey LK_Category_General
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_General));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_General)) = value;
      }
    }

    public unsafe LocalizationKey LK_Category_Camera
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Camera));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Camera)) = value;
      }
    }

    public unsafe LocalizationKey LK_Category_Panels
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Panels));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Panels)) = value;
      }
    }

    public unsafe LocalizationKey LK_Category_ActionBar
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_ActionBar));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_ActionBar)) = value;
      }
    }

    public unsafe LocalizationKey LK_Category_Building
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Building));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_LK_Category_Building)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__InputSystem));
        return pointer == IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_ControlsPanel.State CurrentState
    {
      get
      {
        return *(Options_ControlsPanel.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_CurrentState));
      }
      [param: In] set
      {
        *(Options_ControlsPanel.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr_CurrentState)) = value;
      }
    }

    public unsafe Il2CppStructArray<int> _Values
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Values));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<bool> _Keys
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Keys));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<bool>) null : new Il2CppStructArray<bool>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Keys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MonoBehaviour _Popup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Popup));
        return pointer == IntPtr.Zero ? (MonoBehaviour) null : new MonoBehaviour(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Popup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ControlsInputEntry _SavedEntry
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedEntry));
        return pointer == IntPtr.Zero ? (ControlsInputEntry) null : new ControlsInputEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _SavedPrimary
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedPrimary));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedPrimary)) = value;
      }
    }

    public unsafe bool _SavedPositive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedPositive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedPositive)) = value;
      }
    }

    public unsafe List<ControlsInputEntry> _Entries
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Entries));
        return pointer == IntPtr.Zero ? (List<ControlsInputEntry>) null : new List<ControlsInputEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputFlag _SavedInputFlag
    {
      get
      {
        return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedInputFlag));
      }
      [param: In] set
      {
        *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedInputFlag)) = value;
      }
    }

    public unsafe AnalogInput _SavedAnalog
    {
      get
      {
        return *(AnalogInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedAnalog));
      }
      [param: In] set
      {
        *(AnalogInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_ControlsPanel.NativeFieldInfoPtr__SavedAnalog)) = value;
      }
    }

    public enum State
    {
      Normal,
      ReadKey,
    }
  }
}
