// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataSubSceneSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public class GameDataSubSceneSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MainQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneLoadSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneTagQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSectionQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneTagWithSectionQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadGameDataSubSceneAsync_Public_Void_SubScene_LoadToTargetWorld_LoadParameters_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsLoading_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveSceneTagOnGameDataSceneLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 735291, RefRangeEnd = 735295, XrefRangeStart = 735275, XrefRangeEnd = 735291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LoadGameDataSubSceneAsync(
      SubScene subScene,
      LoadToTargetWorld loadToTargetWorld,
      SceneSystem.LoadParameters loadParameters = default (SceneSystem.LoadParameters))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subScene);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadToTargetWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &loadParameters;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.NativeMethodInfoPtr_LoadGameDataSubSceneAsync_Public_Void_SubScene_LoadToTargetWorld_LoadParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735295, XrefRangeEnd = 735296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsLoading()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.NativeMethodInfoPtr_IsLoading_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735296, XrefRangeEnd = 735348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSubSceneSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735348, XrefRangeEnd = 735351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSubSceneSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735351, XrefRangeEnd = 735420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSubSceneSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameDataSubSceneSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735420, XrefRangeEnd = 735425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSubSceneSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 735453, RefRangeEnd = 735454, XrefRangeStart = 735425, XrefRangeEnd = 735453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveSceneTagOnGameDataSceneLoad_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemoveSceneTagOnGameDataSceneLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameDataSubSceneSystem()
    {
      Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataSubSceneSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr);
      GameDataSubSceneSystem.NativeFieldInfoPtr__MainQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, nameof (_MainQuery));
      GameDataSubSceneSystem.NativeFieldInfoPtr__SceneLoadSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, nameof (_SceneLoadSystem));
      GameDataSubSceneSystem.NativeFieldInfoPtr__SceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, nameof (_SceneSystem));
      GameDataSubSceneSystem.NativeFieldInfoPtr__SceneTagQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, nameof (_SceneTagQuery));
      GameDataSubSceneSystem.NativeFieldInfoPtr__SceneSectionQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, nameof (_SceneSectionQuery));
      GameDataSubSceneSystem.NativeFieldInfoPtr__SceneTagWithSectionQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, nameof (_SceneTagWithSectionQuery));
      GameDataSubSceneSystem.NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, "<>RemoveSceneTagOnGameDataSceneLoad_entityQuery");
      GameDataSubSceneSystem.NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, "<>RemoveSceneTagOnGameDataSceneLoad_profilerMarker");
      GameDataSubSceneSystem.NativeMethodInfoPtr_LoadGameDataSubSceneAsync_Public_Void_SubScene_LoadToTargetWorld_LoadParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664917);
      GameDataSubSceneSystem.NativeMethodInfoPtr_IsLoading_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664918);
      GameDataSubSceneSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664919);
      GameDataSubSceneSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664920);
      GameDataSubSceneSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664921);
      GameDataSubSceneSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664922);
      GameDataSubSceneSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664923);
      GameDataSubSceneSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemoveSceneTagOnGameDataSceneLoad_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, 100664924);
    }

    public GameDataSubSceneSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _MainQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__MainQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__MainQuery)) = value;
      }
    }

    public unsafe SceneLoadSystem _SceneLoadSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneLoadSystem));
        return pointer == System.IntPtr.Zero ? (SceneLoadSystem) null : new SceneLoadSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneLoadSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SceneSystem _SceneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneSystem));
        return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SceneTagQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneTagQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneTagQuery)) = value;
      }
    }

    public unsafe EntityQuery _SceneSectionQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneSectionQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneSectionQuery)) = value;
      }
    }

    public unsafe EntityQuery _SceneTagWithSectionQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneTagWithSectionQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr__SceneTagWithSectionQuery)) = value;
      }
    }

    public unsafe EntityQuery __RemoveSceneTagOnGameDataSceneLoad_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveSceneTagOnGameDataSceneLoad_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.NativeFieldInfoPtr___RemoveSceneTagOnGameDataSceneLoad_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HasRemovedSceneTags
    {
      static HasRemovedSceneTags()
      {
        Il2CppClassPointerStore<GameDataSubSceneSystem.HasRemovedSceneTags>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, nameof (HasRemovedSceneTags));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSubSceneSystem.HasRemovedSceneTags>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSubSceneSystem.HasRemovedSceneTags>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSubSceneSystem/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_removeSceneTagFromSections;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ResolvedSectionEntity_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity sceneEntity,
        [In] ref DynamicBuffer<ResolvedSectionEntity> resolvedSectionEntities)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &sceneEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref resolvedSectionEntities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ResolvedSectionEntity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr);
        GameDataSubSceneSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_removeSceneTagFromSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (removeSceneTagFromSections));
        GameDataSubSceneSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        GameDataSubSceneSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664925);
        GameDataSubSceneSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ResolvedSectionEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664926);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass11_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass11_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> removeSceneTagFromSections
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_removeSceneTagFromSections));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_removeSceneTagFromSections), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe GameDataSubSceneSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GameDataSubSceneSystem) null : new GameDataSubSceneSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSubSceneSystem/ProjectM.<>c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad")]
    public sealed class __c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_removeSceneTagFromSections;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ResolvedSectionEntity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSubSceneSystem_byref___c__DisplayClass11_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735225, RefRangeEnd = 735226, XrefRangeStart = 735202, XrefRangeEnd = 735225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity sceneEntity,
        [In] ref DynamicBuffer<ResolvedSectionEntity> resolvedSectionEntities)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &sceneEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref resolvedSectionEntities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ResolvedSectionEntity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735226, XrefRangeEnd = 735227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSubSceneSystem.__c__DisplayClass11_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 735237, RefRangeEnd = 735248, XrefRangeStart = 735227, XrefRangeEnd = 735237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSubSceneSystem.__c__DisplayClass11_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735248, XrefRangeEnd = 735259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735265, RefRangeEnd = 735266, XrefRangeStart = 735259, XrefRangeEnd = 735265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 735267, RefRangeEnd = 735275, XrefRangeStart = 735266, XrefRangeEnd = 735267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSubSceneSystem componentSystem,
        ref GameDataSubSceneSystem.__c__DisplayClass11_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSubSceneSystem_byref___c__DisplayClass11_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad()
      {
        Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSubSceneSystem>.NativeClassPtr, "<>c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr);
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr_removeSceneTagFromSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, nameof (removeSceneTagFromSections));
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, "<>4__this");
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, nameof (_runtimes));
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, nameof (_performLambdaDelegate));
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ResolvedSectionEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, 100664927);
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, 100664928);
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, 100664929);
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, 100664931);
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, 100664932);
        GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSubSceneSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, 100664933);
      }

      public __c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> removeSceneTagFromSections
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr_removeSceneTagFromSections));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr_removeSceneTagFromSections), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe GameDataSubSceneSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GameDataSubSceneSystem) null : new GameDataSubSceneSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sceneEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_resolvedSectionEntities;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSubSceneSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_sceneEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<ResolvedSectionEntity> forParameter_resolvedSectionEntities;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735192, XrefRangeEnd = 735196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSubSceneSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSubSceneSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 735201, RefRangeEnd = 735202, XrefRangeStart = 735196, XrefRangeEnd = 735201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sceneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sceneEntity));
          GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_resolvedSectionEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_resolvedSectionEntities));
          GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSubSceneSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders>.NativeClassPtr, 100664934);
          GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders>.NativeClassPtr, 100664935);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sceneEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_resolvedSectionEntities;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_sceneEntity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_DynamicBuffer<ResolvedSectionEntity>.StructuralChangeRuntime runtime_resolvedSectionEntities;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sceneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sceneEntity));
            GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_resolvedSectionEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_resolvedSectionEntities));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSubSceneSystem.__c__DisplayClass_RemoveSceneTagOnGameDataSceneLoad.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
