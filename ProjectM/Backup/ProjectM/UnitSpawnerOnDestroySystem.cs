﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitSpawnerOnDestroySystem
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
  public class UnitSpawnerOnDestroySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_UnitSpawnerstation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042499, XrefRangeEnd = 1042507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerOnDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitSpawnerOnDestroySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1042534, RefRangeEnd = 1042536, XrefRangeStart = 1042507, XrefRangeEnd = 1042534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__0_0(Entity entity, [In] ref UnitSpawnerstation station)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref station;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_UnitSpawnerstation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042536, XrefRangeEnd = 1042559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnitSpawnerOnDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042559, XrefRangeEnd = 1042578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UnitSpawnerOnDestroySystem()
    {
      Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnitSpawnerOnDestroySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr);
      UnitSpawnerOnDestroySystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      UnitSpawnerOnDestroySystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      UnitSpawnerOnDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, 100681676);
      UnitSpawnerOnDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, 100681677);
      UnitSpawnerOnDestroySystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_UnitSpawnerstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, 100681678);
      UnitSpawnerOnDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, 100681679);
      UnitSpawnerOnDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, 100681680);
    }

    public UnitSpawnerOnDestroySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UnitSpawnerOnDestroySystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_UnitSpawnerstation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitSpawnerOnDestroySystem_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042479, XrefRangeEnd = 1042481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref UnitSpawnerstation station)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref station;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_UnitSpawnerstation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042481, XrefRangeEnd = 1042492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1042498, RefRangeEnd = 1042499, XrefRangeStart = 1042492, XrefRangeEnd = 1042498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(UnitSpawnerOnDestroySystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitSpawnerOnDestroySystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_UnitSpawnerstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100681681);
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100681683);
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100681684);
        UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitSpawnerOnDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100681685);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe UnitSpawnerOnDestroySystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (UnitSpawnerOnDestroySystem) null : new UnitSpawnerOnDestroySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_station;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitSpawnerOnDestroySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnitSpawnerstation> forParameter_station;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042469, XrefRangeEnd = 1042473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnitSpawnerOnDestroySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitSpawnerOnDestroySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1042478, RefRangeEnd = 1042479, XrefRangeStart = 1042473, XrefRangeEnd = 1042478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_station));
          UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnitSpawnerOnDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100681686);
          UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100681687);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_station;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<UnitSpawnerstation>.StructuralChangeRuntime runtime_station;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_station));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitSpawnerOnDestroySystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
