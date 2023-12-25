// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_dbjjcgeeki
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
  public struct Snapshot_dbjjcgeeki
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodAbilityReplaceBuff_AbilityGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_VBloodAbilityReplaceBuff_AbilityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_VBloodAbilityReplaceBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_VBloodAbilityReplaceBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_VBloodAbilityReplaceBuff;
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
    public PrefabGUID VBloodAbilityReplaceBuff_AbilityGUID;
    [FieldOffset(45)]
    public AbilityTypeEnum VBloodAbilityReplaceBuff_AbilityType;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1576735, XrefRangeEnd = 1576766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dbjjcgeeki.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1576797, RefRangeEnd = 1576798, XrefRangeStart = 1576766, XrefRangeEnd = 1576797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dbjjcgeeki.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_dbjjcgeeki()
    {
      Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_dbjjcgeeki));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr);
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_VBloodAbilityReplaceBuff_AbilityGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (VBloodAbilityReplaceBuff_AbilityGUID));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_VBloodAbilityReplaceBuff_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (VBloodAbilityReplaceBuff_AbilityType));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_VBloodAbilityReplaceBuff_Start));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedFields_VBloodAbilityReplaceBuff_Count));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_VBloodAbilityReplaceBuff));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityGUID));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityType));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_VBloodAbilityReplaceBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataStartOffset_VBloodAbilityReplaceBuff));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_VBloodAbilityReplaceBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (ComponentDataSize_VBloodAbilityReplaceBuff));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_VBloodAbilityReplaceBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, nameof (CompBit_VBloodAbilityReplaceBuff));
      Snapshot_dbjjcgeeki.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, 100664600);
      Snapshot_dbjjcgeeki.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, 100664601);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_dbjjcgeeki>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_VBloodAbilityReplaceBuff_Start
    {
      get
      {
        int replaceBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Start, (void*) &replaceBuffStart);
        return replaceBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_VBloodAbilityReplaceBuff_Count
    {
      get
      {
        int replaceBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Count, (void*) &replaceBuffCount);
        return replaceBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedFields_VBloodAbilityReplaceBuff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_VBloodAbilityReplaceBuff
    {
      get
      {
        int abilityReplaceBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff, (void*) &abilityReplaceBuff);
        return abilityReplaceBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityGUID
    {
      get
      {
        int replaceBuffAbilityGuid;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityGUID, (void*) &replaceBuffAbilityGuid);
        return replaceBuffAbilityGuid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityGUID, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityType
    {
      get
      {
        int replaceBuffAbilityType;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityType, (void*) &replaceBuffAbilityType);
        return replaceBuffAbilityType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_FrameChangedIndex_VBloodAbilityReplaceBuff_AbilityType, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_VBloodAbilityReplaceBuff
    {
      get
      {
        int abilityReplaceBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_VBloodAbilityReplaceBuff, (void*) &abilityReplaceBuff);
        return abilityReplaceBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataStartOffset_VBloodAbilityReplaceBuff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_VBloodAbilityReplaceBuff
    {
      get
      {
        int abilityReplaceBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_VBloodAbilityReplaceBuff, (void*) &abilityReplaceBuff);
        return abilityReplaceBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_ComponentDataSize_VBloodAbilityReplaceBuff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_VBloodAbilityReplaceBuff
    {
      get
      {
        ulong abilityReplaceBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_VBloodAbilityReplaceBuff, (void*) &abilityReplaceBuff);
        return abilityReplaceBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dbjjcgeeki.NativeFieldInfoPtr_CompBit_VBloodAbilityReplaceBuff, (void*) &value);
      }
    }
  }
}
