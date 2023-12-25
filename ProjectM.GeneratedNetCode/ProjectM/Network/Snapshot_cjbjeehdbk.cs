// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cjbjeehdbk
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cjbjeehdbk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityChargesState_ChargeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityChargesState_CurrentCharges;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupState_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupState_GroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupState_SlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_ChargeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_CurrentCharges;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityChargesState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityChargesState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityChargesState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityGroupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityStateBuffer;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AbilityStateBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AbilityStateBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float AbilityChargesState_ChargeTime;
    [FieldOffset(12)]
    public int AbilityChargesState_CurrentCharges;
    [FieldOffset(16)]
    public NetworkId AbilityGroupState_Character;
    [FieldOffset(24)]
    public PrefabGUID AbilityGroupState_GroupId;
    [FieldOffset(28)]
    public int AbilityGroupState_SlotIndex;
    [FieldOffset(32)]
    public NetworkId EntityOwner_Owner;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1573552, XrefRangeEnd = 1573688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data,
      ref BufferFromEntity<Snapshot_AbilityStateBuffer> get_buffer_AbilityStateBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref get_buffer_AbilityStateBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cjbjeehdbk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AbilityStateBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1573731, RefRangeEnd = 1573732, XrefRangeStart = 1573688, XrefRangeEnd = 1573731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      DynamicBuffer<Snapshot_AbilityStateBuffer> buffer_AbilityStateBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer_AbilityStateBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cjbjeehdbk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AbilityStateBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cjbjeehdbk()
    {
      Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cjbjeehdbk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr);
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_AbilityChargesState_ChargeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (AbilityChargesState_ChargeTime));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_AbilityChargesState_CurrentCharges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (AbilityChargesState_CurrentCharges));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_AbilityGroupState_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (AbilityGroupState_Character));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_AbilityGroupState_GroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (AbilityGroupState_GroupId));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_AbilityGroupState_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (AbilityGroupState_SlotIndex));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedFields_AbilityChargesState_Start));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedFields_AbilityChargesState_Count));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupState_Start));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupState_Count));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityChargesState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityStateBuffer));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_ChargeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityChargesState_ChargeTime));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_CurrentCharges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityChargesState_CurrentCharges));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState_Character));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState_GroupId));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState_SlotIndex));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityChargesState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityChargesState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_AbilityChargesState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (ComponentDataSize_AbilityChargesState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityGroupState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (ComponentDataSize_AbilityGroupState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityChargesState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (CompBit_AbilityChargesState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (CompBit_AbilityGroupState));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, nameof (CompBit_AbilityStateBuffer));
      Snapshot_cjbjeehdbk.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AbilityStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, 100664568);
      Snapshot_cjbjeehdbk.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AbilityStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, 100664569);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cjbjeehdbk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityChargesState_Start
    {
      get
      {
        int chargesStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Start, (void*) &chargesStateStart);
        return chargesStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityChargesState_Count
    {
      get
      {
        int chargesStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Count, (void*) &chargesStateCount);
        return chargesStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityChargesState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupState_Start
    {
      get
      {
        int abilityGroupStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start, (void*) &abilityGroupStateStart);
        return abilityGroupStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupState_Count
    {
      get
      {
        int abilityGroupStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count, (void*) &abilityGroupStateCount);
        return abilityGroupStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityChargesState
    {
      get
      {
        int abilityChargesState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState, (void*) &abilityChargesState);
        return abilityChargesState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState
    {
      get
      {
        int abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityStateBuffer
    {
      get
      {
        int abilityStateBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer, (void*) &abilityStateBuffer);
        return abilityStateBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityChargesState_ChargeTime
    {
      get
      {
        int chargesStateChargeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_ChargeTime, (void*) &chargesStateChargeTime);
        return chargesStateChargeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_ChargeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityChargesState_CurrentCharges
    {
      get
      {
        int stateCurrentCharges;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_CurrentCharges, (void*) &stateCurrentCharges);
        return stateCurrentCharges;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityChargesState_CurrentCharges, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState_Character
    {
      get
      {
        int groupStateCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character, (void*) &groupStateCharacter);
        return groupStateCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState_GroupId
    {
      get
      {
        int groupStateGroupId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId, (void*) &groupStateGroupId);
        return groupStateGroupId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState_SlotIndex
    {
      get
      {
        int groupStateSlotIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex, (void*) &groupStateSlotIndex);
        return groupStateSlotIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityChargesState
    {
      get
      {
        int abilityChargesState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityChargesState, (void*) &abilityChargesState);
        return abilityChargesState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityChargesState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityChargesState
    {
      get
      {
        int abilityChargesState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_AbilityChargesState, (void*) &abilityChargesState);
        return abilityChargesState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_AbilityChargesState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityGroupState
    {
      get
      {
        int abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityGroupState
    {
      get
      {
        int abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityChargesState
    {
      get
      {
        ulong abilityChargesState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityChargesState, (void*) &abilityChargesState);
        return abilityChargesState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityChargesState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityGroupState
    {
      get
      {
        ulong abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityStateBuffer
    {
      get
      {
        ulong abilityStateBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityStateBuffer, (void*) &abilityStateBuffer);
        return abilityStateBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cjbjeehdbk.NativeFieldInfoPtr_CompBit_AbilityStateBuffer, (void*) &value);
      }
    }
  }
}
