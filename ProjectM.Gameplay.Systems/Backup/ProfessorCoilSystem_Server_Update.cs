// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilSystem_Server_Update
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
using Unity.Mathematics;
using Unity.Physics;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class ProfessorCoilSystem_Server_Update : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__HandledHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateEvents_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateBeams_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateBeams_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateManagers_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateManagers_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateBeams_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateManagers_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413825, XrefRangeEnd = 1413850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413850, XrefRangeEnd = 1413856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413856, XrefRangeEnd = 1413910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProfessorCoilSystem_Server_Update()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413910, XrefRangeEnd = 1413960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1413982, RefRangeEnd = 1413983, XrefRangeStart = 1413960, XrefRangeEnd = 1413982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr___GetEntityQuery_ForUpdateEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414008, RefRangeEnd = 1414009, XrefRangeStart = 1413983, XrefRangeEnd = 1414008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateBeams_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr___GetEntityQuery_ForUpdateBeams_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414031, RefRangeEnd = 1414032, XrefRangeStart = 1414009, XrefRangeEnd = 1414031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateManagers_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr___GetEntityQuery_ForUpdateManagers_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414033, RefRangeEnd = 1414034, XrefRangeStart = 1414032, XrefRangeEnd = 1414033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414035, RefRangeEnd = 1414036, XrefRangeStart = 1414034, XrefRangeEnd = 1414035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414037, RefRangeEnd = 1414038, XrefRangeStart = 1414036, XrefRangeEnd = 1414037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414042, RefRangeEnd = 1414043, XrefRangeStart = 1414038, XrefRangeEnd = 1414042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414047, RefRangeEnd = 1414048, XrefRangeStart = 1414043, XrefRangeEnd = 1414047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1414052, RefRangeEnd = 1414053, XrefRangeStart = 1414048, XrefRangeEnd = 1414052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProfessorCoilSystem_Server_Update()
    {
      Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ProfessorCoilSystem_Server_Update));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr);
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (_PostUpdateBarrier));
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (_CollisionSystem));
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__CastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (_CastHits));
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__HandledHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (_HandledHits));
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (_ServerTimeAccessor));
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>UpdateEvents_entityQuery");
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>UpdateEvents_profilerMarker");
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateBeams_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>UpdateBeams_entityQuery");
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateBeams_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>UpdateBeams_profilerMarker");
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateManagers_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>UpdateManagers_entityQuery");
      ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateManagers_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>UpdateManagers_profilerMarker");
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668813);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668814);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668815);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668816);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668817);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr___GetEntityQuery_ForUpdateEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668818);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr___GetEntityQuery_ForUpdateBeams_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668819);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr___GetEntityQuery_ForUpdateManagers_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668820);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668821);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668822);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668823);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668824);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668825);
      ProfessorCoilSystem_Server_Update.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, 100668826);
    }

    public ProfessorCoilSystem_Server_Update(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<ColliderCastHit> _CastHits
    {
      get
      {
        return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__CastHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__CastHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _HandledHits
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__HandledHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__HandledHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __UpdateEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateEvents_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateBeams_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateBeams_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateBeams_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateBeams_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateBeams_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateBeams_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateManagers_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateManagers_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateManagers_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateManagers_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateManagers_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.NativeFieldInfoPtr___UpdateManagers_profilerMarker)) = value;
      }
    }

    public class ProfessorCoilSystem_Server_Destroy : SystemBase
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__NewDestroyedManagersQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr__NewDestroyedEventsQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412912, XrefRangeEnd = 1412930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412930, XrefRangeEnd = 1412971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ProfessorCoilSystem_Server_Destroy()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412971, XrefRangeEnd = 1413035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413035, XrefRangeEnd = 1413051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413051, XrefRangeEnd = 1413067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413071, RefRangeEnd = 1413072, XrefRangeStart = 1413067, XrefRangeEnd = 1413071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413076, RefRangeEnd = 1413077, XrefRangeStart = 1413072, XrefRangeEnd = 1413076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ProfessorCoilSystem_Server_Destroy()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (ProfessorCoilSystem_Server_Destroy));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr__NewDestroyedManagersQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, nameof (_NewDestroyedManagersQuery));
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr__NewDestroyedEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, nameof (_NewDestroyedEventsQuery));
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668827);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668828);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668829);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668830);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668831);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668832);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668833);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, 100668834);
      }

      public ProfessorCoilSystem_Server_Destroy(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe EntityQuery _NewDestroyedManagersQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr__NewDestroyedManagersQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr__NewDestroyedManagersQuery)) = value;
        }
      }

      public unsafe EntityQuery _NewDestroyedEventsQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr__NewDestroyedEventsQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr__NewDestroyedEventsQuery)) = value;
        }
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
        }
      }

      public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
      {
        get
        {
          return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
        }
        [param: In] set
        {
          *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
        }
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
        }
      }

      public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
      {
        get
        {
          return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
        }
        [param: In] set
        {
          *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Server_Destroy/<>c__DisplayClass3_0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass3_0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_newDestroyedManagers;
        private static readonly System.IntPtr NativeFieldInfoPtr_ecb;
        private static readonly System.IntPtr NativeFieldInfoPtr_newDestroyedEvents;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilEvent_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_0;
        [FieldOffset(0)]
        public NativeArray<Entity> newDestroyedManagers;
        [FieldOffset(16)]
        public EntityCommandBuffer ecb;
        [FieldOffset(32)]
        public NativeArray<Entity> newDestroyedEvents;

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe __c__DisplayClass3_0()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void _OnUpdate_b__0(Entity entity, [In] ref ProfessorCoilEvent evt)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void _OnUpdate_b__1(
          Entity entity,
          [In] ref ProfessorCoilBeam_State_Server stateServer)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateServer;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass3_0()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, "<>c__DisplayClass3_0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeFieldInfoPtr_newDestroyedManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr, nameof (newDestroyedManagers));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeFieldInfoPtr_ecb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr, nameof (ecb));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeFieldInfoPtr_newDestroyedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr, nameof (newDestroyedEvents));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr, 100668835);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr, 100668836);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr, 100668837);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Server_Destroy/<>c__DisplayClass_OnUpdate_LambdaJob0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_newDestroyedManagers;
        private static readonly System.IntPtr NativeFieldInfoPtr_ecb;
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
        [FieldOffset(0)]
        public NativeArray<Entity> newDestroyedManagers;
        [FieldOffset(16)]
        public EntityCommandBuffer ecb;
        [FieldOffset(32)]
        public ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(72)]
        public unsafe ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412769, XrefRangeEnd = 1412775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(Entity entity, [In] ref ProfessorCoilEvent evt)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(15)]
        [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void ReadFromDisplayClass(
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(17)]
        [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void WriteToDisplayClass(
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412775, XrefRangeEnd = 1412777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412783, RefRangeEnd = 1412784, XrefRangeStart = 1412777, XrefRangeEnd = 1412783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412786, RefRangeEnd = 1412787, XrefRangeStart = 1412784, XrefRangeEnd = 1412786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy componentSystem,
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412787, XrefRangeEnd = 1412791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void RunWithoutJobSystem(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412791, XrefRangeEnd = 1412797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob0()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_newDestroyedManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (newDestroyedManagers));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_ecb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (ecb));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668838);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668839);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668840);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668841);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668842);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668843);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668844);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668845);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity forParameter_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent> forParameter_evt;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1412688, RefRangeEnd = 1412689, XrefRangeStart = 1412684, XrefRangeEnd = 1412688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1412693, RefRangeEnd = 1412694, XrefRangeStart = 1412689, XrefRangeEnd = 1412693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668846);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668847);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
            [FieldOffset(8)]
            public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent>.Runtime runtime_evt;

            static Runtimes()
            {
              Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }

        [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Server_Destroy/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00000D1C$PostfixBurstDelegate")]
        public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
        {
          private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

          [CallerCount(5227)]
          [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static MulticastDelegateNPublicSealedVoObObUnique()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000D1C$PostfixBurstDelegate");
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668848);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668849);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668850);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668851);
          }

          public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }
        }

        [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Server_Destroy/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00000D1C$BurstDirectCall")]
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
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412694, XrefRangeEnd = 1412708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) ref _param0;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412708, XrefRangeEnd = 1412726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe System.IntPtr GetFunctionPointer()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412726, XrefRangeEnd = 1412741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Constructor()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(10560)]
          [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Initialize()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1412768, RefRangeEnd = 1412769, XrefRangeStart = 1412741, XrefRangeEnd = 1412768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static ObjectNInternalAbstractSealedInPoDeInUnique()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000D1C$BurstDirectCall");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668852);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668853);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668854);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668855);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668857);
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
              IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
              return pointer;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
            }
          }

          public static unsafe System.IntPtr DeferredCompilation
          {
            get
            {
              System.IntPtr deferredCompilation;
              IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
              return deferredCompilation;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
            }
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Server_Destroy/<>c__DisplayClass_OnUpdate_LambdaJob1")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob1
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_newDestroyedEvents;
        private static readonly System.IntPtr NativeFieldInfoPtr_ecb;
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_byref___c__DisplayClass3_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
        [FieldOffset(0)]
        public NativeArray<Entity> newDestroyedEvents;
        [FieldOffset(16)]
        public EntityCommandBuffer ecb;
        [FieldOffset(32)]
        public ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(72)]
        public unsafe ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412882, XrefRangeEnd = 1412888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(
          Entity entity,
          [In] ref ProfessorCoilBeam_State_Server stateServer)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateServer;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412888, RefRangeEnd = 1412889, XrefRangeStart = 1412888, XrefRangeEnd = 1412888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void ReadFromDisplayClass(
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412889, RefRangeEnd = 1412890, XrefRangeStart = 1412889, XrefRangeEnd = 1412889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void WriteToDisplayClass(
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412890, XrefRangeEnd = 1412892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412898, RefRangeEnd = 1412899, XrefRangeStart = 1412892, XrefRangeEnd = 1412898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412901, RefRangeEnd = 1412902, XrefRangeStart = 1412899, XrefRangeEnd = 1412901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy componentSystem,
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass3_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412902, XrefRangeEnd = 1412906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void RunWithoutJobSystem(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412906, XrefRangeEnd = 1412912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob1()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_newDestroyedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (newDestroyedEvents));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_ecb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (ecb));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668858);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668859);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668860);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668861);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668862);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668863);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668864);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100668865);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_stateServer;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity forParameter_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Server> forParameter_stateServer;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1412801, RefRangeEnd = 1412802, XrefRangeStart = 1412797, XrefRangeEnd = 1412801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1412806, RefRangeEnd = 1412807, XrefRangeStart = 1412802, XrefRangeEnd = 1412806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_stateServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_stateServer));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Destroy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100668866);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100668867);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_stateServer;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
            [FieldOffset(8)]
            public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Server>.Runtime runtime_stateServer;

            static Runtimes()
            {
              Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_stateServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_stateServer));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }

        [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Server_Destroy/<>c__DisplayClass_OnUpdate_LambdaJob1/RunWithoutJobSystem_00000D25$PostfixBurstDelegate")]
        public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
        {
          private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

          [CallerCount(5227)]
          [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static MulticastDelegateNPublicSealedVoObObUnique()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000D25$PostfixBurstDelegate");
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668868);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668869);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668870);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668871);
          }

          public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }
        }

        [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Server_Destroy/<>c__DisplayClass_OnUpdate_LambdaJob1/RunWithoutJobSystem_00000D25$BurstDirectCall")]
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
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412807, XrefRangeEnd = 1412821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) ref _param0;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412821, XrefRangeEnd = 1412839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe System.IntPtr GetFunctionPointer()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412839, XrefRangeEnd = 1412854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Constructor()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(10560)]
          [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Initialize()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1412881, RefRangeEnd = 1412882, XrefRangeStart = 1412854, XrefRangeEnd = 1412881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static ObjectNInternalAbstractSealedInPoDeInUnique()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000D25$BurstDirectCall");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668872);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668873);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668874);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668875);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668877);
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
              IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
              return pointer;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
            }
          }

          public static unsafe System.IntPtr DeferredCompilation
          {
            get
            {
              System.IntPtr deferredCompilation;
              IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
              return deferredCompilation;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Server_Destroy.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
            }
          }
        }
      }
    }

    public class ProfessorCoilSystem_Client : SystemBase
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__SequencesToSpawn;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
      private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413207, XrefRangeEnd = 1413215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413215, XrefRangeEnd = 1413218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnDestroy()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413218, XrefRangeEnd = 1413294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnUpdate()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(105)]
      [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ProfessorCoilSystem_Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413294, XrefRangeEnd = 1413312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void OnCreateForCompiler()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413334, RefRangeEnd = 1413335, XrefRangeStart = 1413312, XrefRangeEnd = 1413334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
        ComponentSystemBase componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413339, RefRangeEnd = 1413340, XrefRangeStart = 1413335, XrefRangeEnd = 1413339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ProfessorCoilSystem_Client()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, nameof (ProfessorCoilSystem_Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, nameof (_PrefabCollectionSystem));
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr__SequencesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, nameof (_SequencesToSpawn));
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, 100668878);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, 100668879);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, 100668880);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, 100668881);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, 100668882);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, 100668883);
        ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, 100668884);
      }

      public ProfessorCoilSystem_Client(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabCollectionSystem _PrefabCollectionSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr__PrefabCollectionSystem));
          return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeQueue<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData> _SequencesToSpawn
      {
        get
        {
          return *(NativeQueue<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr__SequencesToSpawn));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr__SequencesToSpawn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
        }
      }

      public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
      {
        get
        {
          return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
        }
        [param: In] set
        {
          *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct SequenceSpawnData
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_Start;
        private static readonly System.IntPtr NativeFieldInfoPtr_End;
        private static readonly System.IntPtr NativeFieldInfoPtr_Width;
        private static readonly System.IntPtr NativeFieldInfoPtr_State;
        [FieldOffset(0)]
        public Entity Entity;
        [FieldOffset(8)]
        public float3 Start;
        [FieldOffset(20)]
        public float3 End;
        [FieldOffset(32)]
        public float Width;
        [FieldOffset(36)]
        public ProfessorCoilBeamState State;

        static SequenceSpawnData()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, nameof (SequenceSpawnData));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr, nameof (Entity));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr, nameof (Start));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr, nameof (End));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr, nameof (Width));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr, nameof (State));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Client/<>c__DisplayClass5_0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass5_0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_sequencesToSpawn;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilBeam_Client_byref_ProfessorCoilBeam_State_Shared_byref_Age_0;
        [FieldOffset(0)]
        public NativeQueue<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData> sequencesToSpawn;

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe __c__DisplayClass5_0()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void _OnUpdate_b__0(
          Entity entity,
          [In] ref ProfessorCoilBeam_Client client,
          [In] ref ProfessorCoilBeam_State_Shared stateShared,
          [In] ref Age age)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref client;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateShared;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilBeam_Client_byref_ProfessorCoilBeam_State_Shared_byref_Age_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass5_0()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, "<>c__DisplayClass5_0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0.NativeFieldInfoPtr_sequencesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, nameof (sequencesToSpawn));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, 100668885);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilBeam_Client_byref_ProfessorCoilBeam_State_Shared_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, 100668886);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Client/<>c__DisplayClass_OnUpdate_LambdaJob0")]
      [StructLayout(LayoutKind.Explicit)]
      public struct __c__DisplayClass_OnUpdate_LambdaJob0
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_sequencesToSpawn;
        private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
        private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
        private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
        private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_Client_byref_ProfessorCoilBeam_State_Shared_byref_Age_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Client_byref___c__DisplayClass5_0_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
        [FieldOffset(0)]
        public NativeQueue<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.SequenceSpawnData> sequencesToSpawn;
        [FieldOffset(24)]
        public ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
        [FieldOffset(128)]
        public unsafe ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413174, XrefRangeEnd = 1413179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void OriginalLambdaBody(
          Entity entity,
          [In] ref ProfessorCoilBeam_Client client,
          [In] ref ProfessorCoilBeam_State_Shared stateShared,
          [In] ref Age age)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) &entity;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref client;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateShared;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_Client_byref_ProfessorCoilBeam_State_Shared_byref_Age_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(5)]
        [CachedScanResults(RefRangeStart = 743279, RefRangeEnd = 743284, XrefRangeStart = 743279, XrefRangeEnd = 743284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void ReadFromDisplayClass(
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 981741, RefRangeEnd = 981745, XrefRangeStart = 981741, XrefRangeEnd = 981745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void WriteToDisplayClass(
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413179, XrefRangeEnd = 1413181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413193, RefRangeEnd = 1413194, XrefRangeStart = 1413181, XrefRangeEnd = 1413193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void IterateEntities(
          ref ArchetypeChunk chunk,
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref chunk;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413196, RefRangeEnd = 1413197, XrefRangeStart = 1413194, XrefRangeEnd = 1413196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client componentSystem,
          ref ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass5_0 displayClass)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Client_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413197, XrefRangeEnd = 1413201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void RunWithoutJobSystem(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413201, XrefRangeEnd = 1413207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static __c__DisplayClass_OnUpdate_LambdaJob0()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_sequencesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (sequencesToSpawn));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_Client_byref_ProfessorCoilBeam_State_Shared_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668887);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668888);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668889);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668890);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668891);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Client_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668892);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668893);
          ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668894);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
        {
          get
          {
            System.IntPtr num;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
            System.IntPtr pointer = num;
            return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LambdaParameterValueProviders
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_client;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_stateShared;
          private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_age;
          private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Client_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity forParameter_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_Client> forParameter_client;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Shared> forParameter_stateShared;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<Age> forParameter_age;

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1413087, RefRangeEnd = 1413088, XrefRangeStart = 1413077, XrefRangeEnd = 1413087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe void ScheduleTimeInitialize(
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client componentSystem)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1413098, RefRangeEnd = 1413099, XrefRangeStart = 1413088, XrefRangeEnd = 1413098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
            ref ArchetypeChunk p0,
            int p1,
            int p2)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[3];
            numPtr[0] = (System.IntPtr) ref p0;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
          }

          static LambdaParameterValueProviders()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_client));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_stateShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_stateShared));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_age));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668895);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668896);
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
          }

          [StructLayout(LayoutKind.Explicit)]
          public struct Runtimes
          {
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_client;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_stateShared;
            private static readonly System.IntPtr NativeFieldInfoPtr_runtime_age;
            [FieldOffset(0)]
            public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
            [FieldOffset(8)]
            public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_Client>.Runtime runtime_client;
            [FieldOffset(16)]
            public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Shared>.Runtime runtime_stateShared;
            [FieldOffset(24)]
            public LambdaParameterValueProvider_IComponentData<Age>.Runtime runtime_age;

            static Runtimes()
            {
              Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_client));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_stateShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_stateShared));
              ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_age));
            }

            public Il2CppSystem.Object BoxIl2CppObject()
            {
              return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
            }
          }
        }

        [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Client/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00000D36$PostfixBurstDelegate")]
        public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
        {
          private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
          private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

          [CallerCount(5227)]
          [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
            : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static MulticastDelegateNPublicSealedVoObObUnique()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000D36$PostfixBurstDelegate");
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668897);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668898);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668899);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668900);
          }

          public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
            : base(pointer)
          {
          }
        }

        [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProfessorCoilSystem_Client/<>c__DisplayClass_OnUpdate_LambdaJob0/RunWithoutJobSystem_00000D36$BurstDirectCall")]
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
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413099, XrefRangeEnd = 1413113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[1];
            numPtr[0] = (System.IntPtr) ref _param0;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413113, XrefRangeEnd = 1413131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe System.IntPtr GetFunctionPointer()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
          }

          [CallerCount(0)]
          [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413131, XrefRangeEnd = 1413146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Constructor()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(10560)]
          [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Initialize()
          {
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          [CallerCount(1)]
          [CachedScanResults(RefRangeStart = 1413173, RefRangeEnd = 1413174, XrefRangeStart = 1413146, XrefRangeEnd = 1413173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
          public static unsafe void Invoke(
            ArchetypeChunkIterator* archetypeChunkIterator,
            void* jobData)
          {
            System.IntPtr* numPtr = stackalloc System.IntPtr[2];
            numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
            *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
            System.IntPtr exc;
            IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
          }

          static ObjectNInternalAbstractSealedInPoDeInUnique()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000D36$BurstDirectCall");
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668901);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668902);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668903);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668904);
            ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668906);
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
              IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
              return pointer;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
            }
          }

          public static unsafe System.IntPtr DeferredCompilation
          {
            get
            {
              System.IntPtr deferredCompilation;
              IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
              return deferredCompilation;
            }
            [param: In] set
            {
              IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.ProfessorCoilSystem_Client.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Age_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilManagerHitElement_byref_ProfessorCoilManager_byref_Team_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref ProfessorCoilEvent evt,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        [In] ref Age age)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Age_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        ref DynamicBuffer<ProfessorCoilManagerHitElement> hitBuffer,
        ref ProfessorCoilManager manager,
        [In] ref Team team)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilManagerHitElement_byref_ProfessorCoilManager_byref_Team_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, nameof (collisionWorld));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, nameof (entityManager));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, nameof (serverTime));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, nameof (prefabLookupMap));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, 100668907);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, 100668908);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilManagerHitElement_byref_ProfessorCoilManager_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, 100668909);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe ProfessorCoilSystem_Server_Update __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ProfessorCoilSystem_Server_Update) null : new ProfessorCoilSystem_Server_Update(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe ServerTime serverTime
      {
        get
        {
          return *(ServerTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(ServerTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/<>c__DisplayClass8_1")]
    public sealed class __c__DisplayClass8_1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_casthits;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_byref_ProfessorCoilBeam_State_Shared_byref_ProfessorCoilBeam_Data_Server_byref_Age_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref ProfessorCoilBeam_State_Server stateServer,
        ref ProfessorCoilBeam_State_Shared stateShared,
        [In] ref ProfessorCoilBeam_Data_Server dataServer,
        [In] ref Age age)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref dataServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_byref_ProfessorCoilBeam_State_Shared_byref_ProfessorCoilBeam_Data_Server_byref_Age_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_1()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>c__DisplayClass8_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeFieldInfoPtr_casthits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr, nameof (casthits));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr, "CS$<>8__locals1");
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr, 100668910);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_byref_ProfessorCoilBeam_State_Shared_byref_ProfessorCoilBeam_Data_Server_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr, 100668911);
      }

      public __c__DisplayClass8_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1>.NativeClassPtr, data));
      }

      public unsafe NativeList<ColliderCastHit> casthits
      {
        get
        {
          return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeFieldInfoPtr_casthits));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeFieldInfoPtr_casthits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
          return new ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilPairElement_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Age_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer postUpdateCommandBuffer;
      [FieldOffset(16)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_0;
      [FieldOffset(48)]
      public BufferFromEntity<ProfessorCoilPairElement> _BufferFromEntity_ProfessorCoilPairElement_1;
      [FieldOffset(88)]
      public ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(200)]
      public unsafe ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413437, XrefRangeEnd = 1413450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref ProfessorCoilEvent evt,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        [In] ref Age age)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Age_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413450, XrefRangeEnd = 1413452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413464, RefRangeEnd = 1413465, XrefRangeStart = 1413452, XrefRangeEnd = 1413464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413473, RefRangeEnd = 1413474, XrefRangeStart = 1413465, XrefRangeEnd = 1413473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ProfessorCoilSystem_Server_Update componentSystem,
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413474, XrefRangeEnd = 1413478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413478, XrefRangeEnd = 1413484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateEvents()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>c__DisplayClass_UpdateEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_0));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilPairElement_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (_BufferFromEntity_ProfessorCoilPairElement_1));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (_runtimes));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668912);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668913);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668914);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668915);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668916);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668917);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668918);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, 100668919);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_coilPairs;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_age;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent> forParameter_evt;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement> forParameter_coilPairs;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<Age> forParameter_age;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413350, RefRangeEnd = 1413351, XrefRangeStart = 1413340, XrefRangeEnd = 1413350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ProfessorCoilSystem_Server_Update componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413361, RefRangeEnd = 1413362, XrefRangeStart = 1413351, XrefRangeEnd = 1413361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_coilPairs));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_age));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, 100668920);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, 100668921);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_coilPairs;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_age;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent>.Runtime runtime_evt;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement>.Runtime runtime_coilPairs;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Age>.Runtime runtime_age;

          static Runtimes()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_coilPairs));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_age));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateEvents/ProjectM.RunWithoutJobSystem_00000D44$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, "RunWithoutJobSystem_00000D44$PostfixBurstDelegate");
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668922);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668923);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668924);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668925);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateEvents/ProjectM.RunWithoutJobSystem_00000D44$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413362, XrefRangeEnd = 1413376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413376, XrefRangeEnd = 1413394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413394, XrefRangeEnd = 1413409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413436, RefRangeEnd = 1413437, XrefRangeStart = 1413409, XrefRangeEnd = 1413436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents>.NativeClassPtr, "RunWithoutJobSystem_00000D44$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668926);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668927);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668928);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668929);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668931);
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
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateBeams")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateBeams
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_casthits;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_byref_ProfessorCoilBeam_State_Shared_byref_ProfessorCoilBeam_Data_Server_byref_Age_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<ColliderCastHit> casthits;
      [FieldOffset(16)]
      public CollisionWorld collisionWorld;
      [FieldOffset(360)]
      public EntityManager entityManager;
      [FieldOffset(368)]
      public ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(504)]
      public unsafe ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413587, XrefRangeEnd = 1413626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref ProfessorCoilBeam_State_Server stateServer,
        ref ProfessorCoilBeam_State_Shared stateShared,
        [In] ref ProfessorCoilBeam_Data_Server dataServer,
        [In] ref Age age)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref stateShared;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref dataServer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_byref_ProfessorCoilBeam_State_Shared_byref_ProfessorCoilBeam_Data_Server_byref_Age_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413626, RefRangeEnd = 1413627, XrefRangeStart = 1413626, XrefRangeEnd = 1413626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413627, RefRangeEnd = 1413628, XrefRangeStart = 1413627, XrefRangeEnd = 1413627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413628, XrefRangeEnd = 1413630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413645, RefRangeEnd = 1413646, XrefRangeStart = 1413630, XrefRangeEnd = 1413645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413648, RefRangeEnd = 1413649, XrefRangeStart = 1413646, XrefRangeEnd = 1413648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ProfessorCoilSystem_Server_Update componentSystem,
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413649, XrefRangeEnd = 1413653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413653, XrefRangeEnd = 1413659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateBeams()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>c__DisplayClass_UpdateBeams");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_casthits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (casthits));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (collisionWorld));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (entityManager));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (_runtimes));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilBeam_State_Server_byref_ProfessorCoilBeam_State_Shared_byref_ProfessorCoilBeam_Data_Server_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668932);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668933);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668934);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668935);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668936);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668937);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668938);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, 100668939);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_stateServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_stateShared;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dataServer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_age;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Server> forParameter_stateServer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Shared> forParameter_stateShared;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_Data_Server> forParameter_dataServer;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<Age> forParameter_age;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413497, RefRangeEnd = 1413498, XrefRangeStart = 1413484, XrefRangeEnd = 1413497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ProfessorCoilSystem_Server_Update componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413511, RefRangeEnd = 1413512, XrefRangeStart = 1413498, XrefRangeEnd = 1413511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_stateServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_stateServer));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_stateShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_stateShared));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dataServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dataServer));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_age));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, 100668940);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, 100668941);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_stateServer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_stateShared;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dataServer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_age;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Server>.Runtime runtime_stateServer;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_State_Shared>.Runtime runtime_stateShared;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilBeam_Data_Server>.Runtime runtime_dataServer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<Age>.Runtime runtime_age;

          static Runtimes()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_stateServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_stateServer));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_stateShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_stateShared));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dataServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dataServer));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_age));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateBeams/ProjectM.RunWithoutJobSystem_00000D4D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, "RunWithoutJobSystem_00000D4D$PostfixBurstDelegate");
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668942);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668943);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668944);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668945);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateBeams/ProjectM.RunWithoutJobSystem_00000D4D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413512, XrefRangeEnd = 1413526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413526, XrefRangeEnd = 1413544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413544, XrefRangeEnd = 1413559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413586, RefRangeEnd = 1413587, XrefRangeStart = 1413559, XrefRangeEnd = 1413586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams>.NativeClassPtr, "RunWithoutJobSystem_00000D4D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668946);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668947);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668948);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668949);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668951);
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
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateBeams.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateManagers")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateManagers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Team_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilManagerHitElement_byref_ProfessorCoilManager_byref_Team_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ServerTime serverTime;
      [FieldOffset(40)]
      public EntityCommandBuffer postUpdateCommandBuffer;
      [FieldOffset(56)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(104)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_0;
      [FieldOffset(136)]
      public ComponentDataFromEntity<Team> _ComponentDataFromEntity_Team_1;
      [FieldOffset(168)]
      public ComponentDataFromEntity<BuffableFlagState> _ComponentDataFromEntity_BuffableFlagState_2;
      [FieldOffset(200)]
      public ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(312)]
      public unsafe ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413756, XrefRangeEnd = 1413786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<ProfessorCoilManagerHitElement> hitBuffer,
        ref ProfessorCoilManager manager,
        [In] ref Team team)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hitBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilManagerHitElement_byref_ProfessorCoilManager_byref_Team_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413786, RefRangeEnd = 1413787, XrefRangeStart = 1413786, XrefRangeEnd = 1413786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413787, RefRangeEnd = 1413788, XrefRangeStart = 1413787, XrefRangeEnd = 1413787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413788, XrefRangeEnd = 1413790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413802, RefRangeEnd = 1413803, XrefRangeStart = 1413790, XrefRangeEnd = 1413802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1413814, RefRangeEnd = 1413815, XrefRangeStart = 1413803, XrefRangeEnd = 1413814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ProfessorCoilSystem_Server_Update componentSystem,
        ref ProfessorCoilSystem_Server_Update.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413815, XrefRangeEnd = 1413819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413819, XrefRangeEnd = 1413825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateManagers()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update>.NativeClassPtr, "<>c__DisplayClass_UpdateManagers");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (serverTime));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (prefabLookupMap));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_0));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr__ComponentDataFromEntity_Team_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (_ComponentDataFromEntity_Team_1));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (_ComponentDataFromEntity_BuffableFlagState_2));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (_runtimes));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilManagerHitElement_byref_ProfessorCoilManager_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668952);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668953);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668954);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668955);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668956);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668957);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668958);
        ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, 100668959);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hitBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_manager;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilManagerHitElement> forParameter_hitBuffer;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilManager> forParameter_manager;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413669, RefRangeEnd = 1413670, XrefRangeStart = 1413659, XrefRangeEnd = 1413669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ProfessorCoilSystem_Server_Update componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413680, RefRangeEnd = 1413681, XrefRangeStart = 1413670, XrefRangeEnd = 1413680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hitBuffer));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_manager));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Update_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, 100668960);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, 100668961);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hitBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_manager;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilManagerHitElement>.Runtime runtime_hitBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilManager>.Runtime runtime_manager;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;

          static Runtimes()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hitBuffer));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_manager));
            ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateManagers/ProjectM.RunWithoutJobSystem_00000D56$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, "RunWithoutJobSystem_00000D56$PostfixBurstDelegate");
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668962);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668963);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668964);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668965);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Update/ProjectM.<>c__DisplayClass_UpdateManagers/ProjectM.RunWithoutJobSystem_00000D56$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413681, XrefRangeEnd = 1413695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413695, XrefRangeEnd = 1413713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413713, XrefRangeEnd = 1413728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1413755, RefRangeEnd = 1413756, XrefRangeStart = 1413728, XrefRangeEnd = 1413755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers>.NativeClassPtr, "RunWithoutJobSystem_00000D56$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668966);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668967);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668968);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668969);
          ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668971);
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
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Update.__c__DisplayClass_UpdateManagers.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
