// Decompiled with JetBrains decompiler
// Type: ProjectM.ProfessorCoilSystem_Server_Spawn
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ProfessorCoilSystem_Server_Spawn : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ManagerSpawnQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CoilEventSpawnTagQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CoilQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CoilManagerQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__BeamQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelEventsBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr___ManagerSpawn_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ManagerSpawn_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___EventSpawn_Base_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___EventSpawn_Base_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___EventSpawn_Random_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___EventSpawn_Random_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___EventSpawn_PredefinedSequence_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___EventSpawn_PredefinedSequence_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindTranslationInRange_Private_Static_Boolean_byref_float3_Single_NativeArray_1_Translation_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForManagerSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_Base_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_Random_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_PredefinedSequence_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412358, XrefRangeEnd = 1412411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412411, XrefRangeEnd = 1412496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412499, RefRangeEnd = 1412500, XrefRangeStart = 1412496, XrefRangeEnd = 1412499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindTranslationInRange(
      [In] ref float3 position,
      float rangeSq,
      NativeArray<Translation> translations,
      out int result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rangeSq;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &translations;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_TryFindTranslationInRange_Private_Static_Boolean_byref_float3_Single_NativeArray_1_Translation_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProfessorCoilSystem_Server_Spawn()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412500, XrefRangeEnd = 1412566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412591, RefRangeEnd = 1412592, XrefRangeStart = 1412566, XrefRangeEnd = 1412591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForManagerSpawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForManagerSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412614, RefRangeEnd = 1412615, XrefRangeStart = 1412592, XrefRangeEnd = 1412614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEventSpawn_Base_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_Base_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412640, RefRangeEnd = 1412641, XrefRangeStart = 1412615, XrefRangeEnd = 1412640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEventSpawn_Random_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_Random_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412663, RefRangeEnd = 1412664, XrefRangeStart = 1412641, XrefRangeEnd = 1412663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEventSpawn_PredefinedSequence_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_PredefinedSequence_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412668, RefRangeEnd = 1412669, XrefRangeStart = 1412664, XrefRangeEnd = 1412668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412673, RefRangeEnd = 1412674, XrefRangeStart = 1412669, XrefRangeEnd = 1412673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412678, RefRangeEnd = 1412679, XrefRangeStart = 1412674, XrefRangeEnd = 1412678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1412683, RefRangeEnd = 1412684, XrefRangeStart = 1412679, XrefRangeEnd = 1412683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProfessorCoilSystem_Server_Spawn()
    {
      Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ProfessorCoilSystem_Server_Spawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr);
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__ManagerSpawnQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (_ManagerSpawnQuery));
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilEventSpawnTagQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (_CoilEventSpawnTagQuery));
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (_CoilQuery));
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilManagerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (_CoilManagerQuery));
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__BeamQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (_BeamQuery));
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__TileModelEventsBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (_TileModelEventsBarrier));
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___ManagerSpawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>ManagerSpawn_entityQuery");
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___ManagerSpawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>ManagerSpawn_profilerMarker");
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Base_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>EventSpawn_Base_entityQuery");
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Base_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>EventSpawn_Base_profilerMarker");
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Random_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>EventSpawn_Random_entityQuery");
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Random_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>EventSpawn_Random_profilerMarker");
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_PredefinedSequence_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>EventSpawn_PredefinedSequence_entityQuery");
      ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_PredefinedSequence_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>EventSpawn_PredefinedSequence_profilerMarker");
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668714);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668715);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_TryFindTranslationInRange_Private_Static_Boolean_byref_float3_Single_NativeArray_1_Translation_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668716);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668717);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668718);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForManagerSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668719);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_Base_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668720);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_Random_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668721);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr___GetEntityQuery_ForEventSpawn_PredefinedSequence_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668722);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668723);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668724);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668725);
      ProfessorCoilSystem_Server_Spawn.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, 100668726);
    }

    public ProfessorCoilSystem_Server_Spawn(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _ManagerSpawnQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__ManagerSpawnQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__ManagerSpawnQuery)) = value;
      }
    }

    public unsafe EntityQuery _CoilEventSpawnTagQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilEventSpawnTagQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilEventSpawnTagQuery)) = value;
      }
    }

    public unsafe EntityQuery _CoilQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilQuery)) = value;
      }
    }

    public unsafe EntityQuery _CoilManagerQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilManagerQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__CoilManagerQuery)) = value;
      }
    }

    public unsafe EntityQuery _BeamQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__BeamQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__BeamQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileModelEventsBarrier _TileModelEventsBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__TileModelEventsBarrier));
        return pointer == System.IntPtr.Zero ? (TileModelEventsBarrier) null : new TileModelEventsBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr__TileModelEventsBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __ManagerSpawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___ManagerSpawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___ManagerSpawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ManagerSpawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___ManagerSpawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___ManagerSpawn_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __EventSpawn_Base_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Base_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Base_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __EventSpawn_Base_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Base_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Base_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __EventSpawn_Random_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Random_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Random_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __EventSpawn_Random_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Random_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_Random_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __EventSpawn_PredefinedSequence_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_PredefinedSequence_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_PredefinedSequence_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __EventSpawn_PredefinedSequence_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_PredefinedSequence_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.NativeFieldInfoPtr___EventSpawn_PredefinedSequence_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CoilElementIndexComparer
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ProfessorCoilElement_ProfessorCoilElement_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411767, XrefRangeEnd = 1411768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int Compare(ProfessorCoilElement a, ProfessorCoilElement b)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.CoilElementIndexComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ProfessorCoilElement_ProfessorCoilElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static CoilElementIndexComparer()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.CoilElementIndexComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, nameof (CoilElementIndexComparer));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.CoilElementIndexComparer>.NativeClassPtr);
        ProfessorCoilSystem_Server_Spawn.CoilElementIndexComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ProfessorCoilElement_ProfessorCoilElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.CoilElementIndexComparer>.NativeClassPtr, 100668727);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.CoilElementIndexComparer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_coilTranslationArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_coilArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_coilManagerTranslationArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_coilManagerEntityArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_beams;
      private static readonly System.IntPtr NativeFieldInfoPtr_beamEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ProfessorCoilEvent_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_ProfessorCoilEvent_Random_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilEvent_PredefinedSequence_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DynamicBuffer<ProfessorCoilElement> coils,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref coils;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(ref ProfessorCoilEvent evt, [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref evt;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ProfessorCoilEvent_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        ref ProfessorCoilEvent evt,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        [In] ref ProfessorCoilEvent_Random randomEvt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref randomEvt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_ProfessorCoilEvent_Random_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        ref DynamicBuffer<ProfessorCoilEvent_PredefinedSequence> sequence)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequence;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilEvent_PredefinedSequence_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilTranslationArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (coilTranslationArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (coilArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilManagerTranslationArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (coilManagerTranslationArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilManagerEntityArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (coilManagerEntityArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (prefabLookupMap));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (random));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (commandBuffer));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_beams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (beams));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_beamEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, nameof (beamEntities));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, 100668728);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, 100668729);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_ProfessorCoilEvent_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, 100668730);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_ProfessorCoilEvent_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, 100668731);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilEvent_PredefinedSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, 100668732);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0>.NativeClassPtr, data));
      }

      public unsafe NativeArray<Translation> coilTranslationArray
      {
        get
        {
          return *(NativeArray<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilTranslationArray));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilTranslationArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<ProfessorCoil> coilArray
      {
        get
        {
          return *(NativeArray<ProfessorCoil>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilArray));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ProfessorCoil>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<Translation> coilManagerTranslationArray
      {
        get
        {
          return *(NativeArray<Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilManagerTranslationArray));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilManagerTranslationArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<Entity> coilManagerEntityArray
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilManagerEntityArray));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_coilManagerEntityArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PrefabLookupMap prefabLookupMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_prefabLookupMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_prefabLookupMap)) = value;
        }
      }

      public unsafe ProfessorCoilSystem_Server_Spawn __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ProfessorCoilSystem_Server_Spawn) null : new ProfessorCoilSystem_Server_Spawn(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe NativeArray<ProfessorCoilBeam_State_Server> beams
      {
        get
        {
          return *(NativeArray<ProfessorCoilBeam_State_Server>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_beams));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_beams), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ProfessorCoilBeam_State_Server>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<Entity> beamEntities
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_beamEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0.NativeFieldInfoPtr_beamEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_ManagerSpawn")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ManagerSpawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_coilTranslationArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_coilArray;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<Translation> coilTranslationArray;
      [FieldOffset(16)]
      public NativeArray<ProfessorCoil> coilArray;
      [FieldOffset(32)]
      public ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(152)]
      public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411865, XrefRangeEnd = 1411885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<ProfessorCoilElement> coils,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref coils;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411885, XrefRangeEnd = 1411887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1411899, RefRangeEnd = 1411900, XrefRangeStart = 1411887, XrefRangeEnd = 1411899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1411902, RefRangeEnd = 1411903, XrefRangeStart = 1411900, XrefRangeEnd = 1411902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ProfessorCoilSystem_Server_Spawn componentSystem,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411903, XrefRangeEnd = 1411907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411907, XrefRangeEnd = 1411913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ManagerSpawn()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>c__DisplayClass_ManagerSpawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_coilTranslationArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, nameof (coilTranslationArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_coilArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, nameof (coilArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, nameof (_runtimes));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilElement_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668733);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668734);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668735);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668736);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668737);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668738);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668739);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, 100668740);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_coils;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_coilPairs;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilElement> forParameter_coils;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement> forParameter_coilPairs;
        [FieldOffset(88)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1411778, RefRangeEnd = 1411779, XrefRangeStart = 1411768, XrefRangeEnd = 1411778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ProfessorCoilSystem_Server_Spawn componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1411789, RefRangeEnd = 1411790, XrefRangeStart = 1411779, XrefRangeEnd = 1411789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_coils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_coils));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_coilPairs));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, 100668741);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, 100668742);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_coils;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_coilPairs;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilElement>.Runtime runtime_coils;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement>.Runtime runtime_coilPairs;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_coils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_coils));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_coilPairs));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_ManagerSpawn/ProjectM.RunWithoutJobSystem_00000CE7$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, "RunWithoutJobSystem_00000CE7$PostfixBurstDelegate");
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668743);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668744);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668745);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668746);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_ManagerSpawn/ProjectM.RunWithoutJobSystem_00000CE7$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411790, XrefRangeEnd = 1411804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411804, XrefRangeEnd = 1411822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411822, XrefRangeEnd = 1411837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1411864, RefRangeEnd = 1411865, XrefRangeStart = 1411837, XrefRangeEnd = 1411864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn>.NativeClassPtr, "RunWithoutJobSystem_00000CE7$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668747);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668748);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668749);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668750);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668752);
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
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_ManagerSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_Base")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_EventSpawn_Base
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_coilManagerTranslationArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_coilManagerEntityArray;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ProfessorCoilEvent_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeArray<Translation> coilManagerTranslationArray;
      [FieldOffset(16)]
      public NativeArray<Entity> coilManagerEntityArray;
      [FieldOffset(32)]
      public ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412002, XrefRangeEnd = 1412005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref ProfessorCoilEvent evt, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref evt;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ProfessorCoilEvent_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1101511, RefRangeEnd = 1101514, XrefRangeStart = 1101511, XrefRangeEnd = 1101514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1101514, RefRangeEnd = 1101517, XrefRangeStart = 1101514, XrefRangeEnd = 1101517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412005, XrefRangeEnd = 1412007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412015, RefRangeEnd = 1412016, XrefRangeStart = 1412007, XrefRangeEnd = 1412015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412018, RefRangeEnd = 1412019, XrefRangeStart = 1412016, XrefRangeEnd = 1412018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ProfessorCoilSystem_Server_Spawn componentSystem,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412019, XrefRangeEnd = 1412023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412023, XrefRangeEnd = 1412029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_EventSpawn_Base()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>c__DisplayClass_EventSpawn_Base");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_coilManagerTranslationArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, nameof (coilManagerTranslationArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_coilManagerEntityArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, nameof (coilManagerEntityArray));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, nameof (_runtimes));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ProfessorCoilEvent_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668753);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668754);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668755);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668756);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668757);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668758);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668759);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, 100668760);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent> forParameter_evt;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1411919, RefRangeEnd = 1411920, XrefRangeStart = 1411913, XrefRangeEnd = 1411919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ProfessorCoilSystem_Server_Spawn componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1411926, RefRangeEnd = 1411927, XrefRangeStart = 1411920, XrefRangeEnd = 1411926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders>.NativeClassPtr, 100668761);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders>.NativeClassPtr, 100668762);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent>.Runtime runtime_evt;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_Base/ProjectM.RunWithoutJobSystem_00000CF0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, "RunWithoutJobSystem_00000CF0$PostfixBurstDelegate");
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668763);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668764);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668765);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668766);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_Base/ProjectM.RunWithoutJobSystem_00000CF0$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411927, XrefRangeEnd = 1411941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411941, XrefRangeEnd = 1411959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411959, XrefRangeEnd = 1411974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412001, RefRangeEnd = 1412002, XrefRangeStart = 1411974, XrefRangeEnd = 1412001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base>.NativeClassPtr, "RunWithoutJobSystem_00000CF0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668767);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668768);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668769);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668770);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668772);
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
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Base.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_Random")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_EventSpawn_Random
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilElement_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilPairElement_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_ProfessorCoilEvent_Random_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(48)]
      public Unity.Mathematics.Random random;
      [FieldOffset(56)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(72)]
      public BufferFromEntity<ProfessorCoilElement> _BufferFromEntity_ProfessorCoilElement_0;
      [FieldOffset(112)]
      public BufferFromEntity<ProfessorCoilPairElement> _BufferFromEntity_ProfessorCoilPairElement_1;
      [FieldOffset(152)]
      public ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(264)]
      public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412126, XrefRangeEnd = 1412155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref ProfessorCoilEvent evt,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        [In] ref ProfessorCoilEvent_Random randomEvt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref randomEvt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_ProfessorCoilEvent_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412155, RefRangeEnd = 1412156, XrefRangeStart = 1412155, XrefRangeEnd = 1412155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412156, RefRangeEnd = 1412157, XrefRangeStart = 1412156, XrefRangeEnd = 1412156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412157, XrefRangeEnd = 1412159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412171, RefRangeEnd = 1412172, XrefRangeStart = 1412159, XrefRangeEnd = 1412171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412180, RefRangeEnd = 1412181, XrefRangeStart = 1412172, XrefRangeEnd = 1412180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ProfessorCoilSystem_Server_Spawn componentSystem,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412181, XrefRangeEnd = 1412185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412185, XrefRangeEnd = 1412191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_EventSpawn_Random()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>c__DisplayClass_EventSpawn_Random");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (prefabLookupMap));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (random));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (commandBuffer));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilElement_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (_BufferFromEntity_ProfessorCoilElement_0));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilPairElement_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (_BufferFromEntity_ProfessorCoilPairElement_1));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (_runtimes));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ProfessorCoilEvent_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_ProfessorCoilEvent_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668773);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668774);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668775);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668776);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668777);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668778);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668779);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, 100668780);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_coilPairs;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_randomEvt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent> forParameter_evt;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement> forParameter_coilPairs;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent_Random> forParameter_randomEvt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412039, RefRangeEnd = 1412040, XrefRangeStart = 1412029, XrefRangeEnd = 1412039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ProfessorCoilSystem_Server_Spawn componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412050, RefRangeEnd = 1412051, XrefRangeStart = 1412040, XrefRangeEnd = 1412050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_coilPairs));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_randomEvt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_randomEvt));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, 100668781);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, 100668782);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_coilPairs;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_randomEvt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent>.Runtime runtime_evt;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement>.Runtime runtime_coilPairs;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<ProfessorCoilEvent_Random>.Runtime runtime_randomEvt;

          static Runtimes()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_coilPairs));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_randomEvt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_randomEvt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_Random/ProjectM.RunWithoutJobSystem_00000CF9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, "RunWithoutJobSystem_00000CF9$PostfixBurstDelegate");
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668783);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668784);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668785);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668786);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_Random/ProjectM.RunWithoutJobSystem_00000CF9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412051, XrefRangeEnd = 1412065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412065, XrefRangeEnd = 1412083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412083, XrefRangeEnd = 1412098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412125, RefRangeEnd = 1412126, XrefRangeStart = 1412098, XrefRangeEnd = 1412125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random>.NativeClassPtr, "RunWithoutJobSystem_00000CF9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668787);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668788);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668789);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668790);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668792);
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
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_Random.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_PredefinedSequence")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_EventSpawn_PredefinedSequence
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_beams;
      private static readonly System.IntPtr NativeFieldInfoPtr_beamEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ProfessorCoilEvent_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilElement_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilPairElement_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilEvent_PredefinedSequence_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(48)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(64)]
      public NativeArray<ProfessorCoilBeam_State_Server> beams;
      [FieldOffset(80)]
      public NativeArray<Entity> beamEntities;
      [FieldOffset(96)]
      public ComponentDataFromEntity<ProfessorCoilEvent> _ComponentDataFromEntity_ProfessorCoilEvent_0;
      [FieldOffset(128)]
      public BufferFromEntity<ProfessorCoilElement> _BufferFromEntity_ProfessorCoilElement_1;
      [FieldOffset(168)]
      public BufferFromEntity<ProfessorCoilPairElement> _BufferFromEntity_ProfessorCoilPairElement_2;
      [FieldOffset(208)]
      public ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(296)]
      public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412282, XrefRangeEnd = 1412322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<ProfessorCoilPairElement> coilPairs,
        ref DynamicBuffer<ProfessorCoilEvent_PredefinedSequence> sequence)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref coilPairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequence;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilEvent_PredefinedSequence_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412322, RefRangeEnd = 1412323, XrefRangeStart = 1412322, XrefRangeEnd = 1412322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412323, RefRangeEnd = 1412324, XrefRangeStart = 1412323, XrefRangeEnd = 1412323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412324, XrefRangeEnd = 1412326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412335, RefRangeEnd = 1412336, XrefRangeStart = 1412326, XrefRangeEnd = 1412335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1412347, RefRangeEnd = 1412348, XrefRangeStart = 1412336, XrefRangeEnd = 1412347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ProfessorCoilSystem_Server_Spawn componentSystem,
        ref ProfessorCoilSystem_Server_Spawn.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412348, XrefRangeEnd = 1412352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412352, XrefRangeEnd = 1412358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_EventSpawn_PredefinedSequence()
      {
        Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn>.NativeClassPtr, "<>c__DisplayClass_EventSpawn_PredefinedSequence");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (prefabLookupMap));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (commandBuffer));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_beams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (beams));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_beamEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (beamEntities));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr__ComponentDataFromEntity_ProfessorCoilEvent_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (_ComponentDataFromEntity_ProfessorCoilEvent_0));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilElement_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (_BufferFromEntity_ProfessorCoilElement_1));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr__BufferFromEntity_ProfessorCoilPairElement_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (_BufferFromEntity_ProfessorCoilPairElement_2));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (_runtimes));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_ProfessorCoilPairElement_byref_DynamicBuffer_1_ProfessorCoilEvent_PredefinedSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668793);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668794);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668795);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668796);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668797);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668798);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668799);
        ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, 100668800);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_coilPairs;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequence;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement> forParameter_coilPairs;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilEvent_PredefinedSequence> forParameter_sequence;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412198, RefRangeEnd = 1412199, XrefRangeStart = 1412191, XrefRangeEnd = 1412198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ProfessorCoilSystem_Server_Spawn componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412206, RefRangeEnd = 1412207, XrefRangeStart = 1412199, XrefRangeEnd = 1412206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_coilPairs));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequence));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ProfessorCoilSystem_Server_Spawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr, 100668801);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr, 100668802);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_coilPairs;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequence;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilPairElement>.Runtime runtime_coilPairs;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<ProfessorCoilEvent_PredefinedSequence>.Runtime runtime_sequence;

          static Runtimes()
          {
            Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_coilPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_coilPairs));
            ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequence));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_PredefinedSequence/ProjectM.RunWithoutJobSystem_00000D02$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, "RunWithoutJobSystem_00000D02$PostfixBurstDelegate");
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668803);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668804);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668805);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668806);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ProfessorCoilSystem_Server_Spawn/ProjectM.<>c__DisplayClass_EventSpawn_PredefinedSequence/ProjectM.RunWithoutJobSystem_00000D02$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412207, XrefRangeEnd = 1412221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412221, XrefRangeEnd = 1412239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412239, XrefRangeEnd = 1412254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1412281, RefRangeEnd = 1412282, XrefRangeStart = 1412254, XrefRangeEnd = 1412281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence>.NativeClassPtr, "RunWithoutJobSystem_00000D02$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668807);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668808);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668809);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668810);
          ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668812);
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
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ProfessorCoilSystem_Server_Spawn.__c__DisplayClass_EventSpawn_PredefinedSequence.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
