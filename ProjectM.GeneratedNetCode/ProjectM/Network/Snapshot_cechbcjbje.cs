// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cechbcjbje
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
  public struct Snapshot_cechbcjbje
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Durability_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equippable_EquipTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Durability_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Durability_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equippable_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equippable_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Durability_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Equippable;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float Durability_Value;
    [FieldOffset(12)]
    public NetworkId Equippable_EquipTarget;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1561613, XrefRangeEnd = 1561657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cechbcjbje.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1561674, RefRangeEnd = 1561675, XrefRangeStart = 1561657, XrefRangeEnd = 1561674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cechbcjbje.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cechbcjbje()
    {
      Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cechbcjbje));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr);
      Snapshot_cechbcjbje.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_Durability_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (Durability_Value));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_Equippable_EquipTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (Equippable_EquipTarget));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Durability_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedFields_Durability_Start));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Durability_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedFields_Durability_Count));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedFields_Equippable_Start));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedFields_Equippable_Count));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedIndex_Durability));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedIndex_Equippable));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Durability_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedIndex_Durability_Value));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (FrameChangedIndex_Equippable_EquipTarget));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataStartOffset_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (ComponentDataStartOffset_Durability));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataSize_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (ComponentDataSize_Durability));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (ComponentDataStartOffset_Equippable));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataSize_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (ComponentDataSize_Equippable));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_CompBit_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (CompBit_Durability));
      Snapshot_cechbcjbje.NativeFieldInfoPtr_CompBit_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, nameof (CompBit_Equippable));
      Snapshot_cechbcjbje.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, 100664482);
      Snapshot_cechbcjbje.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, 100664483);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cechbcjbje>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Durability_Start
    {
      get
      {
        int fieldsDurabilityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Durability_Start, (void*) &fieldsDurabilityStart);
        return fieldsDurabilityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Durability_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Durability_Count
    {
      get
      {
        int fieldsDurabilityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Durability_Count, (void*) &fieldsDurabilityCount);
        return fieldsDurabilityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Durability_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equippable_Start
    {
      get
      {
        int fieldsEquippableStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start, (void*) &fieldsEquippableStart);
        return fieldsEquippableStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equippable_Count
    {
      get
      {
        int fieldsEquippableCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count, (void*) &fieldsEquippableCount);
        return fieldsEquippableCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Durability
    {
      get
      {
        int changedIndexDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Durability, (void*) &changedIndexDurability);
        return changedIndexDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Durability, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equippable
    {
      get
      {
        int changedIndexEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Equippable, (void*) &changedIndexEquippable);
        return changedIndexEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Equippable, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Durability_Value
    {
      get
      {
        int indexDurabilityValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Durability_Value, (void*) &indexDurabilityValue);
        return indexDurabilityValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Durability_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equippable_EquipTarget
    {
      get
      {
        int equippableEquipTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget, (void*) &equippableEquipTarget);
        return equippableEquipTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Durability
    {
      get
      {
        int offsetDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataStartOffset_Durability, (void*) &offsetDurability);
        return offsetDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataStartOffset_Durability, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Durability
    {
      get
      {
        int dataSizeDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataSize_Durability, (void*) &dataSizeDurability);
        return dataSizeDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataSize_Durability, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Equippable
    {
      get
      {
        int offsetEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable, (void*) &offsetEquippable);
        return offsetEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Equippable
    {
      get
      {
        int dataSizeEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataSize_Equippable, (void*) &dataSizeEquippable);
        return dataSizeEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_ComponentDataSize_Equippable, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Durability
    {
      get
      {
        ulong compBitDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_CompBit_Durability, (void*) &compBitDurability);
        return compBitDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_CompBit_Durability, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Equippable
    {
      get
      {
        ulong compBitEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_CompBit_Equippable, (void*) &compBitEquippable);
        return compBitEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cechbcjbje.NativeFieldInfoPtr_CompBit_Equippable, (void*) &value);
      }
    }
  }
}
