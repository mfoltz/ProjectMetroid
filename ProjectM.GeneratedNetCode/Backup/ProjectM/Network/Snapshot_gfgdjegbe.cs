﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_gfgdjegbe
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_gfgdjegbe
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelBuff_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelBuff_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TravelBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TravelBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TravelBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TravelBuff;
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
    public NetworkId EntityCreator_Creator;
    [FieldOffset(33)]
    public NetworkId EntityOwner_Owner;
    [FieldOffset(41)]
    public float LifeTime_Duration;
    [FieldOffset(45)]
    public int Team_FactionIndex;
    [FieldOffset(49)]
    public int Team_Value;
    [FieldOffset(53)]
    public float3 TravelBuff_EndPosition;
    [FieldOffset(65)]
    public float3 TravelBuff_StartPosition;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1584979, XrefRangeEnd = 1585077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_gfgdjegbe.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1585122, RefRangeEnd = 1585123, XrefRangeStart = 1585077, XrefRangeEnd = 1585122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_gfgdjegbe.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_gfgdjegbe()
    {
      Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_gfgdjegbe));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr);
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (Team_Value));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_TravelBuff_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (TravelBuff_EndPosition));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_TravelBuff_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (TravelBuff_StartPosition));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_TravelBuff_Start));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedFields_TravelBuff_Count));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_TravelBuff));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_TravelBuff_EndPosition));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (FrameChangedIndex_TravelBuff_StartPosition));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_TravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataStartOffset_TravelBuff));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_TravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (ComponentDataSize_TravelBuff));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_TravelBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, nameof (CompBit_TravelBuff));
      Snapshot_gfgdjegbe.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, 100664678);
      Snapshot_gfgdjegbe.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, 100664679);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_gfgdjegbe>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TravelBuff_Start
    {
      get
      {
        int fieldsTravelBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Start, (void*) &fieldsTravelBuffStart);
        return fieldsTravelBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TravelBuff_Count
    {
      get
      {
        int fieldsTravelBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Count, (void*) &fieldsTravelBuffCount);
        return fieldsTravelBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedFields_TravelBuff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TravelBuff
    {
      get
      {
        int changedIndexTravelBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff, (void*) &changedIndexTravelBuff);
        return changedIndexTravelBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TravelBuff_EndPosition
    {
      get
      {
        int travelBuffEndPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_EndPosition, (void*) &travelBuffEndPosition);
        return travelBuffEndPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_EndPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TravelBuff_StartPosition
    {
      get
      {
        int buffStartPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_StartPosition, (void*) &buffStartPosition);
        return buffStartPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_FrameChangedIndex_TravelBuff_StartPosition, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TravelBuff
    {
      get
      {
        int offsetTravelBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_TravelBuff, (void*) &offsetTravelBuff);
        return offsetTravelBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataStartOffset_TravelBuff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TravelBuff
    {
      get
      {
        int dataSizeTravelBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_TravelBuff, (void*) &dataSizeTravelBuff);
        return dataSizeTravelBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_ComponentDataSize_TravelBuff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TravelBuff
    {
      get
      {
        ulong compBitTravelBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_TravelBuff, (void*) &compBitTravelBuff);
        return compBitTravelBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_gfgdjegbe.NativeFieldInfoPtr_CompBit_TravelBuff, (void*) &value);
      }
    }
  }
}
