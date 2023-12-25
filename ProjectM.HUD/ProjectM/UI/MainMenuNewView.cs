// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MainMenuNewView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Auth;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace ProjectM.UI
{
  public class MainMenuNewView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MenuCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CinematicsCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugServerListButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugStartHeartbeatButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoPlayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoFadeInTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_News;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamPlatformSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_PopupManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__State;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialRefreshDone;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnOpenPopup_Private_Void_PopupType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleLaunchParameters_Private_Void_CommandLineData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SinglePlayerButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowProgressLostPopup_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContinueButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OptionsButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExtrasButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GloomrotCinematicButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VRisingCinematicButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExitButton_OnClick_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHome_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCinematics_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitialRefresh_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278937, XrefRangeEnd = 1278951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278951, XrefRangeEnd = 1278953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnOpenPopup(PopupType popupType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &popupType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_OnOpenPopup_Private_Void_PopupType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278953, XrefRangeEnd = 1279014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279014, XrefRangeEnd = 1279040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleLaunchParameters(
      SteamPlatformSystem.CommandLineData commandLineData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &commandLineData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_HandleLaunchParameters_Private_Void_CommandLineData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279040, XrefRangeEnd = 1279048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SinglePlayerButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_SinglePlayerButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279048, XrefRangeEnd = 1279049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_PlayButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279049, XrefRangeEnd = 1279057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldShowProgressLostPopup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_ShouldShowProgressLostPopup_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279057, XrefRangeEnd = 1279058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ContinueButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_ContinueButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OptionsButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_OptionsButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279058, XrefRangeEnd = 1279059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExtrasButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_ExtrasButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279059, XrefRangeEnd = 1279065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GloomrotCinematicButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_GloomrotCinematicButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279065, XrefRangeEnd = 1279071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void VRisingCinematicButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_VRisingCinematicButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279071, XrefRangeEnd = 1279072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExitButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_ExitButton_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279072, XrefRangeEnd = 1279073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279073, XrefRangeEnd = 1279086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetHome()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_SetHome_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetCinematics()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_SetCinematics_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1279098, RefRangeEnd = 1279100, XrefRangeStart = 1279086, XrefRangeEnd = 1279098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InitialRefresh()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_InitialRefresh_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279100, XrefRangeEnd = 1279101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MainMenuNewView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MainMenuNewView()
    {
      Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MainMenuNewView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr);
      MainMenuNewView.NativeFieldInfoPtr_MenuCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (MenuCollection));
      MainMenuNewView.NativeFieldInfoPtr_CinematicsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (CinematicsCollection));
      MainMenuNewView.NativeFieldInfoPtr_DebugServerListButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (DebugServerListButton));
      MainMenuNewView.NativeFieldInfoPtr_DebugStartHeartbeatButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (DebugStartHeartbeatButton));
      MainMenuNewView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (_InputSystem));
      MainMenuNewView.NativeFieldInfoPtr_VideoImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (VideoImage));
      MainMenuNewView.NativeFieldInfoPtr_VideoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (VideoPlayer));
      MainMenuNewView.NativeFieldInfoPtr_VideoAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (VideoAlpha));
      MainMenuNewView.NativeFieldInfoPtr_VideoFadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (VideoFadeInTime));
      MainMenuNewView.NativeFieldInfoPtr_News = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (News));
      MainMenuNewView.NativeFieldInfoPtr__SteamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (_SteamPlatformSystem));
      MainMenuNewView.NativeFieldInfoPtr_PopupManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (PopupManager));
      MainMenuNewView.NativeFieldInfoPtr__State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (_State));
      MainMenuNewView.NativeFieldInfoPtr_InitialRefreshDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, nameof (InitialRefreshDone));
      MainMenuNewView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668833);
      MainMenuNewView.NativeMethodInfoPtr_OnOpenPopup_Private_Void_PopupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668834);
      MainMenuNewView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668835);
      MainMenuNewView.NativeMethodInfoPtr_HandleLaunchParameters_Private_Void_CommandLineData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668836);
      MainMenuNewView.NativeMethodInfoPtr_SinglePlayerButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668837);
      MainMenuNewView.NativeMethodInfoPtr_PlayButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668838);
      MainMenuNewView.NativeMethodInfoPtr_ShouldShowProgressLostPopup_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668839);
      MainMenuNewView.NativeMethodInfoPtr_ContinueButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668840);
      MainMenuNewView.NativeMethodInfoPtr_OptionsButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668841);
      MainMenuNewView.NativeMethodInfoPtr_ExtrasButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668842);
      MainMenuNewView.NativeMethodInfoPtr_GloomrotCinematicButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668843);
      MainMenuNewView.NativeMethodInfoPtr_VRisingCinematicButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668844);
      MainMenuNewView.NativeMethodInfoPtr_ExitButton_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668845);
      MainMenuNewView.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668846);
      MainMenuNewView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668847);
      MainMenuNewView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668848);
      MainMenuNewView.NativeMethodInfoPtr_SetHome_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668849);
      MainMenuNewView.NativeMethodInfoPtr_SetCinematics_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668850);
      MainMenuNewView.NativeMethodInfoPtr_InitialRefresh_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668851);
      MainMenuNewView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668852);
      MainMenuNewView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668853);
      MainMenuNewView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, 100668854);
    }

    public MainMenuNewView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MenuCollection MenuCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_MenuCollection));
        return pointer == System.IntPtr.Zero ? (MenuCollection) null : new MenuCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_MenuCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MenuCollection CinematicsCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_CinematicsCollection));
        return pointer == System.IntPtr.Zero ? (MenuCollection) null : new MenuCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_CinematicsCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DebugServerListButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_DebugServerListButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_DebugServerListButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DebugStartHeartbeatButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_DebugStartHeartbeatButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_DebugStartHeartbeatButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RawImage VideoImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoImage));
        return pointer == System.IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VideoPlayer VideoPlayer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoPlayer));
        return pointer == System.IntPtr.Zero ? (VideoPlayer) null : new VideoPlayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CanvasGroup VideoAlpha
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoAlpha));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoAlpha), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float VideoFadeInTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoFadeInTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_VideoFadeInTime)) = value;
      }
    }

    public unsafe NewsPanel News
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_News));
        return pointer == System.IntPtr.Zero ? (NewsPanel) null : new NewsPanel(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_News), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SteamPlatformSystem _SteamPlatformSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr__SteamPlatformSystem));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr__SteamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PopupManager PopupManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_PopupManager));
        return pointer == System.IntPtr.Zero ? (PopupManager) null : new PopupManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr_PopupManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MainMenuNewView.State _State
    {
      get
      {
        return *(MainMenuNewView.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr__State));
      }
      [param: In] set
      {
        *(MainMenuNewView.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MainMenuNewView.NativeFieldInfoPtr__State)) = value;
      }
    }

    public static unsafe bool InitialRefreshDone
    {
      get
      {
        bool initialRefreshDone;
        IL2CPP.il2cpp_field_static_get_value(MainMenuNewView.NativeFieldInfoPtr_InitialRefreshDone, (void*) &initialRefreshDone);
        return initialRefreshDone;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MainMenuNewView.NativeFieldInfoPtr_InitialRefreshDone, (void*) &value);
      }
    }

    public enum State
    {
      Home,
      Cinematics,
    }

    [ObfuscatedName("ProjectM.UI.MainMenuNewView/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__16_0_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__16_1_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278923, XrefRangeEnd = 1278930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Start_b__16_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.__c.NativeMethodInfoPtr__Start_b__16_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278930, XrefRangeEnd = 1278937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Start_b__16_1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MainMenuNewView.__c.NativeMethodInfoPtr__Start_b__16_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuNewView>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr);
        MainMenuNewView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr, "<>9");
        MainMenuNewView.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr, "<>9__16_0");
        MainMenuNewView.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr, "<>9__16_1");
        MainMenuNewView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr, 100668857);
        MainMenuNewView.__c.NativeMethodInfoPtr__Start_b__16_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr, 100668858);
        MainMenuNewView.__c.NativeMethodInfoPtr__Start_b__16_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuNewView.__c>.NativeClassPtr, 100668859);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe MainMenuNewView.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MainMenuNewView.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (MainMenuNewView.__c) null : new MainMenuNewView.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MainMenuNewView.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action __9__16_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MainMenuNewView.__c.NativeFieldInfoPtr___9__16_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MainMenuNewView.__c.NativeFieldInfoPtr___9__16_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action __9__16_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MainMenuNewView.__c.NativeFieldInfoPtr___9__16_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MainMenuNewView.__c.NativeFieldInfoPtr___9__16_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
