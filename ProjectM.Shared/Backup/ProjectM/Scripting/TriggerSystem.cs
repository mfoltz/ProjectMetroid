// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.TriggerSystem
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
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Scripting
{
  public class TriggerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScriptMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr__TempColliderHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__TempDistanceHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__TempEntityHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__Result;
    private static readonly System.IntPtr NativeFieldInfoPtr__TriggerData;
    private static readonly System.IntPtr NativeFieldInfoPtr___OverlappingSphere_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OverlappingSphere_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckTriggers_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TriggerData_Public_get_NativeList_1_TriggerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOverlappingSphere_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    public unsafe NativeList<ProjectM.Scripting.TriggerData> TriggerData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerSystem.NativeMethodInfoPtr_get_TriggerData_Public_get_NativeList_1_TriggerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<ProjectM.Scripting.TriggerData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779430, XrefRangeEnd = 779457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TriggerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779457, XrefRangeEnd = 779474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TriggerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779474, XrefRangeEnd = 779540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TriggerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TriggerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TriggerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779540, XrefRangeEnd = 779592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TriggerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779592, XrefRangeEnd = 779611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOverlappingSphere_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerSystem.NativeMethodInfoPtr___GetEntityQuery_ForOverlappingSphere_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 779615, RefRangeEnd = 779616, XrefRangeStart = 779611, XrefRangeEnd = 779615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TriggerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 779620, RefRangeEnd = 779621, XrefRangeStart = 779616, XrefRangeEnd = 779620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TriggerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TriggerSystem()
    {
      Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (TriggerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr);
      TriggerSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_CollisionSystem));
      TriggerSystem.NativeFieldInfoPtr__ScriptMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_ScriptMapper));
      TriggerSystem.NativeFieldInfoPtr__TempColliderHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_TempColliderHits));
      TriggerSystem.NativeFieldInfoPtr__TempDistanceHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_TempDistanceHits));
      TriggerSystem.NativeFieldInfoPtr__TempEntityHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_TempEntityHits));
      TriggerSystem.NativeFieldInfoPtr__AllHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_AllHits));
      TriggerSystem.NativeFieldInfoPtr__Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_Result));
      TriggerSystem.NativeFieldInfoPtr__TriggerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (_TriggerData));
      TriggerSystem.NativeFieldInfoPtr___OverlappingSphere_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, "<>OverlappingSphere_entityQuery");
      TriggerSystem.NativeFieldInfoPtr___OverlappingSphere_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, "<>OverlappingSphere_profilerMarker");
      TriggerSystem.NativeFieldInfoPtr___CheckTriggers_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, "<>CheckTriggers_profilerMarker");
      TriggerSystem.NativeMethodInfoPtr_get_TriggerData_Public_get_NativeList_1_TriggerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668990);
      TriggerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668991);
      TriggerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668992);
      TriggerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668993);
      TriggerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668994);
      TriggerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668995);
      TriggerSystem.NativeMethodInfoPtr___GetEntityQuery_ForOverlappingSphere_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668996);
      TriggerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668997);
      TriggerSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, 100668998);
    }

    public TriggerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerScriptMapper _ScriptMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__ScriptMapper));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper) null : new ServerScriptMapper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__ScriptMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<ColliderCastHit> _TempColliderHits
    {
      get
      {
        return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TempColliderHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TempColliderHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<DistanceHit> _TempDistanceHits
    {
      get
      {
        return *(NativeList<DistanceHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TempDistanceHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TempDistanceHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DistanceHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<HitResult> _TempEntityHits
    {
      get
      {
        return *(NativeList<HitResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TempEntityHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TempEntityHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<HitResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<HitResult> _AllHits
    {
      get
      {
        return *(NativeList<HitResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__AllHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__AllHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<HitResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<TriggerSystem.Result> _Result
    {
      get
      {
        return *(NativeList<TriggerSystem.Result>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__Result));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__Result), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<TriggerSystem.Result>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ProjectM.Scripting.TriggerData> _TriggerData
    {
      get
      {
        return *(NativeList<ProjectM.Scripting.TriggerData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TriggerData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr__TriggerData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ProjectM.Scripting.TriggerData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __OverlappingSphere_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr___OverlappingSphere_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr___OverlappingSphere_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OverlappingSphere_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr___OverlappingSphere_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr___OverlappingSphere_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __CheckTriggers_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr___CheckTriggers_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.NativeFieldInfoPtr___CheckTriggers_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Result
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
      private static readonly System.IntPtr NativeFieldInfoPtr_Start;
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;
      [FieldOffset(0)]
      public Entity CallerEntity;
      [FieldOffset(8)]
      public int FunctionHash;
      [FieldOffset(12)]
      public int Start;
      [FieldOffset(16)]
      public int Count;

      static Result()
      {
        Il2CppClassPointerStore<TriggerSystem.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, nameof (Result));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerSystem.Result>.NativeClassPtr);
        TriggerSystem.Result.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.Result>.NativeClassPtr, nameof (CallerEntity));
        TriggerSystem.Result.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.Result>.NativeClassPtr, nameof (FunctionHash));
        TriggerSystem.Result.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.Result>.NativeClassPtr, nameof (Start));
        TriggerSystem.Result.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.Result>.NativeClassPtr, nameof (Count));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerSystem.Result>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Scripting.TriggerSystem/<>c__DisplayClass13_0")]
    public sealed class __c__DisplayClass13_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempEntitiesHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempDistanceHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_allHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_results;
      private static readonly System.IntPtr NativeFieldInfoPtr_triggerData;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempColliderHits;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Trigger_byref_Trigger_OverlappingSphere_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        [In] ref Trigger data,
        [In] ref Trigger_OverlappingSphere overlappingSphere)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref overlappingSphere;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Trigger_byref_Trigger_OverlappingSphere_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr);
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (getTranslation));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_getRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (getRotation));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempEntitiesHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (tempEntitiesHits));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempDistanceHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (tempDistanceHits));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (collisionWorld));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (entityManager));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_allHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (allHits));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (results));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_triggerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (triggerData));
        TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempColliderHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (tempColliderHits));
        TriggerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, 100668999);
        TriggerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Trigger_byref_Trigger_OverlappingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, 100669000);
        TriggerSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, 100669001);
      }

      public __c__DisplayClass13_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass13_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass13_0>.NativeClassPtr, data));
      }

      public unsafe TriggerSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TriggerSystem) null : new TriggerSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentDataFromEntity<Translation> getTranslation
      {
        get
        {
          return *(ComponentDataFromEntity<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_getTranslation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_getTranslation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Rotation> getRotation
      {
        get
        {
          return *(ComponentDataFromEntity<Rotation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_getRotation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_getRotation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Rotation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<HitResult> tempEntitiesHits
      {
        get
        {
          return *(NativeList<HitResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempEntitiesHits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempEntitiesHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<HitResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<DistanceHit> tempDistanceHits
      {
        get
        {
          return *(NativeList<DistanceHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempDistanceHits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempDistanceHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DistanceHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe NativeList<HitResult> allHits
      {
        get
        {
          return *(NativeList<HitResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_allHits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_allHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<HitResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<TriggerSystem.Result> results
      {
        get
        {
          return *(NativeList<TriggerSystem.Result>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_results));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_results), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<TriggerSystem.Result>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<ProjectM.Scripting.TriggerData> triggerData
      {
        get
        {
          return *(NativeList<ProjectM.Scripting.TriggerData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_triggerData));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_triggerData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ProjectM.Scripting.TriggerData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<ColliderCastHit> tempColliderHits
      {
        get
        {
          return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempColliderHits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_tempColliderHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Scripting.TriggerSystem/ProjectM.Scripting.<>c__DisplayClass_OverlappingSphere")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OverlappingSphere
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempEntitiesHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempDistanceHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_allHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_results;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Trigger_byref_Trigger_OverlappingSphere_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Rotation> getRotation;
      [FieldOffset(64)]
      public NativeList<HitResult> tempEntitiesHits;
      [FieldOffset(80)]
      public NativeList<DistanceHit> tempDistanceHits;
      [FieldOffset(96)]
      public CollisionWorld collisionWorld;
      [FieldOffset(440)]
      public EntityManager entityManager;
      [FieldOffset(448)]
      public NativeList<HitResult> allHits;
      [FieldOffset(464)]
      public NativeList<TriggerSystem.Result> results;
      [FieldOffset(480)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(512)]
      public TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(576)]
      public unsafe TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779182, XrefRangeEnd = 779236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref Trigger data,
        [In] ref Trigger_OverlappingSphere overlappingSphere)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref overlappingSphere;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Trigger_byref_Trigger_OverlappingSphere_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779236, RefRangeEnd = 779237, XrefRangeStart = 779236, XrefRangeEnd = 779236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TriggerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779237, RefRangeEnd = 779238, XrefRangeStart = 779237, XrefRangeEnd = 779237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TriggerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779238, XrefRangeEnd = 779240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779248, RefRangeEnd = 779249, XrefRangeStart = 779240, XrefRangeEnd = 779248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779254, RefRangeEnd = 779255, XrefRangeStart = 779249, XrefRangeEnd = 779254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TriggerSystem componentSystem,
        ref TriggerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779255, XrefRangeEnd = 779259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779259, XrefRangeEnd = 779265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OverlappingSphere()
      {
        Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, "<>c__DisplayClass_OverlappingSphere");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (getTranslation));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_getRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (getRotation));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_tempEntitiesHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (tempEntitiesHits));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_tempDistanceHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (tempDistanceHits));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (collisionWorld));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (entityManager));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_allHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (allHits));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (results));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (_runtimes));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Trigger_byref_Trigger_OverlappingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669002);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669003);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669004);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669005);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669006);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669007);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669008);
        TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, 100669009);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_data;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_overlappingSphere;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Trigger> forParameter_data;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Trigger_OverlappingSphere> forParameter_overlappingSphere;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 779099, RefRangeEnd = 779100, XrefRangeStart = 779093, XrefRangeEnd = 779099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TriggerSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 779106, RefRangeEnd = 779107, XrefRangeStart = 779100, XrefRangeEnd = 779106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_data));
          TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_overlappingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_overlappingSphere));
          TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders>.NativeClassPtr, 100669010);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders>.NativeClassPtr, 100669011);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_data;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_overlappingSphere;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Trigger>.Runtime runtime_data;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Trigger_OverlappingSphere>.Runtime runtime_overlappingSphere;

          static Runtimes()
          {
            Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_data));
            TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_overlappingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_overlappingSphere));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Scripting.TriggerSystem/ProjectM.Scripting.<>c__DisplayClass_OverlappingSphere/ProjectM.Scripting.RunWithoutJobSystem_00001426$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, "RunWithoutJobSystem_00001426$PostfixBurstDelegate");
          TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669012);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669013);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669014);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669015);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Scripting.TriggerSystem/ProjectM.Scripting.<>c__DisplayClass_OverlappingSphere/ProjectM.Scripting.RunWithoutJobSystem_00001426$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779107, XrefRangeEnd = 779121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779121, XrefRangeEnd = 779139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779139, XrefRangeEnd = 779154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 779181, RefRangeEnd = 779182, XrefRangeStart = 779154, XrefRangeEnd = 779181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere>.NativeClassPtr, "RunWithoutJobSystem_00001426$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669016);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669017);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669018);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669019);
          TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669021);
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
            IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_OverlappingSphere.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Scripting.TriggerSystem/ProjectM.Scripting.<>c__DisplayClass_CheckTriggers")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CheckTriggers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_triggerData;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempEntitiesHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempDistanceHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_tempColliderHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_allHits;
      private static readonly System.IntPtr NativeFieldInfoPtr_results;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeList<ProjectM.Scripting.TriggerData> triggerData;
      [FieldOffset(16)]
      public NativeList<HitResult> tempEntitiesHits;
      [FieldOffset(32)]
      public NativeList<DistanceHit> tempDistanceHits;
      [FieldOffset(48)]
      public CollisionWorld collisionWorld;
      [FieldOffset(392)]
      public NativeList<ColliderCastHit> tempColliderHits;
      [FieldOffset(408)]
      public EntityManager entityManager;
      [FieldOffset(416)]
      public NativeList<HitResult> allHits;
      [FieldOffset(432)]
      public NativeList<TriggerSystem.Result> results;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779340, XrefRangeEnd = 779409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779409, RefRangeEnd = 779410, XrefRangeStart = 779409, XrefRangeEnd = 779409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TriggerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779410, RefRangeEnd = 779411, XrefRangeStart = 779410, XrefRangeEnd = 779410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TriggerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779412, RefRangeEnd = 779413, XrefRangeStart = 779411, XrefRangeEnd = 779412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779414, RefRangeEnd = 779415, XrefRangeStart = 779413, XrefRangeEnd = 779414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TriggerSystem componentSystem,
        ref TriggerSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779415, XrefRangeEnd = 779419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 779429, RefRangeEnd = 779430, XrefRangeStart = 779419, XrefRangeEnd = 779429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CheckTriggers()
      {
        Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem>.NativeClassPtr, "<>c__DisplayClass_CheckTriggers");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr);
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_triggerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (triggerData));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_tempEntitiesHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (tempEntitiesHits));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_tempDistanceHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (tempDistanceHits));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (collisionWorld));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_tempColliderHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (tempColliderHits));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (entityManager));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_allHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (allHits));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (results));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, 100669022);
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, 100669023);
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, 100669024);
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, 100669025);
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TriggerSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, 100669026);
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, 100669027);
        TriggerSystem.__c__DisplayClass_CheckTriggers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, 100669028);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_CheckTriggers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Scripting.TriggerSystem/ProjectM.Scripting.<>c__DisplayClass_CheckTriggers/ProjectM.Scripting.RunWithoutJobSystem_0000142E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, "RunWithoutJobSystem_0000142E$PostfixBurstDelegate");
          TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100669029);
          TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100669030);
          TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100669031);
          TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100669032);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Scripting.TriggerSystem/ProjectM.Scripting.<>c__DisplayClass_CheckTriggers/ProjectM.Scripting.RunWithoutJobSystem_0000142E$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779265, XrefRangeEnd = 779279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779279, XrefRangeEnd = 779297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779297, XrefRangeEnd = 779312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 779339, RefRangeEnd = 779340, XrefRangeStart = 779312, XrefRangeEnd = 779339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers>.NativeClassPtr, "RunWithoutJobSystem_0000142E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669033);
          TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669034);
          TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669035);
          TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669036);
          TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669038);
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
            IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TriggerSystem.__c__DisplayClass_CheckTriggers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
