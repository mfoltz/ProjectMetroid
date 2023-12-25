// Decompiled with JetBrains decompiler
// Type: ProjectM.ForceJoinClanEvents
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ForceJoinClanEvents
  {
    static ForceJoinClanEvents()
    {
      Il2CppClassPointerStore<ForceJoinClanEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ForceJoinClanEvents));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJoinClanEvents>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForceJoinClanEvents>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Request_ByClosestToPosition
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public float3 Position;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051523, XrefRangeEnd = 1051526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.Request_ByClosestToPosition.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051529, RefRangeEnd = 1051530, XrefRangeStart = 1051526, XrefRangeEnd = 1051529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.Request_ByClosestToPosition.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Request_ByClosestToPosition()
      {
        Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByClosestToPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForceJoinClanEvents>.NativeClassPtr, nameof (Request_ByClosestToPosition));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByClosestToPosition>.NativeClassPtr);
        ForceJoinClanEvents.Request_ByClosestToPosition.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByClosestToPosition>.NativeClassPtr, nameof (Position));
        ForceJoinClanEvents.Request_ByClosestToPosition.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByClosestToPosition>.NativeClassPtr, 100682613);
        ForceJoinClanEvents.Request_ByClosestToPosition.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByClosestToPosition>.NativeClassPtr, 100682614);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByClosestToPosition>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Request_ByPlayerName
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 Name;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1051531, RefRangeEnd = 1051532, XrefRangeStart = 1051530, XrefRangeEnd = 1051531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.Request_ByPlayerName.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1051533, RefRangeEnd = 1051537, XrefRangeStart = 1051532, XrefRangeEnd = 1051533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.Request_ByPlayerName.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Request_ByPlayerName()
      {
        Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByPlayerName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForceJoinClanEvents>.NativeClassPtr, nameof (Request_ByPlayerName));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByPlayerName>.NativeClassPtr);
        ForceJoinClanEvents.Request_ByPlayerName.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByPlayerName>.NativeClassPtr, nameof (Name));
        ForceJoinClanEvents.Request_ByPlayerName.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByPlayerName>.NativeClassPtr, 100682615);
        ForceJoinClanEvents.Request_ByPlayerName.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByPlayerName>.NativeClassPtr, 100682616);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForceJoinClanEvents.Request_ByPlayerName>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ErrorResponse
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Error;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public ForceJoinClanEvents.ErrorResponse.ErrorKind Error;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051537, XrefRangeEnd = 1051538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.ErrorResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 1051539, RefRangeEnd = 1051545, XrefRangeStart = 1051538, XrefRangeEnd = 1051539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.ErrorResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ErrorResponse()
      {
        Il2CppClassPointerStore<ForceJoinClanEvents.ErrorResponse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForceJoinClanEvents>.NativeClassPtr, nameof (ErrorResponse));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJoinClanEvents.ErrorResponse>.NativeClassPtr);
        ForceJoinClanEvents.ErrorResponse.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceJoinClanEvents.ErrorResponse>.NativeClassPtr, nameof (Error));
        ForceJoinClanEvents.ErrorResponse.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.ErrorResponse>.NativeClassPtr, 100682617);
        ForceJoinClanEvents.ErrorResponse.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.ErrorResponse>.NativeClassPtr, 100682618);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForceJoinClanEvents.ErrorResponse>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public enum ErrorKind
      {
        SenderAlreadyInClan,
        TargetNotInClan,
        NoPlayerFound,
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AdminForceJoinedYourClan
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
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.AdminForceJoinedYourClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(ForceJoinClanEvents.AdminForceJoinedYourClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AdminForceJoinedYourClan()
      {
        Il2CppClassPointerStore<ForceJoinClanEvents.AdminForceJoinedYourClan>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForceJoinClanEvents>.NativeClassPtr, nameof (AdminForceJoinedYourClan));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceJoinClanEvents.AdminForceJoinedYourClan>.NativeClassPtr);
        ForceJoinClanEvents.AdminForceJoinedYourClan.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.AdminForceJoinedYourClan>.NativeClassPtr, 100682619);
        ForceJoinClanEvents.AdminForceJoinedYourClan.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceJoinClanEvents.AdminForceJoinedYourClan>.NativeClassPtr, 100682620);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForceJoinClanEvents.AdminForceJoinedYourClan>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
