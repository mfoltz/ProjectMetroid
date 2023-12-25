// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowTileCollision2DSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ShowTileCollision2DSystem : 
    DrawTileGridSystem<ShowTileCollision2D, ShowTileCollision2DSystem.GridIsActive>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DrawQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFlags_Private_Static_IEnumerable_1_Enum_Enum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074599, XrefRangeEnd = 1074619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileCollision2DSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074619, XrefRangeEnd = 1074729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileCollision2DSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074729, XrefRangeEnd = 1074734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IEnumerable<Il2CppSystem.Enum> GetFlags(Il2CppSystem.Enum input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) input));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem.NativeMethodInfoPtr_GetFlags_Private_Static_IEnumerable_1_Enum_Enum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerable<Il2CppSystem.Enum>) null : new IEnumerable<Il2CppSystem.Enum>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074734, XrefRangeEnd = 1074737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowTileCollision2DSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074737, XrefRangeEnd = 1074740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileCollision2DSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowTileCollision2DSystem()
    {
      Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShowTileCollision2DSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr);
      ShowTileCollision2DSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, nameof (_TerrainManager));
      ShowTileCollision2DSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      ShowTileCollision2DSystem.NativeFieldInfoPtr__DrawQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, nameof (_DrawQuery));
      ShowTileCollision2DSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, 100684660);
      ShowTileCollision2DSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, 100684661);
      ShowTileCollision2DSystem.NativeMethodInfoPtr_GetFlags_Private_Static_IEnumerable_1_Enum_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, 100684662);
      ShowTileCollision2DSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, 100684663);
      ShowTileCollision2DSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, 100684664);
    }

    public ShowTileCollision2DSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DrawQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem.NativeFieldInfoPtr__DrawQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem.NativeFieldInfoPtr__DrawQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GridIsActive
    {
      static GridIsActive()
      {
        Il2CppClassPointerStore<ShowTileCollision2DSystem.GridIsActive>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, nameof (GridIsActive));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollision2DSystem.GridIsActive>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollision2DSystem.GridIsActive>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HoveredTileData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllocationState;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileLayer;
      [FieldOffset(0)]
      public MapCollisionFlags MapCollisionFlags;
      [FieldOffset(4)]
      public ShowTileCollision2DSystem.TileAllocationState AllocationState;
      [FieldOffset(8)]
      public byte HeightLevel;
      [FieldOffset(9)]
      public TileLayerIndex TileLayer;

      static HoveredTileData()
      {
        Il2CppClassPointerStore<ShowTileCollision2DSystem.HoveredTileData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, nameof (HoveredTileData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollision2DSystem.HoveredTileData>.NativeClassPtr);
        ShowTileCollision2DSystem.HoveredTileData.NativeFieldInfoPtr_MapCollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.HoveredTileData>.NativeClassPtr, nameof (MapCollisionFlags));
        ShowTileCollision2DSystem.HoveredTileData.NativeFieldInfoPtr_AllocationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.HoveredTileData>.NativeClassPtr, nameof (AllocationState));
        ShowTileCollision2DSystem.HoveredTileData.NativeFieldInfoPtr_HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.HoveredTileData>.NativeClassPtr, nameof (HeightLevel));
        ShowTileCollision2DSystem.HoveredTileData.NativeFieldInfoPtr_TileLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.HoveredTileData>.NativeClassPtr, nameof (TileLayer));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollision2DSystem.HoveredTileData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum TileAllocationState
    {
      Unknown,
      CellOutOfBounds,
      CellNotAllocated,
      LayerNotAllocated,
      Allocated,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ShowTileCollisionJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DrawGridJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_MouseTile;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_HoveredTileData;
      private static readonly System.IntPtr NativeMethodInfoPtr_FillColor_Private_Void_BoundsMinMax_Int32_CellIntersection_NativeArray_1_Color32_Byte_TileAllocationState_TileLayerIndex_Color_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public DrawTileGridJob<ShowTileCollision2D> DrawGridJob;
      [FieldOffset(152)]
      public int2 MouseTile;
      [FieldOffset(160)]
      public TileWorld TileWorld;
      [FieldOffset(184)]
      public NativeReference<ShowTileCollision2DSystem.HoveredTileData> HoveredTileData;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1074483, RefRangeEnd = 1074484, XrefRangeStart = 1074478, XrefRangeEnd = 1074483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void FillColor(
        BoundsMinMax worldBounds,
        int drawSize,
        CellIntersection intersection,
        NativeArray<Color32> colors,
        byte heightLevel,
        ShowTileCollision2DSystem.TileAllocationState allocationState,
        TileLayerIndex tileLayer,
        Color color)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &worldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &drawSize;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &intersection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &colors;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &allocationState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem.ShowTileCollisionJob.NativeMethodInfoPtr_FillColor_Private_Void_BoundsMinMax_Int32_CellIntersection_NativeArray_1_Color32_Byte_TileAllocationState_TileLayerIndex_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074484, XrefRangeEnd = 1074536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem.ShowTileCollisionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShowTileCollisionJob()
      {
        Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, nameof (ShowTileCollisionJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr);
        ShowTileCollision2DSystem.ShowTileCollisionJob.NativeFieldInfoPtr_DrawGridJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr, nameof (DrawGridJob));
        ShowTileCollision2DSystem.ShowTileCollisionJob.NativeFieldInfoPtr_MouseTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr, nameof (MouseTile));
        ShowTileCollision2DSystem.ShowTileCollisionJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr, nameof (TileWorld));
        ShowTileCollision2DSystem.ShowTileCollisionJob.NativeFieldInfoPtr_HoveredTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr, nameof (HoveredTileData));
        ShowTileCollision2DSystem.ShowTileCollisionJob.NativeMethodInfoPtr_FillColor_Private_Void_BoundsMinMax_Int32_CellIntersection_NativeArray_1_Color32_Byte_TileAllocationState_TileLayerIndex_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr, 100684665);
        ShowTileCollision2DSystem.ShowTileCollisionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr, 100684666);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollision2DSystem.ShowTileCollisionJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ShowTileCollision2DSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdateDrawGridSystem_b__7_0_Internal_String_Enum_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTileCollision2DSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074536, XrefRangeEnd = 1074546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _OnUpdateDrawGridSystem_b__7_0(Il2CppSystem.Enum f)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) f));
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem.__c.NativeMethodInfoPtr__OnUpdateDrawGridSystem_b__7_0_Internal_String_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<ShowTileCollision2DSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollision2DSystem.__c>.NativeClassPtr);
        ShowTileCollision2DSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.__c>.NativeClassPtr, "<>9");
        ShowTileCollision2DSystem.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem.__c>.NativeClassPtr, "<>9__7_0");
        ShowTileCollision2DSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem.__c>.NativeClassPtr, 100684668);
        ShowTileCollision2DSystem.__c.NativeMethodInfoPtr__OnUpdateDrawGridSystem_b__7_0_Internal_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem.__c>.NativeClassPtr, 100684669);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ShowTileCollision2DSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowTileCollision2DSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ShowTileCollision2DSystem.__c) null : new ShowTileCollision2DSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowTileCollision2DSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Il2CppSystem.Enum, string> __9__7_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ShowTileCollision2DSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Enum, string>) null : new Il2CppSystem.Func<Il2CppSystem.Enum, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ShowTileCollision2DSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.ShowTileCollision2DSystem/<GetFlags>d__8")]
    public sealed class _GetFlags_d__8 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;
      private static readonly System.IntPtr NativeFieldInfoPtr_input;
      private static readonly System.IntPtr NativeFieldInfoPtr___3__input;
      private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Enum__get_Current_Private_Virtual_Final_New_get_Enum_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Enum__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Enum_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 181226, RefRangeEnd = 181236, XrefRangeStart = 181226, XrefRangeEnd = 181236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _GetFlags_d__8(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_param1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1074552, RefRangeEnd = 1074553, XrefRangeStart = 1074546, XrefRangeEnd = 1074552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074553, XrefRangeEnd = 1074581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074581, XrefRangeEnd = 1074586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void __m__Finally1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Enum System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EEnum\u003E\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Enum__get_Current_Private_Virtual_Final_New_get_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new Il2CppSystem.Enum(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074586, XrefRangeEnd = 1074591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074591, XrefRangeEnd = 1074599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<Il2CppSystem.Enum> System_Collections_Generic_IEnumerable_System_Enum__GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Enum__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<Il2CppSystem.Enum>) null : new IEnumerator<Il2CppSystem.Enum>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static _GetFlags_d__8()
      {
        Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollision2DSystem>.NativeClassPtr, "<GetFlags>d__8");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, "<>1__state");
        ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, "<>2__current");
        ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, "<>l__initialThreadId");
        ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, nameof (input));
        ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___3__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, "<>3__input");
        ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, "<>7__wrap1");
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684670);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684671);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684672);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684673);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Enum__get_Current_Private_Virtual_Final_New_get_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684674);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684675);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684676);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Enum__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684677);
        ShowTileCollision2DSystem._GetFlags_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2DSystem._GetFlags_d__8>.NativeClassPtr, 100684678);
      }

      public _GetFlags_d__8(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public Il2CppSystem.Enum __2__current
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___2__current);
          return new Il2CppSystem.Enum(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Enum>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Enum>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe int __l__initialThreadId
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___l__initialThreadId));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
        }
      }

      public Il2CppSystem.Enum input
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr_input);
          return new Il2CppSystem.Enum(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Enum>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr_input), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Enum>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public Il2CppSystem.Enum __3__input
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___3__input);
          return new Il2CppSystem.Enum(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Enum>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___3__input), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Enum>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe IEnumerator __7__wrap1
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___7__wrap1));
          return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollision2DSystem._GetFlags_d__8.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
