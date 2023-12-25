// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_jcdhbjde
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
  public struct Snapshot_jcdhbjde
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityOwner_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityOwner_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbBuff_AbsorbCap;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbBuff_AbsorbValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbCap;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbsorbBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbsorbBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbsorbBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
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
    public float AbsorbBuff_AbsorbCap;
    [FieldOffset(28)]
    public float AbsorbBuff_AbsorbValue;
    [FieldOffset(32)]
    public byte Buff_Stacks;
    [FieldOffset(33)]
    public double Buff_StartTimeUnmodified;
    [FieldOffset(41)]
    public NetworkId Buff_Target;
    [FieldOffset(49)]
    public NetworkId EntityCreator_Creator;
    [FieldOffset(57)]
    public NetworkId EntityOwner_Owner;
    [FieldOffset(65)]
    public float LifeTime_Duration;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1588853, XrefRangeEnd = 1588987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jcdhbjde.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1589041, RefRangeEnd = 1589042, XrefRangeStart = 1588987, XrefRangeEnd = 1589041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_jcdhbjde.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_jcdhbjde()
    {
      Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_jcdhbjde));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr);
      Snapshot_jcdhbjde.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_AbilityOwner_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (AbilityOwner_Ability));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_AbilityOwner_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (AbilityOwner_AbilityGroup));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_AbsorbBuff_AbsorbCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (AbsorbBuff_AbsorbCap));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_AbsorbBuff_AbsorbValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (AbsorbBuff_AbsorbValue));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_AbilityOwner_Start));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_AbilityOwner_Count));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_AbsorbBuff_Start));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_AbsorbBuff_Count));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_AbilityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_AbsorbBuff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_AbilityOwner_Ability));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_AbilityOwner_AbilityGroup));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_AbsorbBuff_AbsorbCap));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_AbsorbBuff_AbsorbValue));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataSize_AbilityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_AbsorbBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataStartOffset_AbsorbBuff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_AbsorbBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataSize_AbsorbBuff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_AbilityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (CompBit_AbilityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_AbsorbBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (CompBit_AbsorbBuff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_jcdhbjde.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, 100664720);
      Snapshot_jcdhbjde.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, 100664721);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_jcdhbjde>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityOwner_Start
    {
      get
      {
        int abilityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start, (void*) &abilityOwnerStart);
        return abilityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityOwner_Count
    {
      get
      {
        int abilityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count, (void*) &abilityOwnerCount);
        return abilityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbilityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbsorbBuff_Start
    {
      get
      {
        int fieldsAbsorbBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Start, (void*) &fieldsAbsorbBuffStart);
        return fieldsAbsorbBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbsorbBuff_Count
    {
      get
      {
        int fieldsAbsorbBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Count, (void*) &fieldsAbsorbBuffCount);
        return fieldsAbsorbBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_AbsorbBuff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityOwner
    {
      get
      {
        int indexAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner, (void*) &indexAbilityOwner);
        return indexAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbsorbBuff
    {
      get
      {
        int changedIndexAbsorbBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff, (void*) &changedIndexAbsorbBuff);
        return changedIndexAbsorbBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityOwner_Ability
    {
      get
      {
        int abilityOwnerAbility;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability, (void*) &abilityOwnerAbility);
        return abilityOwnerAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_Ability, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityOwner_AbilityGroup
    {
      get
      {
        int ownerAbilityGroup;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup, (void*) &ownerAbilityGroup);
        return ownerAbilityGroup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbilityOwner_AbilityGroup, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbsorbBuff_AbsorbCap
    {
      get
      {
        int absorbBuffAbsorbCap;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbCap, (void*) &absorbBuffAbsorbCap);
        return absorbBuffAbsorbCap;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbCap, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbsorbBuff_AbsorbValue
    {
      get
      {
        int absorbBuffAbsorbValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbValue, (void*) &absorbBuffAbsorbValue);
        return absorbBuffAbsorbValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_AbsorbBuff_AbsorbValue, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityOwner
    {
      get
      {
        int offsetAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner, (void*) &offsetAbilityOwner);
        return offsetAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityOwner
    {
      get
      {
        int sizeAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_AbilityOwner, (void*) &sizeAbilityOwner);
        return sizeAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbsorbBuff
    {
      get
      {
        int offsetAbsorbBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_AbsorbBuff, (void*) &offsetAbsorbBuff);
        return offsetAbsorbBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_AbsorbBuff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbsorbBuff
    {
      get
      {
        int dataSizeAbsorbBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_AbsorbBuff, (void*) &dataSizeAbsorbBuff);
        return dataSizeAbsorbBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_AbsorbBuff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityOwner
    {
      get
      {
        ulong compBitAbilityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_AbilityOwner, (void*) &compBitAbilityOwner);
        return compBitAbilityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_AbilityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbsorbBuff
    {
      get
      {
        ulong compBitAbsorbBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_AbsorbBuff, (void*) &compBitAbsorbBuff);
        return compBitAbsorbBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_AbsorbBuff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_jcdhbjde.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }
  }
}
