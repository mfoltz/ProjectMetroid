// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodAbilityUtilities
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class VBloodAbilityUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyVBloodAbility_Public_Static_ApplyVBloodAbilityResult_BuffSpawnerSystemData_PrefabLookupMap_Entity_UnlockedAbilityElement_VBloodAbilityApplyType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryApplyVBloodAbility_Public_Static_ApplyVBloodAbilityResult_BuffSpawnerSystemData_PrefabLookupMap_Entity_PrefabGUID_VBloodAbilityApplyType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateBuff_Public_Static_Void_BuffSpawnerSystemData_Entity_Entity_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateBuff2_Public_Static_Void_BuffSpawnerSystemData_Entity_Entity_PrefabGUID_Int32_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1042901, RefRangeEnd = 1042904, XrefRangeStart = 1042900, XrefRangeEnd = 1042901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ApplyVBloodAbilityResult TryApplyVBloodAbility(
      BuffUtility.BuffSpawnerSystemData buffSpawnerSystemData,
      PrefabLookupMap prefabMap,
      Entity character,
      UnlockedAbilityElement ability,
      VBloodAbilityApplyType applyType = VBloodAbilityApplyType.RemovePreviousOnSlot,
      bool primarySlot = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffSpawnerSystemData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ability;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &applyType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &primarySlot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodAbilityUtilities.NativeMethodInfoPtr_TryApplyVBloodAbility_Public_Static_ApplyVBloodAbilityResult_BuffSpawnerSystemData_PrefabLookupMap_Entity_UnlockedAbilityElement_VBloodAbilityApplyType_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ApplyVBloodAbilityResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1042936, RefRangeEnd = 1042938, XrefRangeStart = 1042904, XrefRangeEnd = 1042936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ApplyVBloodAbilityResult TryApplyVBloodAbility(
      BuffUtility.BuffSpawnerSystemData buffSpawnerSystemData,
      PrefabLookupMap prefabMap,
      Entity character,
      PrefabGUID abilityGuid,
      VBloodAbilityApplyType applyType = VBloodAbilityApplyType.RemovePreviousOnSlot,
      bool primarySlot = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffSpawnerSystemData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &applyType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &primarySlot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodAbilityUtilities.NativeMethodInfoPtr_TryApplyVBloodAbility_Public_Static_ApplyVBloodAbilityResult_BuffSpawnerSystemData_PrefabLookupMap_Entity_PrefabGUID_VBloodAbilityApplyType_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ApplyVBloodAbilityResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1042943, RefRangeEnd = 1042944, XrefRangeStart = 1042938, XrefRangeEnd = 1042943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InstantiateBuff(
      BuffUtility.BuffSpawnerSystemData buffSpawnerSystemData,
      Entity character,
      Entity buffPrefab,
      PrefabGUID abilityGuid,
      int slotId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffSpawnerSystemData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &slotId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodAbilityUtilities.NativeMethodInfoPtr_InstantiateBuff_Public_Static_Void_BuffSpawnerSystemData_Entity_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1042963, RefRangeEnd = 1042964, XrefRangeStart = 1042944, XrefRangeEnd = 1042963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InstantiateBuff2(
      BuffUtility.BuffSpawnerSystemData buffSpawnerSystemData,
      Entity character,
      Entity buffPrefab,
      PrefabGUID abilityGuid,
      int slotId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffSpawnerSystemData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &slotId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodAbilityUtilities.NativeMethodInfoPtr_InstantiateBuff2_Public_Static_Void_BuffSpawnerSystemData_Entity_Entity_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodAbilityUtilities()
    {
      Il2CppClassPointerStore<VBloodAbilityUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VBloodAbilityUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodAbilityUtilities>.NativeClassPtr);
      VBloodAbilityUtilities.NativeMethodInfoPtr_TryApplyVBloodAbility_Public_Static_ApplyVBloodAbilityResult_BuffSpawnerSystemData_PrefabLookupMap_Entity_UnlockedAbilityElement_VBloodAbilityApplyType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodAbilityUtilities>.NativeClassPtr, 100681731);
      VBloodAbilityUtilities.NativeMethodInfoPtr_TryApplyVBloodAbility_Public_Static_ApplyVBloodAbilityResult_BuffSpawnerSystemData_PrefabLookupMap_Entity_PrefabGUID_VBloodAbilityApplyType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodAbilityUtilities>.NativeClassPtr, 100681732);
      VBloodAbilityUtilities.NativeMethodInfoPtr_InstantiateBuff_Public_Static_Void_BuffSpawnerSystemData_Entity_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodAbilityUtilities>.NativeClassPtr, 100681733);
      VBloodAbilityUtilities.NativeMethodInfoPtr_InstantiateBuff2_Public_Static_Void_BuffSpawnerSystemData_Entity_Entity_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodAbilityUtilities>.NativeClassPtr, 100681734);
    }

    public VBloodAbilityUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
