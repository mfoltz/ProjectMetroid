﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acjbgiffidc
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

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
  public struct Snapshot_acjbgiffidc
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyAfterDuration_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FallToHeight_Gravity;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_PlayOnSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_SecondaryTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceForEntity_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Rotation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_DestroyAfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_FallToHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InteractedUpon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_UserOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InventoryBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_InventoryBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public double DestroyAfterDuration_EndTime;
    [FieldOffset(16)]
    public ModifiableFloat FallToHeight_Gravity;
    [FieldOffset(24)]
    public bool InteractedUpon_Interacting;
    [FieldOffset(25)]
    public quaternion Rotation_Value;
    [FieldOffset(41)]
    public bool SpawnSequenceForEntity_PlayOnSelf;
    [FieldOffset(42)]
    public float SpawnSequenceForEntity_Scale;
    [FieldOffset(46)]
    public NetworkId SpawnSequenceForEntity_SecondaryTarget;
    [FieldOffset(54)]
    public SequenceGUID SpawnSequenceForEntity_SequenceGuid;
    [FieldOffset(58)]
    public NetworkId SpawnSequenceForEntity_Target;
    [FieldOffset(66)]
    public float3 Translation_Value;
    [FieldOffset(78)]
    public NetworkId UserOwner_Owner;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1536031, XrefRangeEnd = 1536184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_InventoryBuffer> get_buffer_InventoryBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_InventoryBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acjbgiffidc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1536254, RefRangeEnd = 1536255, XrefRangeStart = 1536184, XrefRangeEnd = 1536254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_InventoryBuffer> buffer_InventoryBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_InventoryBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acjbgiffidc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acjbgiffidc()
    {
      Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acjbgiffidc));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr);
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_DestroyAfterDuration_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (DestroyAfterDuration_EndTime));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FallToHeight_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FallToHeight_Gravity));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (InteractedUpon_Interacting));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (Rotation_Value));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_SpawnSequenceForEntity_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (SpawnSequenceForEntity_PlayOnSelf));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_SpawnSequenceForEntity_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (SpawnSequenceForEntity_Scale));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_SpawnSequenceForEntity_SecondaryTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (SpawnSequenceForEntity_SecondaryTarget));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_SpawnSequenceForEntity_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (SpawnSequenceForEntity_SequenceGuid));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_SpawnSequenceForEntity_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (SpawnSequenceForEntity_Target));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_UserOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (UserOwner_Owner));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_DestroyAfterDuration_Start));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_DestroyAfterDuration_Count));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_FallToHeight_Start));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_FallToHeight_Count));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Start));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_InteractedUpon_Count));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Start));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_Rotation_Count));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_SpawnSequenceForEntity_Start));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_SpawnSequenceForEntity_Count));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_UserOwner_Start));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedFields_UserOwner_Count));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_DestroyAfterDuration));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_FallToHeight));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_Rotation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_UserOwner));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_InventoryBuffer));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_DestroyAfterDuration_EndTime));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_FallToHeight_Gravity));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_InteractedUpon_Interacting));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_Rotation_Value));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_Scale));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_SpawnSequenceForEntity_Target));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (FrameChangedIndex_UserOwner_Owner));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataStartOffset_DestroyAfterDuration));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataSize_DestroyAfterDuration));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataStartOffset_FallToHeight));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataSize_FallToHeight));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataStartOffset_InteractedUpon));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataSize_InteractedUpon));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataStartOffset_Rotation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataSize_Rotation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataStartOffset_SpawnSequenceForEntity));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataSize_SpawnSequenceForEntity));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataStartOffset_UserOwner));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (ComponentDataSize_UserOwner));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_DestroyAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_DestroyAfterDuration));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_FallToHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_FallToHeight));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_InteractedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_InteractedUpon));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_Rotation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_SpawnSequenceForEntity));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_UserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_UserOwner));
      Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, nameof (CompBit_InventoryBuffer));
      Snapshot_acjbgiffidc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, 100664262);
      Snapshot_acjbgiffidc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, 100664263);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acjbgiffidc>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DestroyAfterDuration_Start
    {
      get
      {
        int afterDurationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start, (void*) &afterDurationStart);
        return afterDurationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_DestroyAfterDuration_Count
    {
      get
      {
        int afterDurationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count, (void*) &afterDurationCount);
        return afterDurationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_DestroyAfterDuration_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FallToHeight_Start
    {
      get
      {
        int fallToHeightStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start, (void*) &fallToHeightStart);
        return fallToHeightStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FallToHeight_Count
    {
      get
      {
        int fallToHeightCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count, (void*) &fallToHeightCount);
        return fallToHeightCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_FallToHeight_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Start
    {
      get
      {
        int interactedUponStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &interactedUponStart);
        return interactedUponStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InteractedUpon_Count
    {
      get
      {
        int interactedUponCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &interactedUponCount);
        return interactedUponCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_InteractedUpon_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Start
    {
      get
      {
        int fieldsRotationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &fieldsRotationStart);
        return fieldsRotationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Rotation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Rotation_Count
    {
      get
      {
        int fieldsRotationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &fieldsRotationCount);
        return fieldsRotationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Rotation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnSequenceForEntity_Start
    {
      get
      {
        int sequenceForEntityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start, (void*) &sequenceForEntityStart);
        return sequenceForEntityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpawnSequenceForEntity_Count
    {
      get
      {
        int sequenceForEntityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count, (void*) &sequenceForEntityCount);
        return sequenceForEntityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_SpawnSequenceForEntity_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UserOwner_Start
    {
      get
      {
        int fieldsUserOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start, (void*) &fieldsUserOwnerStart);
        return fieldsUserOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_UserOwner_Count
    {
      get
      {
        int fieldsUserOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count, (void*) &fieldsUserOwnerCount);
        return fieldsUserOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedFields_UserOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DestroyAfterDuration
    {
      get
      {
        int destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FallToHeight
    {
      get
      {
        int indexFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight, (void*) &indexFallToHeight);
        return indexFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon
    {
      get
      {
        int indexInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &indexInteractedUpon);
        return indexInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation
    {
      get
      {
        int changedIndexRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &changedIndexRotation);
        return changedIndexRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UserOwner
    {
      get
      {
        int changedIndexUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_UserOwner, (void*) &changedIndexUserOwner);
        return changedIndexUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_UserOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InventoryBuffer
    {
      get
      {
        int indexInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer, (void*) &indexInventoryBuffer);
        return indexInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InventoryBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_DestroyAfterDuration_EndTime
    {
      get
      {
        int afterDurationEndTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime, (void*) &afterDurationEndTime);
        return afterDurationEndTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_DestroyAfterDuration_EndTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FallToHeight_Gravity
    {
      get
      {
        int fallToHeightGravity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity, (void*) &fallToHeightGravity);
        return fallToHeightGravity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_FallToHeight_Gravity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InteractedUpon_Interacting
    {
      get
      {
        int interactedUponInteracting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &interactedUponInteracting);
        return interactedUponInteracting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_InteractedUpon_Interacting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Rotation_Value
    {
      get
      {
        int indexRotationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &indexRotationValue);
        return indexRotationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Rotation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf
    {
      get
      {
        int entityPlayOnSelf;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf, (void*) &entityPlayOnSelf);
        return entityPlayOnSelf;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_PlayOnSelf, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_Scale
    {
      get
      {
        int sequenceForEntityScale;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale, (void*) &sequenceForEntityScale);
        return sequenceForEntityScale;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Scale, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget
    {
      get
      {
        int entitySecondaryTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget, (void*) &entitySecondaryTarget);
        return entitySecondaryTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SecondaryTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid
    {
      get
      {
        int entitySequenceGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid, (void*) &entitySequenceGuid);
        return entitySequenceGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_SequenceGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpawnSequenceForEntity_Target
    {
      get
      {
        int sequenceForEntityTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target, (void*) &sequenceForEntityTarget);
        return sequenceForEntityTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_SpawnSequenceForEntity_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_UserOwner_Owner
    {
      get
      {
        int indexUserOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner, (void*) &indexUserOwnerOwner);
        return indexUserOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_FrameChangedIndex_UserOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_DestroyAfterDuration
    {
      get
      {
        int destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_DestroyAfterDuration
    {
      get
      {
        int destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_FallToHeight
    {
      get
      {
        int offsetFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight, (void*) &offsetFallToHeight);
        return offsetFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_FallToHeight, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_FallToHeight
    {
      get
      {
        int sizeFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_FallToHeight, (void*) &sizeFallToHeight);
        return sizeFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_FallToHeight, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InteractedUpon
    {
      get
      {
        int offsetInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &offsetInteractedUpon);
        return offsetInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InteractedUpon
    {
      get
      {
        int sizeInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &sizeInteractedUpon);
        return sizeInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Rotation
    {
      get
      {
        int startOffsetRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &startOffsetRotation);
        return startOffsetRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Rotation
    {
      get
      {
        int dataSizeRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &dataSizeRotation);
        return dataSizeRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_Rotation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpawnSequenceForEntity
    {
      get
      {
        int sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_UserOwner
    {
      get
      {
        int startOffsetUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner, (void*) &startOffsetUserOwner);
        return startOffsetUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataStartOffset_UserOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_UserOwner
    {
      get
      {
        int dataSizeUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_UserOwner, (void*) &dataSizeUserOwner);
        return dataSizeUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_ComponentDataSize_UserOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_DestroyAfterDuration
    {
      get
      {
        ulong destroyAfterDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_DestroyAfterDuration, (void*) &destroyAfterDuration);
        return destroyAfterDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_DestroyAfterDuration, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_FallToHeight
    {
      get
      {
        ulong compBitFallToHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_FallToHeight, (void*) &compBitFallToHeight);
        return compBitFallToHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_FallToHeight, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InteractedUpon
    {
      get
      {
        ulong bitInteractedUpon;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &bitInteractedUpon);
        return bitInteractedUpon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_InteractedUpon, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Rotation
    {
      get
      {
        ulong compBitRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_Rotation, (void*) &compBitRotation);
        return compBitRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_Rotation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpawnSequenceForEntity
    {
      get
      {
        ulong sequenceForEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity, (void*) &sequenceForEntity);
        return sequenceForEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_SpawnSequenceForEntity, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_UserOwner
    {
      get
      {
        ulong compBitUserOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_UserOwner, (void*) &compBitUserOwner);
        return compBitUserOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_UserOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InventoryBuffer
    {
      get
      {
        ulong bitInventoryBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_InventoryBuffer, (void*) &bitInventoryBuffer);
        return bitInventoryBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjbgiffidc.NativeFieldInfoPtr_CompBit_InventoryBuffer, (void*) &value);
      }
    }
  }
}
