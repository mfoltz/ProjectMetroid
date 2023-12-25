// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_adbijghdjjj
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
  public struct Snapshot_adbijghdjjj
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlot_AbilityBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlot_GroupGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlot_PreviousStateEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlot_SlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupSlot_StateEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_AbilityBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_GroupGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_PreviousStateEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_SlotId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_StateEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityGroupSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityGroupSlot;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId AbilityGroupSlot_AbilityBar;
    [FieldOffset(16)]
    public ModifiablePrefabGUID AbilityGroupSlot_GroupGuid;
    [FieldOffset(24)]
    public NetworkId AbilityGroupSlot_PreviousStateEntity;
    [FieldOffset(32)]
    public int AbilityGroupSlot_SlotId;
    [FieldOffset(36)]
    public NetworkId AbilityGroupSlot_StateEntity;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1538971, XrefRangeEnd = 1539025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbijghdjjj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1539055, RefRangeEnd = 1539056, XrefRangeStart = 1539025, XrefRangeEnd = 1539055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbijghdjjj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_adbijghdjjj()
    {
      Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_adbijghdjjj));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr);
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_AbilityGroupSlot_AbilityBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (AbilityGroupSlot_AbilityBar));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_AbilityGroupSlot_GroupGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (AbilityGroupSlot_GroupGuid));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_AbilityGroupSlot_PreviousStateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (AbilityGroupSlot_PreviousStateEntity));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_AbilityGroupSlot_SlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (AbilityGroupSlot_SlotId));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_AbilityGroupSlot_StateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (AbilityGroupSlot_StateEntity));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupSlot_Start));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedFields_AbilityGroupSlot_Count));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupSlot));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_AbilityBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupSlot_AbilityBar));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_GroupGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupSlot_GroupGuid));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_PreviousStateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupSlot_PreviousStateEntity));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_SlotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupSlot_SlotId));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_StateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (FrameChangedIndex_AbilityGroupSlot_StateEntity));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityGroupSlot));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (ComponentDataSize_AbilityGroupSlot));
      Snapshot_adbijghdjjj.NativeFieldInfoPtr_CompBit_AbilityGroupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, nameof (CompBit_AbilityGroupSlot));
      Snapshot_adbijghdjjj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, 100664298);
      Snapshot_adbijghdjjj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, 100664299);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_adbijghdjjj>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupSlot_Start
    {
      get
      {
        int abilityGroupSlotStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Start, (void*) &abilityGroupSlotStart);
        return abilityGroupSlotStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityGroupSlot_Count
    {
      get
      {
        int abilityGroupSlotCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Count, (void*) &abilityGroupSlotCount);
        return abilityGroupSlotCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedFields_AbilityGroupSlot_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupSlot
    {
      get
      {
        int abilityGroupSlot;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot, (void*) &abilityGroupSlot);
        return abilityGroupSlot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupSlot_AbilityBar
    {
      get
      {
        int groupSlotAbilityBar;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_AbilityBar, (void*) &groupSlotAbilityBar);
        return groupSlotAbilityBar;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_AbilityBar, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupSlot_GroupGuid
    {
      get
      {
        int groupSlotGroupGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_GroupGuid, (void*) &groupSlotGroupGuid);
        return groupSlotGroupGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_GroupGuid, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupSlot_PreviousStateEntity
    {
      get
      {
        int previousStateEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_PreviousStateEntity, (void*) &previousStateEntity);
        return previousStateEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_PreviousStateEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupSlot_SlotId
    {
      get
      {
        int abilityGroupSlotSlotId;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_SlotId, (void*) &abilityGroupSlotSlotId);
        return abilityGroupSlotSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_SlotId, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityGroupSlot_StateEntity
    {
      get
      {
        int groupSlotStateEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_StateEntity, (void*) &groupSlotStateEntity);
        return groupSlotStateEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_FrameChangedIndex_AbilityGroupSlot_StateEntity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityGroupSlot
    {
      get
      {
        int abilityGroupSlot;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupSlot, (void*) &abilityGroupSlot);
        return abilityGroupSlot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityGroupSlot, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityGroupSlot
    {
      get
      {
        int abilityGroupSlot;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupSlot, (void*) &abilityGroupSlot);
        return abilityGroupSlot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_ComponentDataSize_AbilityGroupSlot, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityGroupSlot
    {
      get
      {
        ulong abilityGroupSlot;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_CompBit_AbilityGroupSlot, (void*) &abilityGroupSlot);
        return abilityGroupSlot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbijghdjjj.NativeFieldInfoPtr_CompBit_AbilityGroupSlot, (void*) &value);
      }
    }
  }
}
