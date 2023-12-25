// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ClanEvents_Server
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public static class ClanEvents_Server : Il2CppSystem.Object
  {
    static ClanEvents_Server()
    {
      Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (ClanEvents_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr);
    }

    public ClanEvents_Server(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CreateClan_Response
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.CreateClan_Response.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.CreateClan_Response.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CreateClan_Response()
      {
        Il2CppClassPointerStore<ClanEvents_Server.CreateClan_Response>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (CreateClan_Response));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.CreateClan_Response>.NativeClassPtr);
        ClanEvents_Server.CreateClan_Response.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.CreateClan_Response>.NativeClassPtr, 100690655);
        ClanEvents_Server.CreateClan_Response.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.CreateClan_Response>.NativeClassPtr, 100690656);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.CreateClan_Response>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ClanInvitationResponse
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayerName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Response;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 PlayerName;
      [FieldOffset(64)]
      public InviteRequestResponse Response;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145171, XrefRangeEnd = 1145173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.ClanInvitationResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1145175, RefRangeEnd = 1145177, XrefRangeStart = 1145173, XrefRangeEnd = 1145175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.ClanInvitationResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ClanInvitationResponse()
      {
        Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResponse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (ClanInvitationResponse));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResponse>.NativeClassPtr);
        ClanEvents_Server.ClanInvitationResponse.NativeFieldInfoPtr_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResponse>.NativeClassPtr, nameof (PlayerName));
        ClanEvents_Server.ClanInvitationResponse.NativeFieldInfoPtr_Response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResponse>.NativeClassPtr, nameof (Response));
        ClanEvents_Server.ClanInvitationResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResponse>.NativeClassPtr, 100690657);
        ClanEvents_Server.ClanInvitationResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResponse>.NativeClassPtr, 100690658);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResponse>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ClanInvitationResult
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayerName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 PlayerName;
      [FieldOffset(64)]
      public InvitePlayerResult Result;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.ClanInvitationResult.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1145175, RefRangeEnd = 1145177, XrefRangeStart = 1145175, XrefRangeEnd = 1145177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.ClanInvitationResult.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ClanInvitationResult()
      {
        Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (ClanInvitationResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResult>.NativeClassPtr);
        ClanEvents_Server.ClanInvitationResult.NativeFieldInfoPtr_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResult>.NativeClassPtr, nameof (PlayerName));
        ClanEvents_Server.ClanInvitationResult.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResult>.NativeClassPtr, nameof (Result));
        ClanEvents_Server.ClanInvitationResult.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResult>.NativeClassPtr, 100690659);
        ClanEvents_Server.ClanInvitationResult.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResult>.NativeClassPtr, 100690660);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.ClanInvitationResult>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LeaveClanResultResponse
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public LeaveClanResult Result;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.LeaveClanResultResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1051539, RefRangeEnd = 1051545, XrefRangeStart = 1051539, XrefRangeEnd = 1051545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.LeaveClanResultResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static LeaveClanResultResponse()
      {
        Il2CppClassPointerStore<ClanEvents_Server.LeaveClanResultResponse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (LeaveClanResultResponse));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.LeaveClanResultResponse>.NativeClassPtr);
        ClanEvents_Server.LeaveClanResultResponse.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.LeaveClanResultResponse>.NativeClassPtr, nameof (Result));
        ClanEvents_Server.LeaveClanResultResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.LeaveClanResultResponse>.NativeClassPtr, 100690661);
        ClanEvents_Server.LeaveClanResultResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.LeaveClanResultResponse>.NativeClassPtr, 100690662);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.LeaveClanResultResponse>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AcceptClanInviteResultResponse
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public AcceptClanInviteResult Result;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.AcceptClanInviteResultResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1051539, RefRangeEnd = 1051545, XrefRangeStart = 1051539, XrefRangeEnd = 1051545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.AcceptClanInviteResultResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AcceptClanInviteResultResponse()
      {
        Il2CppClassPointerStore<ClanEvents_Server.AcceptClanInviteResultResponse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (AcceptClanInviteResultResponse));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.AcceptClanInviteResultResponse>.NativeClassPtr);
        ClanEvents_Server.AcceptClanInviteResultResponse.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.AcceptClanInviteResultResponse>.NativeClassPtr, nameof (Result));
        ClanEvents_Server.AcceptClanInviteResultResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.AcceptClanInviteResultResponse>.NativeClassPtr, 100690663);
        ClanEvents_Server.AcceptClanInviteResultResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.AcceptClanInviteResultResponse>.NativeClassPtr, 100690664);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.AcceptClanInviteResultResponse>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RoleChangedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Role;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public ClanRoleEnum Role;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.RoleChangedEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(32)]
      [CachedScanResults(RefRangeStart = 1145139, RefRangeEnd = 1145171, XrefRangeStart = 1145139, XrefRangeEnd = 1145171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.RoleChangedEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RoleChangedEvent()
      {
        Il2CppClassPointerStore<ClanEvents_Server.RoleChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (RoleChangedEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.RoleChangedEvent>.NativeClassPtr);
        ClanEvents_Server.RoleChangedEvent.NativeFieldInfoPtr_Role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.RoleChangedEvent>.NativeClassPtr, nameof (Role));
        ClanEvents_Server.RoleChangedEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.RoleChangedEvent>.NativeClassPtr, 100690665);
        ClanEvents_Server.RoleChangedEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.RoleChangedEvent>.NativeClassPtr, 100690666);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.RoleChangedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MemberConnectionChangedEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UserName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Connected;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 UserName;
      [FieldOffset(64)]
      public bool Connected;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145177, XrefRangeEnd = 1145179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.MemberConnectionChangedEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1145181, RefRangeEnd = 1145182, XrefRangeStart = 1145179, XrefRangeEnd = 1145181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.MemberConnectionChangedEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MemberConnectionChangedEvent()
      {
        Il2CppClassPointerStore<ClanEvents_Server.MemberConnectionChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (MemberConnectionChangedEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.MemberConnectionChangedEvent>.NativeClassPtr);
        ClanEvents_Server.MemberConnectionChangedEvent.NativeFieldInfoPtr_UserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.MemberConnectionChangedEvent>.NativeClassPtr, nameof (UserName));
        ClanEvents_Server.MemberConnectionChangedEvent.NativeFieldInfoPtr_Connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Server.MemberConnectionChangedEvent>.NativeClassPtr, nameof (Connected));
        ClanEvents_Server.MemberConnectionChangedEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.MemberConnectionChangedEvent>.NativeClassPtr, 100690667);
        ClanEvents_Server.MemberConnectionChangedEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.MemberConnectionChangedEvent>.NativeClassPtr, 100690668);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.MemberConnectionChangedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct KickedEvent
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.KickedEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Server.KickedEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static KickedEvent()
      {
        Il2CppClassPointerStore<ClanEvents_Server.KickedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Server>.NativeClassPtr, nameof (KickedEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Server.KickedEvent>.NativeClassPtr);
        ClanEvents_Server.KickedEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.KickedEvent>.NativeClassPtr, 100690669);
        ClanEvents_Server.KickedEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Server.KickedEvent>.NativeClassPtr, 100690670);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Server.KickedEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
