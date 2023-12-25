// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.StoreDestroyedEntitiesSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Network
{
  public class StoreDestroyedEntitiesSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyedEntityPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrevNewDestroyedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UserQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastUpdateFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDestroyedEntities_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateDestroyedEntities_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDestroyPrefab_Private_Entity_NetworkSnapshotType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDestroyPrefabs_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateDestroyedEntities_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1612516, RefRangeEnd = 1612517, XrefRangeStart = 1612456, XrefRangeEnd = 1612516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity CreateDestroyPrefab<TSnapshot>(NetworkSnapshotType snapshotType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &snapshotType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.MethodInfoStoreGeneric_CreateDestroyPrefab_Private_Entity_NetworkSnapshotType_0<TSnapshot>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612517, XrefRangeEnd = 1612547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1614431, RefRangeEnd = 1614432, XrefRangeStart = 1612547, XrefRangeEnd = 1614431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDestroyPrefabs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_CreateDestroyPrefabs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1614432, XrefRangeEnd = 1614446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1614446, XrefRangeEnd = 1614491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1614491, XrefRangeEnd = 1614492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StoreDestroyedEntitiesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1614492, XrefRangeEnd = 1614510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1614535, RefRangeEnd = 1614536, XrefRangeStart = 1614510, XrefRangeEnd = 1614535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateDestroyedEntities_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDestroyedEntities_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1614540, RefRangeEnd = 1614541, XrefRangeStart = 1614536, XrefRangeEnd = 1614540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StoreDestroyedEntitiesSystem()
    {
      Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (StoreDestroyedEntitiesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr);
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyedEntityPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, nameof (_DestroyedEntityPrefabs));
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, nameof (_WorldFrame));
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__PrevNewDestroyedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, nameof (_PrevNewDestroyedQuery));
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, nameof (_DestroyQuery));
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__UserQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, nameof (_UserQuery));
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__LastUpdateFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, nameof (_LastUpdateFrame));
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr___CreateDestroyedEntities_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, "<>CreateDestroyedEntities_entityQuery");
      StoreDestroyedEntitiesSystem.NativeFieldInfoPtr___CreateDestroyedEntities_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, "<>CreateDestroyedEntities_profilerMarker");
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_CreateDestroyPrefab_Private_Entity_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665073);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665074);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_CreateDestroyPrefabs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665075);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665076);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665077);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665078);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665079);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateDestroyedEntities_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665080);
      StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, 100665081);
    }

    public StoreDestroyedEntitiesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashMap<NetworkSnapshotType, Entity> _DestroyedEntityPrefabs
    {
      get
      {
        return *(NativeHashMap<NetworkSnapshotType, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyedEntityPrefabs));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyedEntityPrefabs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkSnapshotType, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _PrevNewDestroyedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__PrevNewDestroyedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__PrevNewDestroyedQuery)) = value;
      }
    }

    public unsafe EntityQuery _DestroyQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyQuery)) = value;
      }
    }

    public unsafe EntityQuery _UserQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__UserQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__UserQuery)) = value;
      }
    }

    public unsafe int _LastUpdateFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__LastUpdateFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr__LastUpdateFrame)) = value;
      }
    }

    public unsafe EntityQuery __CreateDestroyedEntities_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr___CreateDestroyedEntities_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr___CreateDestroyedEntities_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateDestroyedEntities_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr___CreateDestroyedEntities_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.NativeFieldInfoPtr___CreateDestroyedEntities_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Network.StoreDestroyedEntitiesSystem/<>c__DisplayClass10_0")]
    public sealed class __c__DisplayClass10_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyedEntityPrefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempUserList;
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_connectedUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_NetworkSnapshot_byref_NetworkId_byref_PrefabGUID_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref NetworkSnapshot snapshot,
        [In] ref NetworkId networkId,
        [In] ref PrefabGUID prefabGUID)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref snapshot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_NetworkSnapshot_byref_NetworkId_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr);
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_destroyedEntityPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (destroyedEntityPrefabs));
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_tempUserList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (tempUserList));
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_userEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (userEntities));
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_connectedUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (connectedUsers));
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (commandBuffer));
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, 100665082);
        StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_NetworkSnapshot_byref_NetworkId_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, 100665083);
      }

      public __c__DisplayClass10_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass10_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass10_0>.NativeClassPtr, data));
      }

      public unsafe StoreDestroyedEntitiesSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StoreDestroyedEntitiesSystem) null : new StoreDestroyedEntitiesSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<NetworkSnapshotType, Entity> destroyedEntityPrefabs
      {
        get
        {
          return *(NativeHashMap<NetworkSnapshotType, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_destroyedEntityPrefabs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_destroyedEntityPrefabs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkSnapshotType, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> tempUserList
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_tempUserList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_tempUserList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<Entity> userEntities
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_userEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_userEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<ConnectedUser> connectedUsers
      {
        get
        {
          return *(NativeArray<ConnectedUser>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_connectedUsers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_connectedUsers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ConnectedUser>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoreDestroyedEntitiesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Network.StoreDestroyedEntitiesSystem/ProjectM.Network.<>c__DisplayClass_CreateDestroyedEntities")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateDestroyedEntities
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyedEntityPrefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempUserList;
      private static readonly System.IntPtr NativeFieldInfoPtr_userEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_connectedUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_UserEntityNetworkState_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkSnapshot_byref_NetworkId_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StoreDestroyedEntitiesSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<NetworkSnapshotType, Entity> destroyedEntityPrefabs;
      [FieldOffset(16)]
      public NativeList<Entity> tempUserList;
      [FieldOffset(32)]
      public NativeArray<Entity> userEntities;
      [FieldOffset(48)]
      public NativeArray<ConnectedUser> connectedUsers;
      [FieldOffset(64)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(80)]
      public BufferFromEntity<UserEntityNetworkState> _BufferFromEntity_UserEntityNetworkState_0;
      [FieldOffset(120)]
      public StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612387, XrefRangeEnd = 1612423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref NetworkSnapshot snapshot,
        [In] ref NetworkId networkId,
        [In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref snapshot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkSnapshot_byref_NetworkId_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1612423, RefRangeEnd = 1612424, XrefRangeStart = 1612423, XrefRangeEnd = 1612423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StoreDestroyedEntitiesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1612424, RefRangeEnd = 1612425, XrefRangeStart = 1612424, XrefRangeEnd = 1612424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StoreDestroyedEntitiesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612425, XrefRangeEnd = 1612427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1612439, RefRangeEnd = 1612440, XrefRangeStart = 1612427, XrefRangeEnd = 1612439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1612445, RefRangeEnd = 1612446, XrefRangeStart = 1612440, XrefRangeEnd = 1612445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StoreDestroyedEntitiesSystem componentSystem,
        ref StoreDestroyedEntitiesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StoreDestroyedEntitiesSystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612446, XrefRangeEnd = 1612450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612450, XrefRangeEnd = 1612456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateDestroyedEntities()
      {
        Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr, "<>c__DisplayClass_CreateDestroyedEntities");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_destroyedEntityPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (destroyedEntityPrefabs));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_tempUserList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (tempUserList));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_userEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (userEntities));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_connectedUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (connectedUsers));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (commandBuffer));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr__BufferFromEntity_UserEntityNetworkState_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (_BufferFromEntity_UserEntityNetworkState_0));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (_runtimes));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_NetworkSnapshot_byref_NetworkId_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665084);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665085);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665086);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665087);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665088);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StoreDestroyedEntitiesSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665089);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665090);
        StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, 100665091);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_snapshot;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkId;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StoreDestroyedEntitiesSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<NetworkSnapshot> forParameter_snapshot;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<NetworkId> forParameter_networkId;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1612300, RefRangeEnd = 1612301, XrefRangeStart = 1612290, XrefRangeEnd = 1612300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StoreDestroyedEntitiesSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StoreDestroyedEntitiesSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1612311, RefRangeEnd = 1612312, XrefRangeStart = 1612301, XrefRangeEnd = 1612311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_snapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_snapshot));
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkId));
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StoreDestroyedEntitiesSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, 100665092);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, 100665093);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_snapshot;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkId;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<NetworkSnapshot>.Runtime runtime_snapshot;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<NetworkId>.Runtime runtime_networkId;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;

          static Runtimes()
          {
            Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_snapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_snapshot));
            StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkId));
            StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.StoreDestroyedEntitiesSystem/ProjectM.Network.<>c__DisplayClass_CreateDestroyedEntities/ProjectM.Network.RunWithoutJobSystem_000006F5$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, "RunWithoutJobSystem_000006F5$PostfixBurstDelegate");
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665094);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665095);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665096);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665097);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Network.StoreDestroyedEntitiesSystem/ProjectM.Network.<>c__DisplayClass_CreateDestroyedEntities/ProjectM.Network.RunWithoutJobSystem_000006F5$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612312, XrefRangeEnd = 1612326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612326, XrefRangeEnd = 1612344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1612344, XrefRangeEnd = 1612359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1612386, RefRangeEnd = 1612387, XrefRangeStart = 1612359, XrefRangeEnd = 1612386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities>.NativeClassPtr, "RunWithoutJobSystem_000006F5$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665098);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665099);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665100);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665101);
          StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665103);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StoreDestroyedEntitiesSystem.__c__DisplayClass_CreateDestroyedEntities.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_CreateDestroyPrefab_Private_Entity_NetworkSnapshotType_0<TSnapshot>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(StoreDestroyedEntitiesSystem.NativeMethodInfoPtr_CreateDestroyPrefab_Private_Entity_NetworkSnapshotType_0, Il2CppClassPointerStore<StoreDestroyedEntitiesSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSnapshot>.NativeClassPtr))
      }))));
    }
  }
}
