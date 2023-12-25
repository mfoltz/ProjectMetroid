// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.RemovePvPProtectionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Shared.Systems
{
  public class RemovePvPProtectionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovePvPProtectionEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemovePvPProtectionJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemovePvPProtectionJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemovePvPProtectionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119869, XrefRangeEnd = 1119886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemovePvPProtectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemovePvPProtectionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119886, XrefRangeEnd = 1119909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemovePvPProtectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119909, XrefRangeEnd = 1119928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemovePvPProtectionJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemovePvPProtectionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RemovePvPProtectionSystem()
    {
      Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared.Systems", nameof (RemovePvPProtectionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr);
      RemovePvPProtectionSystem.NativeFieldInfoPtr__RemovePvPProtectionEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, nameof (_RemovePvPProtectionEventQuery));
      RemovePvPProtectionSystem.NativeFieldInfoPtr___RemovePvPProtectionJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, "<>RemovePvPProtectionJob_entityQuery");
      RemovePvPProtectionSystem.NativeFieldInfoPtr___RemovePvPProtectionJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, "<>RemovePvPProtectionJob_profilerMarker");
      RemovePvPProtectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, 100688849);
      RemovePvPProtectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, 100688850);
      RemovePvPProtectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, 100688851);
      RemovePvPProtectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForRemovePvPProtectionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, 100688852);
    }

    public RemovePvPProtectionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _RemovePvPProtectionEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.NativeFieldInfoPtr__RemovePvPProtectionEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.NativeFieldInfoPtr__RemovePvPProtectionEventQuery)) = value;
      }
    }

    public unsafe EntityQuery __RemovePvPProtectionJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.NativeFieldInfoPtr___RemovePvPProtectionJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.NativeFieldInfoPtr___RemovePvPProtectionJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemovePvPProtectionJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.NativeFieldInfoPtr___RemovePvPProtectionJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.NativeFieldInfoPtr___RemovePvPProtectionJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.RemovePvPProtectionSystem/<>c__DisplayClass1_0")]
    public sealed class __c__DisplayClass1_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverBootstrapSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RemovePvPProtectionEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref RemovePvPProtectionEvent startCraftEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref startCraftEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RemovePvPProtectionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr);
        RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
        RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_serverBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr, nameof (serverBootstrapSystem));
        RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr, 100688853);
        RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RemovePvPProtectionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr, 100688854);
      }

      public __c__DisplayClass1_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass1_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass1_0>.NativeClassPtr, data));
      }

      public unsafe RemovePvPProtectionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RemovePvPProtectionSystem) null : new RemovePvPProtectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerBootstrapSystem serverBootstrapSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_serverBootstrapSystem));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass1_0.NativeFieldInfoPtr_serverBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.RemovePvPProtectionSystem/ProjectM.Shared.Systems.<>c__DisplayClass_RemovePvPProtectionJob")]
    public sealed class __c__DisplayClass_RemovePvPProtectionJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverBootstrapSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RemovePvPProtectionEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemovePvPProtectionSystem_byref___c__DisplayClass1_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119832, XrefRangeEnd = 1119838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref RemovePvPProtectionEvent startCraftEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref startCraftEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RemovePvPProtectionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 773407, RefRangeEnd = 773412, XrefRangeStart = 773407, XrefRangeEnd = 773412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RemovePvPProtectionSystem.__c__DisplayClass1_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 773414, RefRangeEnd = 773422, XrefRangeStart = 773414, XrefRangeEnd = 773422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RemovePvPProtectionSystem.__c__DisplayClass1_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119838, XrefRangeEnd = 1119857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119863, RefRangeEnd = 1119864, XrefRangeStart = 1119857, XrefRangeEnd = 1119863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1119866, RefRangeEnd = 1119869, XrefRangeStart = 1119864, XrefRangeEnd = 1119866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RemovePvPProtectionSystem componentSystem,
        ref RemovePvPProtectionSystem.__c__DisplayClass1_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemovePvPProtectionSystem_byref___c__DisplayClass1_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemovePvPProtectionJob()
      {
        Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemovePvPProtectionSystem>.NativeClassPtr, "<>c__DisplayClass_RemovePvPProtectionJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr);
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, "<>4__this");
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr_serverBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, nameof (serverBootstrapSystem));
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, nameof (_runtimes));
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RemovePvPProtectionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, 100688855);
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, 100688856);
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, 100688857);
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, 100688859);
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, 100688860);
        RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemovePvPProtectionSystem_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, 100688861);
      }

      public __c__DisplayClass_RemovePvPProtectionJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RemovePvPProtectionJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, data));
      }

      public unsafe RemovePvPProtectionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RemovePvPProtectionSystem) null : new RemovePvPProtectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerBootstrapSystem serverBootstrapSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr_serverBootstrapSystem));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr_serverBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_startCraftEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemovePvPProtectionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<RemovePvPProtectionEvent> forParameter_startCraftEvent;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119816, XrefRangeEnd = 1119823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RemovePvPProtectionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemovePvPProtectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119831, RefRangeEnd = 1119832, XrefRangeStart = 1119823, XrefRangeEnd = 1119831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_startCraftEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_startCraftEvent));
          RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemovePvPProtectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr, 100688862);
          RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr, 100688863);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_startCraftEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(65)]
          public LambdaParameterValueProvider_IComponentData_Tag<RemovePvPProtectionEvent>.StructuralChangeRuntime runtime_startCraftEvent;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_startCraftEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_startCraftEvent));
            RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemovePvPProtectionSystem.__c__DisplayClass_RemovePvPProtectionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
