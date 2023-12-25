// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SetupNetworkIdSystem
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

#nullable disable
namespace ProjectM.Network
{
  public class SetupNetworkIdSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SetupNetworkIdQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdGenerations;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeIds;
    private static readonly System.IntPtr NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumOfFreeIds_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxIds_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReturnNetworkId_Public_Static_Void_EntityManager_Entity_NetworkId_NativeHashMap_2_NetworkId_Entity_NativeArray_1_Byte_NativeQueue_1_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GrowUserEntityNetworkState_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GrowUserEntityNetworkState_Public_Static_Void_Int32_DynamicBuffer_1_UserEntityNetworkState_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGrowUserEntityNetworkState_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    public unsafe int NumOfFreeIds
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1154312, RefRangeEnd = 1154314, XrefRangeStart = 1154309, XrefRangeEnd = 1154312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr_get_NumOfFreeIds_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int MaxIds
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1154317, RefRangeEnd = 1154318, XrefRangeStart = 1154314, XrefRangeEnd = 1154317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr_get_MaxIds_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154318, XrefRangeEnd = 1154365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupNetworkIdSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154365, XrefRangeEnd = 1154371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupNetworkIdSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1154436, RefRangeEnd = 1154437, XrefRangeStart = 1154371, XrefRangeEnd = 1154436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReturnNetworkId(
      EntityManager entityManager,
      Entity targetEntity,
      NetworkId networkId,
      NativeHashMap<NetworkId, Entity> networkIdMap,
      NativeArray<byte> idGenerations,
      NativeQueue<int> freeIds,
      bool forceRemoveEvenIfNotMatchingEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &networkIdMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &idGenerations;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &freeIds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &forceRemoveEvenIfNotMatchingEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr_ReturnNetworkId_Public_Static_Void_EntityManager_Entity_NetworkId_NativeHashMap_2_NetworkId_Entity_NativeArray_1_Byte_NativeQueue_1_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154437, XrefRangeEnd = 1154454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupNetworkIdSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1154471, RefRangeEnd = 1154474, XrefRangeStart = 1154454, XrefRangeEnd = 1154471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GrowUserEntityNetworkState(int oldCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &oldCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr_GrowUserEntityNetworkState_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1154481, RefRangeEnd = 1154483, XrefRangeStart = 1154474, XrefRangeEnd = 1154481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GrowUserEntityNetworkState(
      int idGenerationsLength,
      DynamicBuffer<UserEntityNetworkState> userEntityNetworkState,
      int clearFromIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &idGenerationsLength;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntityNetworkState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &clearFromIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr_GrowUserEntityNetworkState_Public_Static_Void_Int32_DynamicBuffer_1_UserEntityNetworkState_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetupNetworkIdSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154483, XrefRangeEnd = 1154516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupNetworkIdSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154516, XrefRangeEnd = 1154532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGrowUserEntityNetworkState_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr___GetEntityQuery_ForGrowUserEntityNetworkState_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1154536, RefRangeEnd = 1154537, XrefRangeStart = 1154532, XrefRangeEnd = 1154536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetupNetworkIdSystem()
    {
      Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SetupNetworkIdSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr);
      SetupNetworkIdSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      SetupNetworkIdSystem.NativeFieldInfoPtr__SetupNetworkIdQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, nameof (_SetupNetworkIdQuery));
      SetupNetworkIdSystem.NativeFieldInfoPtr_IdGenerations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, nameof (IdGenerations));
      SetupNetworkIdSystem.NativeFieldInfoPtr_FreeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, nameof (FreeIds));
      SetupNetworkIdSystem.NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, "<>GrowUserEntityNetworkState_LambdaJob0_entityQuery");
      SetupNetworkIdSystem.NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, "<>GrowUserEntityNetworkState_LambdaJob0_profilerMarker");
      SetupNetworkIdSystem.NativeMethodInfoPtr_get_NumOfFreeIds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691806);
      SetupNetworkIdSystem.NativeMethodInfoPtr_get_MaxIds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691807);
      SetupNetworkIdSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691808);
      SetupNetworkIdSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691809);
      SetupNetworkIdSystem.NativeMethodInfoPtr_ReturnNetworkId_Public_Static_Void_EntityManager_Entity_NetworkId_NativeHashMap_2_NetworkId_Entity_NativeArray_1_Byte_NativeQueue_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691810);
      SetupNetworkIdSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691811);
      SetupNetworkIdSystem.NativeMethodInfoPtr_GrowUserEntityNetworkState_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691812);
      SetupNetworkIdSystem.NativeMethodInfoPtr_GrowUserEntityNetworkState_Public_Static_Void_Int32_DynamicBuffer_1_UserEntityNetworkState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691813);
      SetupNetworkIdSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691814);
      SetupNetworkIdSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691815);
      SetupNetworkIdSystem.NativeMethodInfoPtr___GetEntityQuery_ForGrowUserEntityNetworkState_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691816);
      SetupNetworkIdSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, 100691817);
    }

    public SetupNetworkIdSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SetupNetworkIdQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr__SetupNetworkIdQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr__SetupNetworkIdQuery)) = value;
      }
    }

    public unsafe NativeList<byte> IdGenerations
    {
      get
      {
        return *(NativeList<byte>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr_IdGenerations));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr_IdGenerations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeQueue<int> FreeIds
    {
      get
      {
        return *(NativeQueue<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr_FreeIds));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr_FreeIds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __GrowUserEntityNetworkState_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GrowUserEntityNetworkState_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupNetworkIdSystem.NativeFieldInfoPtr___GrowUserEntityNetworkState_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Network.SetupNetworkIdSystem/<>c__DisplayClass12_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass12_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newLength;
      private static readonly System.IntPtr NativeFieldInfoPtr_oldCount;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GrowUserEntityNetworkState_b__0_Internal_Void_DynamicBuffer_1_UserEntityNetworkState_0;
      [FieldOffset(0)]
      public int newLength;
      [FieldOffset(4)]
      public int oldCount;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GrowUserEntityNetworkState_b__0(
        DynamicBuffer<UserEntityNetworkState> userEntityNetworkState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &userEntityNetworkState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__GrowUserEntityNetworkState_b__0_Internal_Void_DynamicBuffer_1_UserEntityNetworkState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass12_0>.NativeClassPtr);
        SetupNetworkIdSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_newLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (newLength));
        SetupNetworkIdSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_oldCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (oldCount));
        SetupNetworkIdSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass12_0>.NativeClassPtr, 100691818);
        SetupNetworkIdSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__GrowUserEntityNetworkState_b__0_Internal_Void_DynamicBuffer_1_UserEntityNetworkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass12_0>.NativeClassPtr, 100691819);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass12_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Network.SetupNetworkIdSystem/ProjectM.Network.<>c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newLength;
      private static readonly System.IntPtr NativeFieldInfoPtr_oldCount;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_UserEntityNetworkState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupNetworkIdSystem_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int newLength;
      [FieldOffset(4)]
      public int oldCount;
      [FieldOffset(8)]
      public SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1154286, RefRangeEnd = 1154287, XrefRangeStart = 1154285, XrefRangeEnd = 1154286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<UserEntityNetworkState> userEntityNetworkState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &userEntityNetworkState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_UserEntityNetworkState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 971955, RefRangeEnd = 971956, XrefRangeStart = 971955, XrefRangeEnd = 971956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupNetworkIdSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1154287, RefRangeEnd = 1154288, XrefRangeStart = 1154287, XrefRangeEnd = 1154287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupNetworkIdSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154288, XrefRangeEnd = 1154290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1154295, RefRangeEnd = 1154296, XrefRangeStart = 1154290, XrefRangeEnd = 1154295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1154298, RefRangeEnd = 1154299, XrefRangeStart = 1154296, XrefRangeEnd = 1154298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupNetworkIdSystem componentSystem,
        ref SetupNetworkIdSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupNetworkIdSystem_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154299, XrefRangeEnd = 1154303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154303, XrefRangeEnd = 1154309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0()
      {
        Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupNetworkIdSystem>.NativeClassPtr, "<>c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_newLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, nameof (newLength));
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_oldCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, nameof (oldCount));
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_UserEntityNetworkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691820);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691821);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691822);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691823);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691824);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupNetworkIdSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691825);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691826);
        SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, 100691827);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_userEntityNetworkState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupNetworkIdSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<UserEntityNetworkState> forParameter_userEntityNetworkState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1154205, RefRangeEnd = 1154206, XrefRangeStart = 1154202, XrefRangeEnd = 1154205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupNetworkIdSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupNetworkIdSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1154209, RefRangeEnd = 1154210, XrefRangeStart = 1154206, XrefRangeEnd = 1154209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_userEntityNetworkState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_userEntityNetworkState));
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupNetworkIdSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691828);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100691829);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_userEntityNetworkState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<UserEntityNetworkState>.Runtime runtime_userEntityNetworkState;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_userEntityNetworkState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_userEntityNetworkState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Network.SetupNetworkIdSystem/ProjectM.Network.<>c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0/ProjectM.Network.RunWithoutJobSystem_00006295$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006295$PostfixBurstDelegate");
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691830);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691831);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691832);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691833);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Network.SetupNetworkIdSystem/ProjectM.Network.<>c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0/ProjectM.Network.RunWithoutJobSystem_00006295$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154210, XrefRangeEnd = 1154224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154224, XrefRangeEnd = 1154242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154242, XrefRangeEnd = 1154257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1154284, RefRangeEnd = 1154285, XrefRangeStart = 1154257, XrefRangeEnd = 1154284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00006295$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691834);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691835);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691836);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691837);
          SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691839);
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
            IL2CPP.il2cpp_field_static_get_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupNetworkIdSystem.__c__DisplayClass_GrowUserEntityNetworkState_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
