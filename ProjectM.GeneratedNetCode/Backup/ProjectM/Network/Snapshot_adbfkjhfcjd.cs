// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_adbfkjhfcjd
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
  public struct Snapshot_adbfkjhfcjd
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandData_LastClientFrameReceivedByServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandState_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandState_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandState_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputCommandState_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandData_LastClientFrameReceivedByServer;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InputCommandData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_InputCommandState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InputCommandData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_InputCommandState;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public int InputCommandData_LastClientFrameReceivedByServer;
    [FieldOffset(12)]
    public float3 InputCommandState_LastTranslation;
    [FieldOffset(24)]
    public quaternion InputCommandState_Rotation;
    [FieldOffset(40)]
    public float3 InputCommandState_Translation;
    [FieldOffset(52)]
    public float3 InputCommandState_Velocity;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1538814, XrefRangeEnd = 1538835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbfkjhfcjd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1538860, RefRangeEnd = 1538861, XrefRangeStart = 1538835, XrefRangeEnd = 1538860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_adbfkjhfcjd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_adbfkjhfcjd()
    {
      Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_adbfkjhfcjd));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr);
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_InputCommandData_LastClientFrameReceivedByServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (InputCommandData_LastClientFrameReceivedByServer));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_InputCommandState_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (InputCommandState_LastTranslation));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_InputCommandState_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (InputCommandState_Rotation));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_InputCommandState_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (InputCommandState_Translation));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_InputCommandState_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (InputCommandState_Velocity));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedFields_InputCommandData_Start));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedFields_InputCommandData_Count));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedFields_InputCommandState_Start));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedFields_InputCommandState_Count));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandData));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandState));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandData_LastClientFrameReceivedByServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandData_LastClientFrameReceivedByServer));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandState_LastTranslation));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandState_Rotation));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandState_Translation));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (FrameChangedIndex_InputCommandState_Velocity));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (ComponentDataStartOffset_InputCommandData));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataSize_InputCommandData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (ComponentDataSize_InputCommandData));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (ComponentDataStartOffset_InputCommandState));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataSize_InputCommandState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (ComponentDataSize_InputCommandState));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CompBit_InputCommandData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (CompBit_InputCommandData));
      Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CompBit_InputCommandState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, nameof (CompBit_InputCommandState));
      Snapshot_adbfkjhfcjd.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, 100664292);
      Snapshot_adbfkjhfcjd.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, 100664293);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_adbfkjhfcjd>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InputCommandData_Start
    {
      get
      {
        int commandDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Start, (void*) &commandDataStart);
        return commandDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InputCommandData_Count
    {
      get
      {
        int commandDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Count, (void*) &commandDataCount);
        return commandDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InputCommandState_Start
    {
      get
      {
        int commandStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Start, (void*) &commandStateStart);
        return commandStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_InputCommandState_Count
    {
      get
      {
        int commandStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Count, (void*) &commandStateCount);
        return commandStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedFields_InputCommandState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandData
    {
      get
      {
        int inputCommandData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandData, (void*) &inputCommandData);
        return inputCommandData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandState
    {
      get
      {
        int inputCommandState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState, (void*) &inputCommandState);
        return inputCommandState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandData_LastClientFrameReceivedByServer
    {
      get
      {
        int receivedByServer;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandData_LastClientFrameReceivedByServer, (void*) &receivedByServer);
        return receivedByServer;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandData_LastClientFrameReceivedByServer, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandState_LastTranslation
    {
      get
      {
        int stateLastTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_LastTranslation, (void*) &stateLastTranslation);
        return stateLastTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_LastTranslation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandState_Rotation
    {
      get
      {
        int commandStateRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Rotation, (void*) &commandStateRotation);
        return commandStateRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandState_Translation
    {
      get
      {
        int stateTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Translation, (void*) &stateTranslation);
        return stateTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_InputCommandState_Velocity
    {
      get
      {
        int commandStateVelocity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Velocity, (void*) &commandStateVelocity);
        return commandStateVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_FrameChangedIndex_InputCommandState_Velocity, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InputCommandData
    {
      get
      {
        int inputCommandData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandData, (void*) &inputCommandData);
        return inputCommandData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InputCommandData
    {
      get
      {
        int inputCommandData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataSize_InputCommandData, (void*) &inputCommandData);
        return inputCommandData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataSize_InputCommandData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_InputCommandState
    {
      get
      {
        int inputCommandState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandState, (void*) &inputCommandState);
        return inputCommandState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataStartOffset_InputCommandState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_InputCommandState
    {
      get
      {
        int inputCommandState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataSize_InputCommandState, (void*) &inputCommandState);
        return inputCommandState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_ComponentDataSize_InputCommandState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InputCommandData
    {
      get
      {
        ulong inputCommandData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CompBit_InputCommandData, (void*) &inputCommandData);
        return inputCommandData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CompBit_InputCommandData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_InputCommandState
    {
      get
      {
        ulong inputCommandState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CompBit_InputCommandState, (void*) &inputCommandState);
        return inputCommandState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_adbfkjhfcjd.NativeFieldInfoPtr_CompBit_InputCommandState, (void*) &value);
      }
    }
  }
}
