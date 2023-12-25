// Decompiled with JetBrains decompiler
// Type: ProjectM.VivoxClientSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using VivoxUnity;

#nullable disable
namespace ProjectM
{
  public class VivoxClientSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Instance;
    private static readonly System.IntPtr NativeFieldInfoPtr__SoundSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MutePlayerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__APIEndpoint_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_Client;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoginSession;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChannelSession;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceChannelHandler;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChannelHandler;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentVolume;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsClientInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoVOIPServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoggingEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShouldSendChannelEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_TalkPressed;
    private static readonly System.IntPtr NativeFieldInfoPtr_InternalState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShouldDisconnect;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsePushToTalk;
    private static readonly System.IntPtr NativeFieldInfoPtr_TryConnect;
    private static readonly System.IntPtr NativeFieldInfoPtr_SinceLastPosUpdate;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Username;
    private static readonly System.IntPtr NativeFieldInfoPtr_VivoxDomain;
    private static readonly System.IntPtr NativeFieldInfoPtr_Issuer;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerChannel;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSpeaking;
    private static readonly System.IntPtr NativeFieldInfoPtr__CameraUserQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserInfosToUpdate;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoggingIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoggedIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoggedOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoggingOut;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_APIEndpoint_Public_Static_get_Uri_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_APIEndpoint_Public_Static_set_Void_Uri_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_LoggingIn_Public_Static_add_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_LoggingIn_Public_Static_rem_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_LoggedIn_Public_Static_add_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_LoggedIn_Public_Static_rem_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_LoggedOut_Public_Static_add_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_LoggedOut_Public_Static_rem_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_LoggingOut_Public_Static_add_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_LoggingOut_Public_Static_rem_Void_Action_1_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateUserInfo_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryLoginToVivox_Public_Static_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDevices_Public_Int32_List_1_Tuple_2_String_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDevice_Public_Void_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeClient_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubscribeToVivoxEvents_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoginToVivox_Public_Void_String_String_String_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogoutOfVivox_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinChannel_Public_Void_String_String_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LeaveChannel_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Void_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Void_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoggingIn_Private_Void_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoggedIn_Private_Void_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoggingOut_Private_Void_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoggedOut_Private_Void_ILoginSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVoiceConnecting_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVoiceConnected_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVoiceDisconnecting_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnVoiceDisconnected_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelConnecting_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelConnected_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelDisconnecting_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnChannelDisconnected_Public_Virtual_New_Void_IChannelSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnLoginPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustVolume_Private_Void_IAudioDevices_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__46_0_Private_Void_Entity_byref_ServerRejectEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__46_1_Private_Void_Entity_byref_ServerLoginEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__46_2_Private_Void_Entity_byref_ServerChannelEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__46_3_Private_Void_Entity_byref_ServerLoginEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__46_4_Private_Void_Entity_byref_ServerChannelEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__46_5_Private_Void_IAsyncResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__46_6_Private_Void_IAsyncResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetDevice_b__51_0_Private_Void_IAsyncResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetDevice_b__51_1_Private_Void_IAsyncResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__LoginToVivox_b__54_0_Private_Void_IAsyncResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__JoinChannel_b__56_0_Private_Void_IAsyncResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__JoinChannel_b__56_1_Private_Void_IAsyncResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateUserInfo_FindUsersToUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateUserInfo_ActuallyUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    public static unsafe Uri APIEndpoint
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079470, XrefRangeEnd = 1079474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_get_APIEndpoint_Public_Static_get_Uri_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Uri) null : new Uri(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079474, XrefRangeEnd = 1079479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_set_APIEndpoint_Public_Static_set_Void_Uri_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079479, XrefRangeEnd = 1079490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_LoggingIn(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_add_LoggingIn_Public_Static_add_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079490, XrefRangeEnd = 1079501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_LoggingIn(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_remove_LoggingIn_Public_Static_rem_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079501, XrefRangeEnd = 1079512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_LoggedIn(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_add_LoggedIn_Public_Static_add_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079512, XrefRangeEnd = 1079523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_LoggedIn(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_remove_LoggedIn_Public_Static_rem_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079523, XrefRangeEnd = 1079534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_LoggedOut(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_add_LoggedOut_Public_Static_add_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079534, XrefRangeEnd = 1079545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_LoggedOut(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_remove_LoggedOut_Public_Static_rem_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079545, XrefRangeEnd = 1079556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void add_LoggingOut(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_add_LoggingOut_Public_Static_add_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079556, XrefRangeEnd = 1079567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public static unsafe void remove_LoggingOut(Il2CppSystem.Action<ILoginSession> value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_remove_LoggingOut_Public_Static_rem_Void_Action_1_ILoginSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079567, XrefRangeEnd = 1079759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1079794, RefRangeEnd = 1079795, XrefRangeStart = 1079759, XrefRangeEnd = 1079794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateUserInfo()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_UpdateUserInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079795, XrefRangeEnd = 1079805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryLoginToVivox(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_TryLoginToVivox_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079805, XrefRangeEnd = 1079830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1079907, RefRangeEnd = 1079909, XrefRangeStart = 1079830, XrefRangeEnd = 1079907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetDevices(List<Il2CppSystem.Tuple<string, string>> options, bool Input)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &Input;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_GetDevices_Public_Int32_List_1_Tuple_2_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1079966, RefRangeEnd = 1079968, XrefRangeStart = 1079909, XrefRangeEnd = 1079966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDevice(string devicekey, bool Input)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(devicekey);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &Input;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_SetDevice_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1079993, RefRangeEnd = 1079994, XrefRangeStart = 1079968, XrefRangeEnd = 1079993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeClient()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_InitializeClient_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1080051, RefRangeEnd = 1080052, XrefRangeStart = 1079994, XrefRangeEnd = 1080051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SubscribeToVivoxEvents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_SubscribeToVivoxEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1080092, RefRangeEnd = 1080093, XrefRangeStart = 1080052, XrefRangeEnd = 1080092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoginToVivox(
      string userName,
      string token,
      string issuer,
      string domain,
      bool joinMuted = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(userName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(token);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(issuer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(domain);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &joinMuted;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_LoginToVivox_Public_Void_String_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080093, XrefRangeEnd = 1080105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogoutOfVivox()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_LogoutOfVivox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1080142, RefRangeEnd = 1080143, XrefRangeStart = 1080105, XrefRangeEnd = 1080142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinChannel(
      string token,
      string channelSIP,
      bool switchTransmissionToThisChannel,
      bool joinMuted = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(token);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(channelSIP);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &switchTransmissionToThisChannel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &joinMuted;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_JoinChannel_Public_Void_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080143, XrefRangeEnd = 1080152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LeaveChannel()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_LeaveChannel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080152, XrefRangeEnd = 1080162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Subscribe(ILoginSession loginSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_Subscribe_Public_Void_ILoginSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1080172, RefRangeEnd = 1080173, XrefRangeStart = 1080162, XrefRangeEnd = 1080172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Unsubscribe(ILoginSession loginSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_Unsubscribe_Public_Void_ILoginSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080173, XrefRangeEnd = 1080190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnLoggingIn(ILoginSession loginSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_OnLoggingIn_Private_Void_ILoginSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080190, XrefRangeEnd = 1080208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnLoggedIn(ILoginSession loginSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_OnLoggedIn_Private_Void_ILoginSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080208, XrefRangeEnd = 1080225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnLoggingOut(ILoginSession loginSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_OnLoggingOut_Private_Void_ILoginSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080225, XrefRangeEnd = 1080252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnLoggedOut(ILoginSession loginSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loginSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_OnLoggedOut_Private_Void_ILoginSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080252, XrefRangeEnd = 1080263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnVoiceConnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnVoiceConnecting_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080263, XrefRangeEnd = 1080278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnVoiceConnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnVoiceConnected_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080278, XrefRangeEnd = 1080289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnVoiceDisconnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnVoiceDisconnecting_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080289, XrefRangeEnd = 1080300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnVoiceDisconnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnVoiceDisconnected_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080300, XrefRangeEnd = 1080311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnChannelConnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnChannelConnecting_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080311, XrefRangeEnd = 1080330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnChannelConnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnChannelConnected_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080330, XrefRangeEnd = 1080341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnChannelDisconnecting(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnChannelDisconnecting_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080341, XrefRangeEnd = 1080352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnChannelDisconnected(IChannelSession channelSession)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) channelSession);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnChannelDisconnected_Public_Virtual_New_Void_IChannelSession_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080352, XrefRangeEnd = 1080367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnLoginPropertyChanged(Il2CppSystem.Object sender, PropertyChangedEventArgs propArgs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sender);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) propArgs);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_OnLoginPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080367, XrefRangeEnd = 1080382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AdjustVolume(IAudioDevices devices, float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) devices);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_AdjustVolume_Private_Void_IAudioDevices_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080382, XrefRangeEnd = 1080384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080384, XrefRangeEnd = 1080387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080387, XrefRangeEnd = 1080389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080389, XrefRangeEnd = 1080401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080401, XrefRangeEnd = 1080417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VivoxClientSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1080425, RefRangeEnd = 1080427, XrefRangeStart = 1080417, XrefRangeEnd = 1080425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__46_0(
      Entity entity,
      [In] ref VivoxEvents.ServerRejectEvent loginEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_0_Private_Void_Entity_byref_ServerRejectEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1080431, RefRangeEnd = 1080433, XrefRangeStart = 1080427, XrefRangeEnd = 1080431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__46_1(Entity entity, [In] ref VivoxEvents.ServerLoginEvent loginEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_1_Private_Void_Entity_byref_ServerLoginEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1080437, RefRangeEnd = 1080439, XrefRangeStart = 1080433, XrefRangeEnd = 1080437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__46_2(
      Entity entity,
      [In] ref VivoxEvents.ServerChannelEvent loginEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_2_Private_Void_Entity_byref_ServerChannelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1080469, RefRangeEnd = 1080471, XrefRangeStart = 1080439, XrefRangeEnd = 1080469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__46_3(Entity entity, [In] ref VivoxEvents.ServerLoginEvent loginEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_3_Private_Void_Entity_byref_ServerLoginEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1080484, RefRangeEnd = 1080486, XrefRangeStart = 1080471, XrefRangeEnd = 1080484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__46_4(
      Entity entity,
      [In] ref VivoxEvents.ServerChannelEvent channelEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref channelEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_4_Private_Void_Entity_byref_ServerChannelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080486, XrefRangeEnd = 1080495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__46_5(Il2CppSystem.IAsyncResult ar)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ar);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_5_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080495, XrefRangeEnd = 1080504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__46_6(Il2CppSystem.IAsyncResult ar)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ar);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_6_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080504, XrefRangeEnd = 1080513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetDevice_b__51_0(Il2CppSystem.IAsyncResult ar)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ar);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__SetDevice_b__51_0_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080513, XrefRangeEnd = 1080522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetDevice_b__51_1(Il2CppSystem.IAsyncResult ar)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ar);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__SetDevice_b__51_1_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080522, XrefRangeEnd = 1080532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _LoginToVivox_b__54_0(Il2CppSystem.IAsyncResult ar)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ar);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__LoginToVivox_b__54_0_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080532, XrefRangeEnd = 1080551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _JoinChannel_b__56_0(Il2CppSystem.IAsyncResult ar)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ar);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__JoinChannel_b__56_0_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080551, XrefRangeEnd = 1080562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _JoinChannel_b__56_1(Il2CppSystem.IAsyncResult asyncres)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asyncres);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr__JoinChannel_b__56_1_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080562, XrefRangeEnd = 1080720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VivoxClientSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080720, XrefRangeEnd = 1080736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080736, XrefRangeEnd = 1080752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080752, XrefRangeEnd = 1080768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080768, XrefRangeEnd = 1080784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080784, XrefRangeEnd = 1080800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob4_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080800, XrefRangeEnd = 1080816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateUserInfo_FindUsersToUpdate_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUserInfo_FindUsersToUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080816, XrefRangeEnd = 1080832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateUserInfo_ActuallyUpdate_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUserInfo_ActuallyUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1080836, RefRangeEnd = 1080837, XrefRangeStart = 1080832, XrefRangeEnd = 1080836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VivoxClientSystem()
    {
      Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VivoxClientSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr);
      VivoxClientSystem.NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_Instance));
      VivoxClientSystem.NativeFieldInfoPtr__SoundSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_SoundSettings));
      VivoxClientSystem.NativeFieldInfoPtr__ClientSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_ClientSettings));
      VivoxClientSystem.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_InputSystem));
      VivoxClientSystem.NativeFieldInfoPtr__MutePlayerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_MutePlayerSystem));
      VivoxClientSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      VivoxClientSystem.NativeFieldInfoPtr__APIEndpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<APIEndpoint>k__BackingField");
      VivoxClientSystem.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (Client));
      VivoxClientSystem.NativeFieldInfoPtr_LoginSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (LoginSession));
      VivoxClientSystem.NativeFieldInfoPtr_ChannelSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (ChannelSession));
      VivoxClientSystem.NativeFieldInfoPtr_VoiceChannelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (VoiceChannelHandler));
      VivoxClientSystem.NativeFieldInfoPtr_ChannelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (ChannelHandler));
      VivoxClientSystem.NativeFieldInfoPtr_CurrentVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (CurrentVolume));
      VivoxClientSystem.NativeFieldInfoPtr_IsClientInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (IsClientInitialized));
      VivoxClientSystem.NativeFieldInfoPtr_NoVOIPServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (NoVOIPServer));
      VivoxClientSystem.NativeFieldInfoPtr_LoggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (LoggingEnabled));
      VivoxClientSystem.NativeFieldInfoPtr_ShouldSendChannelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (ShouldSendChannelEvent));
      VivoxClientSystem.NativeFieldInfoPtr_TalkPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (TalkPressed));
      VivoxClientSystem.NativeFieldInfoPtr_InternalState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (InternalState));
      VivoxClientSystem.NativeFieldInfoPtr_ShouldDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (ShouldDisconnect));
      VivoxClientSystem.NativeFieldInfoPtr_UsePushToTalk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (UsePushToTalk));
      VivoxClientSystem.NativeFieldInfoPtr_TryConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (TryConnect));
      VivoxClientSystem.NativeFieldInfoPtr_SinceLastPosUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (SinceLastPosUpdate));
      VivoxClientSystem.NativeFieldInfoPtr_TimeSinceRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (TimeSinceRequest));
      VivoxClientSystem.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (Username));
      VivoxClientSystem.NativeFieldInfoPtr_VivoxDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (VivoxDomain));
      VivoxClientSystem.NativeFieldInfoPtr_Issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (Issuer));
      VivoxClientSystem.NativeFieldInfoPtr_ServerChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (ServerChannel));
      VivoxClientSystem.NativeFieldInfoPtr_IsSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (IsSpeaking));
      VivoxClientSystem.NativeFieldInfoPtr__CameraUserQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_CameraUserQuery));
      VivoxClientSystem.NativeFieldInfoPtr__UserInfosToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (_UserInfosToUpdate));
      VivoxClientSystem.NativeFieldInfoPtr_LoggingIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (LoggingIn));
      VivoxClientSystem.NativeFieldInfoPtr_LoggedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (LoggedIn));
      VivoxClientSystem.NativeFieldInfoPtr_LoggedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (LoggedOut));
      VivoxClientSystem.NativeFieldInfoPtr_LoggingOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, nameof (LoggingOut));
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob3_entityQuery");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob3_profilerMarker");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob4_entityQuery");
      VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob4_profilerMarker");
      VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>UpdateUserInfo_FindUsersToUpdate_entityQuery");
      VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>UpdateUserInfo_FindUsersToUpdate_profilerMarker");
      VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>UpdateUserInfo_ActuallyUpdate_entityQuery");
      VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>UpdateUserInfo_ActuallyUpdate_profilerMarker");
      VivoxClientSystem.NativeMethodInfoPtr_get_APIEndpoint_Public_Static_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684973);
      VivoxClientSystem.NativeMethodInfoPtr_set_APIEndpoint_Public_Static_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684974);
      VivoxClientSystem.NativeMethodInfoPtr_add_LoggingIn_Public_Static_add_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684975);
      VivoxClientSystem.NativeMethodInfoPtr_remove_LoggingIn_Public_Static_rem_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684976);
      VivoxClientSystem.NativeMethodInfoPtr_add_LoggedIn_Public_Static_add_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684977);
      VivoxClientSystem.NativeMethodInfoPtr_remove_LoggedIn_Public_Static_rem_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684978);
      VivoxClientSystem.NativeMethodInfoPtr_add_LoggedOut_Public_Static_add_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684979);
      VivoxClientSystem.NativeMethodInfoPtr_remove_LoggedOut_Public_Static_rem_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684980);
      VivoxClientSystem.NativeMethodInfoPtr_add_LoggingOut_Public_Static_add_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684981);
      VivoxClientSystem.NativeMethodInfoPtr_remove_LoggingOut_Public_Static_rem_Void_Action_1_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684982);
      VivoxClientSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684983);
      VivoxClientSystem.NativeMethodInfoPtr_UpdateUserInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684984);
      VivoxClientSystem.NativeMethodInfoPtr_TryLoginToVivox_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684985);
      VivoxClientSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684986);
      VivoxClientSystem.NativeMethodInfoPtr_GetDevices_Public_Int32_List_1_Tuple_2_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684987);
      VivoxClientSystem.NativeMethodInfoPtr_SetDevice_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684988);
      VivoxClientSystem.NativeMethodInfoPtr_InitializeClient_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684989);
      VivoxClientSystem.NativeMethodInfoPtr_SubscribeToVivoxEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684990);
      VivoxClientSystem.NativeMethodInfoPtr_LoginToVivox_Public_Void_String_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684991);
      VivoxClientSystem.NativeMethodInfoPtr_LogoutOfVivox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684992);
      VivoxClientSystem.NativeMethodInfoPtr_JoinChannel_Public_Void_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684993);
      VivoxClientSystem.NativeMethodInfoPtr_LeaveChannel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684994);
      VivoxClientSystem.NativeMethodInfoPtr_Subscribe_Public_Void_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684995);
      VivoxClientSystem.NativeMethodInfoPtr_Unsubscribe_Public_Void_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684996);
      VivoxClientSystem.NativeMethodInfoPtr_OnLoggingIn_Private_Void_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684997);
      VivoxClientSystem.NativeMethodInfoPtr_OnLoggedIn_Private_Void_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684998);
      VivoxClientSystem.NativeMethodInfoPtr_OnLoggingOut_Private_Void_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100684999);
      VivoxClientSystem.NativeMethodInfoPtr_OnLoggedOut_Private_Void_ILoginSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685000);
      VivoxClientSystem.NativeMethodInfoPtr_OnVoiceConnecting_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685001);
      VivoxClientSystem.NativeMethodInfoPtr_OnVoiceConnected_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685002);
      VivoxClientSystem.NativeMethodInfoPtr_OnVoiceDisconnecting_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685003);
      VivoxClientSystem.NativeMethodInfoPtr_OnVoiceDisconnected_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685004);
      VivoxClientSystem.NativeMethodInfoPtr_OnChannelConnecting_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685005);
      VivoxClientSystem.NativeMethodInfoPtr_OnChannelConnected_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685006);
      VivoxClientSystem.NativeMethodInfoPtr_OnChannelDisconnecting_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685007);
      VivoxClientSystem.NativeMethodInfoPtr_OnChannelDisconnected_Public_Virtual_New_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685008);
      VivoxClientSystem.NativeMethodInfoPtr_OnLoginPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685009);
      VivoxClientSystem.NativeMethodInfoPtr_AdjustVolume_Private_Void_IAudioDevices_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685010);
      VivoxClientSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685011);
      VivoxClientSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685012);
      VivoxClientSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685013);
      VivoxClientSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685014);
      VivoxClientSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685015);
      VivoxClientSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685016);
      VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_0_Private_Void_Entity_byref_ServerRejectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685018);
      VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_1_Private_Void_Entity_byref_ServerLoginEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685019);
      VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_2_Private_Void_Entity_byref_ServerChannelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685020);
      VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_3_Private_Void_Entity_byref_ServerLoginEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685021);
      VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_4_Private_Void_Entity_byref_ServerChannelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685022);
      VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_5_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685023);
      VivoxClientSystem.NativeMethodInfoPtr__OnUpdate_b__46_6_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685024);
      VivoxClientSystem.NativeMethodInfoPtr__SetDevice_b__51_0_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685025);
      VivoxClientSystem.NativeMethodInfoPtr__SetDevice_b__51_1_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685026);
      VivoxClientSystem.NativeMethodInfoPtr__LoginToVivox_b__54_0_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685027);
      VivoxClientSystem.NativeMethodInfoPtr__JoinChannel_b__56_0_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685028);
      VivoxClientSystem.NativeMethodInfoPtr__JoinChannel_b__56_1_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685029);
      VivoxClientSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685030);
      VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685031);
      VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685032);
      VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685033);
      VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685034);
      VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685035);
      VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUserInfo_FindUsersToUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685036);
      VivoxClientSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateUserInfo_ActuallyUpdate_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685037);
      VivoxClientSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, 100685038);
    }

    public VivoxClientSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe VivoxClientSystem _Instance
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr__Instance, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr__Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SoundSettings _SoundSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__SoundSettings));
        return pointer == System.IntPtr.Zero ? (SoundSettings) null : new SoundSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__SoundSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClientSettings _ClientSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__ClientSettings));
        return pointer == System.IntPtr.Zero ? (ClientSettings) null : new ClientSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__ClientSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MutePlayerSystem _MutePlayerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__MutePlayerSystem));
        return pointer == System.IntPtr.Zero ? (MutePlayerSystem) null : new MutePlayerSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__MutePlayerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Uri _APIEndpoint_k__BackingField
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr__APIEndpoint_k__BackingField, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Uri) null : new Uri(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr__APIEndpoint_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Client Client
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_Client));
        return pointer == System.IntPtr.Zero ? (Client) null : new Client(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_Client), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ILoginSession LoginSession
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_LoginSession));
        return pointer == System.IntPtr.Zero ? (ILoginSession) null : new ILoginSession(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_LoginSession), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IChannelSession ChannelSession
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ChannelSession));
        return pointer == System.IntPtr.Zero ? (IChannelSession) null : new IChannelSession(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ChannelSession), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VoiceChannelHandler VoiceChannelHandler
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_VoiceChannelHandler));
        return pointer == System.IntPtr.Zero ? (VoiceChannelHandler) null : new VoiceChannelHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_VoiceChannelHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChannelHandler ChannelHandler
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ChannelHandler));
        return pointer == System.IntPtr.Zero ? (ChannelHandler) null : new ChannelHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ChannelHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float CurrentVolume
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_CurrentVolume));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_CurrentVolume)) = value;
      }
    }

    public unsafe bool IsClientInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_IsClientInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_IsClientInitialized)) = value;
      }
    }

    public static unsafe bool NoVOIPServer
    {
      get
      {
        bool noVoipServer;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_NoVOIPServer, (void*) &noVoipServer);
        return noVoipServer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_NoVOIPServer, (void*) &value);
      }
    }

    public unsafe bool LoggingEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_LoggingEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_LoggingEnabled)) = value;
      }
    }

    public unsafe bool ShouldSendChannelEvent
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ShouldSendChannelEvent));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ShouldSendChannelEvent)) = value;
      }
    }

    public unsafe bool TalkPressed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_TalkPressed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_TalkPressed)) = value;
      }
    }

    public static unsafe VoiceInternalState InternalState
    {
      get
      {
        VoiceInternalState internalState;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_InternalState, (void*) &internalState);
        return internalState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_InternalState, (void*) &value);
      }
    }

    public static unsafe bool ShouldDisconnect
    {
      get
      {
        bool shouldDisconnect;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_ShouldDisconnect, (void*) &shouldDisconnect);
        return shouldDisconnect;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_ShouldDisconnect, (void*) &value);
      }
    }

    public static unsafe bool UsePushToTalk
    {
      get
      {
        bool usePushToTalk;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_UsePushToTalk, (void*) &usePushToTalk);
        return usePushToTalk;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_UsePushToTalk, (void*) &value);
      }
    }

    public static unsafe bool TryConnect
    {
      get
      {
        bool tryConnect;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_TryConnect, (void*) &tryConnect);
        return tryConnect;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_TryConnect, (void*) &value);
      }
    }

    public unsafe float SinceLastPosUpdate
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_SinceLastPosUpdate));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_SinceLastPosUpdate)) = value;
      }
    }

    public unsafe float TimeSinceRequest
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_TimeSinceRequest));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_TimeSinceRequest)) = value;
      }
    }

    public unsafe string Username
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_Username)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string VivoxDomain
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_VivoxDomain)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_VivoxDomain), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Issuer
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_Issuer)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_Issuer), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ServerChannel
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ServerChannel)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_ServerChannel), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool IsSpeaking
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_IsSpeaking));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr_IsSpeaking)) = value;
      }
    }

    public unsafe EntityQuery _CameraUserQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__CameraUserQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__CameraUserQuery)) = value;
      }
    }

    public unsafe NativeList<int> _UserInfosToUpdate
    {
      get
      {
        return *(NativeList<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__UserInfosToUpdate));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr__UserInfosToUpdate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe Il2CppSystem.Action<ILoginSession> LoggingIn
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_LoggingIn, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ILoginSession>) null : new Il2CppSystem.Action<ILoginSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_LoggingIn, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<ILoginSession> LoggedIn
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_LoggedIn, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ILoginSession>) null : new Il2CppSystem.Action<ILoginSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_LoggedIn, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<ILoginSession> LoggedOut
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_LoggedOut, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ILoginSession>) null : new Il2CppSystem.Action<ILoginSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_LoggedOut, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<ILoginSession> LoggingOut
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.NativeFieldInfoPtr_LoggingOut, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ILoginSession>) null : new Il2CppSystem.Action<ILoginSession>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.NativeFieldInfoPtr_LoggingOut, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob4_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateUserInfo_FindUsersToUpdate_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateUserInfo_FindUsersToUpdate_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_FindUsersToUpdate_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateUserInfo_ActuallyUpdate_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateUserInfo_ActuallyUpdate_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.NativeFieldInfoPtr___UpdateUserInfo_ActuallyUpdate_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/<>c__DisplayClass47_0")]
    public sealed class __c__DisplayClass47_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_userInfosToUpdate;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateUserInfo_b__0_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateUserInfo_b__1_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass47_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateUserInfo_b__0(ref DynamicBuffer<UserInfoElement> userInfoBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref userInfoBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__UpdateUserInfo_b__0_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateUserInfo_b__1([In] ref DynamicBuffer<UserInfoElement> userInfoBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref userInfoBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__UpdateUserInfo_b__1_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass47_0()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass47_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, nameof (deltaTime));
        VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_userInfosToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, nameof (userInfosToUpdate));
        VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, "<>4__this");
        VivoxClientSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, 100685039);
        VivoxClientSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__UpdateUserInfo_b__0_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, 100685040);
        VivoxClientSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__UpdateUserInfo_b__1_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, 100685041);
      }

      public __c__DisplayClass47_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass47_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass47_0>.NativeClassPtr, data));
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe NativeList<int> userInfosToUpdate
      {
        get
        {
          return *(NativeList<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_userInfosToUpdate));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_userInfosToUpdate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe VivoxClientSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/<>c__DisplayClass73_0")]
    public sealed class __c__DisplayClass73_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_devices;
      private static readonly System.IntPtr NativeFieldInfoPtr_vivoxValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AdjustVolume_b__0_Internal_Void_IAsyncResult_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass73_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass73_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079114, XrefRangeEnd = 1079118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AdjustVolume_b__0(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass73_0.NativeMethodInfoPtr__AdjustVolume_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass73_0()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass73_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass73_0>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass73_0.NativeFieldInfoPtr_devices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass73_0>.NativeClassPtr, nameof (devices));
        VivoxClientSystem.__c__DisplayClass73_0.NativeFieldInfoPtr_vivoxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass73_0>.NativeClassPtr, nameof (vivoxValue));
        VivoxClientSystem.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass73_0>.NativeClassPtr, 100685042);
        VivoxClientSystem.__c__DisplayClass73_0.NativeMethodInfoPtr__AdjustVolume_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass73_0>.NativeClassPtr, 100685043);
      }

      public __c__DisplayClass73_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe IAudioDevices devices
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass73_0.NativeFieldInfoPtr_devices));
          return pointer == System.IntPtr.Zero ? (IAudioDevices) null : new IAudioDevices(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass73_0.NativeFieldInfoPtr_devices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int vivoxValue
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass73_0.NativeFieldInfoPtr_vivoxValue));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass73_0.NativeFieldInfoPtr_vivoxValue)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerRejectEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079128, XrefRangeEnd = 1079130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref VivoxEvents.ServerRejectEvent loginEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerRejectEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079130, XrefRangeEnd = 1079141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079147, RefRangeEnd = 1079148, XrefRangeStart = 1079141, XrefRangeEnd = 1079147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerRejectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685044);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685046);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685047);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685048);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe VivoxClientSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loginEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<VivoxEvents.ServerRejectEvent> forParameter_loginEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079118, XrefRangeEnd = 1079122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079127, RefRangeEnd = 1079128, XrefRangeStart = 1079122, XrefRangeEnd = 1079127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loginEvent));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100685049);
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100685050);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loginEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(65)]
          public LambdaParameterValueProvider_IComponentData_Tag<VivoxEvents.ServerRejectEvent>.StructuralChangeRuntime runtime_loginEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loginEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerLoginEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079158, XrefRangeEnd = 1079160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref VivoxEvents.ServerLoginEvent loginEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerLoginEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079160, XrefRangeEnd = 1079172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079172, XrefRangeEnd = 1079178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (hostInstance));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_performLambdaDelegate));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerLoginEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100685051);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100685053);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100685054);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100685055);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, data));
      }

      public unsafe VivoxClientSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loginEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerLoginEvent> forParameter_loginEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079148, XrefRangeEnd = 1079152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079157, RefRangeEnd = 1079158, XrefRangeStart = 1079152, XrefRangeEnd = 1079157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loginEvent));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100685056);
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100685057);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loginEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerLoginEvent>.StructuralChangeRuntime runtime_loginEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loginEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob2 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerChannelEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079188, XrefRangeEnd = 1079190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref VivoxEvents.ServerChannelEvent loginEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerChannelEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079190, XrefRangeEnd = 1079202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079202, XrefRangeEnd = 1079208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (hostInstance));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_performLambdaDelegate));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerChannelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100685058);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100685060);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100685061);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100685062);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, data));
      }

      public unsafe VivoxClientSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loginEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerChannelEvent> forParameter_loginEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079178, XrefRangeEnd = 1079182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079187, RefRangeEnd = 1079188, XrefRangeStart = 1079182, XrefRangeEnd = 1079187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loginEvent));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100685063);
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100685064);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loginEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerChannelEvent>.StructuralChangeRuntime runtime_loginEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loginEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob3 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerLoginEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079218, XrefRangeEnd = 1079220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref VivoxEvents.ServerLoginEvent loginEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loginEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerLoginEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079220, XrefRangeEnd = 1079232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079238, RefRangeEnd = 1079239, XrefRangeStart = 1079232, XrefRangeEnd = 1079238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob3()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (hostInstance));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_performLambdaDelegate));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerLoginEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100685065);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100685067);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100685068);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100685069);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob3()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, data));
      }

      public unsafe VivoxClientSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loginEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerLoginEvent> forParameter_loginEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079208, XrefRangeEnd = 1079212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079217, RefRangeEnd = 1079218, XrefRangeStart = 1079212, XrefRangeEnd = 1079217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loginEvent));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100685070);
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100685071);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loginEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerLoginEvent>.StructuralChangeRuntime runtime_loginEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loginEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob4 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerChannelEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079249, XrefRangeEnd = 1079251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref VivoxEvents.ServerChannelEvent channelEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref channelEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerChannelEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079251, XrefRangeEnd = 1079263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079269, RefRangeEnd = 1079270, XrefRangeStart = 1079263, XrefRangeEnd = 1079269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob4()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (hostInstance));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_runtimes));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_performLambdaDelegate));
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ServerChannelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100685072);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100685074);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100685075);
        VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100685076);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob4(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob4()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, data));
      }

      public unsafe VivoxClientSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_channelEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerChannelEvent> forParameter_channelEvent;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079239, XrefRangeEnd = 1079243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079248, RefRangeEnd = 1079249, XrefRangeStart = 1079243, XrefRangeEnd = 1079248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_channelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_channelEvent));
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100685077);
          VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100685078);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_channelEvent;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<VivoxEvents.ServerChannelEvent>.StructuralChangeRuntime runtime_channelEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_channelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_channelEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_UpdateUserInfo_FindUsersToUpdate")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateUserInfo_FindUsersToUpdate
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_userInfosToUpdate;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(8)]
      public NativeList<int> userInfosToUpdate;
      [FieldOffset(24)]
      public VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079353, XrefRangeEnd = 1079364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref DynamicBuffer<UserInfoElement> userInfoBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref userInfoBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 752973, RefRangeEnd = 752979, XrefRangeStart = 752973, XrefRangeEnd = 752979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VivoxClientSystem.__c__DisplayClass47_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 752979, RefRangeEnd = 752985, XrefRangeStart = 752979, XrefRangeEnd = 752985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VivoxClientSystem.__c__DisplayClass47_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079364, XrefRangeEnd = 1079366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079371, RefRangeEnd = 1079372, XrefRangeStart = 1079366, XrefRangeEnd = 1079371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079374, RefRangeEnd = 1079375, XrefRangeStart = 1079372, XrefRangeEnd = 1079374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VivoxClientSystem componentSystem,
        ref VivoxClientSystem.__c__DisplayClass47_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_byref___c__DisplayClass47_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079375, XrefRangeEnd = 1079379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079379, XrefRangeEnd = 1079385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateUserInfo_FindUsersToUpdate()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateUserInfo_FindUsersToUpdate");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, nameof (deltaTime));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_userInfosToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, nameof (userInfosToUpdate));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, nameof (_runtimes));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685079);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685080);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685081);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685082);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685083);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685084);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685085);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, 100685086);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_userInfoBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<UserInfoElement> forParameter_userInfoBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079273, RefRangeEnd = 1079274, XrefRangeStart = 1079270, XrefRangeEnd = 1079273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079277, RefRangeEnd = 1079278, XrefRangeStart = 1079274, XrefRangeEnd = 1079277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_userInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_userInfoBuffer));
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders>.NativeClassPtr, 100685087);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders>.NativeClassPtr, 100685088);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_userInfoBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<UserInfoElement>.Runtime runtime_userInfoBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_userInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_userInfoBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_UpdateUserInfo_FindUsersToUpdate/ProjectM.RunWithoutJobSystem_00004C88$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, "RunWithoutJobSystem_00004C88$PostfixBurstDelegate");
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685089);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685090);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685091);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685092);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_UpdateUserInfo_FindUsersToUpdate/ProjectM.RunWithoutJobSystem_00004C88$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079278, XrefRangeEnd = 1079292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079292, XrefRangeEnd = 1079310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079310, XrefRangeEnd = 1079325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079352, RefRangeEnd = 1079353, XrefRangeStart = 1079325, XrefRangeEnd = 1079352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate>.NativeClassPtr, "RunWithoutJobSystem_00004C88$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685093);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685094);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685095);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685096);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685098);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_FindUsersToUpdate.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VivoxClientSystem/ProjectM.<>c__DisplayClass_UpdateUserInfo_ActuallyUpdate")]
    public sealed class __c__DisplayClass_UpdateUserInfo_ActuallyUpdate : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079448, RefRangeEnd = 1079449, XrefRangeStart = 1079393, XrefRangeEnd = 1079448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref DynamicBuffer<UserInfoElement> userInfoBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref userInfoBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079450, RefRangeEnd = 1079451, XrefRangeStart = 1079449, XrefRangeEnd = 1079450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VivoxClientSystem.__c__DisplayClass47_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079452, RefRangeEnd = 1079453, XrefRangeStart = 1079451, XrefRangeEnd = 1079452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VivoxClientSystem.__c__DisplayClass47_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079453, XrefRangeEnd = 1079455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079460, RefRangeEnd = 1079461, XrefRangeStart = 1079455, XrefRangeEnd = 1079460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1079463, RefRangeEnd = 1079464, XrefRangeStart = 1079461, XrefRangeEnd = 1079463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VivoxClientSystem componentSystem,
        ref VivoxClientSystem.__c__DisplayClass47_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_byref___c__DisplayClass47_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079464, XrefRangeEnd = 1079470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateUserInfo_ActuallyUpdate()
      {
        Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateUserInfo_ActuallyUpdate");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, "<>4__this");
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, nameof (_runtimes));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_UserInfoElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, 100685099);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, 100685100);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, 100685101);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, 100685102);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, 100685103);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, 100685104);
        VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, 100685105);
      }

      public __c__DisplayClass_UpdateUserInfo_ActuallyUpdate(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateUserInfo_ActuallyUpdate()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, data));
      }

      public unsafe VivoxClientSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (VivoxClientSystem) null : new VivoxClientSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_userInfoBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<UserInfoElement> forParameter_userInfoBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079388, RefRangeEnd = 1079389, XrefRangeStart = 1079385, XrefRangeEnd = 1079388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VivoxClientSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1079392, RefRangeEnd = 1079393, XrefRangeStart = 1079389, XrefRangeEnd = 1079392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_userInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_userInfoBuffer));
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VivoxClientSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders>.NativeClassPtr, 100685106);
          VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders>.NativeClassPtr, 100685107);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_userInfoBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<UserInfoElement>.Runtime runtime_userInfoBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_userInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_userInfoBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VivoxClientSystem.__c__DisplayClass_UpdateUserInfo_ActuallyUpdate.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
