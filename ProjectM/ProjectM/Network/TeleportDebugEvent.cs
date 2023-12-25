// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.TeleportDebugEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TeleportDebugEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MousePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Location;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocationNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocationPosition;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public float3 MousePosition;
    [FieldOffset(12)]
    public TeleportDebugEvent.TeleportTarget Target;
    [FieldOffset(16)]
    public NetworkId TargetNetworkId;
    [FieldOffset(24)]
    public TeleportDebugEvent.TeleportLocation Location;
    [FieldOffset(28)]
    public NetworkId LocationNetworkId;
    [FieldOffset(36)]
    public float3 LocationPosition;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145182, XrefRangeEnd = 1145195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145208, RefRangeEnd = 1145209, XrefRangeStart = 1145195, XrefRangeEnd = 1145208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TeleportDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TeleportDebugEvent()
    {
      Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (TeleportDebugEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr);
      TeleportDebugEvent.NativeFieldInfoPtr_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, nameof (MousePosition));
      TeleportDebugEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, nameof (Target));
      TeleportDebugEvent.NativeFieldInfoPtr_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, nameof (TargetNetworkId));
      TeleportDebugEvent.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, nameof (Location));
      TeleportDebugEvent.NativeFieldInfoPtr_LocationNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, nameof (LocationNetworkId));
      TeleportDebugEvent.NativeFieldInfoPtr_LocationPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, nameof (LocationPosition));
      TeleportDebugEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, 100690671);
      TeleportDebugEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, 100690672);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TeleportDebugEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum TeleportTarget
    {
      Self,
      ClosestEnemy,
      ClosestAlly,
      ClosestPlayer,
      ClosestUnit,
      ClosestEnemyToCursor,
      ClosestAllyToCursor,
      ClosestPlayerToCursor,
      ClosestUnitToCursor,
      AllPlayers,
      AllUnits,
      AllAllies,
      AllEnemies,
      AllOtherPlayers,
      AllOtherAllies,
      User,
    }

    public enum TeleportLocation
    {
      Cursor,
      Self,
      WorldPosition,
      TilePosition,
      Nether,
      User,
      Chunk,
      Waypoint,
    }
  }
}
