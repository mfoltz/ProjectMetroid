// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.UpdateSpiderLegsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Hybrid
{
  public class UpdateSpiderLegsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSpiderLegs_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSpiderLegs_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156815, XrefRangeEnd = 1156821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateSpiderLegsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156821, XrefRangeEnd = 1156844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateSpiderLegsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateSpiderLegsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156844, XrefRangeEnd = 1156880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateSpiderLegsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156880, XrefRangeEnd = 1156899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSpiderLegs_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156903, RefRangeEnd = 1156904, XrefRangeStart = 1156899, XrefRangeEnd = 1156903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateSpiderLegsSystem()
    {
      Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (UpdateSpiderLegsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr);
      UpdateSpiderLegsSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      UpdateSpiderLegsSystem.NativeFieldInfoPtr___UpdateSpiderLegs_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, "<>UpdateSpiderLegs_entityQuery");
      UpdateSpiderLegsSystem.NativeFieldInfoPtr___UpdateSpiderLegs_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, "<>UpdateSpiderLegs_profilerMarker");
      UpdateSpiderLegsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, 100692064);
      UpdateSpiderLegsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, 100692065);
      UpdateSpiderLegsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, 100692066);
      UpdateSpiderLegsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, 100692067);
      UpdateSpiderLegsSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpiderLegs_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, 100692068);
      UpdateSpiderLegsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, 100692069);
    }

    public UpdateSpiderLegsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __UpdateSpiderLegs_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.NativeFieldInfoPtr___UpdateSpiderLegs_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.NativeFieldInfoPtr___UpdateSpiderLegs_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSpiderLegs_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.NativeFieldInfoPtr___UpdateSpiderLegs_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.NativeFieldInfoPtr___UpdateSpiderLegs_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.UpdateSpiderLegsSystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<SpiderLeg> legs,
        ref SpiderLegsDriver driver)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref legs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref driver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr);
        UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (deltaTime));
        UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (tileWorld));
        UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (curveCollection));
        UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, 100692070);
        UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, 100692071);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe UpdateSpiderLegsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UpdateSpiderLegsSystem) null : new UpdateSpiderLegsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe TileWorld tileWorld
      {
        get
        {
          return *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_tileWorld));
        }
        [param: In] set
        {
          *(TileWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_tileWorld)) = value;
        }
      }

      public unsafe CurveCollection curveCollection
      {
        get
        {
          return *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_curveCollection));
        }
        [param: In] set
        {
          *(CurveCollection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSpiderLegsSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_curveCollection)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.UpdateSpiderLegsSystem/ProjectM.Hybrid.<>c__DisplayClass_UpdateSpiderLegs")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSpiderLegs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_curveCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_HybridModel_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_LegDirection_Shared_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Velocity_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSpiderLegsSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float deltaTime;
      [FieldOffset(8)]
      public TileWorld tileWorld;
      [FieldOffset(32)]
      public CurveCollection curveCollection;
      [FieldOffset(48)]
      public ComponentDataFromEntity<HybridModel> _ComponentDataFromEntity_HybridModel_0;
      [FieldOffset(80)]
      public ComponentDataFromEntity<LegDirection_Shared> _ComponentDataFromEntity_LegDirection_Shared_1;
      [FieldOffset(112)]
      public ComponentDataFromEntity<Velocity> _ComponentDataFromEntity_Velocity_2;
      [FieldOffset(144)]
      public UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(224)]
      public unsafe UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156676, XrefRangeEnd = 1156779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<SpiderLeg> legs,
        ref SpiderLegsDriver driver)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref legs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref driver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156779, RefRangeEnd = 1156780, XrefRangeStart = 1156779, XrefRangeEnd = 1156779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UpdateSpiderLegsSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156780, RefRangeEnd = 1156781, XrefRangeStart = 1156780, XrefRangeEnd = 1156780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UpdateSpiderLegsSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156781, XrefRangeEnd = 1156783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156792, RefRangeEnd = 1156793, XrefRangeStart = 1156783, XrefRangeEnd = 1156792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1156804, RefRangeEnd = 1156805, XrefRangeStart = 1156793, XrefRangeEnd = 1156804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UpdateSpiderLegsSystem componentSystem,
        ref UpdateSpiderLegsSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSpiderLegsSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156805, XrefRangeEnd = 1156809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156809, XrefRangeEnd = 1156815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSpiderLegs()
      {
        Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSpiderLegsSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateSpiderLegs");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (deltaTime));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (tileWorld));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_curveCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (curveCollection));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr__ComponentDataFromEntity_HybridModel_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (_ComponentDataFromEntity_HybridModel_0));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr__ComponentDataFromEntity_LegDirection_Shared_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (_ComponentDataFromEntity_LegDirection_Shared_1));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr__ComponentDataFromEntity_Velocity_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (_ComponentDataFromEntity_Velocity_2));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (_runtimes));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_SpiderLeg_byref_SpiderLegsDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692072);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692073);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692074);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692075);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692076);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSpiderLegsSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692077);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692078);
        UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, 100692079);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_legs;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_driver;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSpiderLegsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<SpiderLeg> forParameter_legs;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<SpiderLegsDriver> forParameter_driver;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1156592, RefRangeEnd = 1156593, XrefRangeStart = 1156585, XrefRangeEnd = 1156592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UpdateSpiderLegsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSpiderLegsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1156600, RefRangeEnd = 1156601, XrefRangeStart = 1156593, XrefRangeEnd = 1156600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_legs));
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_driver));
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSpiderLegsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, 100692080);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, 100692081);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_legs;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_driver;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<SpiderLeg>.Runtime runtime_legs;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<SpiderLegsDriver>.Runtime runtime_driver;

          static Runtimes()
          {
            Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_legs));
            UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_driver));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.UpdateSpiderLegsSystem/ProjectM.Hybrid.<>c__DisplayClass_UpdateSpiderLegs/ProjectM.Hybrid.RunWithoutJobSystem_00006349$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, "RunWithoutJobSystem_00006349$PostfixBurstDelegate");
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692082);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692083);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692084);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692085);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.UpdateSpiderLegsSystem/ProjectM.Hybrid.<>c__DisplayClass_UpdateSpiderLegs/ProjectM.Hybrid.RunWithoutJobSystem_00006349$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156601, XrefRangeEnd = 1156615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156615, XrefRangeEnd = 1156633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156633, XrefRangeEnd = 1156648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1156675, RefRangeEnd = 1156676, XrefRangeStart = 1156648, XrefRangeEnd = 1156675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs>.NativeClassPtr, "RunWithoutJobSystem_00006349$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692086);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692087);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692088);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692089);
          UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692091);
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
            IL2CPP.il2cpp_field_static_get_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateSpiderLegsSystem.__c__DisplayClass_UpdateSpiderLegs.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
