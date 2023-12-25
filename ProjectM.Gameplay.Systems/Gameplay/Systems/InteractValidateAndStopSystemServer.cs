// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Shared;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class InteractValidateAndStopSystemServer : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__StopInteractQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClearInteractedUpon_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClearInteractedUpon_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetInteractedUpon_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetInteractedUpon_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___StopInteractJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___StopInteractJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ValidateInteractorsJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ValidateInteractorsJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StopInteractJob_Private_Void_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateInteractorsJob_Private_Void_EntityCommandBuffer_InteractValidator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForClearInteractedUpon_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetInteractedUpon_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForStopInteractJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForValidateInteractorsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450778, XrefRangeEnd = 1450812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450812, XrefRangeEnd = 1450814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450814, XrefRangeEnd = 1450861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1450875, RefRangeEnd = 1450876, XrefRangeStart = 1450861, XrefRangeEnd = 1450875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StopInteractJob(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      EntityCommandBuffer buffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr_StopInteractJob_Private_Void_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1450894, RefRangeEnd = 1450895, XrefRangeStart = 1450876, XrefRangeEnd = 1450894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ValidateInteractorsJob(
      EntityCommandBuffer commandBuffer,
      InteractValidator interactValidator)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &interactValidator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr_ValidateInteractorsJob_Private_Void_EntityCommandBuffer_InteractValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InteractValidateAndStopSystemServer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450895, XrefRangeEnd = 1451022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451022, XrefRangeEnd = 1451038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForClearInteractedUpon_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForClearInteractedUpon_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451038, XrefRangeEnd = 1451057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetInteractedUpon_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForSetInteractedUpon_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451057, XrefRangeEnd = 1451076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForStopInteractJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForStopInteractJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1451076, XrefRangeEnd = 1451095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForValidateInteractorsJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForValidateInteractorsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1451099, RefRangeEnd = 1451100, XrefRangeStart = 1451095, XrefRangeEnd = 1451099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1451104, RefRangeEnd = 1451105, XrefRangeStart = 1451100, XrefRangeEnd = 1451104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InteractValidateAndStopSystemServer()
    {
      Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (InteractValidateAndStopSystemServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr);
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr__StopInteractQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, nameof (_StopInteractQuery));
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, nameof (_NetworkIdSystem));
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, nameof (_TileWorldSystem));
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, nameof (_CollisionSystem));
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ClearInteractedUpon_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>ClearInteractedUpon_entityQuery");
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ClearInteractedUpon_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>ClearInteractedUpon_profilerMarker");
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___SetInteractedUpon_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>SetInteractedUpon_entityQuery");
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___SetInteractedUpon_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>SetInteractedUpon_profilerMarker");
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___StopInteractJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>StopInteractJob_entityQuery");
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___StopInteractJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>StopInteractJob_profilerMarker");
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ValidateInteractorsJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>ValidateInteractorsJob_entityQuery");
      InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ValidateInteractorsJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>ValidateInteractorsJob_profilerMarker");
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672664);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672665);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672666);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_StopInteractJob_Private_Void_NativeHashMap_2_NetworkId_Entity_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672667);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_ValidateInteractorsJob_Private_Void_EntityCommandBuffer_InteractValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672668);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672669);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672670);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForClearInteractedUpon_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672671);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForSetInteractedUpon_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672672);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForStopInteractJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672673);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr___GetEntityQuery_ForValidateInteractorsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672674);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672675);
      InteractValidateAndStopSystemServer.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, 100672676);
    }

    public InteractValidateAndStopSystemServer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _StopInteractQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__StopInteractQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__StopInteractQuery)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __ClearInteractedUpon_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ClearInteractedUpon_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ClearInteractedUpon_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ClearInteractedUpon_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ClearInteractedUpon_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ClearInteractedUpon_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SetInteractedUpon_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___SetInteractedUpon_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___SetInteractedUpon_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetInteractedUpon_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___SetInteractedUpon_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___SetInteractedUpon_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __StopInteractJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___StopInteractJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___StopInteractJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __StopInteractJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___StopInteractJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___StopInteractJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ValidateInteractorsJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ValidateInteractorsJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ValidateInteractorsJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ValidateInteractorsJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ValidateInteractorsJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.NativeFieldInfoPtr___ValidateInteractorsJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_interactValidator;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractedUpon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref InteractedUpon interactedUpon)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactedUpon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractedUpon_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref SpellTarget interactTarget,
        [In] ref EntityOwner entityOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr);
        InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, nameof (entityManager));
        InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr_interactValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, nameof (interactValidator));
        InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, 100672677);
        InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractedUpon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, 100672678);
        InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, 100672679);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe InteractValidator interactValidator
      {
        get
        {
          return *(InteractValidator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr_interactValidator));
        }
        [param: In] set
        {
          *(InteractValidator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr_interactValidator)) = value;
        }
      }

      public unsafe InteractValidateAndStopSystemServer __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractValidateAndStopSystemServer) null : new InteractValidateAndStopSystemServer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__StopInteractJob_b__0_Internal_Void_byref_StopInteractingWithObjectEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _StopInteractJob_b__0(
        [In] ref StopInteractingWithObjectEvent stopInteract,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref stopInteract;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeMethodInfoPtr__StopInteractJob_b__0_Internal_Void_byref_StopInteractingWithObjectEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr);
        InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr, nameof (buffer));
        InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr, 100672680);
        InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeMethodInfoPtr__StopInteractJob_b__0_Internal_Void_byref_StopInteractingWithObjectEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr, 100672681);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe InteractValidateAndStopSystemServer __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractValidateAndStopSystemServer) null : new InteractValidateAndStopSystemServer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer buffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr_buffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass8_0.NativeFieldInfoPtr_buffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_interactValidator;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ValidateInteractorsJob_b__0_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ValidateInteractorsJob_b__0(
        Entity entity,
        [In] ref SpellTarget interactTarget,
        [In] ref EntityOwner entityOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeMethodInfoPtr__ValidateInteractorsJob_b__0_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr);
        InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr_interactValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr, nameof (interactValidator));
        InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr, nameof (commandBuffer));
        InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr, 100672682);
        InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeMethodInfoPtr__ValidateInteractorsJob_b__0_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr, 100672683);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass9_0>.NativeClassPtr, data));
      }

      public unsafe InteractValidator interactValidator
      {
        get
        {
          return *(InteractValidator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr_interactValidator));
        }
        [param: In] set
        {
          *(InteractValidator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr_interactValidator)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe InteractValidateAndStopSystemServer __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractValidateAndStopSystemServer) null : new InteractValidateAndStopSystemServer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClearInteractedUpon")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ClearInteractedUpon
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractedUpon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450475, XrefRangeEnd = 1450478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref InteractedUpon interactedUpon)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactedUpon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractedUpon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 927059, RefRangeEnd = 927105, XrefRangeStart = 927059, XrefRangeEnd = 927105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(47)]
      [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450478, XrefRangeEnd = 1450480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450486, RefRangeEnd = 1450487, XrefRangeStart = 1450480, XrefRangeEnd = 1450486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450489, RefRangeEnd = 1450490, XrefRangeStart = 1450487, XrefRangeEnd = 1450489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractValidateAndStopSystemServer componentSystem,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450490, XrefRangeEnd = 1450494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450494, XrefRangeEnd = 1450500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ClearInteractedUpon()
      {
        Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>c__DisplayClass_ClearInteractedUpon");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, nameof (entityManager));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, nameof (_runtimes));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractedUpon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672684);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672685);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672686);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672687);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672688);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672689);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672690);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, 100672691);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interactedUpon;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<InteractedUpon> forParameter_interactedUpon;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450394, RefRangeEnd = 1450395, XrefRangeStart = 1450390, XrefRangeEnd = 1450394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          InteractValidateAndStopSystemServer componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450399, RefRangeEnd = 1450400, XrefRangeStart = 1450395, XrefRangeEnd = 1450399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interactedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interactedUpon));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, 100672692);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, 100672693);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interactedUpon;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<InteractedUpon>.Runtime runtime_interactedUpon;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interactedUpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interactedUpon));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClearInteractedUpon/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001685$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, "RunWithoutJobSystem_00001685$PostfixBurstDelegate");
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672694);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672695);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672696);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672697);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClearInteractedUpon/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001685$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450400, XrefRangeEnd = 1450414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450414, XrefRangeEnd = 1450432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450432, XrefRangeEnd = 1450447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450474, RefRangeEnd = 1450475, XrefRangeStart = 1450447, XrefRangeEnd = 1450474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon>.NativeClassPtr, "RunWithoutJobSystem_00001685$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672698);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672699);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672700);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672701);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672703);
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
            IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ClearInteractedUpon.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_SetInteractedUpon")]
    public sealed class __c__DisplayClass_SetInteractedUpon : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_interactValidator;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450526, RefRangeEnd = 1450527, XrefRangeStart = 1450516, XrefRangeEnd = 1450526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SpellTarget interactTarget,
        [In] ref EntityOwner entityOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450529, RefRangeEnd = 1450530, XrefRangeStart = 1450527, XrefRangeEnd = 1450529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450532, RefRangeEnd = 1450533, XrefRangeStart = 1450530, XrefRangeEnd = 1450532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450533, XrefRangeEnd = 1450535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450544, RefRangeEnd = 1450545, XrefRangeStart = 1450535, XrefRangeEnd = 1450544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450547, RefRangeEnd = 1450548, XrefRangeStart = 1450545, XrefRangeEnd = 1450547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractValidateAndStopSystemServer componentSystem,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450548, XrefRangeEnd = 1450554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetInteractedUpon()
      {
        Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>c__DisplayClass_SetInteractedUpon");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr);
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr_interactValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, nameof (interactValidator));
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, "<>4__this");
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, nameof (_runtimes));
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, 100672704);
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, 100672705);
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, 100672706);
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, 100672707);
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, 100672708);
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, 100672709);
        InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, 100672710);
      }

      public __c__DisplayClass_SetInteractedUpon(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SetInteractedUpon()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, data));
      }

      public unsafe InteractValidator interactValidator
      {
        get
        {
          return *(InteractValidator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr_interactValidator));
        }
        [param: In] set
        {
          *(InteractValidator*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr_interactValidator)) = value;
        }
      }

      public unsafe InteractValidateAndStopSystemServer __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractValidateAndStopSystemServer) null : new InteractValidateAndStopSystemServer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interactTarget;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SpellTarget> forParameter_interactTarget;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450507, RefRangeEnd = 1450508, XrefRangeStart = 1450500, XrefRangeEnd = 1450507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          InteractValidateAndStopSystemServer componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450515, RefRangeEnd = 1450516, XrefRangeStart = 1450508, XrefRangeEnd = 1450515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interactTarget));
          InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, 100672711);
          InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, 100672712);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interactTarget;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SpellTarget>.Runtime runtime_interactTarget;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interactTarget));
            InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_SetInteractedUpon.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_StopInteractJob")]
    public sealed class __c__DisplayClass_StopInteractJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StopInteractingWithObjectEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450593, RefRangeEnd = 1450594, XrefRangeStart = 1450568, XrefRangeEnd = 1450593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref StopInteractingWithObjectEvent stopInteract,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref stopInteract;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StopInteractingWithObjectEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450595, RefRangeEnd = 1450596, XrefRangeStart = 1450594, XrefRangeEnd = 1450595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 1018528, RefRangeEnd = 1018540, XrefRangeStart = 1018528, XrefRangeEnd = 1018540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450596, XrefRangeEnd = 1450598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450606, RefRangeEnd = 1450607, XrefRangeStart = 1450598, XrefRangeEnd = 1450606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450609, RefRangeEnd = 1450610, XrefRangeStart = 1450607, XrefRangeEnd = 1450609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractValidateAndStopSystemServer componentSystem,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450610, XrefRangeEnd = 1450616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_StopInteractJob()
      {
        Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>c__DisplayClass_StopInteractJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr);
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, "<>4__this");
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, nameof (buffer));
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, nameof (_runtimes));
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StopInteractingWithObjectEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, 100672713);
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, 100672714);
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, 100672715);
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, 100672716);
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, 100672717);
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, 100672718);
        InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, 100672719);
      }

      public __c__DisplayClass_StopInteractJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_StopInteractJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe InteractValidateAndStopSystemServer __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractValidateAndStopSystemServer) null : new InteractValidateAndStopSystemServer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer buffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_buffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_buffer)) = value;
        }
      }

      public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_stopInteract;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StopInteractingWithObjectEvent> forParameter_stopInteract;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450560, RefRangeEnd = 1450561, XrefRangeStart = 1450554, XrefRangeEnd = 1450560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          InteractValidateAndStopSystemServer componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450567, RefRangeEnd = 1450568, XrefRangeStart = 1450561, XrefRangeEnd = 1450567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_stopInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_stopInteract));
          InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders>.NativeClassPtr, 100672720);
          InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders>.NativeClassPtr, 100672721);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_stopInteract;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StopInteractingWithObjectEvent>.Runtime runtime_stopInteract;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_stopInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_stopInteract));
            InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_StopInteractJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_ValidateInteractorsJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ValidateInteractorsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_interactValidator;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityOwner_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public InteractValidator interactValidator;
      [FieldOffset(2592)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(2608)]
      public ComponentDataFromEntity<AbilityOwner> _ComponentDataFromEntity_AbilityOwner_0;
      [FieldOffset(2640)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_1;
      [FieldOffset(2672)]
      public InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2744)]
      public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450707, XrefRangeEnd = 1450743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SpellTarget interactTarget,
        [In] ref EntityOwner entityOwner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450744, RefRangeEnd = 1450745, XrefRangeStart = 1450743, XrefRangeEnd = 1450744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450746, RefRangeEnd = 1450747, XrefRangeStart = 1450745, XrefRangeEnd = 1450746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractValidateAndStopSystemServer.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450747, XrefRangeEnd = 1450749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450758, RefRangeEnd = 1450759, XrefRangeStart = 1450749, XrefRangeEnd = 1450758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1450767, RefRangeEnd = 1450768, XrefRangeStart = 1450759, XrefRangeEnd = 1450767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractValidateAndStopSystemServer componentSystem,
        ref InteractValidateAndStopSystemServer.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450768, XrefRangeEnd = 1450772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450772, XrefRangeEnd = 1450778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ValidateInteractorsJob()
      {
        Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer>.NativeClassPtr, "<>c__DisplayClass_ValidateInteractorsJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_interactValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (interactValidator));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (commandBuffer));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityOwner_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityOwner_0));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_1));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (_runtimes));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672722);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672723);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672724);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672725);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672726);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672727);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672728);
        InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, 100672729);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interactTarget;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SpellTarget> forParameter_interactTarget;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_entityOwner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450623, RefRangeEnd = 1450624, XrefRangeStart = 1450616, XrefRangeEnd = 1450623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          InteractValidateAndStopSystemServer componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450631, RefRangeEnd = 1450632, XrefRangeStart = 1450624, XrefRangeEnd = 1450631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interactTarget));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityOwner));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractValidateAndStopSystemServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr, 100672730);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr, 100672731);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interactTarget;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityOwner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SpellTarget>.Runtime runtime_interactTarget;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_entityOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interactTarget));
            InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_ValidateInteractorsJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016A0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, "RunWithoutJobSystem_000016A0$PostfixBurstDelegate");
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672732);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672733);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672734);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672735);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.InteractValidateAndStopSystemServer/ProjectM.Gameplay.Systems.<>c__DisplayClass_ValidateInteractorsJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000016A0$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450632, XrefRangeEnd = 1450646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450646, XrefRangeEnd = 1450664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450664, XrefRangeEnd = 1450679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1450706, RefRangeEnd = 1450707, XrefRangeStart = 1450679, XrefRangeEnd = 1450706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob>.NativeClassPtr, "RunWithoutJobSystem_000016A0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672736);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672737);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672738);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672739);
          InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672741);
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
            IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InteractValidateAndStopSystemServer.__c__DisplayClass_ValidateInteractorsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
