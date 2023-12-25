// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Popup_DirectConnect
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using Stunlock.Fmod;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class Popup_DirectConnect : SimplePopupBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_PasswordInputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_CancelButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoadSpinner;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progressbar;
    private static readonly System.IntPtr NativeFieldInfoPtr_LanConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInfoNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDay;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OKColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerFoundSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerNotFoundSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessageText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LC_ServerCheckTimeout;
    private static readonly System.IntPtr NativeFieldInfoPtr_LC_Players;
    private static readonly System.IntPtr NativeFieldInfoPtr_LC_Day;
    private static readonly System.IntPtr NativeFieldInfoPtr_LC_GameVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryClient;
    private static readonly System.IntPtr NativeFieldInfoPtr__Servers;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryServerInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryResponseTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ValidInput;
    private static readonly System.IntPtr NativeFieldInfoPtr__FoundServer;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConnectServerInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_STEAM_ID_MASK;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DiscoveyTime_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleDiscoveryInProgress_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConnectToServer_Private_Boolean_ServerDiscoveryData_byref_TryConnectError_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChange_ServerInputField_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FocusInputField_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasValidServer_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasServer_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckInput_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPlatformId_Private_Boolean_String_byref_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServerAddressAndPort_Private_Boolean_String_byref_String_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Check_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Cancel_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Connect_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConnectToServer_Private_Boolean_UInt64_byref_TryConnectError_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConnectToServerIpv4_Private_Boolean_String_Int32_byref_TryConnectError_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_Connect_old_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendDiscovery_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearMessage_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMessage_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearServerInfo_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetServerInfo_Private_Void_ServerDiscoveryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe float DiscoveyTime
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285730, XrefRangeEnd = 1285731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_get_DiscoveyTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285731, XrefRangeEnd = 1285762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285762, XrefRangeEnd = 1285778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285778, XrefRangeEnd = 1285794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnShow()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Popup_DirectConnect.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285794, XrefRangeEnd = 1285834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1285980, RefRangeEnd = 1285981, XrefRangeStart = 1285834, XrefRangeEnd = 1285980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleDiscoveryInProgress()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_HandleDiscoveryInProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1286016, RefRangeEnd = 1286017, XrefRangeStart = 1285981, XrefRangeEnd = 1286016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryConnectToServer(
      ServerDiscoveryData server,
      out Popup_DirectConnect.TryConnectError status)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) server));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref status;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_TryConnectToServer_Private_Boolean_ServerDiscoveryData_byref_TryConnectError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286017, XrefRangeEnd = 1286020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValueChange_ServerInputField(string val)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(val);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_OnValueChange_ServerInputField_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286020, XrefRangeEnd = 1286022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FocusInputField()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_FocusInputField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool HasValidServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_HasValidServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool HasServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_HasServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1286026, RefRangeEnd = 1286028, XrefRangeStart = 1286022, XrefRangeEnd = 1286026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckInput()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_CheckInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286028, XrefRangeEnd = 1286030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetPlatformId(string input, out ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref platformId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_TryGetPlatformId_Private_Boolean_String_byref_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1286043, RefRangeEnd = 1286046, XrefRangeStart = 1286030, XrefRangeEnd = 1286043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetServerAddressAndPort(string input, out string host, out int port)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref port;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_TryGetServerAddressAndPort_Private_Boolean_String_byref_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      host = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286046, XrefRangeEnd = 1286047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Check()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Check_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 180802, RefRangeEnd = 180804, XrefRangeStart = 180802, XrefRangeEnd = 180804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Cancel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Cancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286047, XrefRangeEnd = 1286068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Connect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Connect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286068, XrefRangeEnd = 1286077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryConnectToServer(
      ulong platformId,
      out Popup_DirectConnect.TryConnectError status)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &platformId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref status;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_TryConnectToServer_Private_Boolean_UInt64_byref_TryConnectError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286077, XrefRangeEnd = 1286098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryConnectToServerIpv4(
      string address,
      int port,
      out Popup_DirectConnect.TryConnectError status)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(address);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &port;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref status;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_TryConnectToServerIpv4_Private_Boolean_String_Int32_byref_TryConnectError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286098, XrefRangeEnd = 1286111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_Connect_old()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Connect_old_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1286128, RefRangeEnd = 1286129, XrefRangeStart = 1286111, XrefRangeEnd = 1286128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendDiscovery()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_SendDiscovery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1286136, RefRangeEnd = 1286137, XrefRangeStart = 1286129, XrefRangeEnd = 1286136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearMessage()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_ClearMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286137, XrefRangeEnd = 1286141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMessage(LocalizationKey key)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &key;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_SetMessage_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1286148, RefRangeEnd = 1286152, XrefRangeStart = 1286141, XrefRangeEnd = 1286148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearServerInfo()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_ClearServerInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1286180, RefRangeEnd = 1286182, XrefRangeStart = 1286152, XrefRangeEnd = 1286180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetServerInfo(ServerDiscoveryData serverData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) serverData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr_SetServerInfo_Private_Void_ServerDiscoveryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Popup_DirectConnect.NativeMethodInfoPtr_HandleInput_Public_Virtual_Void_InputState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Popup_DirectConnect()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Popup_DirectConnect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Popup_DirectConnect()
    {
      Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (Popup_DirectConnect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr);
      Popup_DirectConnect.NativeFieldInfoPtr_ServerInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerInputField));
      Popup_DirectConnect.NativeFieldInfoPtr_PasswordInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (PasswordInputField));
      Popup_DirectConnect.NativeFieldInfoPtr_CheckButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (CheckButton));
      Popup_DirectConnect.NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (CancelButton));
      Popup_DirectConnect.NativeFieldInfoPtr_ConnectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ConnectButton));
      Popup_DirectConnect.NativeFieldInfoPtr_LoadSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (LoadSpinner));
      Popup_DirectConnect.NativeFieldInfoPtr_Progressbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (Progressbar));
      Popup_DirectConnect.NativeFieldInfoPtr_LanConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (LanConnection));
      Popup_DirectConnect.NativeFieldInfoPtr_ServerInfoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerInfoNode));
      Popup_DirectConnect.NativeFieldInfoPtr_ServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerName));
      Popup_DirectConnect.NativeFieldInfoPtr_ServerUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerUsers));
      Popup_DirectConnect.NativeFieldInfoPtr_ServerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerDay));
      Popup_DirectConnect.NativeFieldInfoPtr_ServerVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerVersion));
      Popup_DirectConnect.NativeFieldInfoPtr_ErrorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ErrorColor));
      Popup_DirectConnect.NativeFieldInfoPtr_OKColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (OKColor));
      Popup_DirectConnect.NativeFieldInfoPtr_ServerFoundSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerFoundSound));
      Popup_DirectConnect.NativeFieldInfoPtr_ServerNotFoundSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (ServerNotFoundSound));
      Popup_DirectConnect.NativeFieldInfoPtr_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (MessageText));
      Popup_DirectConnect.NativeFieldInfoPtr_LC_ServerCheckTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (LC_ServerCheckTimeout));
      Popup_DirectConnect.NativeFieldInfoPtr_LC_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (LC_Players));
      Popup_DirectConnect.NativeFieldInfoPtr_LC_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (LC_Day));
      Popup_DirectConnect.NativeFieldInfoPtr_LC_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (LC_GameVersion));
      Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_DiscoveryClient));
      Popup_DirectConnect.NativeFieldInfoPtr__Servers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_Servers));
      Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryServerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_DiscoveryServerInfo));
      Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_DiscoveryStartTime));
      Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryResponseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_DiscoveryResponseTime));
      Popup_DirectConnect.NativeFieldInfoPtr__ValidInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_ValidInput));
      Popup_DirectConnect.NativeFieldInfoPtr__FoundServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_FoundServer));
      Popup_DirectConnect.NativeFieldInfoPtr__GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_GameVersion));
      Popup_DirectConnect.NativeFieldInfoPtr__ConnectServerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (_ConnectServerInfo));
      Popup_DirectConnect.NativeFieldInfoPtr_STEAM_ID_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, nameof (STEAM_ID_MASK));
      Popup_DirectConnect.NativeMethodInfoPtr_get_DiscoveyTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669440);
      Popup_DirectConnect.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669441);
      Popup_DirectConnect.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669442);
      Popup_DirectConnect.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669443);
      Popup_DirectConnect.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669444);
      Popup_DirectConnect.NativeMethodInfoPtr_HandleDiscoveryInProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669445);
      Popup_DirectConnect.NativeMethodInfoPtr_TryConnectToServer_Private_Boolean_ServerDiscoveryData_byref_TryConnectError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669446);
      Popup_DirectConnect.NativeMethodInfoPtr_OnValueChange_ServerInputField_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669447);
      Popup_DirectConnect.NativeMethodInfoPtr_FocusInputField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669448);
      Popup_DirectConnect.NativeMethodInfoPtr_HasValidServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669449);
      Popup_DirectConnect.NativeMethodInfoPtr_HasServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669450);
      Popup_DirectConnect.NativeMethodInfoPtr_CheckInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669451);
      Popup_DirectConnect.NativeMethodInfoPtr_TryGetPlatformId_Private_Boolean_String_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669452);
      Popup_DirectConnect.NativeMethodInfoPtr_TryGetServerAddressAndPort_Private_Boolean_String_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669453);
      Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Check_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669454);
      Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Cancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669455);
      Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Connect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669456);
      Popup_DirectConnect.NativeMethodInfoPtr_TryConnectToServer_Private_Boolean_UInt64_byref_TryConnectError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669457);
      Popup_DirectConnect.NativeMethodInfoPtr_TryConnectToServerIpv4_Private_Boolean_String_Int32_byref_TryConnectError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669458);
      Popup_DirectConnect.NativeMethodInfoPtr_OnButtonClick_Connect_old_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669459);
      Popup_DirectConnect.NativeMethodInfoPtr_SendDiscovery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669460);
      Popup_DirectConnect.NativeMethodInfoPtr_ClearMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669461);
      Popup_DirectConnect.NativeMethodInfoPtr_SetMessage_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669462);
      Popup_DirectConnect.NativeMethodInfoPtr_ClearServerInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669463);
      Popup_DirectConnect.NativeMethodInfoPtr_SetServerInfo_Private_Void_ServerDiscoveryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669464);
      Popup_DirectConnect.NativeMethodInfoPtr_HandleInput_Public_Virtual_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669465);
      Popup_DirectConnect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup_DirectConnect>.NativeClassPtr, 100669466);
    }

    public Popup_DirectConnect(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_InputField ServerInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField PasswordInputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_PasswordInputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_PasswordInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CheckButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_CheckButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_CheckButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton CancelButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_CancelButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_CancelButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ConnectButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ConnectButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ConnectButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform LoadSpinner
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LoadSpinner));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LoadSpinner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Progressbar
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_Progressbar));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_Progressbar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle LanConnection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LanConnection));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LanConnection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ServerInfoNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerInfoNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerInfoNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerName));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerUsers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerUsers));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerUsers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerDay
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerDay));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerDay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerVersion
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerVersion));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerVersion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color ErrorColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ErrorColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ErrorColor)) = value;
      }
    }

    public unsafe Color OKColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_OKColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_OKColor)) = value;
      }
    }

    public FmodEvent ServerFoundSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerFoundSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerFoundSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FmodEvent ServerNotFoundSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerNotFoundSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_ServerNotFoundSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LocalizedText MessageText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_MessageText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_MessageText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LC_ServerCheckTimeout
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_ServerCheckTimeout));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_ServerCheckTimeout)) = value;
      }
    }

    public unsafe LocalizationKey LC_Players
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_Players));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_Players)) = value;
      }
    }

    public unsafe LocalizationKey LC_Day
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_Day));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_Day)) = value;
      }
    }

    public unsafe LocalizationKey LC_GameVersion
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_GameVersion));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr_LC_GameVersion)) = value;
      }
    }

    public unsafe DiscoveryClient _DiscoveryClient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryClient));
        return pointer == System.IntPtr.Zero ? (DiscoveryClient) null : new DiscoveryClient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryClient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ServerInfo> _Servers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__Servers));
        return pointer == System.IntPtr.Zero ? (List<ServerInfo>) null : new List<ServerInfo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__Servers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.Nullable<ServerInfo> _DiscoveryServerInfo
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryServerInfo);
        return new Il2CppSystem.Nullable<ServerInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryServerInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float _DiscoveryStartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryStartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryStartTime)) = value;
      }
    }

    public unsafe float _DiscoveryResponseTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryResponseTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__DiscoveryResponseTime)) = value;
      }
    }

    public unsafe bool _ValidInput
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__ValidInput));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__ValidInput)) = value;
      }
    }

    public ServerDiscoveryData _FoundServer
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__FoundServer);
        return new ServerDiscoveryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__FoundServer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerDiscoveryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _GameVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__GameVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__GameVersion)) = value;
      }
    }

    public Il2CppSystem.Nullable<ServerInfo> _ConnectServerInfo
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__ConnectServerInfo);
        return new Il2CppSystem.Nullable<ServerInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Popup_DirectConnect.NativeFieldInfoPtr__ConnectServerInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ServerInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe ulong STEAM_ID_MASK
    {
      get
      {
        ulong steamIdMask;
        IL2CPP.il2cpp_field_static_get_value(Popup_DirectConnect.NativeFieldInfoPtr_STEAM_ID_MASK, (void*) &steamIdMask);
        return steamIdMask;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Popup_DirectConnect.NativeFieldInfoPtr_STEAM_ID_MASK, (void*) &value);
      }
    }

    public enum TryConnectError
    {
      None,
      InvalidIpAddress,
      InvalidPort,
      WrongVersion,
      ServerFull,
    }
  }
}
