// Decompiled with JetBrains decompiler
// Type: ProjectM.SceneLoadSystem
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
  public class SceneLoadSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitForLoadQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForScenes;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasQueuedRequestThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WaitingForScenes_Public_get_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Entity_SubScene_String_Boolean_LoadToTargetWorld_LoadParameters_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WarmupSceneWithoutLoading_Public_Void_SubScene_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneName_Private_String_Hash128_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WarmupSceneWithoutLoading_Public_Void_Hash128_String_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsLoading_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    public unsafe NativeList<Entity> WaitingForScenes
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr_get_WaitingForScenes_Public_get_NativeList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<Entity>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 735596, RefRangeEnd = 735602, XrefRangeStart = 735524, XrefRangeEnd = 735596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity LoadSceneAsync(
      SubScene subScene,
      string tag,
      bool waitForSceneLoad,
      LoadToTargetWorld loadToTargetWorld,
      SceneSystem.LoadParameters loadParameters = default (SceneSystem.LoadParameters))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subScene);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tag);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &waitForSceneLoad;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &loadToTargetWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &loadParameters;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr_LoadSceneAsync_Public_Entity_SubScene_String_Boolean_LoadToTargetWorld_LoadParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735602, XrefRangeEnd = 735624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WarmupSceneWithoutLoading(
      SubScene subScene,
      string tag,
      bool waitForSceneLoad)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subScene);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tag);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &waitForSceneLoad;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr_WarmupSceneWithoutLoading_Public_Void_SubScene_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735624, XrefRangeEnd = 735630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetSceneName(Hash128 sceneGUID, string tag)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sceneGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tag);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr_GetSceneName_Private_String_Hash128_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735630, XrefRangeEnd = 735648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WarmupSceneWithoutLoading(
      Hash128 sceneGUID,
      string tag,
      bool waitForSceneLoad)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &sceneGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(tag);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &waitForSceneLoad;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr_WarmupSceneWithoutLoading_Public_Void_Hash128_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 735649, RefRangeEnd = 735650, XrefRangeStart = 735648, XrefRangeEnd = 735649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsLoading()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr_IsLoading_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735650, XrefRangeEnd = 735658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneLoadSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735658, XrefRangeEnd = 735661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneLoadSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735661, XrefRangeEnd = 735704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SceneLoadSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735704, XrefRangeEnd = 735733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735733, XrefRangeEnd = 735749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SceneLoadSystem()
    {
      Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SceneLoadSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr);
      SceneLoadSystem.NativeFieldInfoPtr__SceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, nameof (_SceneSystem));
      SceneLoadSystem.NativeFieldInfoPtr__WaitForLoadQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, nameof (_WaitForLoadQuery));
      SceneLoadSystem.NativeFieldInfoPtr__WaitingForScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, nameof (_WaitingForScenes));
      SceneLoadSystem.NativeFieldInfoPtr__HasQueuedRequestThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, nameof (_HasQueuedRequestThisFrame));
      SceneLoadSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      SceneLoadSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      SceneLoadSystem.NativeMethodInfoPtr_get_WaitingForScenes_Public_get_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664939);
      SceneLoadSystem.NativeMethodInfoPtr_LoadSceneAsync_Public_Entity_SubScene_String_Boolean_LoadToTargetWorld_LoadParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664940);
      SceneLoadSystem.NativeMethodInfoPtr_WarmupSceneWithoutLoading_Public_Void_SubScene_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664941);
      SceneLoadSystem.NativeMethodInfoPtr_GetSceneName_Private_String_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664942);
      SceneLoadSystem.NativeMethodInfoPtr_WarmupSceneWithoutLoading_Public_Void_Hash128_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664943);
      SceneLoadSystem.NativeMethodInfoPtr_IsLoading_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664944);
      SceneLoadSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664945);
      SceneLoadSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664946);
      SceneLoadSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664947);
      SceneLoadSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664948);
      SceneLoadSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664949);
      SceneLoadSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, 100664950);
    }

    public SceneLoadSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SceneSystem _SceneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__SceneSystem));
        return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__SceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _WaitForLoadQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__WaitForLoadQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__WaitForLoadQuery)) = value;
      }
    }

    public unsafe NativeList<Entity> _WaitingForScenes
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__WaitingForScenes));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__WaitingForScenes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _HasQueuedRequestThisFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__HasQueuedRequestThisFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr__HasQueuedRequestThisFrame)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WaitForTargetSceneLoad
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SceneEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_OnlyLoadMetadata;
      [FieldOffset(0)]
      public Entity SceneEntity;
      [FieldOffset(8)]
      public bool OnlyLoadMetadata;

      static WaitForTargetSceneLoad()
      {
        Il2CppClassPointerStore<SceneLoadSystem.WaitForTargetSceneLoad>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, nameof (WaitForTargetSceneLoad));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneLoadSystem.WaitForTargetSceneLoad>.NativeClassPtr);
        SceneLoadSystem.WaitForTargetSceneLoad.NativeFieldInfoPtr_SceneEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.WaitForTargetSceneLoad>.NativeClassPtr, nameof (SceneEntity));
        SceneLoadSystem.WaitForTargetSceneLoad.NativeFieldInfoPtr_OnlyLoadMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.WaitForTargetSceneLoad>.NativeClassPtr, nameof (OnlyLoadMetadata));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneLoadSystem.WaitForTargetSceneLoad>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SceneLoadSystem/<>c__DisplayClass14_0")]
    public sealed class __c__DisplayClass14_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldName;
      private static readonly System.IntPtr NativeFieldInfoPtr_doneSceneLoads_Trackers;
      private static readonly System.IntPtr NativeFieldInfoPtr_doneSceneLoads_Scenes;
      private static readonly System.IntPtr NativeFieldInfoPtr_sceneSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_WaitForTargetSceneLoad_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass14_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref SceneLoadSystem.WaitForTargetSceneLoad waitForSceneLoad)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref waitForSceneLoad;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_WaitForTargetSceneLoad_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass14_0()
      {
        Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, "<>c__DisplayClass14_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr);
        SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
        SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_worldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (worldName));
        SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_doneSceneLoads_Trackers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (doneSceneLoads_Trackers));
        SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_doneSceneLoads_Scenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (doneSceneLoads_Scenes));
        SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_sceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, nameof (sceneSystem));
        SceneLoadSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, 100664951);
        SceneLoadSystem.__c__DisplayClass14_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_WaitForTargetSceneLoad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, 100664952);
      }

      public __c__DisplayClass14_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass14_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass14_0>.NativeClassPtr, data));
      }

      public unsafe SceneLoadSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SceneLoadSystem) null : new SceneLoadSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string worldName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_worldName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_worldName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe NativeList<Entity> doneSceneLoads_Trackers
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_doneSceneLoads_Trackers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_doneSceneLoads_Trackers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> doneSceneLoads_Scenes
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_doneSceneLoads_Scenes));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_doneSceneLoads_Scenes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SceneSystem sceneSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_sceneSystem));
          return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass14_0.NativeFieldInfoPtr_sceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.SceneLoadSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_worldName;
      private static readonly System.IntPtr NativeFieldInfoPtr_doneSceneLoads_Trackers;
      private static readonly System.IntPtr NativeFieldInfoPtr_doneSceneLoads_Scenes;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_sceneSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_RequestSceneLoaded_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_WaitingForSceneLoad_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WaitForTargetSceneLoad_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SceneLoadSystem_byref___c__DisplayClass14_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735491, RefRangeEnd = 735492, XrefRangeStart = 735479, XrefRangeEnd = 735491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SceneLoadSystem.WaitForTargetSceneLoad waitForSceneLoad)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref waitForSceneLoad;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WaitForTargetSceneLoad_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735495, RefRangeEnd = 735496, XrefRangeStart = 735492, XrefRangeEnd = 735495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SceneLoadSystem.__c__DisplayClass14_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735499, RefRangeEnd = 735500, XrefRangeStart = 735496, XrefRangeEnd = 735499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SceneLoadSystem.__c__DisplayClass14_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735500, XrefRangeEnd = 735502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735508, RefRangeEnd = 735509, XrefRangeStart = 735502, XrefRangeEnd = 735508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 735517, RefRangeEnd = 735518, XrefRangeStart = 735509, XrefRangeEnd = 735517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SceneLoadSystem componentSystem,
        ref SceneLoadSystem.__c__DisplayClass14_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SceneLoadSystem_byref___c__DisplayClass14_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 735518, XrefRangeEnd = 735524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneLoadSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_worldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (worldName));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_doneSceneLoads_Trackers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (doneSceneLoads_Trackers));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_doneSceneLoads_Scenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (doneSceneLoads_Scenes));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_sceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (sceneSystem));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_RequestSceneLoaded_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_RequestSceneLoaded_0));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_WaitingForSceneLoad_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_WaitingForSceneLoad_1));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WaitForTargetSceneLoad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664953);
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664954);
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664955);
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664956);
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664957);
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SceneLoadSystem_byref___c__DisplayClass14_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664958);
        SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664959);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe string worldName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_worldName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_worldName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe NativeList<Entity> doneSceneLoads_Trackers
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_doneSceneLoads_Trackers));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_doneSceneLoads_Trackers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> doneSceneLoads_Scenes
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_doneSceneLoads_Scenes));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_doneSceneLoads_Scenes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SceneLoadSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SceneLoadSystem) null : new SceneLoadSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SceneSystem sceneSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_sceneSystem));
          return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_sceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentDataFromEntity<RequestSceneLoaded> _ComponentDataFromEntity_RequestSceneLoaded_0
      {
        get
        {
          return *(ComponentDataFromEntity<RequestSceneLoaded>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_RequestSceneLoaded_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_RequestSceneLoaded_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<RequestSceneLoaded>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<WaitingForSceneLoad> _ComponentDataFromEntity_WaitingForSceneLoad_1
      {
        get
        {
          return *(ComponentDataFromEntity<WaitingForSceneLoad>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_WaitingForSceneLoad_1));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_WaitingForSceneLoad_1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<WaitingForSceneLoad>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_waitForSceneLoad;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SceneLoadSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SceneLoadSystem.WaitForTargetSceneLoad> forParameter_waitForSceneLoad;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 735473, RefRangeEnd = 735474, XrefRangeStart = 735469, XrefRangeEnd = 735473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SceneLoadSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SceneLoadSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 735478, RefRangeEnd = 735479, XrefRangeStart = 735474, XrefRangeEnd = 735478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_waitForSceneLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_waitForSceneLoad));
          SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SceneLoadSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664960);
          SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664961);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_waitForSceneLoad;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SceneLoadSystem.WaitForTargetSceneLoad>.Runtime runtime_waitForSceneLoad;

          static Runtimes()
          {
            Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_waitForSceneLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_waitForSceneLoad));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneLoadSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
