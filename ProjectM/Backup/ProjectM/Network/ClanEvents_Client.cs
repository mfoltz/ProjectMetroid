// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ClanEvents_Client
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
  public static class ClanEvents_Client : Il2CppSystem.Object
  {
    static ClanEvents_Client()
    {
      Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (ClanEvents_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr);
    }

    public ClanEvents_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CreateClan_Request
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanName;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanMotto;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 ClanName;
      [FieldOffset(64)]
      public FixedString64 ClanMotto;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145104, XrefRangeEnd = 1145106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.CreateClan_Request.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1145108, RefRangeEnd = 1145109, XrefRangeStart = 1145106, XrefRangeEnd = 1145108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.CreateClan_Request.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CreateClan_Request()
      {
        Il2CppClassPointerStore<ClanEvents_Client.CreateClan_Request>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr, nameof (CreateClan_Request));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client.CreateClan_Request>.NativeClassPtr);
        ClanEvents_Client.CreateClan_Request.NativeFieldInfoPtr_ClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.CreateClan_Request>.NativeClassPtr, nameof (ClanName));
        ClanEvents_Client.CreateClan_Request.NativeFieldInfoPtr_ClanMotto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.CreateClan_Request>.NativeClassPtr, nameof (ClanMotto));
        ClanEvents_Client.CreateClan_Request.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.CreateClan_Request>.NativeClassPtr, 100690641);
        ClanEvents_Client.CreateClan_Request.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.CreateClan_Request>.NativeClassPtr, 100690642);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Client.CreateClan_Request>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EditClan
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanMotto;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 ClanMotto;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051531, RefRangeEnd = 1051532, XrefRangeStart = 1051531, XrefRangeEnd = 1051532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.EditClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1051533, RefRangeEnd = 1051537, XrefRangeStart = 1051533, XrefRangeEnd = 1051537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.EditClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static EditClan()
      {
        Il2CppClassPointerStore<ClanEvents_Client.EditClan>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr, nameof (EditClan));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client.EditClan>.NativeClassPtr);
        ClanEvents_Client.EditClan.NativeFieldInfoPtr_ClanMotto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.EditClan>.NativeClassPtr, nameof (ClanMotto));
        ClanEvents_Client.EditClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.EditClan>.NativeClassPtr, 100690643);
        ClanEvents_Client.EditClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.EditClan>.NativeClassPtr, 100690644);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Client.EditClan>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InvitePlayerToClan
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayerName;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 PlayerName;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051531, RefRangeEnd = 1051532, XrefRangeStart = 1051531, XrefRangeEnd = 1051532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.InvitePlayerToClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1051533, RefRangeEnd = 1051537, XrefRangeStart = 1051533, XrefRangeEnd = 1051537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.InvitePlayerToClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InvitePlayerToClan()
      {
        Il2CppClassPointerStore<ClanEvents_Client.InvitePlayerToClan>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr, nameof (InvitePlayerToClan));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client.InvitePlayerToClan>.NativeClassPtr);
        ClanEvents_Client.InvitePlayerToClan.NativeFieldInfoPtr_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.InvitePlayerToClan>.NativeClassPtr, nameof (PlayerName));
        ClanEvents_Client.InvitePlayerToClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.InvitePlayerToClan>.NativeClassPtr, 100690645);
        ClanEvents_Client.InvitePlayerToClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.InvitePlayerToClan>.NativeClassPtr, 100690646);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Client.InvitePlayerToClan>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LeaveClan
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanId;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public NetworkId ClanId;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145109, XrefRangeEnd = 1145113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.LeaveClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1145117, RefRangeEnd = 1145118, XrefRangeStart = 1145113, XrefRangeEnd = 1145117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.LeaveClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static LeaveClan()
      {
        Il2CppClassPointerStore<ClanEvents_Client.LeaveClan>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr, nameof (LeaveClan));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client.LeaveClan>.NativeClassPtr);
        ClanEvents_Client.LeaveClan.NativeFieldInfoPtr_ClanId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.LeaveClan>.NativeClassPtr, nameof (ClanId));
        ClanEvents_Client.LeaveClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.LeaveClan>.NativeClassPtr, 100690647);
        ClanEvents_Client.LeaveClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.LeaveClan>.NativeClassPtr, 100690648);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Client.LeaveClan>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ClanInviteResponse
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanId;
      private static readonly System.IntPtr NativeFieldInfoPtr_Response;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public NetworkId ClanId;
      [FieldOffset(8)]
      public InviteRequestResponse Response;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145118, XrefRangeEnd = 1145123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.ClanInviteResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1145128, RefRangeEnd = 1145129, XrefRangeStart = 1145123, XrefRangeEnd = 1145128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.ClanInviteResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ClanInviteResponse()
      {
        Il2CppClassPointerStore<ClanEvents_Client.ClanInviteResponse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr, nameof (ClanInviteResponse));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client.ClanInviteResponse>.NativeClassPtr);
        ClanEvents_Client.ClanInviteResponse.NativeFieldInfoPtr_ClanId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.ClanInviteResponse>.NativeClassPtr, nameof (ClanId));
        ClanEvents_Client.ClanInviteResponse.NativeFieldInfoPtr_Response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.ClanInviteResponse>.NativeClassPtr, nameof (Response));
        ClanEvents_Client.ClanInviteResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.ClanInviteResponse>.NativeClassPtr, 100690649);
        ClanEvents_Client.ClanInviteResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.ClanInviteResponse>.NativeClassPtr, 100690650);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Client.ClanInviteResponse>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ChangeRole_Request
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetUserIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Role;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public int TargetUserIndex;
      [FieldOffset(4)]
      public ClanRoleEnum Role;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.ChangeRole_Request.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1145131, RefRangeEnd = 1145137, XrefRangeStart = 1145129, XrefRangeEnd = 1145131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.ChangeRole_Request.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ChangeRole_Request()
      {
        Il2CppClassPointerStore<ClanEvents_Client.ChangeRole_Request>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr, nameof (ChangeRole_Request));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client.ChangeRole_Request>.NativeClassPtr);
        ClanEvents_Client.ChangeRole_Request.NativeFieldInfoPtr_TargetUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.ChangeRole_Request>.NativeClassPtr, nameof (TargetUserIndex));
        ClanEvents_Client.ChangeRole_Request.NativeFieldInfoPtr_Role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.ChangeRole_Request>.NativeClassPtr, nameof (Role));
        ClanEvents_Client.ChangeRole_Request.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.ChangeRole_Request>.NativeClassPtr, 100690651);
        ClanEvents_Client.ChangeRole_Request.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.ChangeRole_Request>.NativeClassPtr, 100690652);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Client.ChangeRole_Request>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Kick_Request
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetUserIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public int TargetUserIndex;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145137, XrefRangeEnd = 1145138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.Kick_Request.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(32)]
      [CachedScanResults(RefRangeStart = 1145139, RefRangeEnd = 1145171, XrefRangeStart = 1145138, XrefRangeEnd = 1145139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClanEvents_Client.Kick_Request.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Kick_Request()
      {
        Il2CppClassPointerStore<ClanEvents_Client.Kick_Request>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanEvents_Client>.NativeClassPtr, nameof (Kick_Request));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanEvents_Client.Kick_Request>.NativeClassPtr);
        ClanEvents_Client.Kick_Request.NativeFieldInfoPtr_TargetUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanEvents_Client.Kick_Request>.NativeClassPtr, nameof (TargetUserIndex));
        ClanEvents_Client.Kick_Request.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.Kick_Request>.NativeClassPtr, 100690653);
        ClanEvents_Client.Kick_Request.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanEvents_Client.Kick_Request>.NativeClassPtr, 100690654);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanEvents_Client.Kick_Request>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
