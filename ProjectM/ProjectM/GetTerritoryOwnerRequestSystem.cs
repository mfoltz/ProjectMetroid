// Decompiled with JetBrains decompiler
// Type: ProjectM.GetTerritoryOwnerRequestSystem
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
  public class GetTerritoryOwnerRequestSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleTerritories;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOwnerName_Private_Static_FixedString64_byref_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetTerritoryOwnerRequestJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009114, XrefRangeEnd = 1009120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009120, XrefRangeEnd = 1009171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1009181, RefRangeEnd = 1009182, XrefRangeStart = 1009171, XrefRangeEnd = 1009181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe FixedString64 GetOwnerName(
      [In] ref EntityManager entityManager,
      Entity castleTerritoryEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castleTerritoryEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_GetOwnerName_Private_Static_FixedString64_byref_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FixedString64*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetTerritoryOwnerRequestSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009182, XrefRangeEnd = 1009205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009205, XrefRangeEnd = 1009224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetTerritoryOwnerRequestJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetTerritoryOwnerRequestJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GetTerritoryOwnerRequestSystem()
    {
      Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GetTerritoryOwnerRequestSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr);
      GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr__CastleTerritories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, nameof (_CastleTerritories));
      GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, nameof (_EventQuery));
      GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, "<>GetTerritoryOwnerRequestJob_entityQuery");
      GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, "<>GetTerritoryOwnerRequestJob_profilerMarker");
      GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, 100678432);
      GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, 100678433);
      GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_GetOwnerName_Private_Static_FixedString64_byref_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, 100678434);
      GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, 100678435);
      GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, 100678436);
      GetTerritoryOwnerRequestSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetTerritoryOwnerRequestJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, 100678437);
    }

    public GetTerritoryOwnerRequestSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashMap<int, Entity> _CastleTerritories
    {
      get
      {
        return *(NativeHashMap<int, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr__CastleTerritories));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr__CastleTerritories), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe EntityQuery __GetTerritoryOwnerRequestJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetTerritoryOwnerRequestJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.NativeFieldInfoPtr___GetTerritoryOwnerRequestJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.GetTerritoryOwnerRequestSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castleTerritories;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_GetTerritoryOwnerRequestEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref GetTerritoryOwnerRequestEvent requestEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref requestEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_GetTerritoryOwnerRequestEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_castleTerritories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (castleTerritories));
        GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr, 100678438);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_GetTerritoryOwnerRequestEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr, 100678439);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<int, Entity> castleTerritories
      {
        get
        {
          return *(NativeHashMap<int, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_castleTerritories));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_castleTerritories), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe GetTerritoryOwnerRequestSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GetTerritoryOwnerRequestSystem) null : new GetTerritoryOwnerRequestSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.GetTerritoryOwnerRequestSystem/ProjectM.<>c__DisplayClass_GetTerritoryOwnerRequestJob")]
    public sealed class __c__DisplayClass_GetTerritoryOwnerRequestJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castleTerritories;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_GetTerritoryOwnerRequestEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetTerritoryOwnerRequestSystem_byref___c__DisplayClass3_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009092, RefRangeEnd = 1009093, XrefRangeStart = 1009085, XrefRangeEnd = 1009092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref GetTerritoryOwnerRequestEvent requestEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref requestEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_GetTerritoryOwnerRequestEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 735237, RefRangeEnd = 735248, XrefRangeStart = 735237, XrefRangeEnd = 735248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009093, XrefRangeEnd = 1009107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009113, RefRangeEnd = 1009114, XrefRangeStart = 1009107, XrefRangeEnd = 1009113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 735267, RefRangeEnd = 735275, XrefRangeStart = 735267, XrefRangeEnd = 735275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GetTerritoryOwnerRequestSystem componentSystem,
        ref GetTerritoryOwnerRequestSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetTerritoryOwnerRequestSystem_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetTerritoryOwnerRequestJob()
      {
        Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem>.NativeClassPtr, "<>c__DisplayClass_GetTerritoryOwnerRequestJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr_castleTerritories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, nameof (castleTerritories));
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, "<>4__this");
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, nameof (_runtimes));
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_GetTerritoryOwnerRequestEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, 100678440);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, 100678441);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, 100678442);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, 100678444);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, 100678445);
        GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetTerritoryOwnerRequestSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, 100678446);
      }

      public __c__DisplayClass_GetTerritoryOwnerRequestJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_GetTerritoryOwnerRequestJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<int, Entity> castleTerritories
      {
        get
        {
          return *(NativeHashMap<int, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr_castleTerritories));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr_castleTerritories), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe GetTerritoryOwnerRequestSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GetTerritoryOwnerRequestSystem) null : new GetTerritoryOwnerRequestSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_requestEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetTerritoryOwnerRequestSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<GetTerritoryOwnerRequestEvent> forParameter_requestEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009069, XrefRangeEnd = 1009076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GetTerritoryOwnerRequestSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetTerritoryOwnerRequestSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009084, RefRangeEnd = 1009085, XrefRangeStart = 1009076, XrefRangeEnd = 1009084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_requestEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_requestEvent));
          GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetTerritoryOwnerRequestSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr, 100678447);
          GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr, 100678448);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_requestEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<GetTerritoryOwnerRequestEvent>.StructuralChangeRuntime runtime_requestEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_requestEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_requestEvent));
            GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetTerritoryOwnerRequestSystem.__c__DisplayClass_GetTerritoryOwnerRequestJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
