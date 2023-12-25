// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.SerializeReplaySnapshotChunksJob
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Replays
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SerializeReplaySnapshotChunksJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Chunks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuids;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedComponentLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedComponentSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedComponentSizes;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkIndexToNetworkIdMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetBufferData;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetBufferLengthBitsResult;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public NativeArray<ArchetypeChunk> Chunks;
    [FieldOffset(16)]
    public NativeArray<Entity> Entities;
    [FieldOffset(32)]
    public NativeArray<PrefabGUID> PrefabGuids;
    [FieldOffset(48)]
    public NativeArray<NetworkId> NetworkIds;
    [FieldOffset(64)]
    public NativeHashMap<int, int> NetworkedComponentLookup;
    [FieldOffset(80)]
    public NativeHashSet<int> NetworkedComponentSet;
    [FieldOffset(96)]
    public NativeArray<int> NetworkedComponentSizes;
    [FieldOffset(112)]
    public NativeHashMap<int, NetworkId> GetNetworkIndexToNetworkIdMap;
    [FieldOffset(128)]
    public NativeArray<byte> NetBufferData;
    [FieldOffset(144)]
    public NativeArray<int> NetBufferLengthBitsResult;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1483622, XrefRangeEnd = 1483710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializeReplaySnapshotChunksJob()
    {
      Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Replays", nameof (SerializeReplaySnapshotChunksJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr);
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_Chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (Chunks));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (Entities));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_PrefabGuids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (PrefabGuids));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_NetworkIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (NetworkIds));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_NetworkedComponentLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (NetworkedComponentLookup));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_NetworkedComponentSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (NetworkedComponentSet));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_NetworkedComponentSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (NetworkedComponentSizes));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_GetNetworkIndexToNetworkIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (GetNetworkIndexToNetworkIdMap));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_NetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (NetBufferData));
      SerializeReplaySnapshotChunksJob.NativeFieldInfoPtr_NetBufferLengthBitsResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (NetBufferLengthBitsResult));
      SerializeReplaySnapshotChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, 100663725);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ComponentInfo
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TypeIndexInArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedComponentIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsBuffer;
      [FieldOffset(0)]
      public int TypeIndexInArchetype;
      [FieldOffset(4)]
      public int NetworkedComponentIndex;
      [FieldOffset(8)]
      public bool IsBuffer;

      static ComponentInfo()
      {
        Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob.ComponentInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob>.NativeClassPtr, nameof (ComponentInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob.ComponentInfo>.NativeClassPtr);
        SerializeReplaySnapshotChunksJob.ComponentInfo.NativeFieldInfoPtr_TypeIndexInArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob.ComponentInfo>.NativeClassPtr, nameof (TypeIndexInArchetype));
        SerializeReplaySnapshotChunksJob.ComponentInfo.NativeFieldInfoPtr_NetworkedComponentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob.ComponentInfo>.NativeClassPtr, nameof (NetworkedComponentIndex));
        SerializeReplaySnapshotChunksJob.ComponentInfo.NativeFieldInfoPtr_IsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob.ComponentInfo>.NativeClassPtr, nameof (IsBuffer));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeReplaySnapshotChunksJob.ComponentInfo>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
