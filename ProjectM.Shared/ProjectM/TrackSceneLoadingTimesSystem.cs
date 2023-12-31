// Decompiled with JetBrains decompiler
// Type: ProjectM.TrackSceneLoadingTimesSystem
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
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public class TrackSceneLoadingTimesSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr__WasTrackingTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr__SceneSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewLoadRequestsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnloadRequestsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WaitingForLoadRequests;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HumanReadableSize_Private_Static_String_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736587, XrefRangeEnd = 736605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736605, XrefRangeEnd = 736608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736608, XrefRangeEnd = 736728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736736, RefRangeEnd = 736737, XrefRangeStart = 736728, XrefRangeEnd = 736736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string HumanReadableSize(long size)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &size;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_HumanReadableSize_Private_Static_String_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrackSceneLoadingTimesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736737, XrefRangeEnd = 736771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736793, RefRangeEnd = 736794, XrefRangeStart = 736771, XrefRangeEnd = 736793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736816, RefRangeEnd = 736817, XrefRangeStart = 736794, XrefRangeEnd = 736816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736821, RefRangeEnd = 736822, XrefRangeStart = 736817, XrefRangeEnd = 736821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736826, RefRangeEnd = 736827, XrefRangeStart = 736822, XrefRangeEnd = 736826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TrackSceneLoadingTimesSystem()
    {
      Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TrackSceneLoadingTimesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr);
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr_TrackTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (TrackTimes));
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__WasTrackingTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (_WasTrackingTimes));
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__SceneSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (_SceneSystem));
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__NewLoadRequestsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (_NewLoadRequestsQuery));
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__UnloadRequestsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (_UnloadRequestsQuery));
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__WaitingForLoadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (_WaitingForLoadRequests));
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665009);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665010);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665011);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_HumanReadableSize_Private_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665012);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665013);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665014);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665015);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665016);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665017);
      TrackSceneLoadingTimesSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, 100665018);
    }

    public TrackSceneLoadingTimesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool TrackTimes
    {
      get
      {
        bool trackTimes;
        IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr_TrackTimes, (void*) &trackTimes);
        return trackTimes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr_TrackTimes, (void*) &value);
      }
    }

    public unsafe bool _WasTrackingTimes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__WasTrackingTimes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__WasTrackingTimes)) = value;
      }
    }

    public unsafe SceneSystem _SceneSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__SceneSystem));
        return pointer == System.IntPtr.Zero ? (SceneSystem) null : new SceneSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__SceneSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _NewLoadRequestsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__NewLoadRequestsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__NewLoadRequestsQuery)) = value;
      }
    }

    public unsafe EntityQuery _UnloadRequestsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__UnloadRequestsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__UnloadRequestsQuery)) = value;
      }
    }

    public unsafe NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad> _WaitingForLoadRequests
    {
      get
      {
        return *(NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__WaitingForLoadRequests));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr__WaitingForLoadRequests), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TrackedLoad
    {
      static TrackedLoad()
      {
        Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.TrackedLoad>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (TrackedLoad));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.TrackedLoad>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.TrackedLoad>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AwaitedLoad
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSceneSection;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartLoadTimeTicks;
      [FieldOffset(0)]
      public bool IsSceneSection;
      [FieldOffset(4)]
      public Entity Entity;
      [FieldOffset(16)]
      public long StartLoadTimeTicks;

      static AwaitedLoad()
      {
        Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.AwaitedLoad>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, nameof (AwaitedLoad));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.AwaitedLoad>.NativeClassPtr);
        TrackSceneLoadingTimesSystem.AwaitedLoad.NativeFieldInfoPtr_IsSceneSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.AwaitedLoad>.NativeClassPtr, nameof (IsSceneSection));
        TrackSceneLoadingTimesSystem.AwaitedLoad.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.AwaitedLoad>.NativeClassPtr, nameof (Entity));
        TrackSceneLoadingTimesSystem.AwaitedLoad.NativeFieldInfoPtr_StartLoadTimeTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.AwaitedLoad>.NativeClassPtr, nameof (StartLoadTimeTicks));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.AwaitedLoad>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.TrackSceneLoadingTimesSystem/<>c__DisplayClass10_0")]
    public sealed class __c__DisplayClass10_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_waitingList;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TrackedLoad_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RequestSceneLoaded_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref TrackSceneLoadingTimesSystem.TrackedLoad loadRequest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loadRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TrackedLoad_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref RequestSceneLoaded loadRequest)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loadRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RequestSceneLoaded_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr);
        TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_waitingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (waitingList));
        TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (currentTime));
        TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
        TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, 100665019);
        TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_TrackedLoad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, 100665020);
        TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_RequestSceneLoaded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, 100665021);
      }

      public __c__DisplayClass10_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass10_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass10_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad> waitingList
      {
        get
        {
          return *(NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_waitingList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_waitingList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe long currentTime
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_currentTime));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_currentTime)) = value;
        }
      }

      public unsafe TrackSceneLoadingTimesSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TrackSceneLoadingTimesSystem) null : new TrackSceneLoadingTimesSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrackSceneLoadingTimesSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.TrackSceneLoadingTimesSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_waitingList;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TrackedLoad_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad> waitingList;
      [FieldOffset(16)]
      public TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736433, XrefRangeEnd = 736445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref TrackSceneLoadingTimesSystem.TrackedLoad loadRequest)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loadRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TrackedLoad_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736445, XrefRangeEnd = 736447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 736453, RefRangeEnd = 736454, XrefRangeStart = 736447, XrefRangeEnd = 736453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 736456, RefRangeEnd = 736457, XrefRangeStart = 736454, XrefRangeEnd = 736456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TrackSceneLoadingTimesSystem componentSystem,
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736457, XrefRangeEnd = 736461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736461, XrefRangeEnd = 736467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_waitingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (waitingList));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_TrackedLoad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665022);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665023);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665024);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665025);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665026);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665027);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665028);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665029);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loadRequest;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_IComponentData_Tag<TrackSceneLoadingTimesSystem.TrackedLoad> forParameter_loadRequest;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736352, RefRangeEnd = 736353, XrefRangeStart = 736348, XrefRangeEnd = 736352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TrackSceneLoadingTimesSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736357, RefRangeEnd = 736358, XrefRangeStart = 736353, XrefRangeEnd = 736357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loadRequest));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665030);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665031);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loadRequest;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData_Tag<TrackSceneLoadingTimesSystem.TrackedLoad>.Runtime runtime_loadRequest;

          static Runtimes()
          {
            Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loadRequest));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TrackSceneLoadingTimesSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_000006AA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000006AA$PostfixBurstDelegate");
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665032);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665033);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665034);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665035);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TrackSceneLoadingTimesSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_000006AA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736358, XrefRangeEnd = 736372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736372, XrefRangeEnd = 736390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736390, XrefRangeEnd = 736405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736432, RefRangeEnd = 736433, XrefRangeStart = 736405, XrefRangeEnd = 736432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000006AA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665036);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665037);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665038);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665039);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665041);
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
            IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.TrackSceneLoadingTimesSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_waitingList;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SceneSectionData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RequestSceneLoaded_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public long currentTime;
      [FieldOffset(8)]
      public NativeList<TrackSceneLoadingTimesSystem.AwaitedLoad> waitingList;
      [FieldOffset(24)]
      public ComponentDataFromEntity<SceneSectionData> _ComponentDataFromEntity_SceneSectionData_0;
      [FieldOffset(56)]
      public TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736552, XrefRangeEnd = 736558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref RequestSceneLoaded loadRequest)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref loadRequest;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RequestSceneLoaded_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 736558, RefRangeEnd = 736560, XrefRangeStart = 736558, XrefRangeEnd = 736558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 736560, RefRangeEnd = 736562, XrefRangeStart = 736560, XrefRangeEnd = 736560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736562, XrefRangeEnd = 736564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 736570, RefRangeEnd = 736571, XrefRangeStart = 736564, XrefRangeEnd = 736570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 736576, RefRangeEnd = 736577, XrefRangeStart = 736571, XrefRangeEnd = 736576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        TrackSceneLoadingTimesSystem componentSystem,
        ref TrackSceneLoadingTimesSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736577, XrefRangeEnd = 736581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736581, XrefRangeEnd = 736587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (currentTime));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_waitingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (waitingList));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__ComponentDataFromEntity_SceneSectionData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_ComponentDataFromEntity_SceneSectionData_0));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RequestSceneLoaded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665042);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665043);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665044);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665045);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665046);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665047);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665048);
        TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100665049);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_loadRequest;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RequestSceneLoaded> forParameter_loadRequest;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736471, RefRangeEnd = 736472, XrefRangeStart = 736467, XrefRangeEnd = 736471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(TrackSceneLoadingTimesSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736476, RefRangeEnd = 736477, XrefRangeStart = 736472, XrefRangeEnd = 736476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_loadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_loadRequest));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_TrackSceneLoadingTimesSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100665050);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100665051);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_loadRequest;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RequestSceneLoaded>.Runtime runtime_loadRequest;

          static Runtimes()
          {
            Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_loadRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_loadRequest));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.TrackSceneLoadingTimesSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_000006B3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000006B3$PostfixBurstDelegate");
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665052);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665053);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665054);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665055);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.TrackSceneLoadingTimesSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_000006B3$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736477, XrefRangeEnd = 736491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736491, XrefRangeEnd = 736509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736509, XrefRangeEnd = 736524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 736551, RefRangeEnd = 736552, XrefRangeStart = 736524, XrefRangeEnd = 736551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000006B3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665056);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665057);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665058);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665059);
          TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665061);
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
            IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(TrackSceneLoadingTimesSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
