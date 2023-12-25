// Decompiled with JetBrains decompiler
// Type: ProjectM.BuildMenuImpairSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

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
  public class BuildMenuImpairSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCloseBuildMenuImpairedSystem_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209464, XrefRangeEnd = 1209470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuImpairSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209470, XrefRangeEnd = 1209483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuImpairSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenuImpairSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209483, XrefRangeEnd = 1209488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenuImpairSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1209510, RefRangeEnd = 1209511, XrefRangeStart = 1209488, XrefRangeEnd = 1209510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCloseBuildMenuImpairedSystem_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.NativeMethodInfoPtr___GetEntityQuery_ForCloseBuildMenuImpairedSystem_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BuildMenuImpairSystem()
    {
      Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (BuildMenuImpairSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr);
      BuildMenuImpairSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      BuildMenuImpairSystem.NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, "<>CloseBuildMenuImpairedSystem_entityQuery");
      BuildMenuImpairSystem.NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, "<>CloseBuildMenuImpairedSystem_profilerMarker");
      BuildMenuImpairSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, 100663617);
      BuildMenuImpairSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, 100663618);
      BuildMenuImpairSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, 100663619);
      BuildMenuImpairSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, 100663620);
      BuildMenuImpairSystem.NativeMethodInfoPtr___GetEntityQuery_ForCloseBuildMenuImpairedSystem_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, 100663621);
    }

    public BuildMenuImpairSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CloseBuildMenuImpairedSystem_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CloseBuildMenuImpairedSystem_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.NativeFieldInfoPtr___CloseBuildMenuImpairedSystem_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.BuildMenuImpairSystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localControlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_clientWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_BuffableFlagState_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref Buff buff,
        [In] ref BuffableFlagState buffableFlagState)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_BuffableFlagState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr);
        BuildMenuImpairSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_localControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (localControlledEntity));
        BuildMenuImpairSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_clientWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (clientWorld));
        BuildMenuImpairSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr, 100663622);
        BuildMenuImpairSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Buff_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr, 100663623);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe Entity localControlledEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_localControlledEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_localControlledEntity)) = value;
        }
      }

      public unsafe World clientWorld
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_clientWorld));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_clientWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.BuildMenuImpairSystem/ProjectM.<>c__DisplayClass_CloseBuildMenuImpairedSystem")]
    public sealed class __c__DisplayClass_CloseBuildMenuImpairedSystem : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localControlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_clientWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuImpairSystem_byref___c__DisplayClass2_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209421, XrefRangeEnd = 1209425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref BuffableFlagState buffableFlagState)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_BuffableFlagState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209425, XrefRangeEnd = 1209426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuildMenuImpairSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1209436, RefRangeEnd = 1209438, XrefRangeStart = 1209426, XrefRangeEnd = 1209436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuildMenuImpairSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209438, XrefRangeEnd = 1209455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1209461, RefRangeEnd = 1209462, XrefRangeStart = 1209455, XrefRangeEnd = 1209461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1209463, RefRangeEnd = 1209464, XrefRangeStart = 1209462, XrefRangeEnd = 1209463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuildMenuImpairSystem componentSystem,
        ref BuildMenuImpairSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuImpairSystem_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CloseBuildMenuImpairedSystem()
      {
        Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuImpairSystem>.NativeClassPtr, "<>c__DisplayClass_CloseBuildMenuImpairedSystem");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr);
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr_localControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, nameof (localControlledEntity));
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr_clientWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, nameof (clientWorld));
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, nameof (_runtimes));
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, nameof (_performLambdaDelegate));
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, 100663624);
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, 100663625);
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, 100663626);
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, 100663628);
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, 100663629);
        BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuImpairSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, 100663630);
      }

      public __c__DisplayClass_CloseBuildMenuImpairedSystem(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_CloseBuildMenuImpairedSystem()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, data));
      }

      public unsafe Entity localControlledEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr_localControlledEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr_localControlledEntity)) = value;
        }
      }

      public unsafe World clientWorld
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr_clientWorld));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr_clientWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffableFlagState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuImpairSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_buffableFlagState;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209405, XrefRangeEnd = 1209412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuildMenuImpairSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuImpairSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1209420, RefRangeEnd = 1209421, XrefRangeStart = 1209412, XrefRangeEnd = 1209420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffableFlagState));
          BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuildMenuImpairSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr, 100663631);
          BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr, 100663632);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffableFlagState;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<Buff>.StructuralChangeRuntime runtime_buff;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.StructuralChangeRuntime runtime_buffableFlagState;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffableFlagState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildMenuImpairSystem.__c__DisplayClass_CloseBuildMenuImpairedSystem.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
