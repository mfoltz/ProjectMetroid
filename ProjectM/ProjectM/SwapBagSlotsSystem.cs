// Decompiled with JetBrains decompiler
// Type: ProjectM.SwapBagSlotsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SwapBagSlotsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SwapBagSlotsJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SwapBagSlotsJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSwapBagSlotsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015992, XrefRangeEnd = 1016003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwapBagSlotsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016003, XrefRangeEnd = 1016030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwapBagSlotsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SwapBagSlotsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016030, XrefRangeEnd = 1016053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SwapBagSlotsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016053, XrefRangeEnd = 1016072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSwapBagSlotsJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSwapBagSlotsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SwapBagSlotsSystem()
    {
      Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SwapBagSlotsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr);
      SwapBagSlotsSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, nameof (_EventQuery));
      SwapBagSlotsSystem.NativeFieldInfoPtr___SwapBagSlotsJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, "<>SwapBagSlotsJob_entityQuery");
      SwapBagSlotsSystem.NativeFieldInfoPtr___SwapBagSlotsJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, "<>SwapBagSlotsJob_profilerMarker");
      SwapBagSlotsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, 100679230);
      SwapBagSlotsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, 100679231);
      SwapBagSlotsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, 100679232);
      SwapBagSlotsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, 100679233);
      SwapBagSlotsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSwapBagSlotsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, 100679234);
    }

    public SwapBagSlotsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe EntityQuery __SwapBagSlotsJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.NativeFieldInfoPtr___SwapBagSlotsJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.NativeFieldInfoPtr___SwapBagSlotsJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SwapBagSlotsJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.NativeFieldInfoPtr___SwapBagSlotsJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.NativeFieldInfoPtr___SwapBagSlotsJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SwapBagSlotsSystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledThisFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SwapBagSlotsEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref SwapBagSlotsEvent swapBagSlotsEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref swapBagSlotsEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SwapBagSlotsEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr);
        SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_handledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (handledThisFrame));
        SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (handledEvents));
        SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        SwapBagSlotsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr, 100679235);
        SwapBagSlotsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SwapBagSlotsEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr, 100679236);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledThisFrame
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_handledThisFrame));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_handledThisFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SwapBagSlotsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SwapBagSlotsSystem) null : new SwapBagSlotsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.SwapBagSlotsSystem/ProjectM.<>c__DisplayClass_SwapBagSlotsJob")]
    public sealed class __c__DisplayClass_SwapBagSlotsJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledThisFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SwapBagSlotsEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SwapBagSlotsSystem_byref___c__DisplayClass2_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015956, RefRangeEnd = 1015957, XrefRangeStart = 1015908, XrefRangeEnd = 1015956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SwapBagSlotsEvent swapBagSlotsEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref swapBagSlotsEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SwapBagSlotsEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015957, XrefRangeEnd = 1015958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SwapBagSlotsSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015968, RefRangeEnd = 1015969, XrefRangeStart = 1015958, XrefRangeEnd = 1015968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SwapBagSlotsSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015969, XrefRangeEnd = 1015983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015989, RefRangeEnd = 1015990, XrefRangeStart = 1015983, XrefRangeEnd = 1015989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015991, RefRangeEnd = 1015992, XrefRangeStart = 1015990, XrefRangeEnd = 1015991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SwapBagSlotsSystem componentSystem,
        ref SwapBagSlotsSystem.__c__DisplayClass2_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SwapBagSlotsSystem_byref___c__DisplayClass2_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SwapBagSlotsJob()
      {
        Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwapBagSlotsSystem>.NativeClassPtr, "<>c__DisplayClass_SwapBagSlotsJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr);
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr_handledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, nameof (handledThisFrame));
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, nameof (handledEvents));
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, "<>4__this");
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, nameof (_runtimes));
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SwapBagSlotsEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, 100679237);
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, 100679238);
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, 100679239);
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, 100679241);
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, 100679242);
        SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SwapBagSlotsSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, 100679243);
      }

      public __c__DisplayClass_SwapBagSlotsJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SwapBagSlotsJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledThisFrame
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr_handledThisFrame));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr_handledThisFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SwapBagSlotsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SwapBagSlotsSystem) null : new SwapBagSlotsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_swapBagSlotsEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SwapBagSlotsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SwapBagSlotsEvent> forParameter_swapBagSlotsEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015892, XrefRangeEnd = 1015899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SwapBagSlotsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SwapBagSlotsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1015907, RefRangeEnd = 1015908, XrefRangeStart = 1015899, XrefRangeEnd = 1015907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_swapBagSlotsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_swapBagSlotsEvent));
          SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SwapBagSlotsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679244);
          SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679245);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_swapBagSlotsEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<SwapBagSlotsEvent>.StructuralChangeRuntime runtime_swapBagSlotsEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_swapBagSlotsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_swapBagSlotsEvent));
            SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwapBagSlotsSystem.__c__DisplayClass_SwapBagSlotsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
