// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acgfefhihji
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acgfefhihji
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeathRagdollForce_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff_FeedProgressTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff_FeedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff_IsFed;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MountBuff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_MountBuff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MountBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedProgressTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Health;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MountBuff_IsFed;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MountBuff_MaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_MountBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_MountBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DeathRagdollForce;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_HybridModelSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_MountBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public byte Buff_Stacks;
    [FieldOffset(9)]
    public double Buff_StartTimeUnmodified;
    [FieldOffset(17)]
    public NetworkId Buff_Target;
    [FieldOffset(25)]
    public float3 DeathRagdollForce_Force;
    [FieldOffset(37)]
    public NetworkId EntityCreator_Creator;
    [FieldOffset(45)]
    public NetworkId EntityOwner_Owner;
    [FieldOffset(53)]
    public ushort HybridModelSeed_Seed;
    [FieldOffset(55)]
    public float LifeTime_Duration;
    [FieldOffset(59)]
    public float MountBuff_FeedProgressTime;
    [FieldOffset(63)]
    public float MountBuff_FeedTime;
    [FieldOffset(67)]
    public float MountBuff_Health;
    [FieldOffset(71)]
    public bool MountBuff_IsFed;
    [FieldOffset(72)]
    public float MountBuff_MaxHealth;
    [FieldOffset(76)]
    public FixedString64 MountBuff_Name;
    [FieldOffset(140)]
    public NetworkId SpellTarget_Target;
    [FieldOffset(148)]
    public int Team_FactionIndex;
    [FieldOffset(152)]
    public int Team_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1531752, XrefRangeEnd = 1531865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acgfefhihji.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1531926, RefRangeEnd = 1531927, XrefRangeStart = 1531865, XrefRangeEnd = 1531926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acgfefhihji.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acgfefhihji()
    {
      Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acgfefhihji));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr);
      Snapshot_acgfefhihji.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_DeathRagdollForce_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (DeathRagdollForce_Force));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (HybridModelSeed_Seed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_MountBuff_FeedProgressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (MountBuff_FeedProgressTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_MountBuff_FeedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (MountBuff_FeedTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_MountBuff_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (MountBuff_Health));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_MountBuff_IsFed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (MountBuff_IsFed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_MountBuff_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (MountBuff_MaxHealth));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_MountBuff_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (MountBuff_Name));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_SpellTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (SpellTarget_Target));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (Team_Value));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_DeathRagdollForce_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_DeathRagdollForce_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_HybridModelSeed_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_MountBuff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_MountBuff_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_MountBuff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_MountBuff_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_SpellTarget_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_SpellTarget_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_DeathRagdollForce));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_MountBuff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_SpellTarget));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_DeathRagdollForce_Force));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_HybridModelSeed_Seed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedProgressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_MountBuff_FeedProgressTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_MountBuff_FeedTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_MountBuff_Health));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_IsFed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_MountBuff_IsFed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_MountBuff_MaxHealth));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_MountBuff_Name));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_SpellTarget_Target));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_DeathRagdollForce));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_DeathRagdollForce));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_HybridModelSeed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_HybridModelSeed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_MountBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_MountBuff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_MountBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_MountBuff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_SpellTarget));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_SpellTarget));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_DeathRagdollForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_DeathRagdollForce));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_HybridModelSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_HybridModelSeed));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_MountBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_MountBuff));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_SpellTarget));
      Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_acgfefhihji.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, 100664206);
      Snapshot_acgfefhihji.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, 100664207);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acgfefhihji>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DeathRagdollForce_Start
    {
      get
      {
        int ragdollForceStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start, (void*) &ragdollForceStart);
        return ragdollForceStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DeathRagdollForce_Count
    {
      get
      {
        int ragdollForceCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count, (void*) &ragdollForceCount);
        return ragdollForceCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_DeathRagdollForce_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Start
    {
      get
      {
        int hybridModelSeedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &hybridModelSeedStart);
        return hybridModelSeedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_HybridModelSeed_Count
    {
      get
      {
        int hybridModelSeedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &hybridModelSeedCount);
        return hybridModelSeedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_HybridModelSeed_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MountBuff_Start
    {
      get
      {
        int fieldsMountBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_MountBuff_Start, (void*) &fieldsMountBuffStart);
        return fieldsMountBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_MountBuff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_MountBuff_Count
    {
      get
      {
        int fieldsMountBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_MountBuff_Count, (void*) &fieldsMountBuffCount);
        return fieldsMountBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_MountBuff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellTarget_Start
    {
      get
      {
        int spellTargetStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start, (void*) &spellTargetStart);
        return spellTargetStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellTarget_Count
    {
      get
      {
        int spellTargetCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count, (void*) &spellTargetCount);
        return spellTargetCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed
    {
      get
      {
        int indexHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &indexHybridModelSeed);
        return indexHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MountBuff
    {
      get
      {
        int changedIndexMountBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff, (void*) &changedIndexMountBuff);
        return changedIndexMountBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellTarget
    {
      get
      {
        int indexSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget, (void*) &indexSpellTarget);
        return indexSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DeathRagdollForce_Force
    {
      get
      {
        int ragdollForceForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force, (void*) &ragdollForceForce);
        return ragdollForceForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_DeathRagdollForce_Force, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_HybridModelSeed_Seed
    {
      get
      {
        int hybridModelSeedSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &hybridModelSeedSeed);
        return hybridModelSeedSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_HybridModelSeed_Seed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MountBuff_FeedProgressTime
    {
      get
      {
        int feedProgressTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedProgressTime, (void*) &feedProgressTime);
        return feedProgressTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedProgressTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MountBuff_FeedTime
    {
      get
      {
        int mountBuffFeedTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedTime, (void*) &mountBuffFeedTime);
        return mountBuffFeedTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_FeedTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MountBuff_Health
    {
      get
      {
        int indexMountBuffHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Health, (void*) &indexMountBuffHealth);
        return indexMountBuffHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Health, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MountBuff_IsFed
    {
      get
      {
        int indexMountBuffIsFed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_IsFed, (void*) &indexMountBuffIsFed);
        return indexMountBuffIsFed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_IsFed, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MountBuff_MaxHealth
    {
      get
      {
        int mountBuffMaxHealth;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_MaxHealth, (void*) &mountBuffMaxHealth);
        return mountBuffMaxHealth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_MaxHealth, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_MountBuff_Name
    {
      get
      {
        int indexMountBuffName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Name, (void*) &indexMountBuffName);
        return indexMountBuffName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_MountBuff_Name, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellTarget_Target
    {
      get
      {
        int spellTargetTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target, (void*) &spellTargetTarget);
        return spellTargetTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DeathRagdollForce
    {
      get
      {
        int deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_HybridModelSeed
    {
      get
      {
        int offsetHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &offsetHybridModelSeed);
        return offsetHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_HybridModelSeed
    {
      get
      {
        int sizeHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &sizeHybridModelSeed);
        return sizeHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_MountBuff
    {
      get
      {
        int startOffsetMountBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_MountBuff, (void*) &startOffsetMountBuff);
        return startOffsetMountBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_MountBuff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_MountBuff
    {
      get
      {
        int dataSizeMountBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_MountBuff, (void*) &dataSizeMountBuff);
        return dataSizeMountBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_MountBuff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpellTarget
    {
      get
      {
        int offsetSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget, (void*) &offsetSpellTarget);
        return offsetSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpellTarget
    {
      get
      {
        int dataSizeSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_SpellTarget, (void*) &dataSizeSpellTarget);
        return dataSizeSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DeathRagdollForce
    {
      get
      {
        ulong deathRagdollForce;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_DeathRagdollForce, (void*) &deathRagdollForce);
        return deathRagdollForce;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_DeathRagdollForce, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_HybridModelSeed
    {
      get
      {
        ulong bitHybridModelSeed;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &bitHybridModelSeed);
        return bitHybridModelSeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_HybridModelSeed, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_MountBuff
    {
      get
      {
        ulong compBitMountBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_MountBuff, (void*) &compBitMountBuff);
        return compBitMountBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_MountBuff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpellTarget
    {
      get
      {
        ulong compBitSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_SpellTarget, (void*) &compBitSpellTarget);
        return compBitSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_SpellTarget, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acgfefhihji.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }
  }
}
