// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugViewData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.UI
{
  public sealed class DebugViewData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Fps;
    private static readonly System.IntPtr NativeFieldInfoPtr_Positions;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeFieldInfoPtr_Network;
    private static readonly System.IntPtr NativeFieldInfoPtr_Archetype;
    private static readonly System.IntPtr NativeFieldInfoPtr_Chunks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Replay;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetStreaming;

    static DebugViewData()
    {
      Il2CppClassPointerStore<DebugViewData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugViewData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr);
      DebugViewData.NativeFieldInfoPtr_Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (Fps));
      DebugViewData.NativeFieldInfoPtr_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (Positions));
      DebugViewData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (Entities));
      DebugViewData.NativeFieldInfoPtr_Network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (Network));
      DebugViewData.NativeFieldInfoPtr_Archetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (Archetype));
      DebugViewData.NativeFieldInfoPtr_Chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (Chunks));
      DebugViewData.NativeFieldInfoPtr_Replay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (Replay));
      DebugViewData.NativeFieldInfoPtr_AssetStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (AssetStreaming));
    }

    public DebugViewData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public DebugViewData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, data));
    }

    public unsafe DebugViewData.FpsData Fps
    {
      get
      {
        return *(DebugViewData.FpsData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Fps));
      }
      [param: In] set
      {
        *(DebugViewData.FpsData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Fps)) = value;
      }
    }

    public DebugViewData.PositionData Positions
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Positions);
        return new DebugViewData.PositionData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Positions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe DebugViewData.EntityData Entities
    {
      get
      {
        return *(DebugViewData.EntityData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Entities));
      }
      [param: In] set
      {
        *(DebugViewData.EntityData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Entities)) = value;
      }
    }

    public DebugViewData.NetworkData Network
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Network);
        return new DebugViewData.NetworkData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Network), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe DebugViewData.ArchetypeData Archetype
    {
      get
      {
        return *(DebugViewData.ArchetypeData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Archetype));
      }
      [param: In] set
      {
        *(DebugViewData.ArchetypeData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Archetype)) = value;
      }
    }

    public unsafe DebugViewData.ChunksData Chunks
    {
      get
      {
        return *(DebugViewData.ChunksData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Chunks));
      }
      [param: In] set
      {
        *(DebugViewData.ChunksData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Chunks)) = value;
      }
    }

    public unsafe DebugViewData.ReplayData Replay
    {
      get
      {
        return *(DebugViewData.ReplayData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Replay));
      }
      [param: In] set
      {
        *(DebugViewData.ReplayData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_Replay)) = value;
      }
    }

    public unsafe DebugViewData.AssetStreamingData AssetStreaming
    {
      get
      {
        return *(DebugViewData.AssetStreamingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_AssetStreaming));
      }
      [param: In] set
      {
        *(DebugViewData.AssetStreamingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NativeFieldInfoPtr_AssetStreaming)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FpsData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Fps;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerFrameTimeMS;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientFrameTimeMS;
      [FieldOffset(0)]
      public int Fps;
      [FieldOffset(4)]
      public float ServerFrameTimeMS;
      [FieldOffset(8)]
      public float ClientFrameTimeMS;

      static FpsData()
      {
        Il2CppClassPointerStore<DebugViewData.FpsData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (FpsData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.FpsData>.NativeClassPtr);
        DebugViewData.FpsData.NativeFieldInfoPtr_Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.FpsData>.NativeClassPtr, nameof (Fps));
        DebugViewData.FpsData.NativeFieldInfoPtr_ServerFrameTimeMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.FpsData>.NativeClassPtr, nameof (ServerFrameTimeMS));
        DebugViewData.FpsData.NativeFieldInfoPtr_ClientFrameTimeMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.FpsData>.NativeClassPtr, nameof (ClientFrameTimeMS));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.FpsData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class PositionData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentChunk;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalCoordinate;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldCoordinate;
      private static readonly System.IntPtr NativeFieldInfoPtr_MousePositionWorld;

      static PositionData()
      {
        Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (PositionData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr);
        DebugViewData.PositionData.NativeFieldInfoPtr_CurrentChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, nameof (CurrentChunk));
        DebugViewData.PositionData.NativeFieldInfoPtr_LocalCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, nameof (LocalCoordinate));
        DebugViewData.PositionData.NativeFieldInfoPtr_WorldCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, nameof (WorldCoordinate));
        DebugViewData.PositionData.NativeFieldInfoPtr_MousePositionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, nameof (MousePositionWorld));
      }

      public PositionData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public PositionData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.PositionData>.NativeClassPtr, data));
      }

      public unsafe string CurrentChunk
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_CurrentChunk)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_CurrentChunk), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe float2 LocalCoordinate
      {
        get
        {
          return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_LocalCoordinate));
        }
        [param: In] set
        {
          *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_LocalCoordinate)) = value;
        }
      }

      public unsafe float3 WorldCoordinate
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_WorldCoordinate));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_WorldCoordinate)) = value;
        }
      }

      public unsafe float3 MousePositionWorld
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_MousePositionWorld));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.PositionData.NativeFieldInfoPtr_MousePositionWorld)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerEntitiesDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerEntitiesEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientEntitiesDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientEntitiesEnabled;
      [FieldOffset(0)]
      public Nullable_Unboxed<int> ServerEntitiesDisabled;
      [FieldOffset(8)]
      public Nullable_Unboxed<int> ServerEntitiesEnabled;
      [FieldOffset(16)]
      public int ClientEntitiesDisabled;
      [FieldOffset(20)]
      public int ClientEntitiesEnabled;

      static EntityData()
      {
        Il2CppClassPointerStore<DebugViewData.EntityData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (EntityData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.EntityData>.NativeClassPtr);
        DebugViewData.EntityData.NativeFieldInfoPtr_ServerEntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.EntityData>.NativeClassPtr, nameof (ServerEntitiesDisabled));
        DebugViewData.EntityData.NativeFieldInfoPtr_ServerEntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.EntityData>.NativeClassPtr, nameof (ServerEntitiesEnabled));
        DebugViewData.EntityData.NativeFieldInfoPtr_ClientEntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.EntityData>.NativeClassPtr, nameof (ClientEntitiesDisabled));
        DebugViewData.EntityData.NativeFieldInfoPtr_ClientEntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.EntityData>.NativeClassPtr, nameof (ClientEntitiesEnabled));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.EntityData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class NetworkData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Latency;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientConnectState;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerNetworkedEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientNetworkedEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxServerUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientNetworkStatsString;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerNetworkStatsString;

      static NetworkData()
      {
        Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (NetworkData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr);
        DebugViewData.NetworkData.NativeFieldInfoPtr_Latency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (Latency));
        DebugViewData.NetworkData.NativeFieldInfoPtr_ClientConnectState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (ClientConnectState));
        DebugViewData.NetworkData.NativeFieldInfoPtr_ServerNetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (ServerNetworkedEntities));
        DebugViewData.NetworkData.NativeFieldInfoPtr_ClientNetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (ClientNetworkedEntities));
        DebugViewData.NetworkData.NativeFieldInfoPtr_ServerUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (ServerUsers));
        DebugViewData.NetworkData.NativeFieldInfoPtr_MaxServerUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (MaxServerUsers));
        DebugViewData.NetworkData.NativeFieldInfoPtr_ClientUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (ClientUsers));
        DebugViewData.NetworkData.NativeFieldInfoPtr_ClientNetworkStatsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (ClientNetworkStatsString));
        DebugViewData.NetworkData.NativeFieldInfoPtr_ServerNetworkStatsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, nameof (ServerNetworkStatsString));
      }

      public NetworkData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public NetworkData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.NetworkData>.NativeClassPtr, data));
      }

      public unsafe int Latency
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_Latency));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_Latency)) = value;
        }
      }

      public unsafe ClientConnectState ClientConnectState
      {
        get
        {
          return *(ClientConnectState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientConnectState));
        }
        [param: In] set
        {
          *(ClientConnectState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientConnectState)) = value;
        }
      }

      public unsafe Nullable_Unboxed<int> ServerNetworkedEntities
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ServerNetworkedEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ServerNetworkedEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe int ClientNetworkedEntities
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientNetworkedEntities));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientNetworkedEntities)) = value;
        }
      }

      public unsafe Nullable_Unboxed<int> ServerUsers
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ServerUsers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ServerUsers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<int> MaxServerUsers
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_MaxServerUsers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_MaxServerUsers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe int ClientUsers
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientUsers));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientUsers)) = value;
        }
      }

      public unsafe string ClientNetworkStatsString
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientNetworkStatsString)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ClientNetworkStatsString), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string ServerNetworkStatsString
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ServerNetworkStatsString)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewData.NetworkData.NativeFieldInfoPtr_ServerNetworkStatsString), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ArchetypeData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerArchetypeCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientArchetypeCount;
      [FieldOffset(0)]
      public Nullable_Unboxed<int> ServerArchetypeCount;
      [FieldOffset(8)]
      public int ClientArchetypeCount;

      static ArchetypeData()
      {
        Il2CppClassPointerStore<DebugViewData.ArchetypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (ArchetypeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.ArchetypeData>.NativeClassPtr);
        DebugViewData.ArchetypeData.NativeFieldInfoPtr_ServerArchetypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ArchetypeData>.NativeClassPtr, nameof (ServerArchetypeCount));
        DebugViewData.ArchetypeData.NativeFieldInfoPtr_ClientArchetypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ArchetypeData>.NativeClassPtr, nameof (ClientArchetypeCount));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.ArchetypeData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ChunksData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerChunksTotal;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerChunksRequested;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerChunksLoaded;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientChunksTotal;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientChunksRequested;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientChunksLoaded;
      [FieldOffset(0)]
      public Nullable_Unboxed<int> ServerChunksTotal;
      [FieldOffset(8)]
      public Nullable_Unboxed<int> ServerChunksRequested;
      [FieldOffset(16)]
      public Nullable_Unboxed<int> ServerChunksLoaded;
      [FieldOffset(24)]
      public int ClientChunksTotal;
      [FieldOffset(28)]
      public int ClientChunksRequested;
      [FieldOffset(32)]
      public int ClientChunksLoaded;

      static ChunksData()
      {
        Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (ChunksData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr);
        DebugViewData.ChunksData.NativeFieldInfoPtr_ServerChunksTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr, nameof (ServerChunksTotal));
        DebugViewData.ChunksData.NativeFieldInfoPtr_ServerChunksRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr, nameof (ServerChunksRequested));
        DebugViewData.ChunksData.NativeFieldInfoPtr_ServerChunksLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr, nameof (ServerChunksLoaded));
        DebugViewData.ChunksData.NativeFieldInfoPtr_ClientChunksTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr, nameof (ClientChunksTotal));
        DebugViewData.ChunksData.NativeFieldInfoPtr_ClientChunksRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr, nameof (ClientChunksRequested));
        DebugViewData.ChunksData.NativeFieldInfoPtr_ClientChunksLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr, nameof (ClientChunksLoaded));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.ChunksData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ReplayData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_State;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSnapshot;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPercent;
      [FieldOffset(0)]
      public DebugViewData.ReplayData.ReplayState State;
      [FieldOffset(4)]
      public int CurrentSnapshot;
      [FieldOffset(8)]
      public double CurrentTime;
      [FieldOffset(16)]
      public float CurrentPercent;

      static ReplayData()
      {
        Il2CppClassPointerStore<DebugViewData.ReplayData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (ReplayData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.ReplayData>.NativeClassPtr);
        DebugViewData.ReplayData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ReplayData>.NativeClassPtr, nameof (State));
        DebugViewData.ReplayData.NativeFieldInfoPtr_CurrentSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ReplayData>.NativeClassPtr, nameof (CurrentSnapshot));
        DebugViewData.ReplayData.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ReplayData>.NativeClassPtr, nameof (CurrentTime));
        DebugViewData.ReplayData.NativeFieldInfoPtr_CurrentPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.ReplayData>.NativeClassPtr, nameof (CurrentPercent));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.ReplayData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public enum ReplayState
      {
        None,
        Recording,
        Playback,
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AssetStreamingData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalHybridSections;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalClientUISections;
      private static readonly System.IntPtr NativeFieldInfoPtr_LoadedHybridSections;
      private static readonly System.IntPtr NativeFieldInfoPtr_LoadedClientUISections;
      [FieldOffset(0)]
      public int TotalHybridSections;
      [FieldOffset(4)]
      public int TotalClientUISections;
      [FieldOffset(8)]
      public int LoadedHybridSections;
      [FieldOffset(12)]
      public int LoadedClientUISections;

      static AssetStreamingData()
      {
        Il2CppClassPointerStore<DebugViewData.AssetStreamingData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, nameof (AssetStreamingData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewData.AssetStreamingData>.NativeClassPtr);
        DebugViewData.AssetStreamingData.NativeFieldInfoPtr_TotalHybridSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.AssetStreamingData>.NativeClassPtr, nameof (TotalHybridSections));
        DebugViewData.AssetStreamingData.NativeFieldInfoPtr_TotalClientUISections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.AssetStreamingData>.NativeClassPtr, nameof (TotalClientUISections));
        DebugViewData.AssetStreamingData.NativeFieldInfoPtr_LoadedHybridSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.AssetStreamingData>.NativeClassPtr, nameof (LoadedHybridSections));
        DebugViewData.AssetStreamingData.NativeFieldInfoPtr_LoadedClientUISections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewData.AssetStreamingData>.NativeClassPtr, nameof (LoadedClientUISections));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData.AssetStreamingData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
