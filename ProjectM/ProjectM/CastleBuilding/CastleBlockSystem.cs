// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBlockSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleBlockSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Floors;
    private static readonly System.IntPtr NativeFieldInfoPtr__Pillars;
    private static readonly System.IntPtr NativeFieldInfoPtr__Walls;
    private static readonly System.IntPtr NativeFieldInfoPtr__FloorQueries;
    private static readonly System.IntPtr NativeFieldInfoPtr__WallQueries;
    private static readonly System.IntPtr NativeFieldInfoPtr__PillarQueries;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FloorBlockCollection_Public_get_CastleFloorBlockCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WallBlockCollection_Public_get_CastleWallBlockCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PillarBlockCollection_Public_get_CastlePillarBlockCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BlockCollection_Public_get_CastleBlockCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeHashMaps_Internal_Void_byref_NativeHashMap_2_CastleBlock_Entity_byref_NativeHashMap_2_CastleWallBlock_Entity_byref_NativeHashMap_2_CastleBlock_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe CastleFloorBlockCollection FloorBlockCollection
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.NativeMethodInfoPtr_get_FloorBlockCollection_Public_get_CastleFloorBlockCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleFloorBlockCollection*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe CastleWallBlockCollection WallBlockCollection
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.NativeMethodInfoPtr_get_WallBlockCollection_Public_get_CastleWallBlockCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleWallBlockCollection*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe CastlePillarBlockCollection PillarBlockCollection
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.NativeMethodInfoPtr_get_PillarBlockCollection_Public_get_CastlePillarBlockCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastlePillarBlockCollection*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe CastleBlockCollection BlockCollection
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 1127015, RefRangeEnd = 1127018, XrefRangeStart = 1127015, XrefRangeEnd = 1127015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.NativeMethodInfoPtr_get_BlockCollection_Public_get_CastleBlockCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlockCollection*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127018, XrefRangeEnd = 1127102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBlockSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127102, XrefRangeEnd = 1127110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBlockSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127110, XrefRangeEnd = 1127116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBlockSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void GetNativeHashMaps(
      out NativeHashMap<CastleBlock, Entity> floors,
      out NativeHashMap<CastleWallBlock, Entity> walls,
      out NativeHashMap<CastleBlock, Entity> pillars)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref floors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref walls;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pillars;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.NativeMethodInfoPtr_GetNativeHashMaps_Internal_Void_byref_NativeHashMap_2_CastleBlock_Entity_byref_NativeHashMap_2_CastleWallBlock_Entity_byref_NativeHashMap_2_CastleBlock_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1127137, RefRangeEnd = 1127141, XrefRangeStart = 1127116, XrefRangeEnd = 1127137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBlock<TBlock>(
      ref NativeHashMap<TBlock, Entity> blocks,
      [In] ref TBlock block,
      [In] ref Entity entity,
      ref ComponentDataFromEntity<PrefabGUID> getPrefabGuid)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) ref blocks;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) block);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref getPrefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.MethodInfoStoreGeneric_SetBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0<TBlock>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TBlock local = ref block;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TBlock>(objectPointer, false, false);
      local = (TBlock) valueGeneric;
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1127174, RefRangeEnd = 1127178, XrefRangeStart = 1127141, XrefRangeEnd = 1127174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearBlock<TBlock>(
      ref NativeHashMap<TBlock, Entity> blocks,
      [In] ref TBlock block,
      [In] ref Entity entity,
      ref ComponentDataFromEntity<PrefabGUID> getPrefabGuid)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) ref blocks;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) block);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref getPrefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.MethodInfoStoreGeneric_ClearBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0<TBlock>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TBlock local = ref block;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TBlock>(objectPointer, false, false);
      local = (TBlock) valueGeneric;
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBlockSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBlockSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBlockSystem()
    {
      Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBlockSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr);
      CastleBlockSystem.NativeFieldInfoPtr__Floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (_Floors));
      CastleBlockSystem.NativeFieldInfoPtr__Pillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (_Pillars));
      CastleBlockSystem.NativeFieldInfoPtr__Walls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (_Walls));
      CastleBlockSystem.NativeFieldInfoPtr__FloorQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (_FloorQueries));
      CastleBlockSystem.NativeFieldInfoPtr__WallQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (_WallQueries));
      CastleBlockSystem.NativeFieldInfoPtr__PillarQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (_PillarQueries));
      CastleBlockSystem.NativeMethodInfoPtr_get_FloorBlockCollection_Public_get_CastleFloorBlockCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689500);
      CastleBlockSystem.NativeMethodInfoPtr_get_WallBlockCollection_Public_get_CastleWallBlockCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689501);
      CastleBlockSystem.NativeMethodInfoPtr_get_PillarBlockCollection_Public_get_CastlePillarBlockCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689502);
      CastleBlockSystem.NativeMethodInfoPtr_get_BlockCollection_Public_get_CastleBlockCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689503);
      CastleBlockSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689504);
      CastleBlockSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689505);
      CastleBlockSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689506);
      CastleBlockSystem.NativeMethodInfoPtr_GetNativeHashMaps_Internal_Void_byref_NativeHashMap_2_CastleBlock_Entity_byref_NativeHashMap_2_CastleWallBlock_Entity_byref_NativeHashMap_2_CastleBlock_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689507);
      CastleBlockSystem.NativeMethodInfoPtr_SetBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689508);
      CastleBlockSystem.NativeMethodInfoPtr_ClearBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689509);
      CastleBlockSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689510);
      CastleBlockSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, 100689511);
    }

    public CastleBlockSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashMap<CastleBlock, Entity> _Floors
    {
      get
      {
        return *(NativeHashMap<CastleBlock, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__Floors));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__Floors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<CastleBlock, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<CastleBlock, Entity> _Pillars
    {
      get
      {
        return *(NativeHashMap<CastleBlock, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__Pillars));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__Pillars), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<CastleBlock, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<CastleWallBlock, Entity> _Walls
    {
      get
      {
        return *(NativeHashMap<CastleWallBlock, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__Walls));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__Walls), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<CastleWallBlock, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CastleBlockSystem.EventQueries _FloorQueries
    {
      get
      {
        return *(CastleBlockSystem.EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__FloorQueries));
      }
      [param: In] set
      {
        *(CastleBlockSystem.EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__FloorQueries)) = value;
      }
    }

    public unsafe CastleBlockSystem.EventQueries _WallQueries
    {
      get
      {
        return *(CastleBlockSystem.EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__WallQueries));
      }
      [param: In] set
      {
        *(CastleBlockSystem.EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__WallQueries)) = value;
      }
    }

    public unsafe CastleBlockSystem.EventQueries _PillarQueries
    {
      get
      {
        return *(CastleBlockSystem.EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__PillarQueries));
      }
      [param: In] set
      {
        *(CastleBlockSystem.EventQueries*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBlockSystem.NativeFieldInfoPtr__PillarQueries)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EventQueries
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedQuery;
      [FieldOffset(0)]
      public EntityQuery AddedQuery;
      [FieldOffset(16)]
      public EntityQuery RemovedQuery;
      [FieldOffset(32)]
      public EntityQuery UpdatedQuery;

      static EventQueries()
      {
        Il2CppClassPointerStore<CastleBlockSystem.EventQueries>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (EventQueries));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.EventQueries>.NativeClassPtr);
        CastleBlockSystem.EventQueries.NativeFieldInfoPtr_AddedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.EventQueries>.NativeClassPtr, nameof (AddedQuery));
        CastleBlockSystem.EventQueries.NativeFieldInfoPtr_RemovedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.EventQueries>.NativeClassPtr, nameof (RemovedQuery));
        CastleBlockSystem.EventQueries.NativeFieldInfoPtr_UpdatedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.EventQueries>.NativeClassPtr, nameof (UpdatedQuery));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.EventQueries>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FloorJobs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Remove;
      private static readonly System.IntPtr NativeFieldInfoPtr__Add;
      private static readonly System.IntPtr NativeFieldInfoPtr__Update;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_FloorJobs_CastleBlockSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0;
      [FieldOffset(0)]
      public CastleBlockSystem.FloorJobs.RemoveJob _Remove;
      [FieldOffset(112)]
      public CastleBlockSystem.FloorJobs.AddJob _Add;
      [FieldOffset(224)]
      public CastleBlockSystem.FloorJobs.UpdateJob _Update;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1126855, RefRangeEnd = 1126856, XrefRangeStart = 1126839, XrefRangeEnd = 1126855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe CastleBlockSystem.FloorJobs Create(CastleBlockSystem system)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.FloorJobs.NativeMethodInfoPtr_Create_Public_Static_FloorJobs_CastleBlockSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlockSystem.FloorJobs*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1126865, RefRangeEnd = 1126866, XrefRangeStart = 1126856, XrefRangeEnd = 1126865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Run([In] ref CastleBlockSystem.EventQueries queries)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref queries;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.FloorJobs.NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FloorJobs()
      {
        Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (FloorJobs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr);
        CastleBlockSystem.FloorJobs.NativeFieldInfoPtr__Remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, nameof (_Remove));
        CastleBlockSystem.FloorJobs.NativeFieldInfoPtr__Add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, nameof (_Add));
        CastleBlockSystem.FloorJobs.NativeFieldInfoPtr__Update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, nameof (_Update));
        CastleBlockSystem.FloorJobs.NativeMethodInfoPtr_Create_Public_Static_FloorJobs_CastleBlockSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, 100689512);
        CastleBlockSystem.FloorJobs.NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, 100689513);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct AddJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_AddedEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Floors;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.AddedEvent> AddedEvent;
        [FieldOffset(64)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(96)]
        public NativeHashMap<CastleBlock, Entity> Floors;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126802, XrefRangeEnd = 1126813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.FloorJobs.AddJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static AddJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, nameof (AddJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr);
          CastleBlockSystem.FloorJobs.AddJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.FloorJobs.AddJob.NativeFieldInfoPtr_AddedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr, nameof (AddedEvent));
          CastleBlockSystem.FloorJobs.AddJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.FloorJobs.AddJob.NativeFieldInfoPtr_Floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr, nameof (Floors));
          CastleBlockSystem.FloorJobs.AddJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr, 100689514);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.AddJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct RemoveJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_RemoveEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Floors;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.RemovedEvent> RemoveEvent;
        [FieldOffset(64)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(96)]
        public NativeHashMap<CastleBlock, Entity> Floors;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126813, XrefRangeEnd = 1126824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.FloorJobs.RemoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static RemoveJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, nameof (RemoveJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr);
          CastleBlockSystem.FloorJobs.RemoveJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.FloorJobs.RemoveJob.NativeFieldInfoPtr_RemoveEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr, nameof (RemoveEvent));
          CastleBlockSystem.FloorJobs.RemoveJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.FloorJobs.RemoveJob.NativeFieldInfoPtr_Floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr, nameof (Floors));
          CastleBlockSystem.FloorJobs.RemoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr, 100689515);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.RemoveJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct UpdateJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEvents;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Floors;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.UpdatedEvent> UpdatedEvents;
        [FieldOffset(64)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(96)]
        public NativeHashMap<CastleBlock, Entity> Floors;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126824, XrefRangeEnd = 1126839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.FloorJobs.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static UpdateJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs>.NativeClassPtr, nameof (UpdateJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr);
          CastleBlockSystem.FloorJobs.UpdateJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.FloorJobs.UpdateJob.NativeFieldInfoPtr_UpdatedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr, nameof (UpdatedEvents));
          CastleBlockSystem.FloorJobs.UpdateJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.FloorJobs.UpdateJob.NativeFieldInfoPtr_Floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr, nameof (Floors));
          CastleBlockSystem.FloorJobs.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr, 100689516);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.FloorJobs.UpdateJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WallJobs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Remove;
      private static readonly System.IntPtr NativeFieldInfoPtr__Add;
      private static readonly System.IntPtr NativeFieldInfoPtr__Update;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_WallJobs_CastleBlockSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0;
      [FieldOffset(0)]
      public CastleBlockSystem.WallJobs.RemoveJob _Remove;
      [FieldOffset(144)]
      public CastleBlockSystem.WallJobs.AddJob _Add;
      [FieldOffset(288)]
      public CastleBlockSystem.WallJobs.UpdateJob _Update;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1126940, RefRangeEnd = 1126941, XrefRangeStart = 1126921, XrefRangeEnd = 1126940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe CastleBlockSystem.WallJobs Create(CastleBlockSystem system)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.WallJobs.NativeMethodInfoPtr_Create_Public_Static_WallJobs_CastleBlockSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlockSystem.WallJobs*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1126950, RefRangeEnd = 1126951, XrefRangeStart = 1126941, XrefRangeEnd = 1126950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Run([In] ref CastleBlockSystem.EventQueries queries)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref queries;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.WallJobs.NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static WallJobs()
      {
        Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (WallJobs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr);
        CastleBlockSystem.WallJobs.NativeFieldInfoPtr__Remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, nameof (_Remove));
        CastleBlockSystem.WallJobs.NativeFieldInfoPtr__Add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, nameof (_Add));
        CastleBlockSystem.WallJobs.NativeFieldInfoPtr__Update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, nameof (_Update));
        CastleBlockSystem.WallJobs.NativeMethodInfoPtr_Create_Public_Static_WallJobs_CastleBlockSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, 100689517);
        CastleBlockSystem.WallJobs.NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, 100689518);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct AddJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_AddedEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Walls;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.AddedEvent> AddedEvent;
        [FieldOffset(64)]
        public ComponentDataFromEntity<TileData> GetTileData;
        [FieldOffset(96)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(128)]
        public NativeHashMap<CastleWallBlock, Entity> Walls;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126866, XrefRangeEnd = 1126883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.WallJobs.AddJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static AddJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, nameof (AddJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr);
          CastleBlockSystem.WallJobs.AddJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.WallJobs.AddJob.NativeFieldInfoPtr_AddedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr, nameof (AddedEvent));
          CastleBlockSystem.WallJobs.AddJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr, nameof (GetTileData));
          CastleBlockSystem.WallJobs.AddJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.WallJobs.AddJob.NativeFieldInfoPtr_Walls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr, nameof (Walls));
          CastleBlockSystem.WallJobs.AddJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr, 100689519);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.AddJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct RemoveJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_RemoveEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Walls;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.RemovedEvent> RemoveEvent;
        [FieldOffset(64)]
        public ComponentDataFromEntity<TileData> GetTileData;
        [FieldOffset(96)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(128)]
        public NativeHashMap<CastleWallBlock, Entity> Walls;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126883, XrefRangeEnd = 1126900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.WallJobs.RemoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static RemoveJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, nameof (RemoveJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr);
          CastleBlockSystem.WallJobs.RemoveJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.WallJobs.RemoveJob.NativeFieldInfoPtr_RemoveEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr, nameof (RemoveEvent));
          CastleBlockSystem.WallJobs.RemoveJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr, nameof (GetTileData));
          CastleBlockSystem.WallJobs.RemoveJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.WallJobs.RemoveJob.NativeFieldInfoPtr_Walls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr, nameof (Walls));
          CastleBlockSystem.WallJobs.RemoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr, 100689520);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.RemoveJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct UpdateJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEvents;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Walls;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.UpdatedEvent> UpdatedEvents;
        [FieldOffset(64)]
        public ComponentDataFromEntity<TileData> GetTileData;
        [FieldOffset(96)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(128)]
        public NativeHashMap<CastleWallBlock, Entity> Walls;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126900, XrefRangeEnd = 1126921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.WallJobs.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static UpdateJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.WallJobs>.NativeClassPtr, nameof (UpdateJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr);
          CastleBlockSystem.WallJobs.UpdateJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.WallJobs.UpdateJob.NativeFieldInfoPtr_UpdatedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr, nameof (UpdatedEvents));
          CastleBlockSystem.WallJobs.UpdateJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr, nameof (GetTileData));
          CastleBlockSystem.WallJobs.UpdateJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.WallJobs.UpdateJob.NativeFieldInfoPtr_Walls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr, nameof (Walls));
          CastleBlockSystem.WallJobs.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr, 100689521);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.WallJobs.UpdateJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PillarJobs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Remove;
      private static readonly System.IntPtr NativeFieldInfoPtr__Add;
      private static readonly System.IntPtr NativeFieldInfoPtr__Update;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PillarJobs_CastleBlockSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0;
      [FieldOffset(0)]
      public CastleBlockSystem.PillarJobs.RemoveJob _Remove;
      [FieldOffset(112)]
      public CastleBlockSystem.PillarJobs.AddJob _Add;
      [FieldOffset(224)]
      public CastleBlockSystem.PillarJobs.UpdateJob _Update;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1127004, RefRangeEnd = 1127005, XrefRangeStart = 1126988, XrefRangeEnd = 1127004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe CastleBlockSystem.PillarJobs Create(CastleBlockSystem system)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.PillarJobs.NativeMethodInfoPtr_Create_Public_Static_PillarJobs_CastleBlockSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlockSystem.PillarJobs*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1127014, RefRangeEnd = 1127015, XrefRangeStart = 1127005, XrefRangeEnd = 1127014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Run([In] ref CastleBlockSystem.EventQueries queries)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref queries;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.PillarJobs.NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PillarJobs()
      {
        Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr, nameof (PillarJobs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr);
        CastleBlockSystem.PillarJobs.NativeFieldInfoPtr__Remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, nameof (_Remove));
        CastleBlockSystem.PillarJobs.NativeFieldInfoPtr__Add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, nameof (_Add));
        CastleBlockSystem.PillarJobs.NativeFieldInfoPtr__Update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, nameof (_Update));
        CastleBlockSystem.PillarJobs.NativeMethodInfoPtr_Create_Public_Static_PillarJobs_CastleBlockSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, 100689522);
        CastleBlockSystem.PillarJobs.NativeMethodInfoPtr_Run_Public_Void_byref_EventQueries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, 100689523);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct AddJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_AddedEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Pillars;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.AddedEvent> AddedEvent;
        [FieldOffset(64)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(96)]
        public NativeHashMap<CastleBlock, Entity> Pillars;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126951, XrefRangeEnd = 1126962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.PillarJobs.AddJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static AddJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, nameof (AddJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr);
          CastleBlockSystem.PillarJobs.AddJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.PillarJobs.AddJob.NativeFieldInfoPtr_AddedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr, nameof (AddedEvent));
          CastleBlockSystem.PillarJobs.AddJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.PillarJobs.AddJob.NativeFieldInfoPtr_Pillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr, nameof (Pillars));
          CastleBlockSystem.PillarJobs.AddJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr, 100689524);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.AddJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct RemoveJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_RemoveEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Pillars;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.RemovedEvent> RemoveEvent;
        [FieldOffset(64)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(96)]
        public NativeHashMap<CastleBlock, Entity> Pillars;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126962, XrefRangeEnd = 1126973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.PillarJobs.RemoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static RemoveJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, nameof (RemoveJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr);
          CastleBlockSystem.PillarJobs.RemoveJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.PillarJobs.RemoveJob.NativeFieldInfoPtr_RemoveEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr, nameof (RemoveEvent));
          CastleBlockSystem.PillarJobs.RemoveJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.PillarJobs.RemoveJob.NativeFieldInfoPtr_Pillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr, nameof (Pillars));
          CastleBlockSystem.PillarJobs.RemoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr, 100689525);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.RemoveJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct UpdateJob
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEvents;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_Pillars;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.EntityEvent> EntityEvent;
        [FieldOffset(32)]
        public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.UpdatedEvent> UpdatedEvents;
        [FieldOffset(64)]
        public ComponentDataFromEntity<PrefabGUID> GetPrefabGuid;
        [FieldOffset(96)]
        public NativeHashMap<CastleBlock, Entity> Pillars;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126973, XrefRangeEnd = 1126988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(CastleBlockSystem.PillarJobs.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static UpdateJob()
        {
          Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs>.NativeClassPtr, nameof (UpdateJob));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr);
          CastleBlockSystem.PillarJobs.UpdateJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr, nameof (EntityEvent));
          CastleBlockSystem.PillarJobs.UpdateJob.NativeFieldInfoPtr_UpdatedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr, nameof (UpdatedEvents));
          CastleBlockSystem.PillarJobs.UpdateJob.NativeFieldInfoPtr_GetPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr, nameof (GetPrefabGuid));
          CastleBlockSystem.PillarJobs.UpdateJob.NativeFieldInfoPtr_Pillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr, nameof (Pillars));
          CastleBlockSystem.PillarJobs.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr, 100689526);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockSystem.PillarJobs.UpdateJob>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_SetBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0<TBlock>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CastleBlockSystem.NativeMethodInfoPtr_SetBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0, Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBlock>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ClearBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0<TBlock>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CastleBlockSystem.NativeMethodInfoPtr_ClearBlock_Private_Static_Void_byref_NativeHashMap_2_TBlock_Entity_byref_TBlock_byref_Entity_byref_ComponentDataFromEntity_1_PrefabGUID_0, Il2CppClassPointerStore<CastleBlockSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBlock>.NativeClassPtr))
      }))));
    }
  }
}
