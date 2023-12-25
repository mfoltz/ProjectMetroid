// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroySpawnChainChildrenOnDestroySystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class DestroySpawnChainChildrenOnDestroySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_ActiveChildElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnChain_DestroyChildsOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070913, XrefRangeEnd = 1070921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroySpawnChainChildrenOnDestroySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1070950, RefRangeEnd = 1070952, XrefRangeStart = 1070921, XrefRangeEnd = 1070950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__0_0(
      Entity spawnChain,
      ref SpawnChainData.ActiveChildElement activeElement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spawnChain;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeElement;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_ActiveChildElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070952, XrefRangeEnd = 1070975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070975, XrefRangeEnd = 1070994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnChain_DestroyChildsOnDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnChain_DestroyChildsOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DestroySpawnChainChildrenOnDestroySystem()
    {
      Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DestroySpawnChainChildrenOnDestroySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr);
      DestroySpawnChainChildrenOnDestroySystem.NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, "<>SpawnChain_DestroyChildsOnDestroy_entityQuery");
      DestroySpawnChainChildrenOnDestroySystem.NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, "<>SpawnChain_DestroyChildsOnDestroy_profilerMarker");
      DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, 100684372);
      DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, 100684373);
      DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_ActiveChildElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, 100684374);
      DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, 100684375);
      DestroySpawnChainChildrenOnDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnChain_DestroyChildsOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, 100684376);
    }

    public DestroySpawnChainChildrenOnDestroySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __SpawnChain_DestroyChildsOnDestroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnChain_DestroyChildsOnDestroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.NativeFieldInfoPtr___SpawnChain_DestroyChildsOnDestroy_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.DestroySpawnChainChildrenOnDestroySystem/ProjectM.<>c__DisplayClass_SpawnChain_DestroyChildsOnDestroy")]
    public sealed class __c__DisplayClass_SpawnChain_DestroyChildsOnDestroy : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ActiveChildElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroySpawnChainChildrenOnDestroySystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070890, XrefRangeEnd = 1070892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity spawnChain,
        ref SpawnChainData.ActiveChildElement activeElement)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &spawnChain;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeElement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ActiveChildElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070892, XrefRangeEnd = 1070906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1070912, RefRangeEnd = 1070913, XrefRangeStart = 1070906, XrefRangeEnd = 1070912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DestroySpawnChainChildrenOnDestroySystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroySpawnChainChildrenOnDestroySystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnChain_DestroyChildsOnDestroy()
      {
        Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem>.NativeClassPtr, "<>c__DisplayClass_SpawnChain_DestroyChildsOnDestroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr);
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (hostInstance));
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (_runtimes));
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (_performLambdaDelegate));
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_ActiveChildElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684377);
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684379);
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684380);
        DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroySpawnChainChildrenOnDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684381);
      }

      public __c__DisplayClass_SpawnChain_DestroyChildsOnDestroy(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SpawnChain_DestroyChildsOnDestroy()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, data));
      }

      public unsafe DestroySpawnChainChildrenOnDestroySystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (DestroySpawnChainChildrenOnDestroySystem) null : new DestroySpawnChainChildrenOnDestroySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnChain;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeElement;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroySpawnChainChildrenOnDestroySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_spawnChain;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveChildElement> forParameter_activeElement;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070880, XrefRangeEnd = 1070884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          DestroySpawnChainChildrenOnDestroySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroySpawnChainChildrenOnDestroySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070889, RefRangeEnd = 1070890, XrefRangeStart = 1070884, XrefRangeEnd = 1070889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnChain));
          DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeElement));
          DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroySpawnChainChildrenOnDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100684382);
          DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100684383);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnChain;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeElement;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_spawnChain;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveChildElement>.StructuralChangeRuntime runtime_activeElement;

          static Runtimes()
          {
            Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnChain));
            DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeElement));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroySpawnChainChildrenOnDestroySystem.__c__DisplayClass_SpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
