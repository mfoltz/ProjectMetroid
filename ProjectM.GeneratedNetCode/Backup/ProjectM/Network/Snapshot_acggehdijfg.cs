// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_acggehdijfg
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
  public struct Snapshot_acggehdijfg
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCooldownState_CooldownEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCooldownState_CurrentCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityState_GroupEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityState_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityState_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityState;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CooldownEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CurrentCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityState_GroupEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityCooldownState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityCooldownState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityState;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_AbilityTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_AbilityTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityCooldownState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_AbilityTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_EntityOwner;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public double AbilityCooldownState_CooldownEndTime;
    [FieldOffset(16)]
    public float AbilityCooldownState_CurrentCooldown;
    [FieldOffset(20)]
    public NetworkId AbilityState_GroupEntity;
    [FieldOffset(28)]
    public NetworkId AbilityTarget_Target;
    [FieldOffset(36)]
    public NetworkId EntityOwner_Owner;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1531927, XrefRangeEnd = 1531986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acggehdijfg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1532017, RefRangeEnd = 1532018, XrefRangeStart = 1531986, XrefRangeEnd = 1532017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_acggehdijfg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_acggehdijfg()
    {
      Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_acggehdijfg));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr);
      Snapshot_acggehdijfg.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_AbilityCooldownState_CooldownEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (AbilityCooldownState_CooldownEndTime));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_AbilityCooldownState_CurrentCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (AbilityCooldownState_CurrentCooldown));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_AbilityState_GroupEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (AbilityState_GroupEntity));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_AbilityTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (AbilityTarget_Target));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (EntityOwner_Owner));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_AbilityCooldownState_Start));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_AbilityCooldownState_Count));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityState_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_AbilityState_Start));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityState_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_AbilityState_Count));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_AbilityTarget_Start));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_AbilityTarget_Count));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Start));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedFields_EntityOwner_Count));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_AbilityCooldownState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_AbilityState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_AbilityTarget));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CooldownEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_AbilityCooldownState_CooldownEndTime));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CurrentCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_AbilityCooldownState_CurrentCooldown));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityState_GroupEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_AbilityState_GroupEntity));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_AbilityTarget_Target));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (FrameChangedIndex_EntityOwner_Owner));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityCooldownState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityCooldownState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityCooldownState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataSize_AbilityCooldownState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataSize_AbilityState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataStartOffset_AbilityTarget));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataSize_AbilityTarget));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataStartOffset_EntityOwner));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (ComponentDataSize_EntityOwner));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityCooldownState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (CompBit_AbilityCooldownState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (CompBit_AbilityState));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (CompBit_AbilityTarget));
      Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, nameof (CompBit_EntityOwner));
      Snapshot_acggehdijfg.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, 100664208);
      Snapshot_acggehdijfg.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, 100664209);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_acggehdijfg>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityCooldownState_Start
    {
      get
      {
        int cooldownStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Start, (void*) &cooldownStateStart);
        return cooldownStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityCooldownState_Count
    {
      get
      {
        int cooldownStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Count, (void*) &cooldownStateCount);
        return cooldownStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityCooldownState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityState_Start
    {
      get
      {
        int abilityStateStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityState_Start, (void*) &abilityStateStart);
        return abilityStateStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityState_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityState_Count
    {
      get
      {
        int abilityStateCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityState_Count, (void*) &abilityStateCount);
        return abilityStateCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityState_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityTarget_Start
    {
      get
      {
        int abilityTargetStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Start, (void*) &abilityTargetStart);
        return abilityTargetStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_AbilityTarget_Count
    {
      get
      {
        int abilityTargetCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Count, (void*) &abilityTargetCount);
        return abilityTargetCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_AbilityTarget_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Start
    {
      get
      {
        int entityOwnerStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &entityOwnerStart);
        return entityOwnerStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_EntityOwner_Count
    {
      get
      {
        int entityOwnerCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &entityOwnerCount);
        return entityOwnerCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedFields_EntityOwner_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityCooldownState
    {
      get
      {
        int abilityCooldownState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState, (void*) &abilityCooldownState);
        return abilityCooldownState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityState
    {
      get
      {
        int indexAbilityState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityState, (void*) &indexAbilityState);
        return indexAbilityState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityState, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityTarget
    {
      get
      {
        int indexAbilityTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget, (void*) &indexAbilityTarget);
        return indexAbilityTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner
    {
      get
      {
        int indexEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &indexEntityOwner);
        return indexEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityCooldownState_CooldownEndTime
    {
      get
      {
        int stateCooldownEndTime;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CooldownEndTime, (void*) &stateCooldownEndTime);
        return stateCooldownEndTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CooldownEndTime, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityCooldownState_CurrentCooldown
    {
      get
      {
        int stateCurrentCooldown;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CurrentCooldown, (void*) &stateCurrentCooldown);
        return stateCurrentCooldown;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityCooldownState_CurrentCooldown, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityState_GroupEntity
    {
      get
      {
        int stateGroupEntity;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityState_GroupEntity, (void*) &stateGroupEntity);
        return stateGroupEntity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityState_GroupEntity, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_AbilityTarget_Target
    {
      get
      {
        int abilityTargetTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget_Target, (void*) &abilityTargetTarget);
        return abilityTargetTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_AbilityTarget_Target, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_EntityOwner_Owner
    {
      get
      {
        int entityOwnerOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &entityOwnerOwner);
        return entityOwnerOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_FrameChangedIndex_EntityOwner_Owner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityCooldownState
    {
      get
      {
        int abilityCooldownState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityCooldownState, (void*) &abilityCooldownState);
        return abilityCooldownState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityCooldownState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityCooldownState
    {
      get
      {
        int abilityCooldownState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityCooldownState, (void*) &abilityCooldownState);
        return abilityCooldownState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityCooldownState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityState
    {
      get
      {
        int offsetAbilityState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityState, (void*) &offsetAbilityState);
        return offsetAbilityState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityState
    {
      get
      {
        int sizeAbilityState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityState, (void*) &sizeAbilityState);
        return sizeAbilityState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityState, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_AbilityTarget
    {
      get
      {
        int offsetAbilityTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityTarget, (void*) &offsetAbilityTarget);
        return offsetAbilityTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_AbilityTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_AbilityTarget
    {
      get
      {
        int sizeAbilityTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityTarget, (void*) &sizeAbilityTarget);
        return sizeAbilityTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_AbilityTarget, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_EntityOwner
    {
      get
      {
        int offsetEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &offsetEntityOwner);
        return offsetEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataStartOffset_EntityOwner, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_EntityOwner
    {
      get
      {
        int dataSizeEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &dataSizeEntityOwner);
        return dataSizeEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_ComponentDataSize_EntityOwner, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityCooldownState
    {
      get
      {
        ulong abilityCooldownState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityCooldownState, (void*) &abilityCooldownState);
        return abilityCooldownState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityCooldownState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityState
    {
      get
      {
        ulong compBitAbilityState;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityState, (void*) &compBitAbilityState);
        return compBitAbilityState;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityState, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_AbilityTarget
    {
      get
      {
        ulong bitAbilityTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityTarget, (void*) &bitAbilityTarget);
        return bitAbilityTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_AbilityTarget, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_EntityOwner
    {
      get
      {
        ulong compBitEntityOwner;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &compBitEntityOwner);
        return compBitEntityOwner;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_acggehdijfg.NativeFieldInfoPtr_CompBit_EntityOwner, (void*) &value);
      }
    }
  }
}
