// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SerializeEntityParams
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Shared;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SerializeEntityParams
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastAckedServerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotPtr;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedPtr;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModsPerUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIdLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetProfiler;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesNetworked;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_Unboxed_1_Entity_ConnectedUser_TerrainChunk_NetworkId_Int32_IntPtr_IntPtr_ParallelJobWriter_NativeHashMap_2_NetworkId_EntitySyncType_PrefabGUID_SyncRegistry_Server_1_SpellModSet_NativeHashMap_2_NetworkId_Entity_0;
    [FieldOffset(0)]
    public readonly Nullable_Unboxed<Unity.Entities.Entity> Entity;
    [FieldOffset(12)]
    public readonly ConnectedUser ConnectedUser;
    [FieldOffset(16)]
    public readonly TerrainChunk UserChunk;
    [FieldOffset(24)]
    public readonly int LastAckedServerFrame;
    [FieldOffset(32)]
    public readonly System.IntPtr SnapshotPtr;
    [FieldOffset(40)]
    public readonly System.IntPtr FrameChangedPtr;
    [FieldOffset(48)]
    public readonly PrefabGUID PrefabGUID;
    [FieldOffset(52)]
    public readonly NetworkId NetworkId;
    [FieldOffset(64)]
    public readonly SyncRegistry_Server<SpellModSet> SpellModsPerUser;
    [FieldOffset(104)]
    public NativeHashMap<NetworkId, Unity.Entities.Entity> NetworkIdLookup;
    [FieldOffset(120)]
    public NetProfilerData.ParallelJobWriter NetProfiler;
    [FieldOffset(128)]
    public NativeHashMap<NetworkId, EntitySyncType> EntitiesNetworked;

    [CallerCount(0)]
    public unsafe SerializeEntityParams(
      Nullable_Unboxed<Unity.Entities.Entity> entity,
      ConnectedUser connectedUser,
      TerrainChunk userChunk,
      NetworkId networkId,
      int lastAckedServerFrame,
      System.IntPtr snapshotPtr,
      System.IntPtr frameChangedPtr,
      NetProfilerData.ParallelJobWriter netProfiler,
      NativeHashMap<NetworkId, EntitySyncType> entitiesNetworked,
      PrefabGUID prefabGuid,
      SyncRegistry_Server<SpellModSet> spellModsPerUser,
      NativeHashMap<NetworkId, Unity.Entities.Entity> networkIdLookup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &connectedUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &userChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lastAckedServerFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &frameChangedPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &netProfiler;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &entitiesNetworked;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModsPerUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &networkIdLookup;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeEntityParams.NativeMethodInfoPtr__ctor_Public_Void_Nullable_Unboxed_1_Entity_ConnectedUser_TerrainChunk_NetworkId_Int32_IntPtr_IntPtr_ParallelJobWriter_NativeHashMap_2_NetworkId_EntitySyncType_PrefabGUID_SyncRegistry_Server_1_SpellModSet_NativeHashMap_2_NetworkId_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializeEntityParams()
    {
      Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (SerializeEntityParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr);
      SerializeEntityParams.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (Entity));
      SerializeEntityParams.NativeFieldInfoPtr_ConnectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (ConnectedUser));
      SerializeEntityParams.NativeFieldInfoPtr_UserChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (UserChunk));
      SerializeEntityParams.NativeFieldInfoPtr_LastAckedServerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (LastAckedServerFrame));
      SerializeEntityParams.NativeFieldInfoPtr_SnapshotPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (SnapshotPtr));
      SerializeEntityParams.NativeFieldInfoPtr_FrameChangedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (FrameChangedPtr));
      SerializeEntityParams.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (PrefabGUID));
      SerializeEntityParams.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (NetworkId));
      SerializeEntityParams.NativeFieldInfoPtr_SpellModsPerUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (SpellModsPerUser));
      SerializeEntityParams.NativeFieldInfoPtr_NetworkIdLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (NetworkIdLookup));
      SerializeEntityParams.NativeFieldInfoPtr_NetProfiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (NetProfiler));
      SerializeEntityParams.NativeFieldInfoPtr_EntitiesNetworked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, nameof (EntitiesNetworked));
      SerializeEntityParams.NativeMethodInfoPtr__ctor_Public_Void_Nullable_Unboxed_1_Entity_ConnectedUser_TerrainChunk_NetworkId_Int32_IntPtr_IntPtr_ParallelJobWriter_NativeHashMap_2_NetworkId_EntitySyncType_PrefabGUID_SyncRegistry_Server_1_SpellModSet_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, 100669197);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeEntityParams>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
