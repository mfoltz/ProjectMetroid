// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cijeifhgec
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
  public struct Snapshot_cijeifhgec
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_Script_CurseAreaDebuff_DataShared_IsInArea;
    private static readonly System.IntPtr NativeFieldInfoPtr_Script_CurseAreaDebuff_DataShared_StackSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_IsInArea;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_StackSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Script_CurseAreaDebuff_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Script_CurseAreaDebuff_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Script_CurseAreaDebuff_DataShared;
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
    public bool Script_CurseAreaDebuff_DataShared_IsInArea;
    [FieldOffset(42)]
    public byte Script_CurseAreaDebuff_DataShared_StackSize;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1572993, XrefRangeEnd = 1573023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cijeifhgec.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1573053, RefRangeEnd = 1573054, XrefRangeStart = 1573023, XrefRangeEnd = 1573053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cijeifhgec.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cijeifhgec()
    {
      Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cijeifhgec));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr);
      Snapshot_cijeifhgec.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_Script_CurseAreaDebuff_DataShared_IsInArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (Script_CurseAreaDebuff_DataShared_IsInArea));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_Script_CurseAreaDebuff_DataShared_StackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (Script_CurseAreaDebuff_DataShared_StackSize));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_Script_CurseAreaDebuff_DataShared_Start));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedFields_Script_CurseAreaDebuff_DataShared_Count));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_Script_CurseAreaDebuff_DataShared));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_IsInArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_Script_CurseAreaDebuff_DataShared_IsInArea));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_StackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (FrameChangedIndex_Script_CurseAreaDebuff_DataShared_StackSize));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_Script_CurseAreaDebuff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataStartOffset_Script_CurseAreaDebuff_DataShared));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_Script_CurseAreaDebuff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (ComponentDataSize_Script_CurseAreaDebuff_DataShared));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_Script_CurseAreaDebuff_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, nameof (CompBit_Script_CurseAreaDebuff_DataShared));
      Snapshot_cijeifhgec.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, 100664562);
      Snapshot_cijeifhgec.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, 100664563);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cijeifhgec>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Script_CurseAreaDebuff_DataShared_Start
    {
      get
      {
        int debuffDataSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Start, (void*) &debuffDataSharedStart);
        return debuffDataSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Script_CurseAreaDebuff_DataShared_Count
    {
      get
      {
        int debuffDataSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Count, (void*) &debuffDataSharedCount);
        return debuffDataSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedFields_Script_CurseAreaDebuff_DataShared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_CurseAreaDebuff_DataShared
    {
      get
      {
        int debuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared, (void*) &debuffDataShared);
        return debuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_CurseAreaDebuff_DataShared_IsInArea
    {
      get
      {
        int dataSharedIsInArea;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_IsInArea, (void*) &dataSharedIsInArea);
        return dataSharedIsInArea;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_IsInArea, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_CurseAreaDebuff_DataShared_StackSize
    {
      get
      {
        int dataSharedStackSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_StackSize, (void*) &dataSharedStackSize);
        return dataSharedStackSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_FrameChangedIndex_Script_CurseAreaDebuff_DataShared_StackSize, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Script_CurseAreaDebuff_DataShared
    {
      get
      {
        int debuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_Script_CurseAreaDebuff_DataShared, (void*) &debuffDataShared);
        return debuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataStartOffset_Script_CurseAreaDebuff_DataShared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Script_CurseAreaDebuff_DataShared
    {
      get
      {
        int debuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_Script_CurseAreaDebuff_DataShared, (void*) &debuffDataShared);
        return debuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_ComponentDataSize_Script_CurseAreaDebuff_DataShared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Script_CurseAreaDebuff_DataShared
    {
      get
      {
        ulong debuffDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_Script_CurseAreaDebuff_DataShared, (void*) &debuffDataShared);
        return debuffDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cijeifhgec.NativeFieldInfoPtr_CompBit_Script_CurseAreaDebuff_DataShared, (void*) &value);
      }
    }
  }
}
