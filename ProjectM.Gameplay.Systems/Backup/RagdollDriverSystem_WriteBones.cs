// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollDriverSystem_WriteBones
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class RagdollDriverSystem_WriteBones : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___Pass0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Pass0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Pass1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Pass1_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPass0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPass1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414303, XrefRangeEnd = 1414333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RagdollDriverSystem_WriteBones.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RagdollDriverSystem_WriteBones()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414333, XrefRangeEnd = 1414363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RagdollDriverSystem_WriteBones.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414385, RefRangeEnd = 1414386, XrefRangeStart = 1414363, XrefRangeEnd = 1414385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPass0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.NativeMethodInfoPtr___GetEntityQuery_ForPass0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414408, RefRangeEnd = 1414409, XrefRangeStart = 1414386, XrefRangeEnd = 1414408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPass1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.NativeMethodInfoPtr___GetEntityQuery_ForPass1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414413, RefRangeEnd = 1414414, XrefRangeStart = 1414409, XrefRangeEnd = 1414413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RagdollDriverSystem_WriteBones()
    {
      Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (RagdollDriverSystem_WriteBones));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr);
      RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>Pass0_entityQuery");
      RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>Pass0_profilerMarker");
      RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>Pass1_entityQuery");
      RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>Pass1_profilerMarker");
      RagdollDriverSystem_WriteBones.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, 100668972);
      RagdollDriverSystem_WriteBones.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, 100668973);
      RagdollDriverSystem_WriteBones.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, 100668974);
      RagdollDriverSystem_WriteBones.NativeMethodInfoPtr___GetEntityQuery_ForPass0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, 100668975);
      RagdollDriverSystem_WriteBones.NativeMethodInfoPtr___GetEntityQuery_ForPass1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, 100668976);
      RagdollDriverSystem_WriteBones.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, 100668977);
    }

    public RagdollDriverSystem_WriteBones(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __Pass0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Pass0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __Pass1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Pass1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.NativeFieldInfoPtr___Pass1_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.RagdollDriverSystem_WriteBones/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_DynamicBuffer_1_RagdollBoneTransformElement_byref_DynamicBuffer_1_RagdollBoneEntityElement_byref_RagdollDriver_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        DynamicBuffer<RagdollBoneTransformElement> transformBuffer,
        [In] ref DynamicBuffer<RagdollBoneEntityElement> entityBuffer,
        [In] ref RagdollDriver ragdollDriver)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &transformBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ragdollDriver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_DynamicBuffer_1_RagdollBoneTransformElement_byref_DynamicBuffer_1_RagdollBoneEntityElement_byref_RagdollDriver_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr);
        RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr, nameof (time));
        RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr, nameof (deltaTime));
        RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr, 100668978);
        RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_DynamicBuffer_1_RagdollBoneTransformElement_byref_DynamicBuffer_1_RagdollBoneEntityElement_byref_RagdollDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr, 100668979);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass0_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass0_0>.NativeClassPtr, data));
      }

      public unsafe RagdollDriverSystem_WriteBones __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RagdollDriverSystem_WriteBones) null : new RagdollDriverSystem_WriteBones(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float time
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr_time));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr_time)) = value;
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass0_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.RagdollDriverSystem_WriteBones/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_1_Internal_Void_Entity_byref_HybridRagdollComponent_byref_DynamicBuffer_1_RagdollBoneTransformElement_byref_RagdollDriver_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0_1(
        Entity entity,
        [In] ref HybridRagdollComponent hybridRagdollComponent,
        [In] ref DynamicBuffer<RagdollBoneTransformElement> transformBuffer,
        [In] ref RagdollDriver ragdollDriver)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
        numPtr1[0] = (System.IntPtr) &entity;
        System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridRagdollComponent);
        System.IntPtr* numPtr2 = &ptr;
        *(System.IntPtr*) num = (System.IntPtr) numPtr2;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref transformBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ragdollDriver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c.NativeMethodInfoPtr__OnUpdate_b__0_1_Internal_Void_Entity_byref_HybridRagdollComponent_byref_DynamicBuffer_1_RagdollBoneTransformElement_byref_RagdollDriver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref HybridRagdollComponent local = ref hybridRagdollComponent;
        System.IntPtr pointer = ptr;
        HybridRagdollComponent ragdollComponent = pointer == System.IntPtr.Zero ? (HybridRagdollComponent) null : new HybridRagdollComponent(pointer);
        local = ragdollComponent;
      }

      static __c()
      {
        Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c>.NativeClassPtr);
        RagdollDriverSystem_WriteBones.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c>.NativeClassPtr, "<>9");
        RagdollDriverSystem_WriteBones.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c>.NativeClassPtr, "<>9__0_1");
        RagdollDriverSystem_WriteBones.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c>.NativeClassPtr, 100668981);
        RagdollDriverSystem_WriteBones.__c.NativeMethodInfoPtr__OnUpdate_b__0_1_Internal_Void_Entity_byref_HybridRagdollComponent_byref_DynamicBuffer_1_RagdollBoneTransformElement_byref_RagdollDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c>.NativeClassPtr, 100668982);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe RagdollDriverSystem_WriteBones.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RagdollDriverSystem_WriteBones.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RagdollDriverSystem_WriteBones.__c) null : new RagdollDriverSystem_WriteBones.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RagdollDriverSystem_WriteBones.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VIII<Entity, HybridRagdollComponent, DynamicBuffer<RagdollBoneTransformElement>, RagdollDriver> __9__0_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RagdollDriverSystem_WriteBones.__c.NativeFieldInfoPtr___9__0_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VIII<Entity, HybridRagdollComponent, DynamicBuffer<RagdollBoneTransformElement>, RagdollDriver>) null : new VIII<Entity, HybridRagdollComponent, DynamicBuffer<RagdollBoneTransformElement>, RagdollDriver>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RagdollDriverSystem_WriteBones.__c.NativeFieldInfoPtr___9__0_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.RagdollDriverSystem_WriteBones/ProjectM.<>c__DisplayClass_Pass0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Pass0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PhysicsDamping_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_RagdollBoneTransformElement_byref_DynamicBuffer_1_RagdollBoneEntityElement_byref_RagdollDriver_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float time;
      [FieldOffset(4)]
      public float deltaTime;
      [FieldOffset(8)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(40)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_1;
      [FieldOffset(72)]
      public ComponentDataFromEntity<PhysicsDamping> _ComponentDataFromEntity_PhysicsDamping_2;
      [FieldOffset(104)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_3;
      [FieldOffset(136)]
      public ComponentDataFromEntity<LastTranslation> _ComponentDataFromEntity_LastTranslation_4;
      [FieldOffset(168)]
      public RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(280)]
      public unsafe RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414148, XrefRangeEnd = 1414199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<RagdollBoneTransformElement> transformBuffer,
        [In] ref DynamicBuffer<RagdollBoneEntityElement> entityBuffer,
        [In] ref RagdollDriver ragdollDriver)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &transformBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ragdollDriver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_RagdollBoneTransformElement_byref_DynamicBuffer_1_RagdollBoneEntityElement_byref_RagdollDriver_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1414199, RefRangeEnd = 1414200, XrefRangeStart = 1414199, XrefRangeEnd = 1414199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RagdollDriverSystem_WriteBones.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1414200, RefRangeEnd = 1414201, XrefRangeStart = 1414200, XrefRangeEnd = 1414200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RagdollDriverSystem_WriteBones.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414201, XrefRangeEnd = 1414203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1414214, RefRangeEnd = 1414215, XrefRangeStart = 1414203, XrefRangeEnd = 1414214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1414232, RefRangeEnd = 1414233, XrefRangeStart = 1414215, XrefRangeEnd = 1414232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RagdollDriverSystem_WriteBones componentSystem,
        ref RagdollDriverSystem_WriteBones.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414233, XrefRangeEnd = 1414237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414237, XrefRangeEnd = 1414243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Pass0()
      {
        Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>c__DisplayClass_Pass0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (time));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (deltaTime));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_1));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr__ComponentDataFromEntity_PhysicsDamping_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (_ComponentDataFromEntity_PhysicsDamping_2));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_3));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr__ComponentDataFromEntity_LastTranslation_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (_ComponentDataFromEntity_LastTranslation_4));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (_runtimes));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_RagdollBoneTransformElement_byref_DynamicBuffer_1_RagdollBoneEntityElement_byref_RagdollDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668983);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668984);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668985);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668986);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668987);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668988);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668989);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, 100668990);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_transformBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_ragdollDriver;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<RagdollBoneTransformElement> forParameter_transformBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<RagdollBoneEntityElement> forParameter_entityBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<RagdollDriver> forParameter_ragdollDriver;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1414062, RefRangeEnd = 1414063, XrefRangeStart = 1414053, XrefRangeEnd = 1414062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RagdollDriverSystem_WriteBones componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1414072, RefRangeEnd = 1414073, XrefRangeStart = 1414063, XrefRangeEnd = 1414072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_transformBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_transformBuffer));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityBuffer));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_ragdollDriver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_ragdollDriver));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr, 100668991);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr, 100668992);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_transformBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_ragdollDriver;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<RagdollBoneTransformElement>.Runtime runtime_transformBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<RagdollBoneEntityElement>.Runtime runtime_entityBuffer;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<RagdollDriver>.Runtime runtime_ragdollDriver;

          static Runtimes()
          {
            Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_transformBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_transformBuffer));
            RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityBuffer));
            RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_ragdollDriver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_ragdollDriver));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.RagdollDriverSystem_WriteBones/ProjectM.<>c__DisplayClass_Pass0/ProjectM.RunWithoutJobSystem_00000D69$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, "RunWithoutJobSystem_00000D69$PostfixBurstDelegate");
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668993);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668994);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668995);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668996);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.RagdollDriverSystem_WriteBones/ProjectM.<>c__DisplayClass_Pass0/ProjectM.RunWithoutJobSystem_00000D69$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414073, XrefRangeEnd = 1414087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414087, XrefRangeEnd = 1414105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414105, XrefRangeEnd = 1414120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1414147, RefRangeEnd = 1414148, XrefRangeStart = 1414120, XrefRangeEnd = 1414147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0>.NativeClassPtr, "RunWithoutJobSystem_00000D69$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668997);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668998);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668999);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669000);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669002);
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
            IL2CPP.il2cpp_field_static_get_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.RagdollDriverSystem_WriteBones/ProjectM.<>c__DisplayClass_Pass1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Pass1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_HybridRagdollComponent_byref_DynamicBuffer_1_RagdollBoneTransformElement_byref_RagdollDriver_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1414279, RefRangeEnd = 1414280, XrefRangeStart = 1414266, XrefRangeEnd = 1414279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref HybridRagdollComponent hybridRagdollComponent,
        [In] ref DynamicBuffer<RagdollBoneTransformElement> transformBuffer,
        [In] ref RagdollDriver ragdollDriver)
      {
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
        numPtr1[0] = (System.IntPtr) &entity;
        System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridRagdollComponent);
        System.IntPtr* numPtr2 = &ptr;
        *(System.IntPtr*) num = (System.IntPtr) numPtr2;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref transformBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ragdollDriver;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_HybridRagdollComponent_byref_DynamicBuffer_1_RagdollBoneTransformElement_byref_RagdollDriver_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref HybridRagdollComponent local = ref hybridRagdollComponent;
        System.IntPtr pointer = ptr;
        HybridRagdollComponent ragdollComponent = pointer == System.IntPtr.Zero ? (HybridRagdollComponent) null : new HybridRagdollComponent(pointer);
        local = ragdollComponent;
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414280, XrefRangeEnd = 1414282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1414294, RefRangeEnd = 1414295, XrefRangeStart = 1414282, XrefRangeEnd = 1414294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1414296, RefRangeEnd = 1414297, XrefRangeStart = 1414295, XrefRangeEnd = 1414296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(RagdollDriverSystem_WriteBones componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414297, XrefRangeEnd = 1414303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Pass1()
      {
        Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones>.NativeClassPtr, "<>c__DisplayClass_Pass1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, nameof (_runtimes));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_HybridRagdollComponent_byref_DynamicBuffer_1_RagdollBoneTransformElement_byref_RagdollDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, 100669003);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, 100669004);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, 100669005);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, 100669006);
        RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, 100669007);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hybridRagdollComponent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_transformBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_ragdollDriver;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<HybridRagdollComponent> forParameter_hybridRagdollComponent;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_DynamicBuffer<RagdollBoneTransformElement> forParameter_transformBuffer;
        [FieldOffset(88)]
        public LambdaParameterValueProvider_IComponentData<RagdollDriver> forParameter_ragdollDriver;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1414253, RefRangeEnd = 1414254, XrefRangeStart = 1414243, XrefRangeEnd = 1414253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RagdollDriverSystem_WriteBones componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1414265, RefRangeEnd = 1414266, XrefRangeStart = 1414254, XrefRangeEnd = 1414265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hybridRagdollComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hybridRagdollComponent));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_transformBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_transformBuffer));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_ragdollDriver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_ragdollDriver));
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RagdollDriverSystem_WriteBones_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, 100669008);
          RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, 100669009);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hybridRagdollComponent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_transformBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_ragdollDriver;

          static Runtimes()
          {
            Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridRagdollComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hybridRagdollComponent));
            RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_transformBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_transformBuffer));
            RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_ragdollDriver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_ragdollDriver));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<HybridRagdollComponent>.Runtime runtime_hybridRagdollComponent
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridRagdollComponent);
              return new LambdaParameterValueProvider_ManagedComponentData<HybridRagdollComponent>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridRagdollComponent>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridRagdollComponent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridRagdollComponent>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_DynamicBuffer<RagdollBoneTransformElement>.Runtime runtime_transformBuffer
          {
            get
            {
              return *(LambdaParameterValueProvider_DynamicBuffer<RagdollBoneTransformElement>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_transformBuffer));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_transformBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_DynamicBuffer<RagdollBoneTransformElement>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<RagdollDriver>.Runtime runtime_ragdollDriver
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<RagdollDriver>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_ragdollDriver));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollDriverSystem_WriteBones.__c__DisplayClass_Pass1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_ragdollDriver), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<RagdollDriver>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }
  }
}
