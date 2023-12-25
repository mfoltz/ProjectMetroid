// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.Session
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices;
using Epic.OnlineServices.Platform;
using Epic.OnlineServices.Sessions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.EOS
{
  public class Session : EOSImpl.UnmanagedAllocationsOwner
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalSessionName_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentState;
    private static readonly System.IntPtr NativeFieldInfoPtr_isStarted;
    private static readonly System.IntPtr NativeFieldInfoPtr__SavedPlayerCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_registeredUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformInterface;
    private static readonly System.IntPtr NativeFieldInfoPtr__SessionHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveSessionHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_StateChanged;
    private static readonly System.IntPtr NativeFieldInfoPtr__QueuedInitializeCompleteActions;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalSessionName_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalSessionName_Private_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentState_Public_get_State_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentState_Private_set_Void_State_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOwner_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMember_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_SessionData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_SessionData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_StateChanged_Public_add_Void_StateChangedHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_StateChanged_Public_rem_Void_StateChangedHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_SessionData_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_SessionDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Void_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Modify_Public_Void_SessionData_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseHandles_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Void_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterUser_Public_Void_ProductUserId_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterUser_Public_Void_ProductUserId_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSessionAsync_Private_Static_Void_PlatformInterface_String_SessionData_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifySessionAsync_Private_Static_Void_PlatformInterface_String_SessionData_SessionData_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroySessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartSessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndSessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinSessionAsync_Private_Static_Void_PlatformInterface_String_SessionDetails_EOSOperationCompleteHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveSessionHandle_Private_Static_ActiveSession_PlatformInterface_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerCountInSession_Private_Static_UInt32_ActiveSession_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Nullable_1_SessionData_byref___c__DisplayClass32_0_0;

    public unsafe string LocalSessionName
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_get_LocalSessionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_set_LocalSessionName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Session.State CurrentState
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 32697, RefRangeEnd = 32698, XrefRangeStart = 32697, XrefRangeEnd = 32698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_get_CurrentState_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Session.State*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 1121935, RefRangeEnd = 1121944, XrefRangeStart = 1121920, XrefRangeEnd = 1121935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_set_CurrentState_Private_set_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint PlayerCount
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121944, XrefRangeEnd = 1121945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_get_PlayerCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsOwner
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121945, XrefRangeEnd = 1121946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_get_IsOwner_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsMember
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1121947, RefRangeEnd = 1121948, XrefRangeStart = 1121946, XrefRangeEnd = 1121947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_get_IsMember_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe SessionData Data
    {
      [CallerCount(18), CachedScanResults(RefRangeStart = 1121957, RefRangeEnd = 1121975, XrefRangeStart = 1121948, XrefRangeEnd = 1121957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_get_Data_Public_get_SessionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new SessionData(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121975, XrefRangeEnd = 1121990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_set_Data_Public_set_Void_SessionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1121994, RefRangeEnd = 1121995, XrefRangeStart = 1121990, XrefRangeEnd = 1121994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_StateChanged(Session.StateChangedHandler value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_add_StateChanged_Public_add_Void_StateChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1121999, RefRangeEnd = 1122000, XrefRangeStart = 1121995, XrefRangeEnd = 1121999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_StateChanged(Session.StateChangedHandler value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_remove_StateChanged_Public_rem_Void_StateChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122038, RefRangeEnd = 1122039, XrefRangeStart = 1122000, XrefRangeEnd = 1122038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Session(
      PlatformInterface platformInterface,
      SessionData data,
      EOSOperationCompleteHandler initializationCompleteCallback)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initializationCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_SessionData_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122071, RefRangeEnd = 1122072, XrefRangeStart = 1122039, XrefRangeEnd = 1122071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Session(PlatformInterface platformInterface, SessionDetails sessionHandle)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sessionHandle);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_SessionDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122072, XrefRangeEnd = 1122100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start(
      EOSOperationCompleteHandler startSessionCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) startSessionCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_Start_Public_Void_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122100, XrefRangeEnd = 1122133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void End(
      EOSOperationCompleteHandler endSessionCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) endSessionCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_End_Public_Void_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1122163, RefRangeEnd = 1122165, XrefRangeStart = 1122133, XrefRangeEnd = 1122163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Modify(
      SessionData newData,
      EOSOperationCompleteHandler modifySessionCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifySessionCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_Modify_Public_Void_SessionData_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1122218, RefRangeEnd = 1122222, XrefRangeStart = 1122165, XrefRangeEnd = 1122218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Destroy(
      EOSOperationCompleteHandler destroySessionCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destroySessionCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_Destroy_Public_Void_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122222, XrefRangeEnd = 1122301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Session.NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122307, RefRangeEnd = 1122308, XrefRangeStart = 1122301, XrefRangeEnd = 1122307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReleaseHandles()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_ReleaseHandles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122308, XrefRangeEnd = 1122333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Join(
      EOSOperationCompleteHandler joinSessionCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joinSessionCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_Join_Public_Void_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122333, XrefRangeEnd = 1122396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterUser(
      ProductUserId userToRegister,
      EOSOperationCompleteHandler registerUserCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userToRegister);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) registerUserCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_RegisterUser_Public_Void_ProductUserId_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122459, RefRangeEnd = 1122460, XrefRangeStart = 1122396, XrefRangeEnd = 1122459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnregisterUser(
      ProductUserId userToUnregister,
      EOSOperationCompleteHandler unregisterUserCompleteCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userToUnregister);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unregisterUserCompleteCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_UnregisterUser_Public_Void_ProductUserId_EOSOperationCompleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122571, RefRangeEnd = 1122572, XrefRangeStart = 1122460, XrefRangeEnd = 1122571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateSessionAsync(
      PlatformInterface platformInterface,
      string sessionName,
      SessionData sessionData,
      EOSOperationCompleteHandler completeCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sessionData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_CreateSessionAsync_Private_Static_Void_PlatformInterface_String_SessionData_EOSOperationCompleteHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122666, RefRangeEnd = 1122667, XrefRangeStart = 1122572, XrefRangeEnd = 1122666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ModifySessionAsync(
      PlatformInterface platformInterface,
      string sessionName,
      SessionData original,
      SessionData modified,
      EOSOperationCompleteHandler completeCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) original));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) modified));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_ModifySessionAsync_Private_Static_Void_PlatformInterface_String_SessionData_SessionData_EOSOperationCompleteHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1122706, RefRangeEnd = 1122708, XrefRangeStart = 1122667, XrefRangeEnd = 1122706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroySessionAsync(
      PlatformInterface platformInterface,
      string sessionName,
      EOSOperationCompleteHandler completeCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_DestroySessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122747, RefRangeEnd = 1122748, XrefRangeStart = 1122708, XrefRangeEnd = 1122747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void StartSessionAsync(
      PlatformInterface platformInterface,
      string sessionName,
      EOSOperationCompleteHandler completeCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_StartSessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122787, RefRangeEnd = 1122788, XrefRangeStart = 1122748, XrefRangeEnd = 1122787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EndSessionAsync(
      PlatformInterface platformInterface,
      string sessionName,
      EOSOperationCompleteHandler completeCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_EndSessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122831, RefRangeEnd = 1122832, XrefRangeStart = 1122788, XrefRangeEnd = 1122831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void JoinSessionAsync(
      PlatformInterface platformInterface,
      string sessionName,
      SessionDetails sessionHandle,
      EOSOperationCompleteHandler completeCallback)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sessionHandle);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completeCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_JoinSessionAsync_Private_Static_Void_PlatformInterface_String_SessionDetails_EOSOperationCompleteHandler_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1122856, RefRangeEnd = 1122858, XrefRangeStart = 1122832, XrefRangeEnd = 1122856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ActiveSession GetActiveSessionHandle(
      PlatformInterface platformInterface,
      string sessionName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformInterface);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sessionName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_GetActiveSessionHandle_Private_Static_ActiveSession_PlatformInterface_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ActiveSession) null : new ActiveSession(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122858, XrefRangeEnd = 1122859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe uint GetPlayerCountInSession(ActiveSession session)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) session);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_GetPlayerCountInSession_Private_Static_UInt32_ActiveSession_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1122963, RefRangeEnd = 1122964, XrefRangeStart = 1122859, XrefRangeEnd = 1122963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Nullable<SessionData> Method_Private_Nullable_1_SessionData_byref___c__DisplayClass32_0_0(
      ref Session.__c__DisplayClass32_0 _param1)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param1);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_Method_Private_Nullable_1_SessionData_byref___c__DisplayClass32_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<SessionData>(pointer);
    }

    static Session()
    {
      Il2CppClassPointerStore<Session>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (Session));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session>.NativeClassPtr);
      Session.NativeFieldInfoPtr_LogHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (LogHeader));
      Session.NativeFieldInfoPtr__LocalSessionName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "<LocalSessionName>k__BackingField");
      Session.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (_Data));
      Session.NativeFieldInfoPtr__CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (_CurrentState));
      Session.NativeFieldInfoPtr_isStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (isStarted));
      Session.NativeFieldInfoPtr__SavedPlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (_SavedPlayerCount));
      Session.NativeFieldInfoPtr_registeredUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (registeredUsers));
      Session.NativeFieldInfoPtr__PlatformInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (_PlatformInterface));
      Session.NativeFieldInfoPtr__SessionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (_SessionHandle));
      Session.NativeFieldInfoPtr__ActiveSessionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (_ActiveSessionHandle));
      Session.NativeFieldInfoPtr_StateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (StateChanged));
      Session.NativeFieldInfoPtr__QueuedInitializeCompleteActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (_QueuedInitializeCompleteActions));
      Session.NativeMethodInfoPtr_get_LocalSessionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689029);
      Session.NativeMethodInfoPtr_set_LocalSessionName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689030);
      Session.NativeMethodInfoPtr_get_CurrentState_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689031);
      Session.NativeMethodInfoPtr_set_CurrentState_Private_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689032);
      Session.NativeMethodInfoPtr_get_PlayerCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689033);
      Session.NativeMethodInfoPtr_get_IsOwner_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689034);
      Session.NativeMethodInfoPtr_get_IsMember_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689035);
      Session.NativeMethodInfoPtr_get_Data_Public_get_SessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689036);
      Session.NativeMethodInfoPtr_set_Data_Public_set_Void_SessionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689037);
      Session.NativeMethodInfoPtr_add_StateChanged_Public_add_Void_StateChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689038);
      Session.NativeMethodInfoPtr_remove_StateChanged_Public_rem_Void_StateChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689039);
      Session.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_SessionData_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689040);
      Session.NativeMethodInfoPtr__ctor_Public_Void_PlatformInterface_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689041);
      Session.NativeMethodInfoPtr_Start_Public_Void_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689042);
      Session.NativeMethodInfoPtr_End_Public_Void_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689043);
      Session.NativeMethodInfoPtr_Modify_Public_Void_SessionData_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689044);
      Session.NativeMethodInfoPtr_Destroy_Public_Void_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689045);
      Session.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689046);
      Session.NativeMethodInfoPtr_ReleaseHandles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689047);
      Session.NativeMethodInfoPtr_Join_Public_Void_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689048);
      Session.NativeMethodInfoPtr_RegisterUser_Public_Void_ProductUserId_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689049);
      Session.NativeMethodInfoPtr_UnregisterUser_Public_Void_ProductUserId_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689050);
      Session.NativeMethodInfoPtr_CreateSessionAsync_Private_Static_Void_PlatformInterface_String_SessionData_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689051);
      Session.NativeMethodInfoPtr_ModifySessionAsync_Private_Static_Void_PlatformInterface_String_SessionData_SessionData_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689052);
      Session.NativeMethodInfoPtr_DestroySessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689053);
      Session.NativeMethodInfoPtr_StartSessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689054);
      Session.NativeMethodInfoPtr_EndSessionAsync_Private_Static_Void_PlatformInterface_String_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689055);
      Session.NativeMethodInfoPtr_JoinSessionAsync_Private_Static_Void_PlatformInterface_String_SessionDetails_EOSOperationCompleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689056);
      Session.NativeMethodInfoPtr_GetActiveSessionHandle_Private_Static_ActiveSession_PlatformInterface_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689057);
      Session.NativeMethodInfoPtr_GetPlayerCountInSession_Private_Static_UInt32_ActiveSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689058);
      Session.NativeMethodInfoPtr_Method_Private_Nullable_1_SessionData_byref___c__DisplayClass32_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100689059);
    }

    public Session(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string LogHeader
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(Session.NativeFieldInfoPtr_LogHeader, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Session.NativeFieldInfoPtr_LogHeader, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _LocalSessionName_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__LocalSessionName_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__LocalSessionName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public SessionData _Data
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__Data);
        return new SessionData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__Data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SessionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Session.State _CurrentState
    {
      get
      {
        return *(Session.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__CurrentState));
      }
      [param: In] set
      {
        *(Session.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__CurrentState)) = value;
      }
    }

    public unsafe bool isStarted
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_isStarted));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_isStarted)) = value;
      }
    }

    public unsafe uint _SavedPlayerCount
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__SavedPlayerCount));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__SavedPlayerCount)) = value;
      }
    }

    public unsafe Dictionary<ProductUserId, bool> registeredUsers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_registeredUsers));
        return pointer == System.IntPtr.Zero ? (Dictionary<ProductUserId, bool>) null : new Dictionary<ProductUserId, bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_registeredUsers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlatformInterface _PlatformInterface
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__PlatformInterface));
        return pointer == System.IntPtr.Zero ? (PlatformInterface) null : new PlatformInterface(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__PlatformInterface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SessionDetails _SessionHandle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__SessionHandle));
        return pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__SessionHandle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ActiveSession _ActiveSessionHandle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__ActiveSessionHandle));
        return pointer == System.IntPtr.Zero ? (ActiveSession) null : new ActiveSession(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__ActiveSessionHandle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Session.StateChangedHandler StateChanged
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_StateChanged));
        return pointer == System.IntPtr.Zero ? (Session.StateChangedHandler) null : new Session.StateChangedHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_StateChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Queue<EOSOperationCompleteHandler> _QueuedInitializeCompleteActions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__QueuedInitializeCompleteActions));
        return pointer == System.IntPtr.Zero ? (Queue<EOSOperationCompleteHandler>) null : new Queue<EOSOperationCompleteHandler>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr__QueuedInitializeCompleteActions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum State
    {
      NotReady,
      Observed,
      Joined,
      Error,
      Destroyed,
    }

    public sealed class StateChangedHandler : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StateChangedHandler(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.StateChangedHandler>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.StateChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 276826, RefRangeEnd = 276931, XrefRangeStart = 276826, XrefRangeEnd = 276931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.StateChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.StateChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.StateChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StateChangedHandler()
      {
        Il2CppClassPointerStore<Session.StateChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (StateChangedHandler));
        Session.StateChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.StateChangedHandler>.NativeClassPtr, 100689060);
        Session.StateChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.StateChangedHandler>.NativeClassPtr, 100689061);
        Session.StateChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.StateChangedHandler>.NativeClassPtr, 100689062);
        Session.StateChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.StateChangedHandler>.NativeClassPtr, 100689063);
      }

      public StateChangedHandler(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator Session.StateChangedHandler([In] System.Action obj0)
      {
        return DelegateSupport.ConvertDelegate<Session.StateChangedHandler>((System.Delegate) obj0);
      }

      public static Session.StateChangedHandler operator +(
        [In] Session.StateChangedHandler obj0,
        [In] Session.StateChangedHandler obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<Session.StateChangedHandler>();
      }

      public static Session.StateChangedHandler operator -(
        [In] Session.StateChangedHandler obj0,
        [In] Session.StateChangedHandler obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (Session.StateChangedHandler) @delegate : @delegate.Cast<Session.StateChangedHandler>();
      }
    }

    public sealed class JoinSessionComplete : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe JoinSessionComplete(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.JoinSessionComplete>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.JoinSessionComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(27)]
      [CachedScanResults(RefRangeStart = 241276, RefRangeEnd = 241303, XrefRangeStart = 241276, XrefRangeEnd = 241303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.JoinSessionComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121736, XrefRangeEnd = 1121740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        bool success,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &success;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.JoinSessionComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.JoinSessionComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static JoinSessionComplete()
      {
        Il2CppClassPointerStore<Session.JoinSessionComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, nameof (JoinSessionComplete));
        Session.JoinSessionComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.JoinSessionComplete>.NativeClassPtr, 100689064);
        Session.JoinSessionComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.JoinSessionComplete>.NativeClassPtr, 100689065);
        Session.JoinSessionComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.JoinSessionComplete>.NativeClassPtr, 100689066);
        Session.JoinSessionComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.JoinSessionComplete>.NativeClassPtr, 100689067);
      }

      public JoinSessionComplete(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator Session.JoinSessionComplete([In] System.Action<bool> obj0)
      {
        return DelegateSupport.ConvertDelegate<Session.JoinSessionComplete>((System.Delegate) obj0);
      }

      public static Session.JoinSessionComplete operator +(
        [In] Session.JoinSessionComplete obj0,
        [In] Session.JoinSessionComplete obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<Session.JoinSessionComplete>();
      }

      public static Session.JoinSessionComplete operator -(
        [In] Session.JoinSessionComplete obj0,
        [In] Session.JoinSessionComplete obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (Session.JoinSessionComplete) @delegate : @delegate.Cast<Session.JoinSessionComplete>();
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__set_Data_b__17_0_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121740, XrefRangeEnd = 1121746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _set_Data_b__17_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c.NativeMethodInfoPtr__set_Data_b__17_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<Session.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c>.NativeClassPtr);
        Session.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c>.NativeClassPtr, "<>9");
        Session.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c>.NativeClassPtr, "<>9__17_0");
        Session.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c>.NativeClassPtr, 100689069);
        Session.__c.NativeMethodInfoPtr__set_Data_b__17_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c>.NativeClassPtr, 100689070);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe Session.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Session.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Session.__c) null : new Session.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Session.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe EOSOperationCompleteHandler __9__17_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Session.__c.NativeFieldInfoPtr___9__17_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Session.__c.NativeFieldInfoPtr___9__17_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass31_0")]
    public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_initializationCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass31_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass31_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121746, XrefRangeEnd = 1121758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_Boolean_PDM_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass31_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass31_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass31_0>.NativeClassPtr);
        Session.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass31_0.NativeFieldInfoPtr_initializationCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass31_0>.NativeClassPtr, nameof (initializationCompleteCallback));
        Session.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass31_0>.NativeClassPtr, 100689071);
        Session.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass31_0>.NativeClassPtr, 100689072);
      }

      public __c__DisplayClass31_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler initializationCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass31_0.NativeFieldInfoPtr_initializationCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass31_0.NativeFieldInfoPtr_initializationCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass32_0")]
    public sealed class __c__DisplayClass32_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

      static __c__DisplayClass32_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass32_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass32_0>.NativeClassPtr);
        Session.__c__DisplayClass32_0.NativeFieldInfoPtr_sessionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass32_0>.NativeClassPtr, nameof (sessionHandle));
        Session.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
      }

      public __c__DisplayClass32_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass32_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Session.__c__DisplayClass32_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Session.__c__DisplayClass32_0>.NativeClassPtr, data));
      }

      public unsafe SessionDetails sessionHandle
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass32_0.NativeFieldInfoPtr_sessionHandle));
          return pointer == System.IntPtr.Zero ? (SessionDetails) null : new SessionDetails(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass32_0.NativeFieldInfoPtr_sessionHandle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass33_0")]
    public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_startSessionCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass33_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121758, XrefRangeEnd = 1121759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Start_b__0(bool initializationSuccess)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &initializationSuccess;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass33_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121759, XrefRangeEnd = 1121761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_Boolean_PDM_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass33_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass33_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr);
        Session.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass33_0.NativeFieldInfoPtr_startSessionCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr, nameof (startSessionCompleteCallback));
        Session.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr, 100689073);
        Session.__c__DisplayClass33_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr, 100689074);
        Session.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass33_0>.NativeClassPtr, 100689075);
      }

      public __c__DisplayClass33_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler startSessionCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass33_0.NativeFieldInfoPtr_startSessionCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass33_0.NativeFieldInfoPtr_startSessionCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass34_0")]
    public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_endSessionCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__End_b__0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass34_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121761, XrefRangeEnd = 1121762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _End_b__0(bool initializationSuccess)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &initializationSuccess;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass34_0.NativeMethodInfoPtr__End_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_Boolean_PDM_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass34_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass34_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr);
        Session.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass34_0.NativeFieldInfoPtr_endSessionCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr, nameof (endSessionCompleteCallback));
        Session.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr, 100689076);
        Session.__c__DisplayClass34_0.NativeMethodInfoPtr__End_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr, 100689077);
        Session.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass34_0>.NativeClassPtr, 100689078);
      }

      public __c__DisplayClass34_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler endSessionCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass34_0.NativeFieldInfoPtr_endSessionCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass34_0.NativeFieldInfoPtr_endSessionCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass35_0")]
    public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_newData;
      private static readonly System.IntPtr NativeFieldInfoPtr_modifySessionCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Modify_b__0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass35_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121762, XrefRangeEnd = 1121763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Modify_b__0(bool initializationSuccess)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &initializationSuccess;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass35_0.NativeMethodInfoPtr__Modify_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121763, XrefRangeEnd = 1121765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_Boolean_PDM_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass35_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass35_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr);
        Session.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass35_0.NativeFieldInfoPtr_newData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr, nameof (newData));
        Session.__c__DisplayClass35_0.NativeFieldInfoPtr_modifySessionCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr, nameof (modifySessionCompleteCallback));
        Session.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr, 100689079);
        Session.__c__DisplayClass35_0.NativeMethodInfoPtr__Modify_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr, 100689080);
        Session.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass35_0>.NativeClassPtr, 100689081);
      }

      public __c__DisplayClass35_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public SessionData newData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass35_0.NativeFieldInfoPtr_newData);
          return new SessionData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass35_0.NativeFieldInfoPtr_newData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SessionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EOSOperationCompleteHandler modifySessionCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass35_0.NativeFieldInfoPtr_modifySessionCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass35_0.NativeFieldInfoPtr_modifySessionCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass36_0")]
    public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroySessionCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Destroy_b__1_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass36_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121765, XrefRangeEnd = 1121766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Destroy_b__1(bool initializationSuccess)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &initializationSuccess;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass36_0.NativeMethodInfoPtr__Destroy_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121766, XrefRangeEnd = 1121769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_Boolean_PDM_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass36_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass36_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr);
        Session.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass36_0.NativeFieldInfoPtr_destroySessionCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr, nameof (destroySessionCompleteCallback));
        Session.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr, 100689082);
        Session.__c__DisplayClass36_0.NativeMethodInfoPtr__Destroy_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr, 100689083);
        Session.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass36_0>.NativeClassPtr, 100689084);
      }

      public __c__DisplayClass36_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler destroySessionCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass36_0.NativeFieldInfoPtr_destroySessionCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass36_0.NativeFieldInfoPtr_destroySessionCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass37_0")]
    public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_waiting;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Release_b__0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Release_b__2_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass37_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Release_b__0(bool _)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass37_0.NativeMethodInfoPtr__Release_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121769, XrefRangeEnd = 1121778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_PDM_0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe void _Release_b__2(bool _)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass37_0.NativeMethodInfoPtr__Release_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass37_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass37_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr);
        Session.__c__DisplayClass37_0.NativeFieldInfoPtr_waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr, nameof (waiting));
        Session.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr, 100689085);
        Session.__c__DisplayClass37_0.NativeMethodInfoPtr__Release_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr, 100689086);
        Session.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr, 100689087);
        Session.__c__DisplayClass37_0.NativeMethodInfoPtr__Release_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass37_0>.NativeClassPtr, 100689088);
      }

      public __c__DisplayClass37_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe bool waiting
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass37_0.NativeFieldInfoPtr_waiting));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass37_0.NativeFieldInfoPtr_waiting)) = value;
        }
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass39_0")]
    public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_joinSessionCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass39_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass39_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121778, XrefRangeEnd = 1121784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_Boolean_PDM_0(bool success)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &success;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass39_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass39_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass39_0>.NativeClassPtr);
        Session.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass39_0.NativeFieldInfoPtr_joinSessionCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass39_0>.NativeClassPtr, nameof (joinSessionCompleteCallback));
        Session.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass39_0>.NativeClassPtr, 100689089);
        Session.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass39_0>.NativeClassPtr, 100689090);
      }

      public __c__DisplayClass39_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler joinSessionCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass39_0.NativeFieldInfoPtr_joinSessionCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass39_0.NativeFieldInfoPtr_joinSessionCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass40_0")]
    public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_userToRegister;
      private static readonly System.IntPtr NativeFieldInfoPtr_registerUserCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterUser_b__0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_RegisterPlayersCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass40_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121784, XrefRangeEnd = 1121785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterUser_b__0(bool initializationSuccess)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &initializationSuccess;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass40_0.NativeMethodInfoPtr__RegisterUser_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121785, XrefRangeEnd = 1121803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_RegisterPlayersCallbackInfo_PDM_0(
        ref RegisterPlayersCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_Void_byref_RegisterPlayersCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass40_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass40_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr);
        Session.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass40_0.NativeFieldInfoPtr_userToRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr, nameof (userToRegister));
        Session.__c__DisplayClass40_0.NativeFieldInfoPtr_registerUserCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr, nameof (registerUserCompleteCallback));
        Session.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr, 100689091);
        Session.__c__DisplayClass40_0.NativeMethodInfoPtr__RegisterUser_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr, 100689092);
        Session.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_Void_byref_RegisterPlayersCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass40_0>.NativeClassPtr, 100689093);
      }

      public __c__DisplayClass40_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ProductUserId userToRegister
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass40_0.NativeFieldInfoPtr_userToRegister));
          return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass40_0.NativeFieldInfoPtr_userToRegister), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler registerUserCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass40_0.NativeFieldInfoPtr_registerUserCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass40_0.NativeFieldInfoPtr_registerUserCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass41_0")]
    public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_userToUnregister;
      private static readonly System.IntPtr NativeFieldInfoPtr_unregisterUserCompleteCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UnregisterUser_b__0_Internal_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_UnregisterPlayersCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass41_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121803, XrefRangeEnd = 1121804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UnregisterUser_b__0(bool initializationSuccess)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &initializationSuccess;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass41_0.NativeMethodInfoPtr__UnregisterUser_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121804, XrefRangeEnd = 1121809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_UnregisterPlayersCallbackInfo_PDM_0(
        ref UnregisterPlayersCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_byref_UnregisterPlayersCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass41_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass41_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr);
        Session.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
        Session.__c__DisplayClass41_0.NativeFieldInfoPtr_userToUnregister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr, nameof (userToUnregister));
        Session.__c__DisplayClass41_0.NativeFieldInfoPtr_unregisterUserCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr, nameof (unregisterUserCompleteCallback));
        Session.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr, 100689094);
        Session.__c__DisplayClass41_0.NativeMethodInfoPtr__UnregisterUser_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr, 100689095);
        Session.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_byref_UnregisterPlayersCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass41_0>.NativeClassPtr, 100689096);
      }

      public __c__DisplayClass41_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Session __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (Session) null : new Session(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ProductUserId userToUnregister
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass41_0.NativeFieldInfoPtr_userToUnregister));
          return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass41_0.NativeFieldInfoPtr_userToUnregister), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler unregisterUserCompleteCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass41_0.NativeFieldInfoPtr_unregisterUserCompleteCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass41_0.NativeFieldInfoPtr_unregisterUserCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass42_0")]
    public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionModification;
      private static readonly System.IntPtr NativeFieldInfoPtr_completeCallback;
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionName;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass42_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121809, XrefRangeEnd = 1121823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0(
        ref UpdateSessionCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass42_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass42_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr);
        Session.__c__DisplayClass42_0.NativeFieldInfoPtr_sessionModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr, nameof (sessionModification));
        Session.__c__DisplayClass42_0.NativeFieldInfoPtr_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr, nameof (completeCallback));
        Session.__c__DisplayClass42_0.NativeFieldInfoPtr_sessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr, nameof (sessionName));
        Session.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr, 100689097);
        Session.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass42_0>.NativeClassPtr, 100689098);
      }

      public __c__DisplayClass42_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SessionModification sessionModification
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass42_0.NativeFieldInfoPtr_sessionModification));
          return pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass42_0.NativeFieldInfoPtr_sessionModification), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler completeCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass42_0.NativeFieldInfoPtr_completeCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass42_0.NativeFieldInfoPtr_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string sessionName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass42_0.NativeFieldInfoPtr_sessionName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass42_0.NativeFieldInfoPtr_sessionName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass43_0")]
    public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionModification;
      private static readonly System.IntPtr NativeFieldInfoPtr_completeCallback;
      private static readonly System.IntPtr NativeFieldInfoPtr_originalAttributes;
      private static readonly System.IntPtr NativeFieldInfoPtr_result;
      private static readonly System.IntPtr NativeFieldInfoPtr_sessionName;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_1;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass43_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121823, XrefRangeEnd = 1121829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0(
        ref UpdateSessionCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121829, XrefRangeEnd = 1121891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_0(
        KeyValuePair<string, KeyValuePair<AttributeDataValue, bool>> attribute)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) attribute));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121891, XrefRangeEnd = 1121900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_1(
        KeyValuePair<string, KeyValuePair<AttributeDataValue, bool>> attribute)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) attribute));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass43_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass43_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr);
        Session.__c__DisplayClass43_0.NativeFieldInfoPtr_sessionModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, nameof (sessionModification));
        Session.__c__DisplayClass43_0.NativeFieldInfoPtr_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, nameof (completeCallback));
        Session.__c__DisplayClass43_0.NativeFieldInfoPtr_originalAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, nameof (originalAttributes));
        Session.__c__DisplayClass43_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, nameof (result));
        Session.__c__DisplayClass43_0.NativeFieldInfoPtr_sessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, nameof (sessionName));
        Session.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, 100689099);
        Session.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_byref_UpdateSessionCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, 100689100);
        Session.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, 100689101);
        Session.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Boolean_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass43_0>.NativeClassPtr, 100689102);
      }

      public __c__DisplayClass43_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SessionModification sessionModification
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_sessionModification));
          return pointer == System.IntPtr.Zero ? (SessionModification) null : new SessionModification(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_sessionModification), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EOSOperationCompleteHandler completeCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_completeCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<string, KeyValuePair<AttributeDataValue, bool>> originalAttributes
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_originalAttributes));
          return pointer == System.IntPtr.Zero ? (Dictionary<string, KeyValuePair<AttributeDataValue, bool>>) null : new Dictionary<string, KeyValuePair<AttributeDataValue, bool>>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_originalAttributes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Result result
      {
        get
        {
          return *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_result));
        }
        [param: In] set
        {
          *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_result)) = value;
        }
      }

      public unsafe string sessionName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_sessionName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass43_0.NativeFieldInfoPtr_sessionName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass44_0")]
    public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_completeCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_DestroySessionCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass44_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass44_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121900, XrefRangeEnd = 1121905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_DestroySessionCallbackInfo_PDM_0(
        ref DestroySessionCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_Void_byref_DestroySessionCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass44_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass44_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass44_0>.NativeClassPtr);
        Session.__c__DisplayClass44_0.NativeFieldInfoPtr_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass44_0>.NativeClassPtr, nameof (completeCallback));
        Session.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass44_0>.NativeClassPtr, 100689103);
        Session.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_Void_byref_DestroySessionCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass44_0>.NativeClassPtr, 100689104);
      }

      public __c__DisplayClass44_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EOSOperationCompleteHandler completeCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass44_0.NativeFieldInfoPtr_completeCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass44_0.NativeFieldInfoPtr_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass45_0")]
    public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_completeCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_StartSessionCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass45_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass45_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121905, XrefRangeEnd = 1121910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_StartSessionCallbackInfo_PDM_0(
        ref StartSessionCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass45_0.NativeMethodInfoPtr_Method_Internal_Void_byref_StartSessionCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass45_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass45_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass45_0>.NativeClassPtr);
        Session.__c__DisplayClass45_0.NativeFieldInfoPtr_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass45_0>.NativeClassPtr, nameof (completeCallback));
        Session.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass45_0>.NativeClassPtr, 100689105);
        Session.__c__DisplayClass45_0.NativeMethodInfoPtr_Method_Internal_Void_byref_StartSessionCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass45_0>.NativeClassPtr, 100689106);
      }

      public __c__DisplayClass45_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EOSOperationCompleteHandler completeCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass45_0.NativeFieldInfoPtr_completeCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass45_0.NativeFieldInfoPtr_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass46_0")]
    public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_completeCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_EndSessionCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass46_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass46_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121910, XrefRangeEnd = 1121915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_EndSessionCallbackInfo_PDM_0(
        ref EndSessionCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_Void_byref_EndSessionCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass46_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass46_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass46_0>.NativeClassPtr);
        Session.__c__DisplayClass46_0.NativeFieldInfoPtr_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass46_0>.NativeClassPtr, nameof (completeCallback));
        Session.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass46_0>.NativeClassPtr, 100689107);
        Session.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_Void_byref_EndSessionCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass46_0>.NativeClassPtr, 100689108);
      }

      public __c__DisplayClass46_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EOSOperationCompleteHandler completeCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass46_0.NativeFieldInfoPtr_completeCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass46_0.NativeFieldInfoPtr_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.EOS.Session/<>c__DisplayClass48_0")]
    public sealed class __c__DisplayClass48_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_completeCallback;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref_JoinSessionCallbackInfo_PDM_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass48_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session.__c__DisplayClass48_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121915, XrefRangeEnd = 1121920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Method_Internal_Void_byref_JoinSessionCallbackInfo_PDM_0(
        ref JoinSessionCallbackInfo data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Session.__c__DisplayClass48_0.NativeMethodInfoPtr_Method_Internal_Void_byref_JoinSessionCallbackInfo_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass48_0()
      {
        Il2CppClassPointerStore<Session.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session>.NativeClassPtr, "<>c__DisplayClass48_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session.__c__DisplayClass48_0>.NativeClassPtr);
        Session.__c__DisplayClass48_0.NativeFieldInfoPtr_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session.__c__DisplayClass48_0>.NativeClassPtr, nameof (completeCallback));
        Session.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass48_0>.NativeClassPtr, 100689109);
        Session.__c__DisplayClass48_0.NativeMethodInfoPtr_Method_Internal_Void_byref_JoinSessionCallbackInfo_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session.__c__DisplayClass48_0>.NativeClassPtr, 100689110);
      }

      public __c__DisplayClass48_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EOSOperationCompleteHandler completeCallback
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass48_0.NativeFieldInfoPtr_completeCallback));
          return pointer == System.IntPtr.Zero ? (EOSOperationCompleteHandler) null : new EOSOperationCompleteHandler(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Session.__c__DisplayClass48_0.NativeFieldInfoPtr_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
