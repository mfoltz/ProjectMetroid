// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoofTestSceneBootstrapNew
// Assembly: ProjectM.Roofs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D6B6D22B-4E3A-4809-82A6-CC2DECC85297
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Roofs.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Roofs
{
  public class RoofTestSceneBootstrapNew : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabCollectionPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_TestWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__World;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoofGizmoMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorGizmoMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileCountXZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileCountY;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldData;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlaneHitPoints;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventHistory;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastEventHistory;
    private static readonly System.IntPtr NativeFieldInfoPtr__HoveredPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveLayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_HalfWorldBlockCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_HalfWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_HalfBlock;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntityManager_Private_get_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunLastHistory_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunEvent_Private_Void_BasicBuildEvent_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWorld_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupNewWorld_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockCenterWorldPos_Private_Vector3_int2_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe EntityManager EntityManager
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637049, XrefRangeEnd = 1637051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_get_EntityManager_Private_get_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityManager*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637051, XrefRangeEnd = 1637084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637084, XrefRangeEnd = 1637100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RunLastHistory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_RunLastHistory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1637104, RefRangeEnd = 1637105, XrefRangeStart = 1637100, XrefRangeEnd = 1637104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RunEvent(RoofTestingUtility.BasicBuildEvent buildEvent, bool store = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) buildEvent));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &store;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_RunEvent_Private_Void_BasicBuildEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637105, XrefRangeEnd = 1637108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_DestroyWorld_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1637228, RefRangeEnd = 1637229, XrefRangeStart = 1637108, XrefRangeEnd = 1637228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupNewWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_SetupNewWorld_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637229, XrefRangeEnd = 1637288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1637301, RefRangeEnd = 1637302, XrefRangeStart = 1637288, XrefRangeEnd = 1637301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Vector3 GetBlockCenterWorldPos(int2 blockTile, bool offsetHalfWorld, float y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &blockTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetHalfWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_GetBlockCenterWorldPos_Private_Vector3_int2_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637302, XrefRangeEnd = 1637303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637303, XrefRangeEnd = 1637323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RoofTestSceneBootstrapNew()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoofTestSceneBootstrapNew.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RoofTestSceneBootstrapNew()
    {
      Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Roofs.dll", "ProjectM.Roofs", nameof (RoofTestSceneBootstrapNew));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr);
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_PrefabCollectionPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (PrefabCollectionPath));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TestWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (TestWorld));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_World));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_RoofGizmoMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (RoofGizmoMode));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_FloorGizmoMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (FloorGizmoMode));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TileCountXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (TileCountXZ));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TileCountY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (TileCountY));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__SingletonEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_SingletonEntity));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__WorldData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_WorldData));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__PlaneHitPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_PlaneHitPoints));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__EventHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_EventHistory));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__LastEventHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_LastEventHistory));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__HoveredPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_HoveredPoint));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr__ActiveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (_ActiveLayer));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfWorldBlockCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (HalfWorldBlockCount));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_WorldSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (WorldSize));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_BlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (BlockSize));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (HalfWorld));
      RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (HalfBlock));
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_get_EntityManager_Private_get_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663308);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663309);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_RunLastHistory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663310);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_RunEvent_Private_Void_BasicBuildEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663311);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663312);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_DestroyWorld_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663313);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_SetupNewWorld_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663314);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663315);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663316);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_GetBlockCenterWorldPos_Private_Vector3_int2_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663317);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663318);
      RoofTestSceneBootstrapNew.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, 100663319);
    }

    public RoofTestSceneBootstrapNew(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string PrefabCollectionPath
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_PrefabCollectionPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_PrefabCollectionPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe TestWorld TestWorld
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TestWorld));
        return pointer == System.IntPtr.Zero ? (TestWorld) null : new TestWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TestWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe World _World
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__World));
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__World), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RoofDebugMode RoofGizmoMode
    {
      get
      {
        return *(RoofDebugMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_RoofGizmoMode));
      }
      [param: In] set
      {
        *(RoofDebugMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_RoofGizmoMode)) = value;
      }
    }

    public unsafe RoofTestSceneBootstrapNew.FloorMode FloorGizmoMode
    {
      get
      {
        return *(RoofTestSceneBootstrapNew.FloorMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_FloorGizmoMode));
      }
      [param: In] set
      {
        *(RoofTestSceneBootstrapNew.FloorMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_FloorGizmoMode)) = value;
      }
    }

    public static unsafe int TileCountXZ
    {
      get
      {
        int tileCountXz;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TileCountXZ, (void*) &tileCountXz);
        return tileCountXz;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TileCountXZ, (void*) &value);
      }
    }

    public static unsafe int TileCountY
    {
      get
      {
        int tileCountY;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TileCountY, (void*) &tileCountY);
        return tileCountY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_TileCountY, (void*) &value);
      }
    }

    public unsafe Entity _SingletonEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__SingletonEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__SingletonEntity)) = value;
      }
    }

    public unsafe RoofTestingUtility.WorldData _WorldData
    {
      get
      {
        return *(RoofTestingUtility.WorldData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__WorldData));
      }
      [param: In] set
      {
        *(RoofTestingUtility.WorldData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__WorldData)) = value;
      }
    }

    public unsafe List<RoofTestSceneBootstrapNew.PlaneData> _PlaneHitPoints
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__PlaneHitPoints));
        return pointer == System.IntPtr.Zero ? (List<RoofTestSceneBootstrapNew.PlaneData>) null : new List<RoofTestSceneBootstrapNew.PlaneData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__PlaneHitPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RoofTestingUtility.BasicBuildEvent> _EventHistory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__EventHistory));
        return pointer == System.IntPtr.Zero ? (List<RoofTestingUtility.BasicBuildEvent>) null : new List<RoofTestingUtility.BasicBuildEvent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__EventHistory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RoofTestingUtility.BasicBuildEvent> _LastEventHistory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__LastEventHistory));
        return pointer == System.IntPtr.Zero ? (List<RoofTestingUtility.BasicBuildEvent>) null : new List<RoofTestingUtility.BasicBuildEvent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__LastEventHistory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<Vector3> _HoveredPoint
    {
      get
      {
        return *(Nullable_Unboxed<Vector3>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__HoveredPoint));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__HoveredPoint), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Vector3>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _ActiveLayer
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__ActiveLayer));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.NativeFieldInfoPtr__ActiveLayer)) = value;
      }
    }

    public static unsafe int HalfWorldBlockCount
    {
      get
      {
        int halfWorldBlockCount;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfWorldBlockCount, (void*) &halfWorldBlockCount);
        return halfWorldBlockCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfWorldBlockCount, (void*) &value);
      }
    }

    public static unsafe float WorldSize
    {
      get
      {
        float worldSize;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_WorldSize, (void*) &worldSize);
        return worldSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_WorldSize, (void*) &value);
      }
    }

    public static unsafe float BlockSize
    {
      get
      {
        float blockSize;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_BlockSize, (void*) &blockSize);
        return blockSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_BlockSize, (void*) &value);
      }
    }

    public static unsafe float HalfWorld
    {
      get
      {
        float halfWorld;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfWorld, (void*) &halfWorld);
        return halfWorld;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfWorld, (void*) &value);
      }
    }

    public static unsafe float HalfBlock
    {
      get
      {
        float halfBlock;
        IL2CPP.il2cpp_field_static_get_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfBlock, (void*) &halfBlock);
        return halfBlock;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoofTestSceneBootstrapNew.NativeFieldInfoPtr_HalfBlock, (void*) &value);
      }
    }

    public sealed class PlaneData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HitPoints;
      private static readonly System.IntPtr NativeFieldInfoPtr_HitPointData;

      static PlaneData()
      {
        Il2CppClassPointerStore<RoofTestSceneBootstrapNew.PlaneData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (PlaneData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.PlaneData>.NativeClassPtr);
        RoofTestSceneBootstrapNew.PlaneData.NativeFieldInfoPtr_HitPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.PlaneData>.NativeClassPtr, nameof (HitPoints));
        RoofTestSceneBootstrapNew.PlaneData.NativeFieldInfoPtr_HitPointData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.PlaneData>.NativeClassPtr, nameof (HitPointData));
      }

      public PlaneData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public PlaneData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.PlaneData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.PlaneData>.NativeClassPtr, data));
      }

      public unsafe List<Vector3> HitPoints
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.PlaneData.NativeFieldInfoPtr_HitPoints));
          return pointer == System.IntPtr.Zero ? (List<Vector3>) null : new List<Vector3>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.PlaneData.NativeFieldInfoPtr_HitPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<RoofTestSceneBootstrapNew.HitData> HitPointData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.PlaneData.NativeFieldInfoPtr_HitPointData));
          return pointer == System.IntPtr.Zero ? (List<RoofTestSceneBootstrapNew.HitData>) null : new List<RoofTestSceneBootstrapNew.HitData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoofTestSceneBootstrapNew.PlaneData.NativeFieldInfoPtr_HitPointData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_Floor;
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePos;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorTilePos;
      private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalEdge;
      [FieldOffset(0)]
      public Vector3 Position;
      [FieldOffset(12)]
      public bool Floor;
      [FieldOffset(16)]
      public int3 TilePos;
      [FieldOffset(28)]
      public int3 FloorTilePos;
      [FieldOffset(40)]
      public bool HorizontalEdge;

      static HitData()
      {
        Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoofTestSceneBootstrapNew>.NativeClassPtr, nameof (HitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr);
        RoofTestSceneBootstrapNew.HitData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr, nameof (Position));
        RoofTestSceneBootstrapNew.HitData.NativeFieldInfoPtr_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr, nameof (Floor));
        RoofTestSceneBootstrapNew.HitData.NativeFieldInfoPtr_TilePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr, nameof (TilePos));
        RoofTestSceneBootstrapNew.HitData.NativeFieldInfoPtr_FloorTilePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr, nameof (FloorTilePos));
        RoofTestSceneBootstrapNew.HitData.NativeFieldInfoPtr_HorizontalEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr, nameof (HorizontalEdge));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoofTestSceneBootstrapNew.HitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum FloorMode
    {
      Off,
      DisplayWireframe,
      DisplayFull,
    }
  }
}
