// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_aifkcjfiic
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_aifkcjfiic
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Durability_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Equippable_EquipTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_NameGeneratorPostfixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_NameGeneratorPrefixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_RandomNamePostfix;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_RandomNamePrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_LegendaryItemInstance_TierIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_LegendaryItemSpellModSetComponent_AbilityMods0;
    private static readonly System.IntPtr NativeFieldInfoPtr_LegendaryItemSpellModSetComponent_AbilityMods1;
    private static readonly System.IntPtr NativeFieldInfoPtr_LegendaryItemSpellModSetComponent_StatMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Durability_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Durability_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equippable_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Equippable_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Durability_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance_TierIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods0;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods1;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_StatMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LegendaryItemInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemSpellModSetComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_LegendaryItemSpellModSetComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Durability;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Equippable;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LegendaryItemInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_LegendaryItemSpellModSetComponent;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float Durability_Value;
    [FieldOffset(12)]
    public NetworkId Equippable_EquipTarget;
    [FieldOffset(20)]
    public PrefabGUID GeneratedName_NameGeneratorPostfixSource;
    [FieldOffset(24)]
    public PrefabGUID GeneratedName_NameGeneratorPrefixSource;
    [FieldOffset(28)]
    public byte GeneratedName_RandomNamePostfix;
    [FieldOffset(29)]
    public byte GeneratedName_RandomNamePrefix;
    [FieldOffset(30)]
    public byte LegendaryItemInstance_TierIndex;
    [FieldOffset(31)]
    public SpellModSet LegendaryItemSpellModSetComponent_AbilityMods0;
    [FieldOffset(103)]
    public SpellModSet LegendaryItemSpellModSetComponent_AbilityMods1;
    [FieldOffset(175)]
    public SpellModSet LegendaryItemSpellModSetComponent_StatMods;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1552172, XrefRangeEnd = 1552238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_aifkcjfiic.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1552280, RefRangeEnd = 1552281, XrefRangeStart = 1552238, XrefRangeEnd = 1552280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_aifkcjfiic.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_aifkcjfiic()
    {
      Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_aifkcjfiic));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr);
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_Durability_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (Durability_Value));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_Equippable_EquipTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (Equippable_EquipTarget));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_GeneratedName_NameGeneratorPostfixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (GeneratedName_NameGeneratorPostfixSource));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_GeneratedName_NameGeneratorPrefixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (GeneratedName_NameGeneratorPrefixSource));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_GeneratedName_RandomNamePostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (GeneratedName_RandomNamePostfix));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_GeneratedName_RandomNamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (GeneratedName_RandomNamePrefix));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_LegendaryItemInstance_TierIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (LegendaryItemInstance_TierIndex));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_LegendaryItemSpellModSetComponent_AbilityMods0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (LegendaryItemSpellModSetComponent_AbilityMods0));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_LegendaryItemSpellModSetComponent_AbilityMods1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (LegendaryItemSpellModSetComponent_AbilityMods1));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_LegendaryItemSpellModSetComponent_StatMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (LegendaryItemSpellModSetComponent_StatMods));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Durability_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_Durability_Start));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Durability_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_Durability_Count));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_Equippable_Start));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_Equippable_Count));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_GeneratedName_Start));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_GeneratedName_Count));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_LegendaryItemInstance_Start));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_LegendaryItemInstance_Count));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_LegendaryItemSpellModSetComponent_Start));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedFields_LegendaryItemSpellModSetComponent_Count));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_Durability));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_Equippable));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_LegendaryItemInstance));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_LegendaryItemSpellModSetComponent));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Durability_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_Durability_Value));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_Equippable_EquipTarget));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_RandomNamePostfix));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_RandomNamePrefix));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance_TierIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_LegendaryItemInstance_TierIndex));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods0));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods1));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_StatMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (FrameChangedIndex_LegendaryItemSpellModSetComponent_StatMods));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataStartOffset_Durability));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataSize_Durability));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataStartOffset_Equippable));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataSize_Equippable));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataStartOffset_GeneratedName));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataSize_GeneratedName));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataStartOffset_LegendaryItemInstance));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_LegendaryItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataSize_LegendaryItemInstance));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemSpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataStartOffset_LegendaryItemSpellModSetComponent));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_LegendaryItemSpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (ComponentDataSize_LegendaryItemSpellModSetComponent));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_Durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (CompBit_Durability));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (CompBit_Equippable));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (CompBit_GeneratedName));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_LegendaryItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (CompBit_LegendaryItemInstance));
      Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_LegendaryItemSpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, nameof (CompBit_LegendaryItemSpellModSetComponent));
      Snapshot_aifkcjfiic.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, 100664398);
      Snapshot_aifkcjfiic.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, 100664399);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_aifkcjfiic>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Durability_Start
    {
      get
      {
        int fieldsDurabilityStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Durability_Start, (void*) &fieldsDurabilityStart);
        return fieldsDurabilityStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Durability_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Durability_Count
    {
      get
      {
        int fieldsDurabilityCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Durability_Count, (void*) &fieldsDurabilityCount);
        return fieldsDurabilityCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Durability_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equippable_Start
    {
      get
      {
        int fieldsEquippableStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start, (void*) &fieldsEquippableStart);
        return fieldsEquippableStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Equippable_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Equippable_Count
    {
      get
      {
        int fieldsEquippableCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count, (void*) &fieldsEquippableCount);
        return fieldsEquippableCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_Equippable_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_GeneratedName_Start
    {
      get
      {
        int generatedNameStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start, (void*) &generatedNameStart);
        return generatedNameStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_GeneratedName_Count
    {
      get
      {
        int generatedNameCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count, (void*) &generatedNameCount);
        return generatedNameCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LegendaryItemInstance_Start
    {
      get
      {
        int itemInstanceStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Start, (void*) &itemInstanceStart);
        return itemInstanceStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LegendaryItemInstance_Count
    {
      get
      {
        int itemInstanceCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Count, (void*) &itemInstanceCount);
        return itemInstanceCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemInstance_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LegendaryItemSpellModSetComponent_Start
    {
      get
      {
        int setComponentStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Start, (void*) &setComponentStart);
        return setComponentStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_LegendaryItemSpellModSetComponent_Count
    {
      get
      {
        int setComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Count, (void*) &setComponentCount);
        return setComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedFields_LegendaryItemSpellModSetComponent_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Durability
    {
      get
      {
        int changedIndexDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Durability, (void*) &changedIndexDurability);
        return changedIndexDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Durability, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equippable
    {
      get
      {
        int changedIndexEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Equippable, (void*) &changedIndexEquippable);
        return changedIndexEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Equippable, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName
    {
      get
      {
        int indexGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName, (void*) &indexGeneratedName);
        return indexGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LegendaryItemInstance
    {
      get
      {
        int legendaryItemInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance, (void*) &legendaryItemInstance);
        return legendaryItemInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LegendaryItemSpellModSetComponent
    {
      get
      {
        int spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Durability_Value
    {
      get
      {
        int indexDurabilityValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Durability_Value, (void*) &indexDurabilityValue);
        return indexDurabilityValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Durability_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Equippable_EquipTarget
    {
      get
      {
        int equippableEquipTarget;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget, (void*) &equippableEquipTarget);
        return equippableEquipTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_Equippable_EquipTarget, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource
    {
      get
      {
        int generatorPostfixSource;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource, (void*) &generatorPostfixSource);
        return generatorPostfixSource;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource
    {
      get
      {
        int generatorPrefixSource;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource, (void*) &generatorPrefixSource);
        return generatorPrefixSource;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_RandomNamePostfix
    {
      get
      {
        int randomNamePostfix;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix, (void*) &randomNamePostfix);
        return randomNamePostfix;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_RandomNamePrefix
    {
      get
      {
        int randomNamePrefix;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix, (void*) &randomNamePrefix);
        return randomNamePrefix;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LegendaryItemInstance_TierIndex
    {
      get
      {
        int instanceTierIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance_TierIndex, (void*) &instanceTierIndex);
        return instanceTierIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemInstance_TierIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods0
    {
      get
      {
        int componentAbilityMods0;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods0, (void*) &componentAbilityMods0);
        return componentAbilityMods0;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods0, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods1
    {
      get
      {
        int componentAbilityMods1;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods1, (void*) &componentAbilityMods1);
        return componentAbilityMods1;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_AbilityMods1, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_LegendaryItemSpellModSetComponent_StatMods
    {
      get
      {
        int componentStatMods;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_StatMods, (void*) &componentStatMods);
        return componentStatMods;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_FrameChangedIndex_LegendaryItemSpellModSetComponent_StatMods, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Durability
    {
      get
      {
        int offsetDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_Durability, (void*) &offsetDurability);
        return offsetDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_Durability, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Durability
    {
      get
      {
        int dataSizeDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_Durability, (void*) &dataSizeDurability);
        return dataSizeDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_Durability, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Equippable
    {
      get
      {
        int offsetEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable, (void*) &offsetEquippable);
        return offsetEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_Equippable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Equippable
    {
      get
      {
        int dataSizeEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_Equippable, (void*) &dataSizeEquippable);
        return dataSizeEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_Equippable, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_GeneratedName
    {
      get
      {
        int offsetGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName, (void*) &offsetGeneratedName);
        return offsetGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_GeneratedName
    {
      get
      {
        int sizeGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_GeneratedName, (void*) &sizeGeneratedName);
        return sizeGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_GeneratedName, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LegendaryItemInstance
    {
      get
      {
        int legendaryItemInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemInstance, (void*) &legendaryItemInstance);
        return legendaryItemInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemInstance, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LegendaryItemInstance
    {
      get
      {
        int legendaryItemInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_LegendaryItemInstance, (void*) &legendaryItemInstance);
        return legendaryItemInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_LegendaryItemInstance, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_LegendaryItemSpellModSetComponent
    {
      get
      {
        int spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemSpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataStartOffset_LegendaryItemSpellModSetComponent, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_LegendaryItemSpellModSetComponent
    {
      get
      {
        int spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_LegendaryItemSpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_ComponentDataSize_LegendaryItemSpellModSetComponent, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Durability
    {
      get
      {
        ulong compBitDurability;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_Durability, (void*) &compBitDurability);
        return compBitDurability;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_Durability, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Equippable
    {
      get
      {
        ulong compBitEquippable;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_Equippable, (void*) &compBitEquippable);
        return compBitEquippable;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_Equippable, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_GeneratedName
    {
      get
      {
        ulong bitGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_GeneratedName, (void*) &bitGeneratedName);
        return bitGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_GeneratedName, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LegendaryItemInstance
    {
      get
      {
        ulong legendaryItemInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_LegendaryItemInstance, (void*) &legendaryItemInstance);
        return legendaryItemInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_LegendaryItemInstance, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_LegendaryItemSpellModSetComponent
    {
      get
      {
        ulong spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_LegendaryItemSpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_aifkcjfiic.NativeFieldInfoPtr_CompBit_LegendaryItemSpellModSetComponent, (void*) &value);
      }
    }
  }
}
