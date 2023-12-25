// Decompiled with JetBrains decompiler
// Type: ProjectM.GlobalWorldVFXInstanceSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

#nullable disable
namespace ProjectM
{
  public class GlobalWorldVFXInstanceSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldVFXManagerParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__Random;
    private static readonly System.IntPtr NativeFieldInfoPtr__ManagerIndexToNumEntitiesHashMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__ManagerIndexToVFXListIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnEventQueue;
    private static readonly System.IntPtr NativeFieldInfoPtr__BusyManagers;
    private static readonly System.IntPtr NativeFieldInfoPtr__AvailableManagerIndices;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalManagerPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldVFXManagers;
    private static readonly System.IntPtr NativeFieldInfoPtr__ManagedVFXSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr__ManagerEventAttributes;
    private static readonly System.IntPtr NativeFieldInfoPtr__PositionAttribute;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnAttribute;
    private static readonly System.IntPtr NativeFieldInfoPtr__BoundsAttribute;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxSpawnRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxSpawnRangeSq;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateFrequency;
    private static readonly System.IntPtr NativeFieldInfoPtr__FrameRate;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxManagers;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSpawns_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSpawns_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateWorldVFXManagerIndex_Private_Int32_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstFreeIndex_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendSpawnEvent_Private_Void_DynamicWorldVFXSpawnEvent_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalUser_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084334, XrefRangeEnd = 1084466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084466, XrefRangeEnd = 1084479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084479, XrefRangeEnd = 1084516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084534, RefRangeEnd = 1084535, XrefRangeStart = 1084516, XrefRangeEnd = 1084534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSpawns(float elapsedTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &elapsedTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_AddSpawns_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084662, RefRangeEnd = 1084663, XrefRangeStart = 1084535, XrefRangeEnd = 1084662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveSpawns()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_RemoveSpawns_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084740, RefRangeEnd = 1084741, XrefRangeStart = 1084663, XrefRangeEnd = 1084740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetOrCreateWorldVFXManagerIndex(GameObject vfxPrefab)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vfxPrefab);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_GetOrCreateWorldVFXManagerIndex_Private_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084741, XrefRangeEnd = 1084750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetFirstFreeIndex()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_GetFirstFreeIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084777, RefRangeEnd = 1084778, XrefRangeStart = 1084750, XrefRangeEnd = 1084777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendSpawnEvent(DynamicWorldVFXSpawnEvent spawnEvent, float3 playerPos)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spawnEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &playerPos;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_SendSpawnEvent_Private_Void_DynamicWorldVFXSpawnEvent_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084788, RefRangeEnd = 1084789, XrefRangeStart = 1084778, XrefRangeEnd = 1084788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalUser()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GlobalWorldVFXInstanceSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GlobalWorldVFXInstanceSystem()
    {
      Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GlobalWorldVFXInstanceSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr);
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__WorldVFXManagerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_WorldVFXManagerParent));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__AddedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_AddedQuery));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__UpdateQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_UpdateQuery));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__RemovedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_RemovedQuery));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__LocalPlayerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_LocalPlayerQuery));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_ChunkRange));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_Random));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerIndexToNumEntitiesHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_ManagerIndexToNumEntitiesHashMap));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerIndexToVFXListIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_ManagerIndexToVFXListIndex));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__SpawnEventQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_SpawnEventQueue));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__BusyManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_BusyManagers));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__AvailableManagerIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_AvailableManagerIndices));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__OriginalManagerPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_OriginalManagerPrefabs));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__WorldVFXManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_WorldVFXManagers));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagedVFXSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_ManagedVFXSystems));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerEventAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_ManagerEventAttributes));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__PositionAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_PositionAttribute));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__SpawnAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_SpawnAttribute));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__BoundsAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_BoundsAttribute));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxSpawnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_MaxSpawnRange));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxSpawnRangeSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_MaxSpawnRangeSq));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__UpdateFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_UpdateFrequency));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__FrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_FrameRate));
      GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, nameof (_MaxManagers));
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685431);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685432);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685433);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_AddSpawns_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685434);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_RemoveSpawns_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685435);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_GetOrCreateWorldVFXManagerIndex_Private_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685436);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_GetFirstFreeIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685437);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_SendSpawnEvent_Private_Void_DynamicWorldVFXSpawnEvent_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685438);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685439);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685440);
      GlobalWorldVFXInstanceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, 100685442);
    }

    public GlobalWorldVFXInstanceSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject _WorldVFXManagerParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__WorldVFXManagerParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__WorldVFXManagerParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _AddedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__AddedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__AddedQuery)) = value;
      }
    }

    public unsafe EntityQuery _UpdateQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__UpdateQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__UpdateQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__RemovedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__RemovedQuery)) = value;
      }
    }

    public unsafe EntityQuery _LocalPlayerQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__LocalPlayerQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__LocalPlayerQuery)) = value;
      }
    }

    public unsafe ChunkRange _ChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ChunkRange)) = value;
      }
    }

    public unsafe Unity.Mathematics.Random _Random
    {
      get
      {
        return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__Random));
      }
      [param: In] set
      {
        *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__Random)) = value;
      }
    }

    public unsafe NativeHashMap<int, int> _ManagerIndexToNumEntitiesHashMap
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerIndexToNumEntitiesHashMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerIndexToNumEntitiesHashMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<int, int> _ManagerIndexToVFXListIndex
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerIndexToVFXListIndex));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerIndexToVFXListIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<DynamicWorldVFXSpawnEvent> _SpawnEventQueue
    {
      get
      {
        return *(NativeList<DynamicWorldVFXSpawnEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__SpawnEventQueue));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__SpawnEventQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DynamicWorldVFXSpawnEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<int> _BusyManagers
    {
      get
      {
        return *(NativeList<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__BusyManagers));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__BusyManagers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<int> _AvailableManagerIndices
    {
      get
      {
        return *(NativeList<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__AvailableManagerIndices));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__AvailableManagerIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<GameObject> _OriginalManagerPrefabs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__OriginalManagerPrefabs));
        return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__OriginalManagerPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<GameObject> _WorldVFXManagers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__WorldVFXManagers));
        return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__WorldVFXManagers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VisualEffect> _ManagedVFXSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagedVFXSystems));
        return pointer == System.IntPtr.Zero ? (List<VisualEffect>) null : new List<VisualEffect>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagedVFXSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<VFXEventAttribute> _ManagerEventAttributes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerEventAttributes));
        return pointer == System.IntPtr.Zero ? (List<VFXEventAttribute>) null : new List<VFXEventAttribute>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__ManagerEventAttributes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ExposedProperty _PositionAttribute
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__PositionAttribute, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__PositionAttribute, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ExposedProperty _SpawnAttribute
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__SpawnAttribute, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__SpawnAttribute, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ExposedProperty _BoundsAttribute
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__BoundsAttribute, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ExposedProperty) null : new ExposedProperty(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__BoundsAttribute, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe float _MaxSpawnRange
    {
      get
      {
        float maxSpawnRange;
        IL2CPP.il2cpp_field_static_get_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxSpawnRange, (void*) &maxSpawnRange);
        return maxSpawnRange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxSpawnRange, (void*) &value);
      }
    }

    public unsafe float _MaxSpawnRangeSq
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxSpawnRangeSq));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxSpawnRangeSq)) = value;
      }
    }

    public static unsafe float _UpdateFrequency
    {
      get
      {
        float updateFrequency;
        IL2CPP.il2cpp_field_static_get_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__UpdateFrequency, (void*) &updateFrequency);
        return updateFrequency;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__UpdateFrequency, (void*) &value);
      }
    }

    public static unsafe int _FrameRate
    {
      get
      {
        int frameRate;
        IL2CPP.il2cpp_field_static_get_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__FrameRate, (void*) &frameRate);
        return frameRate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__FrameRate, (void*) &value);
      }
    }

    public static unsafe int _MaxManagers
    {
      get
      {
        int maxManagers;
        IL2CPP.il2cpp_field_static_get_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxManagers, (void*) &maxManagers);
        return maxManagers;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GlobalWorldVFXInstanceSystem.NativeFieldInfoPtr__MaxManagers, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.GlobalWorldVFXInstanceSystem/<>c__DisplayClass29_0")]
    public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_vfxPrefab;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetOrCreateWorldVFXManagerIndex_b__0_Internal_Boolean_GameObject_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass29_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084333, XrefRangeEnd = 1084334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _GetOrCreateWorldVFXManagerIndex_b__0(GameObject s)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__GetOrCreateWorldVFXManagerIndex_b__0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass29_0()
      {
        Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem>.NativeClassPtr, "<>c__DisplayClass29_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0>.NativeClassPtr);
        GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_vfxPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0>.NativeClassPtr, nameof (vfxPrefab));
        GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0>.NativeClassPtr, 100685443);
        GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0.NativeMethodInfoPtr__GetOrCreateWorldVFXManagerIndex_b__0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0>.NativeClassPtr, 100685444);
      }

      public __c__DisplayClass29_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GameObject vfxPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_vfxPrefab));
          return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalWorldVFXInstanceSystem.__c__DisplayClass29_0.NativeFieldInfoPtr_vfxPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
