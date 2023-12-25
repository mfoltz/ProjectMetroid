// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldZoneCollection
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

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldZoneCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldZoneEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldZoneIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunkMetadatas;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollection_WorldZoneCollectionQueries_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollection_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindZoneForPosition_Public_Boolean_float3_byref_Entity_byref_WorldZoneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindZoneForWorldZoneId_Public_Boolean_WorldZoneId_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetUserZoneData_Public_Static_Boolean_WorldZoneId_DynamicBuffer_1_UserMapZoneElement_byref_UserMapZoneElement_0;
    [FieldOffset(0)]
    public NativeArray<Entity> WorldZoneEntities;
    [FieldOffset(16)]
    public NativeArray<WorldZoneId> WorldZoneIds;
    [FieldOffset(32)]
    public NativeArray<TerrainChunkMetadata> TerrainChunkMetadatas;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1049467, RefRangeEnd = 1049470, XrefRangeStart = 1049460, XrefRangeEnd = 1049467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WorldZoneCollection Create(WorldZoneCollectionQueries queries)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &queries;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldZoneCollection.NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollection_WorldZoneCollectionQueries_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WorldZoneCollection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1049493, RefRangeEnd = 1049494, XrefRangeStart = 1049470, XrefRangeEnd = 1049493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WorldZoneCollection Create(ComponentSystemBase system)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldZoneCollection.NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollection_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WorldZoneCollection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1049503, RefRangeEnd = 1049507, XrefRangeStart = 1049494, XrefRangeEnd = 1049503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldZoneCollection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1049509, RefRangeEnd = 1049511, XrefRangeStart = 1049507, XrefRangeEnd = 1049509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindZoneForPosition(
      float3 worldPosition,
      out Entity zoneEntity,
      out WorldZoneId zoneId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref zoneEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref zoneId;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldZoneCollection.NativeMethodInfoPtr_TryFindZoneForPosition_Public_Boolean_float3_byref_Entity_byref_WorldZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1049512, RefRangeEnd = 1049513, XrefRangeStart = 1049511, XrefRangeEnd = 1049512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindZoneForWorldZoneId(WorldZoneId zoneId, out Entity zoneEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &zoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref zoneEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldZoneCollection.NativeMethodInfoPtr_TryFindZoneForWorldZoneId_Public_Boolean_WorldZoneId_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1049522, RefRangeEnd = 1049524, XrefRangeStart = 1049513, XrefRangeEnd = 1049522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetUserZoneData(
      WorldZoneId zoneId,
      DynamicBuffer<UserMapZoneElement> userZoneDatas,
      out UserMapZoneElement userZoneData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &zoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userZoneDatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref userZoneData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldZoneCollection.NativeMethodInfoPtr_TryGetUserZoneData_Public_Static_Boolean_WorldZoneId_DynamicBuffer_1_UserMapZoneElement_byref_UserMapZoneElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorldZoneCollection()
    {
      Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorldZoneCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr);
      WorldZoneCollection.NativeFieldInfoPtr_WorldZoneEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, nameof (WorldZoneEntities));
      WorldZoneCollection.NativeFieldInfoPtr_WorldZoneIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, nameof (WorldZoneIds));
      WorldZoneCollection.NativeFieldInfoPtr_TerrainChunkMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, nameof (TerrainChunkMetadatas));
      WorldZoneCollection.NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollection_WorldZoneCollectionQueries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, 100682348);
      WorldZoneCollection.NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollection_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, 100682349);
      WorldZoneCollection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, 100682350);
      WorldZoneCollection.NativeMethodInfoPtr_TryFindZoneForPosition_Public_Boolean_float3_byref_Entity_byref_WorldZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, 100682351);
      WorldZoneCollection.NativeMethodInfoPtr_TryFindZoneForWorldZoneId_Public_Boolean_WorldZoneId_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, 100682352);
      WorldZoneCollection.NativeMethodInfoPtr_TryGetUserZoneData_Public_Static_Boolean_WorldZoneId_DynamicBuffer_1_UserMapZoneElement_byref_UserMapZoneElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, 100682353);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldZoneCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
