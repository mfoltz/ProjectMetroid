// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ackebkbdbjj
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
  public struct Snapshot_ackebkbdbjj
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equippable_EquipTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equippable_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equippable_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Equippable;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public NetworkId Equippable_EquipTarget;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1538057, XrefRangeEnd = 1538067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ackebkbdbjj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1538079, RefRangeEnd = 1538080, XrefRangeStart = 1538067, XrefRangeEnd = 1538079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_ackebkbdbjj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_ackebkbdbjj()
    {
      Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ackebkbdbjj));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr);
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_Equippable_EquipTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (Equippable_EquipTarget));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (FrameChangedFields_Equippable_Start));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (FrameChangedFields_Equippable_Count));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedIndex_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (FrameChangedIndex_Equippable));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (FrameChangedIndex_Equippable_EquipTarget));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (ComponentDataStartOffset_Equippable));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_ComponentDataSize_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (ComponentDataSize_Equippable));
      Snapshot_ackebkbdbjj.NativeFieldInfoPtr_CompBit_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, nameof (CompBit_Equippable));
      Snapshot_ackebkbdbjj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, 100664276);
      Snapshot_ackebkbdbjj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, 100664277);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ackebkbdbjj>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equippable_Start
    {
      get
      {
        int fieldsEquippableStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start, (void*) &fieldsEquippableStart);
        return fieldsEquippableStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equippable_Count
    {
      get
      {
        int fieldsEquippableCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count, (void*) &fieldsEquippableCount);
        return fieldsEquippableCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equippable
    {
      get
      {
        int changedIndexEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedIndex_Equippable, (void*) &changedIndexEquippable);
        return changedIndexEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedIndex_Equippable, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equippable_EquipTarget
    {
      get
      {
        int equippableEquipTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget, (void*) &equippableEquipTarget);
        return equippableEquipTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Equippable
    {
      get
      {
        int offsetEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable, (void*) &offsetEquippable);
        return offsetEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Equippable
    {
      get
      {
        int dataSizeEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_ComponentDataSize_Equippable, (void*) &dataSizeEquippable);
        return dataSizeEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_ComponentDataSize_Equippable, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Equippable
    {
      get
      {
        ulong compBitEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_CompBit_Equippable, (void*) &compBitEquippable);
        return compBitEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_ackebkbdbjj.NativeFieldInfoPtr_CompBit_Equippable, (void*) &value);
      }
    }
  }
}
