// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelToTargetSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Hybrid;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class TravelToTargetSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__BarrierSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr___TravelToTargetJob_entityQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTravelToTargetJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385091, XrefRangeEnd = 1385102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385102, XrefRangeEnd = 1385116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TravelToTargetSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385116, XrefRangeEnd = 1385118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1385143, RefRangeEnd = 1385144, XrefRangeStart = 1385118, XrefRangeEnd = 1385143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTravelToTargetJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.NativeMethodInfoPtr___GetEntityQuery_ForTravelToTargetJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TravelToTargetSystem()
    {
      Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (TravelToTargetSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr);
      TravelToTargetSystem.NativeFieldInfoPtr__BarrierSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, nameof (_BarrierSystem));
      TravelToTargetSystem.NativeFieldInfoPtr__CurveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, nameof (_CurveCollection));
      TravelToTargetSystem.NativeFieldInfoPtr___TravelToTargetJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, "<>TravelToTargetJob_entityQuery");
      TravelToTargetSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, 100665919);
      TravelToTargetSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, 100665920);
      TravelToTargetSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, 100665921);
      TravelToTargetSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, 100665922);
      TravelToTargetSystem.NativeMethodInfoPtr___GetEntityQuery_ForTravelToTargetJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, 100665923);
    }

    public TravelToTargetSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PostUpdateBarrier _BarrierSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.NativeFieldInfoPtr__BarrierSystem));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.NativeFieldInfoPtr__BarrierSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.NativeFieldInfoPtr__CurveCollection));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.NativeFieldInfoPtr__CurveCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __TravelToTargetJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.NativeFieldInfoPtr___TravelToTargetJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.NativeFieldInfoPtr___TravelToTargetJob_entityQuery)) = value;
      }
    }

    [ObfuscatedName("ProjectM.TravelToTargetSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TravelToTarget_byref_LifeTime_byref_Buff_byref_Age_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref TravelToTarget travelToTarget,
        ref LifeTime buffLifeTime,
        [In] ref Buff buff,
        [In] ref Age age)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref travelToTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffLifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TravelToTarget_byref_LifeTime_byref_Buff_byref_Age_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr);
        TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (curveMap));
        TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (isServer));
        TravelToTargetSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr, 100665924);
        TravelToTargetSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TravelToTarget_byref_LifeTime_byref_Buff_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr, 100665925);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe TravelToTargetSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TravelToTargetSystem) null : new TravelToTargetSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CurveCollection curveMap
      {
        get
        {
          return *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_curveMap));
        }
        [param: In] set
        {
          *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_curveMap)) = value;
        }
      }

      public unsafe bool isServer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_isServer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_isServer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.TravelToTargetSystem/ProjectM.<>c__DisplayClass_TravelToTargetJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TravelToTargetJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_curveMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_HybridModelOffset_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TravelToTarget_byref_LifeTime_byref_Buff_byref_Age_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSystem_byref___c__DisplayClass3_0_0;
      [FieldOffset(0)]
      public CurveCollection curveMap;
      [FieldOffset(16)]
      public bool isServer;
      [FieldOffset(24)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(56)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_1;
      [FieldOffset(88)]
      public ComponentDataFromEntity<LastTranslation> _ComponentDataFromEntity_LastTranslation_2;
      [FieldOffset(120)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_3;
      [FieldOffset(152)]
      public ComponentDataFromEntity<HybridModelOffset> _ComponentDataFromEntity_HybridModelOffset_4;
      [FieldOffset(184)]
      public TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(320)]
      public unsafe TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384965, XrefRangeEnd = 1385055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref TravelToTarget travelToTarget,
        ref LifeTime buffLifeTime,
        [In] ref Buff buff,
        [In] ref Age age)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref travelToTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffLifeTime;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TravelToTarget_byref_LifeTime_byref_Buff_byref_Age_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1039428, RefRangeEnd = 1039431, XrefRangeStart = 1039428, XrefRangeEnd = 1039431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TravelToTargetSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385055, XrefRangeEnd = 1385057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1385072, RefRangeEnd = 1385073, XrefRangeStart = 1385057, XrefRangeEnd = 1385072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1385090, RefRangeEnd = 1385091, XrefRangeStart = 1385073, XrefRangeEnd = 1385090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TravelToTargetSystem componentSystem,
        ref TravelToTargetSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TravelToTargetJob()
      {
        Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSystem>.NativeClassPtr, "<>c__DisplayClass_TravelToTargetJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr);
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr_curveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (curveMap));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (isServer));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_1));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_LastTranslation_2));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_3));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr__ComponentDataFromEntity_HybridModelOffset_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_HybridModelOffset_4));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (_runtimes));
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TravelToTarget_byref_LifeTime_byref_Buff_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, 100665926);
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, 100665927);
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, 100665928);
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, 100665929);
        TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, 100665930);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_travelToTarget;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffLifeTime;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_age;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<TravelToTarget> forParameter_travelToTarget;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<LifeTime> forParameter_buffLifeTime;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<Age> forParameter_age;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1384950, RefRangeEnd = 1384951, XrefRangeStart = 1384937, XrefRangeEnd = 1384950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TravelToTargetSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1384964, RefRangeEnd = 1384965, XrefRangeStart = 1384951, XrefRangeEnd = 1384964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_travelToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_travelToTarget));
          TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffLifeTime));
          TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_age));
          TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TravelToTargetSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, 100665931);
          TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, 100665932);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_travelToTarget;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffLifeTime;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_age;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<TravelToTarget>.Runtime runtime_travelToTarget;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<LifeTime>.Runtime runtime_buffLifeTime;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Age>.Runtime runtime_age;

          static Runtimes()
          {
            Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_travelToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_travelToTarget));
            TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffLifeTime));
            TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_age));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelToTargetSystem.__c__DisplayClass_TravelToTargetJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
