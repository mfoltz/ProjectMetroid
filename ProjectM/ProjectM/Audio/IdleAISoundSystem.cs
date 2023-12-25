// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.IdleAISoundSystem
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
using Unity.Transforms;

#nullable disable
namespace ProjectM.Audio
{
  public class IdleAISoundSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManagerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParameterArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME_STR;
    private static readonly System.IntPtr NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME;
    private static readonly System.IntPtr NativeFieldInfoPtr___MoveActiveIdleAISounds_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___MoveActiveIdleAISounds_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateIdleAISoundParameters_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateIdleAISoundParameters_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___StartIdleAISounds_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___StartIdleAISounds_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___IdleAISound_OnAggro_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___IdleAISound_OnAggro_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___IdleAISound_OnDeath_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___IdleAISound_OnDeath_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromIdleAIStop_Private_StudioEventStopModeEnum_IdleAIStudioEventStopModeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForMoveActiveIdleAISounds_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateIdleAISoundParameters_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForStartIdleAISounds_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForIdleAISound_OnAggro_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForIdleAISound_OnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;

    [CallerCount(0)]
    public unsafe StudioEventStopModeEnum ConvertFromIdleAIStop(
      IdleAIStudioEventStopModeEnum stopModeEnum)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &stopModeEnum;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr_ConvertFromIdleAIStop_Private_StudioEventStopModeEnum_IdleAIStudioEventStopModeEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(StudioEventStopModeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141644, XrefRangeEnd = 1141681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IdleAISoundSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141681, XrefRangeEnd = 1141941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IdleAISoundSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IdleAISoundSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141941, XrefRangeEnd = 1142041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IdleAISoundSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142063, RefRangeEnd = 1142064, XrefRangeStart = 1142041, XrefRangeEnd = 1142063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForMoveActiveIdleAISounds_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForMoveActiveIdleAISounds_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142089, RefRangeEnd = 1142090, XrefRangeStart = 1142064, XrefRangeEnd = 1142089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateIdleAISoundParameters_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateIdleAISoundParameters_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142090, XrefRangeEnd = 1142106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForStartIdleAISounds_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForStartIdleAISounds_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142128, RefRangeEnd = 1142129, XrefRangeStart = 1142106, XrefRangeEnd = 1142128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForIdleAISound_OnAggro_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForIdleAISound_OnAggro_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142154, RefRangeEnd = 1142155, XrefRangeStart = 1142129, XrefRangeEnd = 1142154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForIdleAISound_OnDeath_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForIdleAISound_OnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142159, RefRangeEnd = 1142160, XrefRangeStart = 1142155, XrefRangeEnd = 1142159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142164, RefRangeEnd = 1142165, XrefRangeStart = 1142160, XrefRangeEnd = 1142164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142169, RefRangeEnd = 1142170, XrefRangeStart = 1142165, XrefRangeEnd = 1142169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142174, RefRangeEnd = 1142175, XrefRangeStart = 1142170, XrefRangeEnd = 1142174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1142179, RefRangeEnd = 1142180, XrefRangeStart = 1142175, XrefRangeEnd = 1142179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IdleAISoundSystem()
    {
      Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (IdleAISoundSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr);
      IdleAISoundSystem.NativeFieldInfoPtr__StudioManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, nameof (_StudioManagerSystem));
      IdleAISoundSystem.NativeFieldInfoPtr__DefaultArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, nameof (_DefaultArchetype));
      IdleAISoundSystem.NativeFieldInfoPtr__ParameterArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, nameof (_ParameterArchetype));
      IdleAISoundSystem.NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME_STR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, nameof (MOVE_SPEED_PARAMETER_NAME_STR));
      IdleAISoundSystem.NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, nameof (MOVE_SPEED_PARAMETER_NAME));
      IdleAISoundSystem.NativeFieldInfoPtr___MoveActiveIdleAISounds_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>MoveActiveIdleAISounds_entityQuery");
      IdleAISoundSystem.NativeFieldInfoPtr___MoveActiveIdleAISounds_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>MoveActiveIdleAISounds_profilerMarker");
      IdleAISoundSystem.NativeFieldInfoPtr___UpdateIdleAISoundParameters_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>UpdateIdleAISoundParameters_entityQuery");
      IdleAISoundSystem.NativeFieldInfoPtr___UpdateIdleAISoundParameters_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>UpdateIdleAISoundParameters_profilerMarker");
      IdleAISoundSystem.NativeFieldInfoPtr___StartIdleAISounds_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>StartIdleAISounds_entityQuery");
      IdleAISoundSystem.NativeFieldInfoPtr___StartIdleAISounds_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>StartIdleAISounds_profilerMarker");
      IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnAggro_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>IdleAISound_OnAggro_entityQuery");
      IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnAggro_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>IdleAISound_OnAggro_profilerMarker");
      IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnDeath_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>IdleAISound_OnDeath_entityQuery");
      IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnDeath_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>IdleAISound_OnDeath_profilerMarker");
      IdleAISoundSystem.NativeMethodInfoPtr_ConvertFromIdleAIStop_Private_StudioEventStopModeEnum_IdleAIStudioEventStopModeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690265);
      IdleAISoundSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690266);
      IdleAISoundSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690267);
      IdleAISoundSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690268);
      IdleAISoundSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690270);
      IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForMoveActiveIdleAISounds_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690271);
      IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateIdleAISoundParameters_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690272);
      IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForStartIdleAISounds_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690273);
      IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForIdleAISound_OnAggro_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690274);
      IdleAISoundSystem.NativeMethodInfoPtr___GetEntityQuery_ForIdleAISound_OnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690275);
      IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690276);
      IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690277);
      IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690278);
      IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690279);
      IdleAISoundSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, 100690280);
    }

    public IdleAISoundSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StudioManagerSystem _StudioManagerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr__StudioManagerSystem));
        return pointer == System.IntPtr.Zero ? (StudioManagerSystem) null : new StudioManagerSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr__StudioManagerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityArchetype _DefaultArchetype
    {
      get
      {
        return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr__DefaultArchetype));
      }
      [param: In] set
      {
        *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr__DefaultArchetype)) = value;
      }
    }

    public unsafe EntityArchetype _ParameterArchetype
    {
      get
      {
        return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr__ParameterArchetype));
      }
      [param: In] set
      {
        *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr__ParameterArchetype)) = value;
      }
    }

    public static unsafe string MOVE_SPEED_PARAMETER_NAME_STR
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME_STR, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME_STR, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe FixedString64 MOVE_SPEED_PARAMETER_NAME
    {
      get
      {
        FixedString64 speedParameterName;
        IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME, (void*) &speedParameterName);
        return speedParameterName;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.NativeFieldInfoPtr_MOVE_SPEED_PARAMETER_NAME, (void*) &value);
      }
    }

    public unsafe EntityQuery __MoveActiveIdleAISounds_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___MoveActiveIdleAISounds_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___MoveActiveIdleAISounds_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __MoveActiveIdleAISounds_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___MoveActiveIdleAISounds_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___MoveActiveIdleAISounds_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateIdleAISoundParameters_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___UpdateIdleAISoundParameters_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___UpdateIdleAISoundParameters_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateIdleAISoundParameters_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___UpdateIdleAISoundParameters_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___UpdateIdleAISoundParameters_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __StartIdleAISounds_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___StartIdleAISounds_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___StartIdleAISounds_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __StartIdleAISounds_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___StartIdleAISounds_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___StartIdleAISounds_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __IdleAISound_OnAggro_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnAggro_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnAggro_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __IdleAISound_OnAggro_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnAggro_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnAggro_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __IdleAISound_OnDeath_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnDeath_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnDeath_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __IdleAISound_OnDeath_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnDeath_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IdleAISoundSystem.NativeFieldInfoPtr___IdleAISound_OnDeath_profilerMarker)) = value;
      }
    }

    public enum IdleAISoundEventType
    {
      PlayOnAggro,
      StopOnAggro,
      StopOnDeath,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct IdleAISoundEvent
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EventEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_EventType;
      [FieldOffset(0)]
      public Entity EventEntity;
      [FieldOffset(8)]
      public IdleAISoundSystem.IdleAISoundEventType EventType;

      static IdleAISoundEvent()
      {
        Il2CppClassPointerStore<IdleAISoundSystem.IdleAISoundEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, nameof (IdleAISoundEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.IdleAISoundEvent>.NativeClassPtr);
        IdleAISoundSystem.IdleAISoundEvent.NativeFieldInfoPtr_EventEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.IdleAISoundEvent>.NativeClassPtr, nameof (EventEntity));
        IdleAISoundSystem.IdleAISoundEvent.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.IdleAISoundEvent>.NativeClassPtr, nameof (EventType));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.IdleAISoundEvent>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/<>c__DisplayClass9_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass9_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_removeUninitialized;
      private static readonly System.IntPtr NativeFieldInfoPtr_soundEventQueue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_MoveVelocity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_IdleAISound_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_AggroConsumer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_Dead_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<Entity> removeUninitialized;
      [FieldOffset(24)]
      public NativeList<IdleAISoundSystem.IdleAISoundEvent> soundEventQueue;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref LocalToWorld localToWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref MoveVelocity moveVelocity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveVelocity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_MoveVelocity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(Entity entity, [In] ref IdleAISound idleAISound)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_IdleAISound_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref AggroConsumer aggroConsumer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_AggroConsumer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref Dead dead)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref dead;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_Dead_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr);
        IdleAISoundSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (entityManager));
        IdleAISoundSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_removeUninitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (removeUninitialized));
        IdleAISoundSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_soundEventQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (soundEventQueue));
        IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, 100690281);
        IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, 100690282);
        IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_MoveVelocity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, 100690283);
        IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_IdleAISound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, 100690284);
        IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_AggroConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, 100690285);
        IdleAISoundSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_Dead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, 100690286);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass9_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_MoveActiveIdleAISounds")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_MoveActiveIdleAISounds
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141040, XrefRangeEnd = 1141080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref LocalToWorld localToWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141080, XrefRangeEnd = 1141082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141094, RefRangeEnd = 1141095, XrefRangeStart = 1141082, XrefRangeEnd = 1141094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141097, RefRangeEnd = 1141098, XrefRangeStart = 1141095, XrefRangeEnd = 1141097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        IdleAISoundSystem componentSystem,
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141098, XrefRangeEnd = 1141102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141102, XrefRangeEnd = 1141108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_MoveActiveIdleAISounds()
      {
        Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>c__DisplayClass_MoveActiveIdleAISounds");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, nameof (entityManager));
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, nameof (_runtimes));
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690287);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690288);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690289);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690290);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690291);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690292);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690293);
        IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, 100690294);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISound;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISoundBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorld;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<IdleAISound> forParameter_idleAISound;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer> forParameter_idleAISoundBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorld;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1140953, RefRangeEnd = 1140954, XrefRangeStart = 1140943, XrefRangeEnd = 1140953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(IdleAISoundSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1140964, RefRangeEnd = 1140965, XrefRangeStart = 1140954, XrefRangeEnd = 1140964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISound));
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISoundBuffer));
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorld));
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, 100690295);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, 100690296);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISound;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISoundBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorld;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<IdleAISound>.Runtime runtime_idleAISound;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer>.Runtime runtime_idleAISoundBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorld;

          static Runtimes()
          {
            Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISound));
            IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISoundBuffer));
            IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorld));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_MoveActiveIdleAISounds/ProjectM.Audio.RunWithoutJobSystem_00005E00$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, "RunWithoutJobSystem_00005E00$PostfixBurstDelegate");
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690297);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690298);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690299);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690300);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_MoveActiveIdleAISounds/ProjectM.Audio.RunWithoutJobSystem_00005E00$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140965, XrefRangeEnd = 1140979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140979, XrefRangeEnd = 1140997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140997, XrefRangeEnd = 1141012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141039, RefRangeEnd = 1141040, XrefRangeStart = 1141012, XrefRangeEnd = 1141039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds>.NativeClassPtr, "RunWithoutJobSystem_00005E00$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690301);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690302);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690303);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690304);
          IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690306);
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
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_MoveActiveIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_UpdateIdleAISoundParameters")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateIdleAISoundParameters
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_MoveVelocity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141205, XrefRangeEnd = 1141230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref MoveVelocity moveVelocity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveVelocity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_MoveVelocity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141230, XrefRangeEnd = 1141232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141244, RefRangeEnd = 1141245, XrefRangeStart = 1141232, XrefRangeEnd = 1141244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141247, RefRangeEnd = 1141248, XrefRangeStart = 1141245, XrefRangeEnd = 1141247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        IdleAISoundSystem componentSystem,
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141248, XrefRangeEnd = 1141252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141252, XrefRangeEnd = 1141258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateIdleAISoundParameters()
      {
        Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateIdleAISoundParameters");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, nameof (entityManager));
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, nameof (_runtimes));
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_MoveVelocity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690307);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690308);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690309);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690310);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690311);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690312);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690313);
        IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, 100690314);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISound;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISoundBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_moveVelocity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<IdleAISound> forParameter_idleAISound;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer> forParameter_idleAISoundBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<MoveVelocity> forParameter_moveVelocity;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141118, RefRangeEnd = 1141119, XrefRangeStart = 1141108, XrefRangeEnd = 1141118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(IdleAISoundSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141129, RefRangeEnd = 1141130, XrefRangeStart = 1141119, XrefRangeEnd = 1141129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISound));
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISoundBuffer));
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_moveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_moveVelocity));
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, 100690315);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, 100690316);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISound;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISoundBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_moveVelocity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<IdleAISound>.Runtime runtime_idleAISound;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer>.Runtime runtime_idleAISoundBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<MoveVelocity>.Runtime runtime_moveVelocity;

          static Runtimes()
          {
            Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISound));
            IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISoundBuffer));
            IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_moveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_moveVelocity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_UpdateIdleAISoundParameters/ProjectM.Audio.RunWithoutJobSystem_00005E09$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, "RunWithoutJobSystem_00005E09$PostfixBurstDelegate");
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690317);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690318);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690319);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690320);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_UpdateIdleAISoundParameters/ProjectM.Audio.RunWithoutJobSystem_00005E09$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141130, XrefRangeEnd = 1141144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141144, XrefRangeEnd = 1141162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141162, XrefRangeEnd = 1141177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141204, RefRangeEnd = 1141205, XrefRangeStart = 1141177, XrefRangeEnd = 1141204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters>.NativeClassPtr, "RunWithoutJobSystem_00005E09$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690321);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690322);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690323);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690324);
          IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690326);
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
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_UpdateIdleAISoundParameters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_StartIdleAISounds")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_StartIdleAISounds
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_removeUninitialized;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<Entity> removeUninitialized;
      [FieldOffset(24)]
      public IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141343, XrefRangeEnd = 1141349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref IdleAISound idleAISound)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980573, RefRangeEnd = 980586, XrefRangeStart = 980573, XrefRangeEnd = 980586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 980586, RefRangeEnd = 980599, XrefRangeStart = 980586, XrefRangeEnd = 980599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141349, XrefRangeEnd = 1141351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141357, RefRangeEnd = 1141358, XrefRangeStart = 1141351, XrefRangeEnd = 1141357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141360, RefRangeEnd = 1141361, XrefRangeStart = 1141358, XrefRangeEnd = 1141360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        IdleAISoundSystem componentSystem,
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141361, XrefRangeEnd = 1141365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141365, XrefRangeEnd = 1141371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_StartIdleAISounds()
      {
        Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>c__DisplayClass_StartIdleAISounds");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, nameof (entityManager));
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_removeUninitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, nameof (removeUninitialized));
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, nameof (_runtimes));
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690327);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690328);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690329);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690330);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690331);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690332);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690333);
        IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, 100690334);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISound;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<IdleAISound> forParameter_idleAISound;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141262, RefRangeEnd = 1141263, XrefRangeStart = 1141258, XrefRangeEnd = 1141262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(IdleAISoundSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141267, RefRangeEnd = 1141268, XrefRangeStart = 1141263, XrefRangeEnd = 1141267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISound));
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, 100690335);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, 100690336);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISound;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<IdleAISound>.Runtime runtime_idleAISound;

          static Runtimes()
          {
            Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISound));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_StartIdleAISounds/ProjectM.Audio.RunWithoutJobSystem_00005E12$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, "RunWithoutJobSystem_00005E12$PostfixBurstDelegate");
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690337);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690338);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690339);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690340);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_StartIdleAISounds/ProjectM.Audio.RunWithoutJobSystem_00005E12$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141268, XrefRangeEnd = 1141282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141282, XrefRangeEnd = 1141300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141300, XrefRangeEnd = 1141315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141342, RefRangeEnd = 1141343, XrefRangeStart = 1141315, XrefRangeEnd = 1141342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds>.NativeClassPtr, "RunWithoutJobSystem_00005E12$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690341);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690342);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690343);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690344);
          IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690346);
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
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_StartIdleAISounds.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_IdleAISound_OnAggro")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_IdleAISound_OnAggro
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_soundEventQueue;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_AggroConsumer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<IdleAISoundSystem.IdleAISoundEvent> soundEventQueue;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141468, XrefRangeEnd = 1141481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref AggroConsumer aggroConsumer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_AggroConsumer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1141481, RefRangeEnd = 1141483, XrefRangeStart = 1141481, XrefRangeEnd = 1141481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1141483, RefRangeEnd = 1141485, XrefRangeStart = 1141483, XrefRangeEnd = 1141483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141485, XrefRangeEnd = 1141487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141499, RefRangeEnd = 1141500, XrefRangeStart = 1141487, XrefRangeEnd = 1141499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141502, RefRangeEnd = 1141503, XrefRangeStart = 1141500, XrefRangeEnd = 1141502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        IdleAISoundSystem componentSystem,
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141503, XrefRangeEnd = 1141507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141507, XrefRangeEnd = 1141513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_IdleAISound_OnAggro()
      {
        Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>c__DisplayClass_IdleAISound_OnAggro");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_soundEventQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, nameof (soundEventQueue));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, nameof (entityManager));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, nameof (_runtimes));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_AggroConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690347);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690348);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690349);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690350);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690351);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690352);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690353);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, 100690354);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISound;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISoundBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_aggroConsumer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<IdleAISound> forParameter_idleAISound;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer> forParameter_idleAISoundBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<AggroConsumer> forParameter_aggroConsumer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141381, RefRangeEnd = 1141382, XrefRangeStart = 1141371, XrefRangeEnd = 1141381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(IdleAISoundSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141392, RefRangeEnd = 1141393, XrefRangeStart = 1141382, XrefRangeEnd = 1141392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISound));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISoundBuffer));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_aggroConsumer));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, 100690355);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, 100690356);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISound;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISoundBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_aggroConsumer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<IdleAISound>.Runtime runtime_idleAISound;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer>.Runtime runtime_idleAISoundBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<AggroConsumer>.Runtime runtime_aggroConsumer;

          static Runtimes()
          {
            Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISound));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISoundBuffer));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_aggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_aggroConsumer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_IdleAISound_OnAggro/ProjectM.Audio.RunWithoutJobSystem_00005E1B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, "RunWithoutJobSystem_00005E1B$PostfixBurstDelegate");
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690357);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690358);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690359);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690360);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_IdleAISound_OnAggro/ProjectM.Audio.RunWithoutJobSystem_00005E1B$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141393, XrefRangeEnd = 1141407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141407, XrefRangeEnd = 1141425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141425, XrefRangeEnd = 1141440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141467, RefRangeEnd = 1141468, XrefRangeStart = 1141440, XrefRangeEnd = 1141467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro>.NativeClassPtr, "RunWithoutJobSystem_00005E1B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690361);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690362);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690363);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690364);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690366);
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
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnAggro.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_IdleAISound_OnDeath")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_IdleAISound_OnDeath
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_soundEventQueue;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_Dead_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<IdleAISoundSystem.IdleAISoundEvent> soundEventQueue;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141610, XrefRangeEnd = 1141616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref IdleAISound idleAISound,
        [In] ref DynamicBuffer<IdleAISoundBuffer> idleAISoundBuffer,
        [In] ref Dead dead)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISound;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref idleAISoundBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref dead;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_Dead_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1141481, RefRangeEnd = 1141483, XrefRangeStart = 1141481, XrefRangeEnd = 1141483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1141483, RefRangeEnd = 1141485, XrefRangeStart = 1141483, XrefRangeEnd = 1141485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141616, XrefRangeEnd = 1141618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141630, RefRangeEnd = 1141631, XrefRangeStart = 1141618, XrefRangeEnd = 1141630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1141633, RefRangeEnd = 1141634, XrefRangeStart = 1141631, XrefRangeEnd = 1141633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        IdleAISoundSystem componentSystem,
        ref IdleAISoundSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141634, XrefRangeEnd = 1141638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141638, XrefRangeEnd = 1141644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_IdleAISound_OnDeath()
      {
        Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem>.NativeClassPtr, "<>c__DisplayClass_IdleAISound_OnDeath");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_soundEventQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, nameof (soundEventQueue));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, nameof (entityManager));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, nameof (_runtimes));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_IdleAISound_byref_DynamicBuffer_1_IdleAISoundBuffer_byref_Dead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690367);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690368);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690369);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690370);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690371);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690372);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690373);
        IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, 100690374);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISound;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_idleAISoundBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dead;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<IdleAISound> forParameter_idleAISound;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer> forParameter_idleAISoundBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<Dead> forParameter_dead;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141523, RefRangeEnd = 1141524, XrefRangeStart = 1141513, XrefRangeEnd = 1141523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(IdleAISoundSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141534, RefRangeEnd = 1141535, XrefRangeStart = 1141524, XrefRangeEnd = 1141534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISound));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_idleAISoundBuffer));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dead));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_IdleAISoundSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, 100690375);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, 100690376);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISound;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_idleAISoundBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dead;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<IdleAISound>.Runtime runtime_idleAISound;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<IdleAISoundBuffer>.Runtime runtime_idleAISoundBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Dead>.Runtime runtime_dead;

          static Runtimes()
          {
            Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISound));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_idleAISoundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_idleAISoundBuffer));
            IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dead));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_IdleAISound_OnDeath/ProjectM.Audio.RunWithoutJobSystem_00005E24$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, "RunWithoutJobSystem_00005E24$PostfixBurstDelegate");
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690377);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690378);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690379);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690380);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.IdleAISoundSystem/ProjectM.Audio.<>c__DisplayClass_IdleAISound_OnDeath/ProjectM.Audio.RunWithoutJobSystem_00005E24$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141535, XrefRangeEnd = 1141549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141549, XrefRangeEnd = 1141567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141567, XrefRangeEnd = 1141582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1141609, RefRangeEnd = 1141610, XrefRangeStart = 1141582, XrefRangeEnd = 1141609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath>.NativeClassPtr, "RunWithoutJobSystem_00005E24$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690381);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690382);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690383);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690384);
          IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690386);
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
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(IdleAISoundSystem.__c__DisplayClass_IdleAISound_OnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
