// Decompiled with JetBrains decompiler
// Type: ProjectM.CurveCollectionSystem
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

#nullable disable
namespace ProjectM
{
  public class CurveCollectionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GuidHashToCurveDataMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterCurveQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurveCollection_Public_get_CurveCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurveData_Public_Boolean_Int32_byref_CurveData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCurve_Public_Single_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    public unsafe CurveCollection CurveCollection
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.NativeMethodInfoPtr_get_CurveCollection_Public_get_CurveCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CurveCollection*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750903, XrefRangeEnd = 750906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetCurveData(int curveGuid, out CurveData curveData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &curveGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.NativeMethodInfoPtr_TryGetCurveData_Public_Boolean_Int32_byref_CurveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750906, XrefRangeEnd = 750912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float EvaluateCurve(int curveGuid, float t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &curveGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.NativeMethodInfoPtr_EvaluateCurve_Public_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750912, XrefRangeEnd = 750915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurveCollectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750915, XrefRangeEnd = 750918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurveCollectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750918, XrefRangeEnd = 750932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurveCollectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CurveCollectionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750932, XrefRangeEnd = 750968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurveCollectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750968, XrefRangeEnd = 750987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 750991, RefRangeEnd = 750992, XrefRangeStart = 750987, XrefRangeEnd = 750991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CurveCollectionSystem()
    {
      Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CurveCollectionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr);
      CurveCollectionSystem.NativeFieldInfoPtr__GuidHashToCurveDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, nameof (_GuidHashToCurveDataMap));
      CurveCollectionSystem.NativeFieldInfoPtr__RegisterCurveQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, nameof (_RegisterCurveQuery));
      CurveCollectionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      CurveCollectionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      CurveCollectionSystem.NativeMethodInfoPtr_get_CurveCollection_Public_get_CurveCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666095);
      CurveCollectionSystem.NativeMethodInfoPtr_TryGetCurveData_Public_Boolean_Int32_byref_CurveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666096);
      CurveCollectionSystem.NativeMethodInfoPtr_EvaluateCurve_Public_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666097);
      CurveCollectionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666098);
      CurveCollectionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666099);
      CurveCollectionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666100);
      CurveCollectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666101);
      CurveCollectionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666102);
      CurveCollectionSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666103);
      CurveCollectionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, 100666104);
    }

    public CurveCollectionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashMap<int, CurveData> _GuidHashToCurveDataMap
    {
      get
      {
        return *(NativeHashMap<int, CurveData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr__GuidHashToCurveDataMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr__GuidHashToCurveDataMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, CurveData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _RegisterCurveQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr__RegisterCurveQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr__RegisterCurveQuery)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurveCollectionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CurveCollectionSystem/<>c__DisplayClass8_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass8_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dataMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_CurveData_0;
      [FieldOffset(0)]
      public NativeHashMap<int, CurveData> dataMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CurveData curveData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_CurveData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass8_0>.NativeClassPtr);
        CurveCollectionSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_dataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (dataMap));
        CurveCollectionSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass8_0>.NativeClassPtr, 100666105);
        CurveCollectionSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_CurveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass8_0>.NativeClassPtr, 100666106);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass8_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CurveCollectionSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dataMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CurveData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CurveCollectionSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<int, CurveData> dataMap;
      [FieldOffset(16)]
      public CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750876, XrefRangeEnd = 750879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CurveData curveData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CurveData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CurveCollectionSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CurveCollectionSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750879, XrefRangeEnd = 750881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 750889, RefRangeEnd = 750890, XrefRangeStart = 750881, XrefRangeEnd = 750889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 750892, RefRangeEnd = 750893, XrefRangeStart = 750890, XrefRangeEnd = 750892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CurveCollectionSystem componentSystem,
        ref CurveCollectionSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CurveCollectionSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750893, XrefRangeEnd = 750897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750897, XrefRangeEnd = 750903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveCollectionSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_dataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (dataMap));
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CurveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666107);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666108);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666109);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666110);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666111);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CurveCollectionSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666112);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666113);
        CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100666114);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_curveData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CurveCollectionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CurveData> forParameter_curveData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 750793, RefRangeEnd = 750794, XrefRangeStart = 750787, XrefRangeEnd = 750793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CurveCollectionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CurveCollectionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 750800, RefRangeEnd = 750801, XrefRangeStart = 750794, XrefRangeEnd = 750800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_curveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_curveData));
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CurveCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666115);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666116);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_curveData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CurveData>.Runtime runtime_curveData;

          static Runtimes()
          {
            Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_curveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_curveData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CurveCollectionSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000A94$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000A94$PostfixBurstDelegate");
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666117);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666118);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666119);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666120);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CurveCollectionSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000A94$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750801, XrefRangeEnd = 750815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750815, XrefRangeEnd = 750833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750833, XrefRangeEnd = 750848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 750875, RefRangeEnd = 750876, XrefRangeStart = 750848, XrefRangeEnd = 750875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000A94$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666121);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666122);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666123);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666124);
          CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666126);
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
            IL2CPP.il2cpp_field_static_get_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CurveCollectionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
