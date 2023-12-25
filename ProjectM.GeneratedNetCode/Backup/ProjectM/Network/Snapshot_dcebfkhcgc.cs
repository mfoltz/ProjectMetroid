﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_dcebfkhcgc
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_dcebfkhcgc
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_Team_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_TileModel_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_Team_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_TileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_StaticTransformCompatible;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_Team;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_TileModel;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public float StaticTransformCompatible_NonStaticTransform_Height;
    [FieldOffset(12)]
    public float2 StaticTransformCompatible_NonStaticTransform_Pos;
    [FieldOffset(20)]
    public TileRotation StaticTransformCompatible_NonStaticTransform_Rotation;
    [FieldOffset(21)]
    public StaticTransformIndex StaticTransformCompatible_StaticTransform;
    [FieldOffset(33)]
    public bool StaticTransformCompatible_UseStaticTransform;
    [FieldOffset(34)]
    public int Team_FactionIndex;
    [FieldOffset(38)]
    public int Team_Value;
    [FieldOffset(42)]
    public ProjectM.TileType TileModel_DisabledTileTypes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1577190, XrefRangeEnd = 1577239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dcebfkhcgc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1577265, RefRangeEnd = 1577266, XrefRangeStart = 1577239, XrefRangeEnd = 1577265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_dcebfkhcgc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_dcebfkhcgc()
    {
      Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_dcebfkhcgc));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr);
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (StaticTransformCompatible_StaticTransform));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (StaticTransformCompatible_UseStaticTransform));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (Team_FactionIndex));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (Team_Value));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (TileModel_DisabledTileTypes));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Start));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedFields_StaticTransformCompatible_Count));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_Team_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedFields_Team_Start));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_Team_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedFields_Team_Count));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Start));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedFields_TileModel_Count));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_Team));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_TileModel));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_StaticTransform));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_StaticTransformCompatible_UseStaticTransform));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_Team_FactionIndex));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_Team_Value));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (FrameChangedIndex_TileModel_DisabledTileTypes));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (ComponentDataStartOffset_StaticTransformCompatible));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (ComponentDataSize_StaticTransformCompatible));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (ComponentDataStartOffset_Team));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (ComponentDataSize_Team));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (ComponentDataStartOffset_TileModel));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (ComponentDataSize_TileModel));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_StaticTransformCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (CompBit_StaticTransformCompatible));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (CompBit_Team));
      Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_TileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, nameof (CompBit_TileModel));
      Snapshot_dcebfkhcgc.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, 100664608);
      Snapshot_dcebfkhcgc.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, 100664609);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_dcebfkhcgc>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Start
    {
      get
      {
        int transformCompatibleStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &transformCompatibleStart);
        return transformCompatibleStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_StaticTransformCompatible_Count
    {
      get
      {
        int transformCompatibleCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &transformCompatibleCount);
        return transformCompatibleCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_StaticTransformCompatible_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Start
    {
      get
      {
        int changedFieldsTeamStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &changedFieldsTeamStart);
        return changedFieldsTeamStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_Team_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_Team_Count
    {
      get
      {
        int changedFieldsTeamCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &changedFieldsTeamCount);
        return changedFieldsTeamCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_Team_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Start
    {
      get
      {
        int fieldsTileModelStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &fieldsTileModelStart);
        return fieldsTileModelStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_TileModel_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_TileModel_Count
    {
      get
      {
        int fieldsTileModelCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &fieldsTileModelCount);
        return fieldsTileModelCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedFields_TileModel_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team
    {
      get
      {
        int changedIndexTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &changedIndexTeam);
        return changedIndexTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel
    {
      get
      {
        int changedIndexTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &changedIndexTileModel);
        return changedIndexTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_TileModel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height
    {
      get
      {
        int staticTransformHeight;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &staticTransformHeight);
        return staticTransformHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Height, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos
    {
      get
      {
        int staticTransformPos;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &staticTransformPos);
        return staticTransformPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Pos, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation
    {
      get
      {
        int transformRotation;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &transformRotation);
        return transformRotation;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_NonStaticTransform_Rotation, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_StaticTransform
    {
      get
      {
        int compatibleStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &compatibleStaticTransform);
        return compatibleStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_StaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_StaticTransformCompatible_UseStaticTransform
    {
      get
      {
        int useStaticTransform;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &useStaticTransform);
        return useStaticTransform;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_StaticTransformCompatible_UseStaticTransform, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_FactionIndex
    {
      get
      {
        int teamFactionIndex;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &teamFactionIndex);
        return teamFactionIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team_FactionIndex, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_Team_Value
    {
      get
      {
        int changedIndexTeamValue;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &changedIndexTeamValue);
        return changedIndexTeamValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_Team_Value, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_TileModel_DisabledTileTypes
    {
      get
      {
        int disabledTileTypes;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &disabledTileTypes);
        return disabledTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_FrameChangedIndex_TileModel_DisabledTileTypes, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_StaticTransformCompatible
    {
      get
      {
        int transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_Team
    {
      get
      {
        int dataStartOffsetTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &dataStartOffsetTeam);
        return dataStartOffsetTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_Team
    {
      get
      {
        int componentDataSizeTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &componentDataSizeTeam);
        return componentDataSizeTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_Team, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_TileModel
    {
      get
      {
        int startOffsetTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &startOffsetTileModel);
        return startOffsetTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataStartOffset_TileModel, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_TileModel
    {
      get
      {
        int dataSizeTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &dataSizeTileModel);
        return dataSizeTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_ComponentDataSize_TileModel, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_StaticTransformCompatible
    {
      get
      {
        ulong transformCompatible;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &transformCompatible);
        return transformCompatible;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_StaticTransformCompatible, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_Team
    {
      get
      {
        ulong compBitTeam;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_Team, (void*) &compBitTeam);
        return compBitTeam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_Team, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_TileModel
    {
      get
      {
        ulong compBitTileModel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_TileModel, (void*) &compBitTileModel);
        return compBitTileModel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_dcebfkhcgc.NativeFieldInfoPtr_CompBit_TileModel, (void*) &value);
      }
    }
  }
}
