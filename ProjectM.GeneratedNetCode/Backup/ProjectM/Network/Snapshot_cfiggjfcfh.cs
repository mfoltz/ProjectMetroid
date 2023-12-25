// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cfiggjfcfh
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cfiggjfcfh
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeToBlack_Manual_FadeState;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBuff_EndCameraRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBuff_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBuff_SetCameraRotationOnTeleport;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Buff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Buff_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndCameraRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_SetCameraRotationOnTeleport;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TeleportBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TeleportBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Buff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityCreator;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_FadeToBlack_Manual;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TeleportBuff;
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
    public FadeToBlack_Manual.State FadeToBlack_Manual_FadeState;
    [FieldOffset(45)]
    public int Team_FactionIndex;
    [FieldOffset(49)]
    public int Team_Value;
    [FieldOffset(53)]
    public float TeleportBuff_EndCameraRotation;
    [FieldOffset(57)]
    public float3 TeleportBuff_EndPosition;
    [FieldOffset(69)]
    public bool TeleportBuff_SetCameraRotationOnTeleport;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1568688, XrefRangeEnd = 1568756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cfiggjfcfh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1568798, RefRangeEnd = 1568799, XrefRangeStart = 1568756, XrefRangeEnd = 1568798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cfiggjfcfh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cfiggjfcfh()
    {
      Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cfiggjfcfh));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr);
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (Buff_Stacks));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (Buff_StartTimeUnmodified));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (Buff_Target));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (EntityCreator_Creator));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FadeToBlack_Manual_FadeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FadeToBlack_Manual_FadeState));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (Team_Value));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_TeleportBuff_EndCameraRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (TeleportBuff_EndCameraRotation));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_TeleportBuff_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (TeleportBuff_EndPosition));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_TeleportBuff_SetCameraRotationOnTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (TeleportBuff_SetCameraRotationOnTeleport));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Buff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_Buff_Start));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Buff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_Buff_Count));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Start));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_EntityCreator_Count));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_FadeToBlack_Manual_Start));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_FadeToBlack_Manual_Count));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_TeleportBuff_Start));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedFields_TeleportBuff_Count));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_Buff));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_FadeToBlack_Manual));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_TeleportBuff));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Stacks));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_Buff_StartTimeUnmodified));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_Buff_Target));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_EntityCreator_Creator));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_FadeToBlack_Manual_FadeState));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndCameraRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_TeleportBuff_EndCameraRotation));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_TeleportBuff_EndPosition));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_SetCameraRotationOnTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (FrameChangedIndex_TeleportBuff_SetCameraRotationOnTeleport));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataStartOffset_Buff));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataSize_Buff));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityCreator));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataSize_EntityCreator));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataStartOffset_FadeToBlack_Manual));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataSize_FadeToBlack_Manual));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_TeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataStartOffset_TeleportBuff));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_TeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (ComponentDataSize_TeleportBuff));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (CompBit_Buff));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_EntityCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (CompBit_EntityCreator));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_FadeToBlack_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (CompBit_FadeToBlack_Manual));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_TeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, nameof (CompBit_TeleportBuff));
      Snapshot_cfiggjfcfh.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, 100664520);
      Snapshot_cfiggjfcfh.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, 100664521);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cfiggjfcfh>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Start
    {
      get
      {
        int changedFieldsBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &changedFieldsBuffStart);
        return changedFieldsBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Buff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Buff_Count
    {
      get
      {
        int changedFieldsBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &changedFieldsBuffCount);
        return changedFieldsBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Buff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Start
    {
      get
      {
        int entityCreatorStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &entityCreatorStart);
        return entityCreatorStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityCreator_Count
    {
      get
      {
        int entityCreatorCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &entityCreatorCount);
        return entityCreatorCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityCreator_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FadeToBlack_Manual_Start
    {
      get
      {
        int blackManualStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start, (void*) &blackManualStart);
        return blackManualStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_FadeToBlack_Manual_Count
    {
      get
      {
        int blackManualCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count, (void*) &blackManualCount);
        return blackManualCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_FadeToBlack_Manual_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TeleportBuff_Start
    {
      get
      {
        int teleportBuffStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Start, (void*) &teleportBuffStart);
        return teleportBuffStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TeleportBuff_Count
    {
      get
      {
        int teleportBuffCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Count, (void*) &teleportBuffCount);
        return teleportBuffCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedFields_TeleportBuff_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff
    {
      get
      {
        int changedIndexBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &changedIndexBuff);
        return changedIndexBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator
    {
      get
      {
        int indexEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &indexEntityCreator);
        return indexEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FadeToBlack_Manual
    {
      get
      {
        int fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TeleportBuff
    {
      get
      {
        int indexTeleportBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff, (void*) &indexTeleportBuff);
        return indexTeleportBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Stacks
    {
      get
      {
        int changedIndexBuffStacks;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &changedIndexBuffStacks);
        return changedIndexBuffStacks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Stacks, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_StartTimeUnmodified
    {
      get
      {
        int startTimeUnmodified;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &startTimeUnmodified);
        return startTimeUnmodified;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_StartTimeUnmodified, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Buff_Target
    {
      get
      {
        int changedIndexBuffTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &changedIndexBuffTarget);
        return changedIndexBuffTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Buff_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityCreator_Creator
    {
      get
      {
        int entityCreatorCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &entityCreatorCreator);
        return entityCreatorCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityCreator_Creator, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_FadeToBlack_Manual_FadeState
    {
      get
      {
        int blackManualFadeState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState, (void*) &blackManualFadeState);
        return blackManualFadeState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_FadeToBlack_Manual_FadeState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TeleportBuff_EndCameraRotation
    {
      get
      {
        int endCameraRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndCameraRotation, (void*) &endCameraRotation);
        return endCameraRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndCameraRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TeleportBuff_EndPosition
    {
      get
      {
        int teleportBuffEndPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndPosition, (void*) &teleportBuffEndPosition);
        return teleportBuffEndPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_EndPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TeleportBuff_SetCameraRotationOnTeleport
    {
      get
      {
        int rotationOnTeleport;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_SetCameraRotationOnTeleport, (void*) &rotationOnTeleport);
        return rotationOnTeleport;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_FrameChangedIndex_TeleportBuff_SetCameraRotationOnTeleport, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Buff
    {
      get
      {
        int dataStartOffsetBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &dataStartOffsetBuff);
        return dataStartOffsetBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Buff
    {
      get
      {
        int componentDataSizeBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &componentDataSizeBuff);
        return componentDataSizeBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_Buff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityCreator
    {
      get
      {
        int offsetEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &offsetEntityCreator);
        return offsetEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityCreator
    {
      get
      {
        int sizeEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &sizeEntityCreator);
        return sizeEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_EntityCreator, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_FadeToBlack_Manual
    {
      get
      {
        int fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_FadeToBlack_Manual, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_FadeToBlack_Manual
    {
      get
      {
        int fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_FadeToBlack_Manual, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TeleportBuff
    {
      get
      {
        int offsetTeleportBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_TeleportBuff, (void*) &offsetTeleportBuff);
        return offsetTeleportBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataStartOffset_TeleportBuff, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TeleportBuff
    {
      get
      {
        int sizeTeleportBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_TeleportBuff, (void*) &sizeTeleportBuff);
        return sizeTeleportBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_ComponentDataSize_TeleportBuff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Buff
    {
      get
      {
        ulong compBitBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_Buff, (void*) &compBitBuff);
        return compBitBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_Buff, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityCreator
    {
      get
      {
        ulong bitEntityCreator;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &bitEntityCreator);
        return bitEntityCreator;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_EntityCreator, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_FadeToBlack_Manual
    {
      get
      {
        ulong fadeToBlackManual;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_FadeToBlack_Manual, (void*) &fadeToBlackManual);
        return fadeToBlackManual;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_FadeToBlack_Manual, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TeleportBuff
    {
      get
      {
        ulong compBitTeleportBuff;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_TeleportBuff, (void*) &compBitTeleportBuff);
        return compBitTeleportBuff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cfiggjfcfh.NativeFieldInfoPtr_CompBit_TeleportBuff, (void*) &value);
      }
    }
  }
}
