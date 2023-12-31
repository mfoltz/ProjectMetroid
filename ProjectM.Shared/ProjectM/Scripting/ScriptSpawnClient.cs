// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ScriptSpawnClient
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Scripting
{
  public class ScriptSpawnClient : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ScriptMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_0_Private_Void_Entity_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773648, XrefRangeEnd = 773654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptSpawnClient.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773654, XrefRangeEnd = 773674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptSpawnClient.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScriptSpawnClient()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 773676, RefRangeEnd = 773678, XrefRangeStart = 773674, XrefRangeEnd = 773676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__2_0(Entity entity, [In] ref PrefabGUID p)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref p;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.NativeMethodInfoPtr__OnUpdate_b__2_0_Private_Void_Entity_byref_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773678, XrefRangeEnd = 773683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptSpawnClient.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773705, RefRangeEnd = 773706, XrefRangeStart = 773683, XrefRangeEnd = 773705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ScriptSpawnClient()
    {
      Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ScriptSpawnClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr);
      ScriptSpawnClient.NativeFieldInfoPtr__ScriptMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, nameof (_ScriptMapper));
      ScriptSpawnClient.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ScriptSpawnClient.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ScriptSpawnClient.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, 100668551);
      ScriptSpawnClient.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, 100668552);
      ScriptSpawnClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, 100668553);
      ScriptSpawnClient.NativeMethodInfoPtr__OnUpdate_b__2_0_Private_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, 100668554);
      ScriptSpawnClient.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, 100668555);
      ScriptSpawnClient.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, 100668556);
    }

    public ScriptSpawnClient(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClientScriptMapper _ScriptMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.NativeFieldInfoPtr__ScriptMapper));
        return pointer == System.IntPtr.Zero ? (ClientScriptMapper) null : new ClientScriptMapper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.NativeFieldInfoPtr__ScriptMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Scripting.ScriptSpawnClient/ProjectM.Scripting.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ScriptSpawnClient_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773628, XrefRangeEnd = 773630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref PrefabGUID p)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref p;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773630, XrefRangeEnd = 773641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 773647, RefRangeEnd = 773648, XrefRangeStart = 773641, XrefRangeEnd = 773647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ScriptSpawnClient componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ScriptSpawnClient_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptSpawnClient>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668557);
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668559);
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668560);
        ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ScriptSpawnClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668561);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ScriptSpawnClient hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ScriptSpawnClient) null : new ScriptSpawnClient(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_p;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ScriptSpawnClient_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_p;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773618, XrefRangeEnd = 773622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ScriptSpawnClient componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ScriptSpawnClient_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 773627, RefRangeEnd = 773628, XrefRangeStart = 773622, XrefRangeEnd = 773627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_p));
          ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ScriptSpawnClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668562);
          ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668563);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_p;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.StructuralChangeRuntime runtime_p;

          static Runtimes()
          {
            Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_p));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptSpawnClient.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
