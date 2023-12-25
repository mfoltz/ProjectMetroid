﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cgbeibighh
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cgbeibighh
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityOwner_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityOwner_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Script_SetFlyingHeightVision_Buff_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Script_SetFlyingHeightVision_Buff_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Script_SetFlyingHeightVision_Buff_DataShared;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId AbilityOwner_Ability;
    [FieldOffset(16)]
    public NetworkId AbilityOwner_AbilityGroup;
    [FieldOffset(24)]
    public byte Buff_Stacks;
    [FieldOffset(25)]
    public double Buff_StartTimeUnmodified;
    [FieldOffset(33)]
    public NetworkId Buff_Target;
    [FieldOffset(41)]
    public NetworkId EntityCreator_Creator;
    [FieldOffset(49)]
    public NetworkId EntityOwner_Owner;
    [FieldOffset(57)]
    public bool Script_SetFlyingHeightVision_Buff_DataShared_BuffActive;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1569277, XrefRangeEnd = 1569318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cgbeibighh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1569359, RefRangeEnd = 1569360, XrefRangeStart = 1569318, XrefRangeEnd = 1569359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cgbeibighh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cgbeibighh()
    {
      Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cgbeibighh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr);
      Snapshot_cgbeibighh.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_AbilityOwner_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (AbilityOwner_Ability));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_AbilityOwner_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (AbilityOwner_AbilityGroup));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (Script_SetFlyingHeightVision_Buff_DataShared_BuffActive));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_AbilityOwner_Start));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_AbilityOwner_Count));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Start));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Count));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityOwner_Ability));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_AbilityOwner_AbilityGroup));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataSize_AbilityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_Script_SetFlyingHeightVision_Buff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataStartOffset_Script_SetFlyingHeightVision_Buff_DataShared));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_Script_SetFlyingHeightVision_Buff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (ComponentDataSize_Script_SetFlyingHeightVision_Buff_DataShared));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (CompBit_AbilityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_Script_SetFlyingHeightVision_Buff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, nameof (CompBit_Script_SetFlyingHeightVision_Buff_DataShared));
      Snapshot_cgbeibighh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, 100664528);
      Snapshot_cgbeibighh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, 100664529);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cgbeibighh>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityOwner_Start
    {
      get
      {
        int abilityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start, (void*) &abilityOwnerStart);
        return abilityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityOwner_Count
    {
      get
      {
        int abilityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count, (void*) &abilityOwnerCount);
        return abilityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Start
    {
      get
      {
        int buffDataSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Start, (void*) &buffDataSharedStart);
        return buffDataSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Count
    {
      get
      {
        int buffDataSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Count, (void*) &buffDataSharedCount);
        return buffDataSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedFields_Script_SetFlyingHeightVision_Buff_DataShared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityOwner
    {
      get
      {
        int indexAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner, (void*) &indexAbilityOwner);
        return indexAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared
    {
      get
      {
        int visionBuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &visionBuffDataShared);
        return visionBuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityOwner_Ability
    {
      get
      {
        int abilityOwnerAbility;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability, (void*) &abilityOwnerAbility);
        return abilityOwnerAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityOwner_AbilityGroup
    {
      get
      {
        int ownerAbilityGroup;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup, (void*) &ownerAbilityGroup);
        return ownerAbilityGroup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive
    {
      get
      {
        int sharedBuffActive;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive, (void*) &sharedBuffActive);
        return sharedBuffActive;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_FrameChangedIndex_Script_SetFlyingHeightVision_Buff_DataShared_BuffActive, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityOwner
    {
      get
      {
        int offsetAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner, (void*) &offsetAbilityOwner);
        return offsetAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityOwner
    {
      get
      {
        int sizeAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_AbilityOwner, (void*) &sizeAbilityOwner);
        return sizeAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Script_SetFlyingHeightVision_Buff_DataShared
    {
      get
      {
        int visionBuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &visionBuffDataShared);
        return visionBuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataStartOffset_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Script_SetFlyingHeightVision_Buff_DataShared
    {
      get
      {
        int visionBuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &visionBuffDataShared);
        return visionBuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_ComponentDataSize_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityOwner
    {
      get
      {
        ulong compBitAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_AbilityOwner, (void*) &compBitAbilityOwner);
        return compBitAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Script_SetFlyingHeightVision_Buff_DataShared
    {
      get
      {
        ulong visionBuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &visionBuffDataShared);
        return visionBuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cgbeibighh.NativeFieldInfoPtr_CompBit_Script_SetFlyingHeightVision_Buff_DataShared, (void*) &value);
      }
    }
  }
}
