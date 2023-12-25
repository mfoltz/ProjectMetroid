// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_achiggdccdc
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
  public struct Snapshot_achiggdccdc
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_NameGeneratorPostfixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_NameGeneratorPrefixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_RandomNamePostfix;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedName_RandomNamePrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelInstance_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelInstance_TierIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModSetComponent_SpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_TierIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent_SpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_JewelInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_JewelInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SpellModSetComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SpellModSetComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_GeneratedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_JewelInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SpellModSetComponent;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public PrefabGUID GeneratedName_NameGeneratorPostfixSource;
    [FieldOffset(12)]
    public PrefabGUID GeneratedName_NameGeneratorPrefixSource;
    [FieldOffset(16)]
    public byte GeneratedName_RandomNamePostfix;
    [FieldOffset(17)]
    public byte GeneratedName_RandomNamePrefix;
    [FieldOffset(18)]
    public PrefabGUID JewelInstance_Ability;
    [FieldOffset(22)]
    public byte JewelInstance_TierIndex;
    [FieldOffset(23)]
    public SpellModSet SpellModSetComponent_SpellMods;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1534236, XrefRangeEnd = 1534255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_achiggdccdc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1534279, RefRangeEnd = 1534280, XrefRangeStart = 1534255, XrefRangeEnd = 1534279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_achiggdccdc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_achiggdccdc()
    {
      Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_achiggdccdc));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr);
      Snapshot_achiggdccdc.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_GeneratedName_NameGeneratorPostfixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (GeneratedName_NameGeneratorPostfixSource));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_GeneratedName_NameGeneratorPrefixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (GeneratedName_NameGeneratorPrefixSource));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_GeneratedName_RandomNamePostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (GeneratedName_RandomNamePostfix));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_GeneratedName_RandomNamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (GeneratedName_RandomNamePrefix));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_JewelInstance_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (JewelInstance_Ability));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_JewelInstance_TierIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (JewelInstance_TierIndex));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_SpellModSetComponent_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (SpellModSetComponent_SpellMods));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedFields_GeneratedName_Start));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedFields_GeneratedName_Count));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedFields_JewelInstance_Start));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedFields_JewelInstance_Count));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedFields_SpellModSetComponent_Start));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedFields_SpellModSetComponent_Count));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_JewelInstance));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_SpellModSetComponent));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_RandomNamePostfix));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_GeneratedName_RandomNamePrefix));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_JewelInstance_Ability));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_TierIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_JewelInstance_TierIndex));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (FrameChangedIndex_SpellModSetComponent_SpellMods));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (ComponentDataStartOffset_GeneratedName));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (ComponentDataSize_GeneratedName));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_JewelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (ComponentDataStartOffset_JewelInstance));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_JewelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (ComponentDataSize_JewelInstance));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_SpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (ComponentDataStartOffset_SpellModSetComponent));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_SpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (ComponentDataSize_SpellModSetComponent));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_GeneratedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (CompBit_GeneratedName));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_JewelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (CompBit_JewelInstance));
      Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_SpellModSetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, nameof (CompBit_SpellModSetComponent));
      Snapshot_achiggdccdc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, 100664234);
      Snapshot_achiggdccdc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, 100664235);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_achiggdccdc>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_GeneratedName_Start
    {
      get
      {
        int generatedNameStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start, (void*) &generatedNameStart);
        return generatedNameStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_GeneratedName_Count
    {
      get
      {
        int generatedNameCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count, (void*) &generatedNameCount);
        return generatedNameCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_GeneratedName_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_JewelInstance_Start
    {
      get
      {
        int jewelInstanceStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Start, (void*) &jewelInstanceStart);
        return jewelInstanceStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_JewelInstance_Count
    {
      get
      {
        int jewelInstanceCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Count, (void*) &jewelInstanceCount);
        return jewelInstanceCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_JewelInstance_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellModSetComponent_Start
    {
      get
      {
        int setComponentStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Start, (void*) &setComponentStart);
        return setComponentStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SpellModSetComponent_Count
    {
      get
      {
        int setComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Count, (void*) &setComponentCount);
        return setComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedFields_SpellModSetComponent_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName
    {
      get
      {
        int indexGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName, (void*) &indexGeneratedName);
        return indexGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelInstance
    {
      get
      {
        int indexJewelInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance, (void*) &indexJewelInstance);
        return indexJewelInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellModSetComponent
    {
      get
      {
        int spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource
    {
      get
      {
        int generatorPostfixSource;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource, (void*) &generatorPostfixSource);
        return generatorPostfixSource;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPostfixSource, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource
    {
      get
      {
        int generatorPrefixSource;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource, (void*) &generatorPrefixSource);
        return generatorPrefixSource;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_NameGeneratorPrefixSource, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_RandomNamePostfix
    {
      get
      {
        int randomNamePostfix;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix, (void*) &randomNamePostfix);
        return randomNamePostfix;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePostfix, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_GeneratedName_RandomNamePrefix
    {
      get
      {
        int randomNamePrefix;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix, (void*) &randomNamePrefix);
        return randomNamePrefix;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_GeneratedName_RandomNamePrefix, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelInstance_Ability
    {
      get
      {
        int jewelInstanceAbility;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_Ability, (void*) &jewelInstanceAbility);
        return jewelInstanceAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_Ability, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_JewelInstance_TierIndex
    {
      get
      {
        int instanceTierIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_TierIndex, (void*) &instanceTierIndex);
        return instanceTierIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_JewelInstance_TierIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SpellModSetComponent_SpellMods
    {
      get
      {
        int componentSpellMods;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent_SpellMods, (void*) &componentSpellMods);
        return componentSpellMods;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_FrameChangedIndex_SpellModSetComponent_SpellMods, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_GeneratedName
    {
      get
      {
        int offsetGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName, (void*) &offsetGeneratedName);
        return offsetGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_GeneratedName, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_GeneratedName
    {
      get
      {
        int sizeGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_GeneratedName, (void*) &sizeGeneratedName);
        return sizeGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_GeneratedName, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_JewelInstance
    {
      get
      {
        int offsetJewelInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_JewelInstance, (void*) &offsetJewelInstance);
        return offsetJewelInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_JewelInstance, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_JewelInstance
    {
      get
      {
        int sizeJewelInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_JewelInstance, (void*) &sizeJewelInstance);
        return sizeJewelInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_JewelInstance, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SpellModSetComponent
    {
      get
      {
        int spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_SpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataStartOffset_SpellModSetComponent, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SpellModSetComponent
    {
      get
      {
        int spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_SpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_ComponentDataSize_SpellModSetComponent, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_GeneratedName
    {
      get
      {
        ulong bitGeneratedName;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_GeneratedName, (void*) &bitGeneratedName);
        return bitGeneratedName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_GeneratedName, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_JewelInstance
    {
      get
      {
        ulong bitJewelInstance;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_JewelInstance, (void*) &bitJewelInstance);
        return bitJewelInstance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_JewelInstance, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SpellModSetComponent
    {
      get
      {
        ulong spellModSetComponent;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_SpellModSetComponent, (void*) &spellModSetComponent);
        return spellModSetComponent;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_achiggdccdc.NativeFieldInfoPtr_CompBit_SpellModSetComponent, (void*) &value);
      }
    }
  }
}
