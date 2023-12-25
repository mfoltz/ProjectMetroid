// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_fdjggbfcb
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
  public struct Snapshot_fdjggbfcb
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileDestroyData_HasHitTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMovement_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMovement_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMovement_TargetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData_HasHitTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_ProjectileDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_ProjectileDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpellMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_ProjectileDestroyData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpellMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float LifeTime_Duration;
    [FieldOffset(12)]
    public bool ProjectileDestroyData_HasHitTarget;
    [FieldOffset(13)]
    public bool SpellMovement_Disabled;
    [FieldOffset(14)]
    public float3 SpellMovement_StartPosition;
    [FieldOffset(26)]
    public float3 SpellMovement_TargetPosition;
    [FieldOffset(38)]
    public int Team_FactionIndex;
    [FieldOffset(42)]
    public int Team_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1581890, XrefRangeEnd = 1581966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fdjggbfcb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1581993, RefRangeEnd = 1581994, XrefRangeStart = 1581966, XrefRangeEnd = 1581993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_fdjggbfcb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_fdjggbfcb()
    {
      Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_fdjggbfcb));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr);
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ProjectileDestroyData_HasHitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ProjectileDestroyData_HasHitTarget));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_SpellMovement_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (SpellMovement_Disabled));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_SpellMovement_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (SpellMovement_StartPosition));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_SpellMovement_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (SpellMovement_TargetPosition));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (Team_Value));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_ProjectileDestroyData_Start));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_ProjectileDestroyData_Count));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_SpellMovement_Start));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_SpellMovement_Count));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_ProjectileDestroyData));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData_HasHitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_ProjectileDestroyData_HasHitTarget));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement_Disabled));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement_StartPosition));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_SpellMovement_TargetPosition));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_ProjectileDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataStartOffset_ProjectileDestroyData));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_ProjectileDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataSize_ProjectileDestroyData));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataStartOffset_SpellMovement));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataSize_SpellMovement));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_ProjectileDestroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (CompBit_ProjectileDestroyData));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_SpellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (CompBit_SpellMovement));
      Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_fdjggbfcb.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, 100664648);
      Snapshot_fdjggbfcb.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, 100664649);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_fdjggbfcb>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ProjectileDestroyData_Start
    {
      get
      {
        int destroyDataStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Start, (void*) &destroyDataStart);
        return destroyDataStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_ProjectileDestroyData_Count
    {
      get
      {
        int destroyDataCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Count, (void*) &destroyDataCount);
        return destroyDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_ProjectileDestroyData_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellMovement_Start
    {
      get
      {
        int spellMovementStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start, (void*) &spellMovementStart);
        return spellMovementStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellMovement_Count
    {
      get
      {
        int spellMovementCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count, (void*) &spellMovementCount);
        return spellMovementCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_SpellMovement_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProjectileDestroyData
    {
      get
      {
        int projectileDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData, (void*) &projectileDestroyData);
        return projectileDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement
    {
      get
      {
        int indexSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement, (void*) &indexSpellMovement);
        return indexSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_ProjectileDestroyData_HasHitTarget
    {
      get
      {
        int dataHasHitTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData_HasHitTarget, (void*) &dataHasHitTarget);
        return dataHasHitTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_ProjectileDestroyData_HasHitTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement_Disabled
    {
      get
      {
        int movementDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled, (void*) &movementDisabled);
        return movementDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_Disabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement_StartPosition
    {
      get
      {
        int movementStartPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition, (void*) &movementStartPosition);
        return movementStartPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_StartPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellMovement_TargetPosition
    {
      get
      {
        int movementTargetPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition, (void*) &movementTargetPosition);
        return movementTargetPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_SpellMovement_TargetPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_ProjectileDestroyData
    {
      get
      {
        int projectileDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_ProjectileDestroyData, (void*) &projectileDestroyData);
        return projectileDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_ProjectileDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_ProjectileDestroyData
    {
      get
      {
        int projectileDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_ProjectileDestroyData, (void*) &projectileDestroyData);
        return projectileDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_ProjectileDestroyData, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpellMovement
    {
      get
      {
        int offsetSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement, (void*) &offsetSpellMovement);
        return offsetSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_SpellMovement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpellMovement
    {
      get
      {
        int sizeSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_SpellMovement, (void*) &sizeSpellMovement);
        return sizeSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_SpellMovement, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_ProjectileDestroyData
    {
      get
      {
        ulong projectileDestroyData;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_ProjectileDestroyData, (void*) &projectileDestroyData);
        return projectileDestroyData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_ProjectileDestroyData, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpellMovement
    {
      get
      {
        ulong bitSpellMovement;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_SpellMovement, (void*) &bitSpellMovement);
        return bitSpellMovement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_SpellMovement, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_fdjggbfcb.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }
  }
}
