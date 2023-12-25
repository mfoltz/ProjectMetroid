// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.GetPlacementResultAsyncSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Profiling;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public class GetPlacementResultAsyncSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ScriptMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementOperationRequests;
    private static readonly System.IntPtr NativeFieldInfoPtr__Results;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoPlacementRequestNoBurstDueToLog_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DoPlacementRequest_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136815, XrefRangeEnd = 1136844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136844, XrefRangeEnd = 1136845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136845, XrefRangeEnd = 1136900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetPlacementResultAsyncSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136900, XrefRangeEnd = 1136928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1136932, RefRangeEnd = 1136933, XrefRangeStart = 1136928, XrefRangeEnd = 1136932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetPlacementResultAsyncSystem()
    {
      Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (GetPlacementResultAsyncSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr);
      GetPlacementResultAsyncSystem.NativeFieldInfoPtr__ScriptMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, nameof (_ScriptMapper));
      GetPlacementResultAsyncSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, nameof (_PlacementSystemData));
      GetPlacementResultAsyncSystem.NativeFieldInfoPtr__PlacementOperationRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, nameof (_PlacementOperationRequests));
      GetPlacementResultAsyncSystem.NativeFieldInfoPtr__Results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, nameof (_Results));
      GetPlacementResultAsyncSystem.NativeFieldInfoPtr___DoPlacementRequestNoBurstDueToLog_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, "<>DoPlacementRequestNoBurstDueToLog_profilerMarker");
      GetPlacementResultAsyncSystem.NativeFieldInfoPtr___DoPlacementRequest_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, "<>DoPlacementRequest_profilerMarker");
      GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, 100689983);
      GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, 100689984);
      GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, 100689985);
      GetPlacementResultAsyncSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, 100689986);
      GetPlacementResultAsyncSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, 100689987);
      GetPlacementResultAsyncSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, 100689988);
    }

    public GetPlacementResultAsyncSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ServerScriptMapper _ScriptMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__ScriptMapper));
        return pointer == System.IntPtr.Zero ? (ServerScriptMapper) null : new ServerScriptMapper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__ScriptMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _PlacementOperationRequests
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__PlacementOperationRequests));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__PlacementOperationRequests)) = value;
      }
    }

    public unsafe List<GetPlacementResultAsyncSystem.Result> _Results
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__Results));
        return pointer == System.IntPtr.Zero ? (List<GetPlacementResultAsyncSystem.Result>) null : new List<GetPlacementResultAsyncSystem.Result>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr__Results), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProfilerMarker __DoPlacementRequestNoBurstDueToLog_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr___DoPlacementRequestNoBurstDueToLog_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr___DoPlacementRequestNoBurstDueToLog_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __DoPlacementRequest_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr___DoPlacementRequest_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetPlacementResultAsyncSystem.NativeFieldInfoPtr___DoPlacementRequest_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Result
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Request;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementResult;
      [FieldOffset(0)]
      public PlacementOperationRequest Request;
      [FieldOffset(72)]
      public PlacementResult PlacementResult;

      static Result()
      {
        Il2CppClassPointerStore<GetPlacementResultAsyncSystem.Result>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, nameof (Result));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.Result>.NativeClassPtr);
        GetPlacementResultAsyncSystem.Result.NativeFieldInfoPtr_Request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.Result>.NativeClassPtr, nameof (Request));
        GetPlacementResultAsyncSystem.Result.NativeFieldInfoPtr_PlacementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.Result>.NativeClassPtr, nameof (PlacementResult));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.Result>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Placement.GetPlacementResultAsyncSystem/<>c__DisplayClass7_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass7_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_placementJobParams;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      [FieldOffset(0)]
      public GetPlacementResult.JobData placementJobParams;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_0>.NativeClassPtr);
        GetPlacementResultAsyncSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_placementJobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (placementJobParams));
        GetPlacementResultAsyncSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_0>.NativeClassPtr, 100689989);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Placement.GetPlacementResultAsyncSystem/<>c__DisplayClass7_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass7_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_placementResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_operation;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0;
      [FieldOffset(0)]
      public PlacementResult placementResult;
      [FieldOffset(144)]
      public GetPlacementResult.Operation operation;
      [FieldOffset(208)]
      public GetPlacementResultAsyncSystem.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_1()
      {
        Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, "<>c__DisplayClass7_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr);
        GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeFieldInfoPtr_placementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr, nameof (placementResult));
        GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr, nameof (operation));
        GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
        GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr, 100689990);
        GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr, 100689991);
        GetPlacementResultAsyncSystem.__c__DisplayClass7_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr, 100689992);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass7_1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Placement.GetPlacementResultAsyncSystem/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_DoPlacementRequestNoBurstDueToLog")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DoPlacementRequestNoBurstDueToLog
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_operation;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementJobParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetPlacementResultAsyncSystem_byref___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public GetPlacementResult.Operation operation;
      [FieldOffset(64)]
      public GetPlacementResult.JobData placementJobParams;
      [FieldOffset(3768)]
      public PlacementResult placementResult;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136623, RefRangeEnd = 1136627, XrefRangeStart = 1136622, XrefRangeEnd = 1136623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136628, RefRangeEnd = 1136632, XrefRangeStart = 1136627, XrefRangeEnd = 1136628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GetPlacementResultAsyncSystem.__c__DisplayClass7_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136633, RefRangeEnd = 1136635, XrefRangeStart = 1136632, XrefRangeEnd = 1136633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GetPlacementResultAsyncSystem.__c__DisplayClass7_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136636, RefRangeEnd = 1136640, XrefRangeStart = 1136635, XrefRangeEnd = 1136636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136641, RefRangeEnd = 1136643, XrefRangeStart = 1136640, XrefRangeEnd = 1136641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GetPlacementResultAsyncSystem componentSystem,
        ref GetPlacementResultAsyncSystem.__c__DisplayClass7_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetPlacementResultAsyncSystem_byref___c__DisplayClass7_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136734, RefRangeEnd = 1136736, XrefRangeStart = 1136643, XrefRangeEnd = 1136734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DoPlacementRequestNoBurstDueToLog()
      {
        Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, "<>c__DisplayClass_DoPlacementRequestNoBurstDueToLog");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, nameof (operation));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeFieldInfoPtr_placementJobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, nameof (placementJobParams));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeFieldInfoPtr_placementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, nameof (placementResult));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, 100689993);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, 100689994);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, 100689995);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, 100689996);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetPlacementResultAsyncSystem_byref___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, 100689997);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, 100689998);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequestNoBurstDueToLog.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Placement.GetPlacementResultAsyncSystem/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_DoPlacementRequest")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DoPlacementRequest
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_operation;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementJobParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_placementResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetPlacementResultAsyncSystem_byref___c__DisplayClass7_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public GetPlacementResult.Operation operation;
      [FieldOffset(64)]
      public GetPlacementResult.JobData placementJobParams;
      [FieldOffset(3768)]
      public PlacementResult placementResult;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136623, RefRangeEnd = 1136627, XrefRangeStart = 1136623, XrefRangeEnd = 1136627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136628, RefRangeEnd = 1136632, XrefRangeStart = 1136628, XrefRangeEnd = 1136632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GetPlacementResultAsyncSystem.__c__DisplayClass7_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136633, RefRangeEnd = 1136635, XrefRangeStart = 1136633, XrefRangeEnd = 1136635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GetPlacementResultAsyncSystem.__c__DisplayClass7_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1136636, RefRangeEnd = 1136640, XrefRangeStart = 1136636, XrefRangeEnd = 1136640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136641, RefRangeEnd = 1136643, XrefRangeStart = 1136641, XrefRangeEnd = 1136643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GetPlacementResultAsyncSystem componentSystem,
        ref GetPlacementResultAsyncSystem.__c__DisplayClass7_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetPlacementResultAsyncSystem_byref___c__DisplayClass7_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136811, XrefRangeEnd = 1136815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1136734, RefRangeEnd = 1136736, XrefRangeStart = 1136734, XrefRangeEnd = 1136736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DoPlacementRequest()
      {
        Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResultAsyncSystem>.NativeClassPtr, "<>c__DisplayClass_DoPlacementRequest");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (operation));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_placementJobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (placementJobParams));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_placementResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (placementResult));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100689999);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100690000);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100690001);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100690002);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GetPlacementResultAsyncSystem_byref___c__DisplayClass7_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100690003);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100690004);
        GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, 100690005);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Placement.GetPlacementResultAsyncSystem/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_DoPlacementRequest/ProjectM.CastleBuilding.Placement.RunWithoutJobSystem_00005D13$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, "RunWithoutJobSystem_00005D13$PostfixBurstDelegate");
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100690006);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100690007);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100690008);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100690009);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Placement.GetPlacementResultAsyncSystem/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_DoPlacementRequest/ProjectM.CastleBuilding.Placement.RunWithoutJobSystem_00005D13$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136736, XrefRangeEnd = 1136750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136750, XrefRangeEnd = 1136768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1136768, XrefRangeEnd = 1136783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1136810, RefRangeEnd = 1136811, XrefRangeStart = 1136783, XrefRangeEnd = 1136810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest>.NativeClassPtr, "RunWithoutJobSystem_00005D13$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690010);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690011);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690012);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690013);
          GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690015);
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
            IL2CPP.il2cpp_field_static_get_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GetPlacementResultAsyncSystem.__c__DisplayClass_DoPlacementRequest.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
