// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ConnectingView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ConnectingView : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadingText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadyText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Backgrounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadingMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Initializing;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Authenticating;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_StartingUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Connecting;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Loading;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_PreWarmingShaders;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Ready;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Error;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ServerStarting;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VersionMismatch;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedStatusMessages;
    private static readonly System.IntPtr NativeFieldInfoPtr_CharacterCreationScenePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConnectStartedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__FramesSinceConnectStarted;
    private static readonly System.IntPtr NativeFieldInfoPtr__ForceShowBackButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__Ready;
    private static readonly System.IntPtr NativeFieldInfoPtr__CustomizationBrowser;
    private static readonly System.IntPtr NativeFieldInfoPtr__FadeOut;
    private static readonly System.IntPtr NativeFieldInfoPtr__EditorSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__GotoCharacterScreenDone;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameBootstrap;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameConnect;
    private static readonly System.IntPtr NativeFieldInfoPtr__BackgroundSpriteIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BackButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BackgroundButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277613, XrefRangeEnd = 1277657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277657, XrefRangeEnd = 1277658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BackButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr_BackButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void BackgroundButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr_BackgroundButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277658, XrefRangeEnd = 1277698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConnectingView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConnectingView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConnectingView()
    {
      Il2CppClassPointerStore<ConnectingView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ConnectingView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr);
      ConnectingView.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (CanvasGroup));
      ConnectingView.NativeFieldInfoPtr_LoadingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LoadingText));
      ConnectingView.NativeFieldInfoPtr_ReadyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (ReadyText));
      ConnectingView.NativeFieldInfoPtr_Backgrounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (Backgrounds));
      ConnectingView.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (BackgroundImage));
      ConnectingView.NativeFieldInfoPtr_BackgroundButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (BackgroundButton));
      ConnectingView.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (BackButton));
      ConnectingView.NativeFieldInfoPtr_LoadingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LoadingMessage));
      ConnectingView.NativeFieldInfoPtr_LK_Initializing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_Initializing));
      ConnectingView.NativeFieldInfoPtr_LK_Authenticating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_Authenticating));
      ConnectingView.NativeFieldInfoPtr_LK_StartingUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_StartingUp));
      ConnectingView.NativeFieldInfoPtr_LK_Connecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_Connecting));
      ConnectingView.NativeFieldInfoPtr_LK_Loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_Loading));
      ConnectingView.NativeFieldInfoPtr_LK_PreWarmingShaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_PreWarmingShaders));
      ConnectingView.NativeFieldInfoPtr_LK_Ready = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_Ready));
      ConnectingView.NativeFieldInfoPtr_LK_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_Error));
      ConnectingView.NativeFieldInfoPtr_LK_ServerStarting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_ServerStarting));
      ConnectingView.NativeFieldInfoPtr_LK_VersionMismatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LK_VersionMismatch));
      ConnectingView.NativeFieldInfoPtr_LocalizedStatusMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (LocalizedStatusMessages));
      ConnectingView.NativeFieldInfoPtr_CharacterCreationScenePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (CharacterCreationScenePrefab));
      ConnectingView.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_InputSystem));
      ConnectingView.NativeFieldInfoPtr__ConnectStartedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_ConnectStartedTime));
      ConnectingView.NativeFieldInfoPtr__FramesSinceConnectStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_FramesSinceConnectStarted));
      ConnectingView.NativeFieldInfoPtr__ForceShowBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_ForceShowBackButton));
      ConnectingView.NativeFieldInfoPtr__Ready = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_Ready));
      ConnectingView.NativeFieldInfoPtr__CustomizationBrowser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_CustomizationBrowser));
      ConnectingView.NativeFieldInfoPtr__FadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_FadeOut));
      ConnectingView.NativeFieldInfoPtr__EditorSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_EditorSettings));
      ConnectingView.NativeFieldInfoPtr__GotoCharacterScreenDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_GotoCharacterScreenDone));
      ConnectingView.NativeFieldInfoPtr__GameBootstrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_GameBootstrap));
      ConnectingView.NativeFieldInfoPtr__GameConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_GameConnect));
      ConnectingView.NativeFieldInfoPtr__BackgroundSpriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, nameof (_BackgroundSpriteIndex));
      ConnectingView.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668712);
      ConnectingView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668713);
      ConnectingView.NativeMethodInfoPtr_BackButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668714);
      ConnectingView.NativeMethodInfoPtr_BackgroundButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668715);
      ConnectingView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668716);
      ConnectingView.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668717);
      ConnectingView.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668718);
      ConnectingView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectingView>.NativeClassPtr, 100668719);
    }

    public ConnectingView(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup CanvasGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_CanvasGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI LoadingText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LoadingText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LoadingText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI ReadyText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_ReadyText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_ReadyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Sprite> Backgrounds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_Backgrounds));
        return pointer == System.IntPtr.Zero ? (List<Sprite>) null : new List<Sprite>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_Backgrounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BackgroundImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_BackgroundImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button BackgroundButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_BackgroundButton));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_BackgroundButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton BackButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_BackButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText LoadingMessage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LoadingMessage));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LoadingMessage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Initializing
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Initializing));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Initializing)) = value;
      }
    }

    public unsafe LocalizationKey LK_Authenticating
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Authenticating));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Authenticating)) = value;
      }
    }

    public unsafe LocalizationKey LK_StartingUp
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_StartingUp));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_StartingUp)) = value;
      }
    }

    public unsafe LocalizationKey LK_Connecting
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Connecting));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Connecting)) = value;
      }
    }

    public unsafe LocalizationKey LK_Loading
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Loading));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Loading)) = value;
      }
    }

    public unsafe LocalizationKey LK_PreWarmingShaders
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_PreWarmingShaders));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_PreWarmingShaders)) = value;
      }
    }

    public unsafe LocalizationKey LK_Ready
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Ready));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Ready)) = value;
      }
    }

    public unsafe LocalizationKey LK_Error
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Error));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_Error)) = value;
      }
    }

    public unsafe LocalizationKey LK_ServerStarting
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_ServerStarting));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_ServerStarting)) = value;
      }
    }

    public unsafe LocalizationKey LK_VersionMismatch
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_VersionMismatch));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LK_VersionMismatch)) = value;
      }
    }

    public unsafe LocalizedStatusMessagesAsset LocalizedStatusMessages
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LocalizedStatusMessages));
        return pointer == System.IntPtr.Zero ? (LocalizedStatusMessagesAsset) null : new LocalizedStatusMessagesAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_LocalizedStatusMessages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CharacterCreationScenePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_CharacterCreationScenePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr_CharacterCreationScenePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _ConnectStartedTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__ConnectStartedTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__ConnectStartedTime)) = value;
      }
    }

    public unsafe int _FramesSinceConnectStarted
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__FramesSinceConnectStarted));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__FramesSinceConnectStarted)) = value;
      }
    }

    public unsafe bool _ForceShowBackButton
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__ForceShowBackButton));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__ForceShowBackButton)) = value;
      }
    }

    public unsafe bool _Ready
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__Ready));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__Ready)) = value;
      }
    }

    public unsafe GameObject _CustomizationBrowser
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__CustomizationBrowser));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__CustomizationBrowser), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _FadeOut
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__FadeOut));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__FadeOut)) = value;
      }
    }

    public unsafe EditorSettings _EditorSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__EditorSettings));
        return pointer == System.IntPtr.Zero ? (EditorSettings) null : new EditorSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__EditorSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _GotoCharacterScreenDone
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__GotoCharacterScreenDone));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__GotoCharacterScreenDone)) = value;
      }
    }

    public unsafe GameBootstrap _GameBootstrap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__GameBootstrap));
        return pointer == System.IntPtr.Zero ? (GameBootstrap) null : new GameBootstrap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__GameBootstrap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<GameConnect> _GameConnect
    {
      get
      {
        return *(Nullable_Unboxed<GameConnect>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__GameConnect));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__GameConnect), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<GameConnect>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _BackgroundSpriteIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__BackgroundSpriteIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConnectingView.NativeFieldInfoPtr__BackgroundSpriteIndex)) = value;
      }
    }
  }
}
