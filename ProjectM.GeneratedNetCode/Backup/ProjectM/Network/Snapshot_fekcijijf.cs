﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_fekcijijf
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
  public struct Snapshot_fekcijijf
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupComboState_ComboIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupState_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupState_GroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupState_SlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState_ComboIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupComboState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityGroupComboState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityGroupComboState;
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
    public int AbilityGroupComboState_ComboIndex;
    [FieldOffset(12)]
    public NetworkId AbilityGroupState_Character;
    [FieldOffset(20)]
    public PrefabGUID AbilityGroupState_GroupId;
    [FieldOffset(24)]
    public int AbilityGroupState_SlotIndex;
    [FieldOffset(28)]
    public NetworkId EntityOwner_Owner;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1582140, XrefRangeEnd = 1582243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fekcijijf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AbilityStateBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1582282, RefRangeEnd = 1582283, XrefRangeStart = 1582243, XrefRangeEnd = 1582282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fekcijijf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AbilityStateBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_fekcijijf()
    {
      Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_fekcijijf));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr);
      Snapshot_fekcijijf.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_fekcijijf.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_fekcijijf.NativeFieldInfoPtr_AbilityGroupComboState_ComboIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (AbilityGroupComboState_ComboIndex));
      Snapshot_fekcijijf.NativeFieldInfoPtr_AbilityGroupState_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (AbilityGroupState_Character));
      Snapshot_fekcijijf.NativeFieldInfoPtr_AbilityGroupState_GroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (AbilityGroupState_GroupId));
      Snapshot_fekcijijf.NativeFieldInfoPtr_AbilityGroupState_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (AbilityGroupState_SlotIndex));
      Snapshot_fekcijijf.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_fekcijijf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupComboState_Start));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupComboState_Count));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupState_Start));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupState_Count));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupComboState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_AbilityStateBuffer));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState_ComboIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupComboState_ComboIndex));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState_Character));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState_GroupId));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupState_SlotIndex));
      Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupComboState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityGroupComboState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupComboState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (ComponentDataSize_AbilityGroupComboState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityGroupState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (ComponentDataSize_AbilityGroupState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityGroupComboState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (CompBit_AbilityGroupComboState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityGroupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (CompBit_AbilityGroupState));
      Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, nameof (CompBit_AbilityStateBuffer));
      Snapshot_fekcijijf.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_byref_BufferFromEntity_1_Snapshot_AbilityStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, 100664652);
      Snapshot_fekcijijf.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_DynamicBuffer_1_Snapshot_AbilityStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, 100664653);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_fekcijijf>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupComboState_Start
    {
      get
      {
        int groupComboStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Start, (void*) &groupComboStateStart);
        return groupComboStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupComboState_Count
    {
      get
      {
        int groupComboStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Count, (void*) &groupComboStateCount);
        return groupComboStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupComboState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupState_Start
    {
      get
      {
        int abilityGroupStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start, (void*) &abilityGroupStateStart);
        return abilityGroupStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupState_Count
    {
      get
      {
        int abilityGroupStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count, (void*) &abilityGroupStateCount);
        return abilityGroupStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupComboState
    {
      get
      {
        int abilityGroupComboState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState, (void*) &abilityGroupComboState);
        return abilityGroupComboState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState
    {
      get
      {
        int abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityStateBuffer
    {
      get
      {
        int abilityStateBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer, (void*) &abilityStateBuffer);
        return abilityStateBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityStateBuffer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupComboState_ComboIndex
    {
      get
      {
        int comboStateComboIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState_ComboIndex, (void*) &comboStateComboIndex);
        return comboStateComboIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupComboState_ComboIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState_Character
    {
      get
      {
        int groupStateCharacter;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character, (void*) &groupStateCharacter);
        return groupStateCharacter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_Character, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState_GroupId
    {
      get
      {
        int groupStateGroupId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId, (void*) &groupStateGroupId);
        return groupStateGroupId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_GroupId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupState_SlotIndex
    {
      get
      {
        int groupStateSlotIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex, (void*) &groupStateSlotIndex);
        return groupStateSlotIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupState_SlotIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityGroupComboState
    {
      get
      {
        int abilityGroupComboState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupComboState, (void*) &abilityGroupComboState);
        return abilityGroupComboState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupComboState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityGroupComboState
    {
      get
      {
        int abilityGroupComboState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupComboState, (void*) &abilityGroupComboState);
        return abilityGroupComboState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupComboState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityGroupState
    {
      get
      {
        int abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityGroupState
    {
      get
      {
        int abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityGroupComboState
    {
      get
      {
        ulong abilityGroupComboState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityGroupComboState, (void*) &abilityGroupComboState);
        return abilityGroupComboState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityGroupComboState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityGroupState
    {
      get
      {
        ulong abilityGroupState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityGroupState, (void*) &abilityGroupState);
        return abilityGroupState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityGroupState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityStateBuffer
    {
      get
      {
        ulong abilityStateBuffer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityStateBuffer, (void*) &abilityStateBuffer);
        return abilityStateBuffer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fekcijijf.NativeFieldInfoPtr_CompBit_AbilityStateBuffer, (void*) &value);
      }
    }
  }
}
