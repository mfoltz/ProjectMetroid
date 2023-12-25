// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.AiAbilityHelpers
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiAbilityHelpers
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityGroupSlotBuffer_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityStateBuffer_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityStateBuffer_BufferFromEntity_1_AbilityGroupSlotBuffer_byref_DynamicBuffer_1_AbilityStateBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPreviousAbilityStateEntity_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupComboState_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAbilityOnCooldown_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_ComponentDataFromEntity_1_AbilityCooldownState_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityCooldown_Internal_Static_Void_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_ComponentDataFromEntity_1_AbilityCooldownState_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_Single_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAbilityStateBuffer_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_DynamicBuffer_1_AbilityStateBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentAbilityStateEntity_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAbilityOnCooldown_Internal_Static_Boolean_EntityManager_Int32_Entity_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAbilityCooldown_Internal_Static_Void_EntityManager_Int32_Entity_Single_Double_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1335973, RefRangeEnd = 1335981, XrefRangeStart = 1335954, XrefRangeEnd = 1335973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityGroupStateEntity(
      int abilityIndex,
      Entity entity,
      ComponentDataFromEntity<AbilityGroupSlot> getAbilityGroupSlot,
      BufferFromEntity<AbilityGroupSlotBuffer> getAbilityGroupSlotBuffer,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlotBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityGroupSlotBuffer_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335981, XrefRangeEnd = 1335989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityStateBuffer(
      int abilityIndex,
      Entity entity,
      ComponentDataFromEntity<AbilityGroupSlot> getAbilityGroupSlot,
      BufferFromEntity<AbilityStateBuffer> getAbilityStateBuffer,
      BufferFromEntity<AbilityGroupSlotBuffer> getAbilityGroupSlotBuffer,
      out DynamicBuffer<AbilityStateBuffer> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityStateBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlotBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityStateBuffer_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityStateBuffer_BufferFromEntity_1_AbilityGroupSlotBuffer_byref_DynamicBuffer_1_AbilityStateBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335989, XrefRangeEnd = 1335999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetPreviousAbilityStateEntity(
      int abilityIndex,
      Entity entity,
      ComponentDataFromEntity<AbilityGroupComboState> getAbilityGroupComboState,
      ComponentDataFromEntity<AbilityGroupSlot> getAbilityGroupSlot,
      BufferFromEntity<AbilityGroupSlotBuffer> getAbilityGroupSlotBuffer,
      BufferFromEntity<AbilityStateBuffer> getAbilityStateBuffer,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupComboState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlotBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityStateBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_TryGetPreviousAbilityStateEntity_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupComboState_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335999, XrefRangeEnd = 1336023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAbilityOnCooldown(
      int abilityIndex,
      Entity entity,
      ComponentDataFromEntity<AbilityGroupSlot> getAbilityGroupSlot,
      ComponentDataFromEntity<AbilityCooldownState> getAbilityCooldownState,
      BufferFromEntity<AbilityGroupSlotBuffer> getAbilityGroupSlotBuffer,
      BufferFromEntity<AbilityStateBuffer> getAbilityStateBuffer,
      double elapsedTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityCooldownState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlotBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityStateBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &elapsedTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_IsAbilityOnCooldown_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_ComponentDataFromEntity_1_AbilityCooldownState_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1336049, RefRangeEnd = 1336050, XrefRangeStart = 1336023, XrefRangeEnd = 1336049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAbilityCooldown(
      int abilityIndex,
      Entity entity,
      ComponentDataFromEntity<AbilityGroupSlot> getAbilityGroupSlot,
      ComponentDataFromEntity<AbilityCooldownState> getAbilityCooldownState,
      BufferFromEntity<AbilityGroupSlotBuffer> getAbilityGroupSlotBuffer,
      BufferFromEntity<AbilityStateBuffer> getAbilityStateBuffer,
      float cooldown,
      double elapsedTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityCooldownState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityGroupSlotBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getAbilityStateBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldown;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &elapsedTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_SetAbilityCooldown_Internal_Static_Void_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_ComponentDataFromEntity_1_AbilityCooldownState_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_Single_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1336069, RefRangeEnd = 1336071, XrefRangeStart = 1336050, XrefRangeEnd = 1336069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityGroupStateEntity(
      EntityManager entityManager,
      int abilityIndex,
      Entity entity,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1336078, RefRangeEnd = 1336081, XrefRangeStart = 1336071, XrefRangeEnd = 1336078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAbilityStateBuffer(
      EntityManager entityManager,
      int abilityIndex,
      Entity entity,
      out DynamicBuffer<AbilityStateBuffer> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityStateBuffer_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_DynamicBuffer_1_AbilityStateBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1336085, RefRangeEnd = 1336087, XrefRangeStart = 1336081, XrefRangeEnd = 1336085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetCurrentAbilityStateEntity(
      EntityManager entityManager,
      int abilityIndex,
      Entity entity,
      out Entity result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_TryGetCurrentAbilityStateEntity_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1336105, RefRangeEnd = 1336107, XrefRangeStart = 1336087, XrefRangeEnd = 1336105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAbilityOnCooldown(
      EntityManager entityManager,
      int abilityIndex,
      Entity entity,
      double elapsedTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &elapsedTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_IsAbilityOnCooldown_Internal_Static_Boolean_EntityManager_Int32_Entity_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1336127, RefRangeEnd = 1336128, XrefRangeStart = 1336107, XrefRangeEnd = 1336127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetAbilityCooldown(
      EntityManager entityManager,
      int abilityIndex,
      Entity entity,
      float cooldown,
      double elapsedTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &cooldown;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &elapsedTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiAbilityHelpers.NativeMethodInfoPtr_SetAbilityCooldown_Internal_Static_Void_EntityManager_Int32_Entity_Single_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AiAbilityHelpers()
    {
      Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (AiAbilityHelpers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr);
      AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityGroupSlotBuffer_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664423);
      AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityStateBuffer_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityStateBuffer_BufferFromEntity_1_AbilityGroupSlotBuffer_byref_DynamicBuffer_1_AbilityStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664424);
      AiAbilityHelpers.NativeMethodInfoPtr_TryGetPreviousAbilityStateEntity_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupComboState_ComponentDataFromEntity_1_AbilityGroupSlot_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664425);
      AiAbilityHelpers.NativeMethodInfoPtr_IsAbilityOnCooldown_Internal_Static_Boolean_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_ComponentDataFromEntity_1_AbilityCooldownState_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664426);
      AiAbilityHelpers.NativeMethodInfoPtr_SetAbilityCooldown_Internal_Static_Void_Int32_Entity_ComponentDataFromEntity_1_AbilityGroupSlot_ComponentDataFromEntity_1_AbilityCooldownState_BufferFromEntity_1_AbilityGroupSlotBuffer_BufferFromEntity_1_AbilityStateBuffer_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664427);
      AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityGroupStateEntity_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664428);
      AiAbilityHelpers.NativeMethodInfoPtr_TryGetAbilityStateBuffer_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_DynamicBuffer_1_AbilityStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664429);
      AiAbilityHelpers.NativeMethodInfoPtr_TryGetCurrentAbilityStateEntity_Internal_Static_Boolean_EntityManager_Int32_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664430);
      AiAbilityHelpers.NativeMethodInfoPtr_IsAbilityOnCooldown_Internal_Static_Boolean_EntityManager_Int32_Entity_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664431);
      AiAbilityHelpers.NativeMethodInfoPtr_SetAbilityCooldown_Internal_Static_Void_EntityManager_Int32_Entity_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, 100664432);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiAbilityHelpers>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
