// Decompiled with JetBrains decompiler
// Type: ProjectM.TeleportEvents_ToServer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TeleportEvents_ToServer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TeleportEvents_ToServer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TeleportEvents_ToServer()
    {
      Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TeleportEvents_ToServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr);
      TeleportEvents_ToServer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr, 100681475);
    }

    public TeleportEvents_ToServer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TeleportToWaypointEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FromWaypoint;
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetChunkWaypoint;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public NetworkId FromWaypoint;
      [FieldOffset(8)]
      public NetworkId TargetChunkWaypoint;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040456, XrefRangeEnd = 1040461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.TeleportToWaypointEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1040466, RefRangeEnd = 1040467, XrefRangeStart = 1040461, XrefRangeEnd = 1040466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.TeleportToWaypointEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TeleportToWaypointEvent()
      {
        Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToWaypointEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr, nameof (TeleportToWaypointEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToWaypointEvent>.NativeClassPtr);
        TeleportEvents_ToServer.TeleportToWaypointEvent.NativeFieldInfoPtr_FromWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToWaypointEvent>.NativeClassPtr, nameof (FromWaypoint));
        TeleportEvents_ToServer.TeleportToWaypointEvent.NativeFieldInfoPtr_TargetChunkWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToWaypointEvent>.NativeClassPtr, nameof (TargetChunkWaypoint));
        TeleportEvents_ToServer.TeleportToWaypointEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToWaypointEvent>.NativeClassPtr, 100681476);
        TeleportEvents_ToServer.TeleportToWaypointEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToWaypointEvent>.NativeClassPtr, 100681477);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToWaypointEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TeleportToNetherEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FromChunkWaypoint;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public NetworkId FromChunkWaypoint;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040467, XrefRangeEnd = 1040471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.TeleportToNetherEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1040475, RefRangeEnd = 1040476, XrefRangeStart = 1040471, XrefRangeEnd = 1040475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.TeleportToNetherEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TeleportToNetherEvent()
      {
        Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToNetherEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr, nameof (TeleportToNetherEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToNetherEvent>.NativeClassPtr);
        TeleportEvents_ToServer.TeleportToNetherEvent.NativeFieldInfoPtr_FromChunkWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToNetherEvent>.NativeClassPtr, nameof (FromChunkWaypoint));
        TeleportEvents_ToServer.TeleportToNetherEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToNetherEvent>.NativeClassPtr, 100681478);
        TeleportEvents_ToServer.TeleportToNetherEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToNetherEvent>.NativeClassPtr, 100681479);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportEvents_ToServer.TeleportToNetherEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DebugTeleportToEntityEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public NetworkId TargetEntity;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1040476, XrefRangeEnd = 1040480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.DebugTeleportToEntityEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1040484, RefRangeEnd = 1040485, XrefRangeStart = 1040480, XrefRangeEnd = 1040484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.DebugTeleportToEntityEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DebugTeleportToEntityEvent()
      {
        Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToEntityEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr, nameof (DebugTeleportToEntityEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToEntityEvent>.NativeClassPtr);
        TeleportEvents_ToServer.DebugTeleportToEntityEvent.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToEntityEvent>.NativeClassPtr, nameof (TargetEntity));
        TeleportEvents_ToServer.DebugTeleportToEntityEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToEntityEvent>.NativeClassPtr, 100681480);
        TeleportEvents_ToServer.DebugTeleportToEntityEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToEntityEvent>.NativeClassPtr, 100681481);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToEntityEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DebugTeleportToNetherEvent
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
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.DebugTeleportToNetherEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(TeleportEvents_ToServer.DebugTeleportToNetherEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DebugTeleportToNetherEvent()
      {
        Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToNetherEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TeleportEvents_ToServer>.NativeClassPtr, nameof (DebugTeleportToNetherEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToNetherEvent>.NativeClassPtr);
        TeleportEvents_ToServer.DebugTeleportToNetherEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToNetherEvent>.NativeClassPtr, 100681482);
        TeleportEvents_ToServer.DebugTeleportToNetherEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToNetherEvent>.NativeClassPtr, 100681483);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportEvents_ToServer.DebugTeleportToNetherEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
