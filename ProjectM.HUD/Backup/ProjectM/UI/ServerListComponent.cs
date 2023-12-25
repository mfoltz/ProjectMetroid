// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ServerListComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ServerListComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Servers;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerEntriesParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerListEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideFullServersCheckbox;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefreshListButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_JoinServerButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__Entries;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientNetworkVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__DiscoveryClient;
    private static readonly System.IntPtr NativeFieldInfoPtr__SendDiscoveryTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalServerList;
    private static readonly System.IntPtr NativeFieldInfoPtr__DownloadedServerList;
    private static readonly System.IntPtr NativeFieldInfoPtr__WebRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__DownloadedServerListTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_LIST_FILE_MAX_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_serverDiscoveryDatas;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChange_HideServers_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_RefreshList_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonClick_JoinServer_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendDiscoveryStuff_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendDiscoveryMessages_Private_Void_List_1_ServerInfo_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartFetchServerListURL_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearWebRequest_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddFromLocalConfigFile_Private_Void_List_1_ServerInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddServersToList_Private_Void_String_List_1_ServerInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddFromAsset_Private_Void_List_1_ServerInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshList_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEntrySelected_Private_Void_ServerListEntryComponent_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286859, XrefRangeEnd = 1286886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286886, XrefRangeEnd = 1286901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValueChange_HideServers(bool boolValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &boolValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_OnValueChange_HideServers_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286901, XrefRangeEnd = 1286925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286925, XrefRangeEnd = 1286928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286928, XrefRangeEnd = 1286931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_RefreshList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_OnButtonClick_RefreshList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286931, XrefRangeEnd = 1286947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnButtonClick_JoinServer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_OnButtonClick_JoinServer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1286987, RefRangeEnd = 1286988, XrefRangeStart = 1286947, XrefRangeEnd = 1286987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendDiscoveryStuff(bool discoverLocalPeers = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &discoverLocalPeers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_SendDiscoveryStuff_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1286998, RefRangeEnd = 1287001, XrefRangeStart = 1286988, XrefRangeEnd = 1286998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendDiscoveryMessages(List<ServerInfo> serverList, bool discoverLocalPeers)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverList);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &discoverLocalPeers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_SendDiscoveryMessages_Private_Void_List_1_ServerInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287001, XrefRangeEnd = 1287022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartFetchServerListURL()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_StartFetchServerListURL_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearWebRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_ClearWebRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287052, RefRangeEnd = 1287053, XrefRangeStart = 1287022, XrefRangeEnd = 1287052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddFromLocalConfigFile(List<ServerInfo> serverList)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverList);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_AddFromLocalConfigFile_Private_Void_List_1_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1287075, RefRangeEnd = 1287076, XrefRangeStart = 1287053, XrefRangeEnd = 1287075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddServersToList(string fileContent, List<ServerInfo> serverList)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fileContent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverList);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_AddServersToList_Private_Void_String_List_1_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287076, XrefRangeEnd = 1287094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddFromAsset(List<ServerInfo> serverInfos)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverInfos);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_AddFromAsset_Private_Void_List_1_ServerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1287101, RefRangeEnd = 1287103, XrefRangeStart = 1287094, XrefRangeEnd = 1287101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshList(bool discoverLocalPeers = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &discoverLocalPeers;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_RefreshList_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287103, XrefRangeEnd = 1287244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287244, XrefRangeEnd = 1287252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEntrySelected(ServerListEntryComponent entry, int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr_OnEntrySelected_Private_Void_ServerListEntryComponent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287252, XrefRangeEnd = 1287272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerListComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerListComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerListComponent()
    {
      Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ServerListComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr);
      ServerListComponent.NativeFieldInfoPtr_Servers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (Servers));
      ServerListComponent.NativeFieldInfoPtr_ServerEntriesParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (ServerEntriesParent));
      ServerListComponent.NativeFieldInfoPtr_ServerListEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (ServerListEntryPrefab));
      ServerListComponent.NativeFieldInfoPtr_HideFullServersCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (HideFullServersCheckbox));
      ServerListComponent.NativeFieldInfoPtr_RefreshListButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (RefreshListButton));
      ServerListComponent.NativeFieldInfoPtr_JoinServerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (JoinServerButton));
      ServerListComponent.NativeFieldInfoPtr__Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_Entries));
      ServerListComponent.NativeFieldInfoPtr__SelectedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_SelectedEntry));
      ServerListComponent.NativeFieldInfoPtr__ClientNetworkVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_ClientNetworkVersion));
      ServerListComponent.NativeFieldInfoPtr__SelectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_SelectedIndex));
      ServerListComponent.NativeFieldInfoPtr__DiscoveryClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_DiscoveryClient));
      ServerListComponent.NativeFieldInfoPtr__SendDiscoveryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_SendDiscoveryTime));
      ServerListComponent.NativeFieldInfoPtr__LocalServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_LocalServerList));
      ServerListComponent.NativeFieldInfoPtr__DownloadedServerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_DownloadedServerList));
      ServerListComponent.NativeFieldInfoPtr__WebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_WebRequest));
      ServerListComponent.NativeFieldInfoPtr__DownloadedServerListTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (_DownloadedServerListTime));
      ServerListComponent.NativeFieldInfoPtr_SERVER_LIST_FILE_MAX_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (SERVER_LIST_FILE_MAX_SIZE));
      ServerListComponent.NativeFieldInfoPtr_serverDiscoveryDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, nameof (serverDiscoveryDatas));
      ServerListComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669490);
      ServerListComponent.NativeMethodInfoPtr_OnValueChange_HideServers_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669491);
      ServerListComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669492);
      ServerListComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669493);
      ServerListComponent.NativeMethodInfoPtr_OnButtonClick_RefreshList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669494);
      ServerListComponent.NativeMethodInfoPtr_OnButtonClick_JoinServer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669495);
      ServerListComponent.NativeMethodInfoPtr_SendDiscoveryStuff_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669496);
      ServerListComponent.NativeMethodInfoPtr_SendDiscoveryMessages_Private_Void_List_1_ServerInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669497);
      ServerListComponent.NativeMethodInfoPtr_StartFetchServerListURL_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669498);
      ServerListComponent.NativeMethodInfoPtr_ClearWebRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669499);
      ServerListComponent.NativeMethodInfoPtr_AddFromLocalConfigFile_Private_Void_List_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669500);
      ServerListComponent.NativeMethodInfoPtr_AddServersToList_Private_Void_String_List_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669501);
      ServerListComponent.NativeMethodInfoPtr_AddFromAsset_Private_Void_List_1_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669502);
      ServerListComponent.NativeMethodInfoPtr_RefreshList_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669503);
      ServerListComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669504);
      ServerListComponent.NativeMethodInfoPtr_OnEntrySelected_Private_Void_ServerListEntryComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669505);
      ServerListComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, 100669506);
    }

    public ServerListComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ServerListDataEntry> Servers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_Servers));
        return pointer == System.IntPtr.Zero ? (List<ServerListDataEntry>) null : new List<ServerListDataEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_Servers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ServerEntriesParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_ServerEntriesParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_ServerEntriesParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerListEntryComponent ServerListEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_ServerListEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ServerListEntryComponent) null : new ServerListEntryComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_ServerListEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle HideFullServersCheckbox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_HideFullServersCheckbox));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_HideFullServersCheckbox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton RefreshListButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_RefreshListButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_RefreshListButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton JoinServerButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_JoinServerButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_JoinServerButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<ServerListEntryComponent> _Entries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__Entries));
        return pointer == System.IntPtr.Zero ? (UI_Cache<ServerListEntryComponent>) null : new UI_Cache<ServerListEntryComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerListEntryComponent _SelectedEntry
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__SelectedEntry));
        return pointer == System.IntPtr.Zero ? (ServerListEntryComponent) null : new ServerListEntryComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__SelectedEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _ClientNetworkVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__ClientNetworkVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__ClientNetworkVersion)) = value;
      }
    }

    public unsafe int _SelectedIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__SelectedIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__SelectedIndex)) = value;
      }
    }

    public unsafe DiscoveryClient _DiscoveryClient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__DiscoveryClient));
        return pointer == System.IntPtr.Zero ? (DiscoveryClient) null : new DiscoveryClient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__DiscoveryClient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _SendDiscoveryTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__SendDiscoveryTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__SendDiscoveryTime)) = value;
      }
    }

    public unsafe List<ServerInfo> _LocalServerList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__LocalServerList));
        return pointer == System.IntPtr.Zero ? (List<ServerInfo>) null : new List<ServerInfo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__LocalServerList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ServerInfo> _DownloadedServerList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__DownloadedServerList));
        return pointer == System.IntPtr.Zero ? (List<ServerInfo>) null : new List<ServerInfo>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__DownloadedServerList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityWebRequest _WebRequest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__WebRequest));
        return pointer == System.IntPtr.Zero ? (UnityWebRequest) null : new UnityWebRequest(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__WebRequest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _DownloadedServerListTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__DownloadedServerListTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr__DownloadedServerListTime)) = value;
      }
    }

    public static unsafe int SERVER_LIST_FILE_MAX_SIZE
    {
      get
      {
        int serverListFileMaxSize;
        IL2CPP.il2cpp_field_static_get_value(ServerListComponent.NativeFieldInfoPtr_SERVER_LIST_FILE_MAX_SIZE, (void*) &serverListFileMaxSize);
        return serverListFileMaxSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerListComponent.NativeFieldInfoPtr_SERVER_LIST_FILE_MAX_SIZE, (void*) &value);
      }
    }

    public unsafe List<ServerDiscoveryData> serverDiscoveryDatas
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_serverDiscoveryDatas));
        return pointer == System.IntPtr.Zero ? (List<ServerDiscoveryData>) null : new List<ServerDiscoveryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerListComponent.NativeFieldInfoPtr_serverDiscoveryDatas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.ServerListComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__32_0_Internal_Int32_ServerDiscoveryData_ServerDiscoveryData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerListComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286857, XrefRangeEnd = 1286859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Update_b__32_0(ServerDiscoveryData a, ServerDiscoveryData b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerListComponent.__c.NativeMethodInfoPtr__Update_b__32_0_Internal_Int32_ServerDiscoveryData_ServerDiscoveryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServerListComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListComponent.__c>.NativeClassPtr);
        ServerListComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent.__c>.NativeClassPtr, "<>9");
        ServerListComponent.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListComponent.__c>.NativeClassPtr, "<>9__32_0");
        ServerListComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent.__c>.NativeClassPtr, 100669508);
        ServerListComponent.__c.NativeMethodInfoPtr__Update_b__32_0_Internal_Int32_ServerDiscoveryData_ServerDiscoveryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListComponent.__c>.NativeClassPtr, 100669509);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServerListComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServerListComponent.__c) null : new ServerListComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<ServerDiscoveryData> __9__32_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerListComponent.__c.NativeFieldInfoPtr___9__32_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<ServerDiscoveryData>) null : new Il2CppSystem.Comparison<ServerDiscoveryData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerListComponent.__c.NativeFieldInfoPtr___9__32_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
