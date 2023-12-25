// Decompiled with JetBrains decompiler
// Type: ProjectM.AnalyticsReportingSystem_AlwaysUpdate
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

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
  public class AnalyticsReportingSystem_AlwaysUpdate : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ACCUMULATIVE_SEND_FREQUENCY;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastAccumulativeSendTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventHandlersSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_VbloodEngage;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVbloodEngage_Private_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPersistentVbloodEngageString_Public_Static_String_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateVbloodEngage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975311, XrefRangeEnd = 975322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975322, XrefRangeEnd = 975325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975325, XrefRangeEnd = 975338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 975352, RefRangeEnd = 975353, XrefRangeStart = 975338, XrefRangeEnd = 975352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateVbloodEngage(double serverTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_UpdateVbloodEngage_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 975357, RefRangeEnd = 975360, XrefRangeStart = 975353, XrefRangeEnd = 975357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetPersistentVbloodEngageString(PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_GetPersistentVbloodEngageString_Public_Static_String_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnalyticsReportingSystem_AlwaysUpdate()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975360, XrefRangeEnd = 975399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975399, XrefRangeEnd = 975418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateVbloodEngage_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr___GetEntityQuery_ForUpdateVbloodEngage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AnalyticsReportingSystem_AlwaysUpdate()
    {
      Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AnalyticsReportingSystem_AlwaysUpdate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr);
      AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr_ACCUMULATIVE_SEND_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, nameof (ACCUMULATIVE_SEND_FREQUENCY));
      AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__LastAccumulativeSendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, nameof (_LastAccumulativeSendTime));
      AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__EventHandlersSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, nameof (_EventHandlersSystem));
      AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr_VbloodEngage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, nameof (VbloodEngage));
      AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, "<>UpdateVbloodEngage_LambdaJob0_entityQuery");
      AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, "<>UpdateVbloodEngage_LambdaJob0_profilerMarker");
      AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_5));
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675401);
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675402);
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675403);
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_UpdateVbloodEngage_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675404);
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_GetPersistentVbloodEngageString_Public_Static_String_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675405);
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675406);
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675407);
      AnalyticsReportingSystem_AlwaysUpdate.NativeMethodInfoPtr___GetEntityQuery_ForUpdateVbloodEngage_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, 100675408);
    }

    public AnalyticsReportingSystem_AlwaysUpdate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int ACCUMULATIVE_SEND_FREQUENCY
    {
      get
      {
        int accumulativeSendFrequency;
        IL2CPP.il2cpp_field_static_get_value(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr_ACCUMULATIVE_SEND_FREQUENCY, (void*) &accumulativeSendFrequency);
        return accumulativeSendFrequency;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr_ACCUMULATIVE_SEND_FREQUENCY, (void*) &value);
      }
    }

    public unsafe double _LastAccumulativeSendTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__LastAccumulativeSendTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__LastAccumulativeSendTime)) = value;
      }
    }

    public unsafe AnalyticsReportingSystem_EventHandlers _EventHandlersSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__EventHandlersSystem));
        return pointer == System.IntPtr.Zero ? (AnalyticsReportingSystem_EventHandlers) null : new AnalyticsReportingSystem_EventHandlers(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__EventHandlersSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData VbloodEngage
    {
      get
      {
        return *(AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr_VbloodEngage));
      }
      [param: In] set
      {
        *(AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr_VbloodEngage)) = value;
      }
    }

    public unsafe EntityQuery __UpdateVbloodEngage_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateVbloodEngage_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr___UpdateVbloodEngage_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_5
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_5));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_5)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VbloodEngageData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Counters;
      private static readonly System.IntPtr NativeFieldInfoPtr_EngagedPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_EngageTime;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, int> Counters;
      [FieldOffset(16)]
      public PrefabGUID EngagedPrefab;
      [FieldOffset(24)]
      public double EngageTime;

      static VbloodEngageData()
      {
        Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, nameof (VbloodEngageData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData>.NativeClassPtr);
        AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData.NativeFieldInfoPtr_Counters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData>.NativeClassPtr, nameof (Counters));
        AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData.NativeFieldInfoPtr_EngagedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData>.NativeClassPtr, nameof (EngagedPrefab));
        AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData.NativeFieldInfoPtr_EngageTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData>.NativeClassPtr, nameof (EngageTime));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.VbloodEngageData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AnalyticsReportingSystem_AlwaysUpdate/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVbloodEngage_b__0_Internal_Void_byref_CombatMusicListener_Shared_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateVbloodEngage_b__0([In] ref CombatMusicListener_Shared musicListener)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref musicListener;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateVbloodEngage_b__0_Internal_Void_byref_CombatMusicListener_Shared_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr, nameof (serverTime));
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr, 100675409);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateVbloodEngage_b__0_Internal_Void_byref_CombatMusicListener_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr, 100675410);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe AnalyticsReportingSystem_AlwaysUpdate __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AnalyticsReportingSystem_AlwaysUpdate) null : new AnalyticsReportingSystem_AlwaysUpdate(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AnalyticsReportingSystem_AlwaysUpdate/ProjectM.<>c__DisplayClass_UpdateVbloodEngage_LambdaJob0")]
    public sealed class __c__DisplayClass_UpdateVbloodEngage_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CombatMusicListener_Shared_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AnalyticsReportingSystem_AlwaysUpdate_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 975277, RefRangeEnd = 975278, XrefRangeStart = 975262, XrefRangeEnd = 975277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref CombatMusicListener_Shared musicListener)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref musicListener;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CombatMusicListener_Shared_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 975279, RefRangeEnd = 975282, XrefRangeStart = 975278, XrefRangeEnd = 975279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 975283, RefRangeEnd = 975294, XrefRangeStart = 975282, XrefRangeEnd = 975283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975294, XrefRangeEnd = 975296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 975301, RefRangeEnd = 975302, XrefRangeStart = 975296, XrefRangeEnd = 975301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 975304, RefRangeEnd = 975305, XrefRangeStart = 975302, XrefRangeEnd = 975304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AnalyticsReportingSystem_AlwaysUpdate componentSystem,
        ref AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AnalyticsReportingSystem_AlwaysUpdate_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975305, XrefRangeEnd = 975311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateVbloodEngage_LambdaJob0()
      {
        Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate>.NativeClassPtr, "<>c__DisplayClass_UpdateVbloodEngage_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, "<>4__this");
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, nameof (serverTime));
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CombatMusicListener_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, 100675411);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, 100675412);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, 100675413);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, 100675414);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, 100675415);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AnalyticsReportingSystem_AlwaysUpdate_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, 100675416);
        AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, 100675417);
      }

      public __c__DisplayClass_UpdateVbloodEngage_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateVbloodEngage_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe AnalyticsReportingSystem_AlwaysUpdate __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AnalyticsReportingSystem_AlwaysUpdate) null : new AnalyticsReportingSystem_AlwaysUpdate(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_musicListener;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AnalyticsReportingSystem_AlwaysUpdate_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CombatMusicListener_Shared> forParameter_musicListener;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 975257, RefRangeEnd = 975258, XrefRangeStart = 975254, XrefRangeEnd = 975257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AnalyticsReportingSystem_AlwaysUpdate componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AnalyticsReportingSystem_AlwaysUpdate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 975261, RefRangeEnd = 975262, XrefRangeStart = 975258, XrefRangeEnd = 975261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_musicListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_musicListener));
          AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AnalyticsReportingSystem_AlwaysUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675418);
          AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100675419);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_musicListener;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CombatMusicListener_Shared>.Runtime runtime_musicListener;

          static Runtimes()
          {
            Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_musicListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_musicListener));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalyticsReportingSystem_AlwaysUpdate.__c__DisplayClass_UpdateVbloodEngage_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
