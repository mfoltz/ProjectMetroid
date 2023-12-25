// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Behaviours
{
  public class BehaviourTreeStateBuffsSystem_RegisterAndDestroy : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Register_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Register_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuffShouldExistInState_Private_Static_Boolean_PrefabGUID_GenericEnemyState_byref_DynamicBuffer_1_BehaviourTreeStateBuffsBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegister_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340652, XrefRangeEnd = 1340690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1340699, RefRangeEnd = 1340701, XrefRangeStart = 1340690, XrefRangeEnd = 1340699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool BuffShouldExistInState(
      PrefabGUID buffGuid,
      GenericEnemyState state,
      [In] ref DynamicBuffer<BehaviourTreeStateBuffsBuffer> buffs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &state;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffs;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_BuffShouldExistInState_Private_Static_Boolean_PrefabGUID_GenericEnemyState_byref_DynamicBuffer_1_BehaviourTreeStateBuffsBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeStateBuffsSystem_RegisterAndDestroy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340701, XrefRangeEnd = 1340768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340768, XrefRangeEnd = 1340787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegister_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr___GetEntityQuery_ForRegister_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340787, XrefRangeEnd = 1340803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1340807, RefRangeEnd = 1340808, XrefRangeStart = 1340803, XrefRangeEnd = 1340807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1340812, RefRangeEnd = 1340813, XrefRangeStart = 1340808, XrefRangeEnd = 1340812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BehaviourTreeStateBuffsSystem_RegisterAndDestroy()
    {
      Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeStateBuffsSystem_RegisterAndDestroy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr__RegisterQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, nameof (_RegisterQuery));
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Register_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, "<>Register_entityQuery");
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Register_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, "<>Register_profilerMarker");
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Destroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, "<>Destroy_entityQuery");
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Destroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, "<>Destroy_profilerMarker");
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665073);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_BuffShouldExistInState_Private_Static_Boolean_PrefabGUID_GenericEnemyState_byref_DynamicBuffer_1_BehaviourTreeStateBuffsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665074);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665075);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665076);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr___GetEntityQuery_ForRegister_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665077);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665078);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665079);
      BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, 100665080);
    }

    public BehaviourTreeStateBuffsSystem_RegisterAndDestroy(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _RegisterQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr__RegisterQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr__RegisterQuery)) = value;
      }
    }

    public unsafe EntityQuery __Register_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Register_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Register_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Register_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Register_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Register_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __Destroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Destroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Destroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Destroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Destroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.NativeFieldInfoPtr___Destroy_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy/<>c__DisplayClass1_0")]
    public sealed class __c__DisplayClass1_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RegisterBehaviourTreeStateBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_BehaviourTreeStateChangedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref RegisterBehaviourTreeStateBuff registerBuff)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RegisterBehaviourTreeStateBuff_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref BehaviourTreeStateChangedEvent evt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_BehaviourTreeStateChangedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeFieldInfoPtr_destroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr, nameof (destroyCommandBuffer));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr, 100665081);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_RegisterBehaviourTreeStateBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr, 100665082);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_BehaviourTreeStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr, 100665083);
      }

      public __c__DisplayClass1_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass1_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0>.NativeClassPtr, data));
      }

      public unsafe BehaviourTreeStateBuffsSystem_RegisterAndDestroy __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BehaviourTreeStateBuffsSystem_RegisterAndDestroy) null : new BehaviourTreeStateBuffsSystem_RegisterAndDestroy(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer destroyCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeFieldInfoPtr_destroyCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0.NativeFieldInfoPtr_destroyCommandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy/ProjectM.Behaviours.<>c__DisplayClass_Register")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Register
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RegisterBehaviourTreeStateBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<BehaviourTreeStateActiveBuffsBuffer> _BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_0;
      [FieldOffset(40)]
      public BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340484, XrefRangeEnd = 1340490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref RegisterBehaviourTreeStateBuff registerBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RegisterBehaviourTreeStateBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340490, XrefRangeEnd = 1340492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1340498, RefRangeEnd = 1340499, XrefRangeStart = 1340492, XrefRangeEnd = 1340498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1340503, RefRangeEnd = 1340504, XrefRangeStart = 1340499, XrefRangeEnd = 1340503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy componentSystem,
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340504, XrefRangeEnd = 1340508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340508, XrefRangeEnd = 1340514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Register()
      {
        Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, "<>c__DisplayClass_Register");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, nameof (_BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_0));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, nameof (_runtimes));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RegisterBehaviourTreeStateBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665084);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665085);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665086);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665087);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665088);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665089);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665090);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, 100665091);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RegisterBehaviourTreeStateBuff> forParameter_registerBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1340403, RefRangeEnd = 1340404, XrefRangeStart = 1340399, XrefRangeEnd = 1340403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1340408, RefRangeEnd = 1340409, XrefRangeStart = 1340404, XrefRangeEnd = 1340408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerBuff));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders>.NativeClassPtr, 100665092);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders>.NativeClassPtr, 100665093);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RegisterBehaviourTreeStateBuff>.Runtime runtime_registerBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy/ProjectM.Behaviours.<>c__DisplayClass_Register/ProjectM.Behaviours.RunWithoutJobSystem_00000598$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, "RunWithoutJobSystem_00000598$PostfixBurstDelegate");
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665094);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665095);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665096);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665097);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy/ProjectM.Behaviours.<>c__DisplayClass_Register/ProjectM.Behaviours.RunWithoutJobSystem_00000598$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340409, XrefRangeEnd = 1340423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340423, XrefRangeEnd = 1340441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340441, XrefRangeEnd = 1340456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1340483, RefRangeEnd = 1340484, XrefRangeStart = 1340456, XrefRangeEnd = 1340483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register>.NativeClassPtr, "RunWithoutJobSystem_00000598$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665098);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665099);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665100);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665101);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665103);
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
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Register.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy/ProjectM.Behaviours.<>c__DisplayClass_Destroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Destroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeStateBuffsBuffer_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BehaviourTreeStateChangedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_byref___c__DisplayClass1_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer destroyCommandBuffer;
      [FieldOffset(16)]
      public BufferFromEntity<BehaviourTreeStateBuffsBuffer> _BufferFromEntity_BehaviourTreeStateBuffsBuffer_0;
      [FieldOffset(56)]
      public BufferFromEntity<BehaviourTreeStateActiveBuffsBuffer> _BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_1;
      [FieldOffset(96)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_2;
      [FieldOffset(128)]
      public BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340597, XrefRangeEnd = 1340622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref BehaviourTreeStateChangedEvent evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BehaviourTreeStateChangedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340622, XrefRangeEnd = 1340624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1340629, RefRangeEnd = 1340630, XrefRangeStart = 1340624, XrefRangeEnd = 1340629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1340641, RefRangeEnd = 1340642, XrefRangeStart = 1340630, XrefRangeEnd = 1340641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy componentSystem,
        ref BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass1_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_byref___c__DisplayClass1_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340642, XrefRangeEnd = 1340646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340646, XrefRangeEnd = 1340652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Destroy()
      {
        Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy>.NativeClassPtr, "<>c__DisplayClass_Destroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr_destroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (destroyCommandBuffer));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeStateBuffsBuffer_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_BufferFromEntity_BehaviourTreeStateBuffsBuffer_0));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr__BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_BufferFromEntity_BehaviourTreeStateActiveBuffsBuffer_1));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_2));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_runtimes));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BehaviourTreeStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665104);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665105);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665106);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665107);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665108);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_byref___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665109);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665110);
        BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, 100665111);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BehaviourTreeStateChangedEvent> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1340517, RefRangeEnd = 1340518, XrefRangeStart = 1340514, XrefRangeEnd = 1340517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1340521, RefRangeEnd = 1340522, XrefRangeStart = 1340518, XrefRangeEnd = 1340521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BehaviourTreeStateBuffsSystem_RegisterAndDestroy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100665112);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100665113);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BehaviourTreeStateChangedEvent>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy/ProjectM.Behaviours.<>c__DisplayClass_Destroy/ProjectM.Behaviours.RunWithoutJobSystem_000005A1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, "RunWithoutJobSystem_000005A1$PostfixBurstDelegate");
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665114);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665115);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665116);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665117);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Behaviours.BehaviourTreeStateBuffsSystem_RegisterAndDestroy/ProjectM.Behaviours.<>c__DisplayClass_Destroy/ProjectM.Behaviours.RunWithoutJobSystem_000005A1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340522, XrefRangeEnd = 1340536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340536, XrefRangeEnd = 1340554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1340554, XrefRangeEnd = 1340569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1340596, RefRangeEnd = 1340597, XrefRangeStart = 1340569, XrefRangeEnd = 1340596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy>.NativeClassPtr, "RunWithoutJobSystem_000005A1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665118);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665119);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665120);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665121);
          BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665123);
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
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BehaviourTreeStateBuffsSystem_RegisterAndDestroy.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
