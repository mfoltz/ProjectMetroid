﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceAbilityOnSlotWhenMountedBuffSystem_Update
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

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
  public class ReplaceAbilityOnSlotWhenMountedBuffSystem_Update : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ToAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr__ToRemove;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToRemove_Internal_Void_byref_ToModifyData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModifications_Private_Void_byref_ToModifyData_EntityCommandBuffer_byref_ModificationStructure_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416384, XrefRangeEnd = 1416387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddToRemove(
      [In] ref ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_AddToRemove_Internal_Void_byref_ToModifyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416387, XrefRangeEnd = 1416397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416397, XrefRangeEnd = 1416402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416402, XrefRangeEnd = 1416459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1416514, RefRangeEnd = 1416515, XrefRangeStart = 1416459, XrefRangeEnd = 1416514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyModifications(
      [In] ref ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData data,
      EntityCommandBuffer ecb,
      [In] ref ModificationStructure modificationStruct)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ecb;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationStruct;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_ApplyModifications_Private_Void_byref_ToModifyData_EntityCommandBuffer_byref_ModificationStructure_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplaceAbilityOnSlotWhenMountedBuffSystem_Update()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416515, XrefRangeEnd = 1416533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1416555, RefRangeEnd = 1416556, XrefRangeStart = 1416533, XrefRangeEnd = 1416555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1416560, RefRangeEnd = 1416561, XrefRangeStart = 1416556, XrefRangeEnd = 1416560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplaceAbilityOnSlotWhenMountedBuffSystem_Update()
    {
      Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ReplaceAbilityOnSlotWhenMountedBuffSystem_Update));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, nameof (_ModificationSystem));
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, nameof (_ToAdd));
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, nameof (_ToRemove));
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_AddToRemove_Internal_Void_byref_ToModifyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669194);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669195);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669196);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669197);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_ApplyModifications_Private_Void_byref_ToModifyData_EntityCommandBuffer_byref_ModificationStructure_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669198);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669199);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669200);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669201);
      ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, 100669202);
    }

    public ReplaceAbilityOnSlotWhenMountedBuffSystem_Update(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData> _ToAdd
    {
      get
      {
        return *(NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ToAdd));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ToAdd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData> _ToRemove
    {
      get
      {
        return *(NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ToRemove));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr__ToRemove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotWhenMountedBuffSystem_Update/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_toAdd;
      private static readonly System.IntPtr NativeFieldInfoPtr_toRemove;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffElement_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffModificationElement_byref_Buff_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffElement> replaceBuffer,
        ref DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffModificationElement> modificationBuffer,
        [In] ref Buff buff)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaceBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffElement_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffModificationElement_byref_Buff_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr_toAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr, nameof (toAdd));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr_toRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr, nameof (toRemove));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr, 100669203);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffElement_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffModificationElement_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr, 100669204);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass6_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0>.NativeClassPtr, data));
      }

      public unsafe ReplaceAbilityOnSlotWhenMountedBuffSystem_Update __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ReplaceAbilityOnSlotWhenMountedBuffSystem_Update) null : new ReplaceAbilityOnSlotWhenMountedBuffSystem_Update(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData> toAdd
      {
        get
        {
          return *(NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr_toAdd));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr_toAdd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData> toRemove
      {
        get
        {
          return *(NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr_toRemove));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0.NativeFieldInfoPtr_toRemove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotWhenMountedBuffSystem_Update/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_toAdd;
      private static readonly System.IntPtr NativeFieldInfoPtr_toRemove;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ServantPower_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffElement_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffModificationElement_byref_Buff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotWhenMountedBuffSystem_Update_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData> toAdd;
      [FieldOffset(16)]
      public NativeList<ReplaceAbilityOnSlotWhenMountedBuff_Shared.ToModifyData> toRemove;
      [FieldOffset(32)]
      public ComponentDataFromEntity<ServantPower> _ComponentDataFromEntity_ServantPower_0;
      [FieldOffset(64)]
      public ComponentDataFromEntity<Mounter> _ComponentDataFromEntity_Mounter_1;
      [FieldOffset(96)]
      public ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(216)]
      public unsafe ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416334, XrefRangeEnd = 1416350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffElement> replaceBuffer,
        ref DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffModificationElement> modificationBuffer,
        [In] ref Buff buff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaceBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref modificationBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffElement_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffModificationElement_byref_Buff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755494, RefRangeEnd = 755501, XrefRangeStart = 755494, XrefRangeEnd = 755501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 755501, RefRangeEnd = 755508, XrefRangeStart = 755501, XrefRangeEnd = 755508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416350, XrefRangeEnd = 1416352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1416364, RefRangeEnd = 1416365, XrefRangeStart = 1416352, XrefRangeEnd = 1416364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1416373, RefRangeEnd = 1416374, XrefRangeStart = 1416365, XrefRangeEnd = 1416373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update componentSystem,
        ref ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotWhenMountedBuffSystem_Update_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416374, XrefRangeEnd = 1416378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416378, XrefRangeEnd = 1416384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_toAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (toAdd));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_toRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (toRemove));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ServantPower_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_ServantPower_0));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Mounter_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Mounter_1));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffElement_byref_DynamicBuffer_1_ReplaceAbilityOnSlotWhenMountedBuffModificationElement_byref_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669205);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669206);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669207);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669208);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669209);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotWhenMountedBuffSystem_Update_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669210);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669211);
        ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669212);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_replaceBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_modificationBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotWhenMountedBuffSystem_Update_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffElement> forParameter_replaceBuffer;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffModificationElement> forParameter_modificationBuffer;
        [FieldOffset(88)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1416247, RefRangeEnd = 1416248, XrefRangeStart = 1416237, XrefRangeEnd = 1416247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotWhenMountedBuffSystem_Update_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1416258, RefRangeEnd = 1416259, XrefRangeStart = 1416248, XrefRangeEnd = 1416258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_replaceBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_replaceBuffer));
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_modificationBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_modificationBuffer));
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceAbilityOnSlotWhenMountedBuffSystem_Update_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669213);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669214);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_replaceBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_modificationBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffElement>.Runtime runtime_replaceBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<ReplaceAbilityOnSlotWhenMountedBuffModificationElement>.Runtime runtime_modificationBuffer;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;

          static Runtimes()
          {
            Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_replaceBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_replaceBuffer));
            ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_modificationBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_modificationBuffer));
            ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotWhenMountedBuffSystem_Update/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000DF3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000DF3$PostfixBurstDelegate");
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669215);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669216);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669217);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669218);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ReplaceAbilityOnSlotWhenMountedBuffSystem_Update/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000DF3$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416259, XrefRangeEnd = 1416273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416273, XrefRangeEnd = 1416291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416291, XrefRangeEnd = 1416306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1416333, RefRangeEnd = 1416334, XrefRangeStart = 1416306, XrefRangeEnd = 1416333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000DF3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669219);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669220);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669221);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669222);
          ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669224);
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
            IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceAbilityOnSlotWhenMountedBuffSystem_Update.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
