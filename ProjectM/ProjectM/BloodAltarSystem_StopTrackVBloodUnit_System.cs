// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodAltarSystem_StopTrackVBloodUnit_System
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
namespace ProjectM
{
  public class BloodAltarSystem_StopTrackVBloodUnit_System : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleEvent_Private_Void_FromCharacter_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000082, XrefRangeEnd = 1000098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000098, XrefRangeEnd = 1000112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1000126, RefRangeEnd = 1000127, XrefRangeStart = 1000112, XrefRangeEnd = 1000126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleEvent(
      FromCharacter fromCharacter,
      EntityCommandBuffer destroyCommandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_HandleEvent_Private_Void_FromCharacter_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodAltarSystem_StopTrackVBloodUnit_System()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000127, XrefRangeEnd = 1000163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000163, XrefRangeEnd = 1000182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr___GetEntityQuery_ForHandleEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1000186, RefRangeEnd = 1000187, XrefRangeStart = 1000182, XrefRangeEnd = 1000186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodAltarSystem_StopTrackVBloodUnit_System()
    {
      Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BloodAltarSystem_StopTrackVBloodUnit_System));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr);
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, nameof (_DestroyBarrier));
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, nameof (_EventQuery));
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr___HandleEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, "<>HandleEvent_LambdaJob0_entityQuery");
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr___HandleEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, "<>HandleEvent_LambdaJob0_profilerMarker");
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, 100677372);
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, 100677373);
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_HandleEvent_Private_Void_FromCharacter_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, 100677374);
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, 100677375);
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, 100677376);
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr___GetEntityQuery_ForHandleEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, 100677377);
      BloodAltarSystem_StopTrackVBloodUnit_System.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, 100677378);
    }

    public BloodAltarSystem_StopTrackVBloodUnit_System(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe EntityQuery __HandleEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr___HandleEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr___HandleEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr___HandleEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodAltarSystem_StopTrackVBloodUnit_System.NativeFieldInfoPtr___HandleEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.BloodAltarSystem_StopTrackVBloodUnit_System/<>c__DisplayClass4_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass4_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleEvent_b__0_Internal_Void_Entity_byref_Buff_0;
      [FieldOffset(0)]
      public FromCharacter fromCharacter;
      [FieldOffset(16)]
      public EntityCommandBuffer destroyCommandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleEvent_b__0(Entity entity, [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0.NativeMethodInfoPtr__HandleEvent_b__0_Internal_Void_Entity_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0>.NativeClassPtr);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0.NativeFieldInfoPtr_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0>.NativeClassPtr, nameof (fromCharacter));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0.NativeFieldInfoPtr_destroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0>.NativeClassPtr, nameof (destroyCommandBuffer));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0>.NativeClassPtr, 100677379);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0.NativeMethodInfoPtr__HandleEvent_b__0_Internal_Void_Entity_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0>.NativeClassPtr, 100677380);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.BloodAltarSystem_StopTrackVBloodUnit_System/ProjectM.<>c__DisplayClass_HandleEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BloodAltarSystem_StopTrackVBloodUnit_System_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public FromCharacter fromCharacter;
      [FieldOffset(16)]
      public EntityCommandBuffer destroyCommandBuffer;
      [FieldOffset(32)]
      public BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000056, XrefRangeEnd = 1000060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000060, XrefRangeEnd = 1000062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1000068, RefRangeEnd = 1000069, XrefRangeStart = 1000062, XrefRangeEnd = 1000068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1000071, RefRangeEnd = 1000072, XrefRangeStart = 1000069, XrefRangeEnd = 1000071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BloodAltarSystem_StopTrackVBloodUnit_System componentSystem,
        ref BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BloodAltarSystem_StopTrackVBloodUnit_System_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000072, XrefRangeEnd = 1000076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000076, XrefRangeEnd = 1000082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System>.NativeClassPtr, "<>c__DisplayClass_HandleEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, nameof (fromCharacter));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_destroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, nameof (destroyCommandBuffer));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677381);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677382);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677383);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677384);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677385);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BloodAltarSystem_StopTrackVBloodUnit_System_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677386);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677387);
        BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, 100677388);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BloodAltarSystem_StopTrackVBloodUnit_System_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 999975, RefRangeEnd = 999976, XrefRangeStart = 999971, XrefRangeEnd = 999975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          BloodAltarSystem_StopTrackVBloodUnit_System componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BloodAltarSystem_StopTrackVBloodUnit_System_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 999980, RefRangeEnd = 999981, XrefRangeStart = 999976, XrefRangeEnd = 999980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BloodAltarSystem_StopTrackVBloodUnit_System_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100677389);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100677390);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.BloodAltarSystem_StopTrackVBloodUnit_System/ProjectM.<>c__DisplayClass_HandleEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_00003566$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003566$PostfixBurstDelegate");
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677391);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677392);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677393);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677394);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.BloodAltarSystem_StopTrackVBloodUnit_System/ProjectM.<>c__DisplayClass_HandleEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_00003566$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999981, XrefRangeEnd = 999995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999995, XrefRangeEnd = 1000013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000013, XrefRangeEnd = 1000028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1000055, RefRangeEnd = 1000056, XrefRangeStart = 1000028, XrefRangeEnd = 1000055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00003566$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677395);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677396);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677397);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677398);
          BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677400);
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
            IL2CPP.il2cpp_field_static_get_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BloodAltarSystem_StopTrackVBloodUnit_System.__c__DisplayClass_HandleEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
