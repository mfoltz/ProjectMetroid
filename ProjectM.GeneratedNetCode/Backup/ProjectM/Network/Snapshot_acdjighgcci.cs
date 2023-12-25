// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acdjighgcci
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Gameplay.Scripting;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acdjighgcci
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotateOverTimeData_InitialRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotateOverTimeData_RotationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Translation_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Translation_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_RotateOverTimeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Translation;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float LifeTime_Duration;
    [FieldOffset(12)]
    public quaternion RotateOverTimeData_InitialRotation;
    [FieldOffset(28)]
    public RotationType RotateOverTimeData_RotationType;
    [FieldOffset(32)]
    public int Team_FactionIndex;
    [FieldOffset(36)]
    public int Team_Value;
    [FieldOffset(40)]
    public float3 Translation_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1527673, XrefRangeEnd = 1527749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acdjighgcci.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1527776, RefRangeEnd = 1527777, XrefRangeStart = 1527749, XrefRangeEnd = 1527776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acdjighgcci.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acdjighgcci()
    {
      Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acdjighgcci));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr);
      Snapshot_acdjighgcci.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_RotateOverTimeData_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (RotateOverTimeData_InitialRotation));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_RotateOverTimeData_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (RotateOverTimeData_RotationType));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (Team_Value));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (Translation_Value));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_RotateOverTimeData_Start));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_RotateOverTimeData_Count));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Translation_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_Translation_Start));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Translation_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedFields_Translation_Count));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_RotateOverTimeData));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_Translation));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_RotateOverTimeData_InitialRotation));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_RotateOverTimeData_RotationType));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (FrameChangedIndex_Translation_Value));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataStartOffset_RotateOverTimeData));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataSize_RotateOverTimeData));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataStartOffset_Translation));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (ComponentDataSize_Translation));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_RotateOverTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (CompBit_RotateOverTimeData));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, nameof (CompBit_Translation));
      Snapshot_acdjighgcci.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, 100664168);
      Snapshot_acdjighgcci.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, 100664169);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acdjighgcci>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RotateOverTimeData_Start
    {
      get
      {
        int overTimeDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start, (void*) &overTimeDataStart);
        return overTimeDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_RotateOverTimeData_Count
    {
      get
      {
        int overTimeDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count, (void*) &overTimeDataCount);
        return overTimeDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_RotateOverTimeData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Start
    {
      get
      {
        int translationStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &translationStart);
        return translationStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Translation_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Translation_Count
    {
      get
      {
        int translationCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &translationCount);
        return translationCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedFields_Translation_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RotateOverTimeData
    {
      get
      {
        int rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation
    {
      get
      {
        int indexTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &indexTranslation);
        return indexTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Translation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RotateOverTimeData_InitialRotation
    {
      get
      {
        int dataInitialRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation, (void*) &dataInitialRotation);
        return dataInitialRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_InitialRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_RotateOverTimeData_RotationType
    {
      get
      {
        int dataRotationType;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType, (void*) &dataRotationType);
        return dataRotationType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_RotateOverTimeData_RotationType, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Translation_Value
    {
      get
      {
        int translationValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &translationValue);
        return translationValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_FrameChangedIndex_Translation_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_RotateOverTimeData
    {
      get
      {
        int rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_RotateOverTimeData
    {
      get
      {
        int rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Translation
    {
      get
      {
        int offsetTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &offsetTranslation);
        return offsetTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataStartOffset_Translation, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Translation
    {
      get
      {
        int dataSizeTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &dataSizeTranslation);
        return dataSizeTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_ComponentDataSize_Translation, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_RotateOverTimeData
    {
      get
      {
        ulong rotateOverTimeData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_RotateOverTimeData, (void*) &rotateOverTimeData);
        return rotateOverTimeData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_RotateOverTimeData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Translation
    {
      get
      {
        ulong compBitTranslation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_Translation, (void*) &compBitTranslation);
        return compBitTranslation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acdjighgcci.NativeFieldInfoPtr_CompBit_Translation, (void*) &value);
      }
    }
  }
}
