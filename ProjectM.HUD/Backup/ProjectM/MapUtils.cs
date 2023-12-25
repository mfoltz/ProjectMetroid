// Decompiled with JetBrains decompiler
// Type: ProjectM.MapUtils
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class MapUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnchoredPositionFromWorldPos2d_Public_Static_Vector3_byref_Matrix4x4_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPositionFromAnchoredPosition_Public_Static_Vector3_byref_Matrix4x4_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMatrixGlobalMap_Public_Static_Void_byref_Matrix4x4_Vector2_Single_Single_byref_Matrix4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldRotationToIconRotation_Public_Static_Quaternion_quaternion_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalPlayerData_Public_Static_Boolean_byref_LocalUserData_byref_Entity_byref_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPositionWorldZone_Public_Static_Boolean_EntityManager_NativeHashMap_2_TerrainChunk_Entity_float3_byref_WorldZone_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetZoneActiveMission_Public_Static_Boolean_byref_MapZoneData_DynamicBuffer_1_ActiveServantMission_byref_ActiveServantMission_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1211444, RefRangeEnd = 1211447, XrefRangeStart = 1211443, XrefRangeEnd = 1211444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 GetAnchoredPositionFromWorldPos2d(
      ref Matrix4x4 worldToAnchoredSpace,
      float2 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref worldToAnchoredSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapUtils.NativeMethodInfoPtr_GetAnchoredPositionFromWorldPos2d_Public_Static_Vector3_byref_Matrix4x4_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1211449, RefRangeEnd = 1211450, XrefRangeStart = 1211447, XrefRangeEnd = 1211449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 GetWorldPositionFromAnchoredPosition(
      ref Matrix4x4 worldToAnchoredSpace,
      float2 anchoredPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref worldToAnchoredSpace;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &anchoredPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapUtils.NativeMethodInfoPtr_GetWorldPositionFromAnchoredPosition_Public_Static_Vector3_byref_Matrix4x4_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1211455, RefRangeEnd = 1211457, XrefRangeStart = 1211450, XrefRangeEnd = 1211455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateMatrixGlobalMap(
      [In] ref Matrix4x4 projectionMatrix,
      Vector2 textureSize,
      float mapRotation,
      float zoom,
      out Matrix4x4 worldToAnchoredSpace)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref projectionMatrix;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &textureSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mapRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &zoom;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldToAnchoredSpace;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapUtils.NativeMethodInfoPtr_UpdateMatrixGlobalMap_Public_Static_Void_byref_Matrix4x4_Vector2_Single_Single_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1211463, RefRangeEnd = 1211465, XrefRangeStart = 1211457, XrefRangeEnd = 1211463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Quaternion WorldRotationToIconRotation(
      quaternion rotationInWorld,
      float adjustRotation = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotationInWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &adjustRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapUtils.NativeMethodInfoPtr_WorldRotationToIconRotation_Public_Static_Quaternion_quaternion_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1211468, RefRangeEnd = 1211469, XrefRangeStart = 1211465, XrefRangeEnd = 1211468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetLocalPlayerData(
      ref CommonClientDataSystem.LocalUserData localUserData,
      out Entity localPlayer,
      out Entity localUser,
      out Entity cameraEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref localUserData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localPlayer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref localUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cameraEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapUtils.NativeMethodInfoPtr_TryGetLocalPlayerData_Public_Static_Boolean_byref_LocalUserData_byref_Entity_byref_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1211477, RefRangeEnd = 1211479, XrefRangeStart = 1211469, XrefRangeEnd = 1211477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetPositionWorldZone(
      EntityManager entityManager,
      NativeHashMap<TerrainChunk, Entity> terrainChunkMetadatas,
      float3 position,
      out WorldZone zoneType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunkMetadatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref zoneType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapUtils.NativeMethodInfoPtr_TryGetPositionWorldZone_Public_Static_Boolean_EntityManager_NativeHashMap_2_TerrainChunk_Entity_float3_byref_WorldZone_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1211488, RefRangeEnd = 1211491, XrefRangeStart = 1211479, XrefRangeEnd = 1211488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetZoneActiveMission(
      [In] ref MapZoneData zone,
      DynamicBuffer<ActiveServantMission> activeServantMissions,
      out ActiveServantMission result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref zone;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activeServantMissions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapUtils.NativeMethodInfoPtr_TryGetZoneActiveMission_Public_Static_Boolean_byref_MapZoneData_DynamicBuffer_1_ActiveServantMission_byref_ActiveServantMission_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MapUtils()
    {
      Il2CppClassPointerStore<MapUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (MapUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapUtils>.NativeClassPtr);
      MapUtils.NativeMethodInfoPtr_GetAnchoredPositionFromWorldPos2d_Public_Static_Vector3_byref_Matrix4x4_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtils>.NativeClassPtr, 100663754);
      MapUtils.NativeMethodInfoPtr_GetWorldPositionFromAnchoredPosition_Public_Static_Vector3_byref_Matrix4x4_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtils>.NativeClassPtr, 100663755);
      MapUtils.NativeMethodInfoPtr_UpdateMatrixGlobalMap_Public_Static_Void_byref_Matrix4x4_Vector2_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtils>.NativeClassPtr, 100663756);
      MapUtils.NativeMethodInfoPtr_WorldRotationToIconRotation_Public_Static_Quaternion_quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtils>.NativeClassPtr, 100663757);
      MapUtils.NativeMethodInfoPtr_TryGetLocalPlayerData_Public_Static_Boolean_byref_LocalUserData_byref_Entity_byref_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtils>.NativeClassPtr, 100663758);
      MapUtils.NativeMethodInfoPtr_TryGetPositionWorldZone_Public_Static_Boolean_EntityManager_NativeHashMap_2_TerrainChunk_Entity_float3_byref_WorldZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtils>.NativeClassPtr, 100663759);
      MapUtils.NativeMethodInfoPtr_TryGetZoneActiveMission_Public_Static_Boolean_byref_MapZoneData_DynamicBuffer_1_ActiveServantMission_byref_ActiveServantMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapUtils>.NativeClassPtr, 100663760);
    }

    public MapUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
