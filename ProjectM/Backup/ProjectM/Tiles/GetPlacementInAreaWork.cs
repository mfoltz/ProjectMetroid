// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.GetPlacementInAreaWork
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Tiles
{
  public static class GetPlacementInAreaWork : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndRunJobs_Public_Static_Result_ComponentSystemBase_TileModelSpatialLookupMap_BoundsMinMax_Entity_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1085517, RefRangeEnd = 1085518, XrefRangeStart = 1085458, XrefRangeEnd = 1085517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GetPlacementInAreaWork.Result CreateAndRunJobs(
      ComponentSystemBase systemBase,
      TileModelSpatialLookupMap lookupMapSystem,
      BoundsMinMax areaWorldBounds,
      Entity entityToExclude)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lookupMapSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &areaWorldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entityToExclude;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementInAreaWork.NativeMethodInfoPtr_CreateAndRunJobs_Public_Static_Result_ComponentSystemBase_TileModelSpatialLookupMap_BoundsMinMax_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GetPlacementInAreaWork.Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GetPlacementInAreaWork()
    {
      Il2CppClassPointerStore<GetPlacementInAreaWork>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (GetPlacementInAreaWork));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementInAreaWork>.NativeClassPtr);
      GetPlacementInAreaWork.NativeMethodInfoPtr_CreateAndRunJobs_Public_Static_Result_ComponentSystemBase_TileModelSpatialLookupMap_BoundsMinMax_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementInAreaWork>.NativeClassPtr, 100685500);
    }

    public GetPlacementInAreaWork(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Result
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementArray;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public BoundsMinMax WorldBounds;
      [FieldOffset(16)]
      public NativeMultiHashMap<int3, PlacementData> PlacementArray;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1085400, RefRangeEnd = 1085401, XrefRangeStart = 1085394, XrefRangeEnd = 1085400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementInAreaWork.Result.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Result()
      {
        Il2CppClassPointerStore<GetPlacementInAreaWork.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementInAreaWork>.NativeClassPtr, nameof (Result));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementInAreaWork.Result>.NativeClassPtr);
        GetPlacementInAreaWork.Result.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.Result>.NativeClassPtr, nameof (WorldBounds));
        GetPlacementInAreaWork.Result.NativeFieldInfoPtr_PlacementArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.Result>.NativeClassPtr, nameof (PlacementArray));
        GetPlacementInAreaWork.Result.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementInAreaWork.Result>.NativeClassPtr, 100685501);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementInAreaWork.Result>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MergePlacementDataJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTiles;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBakedPlacementTilesBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsPrefabEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabTileOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabTileRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_AreaWorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_MergedPlacementArray;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public TileWorld TileWorld;
      [FieldOffset(24)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(40)]
      public BufferFromEntity<BakedPlacementTiles> GetBakedPlacementTiles;
      [FieldOffset(80)]
      public BufferFromEntity<BakedPlacementTilesBounds> GetBakedPlacementTilesBounds;
      [FieldOffset(120)]
      public NativeArray<Entity> Entities;
      [FieldOffset(136)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(168)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(200)]
      public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
      [FieldOffset(232)]
      public bool IsPrefabEntity;
      [FieldOffset(236)]
      public int2 PrefabTileOffset;
      [FieldOffset(244)]
      public TileRotation PrefabTileRotation;
      [FieldOffset(248)]
      public BoundsMinMax AreaWorldBounds;
      [FieldOffset(264)]
      public NativeMultiHashMap<int3, PlacementData> MergedPlacementArray;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085401, XrefRangeEnd = 1085458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementInAreaWork.MergePlacementDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MergePlacementDataJob()
      {
        Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementInAreaWork>.NativeClassPtr, nameof (MergePlacementDataJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr);
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (TileWorld));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (TerrainChunks));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_GetBakedPlacementTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (GetBakedPlacementTiles));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_GetBakedPlacementTilesBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (GetBakedPlacementTilesBounds));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (Entities));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (GetTilePosition));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (GetTileData));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (GetLocalToWorld));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_IsPrefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (IsPrefabEntity));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_PrefabTileOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (PrefabTileOffset));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_PrefabTileRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (PrefabTileRotation));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_AreaWorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (AreaWorldBounds));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeFieldInfoPtr_MergedPlacementArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, nameof (MergedPlacementArray));
        GetPlacementInAreaWork.MergePlacementDataJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, 100685502);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementInAreaWork.MergePlacementDataJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
