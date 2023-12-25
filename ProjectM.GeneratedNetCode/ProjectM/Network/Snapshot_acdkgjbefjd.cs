// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acdkgjbefjd
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
  public struct Snapshot_acdkgjbefjd
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_BlastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_End;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_PreviewTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_BlastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_End;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_PreviewTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ProfessorCoilBeam_State_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ProfessorCoilBeam_State_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ProfessorCoilBeam_State_Shared;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float ProfessorCoilBeam_State_Shared_BlastTime;
    [FieldOffset(12)]
    public float3 ProfessorCoilBeam_State_Shared_End;
    [FieldOffset(24)]
    public float ProfessorCoilBeam_State_Shared_PreviewTime;
    [FieldOffset(28)]
    public float3 ProfessorCoilBeam_State_Shared_Start;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1527777, XrefRangeEnd = 1527852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acdkgjbefjd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1527874, RefRangeEnd = 1527875, XrefRangeStart = 1527852, XrefRangeEnd = 1527874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acdkgjbefjd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acdkgjbefjd()
    {
      Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acdkgjbefjd));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr);
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_BlastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (ProfessorCoilBeam_State_Shared_BlastTime));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (ProfessorCoilBeam_State_Shared_End));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_PreviewTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (ProfessorCoilBeam_State_Shared_PreviewTime));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ProfessorCoilBeam_State_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (ProfessorCoilBeam_State_Shared_Start));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChangedFields_ProfessorCoilBeam_State_Shared_Start));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChangedFields_ProfessorCoilBeam_State_Shared_Count));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChangedIndex_ProfessorCoilBeam_State_Shared));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_BlastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChangedIndex_ProfessorCoilBeam_State_Shared_BlastTime));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChangedIndex_ProfessorCoilBeam_State_Shared_End));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_PreviewTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChangedIndex_ProfessorCoilBeam_State_Shared_PreviewTime));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (FrameChangedIndex_ProfessorCoilBeam_State_Shared_Start));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ComponentDataStartOffset_ProfessorCoilBeam_State_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (ComponentDataStartOffset_ProfessorCoilBeam_State_Shared));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ComponentDataSize_ProfessorCoilBeam_State_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (ComponentDataSize_ProfessorCoilBeam_State_Shared));
      Snapshot_acdkgjbefjd.NativeFieldInfoPtr_CompBit_ProfessorCoilBeam_State_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, nameof (CompBit_ProfessorCoilBeam_State_Shared));
      Snapshot_acdkgjbefjd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, 100664170);
      Snapshot_acdkgjbefjd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, 100664171);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acdkgjbefjd>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ProfessorCoilBeam_State_Shared_Start
    {
      get
      {
        int stateSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Start, (void*) &stateSharedStart);
        return stateSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ProfessorCoilBeam_State_Shared_Count
    {
      get
      {
        int stateSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Count, (void*) &stateSharedCount);
        return stateSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedFields_ProfessorCoilBeam_State_Shared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProfessorCoilBeam_State_Shared
    {
      get
      {
        int coilBeamStateShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared, (void*) &coilBeamStateShared);
        return coilBeamStateShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProfessorCoilBeam_State_Shared_BlastTime
    {
      get
      {
        int stateSharedBlastTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_BlastTime, (void*) &stateSharedBlastTime);
        return stateSharedBlastTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_BlastTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProfessorCoilBeam_State_Shared_End
    {
      get
      {
        int beamStateSharedEnd;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_End, (void*) &beamStateSharedEnd);
        return beamStateSharedEnd;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_End, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProfessorCoilBeam_State_Shared_PreviewTime
    {
      get
      {
        int sharedPreviewTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_PreviewTime, (void*) &sharedPreviewTime);
        return sharedPreviewTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_PreviewTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProfessorCoilBeam_State_Shared_Start
    {
      get
      {
        int stateSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_Start, (void*) &stateSharedStart);
        return stateSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_FrameChangedIndex_ProfessorCoilBeam_State_Shared_Start, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ProfessorCoilBeam_State_Shared
    {
      get
      {
        int coilBeamStateShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ComponentDataStartOffset_ProfessorCoilBeam_State_Shared, (void*) &coilBeamStateShared);
        return coilBeamStateShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ComponentDataStartOffset_ProfessorCoilBeam_State_Shared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ProfessorCoilBeam_State_Shared
    {
      get
      {
        int coilBeamStateShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ComponentDataSize_ProfessorCoilBeam_State_Shared, (void*) &coilBeamStateShared);
        return coilBeamStateShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_ComponentDataSize_ProfessorCoilBeam_State_Shared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ProfessorCoilBeam_State_Shared
    {
      get
      {
        ulong coilBeamStateShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_CompBit_ProfessorCoilBeam_State_Shared, (void*) &coilBeamStateShared);
        return coilBeamStateShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdkgjbefjd.NativeFieldInfoPtr_CompBit_ProfessorCoilBeam_State_Shared, (void*) &value);
      }
    }
  }
}
