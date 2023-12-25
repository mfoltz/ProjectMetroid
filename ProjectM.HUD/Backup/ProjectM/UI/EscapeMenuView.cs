// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.EscapeMenuView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class EscapeMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MenuCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionInfoRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionInfoText1;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionInfoText2;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionInfoText3;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastlePvPEnabledText;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerPvPEnabledText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionInfoKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_StreamerModeKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReportABugButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_FAQButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_Popup;
    private static readonly System.IntPtr NativeFieldInfoPtr_YesKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnstuckWarningKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodBoundUnstuckWarningKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaveGameKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaveGameHostKey;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveConnectionData;
    private static readonly System.IntPtr NativeFieldInfoPtr__BlockOtherButtonPresses;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConnectionString_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_ResumeGame_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Options_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_LeaveGame_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_ExitToDesktop_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_GoToUnstuckView_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBloodBound_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsServerHost_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendUnstuckEvent_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_ReportABug_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_FrequentlyAskedQuestions_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResumeGame_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnButtonClick_LeaveGame_b__28_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnButtonClick_ExitToDesktop_b__29_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnButtonClick_GoToUnstuckView_b__30_0_Private_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277795, XrefRangeEnd = 1277804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277804, XrefRangeEnd = 1277811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateConnectionString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_UpdateConnectionString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277811, XrefRangeEnd = 1277812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277812, XrefRangeEnd = 1277871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277871, XrefRangeEnd = 1277872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_ResumeGame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_ResumeGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277872, XrefRangeEnd = 1277873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Options()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_Options_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277873, XrefRangeEnd = 1277906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_LeaveGame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_LeaveGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277906, XrefRangeEnd = 1277939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_ExitToDesktop()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_ExitToDesktop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277939, XrefRangeEnd = 1277983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_GoToUnstuckView()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_GoToUnstuckView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277983, XrefRangeEnd = 1277996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsBloodBound()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_IsBloodBound_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1278004, RefRangeEnd = 1278006, XrefRangeStart = 1277996, XrefRangeEnd = 1278004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsServerHost()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_IsServerHost_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278006, XrefRangeEnd = 1278013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendUnstuckEvent()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_SendUnstuckEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278013, XrefRangeEnd = 1278016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_ReportABug()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_ReportABug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278016, XrefRangeEnd = 1278019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_FrequentlyAskedQuestions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_FrequentlyAskedQuestions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278019, XrefRangeEnd = 1278023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278023, XrefRangeEnd = 1278024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResumeGame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr_ResumeGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EscapeMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278024, XrefRangeEnd = 1278025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnButtonClick_LeaveGame_b__28_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr__OnButtonClick_LeaveGame_b__28_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278025, XrefRangeEnd = 1278026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnButtonClick_ExitToDesktop_b__29_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr__OnButtonClick_ExitToDesktop_b__29_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278026, XrefRangeEnd = 1278034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnButtonClick_GoToUnstuckView_b__30_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.NativeMethodInfoPtr__OnButtonClick_GoToUnstuckView_b__30_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EscapeMenuView()
    {
      Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (EscapeMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr);
      EscapeMenuView.NativeFieldInfoPtr_MenuCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (MenuCollection));
      EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (ConnectionInfoRect));
      EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (ConnectionInfoText1));
      EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (ConnectionInfoText2));
      EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (ConnectionInfoText3));
      EscapeMenuView.NativeFieldInfoPtr_CastlePvPEnabledText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (CastlePvPEnabledText));
      EscapeMenuView.NativeFieldInfoPtr_PlayerPvPEnabledText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (PlayerPvPEnabledText));
      EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (ConnectionInfoKey));
      EscapeMenuView.NativeFieldInfoPtr_StreamerModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (StreamerModeKey));
      EscapeMenuView.NativeFieldInfoPtr_ReportABugButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (ReportABugButton));
      EscapeMenuView.NativeFieldInfoPtr_FAQButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (FAQButton));
      EscapeMenuView.NativeFieldInfoPtr_Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (Popup));
      EscapeMenuView.NativeFieldInfoPtr_YesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (YesKey));
      EscapeMenuView.NativeFieldInfoPtr_NoKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (NoKey));
      EscapeMenuView.NativeFieldInfoPtr_UnstuckWarningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (UnstuckWarningKey));
      EscapeMenuView.NativeFieldInfoPtr_BloodBoundUnstuckWarningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (BloodBoundUnstuckWarningKey));
      EscapeMenuView.NativeFieldInfoPtr_LeaveGameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (LeaveGameKey));
      EscapeMenuView.NativeFieldInfoPtr_LeaveGameHostKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (LeaveGameHostKey));
      EscapeMenuView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (_InputSystem));
      EscapeMenuView.NativeFieldInfoPtr__ActiveConnectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (_ActiveConnectionData));
      EscapeMenuView.NativeFieldInfoPtr__BlockOtherButtonPresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, nameof (_BlockOtherButtonPresses));
      EscapeMenuView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668740);
      EscapeMenuView.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668741);
      EscapeMenuView.NativeMethodInfoPtr_UpdateConnectionString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668742);
      EscapeMenuView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668743);
      EscapeMenuView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668744);
      EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_ResumeGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668745);
      EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_Options_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668746);
      EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_LeaveGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668747);
      EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_ExitToDesktop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668748);
      EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_GoToUnstuckView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668749);
      EscapeMenuView.NativeMethodInfoPtr_IsBloodBound_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668750);
      EscapeMenuView.NativeMethodInfoPtr_IsServerHost_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668751);
      EscapeMenuView.NativeMethodInfoPtr_SendUnstuckEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668752);
      EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_ReportABug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668753);
      EscapeMenuView.NativeMethodInfoPtr_OnButtonClick_FrequentlyAskedQuestions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668754);
      EscapeMenuView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668755);
      EscapeMenuView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668756);
      EscapeMenuView.NativeMethodInfoPtr_ResumeGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668757);
      EscapeMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668758);
      EscapeMenuView.NativeMethodInfoPtr__OnButtonClick_LeaveGame_b__28_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668759);
      EscapeMenuView.NativeMethodInfoPtr__OnButtonClick_ExitToDesktop_b__29_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668760);
      EscapeMenuView.NativeMethodInfoPtr__OnButtonClick_GoToUnstuckView_b__30_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, 100668761);
    }

    public EscapeMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MenuCollection MenuCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_MenuCollection));
        return pointer == System.IntPtr.Zero ? (MenuCollection) null : new MenuCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_MenuCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ConnectionInfoRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ConnectionInfoText1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText1));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ConnectionInfoText2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText2));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ConnectionInfoText3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText3));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoText3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CastlePvPEnabledText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_CastlePvPEnabledText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_CastlePvPEnabledText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PlayerPvPEnabledText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_PlayerPvPEnabledText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_PlayerPvPEnabledText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey ConnectionInfoKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ConnectionInfoKey)) = value;
      }
    }

    public unsafe LocalizationKey StreamerModeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_StreamerModeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_StreamerModeKey)) = value;
      }
    }

    public unsafe SimpleStunButton ReportABugButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ReportABugButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_ReportABugButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton FAQButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_FAQButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_FAQButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EscapeMenuPopup Popup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_Popup));
        return pointer == System.IntPtr.Zero ? (EscapeMenuPopup) null : new EscapeMenuPopup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_Popup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey YesKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_YesKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_YesKey)) = value;
      }
    }

    public unsafe LocalizationKey NoKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_NoKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_NoKey)) = value;
      }
    }

    public unsafe LocalizationKey UnstuckWarningKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_UnstuckWarningKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_UnstuckWarningKey)) = value;
      }
    }

    public unsafe LocalizationKey BloodBoundUnstuckWarningKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_BloodBoundUnstuckWarningKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_BloodBoundUnstuckWarningKey)) = value;
      }
    }

    public unsafe LocalizationKey LeaveGameKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_LeaveGameKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_LeaveGameKey)) = value;
      }
    }

    public unsafe LocalizationKey LeaveGameHostKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_LeaveGameHostKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr_LeaveGameHostKey)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ClientBootstrapSystem.ConnectionData _ActiveConnectionData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr__ActiveConnectionData);
        return new ClientBootstrapSystem.ConnectionData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr__ActiveConnectionData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ClientBootstrapSystem.ConnectionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _BlockOtherButtonPresses
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr__BlockOtherButtonPresses));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EscapeMenuView.NativeFieldInfoPtr__BlockOtherButtonPresses)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.EscapeMenuView/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__28_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__29_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__30_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnButtonClick_LeaveGame_b__28_1_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnButtonClick_ExitToDesktop_b__29_1_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnButtonClick_GoToUnstuckView_b__30_1_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnButtonClick_LeaveGame_b__28_1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.__c.NativeMethodInfoPtr__OnButtonClick_LeaveGame_b__28_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnButtonClick_ExitToDesktop_b__29_1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.__c.NativeMethodInfoPtr__OnButtonClick_ExitToDesktop_b__29_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnButtonClick_GoToUnstuckView_b__30_1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EscapeMenuView.__c.NativeMethodInfoPtr__OnButtonClick_GoToUnstuckView_b__30_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscapeMenuView>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr);
        EscapeMenuView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, "<>9");
        EscapeMenuView.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, "<>9__28_1");
        EscapeMenuView.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, "<>9__29_1");
        EscapeMenuView.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, "<>9__30_1");
        EscapeMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, 100668763);
        EscapeMenuView.__c.NativeMethodInfoPtr__OnButtonClick_LeaveGame_b__28_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, 100668764);
        EscapeMenuView.__c.NativeMethodInfoPtr__OnButtonClick_ExitToDesktop_b__29_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, 100668765);
        EscapeMenuView.__c.NativeMethodInfoPtr__OnButtonClick_GoToUnstuckView_b__30_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscapeMenuView.__c>.NativeClassPtr, 100668766);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe EscapeMenuView.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EscapeMenuView.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (EscapeMenuView.__c) null : new EscapeMenuView.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EscapeMenuView.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action __9__28_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EscapeMenuView.__c.NativeFieldInfoPtr___9__28_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EscapeMenuView.__c.NativeFieldInfoPtr___9__28_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action __9__29_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EscapeMenuView.__c.NativeFieldInfoPtr___9__29_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EscapeMenuView.__c.NativeFieldInfoPtr___9__29_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action __9__30_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EscapeMenuView.__c.NativeFieldInfoPtr___9__30_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EscapeMenuView.__c.NativeFieldInfoPtr___9__30_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
