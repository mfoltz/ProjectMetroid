// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.StartGameLoadMenuView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Backtrace.Unity.Model;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Audio;
using ProjectM.Auth;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class StartGameLoadMenuView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CinematicStartDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreLoadTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogoNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalyticsNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToSNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_BetaNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorMessageText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalyticsAgreementToggleGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalyticsAgreementToggle_Accept;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitButtonAnalytics;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptButtonAnalytics;
    private static readonly System.IntPtr NativeFieldInfoPtr__AnalyticsInfoTextClickHandler;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToSScrollbar;
    private static readonly System.IntPtr NativeFieldInfoPtr_AgreementToggle_PrivacyPolicy;
    private static readonly System.IntPtr NativeFieldInfoPtr_AgreementToggle_Tos;
    private static readonly System.IntPtr NativeFieldInfoPtr_TosButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrivacyPolicyButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptButtonToS;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitButtonToS;
    private static readonly System.IntPtr NativeFieldInfoPtr_AgreementToggle_Beta;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptButtonBeta;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitButtonBeta;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_SteamNotRunning;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_SteamInitFailed;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_SteamworksDllNotFound;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GameNotOwned;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_UnknownError;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_AppMissmatch;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadingHolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoPlayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_LongClip;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShortClip;
    private static readonly System.IntPtr NativeFieldInfoPtr__CinematicLoaded;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr__State;
    private static readonly System.IntPtr NativeFieldInfoPtr__CinematicStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreLoadTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamPlatformSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EOSPlatformSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManagerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamInitializeState;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForPlatformInit_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformInitState_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SteamFailure_Private_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WaitingForPlatformInit_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_WaitingForPlatformInit_Internal_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformInitState_Public_get_PlatformInitState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformInitState_Internal_set_Void_PlatformInitState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeBacktrace_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VideoPlayer_errorReceived_Private_Void_VideoPlayer_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VideoPlayer_started_Private_Void_VideoPlayer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExitGame_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMuteMusic_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableVideo_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__57_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__57_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__57_2_Private_Void_0;

    public unsafe bool SteamFailure
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_get_SteamFailure_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool WaitingForPlatformInit
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_get_WaitingForPlatformInit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_set_WaitingForPlatformInit_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PlatformInitState PlatformInitState
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_get_PlatformInitState_Public_get_PlatformInitState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlatformInitState*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_set_PlatformInitState_Internal_set_Void_PlatformInitState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287391, XrefRangeEnd = 1287527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287527, XrefRangeEnd = 1287547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeBacktrace()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_InitializeBacktrace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287547, XrefRangeEnd = 1287549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void VideoPlayer_errorReceived(UnityEngine.Video.VideoPlayer source, string message)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(message);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_VideoPlayer_errorReceived_Private_Void_VideoPlayer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void VideoPlayer_started(UnityEngine.Video.VideoPlayer source)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_VideoPlayer_started_Private_Void_VideoPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExitGame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_ExitGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287549, XrefRangeEnd = 1287588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetMuteMusic(bool mute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mute;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_SetMuteMusic_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287590, RefRangeEnd = 1287591, XrefRangeStart = 1287588, XrefRangeEnd = 1287590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableVideo()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_DisableVideo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287591, XrefRangeEnd = 1287642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287642, XrefRangeEnd = 1287643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StartGameLoadMenuView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287643, XrefRangeEnd = 1287651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__57_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr__Awake_b__57_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Awake_b__57_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr__Awake_b__57_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287651, XrefRangeEnd = 1287652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__57_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.NativeMethodInfoPtr__Awake_b__57_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StartGameLoadMenuView()
    {
      Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (StartGameLoadMenuView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr);
      StartGameLoadMenuView.NativeFieldInfoPtr_CinematicStartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (CinematicStartDelay));
      StartGameLoadMenuView.NativeFieldInfoPtr_PreLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (PreLoadTime));
      StartGameLoadMenuView.NativeFieldInfoPtr_LoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LoadTime));
      StartGameLoadMenuView.NativeFieldInfoPtr_LogoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LogoNode));
      StartGameLoadMenuView.NativeFieldInfoPtr_LoadProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LoadProgress));
      StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AnalyticsNode));
      StartGameLoadMenuView.NativeFieldInfoPtr_ToSNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ToSNode));
      StartGameLoadMenuView.NativeFieldInfoPtr_BetaNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (BetaNode));
      StartGameLoadMenuView.NativeFieldInfoPtr_ErrorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ErrorNode));
      StartGameLoadMenuView.NativeFieldInfoPtr_ErrorMessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ErrorMessageText));
      StartGameLoadMenuView.NativeFieldInfoPtr_ExitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ExitButton));
      StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsAgreementToggleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AnalyticsAgreementToggleGroup));
      StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsAgreementToggle_Accept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AnalyticsAgreementToggle_Accept));
      StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonAnalytics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ExitButtonAnalytics));
      StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonAnalytics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AcceptButtonAnalytics));
      StartGameLoadMenuView.NativeFieldInfoPtr__AnalyticsInfoTextClickHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_AnalyticsInfoTextClickHandler));
      StartGameLoadMenuView.NativeFieldInfoPtr_ToSScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ToSScrollbar));
      StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_PrivacyPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AgreementToggle_PrivacyPolicy));
      StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_Tos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AgreementToggle_Tos));
      StartGameLoadMenuView.NativeFieldInfoPtr_TosButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (TosButton));
      StartGameLoadMenuView.NativeFieldInfoPtr_PrivacyPolicyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (PrivacyPolicyButton));
      StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonToS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AcceptButtonToS));
      StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonToS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ExitButtonToS));
      StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_Beta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AgreementToggle_Beta));
      StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonBeta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (AcceptButtonBeta));
      StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonBeta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ExitButtonBeta));
      StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamNotRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LK_SteamNotRunning));
      StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamInitFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LK_SteamInitFailed));
      StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamworksDllNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LK_SteamworksDllNotFound));
      StartGameLoadMenuView.NativeFieldInfoPtr_LK_GameNotOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LK_GameNotOwned));
      StartGameLoadMenuView.NativeFieldInfoPtr_LK_UnknownError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LK_UnknownError));
      StartGameLoadMenuView.NativeFieldInfoPtr_LK_AppMissmatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LK_AppMissmatch));
      StartGameLoadMenuView.NativeFieldInfoPtr_LoadingHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LoadingHolder));
      StartGameLoadMenuView.NativeFieldInfoPtr_VideoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (VideoPlayer));
      StartGameLoadMenuView.NativeFieldInfoPtr_LongClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (LongClip));
      StartGameLoadMenuView.NativeFieldInfoPtr_ShortClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (ShortClip));
      StartGameLoadMenuView.NativeFieldInfoPtr__CinematicLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_CinematicLoaded));
      StartGameLoadMenuView.NativeFieldInfoPtr_SoundMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (SoundMapper));
      StartGameLoadMenuView.NativeFieldInfoPtr__State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_State));
      StartGameLoadMenuView.NativeFieldInfoPtr__CinematicStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_CinematicStartTime));
      StartGameLoadMenuView.NativeFieldInfoPtr__PreLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_PreLoadTime));
      StartGameLoadMenuView.NativeFieldInfoPtr__LoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_LoadTime));
      StartGameLoadMenuView.NativeFieldInfoPtr__SteamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_SteamPlatformSystem));
      StartGameLoadMenuView.NativeFieldInfoPtr__EOSPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_EOSPlatformSystem));
      StartGameLoadMenuView.NativeFieldInfoPtr__StudioManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_StudioManagerSystem));
      StartGameLoadMenuView.NativeFieldInfoPtr__SteamInitializeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, nameof (_SteamInitializeState));
      StartGameLoadMenuView.NativeFieldInfoPtr__WaitingForPlatformInit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, "<WaitingForPlatformInit>k__BackingField");
      StartGameLoadMenuView.NativeFieldInfoPtr__PlatformInitState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, "<PlatformInitState>k__BackingField");
      StartGameLoadMenuView.NativeMethodInfoPtr_get_SteamFailure_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669532);
      StartGameLoadMenuView.NativeMethodInfoPtr_get_WaitingForPlatformInit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669533);
      StartGameLoadMenuView.NativeMethodInfoPtr_set_WaitingForPlatformInit_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669534);
      StartGameLoadMenuView.NativeMethodInfoPtr_get_PlatformInitState_Public_get_PlatformInitState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669535);
      StartGameLoadMenuView.NativeMethodInfoPtr_set_PlatformInitState_Internal_set_Void_PlatformInitState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669536);
      StartGameLoadMenuView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669537);
      StartGameLoadMenuView.NativeMethodInfoPtr_InitializeBacktrace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669538);
      StartGameLoadMenuView.NativeMethodInfoPtr_VideoPlayer_errorReceived_Private_Void_VideoPlayer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669539);
      StartGameLoadMenuView.NativeMethodInfoPtr_VideoPlayer_started_Private_Void_VideoPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669540);
      StartGameLoadMenuView.NativeMethodInfoPtr_ExitGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669541);
      StartGameLoadMenuView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669542);
      StartGameLoadMenuView.NativeMethodInfoPtr_SetMuteMusic_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669543);
      StartGameLoadMenuView.NativeMethodInfoPtr_DisableVideo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669544);
      StartGameLoadMenuView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669545);
      StartGameLoadMenuView.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669546);
      StartGameLoadMenuView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669547);
      StartGameLoadMenuView.NativeMethodInfoPtr__Awake_b__57_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669548);
      StartGameLoadMenuView.NativeMethodInfoPtr__Awake_b__57_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669549);
      StartGameLoadMenuView.NativeMethodInfoPtr__Awake_b__57_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, 100669550);
    }

    public StartGameLoadMenuView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float CinematicStartDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_CinematicStartDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_CinematicStartDelay)) = value;
      }
    }

    public unsafe float PreLoadTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_PreLoadTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_PreLoadTime)) = value;
      }
    }

    public unsafe float LoadTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LoadTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LoadTime)) = value;
      }
    }

    public unsafe RectTransform LogoNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LogoNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LogoNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image LoadProgress
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LoadProgress));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LoadProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform AnalyticsNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ToSNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ToSNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ToSNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform BetaNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_BetaNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_BetaNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ErrorNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ErrorNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ErrorNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ErrorMessageText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ErrorMessageText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ErrorMessageText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ExitButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ToggleGroup AnalyticsAgreementToggleGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsAgreementToggleGroup));
        return pointer == System.IntPtr.Zero ? (ToggleGroup) null : new ToggleGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsAgreementToggleGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle AnalyticsAgreementToggle_Accept
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsAgreementToggle_Accept));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AnalyticsAgreementToggle_Accept), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ExitButtonAnalytics
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonAnalytics));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonAnalytics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AcceptButtonAnalytics
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonAnalytics));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonAnalytics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_LinkClickHandler _AnalyticsInfoTextClickHandler
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__AnalyticsInfoTextClickHandler));
        return pointer == System.IntPtr.Zero ? (TMP_LinkClickHandler) null : new TMP_LinkClickHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__AnalyticsInfoTextClickHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Scrollbar ToSScrollbar
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ToSScrollbar));
        return pointer == System.IntPtr.Zero ? (Scrollbar) null : new Scrollbar(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ToSScrollbar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle AgreementToggle_PrivacyPolicy
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_PrivacyPolicy));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_PrivacyPolicy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle AgreementToggle_Tos
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_Tos));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_Tos), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton TosButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_TosButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_TosButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton PrivacyPolicyButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_PrivacyPolicyButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_PrivacyPolicyButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AcceptButtonToS
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonToS));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonToS), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ExitButtonToS
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonToS));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonToS), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle AgreementToggle_Beta
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_Beta));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AgreementToggle_Beta), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton AcceptButtonBeta
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonBeta));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_AcceptButtonBeta), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ExitButtonBeta
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonBeta));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ExitButtonBeta), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_SteamNotRunning
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamNotRunning));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamNotRunning)) = value;
      }
    }

    public unsafe LocalizationKey LK_SteamInitFailed
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamInitFailed));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamInitFailed)) = value;
      }
    }

    public unsafe LocalizationKey LK_SteamworksDllNotFound
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamworksDllNotFound));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_SteamworksDllNotFound)) = value;
      }
    }

    public unsafe LocalizationKey LK_GameNotOwned
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_GameNotOwned));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_GameNotOwned)) = value;
      }
    }

    public unsafe LocalizationKey LK_UnknownError
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_UnknownError));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_UnknownError)) = value;
      }
    }

    public unsafe LocalizationKey LK_AppMissmatch
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_AppMissmatch));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LK_AppMissmatch)) = value;
      }
    }

    public unsafe CanvasGroup LoadingHolder
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LoadingHolder));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LoadingHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StunVideoPlayer VideoPlayer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_VideoPlayer));
        return pointer == System.IntPtr.Zero ? (StunVideoPlayer) null : new StunVideoPlayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_VideoPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StunVideoAsset LongClip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LongClip));
        return pointer == System.IntPtr.Zero ? (StunVideoAsset) null : new StunVideoAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_LongClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StunVideoAsset ShortClip
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ShortClip));
        return pointer == System.IntPtr.Zero ? (StunVideoAsset) null : new StunVideoAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_ShortClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _CinematicLoaded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__CinematicLoaded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__CinematicLoaded)) = value;
      }
    }

    public unsafe UISoundMapping SoundMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_SoundMapper));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr_SoundMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StartGameLoadMenuView.State _State
    {
      get
      {
        return *(StartGameLoadMenuView.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__State));
      }
      [param: In] set
      {
        *(StartGameLoadMenuView.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__State)) = value;
      }
    }

    public unsafe float _CinematicStartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__CinematicStartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__CinematicStartTime)) = value;
      }
    }

    public unsafe float _PreLoadTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__PreLoadTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__PreLoadTime)) = value;
      }
    }

    public unsafe float _LoadTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__LoadTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__LoadTime)) = value;
      }
    }

    public unsafe SteamPlatformSystem _SteamPlatformSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__SteamPlatformSystem));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__SteamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EOSPlatformSystem _EOSPlatformSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__EOSPlatformSystem));
        return pointer == System.IntPtr.Zero ? (EOSPlatformSystem) null : new EOSPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__EOSPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StudioManagerSystem _StudioManagerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__StudioManagerSystem));
        return pointer == System.IntPtr.Zero ? (StudioManagerSystem) null : new StudioManagerSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__StudioManagerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlatformInitState _SteamInitializeState
    {
      get
      {
        return *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__SteamInitializeState));
      }
      [param: In] set
      {
        *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__SteamInitializeState)) = value;
      }
    }

    public unsafe bool _WaitingForPlatformInit_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__WaitingForPlatformInit_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__WaitingForPlatformInit_k__BackingField)) = value;
      }
    }

    public unsafe PlatformInitState _PlatformInitState_k__BackingField
    {
      get
      {
        return *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__PlatformInitState_k__BackingField));
      }
      [param: In] set
      {
        *(PlatformInitState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.NativeFieldInfoPtr__PlatformInitState_k__BackingField)) = value;
      }
    }

    public enum State
    {
      InitializingVideo,
      PlayingVideo,
      Preload,
      Load,
      AcceptBetaNDA,
      AcceptAnalytics,
      AcceptToS,
      PostLoad,
      Done,
    }

    [ObfuscatedName("ProjectM.UI.StartGameLoadMenuView/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__57_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__57_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__62_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__57_3_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__57_4_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__62_0_Internal_Void_String_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287366, XrefRangeEnd = 1287369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__57_3()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.__c.NativeMethodInfoPtr__Awake_b__57_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287369, XrefRangeEnd = 1287372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Awake_b__57_4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.__c.NativeMethodInfoPtr__Awake_b__57_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287372, XrefRangeEnd = 1287384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Start_b__62_0(string id)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.__c.NativeMethodInfoPtr__Start_b__62_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr);
        StartGameLoadMenuView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, "<>9");
        StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__57_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, "<>9__57_3");
        StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__57_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, "<>9__57_4");
        StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, "<>9__62_0");
        StartGameLoadMenuView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, 100669552);
        StartGameLoadMenuView.__c.NativeMethodInfoPtr__Awake_b__57_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, 100669553);
        StartGameLoadMenuView.__c.NativeMethodInfoPtr__Awake_b__57_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, 100669554);
        StartGameLoadMenuView.__c.NativeMethodInfoPtr__Start_b__62_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView.__c>.NativeClassPtr, 100669555);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe StartGameLoadMenuView.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StartGameLoadMenuView.__c) null : new StartGameLoadMenuView.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__57_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__57_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__57_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__57_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__57_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__57_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction<string> __9__62_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__62_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction<string>) null : new UnityAction<string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StartGameLoadMenuView.__c.NativeFieldInfoPtr___9__62_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.StartGameLoadMenuView/<>c__DisplayClass58_0")]
    public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_applicationType;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__InitializeBacktrace_b__0_Internal_BacktraceData_BacktraceData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass58_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartGameLoadMenuView.__c__DisplayClass58_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287384, XrefRangeEnd = 1287391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BacktraceData _InitializeBacktrace_b__0(BacktraceData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StartGameLoadMenuView.__c__DisplayClass58_0.NativeMethodInfoPtr__InitializeBacktrace_b__0_Internal_BacktraceData_BacktraceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BacktraceData) null : new BacktraceData(pointer);
      }

      static __c__DisplayClass58_0()
      {
        Il2CppClassPointerStore<StartGameLoadMenuView.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartGameLoadMenuView>.NativeClassPtr, "<>c__DisplayClass58_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartGameLoadMenuView.__c__DisplayClass58_0>.NativeClassPtr);
        StartGameLoadMenuView.__c__DisplayClass58_0.NativeFieldInfoPtr_applicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartGameLoadMenuView.__c__DisplayClass58_0>.NativeClassPtr, nameof (applicationType));
        StartGameLoadMenuView.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView.__c__DisplayClass58_0>.NativeClassPtr, 100669556);
        StartGameLoadMenuView.__c__DisplayClass58_0.NativeMethodInfoPtr__InitializeBacktrace_b__0_Internal_BacktraceData_BacktraceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartGameLoadMenuView.__c__DisplayClass58_0>.NativeClassPtr, 100669557);
      }

      public __c__DisplayClass58_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string applicationType
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.__c__DisplayClass58_0.NativeFieldInfoPtr_applicationType)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StartGameLoadMenuView.__c__DisplayClass58_0.NativeFieldInfoPtr_applicationType), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }
  }
}
