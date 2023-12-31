// Decompiled with JetBrains decompiler
// Type: ProjectM.AiUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public static class AiUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNpcsEnabled_Public_Static_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNpcsEnabled_Public_Static_Boolean_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAiDebugEnabled_Public_Static_Void_ComponentSystemBase_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetTargetPositionFromNetworkedEntity_Public_Static_Boolean_NetworkedEntity_ComponentDataFromEntity_1_Translation_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAimInputs_Public_Static_Void_float2_float2_Single_byref_EntityInput_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAimDirection_Private_Static_float3_float2_float2_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCooldownsDisabled_Public_Static_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetServerTime_Public_Static_Double_SingletonAccessor_1_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfDay_Public_Static_TimeOfDay_SingletonAccessor_1_DayNightCycle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMinionCount_Public_Static_Int32_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFollowersCount_Public_Static_Int32_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxMinions_Public_Static_Int32_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldCombatAreaRelocate_Public_Static_Boolean_byref_float3_byref_AggroConsumer_Single_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 763485, RefRangeEnd = 763489, XrefRangeStart = 763479, XrefRangeEnd = 763485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsNpcsEnabled(
      SingletonAccessor<SyncedServerDebugSettings> serverDebugSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverDebugSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_IsNpcsEnabled_Public_Static_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763489, XrefRangeEnd = 763509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsNpcsEnabled(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_IsNpcsEnabled_Public_Static_Boolean_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763520, RefRangeEnd = 763521, XrefRangeStart = 763509, XrefRangeEnd = 763520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAiDebugEnabled(ComponentSystemBase system, bool enableAiDebug)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &enableAiDebug;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_SetAiDebugEnabled_Public_Static_Void_ComponentSystemBase_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763528, RefRangeEnd = 763531, XrefRangeStart = 763521, XrefRangeEnd = 763528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetTargetPositionFromNetworkedEntity(
      NetworkedEntity entity,
      ComponentDataFromEntity<Translation> getTranslation,
      out float2 targetPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_TryGetTargetPositionFromNetworkedEntity_Public_Static_Boolean_NetworkedEntity_ComponentDataFromEntity_1_Translation_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 763533, RefRangeEnd = 763541, XrefRangeStart = 763531, XrefRangeEnd = 763533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAimInputs(
      float2 position,
      float2 targetPosition,
      float y,
      ref EntityInput entityInput)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityInput;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_SetAimInputs_Public_Static_Void_float2_float2_Single_byref_EntityInput_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe float3 GetAimDirection(float2 position, float2 targetPosition, float y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_GetAimDirection_Private_Static_float3_float2_float2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763547, RefRangeEnd = 763548, XrefRangeStart = 763541, XrefRangeEnd = 763547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsCooldownsDisabled(
      SingletonAccessor<SyncedServerDebugSettings> serverDebugSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverDebugSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_IsCooldownsDisabled_Public_Static_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 763554, RefRangeEnd = 763564, XrefRangeStart = 763548, XrefRangeEnd = 763554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double GetServerTime(SingletonAccessor<ServerTime> accessor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &accessor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_GetServerTime_Public_Static_Double_SingletonAccessor_1_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 763571, RefRangeEnd = 763573, XrefRangeStart = 763564, XrefRangeEnd = 763571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TimeOfDay GetTimeOfDay(SingletonAccessor<DayNightCycle> accessor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &accessor;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_GetTimeOfDay_Public_Static_TimeOfDay_SingletonAccessor_1_DayNightCycle_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TimeOfDay*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763590, RefRangeEnd = 763593, XrefRangeStart = 763573, XrefRangeEnd = 763590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetMinionCount(Entity entity, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_GetMinionCount_Public_Static_Int32_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763593, XrefRangeEnd = 763599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetFollowersCount(Entity entity, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_GetFollowersCount_Public_Static_Int32_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 763627, RefRangeEnd = 763629, XrefRangeStart = 763599, XrefRangeEnd = 763627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetMaxMinions(Entity entity, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_GetMaxMinions_Public_Static_Int32_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763634, RefRangeEnd = 763635, XrefRangeStart = 763629, XrefRangeEnd = 763634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldCombatAreaRelocate(
      [In] ref float3 position,
      [In] ref AggroConsumer aggroConsumer,
      float relocateDistance)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aggroConsumer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relocateDistance;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiUtility.NativeMethodInfoPtr_ShouldCombatAreaRelocate_Public_Static_Boolean_byref_float3_byref_AggroConsumer_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AiUtility()
    {
      Il2CppClassPointerStore<AiUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AiUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiUtility>.NativeClassPtr);
      AiUtility.NativeMethodInfoPtr_IsNpcsEnabled_Public_Static_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667450);
      AiUtility.NativeMethodInfoPtr_IsNpcsEnabled_Public_Static_Boolean_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667451);
      AiUtility.NativeMethodInfoPtr_SetAiDebugEnabled_Public_Static_Void_ComponentSystemBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667452);
      AiUtility.NativeMethodInfoPtr_TryGetTargetPositionFromNetworkedEntity_Public_Static_Boolean_NetworkedEntity_ComponentDataFromEntity_1_Translation_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667453);
      AiUtility.NativeMethodInfoPtr_SetAimInputs_Public_Static_Void_float2_float2_Single_byref_EntityInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667454);
      AiUtility.NativeMethodInfoPtr_GetAimDirection_Private_Static_float3_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667455);
      AiUtility.NativeMethodInfoPtr_IsCooldownsDisabled_Public_Static_Boolean_SingletonAccessor_1_SyncedServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667456);
      AiUtility.NativeMethodInfoPtr_GetServerTime_Public_Static_Double_SingletonAccessor_1_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667457);
      AiUtility.NativeMethodInfoPtr_GetTimeOfDay_Public_Static_TimeOfDay_SingletonAccessor_1_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667458);
      AiUtility.NativeMethodInfoPtr_GetMinionCount_Public_Static_Int32_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667459);
      AiUtility.NativeMethodInfoPtr_GetFollowersCount_Public_Static_Int32_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667460);
      AiUtility.NativeMethodInfoPtr_GetMaxMinions_Public_Static_Int32_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667461);
      AiUtility.NativeMethodInfoPtr_ShouldCombatAreaRelocate_Public_Static_Boolean_byref_float3_byref_AggroConsumer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiUtility>.NativeClassPtr, 100667462);
    }

    public AiUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
