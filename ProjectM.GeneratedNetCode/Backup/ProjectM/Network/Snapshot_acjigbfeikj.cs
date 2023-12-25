﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acjigbfeikj
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_acjigbfeikj
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Script_HomingSpell_DataShared_SyncAge;
    private static readonly System.IntPtr NativeFieldInfoPtr_Script_HomingSpell_DataShared_SyncPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Script_HomingSpell_DataShared_SyncRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncAge;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Script_HomingSpell_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Script_HomingSpell_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Script_HomingSpell_DataShared;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpellTarget;
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
    public float Script_HomingSpell_DataShared_SyncAge;
    [FieldOffset(16)]
    public float3 Script_HomingSpell_DataShared_SyncPosition;
    [FieldOffset(28)]
    public Quaternion Script_HomingSpell_DataShared_SyncRotation;
    [FieldOffset(44)]
    public NetworkId SpellTarget_Target;
    [FieldOffset(52)]
    public int Team_FactionIndex;
    [FieldOffset(56)]
    public int Team_Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1536731, XrefRangeEnd = 1536846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acjigbfeikj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1536883, RefRangeEnd = 1536884, XrefRangeStart = 1536846, XrefRangeEnd = 1536883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acjigbfeikj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acjigbfeikj()
    {
      Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acjigbfeikj));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr);
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (LifeTime_Duration));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_Script_HomingSpell_DataShared_SyncAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (Script_HomingSpell_DataShared_SyncAge));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_Script_HomingSpell_DataShared_SyncPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (Script_HomingSpell_DataShared_SyncPosition));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_Script_HomingSpell_DataShared_SyncRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (Script_HomingSpell_DataShared_SyncRotation));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_SpellTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (SpellTarget_Target));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (Team_Value));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Start));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_LifeTime_Count));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_Script_HomingSpell_DataShared_Start));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_Script_HomingSpell_DataShared_Count));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_SpellTarget_Start));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_SpellTarget_Count));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_Script_HomingSpell_DataShared));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_SpellTarget));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_LifeTime_Duration));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_Script_HomingSpell_DataShared_SyncAge));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_Script_HomingSpell_DataShared_SyncPosition));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_Script_HomingSpell_DataShared_SyncRotation));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_SpellTarget_Target));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataStartOffset_LifeTime));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataSize_LifeTime));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_Script_HomingSpell_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataStartOffset_Script_HomingSpell_DataShared));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_Script_HomingSpell_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataSize_Script_HomingSpell_DataShared));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataStartOffset_SpellTarget));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataSize_SpellTarget));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_LifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (CompBit_LifeTime));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_Script_HomingSpell_DataShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (CompBit_Script_HomingSpell_DataShared));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (CompBit_SpellTarget));
      Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_acjigbfeikj.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, 100664266);
      Snapshot_acjigbfeikj.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, 100664267);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acjigbfeikj>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Start
    {
      get
      {
        int fieldsLifeTimeStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &fieldsLifeTimeStart);
        return fieldsLifeTimeStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LifeTime_Count
    {
      get
      {
        int fieldsLifeTimeCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &fieldsLifeTimeCount);
        return fieldsLifeTimeCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_LifeTime_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Script_HomingSpell_DataShared_Start
    {
      get
      {
        int spellDataSharedStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Start, (void*) &spellDataSharedStart);
        return spellDataSharedStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Script_HomingSpell_DataShared_Count
    {
      get
      {
        int spellDataSharedCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Count, (void*) &spellDataSharedCount);
        return spellDataSharedCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Script_HomingSpell_DataShared_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellTarget_Start
    {
      get
      {
        int spellTargetStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start, (void*) &spellTargetStart);
        return spellTargetStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellTarget_Count
    {
      get
      {
        int spellTargetCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count, (void*) &spellTargetCount);
        return spellTargetCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_SpellTarget_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime
    {
      get
      {
        int changedIndexLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &changedIndexLifeTime);
        return changedIndexLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_LifeTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_HomingSpell_DataShared
    {
      get
      {
        int homingSpellDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared, (void*) &homingSpellDataShared);
        return homingSpellDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellTarget
    {
      get
      {
        int indexSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget, (void*) &indexSpellTarget);
        return indexSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LifeTime_Duration
    {
      get
      {
        int lifeTimeDuration;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &lifeTimeDuration);
        return lifeTimeDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_LifeTime_Duration, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_HomingSpell_DataShared_SyncAge
    {
      get
      {
        int dataSharedSyncAge;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncAge, (void*) &dataSharedSyncAge);
        return dataSharedSyncAge;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncAge, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_HomingSpell_DataShared_SyncPosition
    {
      get
      {
        int sharedSyncPosition;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncPosition, (void*) &sharedSyncPosition);
        return sharedSyncPosition;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncPosition, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Script_HomingSpell_DataShared_SyncRotation
    {
      get
      {
        int sharedSyncRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncRotation, (void*) &sharedSyncRotation);
        return sharedSyncRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Script_HomingSpell_DataShared_SyncRotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellTarget_Target
    {
      get
      {
        int spellTargetTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target, (void*) &spellTargetTarget);
        return spellTargetTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_SpellTarget_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LifeTime
    {
      get
      {
        int startOffsetLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &startOffsetLifeTime);
        return startOffsetLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LifeTime
    {
      get
      {
        int dataSizeLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &dataSizeLifeTime);
        return dataSizeLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_LifeTime, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Script_HomingSpell_DataShared
    {
      get
      {
        int homingSpellDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_Script_HomingSpell_DataShared, (void*) &homingSpellDataShared);
        return homingSpellDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_Script_HomingSpell_DataShared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Script_HomingSpell_DataShared
    {
      get
      {
        int homingSpellDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_Script_HomingSpell_DataShared, (void*) &homingSpellDataShared);
        return homingSpellDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_Script_HomingSpell_DataShared, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpellTarget
    {
      get
      {
        int offsetSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget, (void*) &offsetSpellTarget);
        return offsetSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpellTarget
    {
      get
      {
        int dataSizeSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_SpellTarget, (void*) &dataSizeSpellTarget);
        return dataSizeSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_SpellTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LifeTime
    {
      get
      {
        ulong compBitLifeTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &compBitLifeTime);
        return compBitLifeTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_LifeTime, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Script_HomingSpell_DataShared
    {
      get
      {
        ulong homingSpellDataShared;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_Script_HomingSpell_DataShared, (void*) &homingSpellDataShared);
        return homingSpellDataShared;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_Script_HomingSpell_DataShared, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpellTarget
    {
      get
      {
        ulong compBitSpellTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_SpellTarget, (void*) &compBitSpellTarget);
        return compBitSpellTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_SpellTarget, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acjigbfeikj.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }
  }
}
