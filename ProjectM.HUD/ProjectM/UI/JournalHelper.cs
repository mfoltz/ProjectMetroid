// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.JournalHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public static class JournalHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedRewardString;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAchievementInProgressData_Public_Static_Boolean_PrefabGUID_List_1_AchievementEntryData_List_1_AchievementInProgressElement_JournalSettings_byref_AchievementInProgressElement_byref_Int32_byref_Int32_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredCompletedAmount_Public_Static_Int32_PrefabGUID_List_1_AchievementEntryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FetchRewardString_Public_Static_LocalizedString_EntityManager_GameDataSystem_PrefabCollectionSystem_JournalSettings_PrefabGUID_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSubTaskProgress_Public_Static_Int32_List_1_AchievementInProgressElement_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSubTaskCompleted_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FetchTechReward_Public_Static_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_DynamicBuffer_1_ProgressionBookTechElement_byref_DynamicBuffer_1_TechUnlockRecipeBuffer_byref_DynamicBuffer_1_TechUnlockBlueprintBuffer_byref_DynamicBuffer_1_ProgressionBookShapeshiftElement_byref_LocalizationKey_byref_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214805, XrefRangeEnd = 1214830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAchievementInProgressData(
      PrefabGUID prefabGuid,
      List<AchievementEntryData> sortedAchievements,
      List<AchievementInProgressElement> completedAchievements,
      JournalSettings settings,
      out AchievementInProgressElement completedAchievementElement,
      out int completedAmount,
      out int requiredAmount,
      out string colorCode)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      numPtr1[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sortedAchievements);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completedAchievements);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref completedAchievementElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref completedAmount;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref requiredAmount;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JournalHelper.NativeMethodInfoPtr_TryGetAchievementInProgressData_Public_Static_Boolean_PrefabGUID_List_1_AchievementEntryData_List_1_AchievementInProgressElement_JournalSettings_byref_AchievementInProgressElement_byref_Int32_byref_Int32_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      colorCode = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1214847, RefRangeEnd = 1214848, XrefRangeStart = 1214830, XrefRangeEnd = 1214847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetRequiredCompletedAmount(
      PrefabGUID requestedAchievement,
      List<AchievementEntryData> sortedAchievements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &requestedAchievement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sortedAchievements);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalHelper.NativeMethodInfoPtr_GetRequiredCompletedAmount_Public_Static_Int32_PrefabGUID_List_1_AchievementEntryData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1215183, RefRangeEnd = 1215185, XrefRangeStart = 1214848, XrefRangeEnd = 1215183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LocalizedString FetchRewardString(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      JournalSettings jSettings,
      PrefabGUID reward,
      LocalizationKey overrideText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jSettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &reward;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideText;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(JournalHelper.NativeMethodInfoPtr_FetchRewardString_Public_Static_LocalizedString_EntityManager_GameDataSystem_PrefabCollectionSystem_JournalSettings_PrefabGUID_LocalizationKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedString(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1215190, RefRangeEnd = 1215191, XrefRangeStart = 1215185, XrefRangeEnd = 1215190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetSubTaskProgress(
      List<AchievementInProgressElement> achievementSubTasksInProgress,
      PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) achievementSubTasksInProgress);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalHelper.NativeMethodInfoPtr_GetSubTaskProgress_Public_Static_Int32_List_1_AchievementInProgressElement_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1215218, RefRangeEnd = 1215221, XrefRangeStart = 1215191, XrefRangeEnd = 1215218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsSubTaskCompleted(
      EntityManager entityManager,
      PrefabCollectionSystem prefabCollectionSystem,
      Entity localUserEntity,
      PrefabGUID subTaskGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localUserEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &subTaskGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalHelper.NativeMethodInfoPtr_IsSubTaskCompleted_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_Entity_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215221, XrefRangeEnd = 1215243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FetchTechReward(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      DynamicBuffer<ProgressionBookTechElement> unlocksTechs,
      out DynamicBuffer<TechUnlockRecipeBuffer> techRecipe,
      out DynamicBuffer<TechUnlockBlueprintBuffer> techBlueprint,
      out DynamicBuffer<ProgressionBookShapeshiftElement> techShapeshifts,
      out LocalizationKey rewardString,
      out bool displayAsGenericUnlock)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &unlocksTechs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref techRecipe;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref techBlueprint;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref techShapeshifts;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref rewardString;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayAsGenericUnlock;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalHelper.NativeMethodInfoPtr_FetchTechReward_Public_Static_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_DynamicBuffer_1_ProgressionBookTechElement_byref_DynamicBuffer_1_TechUnlockRecipeBuffer_byref_DynamicBuffer_1_TechUnlockBlueprintBuffer_byref_DynamicBuffer_1_ProgressionBookShapeshiftElement_byref_LocalizationKey_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JournalHelper()
    {
      Il2CppClassPointerStore<JournalHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (JournalHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr);
      JournalHelper.NativeFieldInfoPtr__CachedRewardString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr, nameof (_CachedRewardString));
      JournalHelper.NativeMethodInfoPtr_TryGetAchievementInProgressData_Public_Static_Boolean_PrefabGUID_List_1_AchievementEntryData_List_1_AchievementInProgressElement_JournalSettings_byref_AchievementInProgressElement_byref_Int32_byref_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr, 100664079);
      JournalHelper.NativeMethodInfoPtr_GetRequiredCompletedAmount_Public_Static_Int32_PrefabGUID_List_1_AchievementEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr, 100664080);
      JournalHelper.NativeMethodInfoPtr_FetchRewardString_Public_Static_LocalizedString_EntityManager_GameDataSystem_PrefabCollectionSystem_JournalSettings_PrefabGUID_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr, 100664081);
      JournalHelper.NativeMethodInfoPtr_GetSubTaskProgress_Public_Static_Int32_List_1_AchievementInProgressElement_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr, 100664082);
      JournalHelper.NativeMethodInfoPtr_IsSubTaskCompleted_Public_Static_Boolean_EntityManager_PrefabCollectionSystem_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr, 100664083);
      JournalHelper.NativeMethodInfoPtr_FetchTechReward_Public_Static_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_DynamicBuffer_1_ProgressionBookTechElement_byref_DynamicBuffer_1_TechUnlockRecipeBuffer_byref_DynamicBuffer_1_TechUnlockBlueprintBuffer_byref_DynamicBuffer_1_ProgressionBookShapeshiftElement_byref_LocalizationKey_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalHelper>.NativeClassPtr, 100664084);
    }

    public JournalHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Dictionary<PrefabGUID, LocalizedString> _CachedRewardString
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalHelper.NativeFieldInfoPtr__CachedRewardString, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, LocalizedString>) null : new Dictionary<PrefabGUID, LocalizedString>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalHelper.NativeFieldInfoPtr__CachedRewardString, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
