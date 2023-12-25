// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.BuffSequenceSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Sequencer
{
  public class BuffSequenceSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__InputEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSelfRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputLifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputBuffTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputEndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputAge;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__BalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__DayNightCycle;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetIndex_Private_Static_Boolean_byref_BlobArray_1_SequenceInputElement_byref_FixedString64_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089017, XrefRangeEnd = 1089052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffSequenceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089052, XrefRangeEnd = 1089054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffSequenceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089054, XrefRangeEnd = 1089098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffSequenceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1089103, RefRangeEnd = 1089113, XrefRangeStart = 1089098, XrefRangeEnd = 1089103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetIndex(
      ref BlobArray<SequenceInputElement> blackboardInput,
      [In] ref FixedString64 inputName,
      out int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref blackboardInput;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref inputName;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.NativeMethodInfoPtr_TryGetIndex_Private_Static_Boolean_byref_BlobArray_1_SequenceInputElement_byref_FixedString64_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuffSequenceSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089113, XrefRangeEnd = 1089131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuffSequenceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1089156, RefRangeEnd = 1089157, XrefRangeStart = 1089131, XrefRangeEnd = 1089156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1089161, RefRangeEnd = 1089162, XrefRangeStart = 1089157, XrefRangeEnd = 1089161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuffSequenceSystem()
    {
      Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (BuffSequenceSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr);
      BuffSequenceSystem.NativeFieldInfoPtr__InputEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputEntity));
      BuffSequenceSystem.NativeFieldInfoPtr__InputOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputOwner));
      BuffSequenceSystem.NativeFieldInfoPtr__InputPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputPosition));
      BuffSequenceSystem.NativeFieldInfoPtr__InputRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputRotation));
      BuffSequenceSystem.NativeFieldInfoPtr__InputSelfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputSelfRotation));
      BuffSequenceSystem.NativeFieldInfoPtr__InputStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputStacks));
      BuffSequenceSystem.NativeFieldInfoPtr__InputLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputLifeTime));
      BuffSequenceSystem.NativeFieldInfoPtr__InputBuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputBuffTarget));
      BuffSequenceSystem.NativeFieldInfoPtr__InputEndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputEndPosition));
      BuffSequenceSystem.NativeFieldInfoPtr__InputAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_InputAge));
      BuffSequenceSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      BuffSequenceSystem.NativeFieldInfoPtr__BalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_BalanceSettings));
      BuffSequenceSystem.NativeFieldInfoPtr__DayNightCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_DayNightCycle));
      BuffSequenceSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_ServerTime));
      BuffSequenceSystem.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      BuffSequenceSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      BuffSequenceSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      BuffSequenceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685711);
      BuffSequenceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685712);
      BuffSequenceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685713);
      BuffSequenceSystem.NativeMethodInfoPtr_TryGetIndex_Private_Static_Boolean_byref_BlobArray_1_SequenceInputElement_byref_FixedString64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685714);
      BuffSequenceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685715);
      BuffSequenceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685716);
      BuffSequenceSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685717);
      BuffSequenceSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, 100685718);
    }

    public BuffSequenceSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FixedString64 _InputEntity
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputEntity));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputEntity)) = value;
      }
    }

    public unsafe FixedString64 _InputOwner
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputOwner));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputOwner)) = value;
      }
    }

    public unsafe FixedString64 _InputPosition
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputPosition));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputPosition)) = value;
      }
    }

    public unsafe FixedString64 _InputRotation
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputRotation));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputRotation)) = value;
      }
    }

    public unsafe FixedString64 _InputSelfRotation
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputSelfRotation));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputSelfRotation)) = value;
      }
    }

    public unsafe FixedString64 _InputStacks
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputStacks));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputStacks)) = value;
      }
    }

    public unsafe FixedString64 _InputLifeTime
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputLifeTime));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputLifeTime)) = value;
      }
    }

    public unsafe FixedString64 _InputBuffTarget
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputBuffTarget));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputBuffTarget)) = value;
      }
    }

    public unsafe FixedString64 _InputEndPosition
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputEndPosition));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputEndPosition)) = value;
      }
    }

    public unsafe FixedString64 _InputAge
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputAge));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__InputAge)) = value;
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _BalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__BalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__BalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<DayNightCycle> _DayNightCycle
    {
      get
      {
        return *(SingletonAccessor<DayNightCycle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__DayNightCycle));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__DayNightCycle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<DayNightCycle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.BuffSequenceSystem/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBlackboardBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSequenceInput;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputBuffTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputSelfRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputStacks;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputLifeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLifeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputEndPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputAge;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAge;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_BuffSequenceSpawned_byref_DynamicBuffer_1_BuffSequence_byref_Buff_byref_EntityOwner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<BuffSequenceSpawned> buffSequencesSpawned,
        ref DynamicBuffer<BuffSequence> buffSequences,
        [In] ref Buff buff,
        [In] ref EntityOwner entityOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffSequencesSpawned;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffSequences;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_BuffSequenceSpawned_byref_DynamicBuffer_1_BuffSequence_byref_Buff_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr);
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (conditionChecker));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (commandBuffer));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getBlackboardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (getBlackboardBuffer));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getSequenceInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (getSequenceInput));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputEntity));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputBuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputBuffTarget));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputOwner));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputPosition));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (getTranslation));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputRotation));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (getRotation));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputSelfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputSelfRotation));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputStacks));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputLifeTime));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (getLifeTime));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputEndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputEndPosition));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (inputAge));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (getAge));
        BuffSequenceSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, 100685719);
        BuffSequenceSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_BuffSequenceSpawned_byref_DynamicBuffer_1_BuffSequence_byref_Buff_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, 100685720);
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass17_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass17_0>.NativeClassPtr, data));
      }

      public unsafe BuffSequenceSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BuffSequenceSystem) null : new BuffSequenceSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ConditionChecker conditionChecker
      {
        get
        {
          return *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_conditionChecker));
        }
        [param: In] set
        {
          *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_conditionChecker)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe BufferFromEntity<BlackboardElement> getBlackboardBuffer
      {
        get
        {
          return *(BufferFromEntity<BlackboardElement>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getBlackboardBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getBlackboardBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<BlackboardElement>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<SequenceInput> getSequenceInput
      {
        get
        {
          return *(ComponentDataFromEntity<SequenceInput>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getSequenceInput));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getSequenceInput), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<SequenceInput>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe FixedString64 inputEntity
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputEntity));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputEntity)) = value;
        }
      }

      public unsafe FixedString64 inputBuffTarget
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputBuffTarget));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputBuffTarget)) = value;
        }
      }

      public unsafe FixedString64 inputOwner
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputOwner));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputOwner)) = value;
        }
      }

      public unsafe FixedString64 inputPosition
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputPosition));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputPosition)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<Translation> getTranslation
      {
        get
        {
          return *(ComponentDataFromEntity<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getTranslation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getTranslation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe FixedString64 inputRotation
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputRotation));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputRotation)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<Rotation> getRotation
      {
        get
        {
          return *(ComponentDataFromEntity<Rotation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getRotation));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getRotation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Rotation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe FixedString64 inputSelfRotation
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputSelfRotation));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputSelfRotation)) = value;
        }
      }

      public unsafe FixedString64 inputStacks
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputStacks));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputStacks)) = value;
        }
      }

      public unsafe FixedString64 inputLifeTime
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputLifeTime));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputLifeTime)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<LifeTime> getLifeTime
      {
        get
        {
          return *(ComponentDataFromEntity<LifeTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getLifeTime));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getLifeTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<LifeTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe FixedString64 inputEndPosition
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputEndPosition));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputEndPosition)) = value;
        }
      }

      public unsafe FixedString64 inputAge
      {
        get
        {
          return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputAge));
        }
        [param: In] set
        {
          *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_inputAge)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<Age> getAge
      {
        get
        {
          return *(ComponentDataFromEntity<Age>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getAge));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuffSequenceSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_getAge), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Age>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.BuffSequenceSystem/ProjectM.Sequencer.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBlackboardBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getSequenceInput;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputBuffTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_getTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputSelfRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputStacks;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputLifeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLifeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputEndPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_inputAge;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAge;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SequenceInstance_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_BuffSequenceSpawned_byref_DynamicBuffer_1_BuffSequence_byref_Buff_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffSequenceSystem_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ConditionChecker conditionChecker;
      [FieldOffset(2200)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(2216)]
      public BufferFromEntity<BlackboardElement> getBlackboardBuffer;
      [FieldOffset(2256)]
      public ComponentDataFromEntity<SequenceInput> getSequenceInput;
      [FieldOffset(2288)]
      public FixedString64 inputEntity;
      [FieldOffset(2352)]
      public FixedString64 inputBuffTarget;
      [FieldOffset(2416)]
      public FixedString64 inputOwner;
      [FieldOffset(2480)]
      public FixedString64 inputPosition;
      [FieldOffset(2544)]
      public ComponentDataFromEntity<Translation> getTranslation;
      [FieldOffset(2576)]
      public FixedString64 inputRotation;
      [FieldOffset(2640)]
      public ComponentDataFromEntity<Rotation> getRotation;
      [FieldOffset(2672)]
      public FixedString64 inputSelfRotation;
      [FieldOffset(2736)]
      public FixedString64 inputStacks;
      [FieldOffset(2800)]
      public FixedString64 inputLifeTime;
      [FieldOffset(2864)]
      public ComponentDataFromEntity<LifeTime> getLifeTime;
      [FieldOffset(2896)]
      public FixedString64 inputEndPosition;
      [FieldOffset(2960)]
      public FixedString64 inputAge;
      [FieldOffset(3024)]
      public ComponentDataFromEntity<Age> getAge;
      [FieldOffset(3056)]
      public ComponentDataFromEntity<EntityOwner> _ComponentDataFromEntity_EntityOwner_0;
      [FieldOffset(3088)]
      public ComponentDataFromEntity<SequenceInstance> _ComponentDataFromEntity_SequenceInstance_1;
      [FieldOffset(3120)]
      public BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(3272)]
      public unsafe BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088878, XrefRangeEnd = 1088976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<BuffSequenceSpawned> buffSequencesSpawned,
        ref DynamicBuffer<BuffSequence> buffSequences,
        [In] ref Buff buff,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffSequencesSpawned;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffSequences;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_BuffSequenceSpawned_byref_DynamicBuffer_1_BuffSequence_byref_Buff_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1088977, RefRangeEnd = 1088978, XrefRangeStart = 1088976, XrefRangeEnd = 1088977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref BuffSequenceSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1088979, RefRangeEnd = 1088980, XrefRangeStart = 1088978, XrefRangeEnd = 1088979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref BuffSequenceSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088980, XrefRangeEnd = 1088982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1088997, RefRangeEnd = 1088998, XrefRangeStart = 1088982, XrefRangeEnd = 1088997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1089006, RefRangeEnd = 1089007, XrefRangeStart = 1088998, XrefRangeEnd = 1089006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        BuffSequenceSystem componentSystem,
        ref BuffSequenceSystem.__c__DisplayClass17_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffSequenceSystem_byref___c__DisplayClass17_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089007, XrefRangeEnd = 1089011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089011, XrefRangeEnd = 1089017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffSequenceSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (conditionChecker));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (commandBuffer));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getBlackboardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getBlackboardBuffer));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getSequenceInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getSequenceInput));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputEntity));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputBuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputBuffTarget));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputOwner));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputPosition));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getTranslation));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputRotation));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getRotation));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputSelfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputSelfRotation));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputStacks));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputLifeTime));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getLifeTime));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputEndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputEndPosition));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_inputAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (inputAge));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_getAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (getAge));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityOwner_0));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_SequenceInstance_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_SequenceInstance_1));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_BuffSequenceSpawned_byref_DynamicBuffer_1_BuffSequence_byref_Buff_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685721);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685722);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685723);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685724);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685725);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffSequenceSystem_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685726);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685727);
        BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100685728);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffSequencesSpawned;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffSequences;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffSequenceSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<BuffSequenceSpawned> forParameter_buffSequencesSpawned;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_DynamicBuffer<BuffSequence> forParameter_buffSequences;
        [FieldOffset(88)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1088788, RefRangeEnd = 1088789, XrefRangeStart = 1088775, XrefRangeEnd = 1088788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(BuffSequenceSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffSequenceSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1088802, RefRangeEnd = 1088803, XrefRangeStart = 1088789, XrefRangeEnd = 1088802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffSequencesSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffSequencesSpawned));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffSequences));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_BuffSequenceSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100685729);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100685730);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffSequencesSpawned;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffSequences;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<BuffSequenceSpawned>.Runtime runtime_buffSequencesSpawned;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<BuffSequence>.Runtime runtime_buffSequences;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffSequencesSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffSequencesSpawned));
            BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffSequences));
            BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.BuffSequenceSystem/ProjectM.Sequencer.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Sequencer.RunWithoutJobSystem_00004E86$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00004E86$PostfixBurstDelegate");
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685731);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685732);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685733);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100685734);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.BuffSequenceSystem/ProjectM.Sequencer.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Sequencer.RunWithoutJobSystem_00004E86$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088803, XrefRangeEnd = 1088817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088817, XrefRangeEnd = 1088835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088835, XrefRangeEnd = 1088850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1088877, RefRangeEnd = 1088878, XrefRangeStart = 1088850, XrefRangeEnd = 1088877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00004E86$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685735);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685736);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685737);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685738);
          BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100685740);
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
            IL2CPP.il2cpp_field_static_get_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(BuffSequenceSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
