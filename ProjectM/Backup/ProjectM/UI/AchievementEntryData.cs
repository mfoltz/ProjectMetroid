// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AchievementEntryData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public sealed class AchievementEntryData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Dependency;
    private static readonly System.IntPtr NativeFieldInfoPtr_RewardGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_JournalCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Quest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Flavor;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideRewardText;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredCompletedCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubTasks;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_AchievementEntryType_PrefabGUID_PrefabGUID_PrefabGUID_JournalCategoryType_Sprite_LocalizationKey_LocalizationKey_LocalizationKey_LocalizationKey_Int32_Il2CppStructArray_1_AchievementSubTaskEntryData_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1160601, RefRangeEnd = 1160604, XrefRangeStart = 1160599, XrefRangeEnd = 1160601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementEntryData(
      int id,
      AchievementEntryType entryType,
      PrefabGUID achievementGUID,
      PrefabGUID dependency,
      PrefabGUID rewardGuid,
      JournalCategoryType journalCategory,
      Sprite tooltipSprite,
      LocalizationKey tooltipText,
      LocalizationKey quest,
      LocalizationKey flavor,
      LocalizationKey overrideRewardText,
      int requiredCompletedCount,
      Il2CppStructArray<AchievementSubTaskEntryData> subTasks)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[13];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entryType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &achievementGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dependency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rewardGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &journalCategory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tooltipSprite);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipText;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &quest;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &flavor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideRewardText;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredCompletedCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subTasks);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntryData.NativeMethodInfoPtr__ctor_Public_Void_Int32_AchievementEntryType_PrefabGUID_PrefabGUID_PrefabGUID_JournalCategoryType_Sprite_LocalizationKey_LocalizationKey_LocalizationKey_LocalizationKey_Int32_Il2CppStructArray_1_AchievementSubTaskEntryData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementEntryData()
    {
      Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (AchievementEntryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr);
      AchievementEntryData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (ID));
      AchievementEntryData.NativeFieldInfoPtr_EntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (EntryType));
      AchievementEntryData.NativeFieldInfoPtr_AchievementGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (AchievementGUID));
      AchievementEntryData.NativeFieldInfoPtr_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (Dependency));
      AchievementEntryData.NativeFieldInfoPtr_RewardGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (RewardGUID));
      AchievementEntryData.NativeFieldInfoPtr_JournalCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (JournalCategory));
      AchievementEntryData.NativeFieldInfoPtr_TooltipSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (TooltipSprite));
      AchievementEntryData.NativeFieldInfoPtr_TooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (TooltipText));
      AchievementEntryData.NativeFieldInfoPtr_Quest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (Quest));
      AchievementEntryData.NativeFieldInfoPtr_Flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (Flavor));
      AchievementEntryData.NativeFieldInfoPtr_OverrideRewardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (OverrideRewardText));
      AchievementEntryData.NativeFieldInfoPtr_RequiredCompletedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (RequiredCompletedCount));
      AchievementEntryData.NativeFieldInfoPtr_SubTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, nameof (SubTasks));
      AchievementEntryData.NativeMethodInfoPtr__ctor_Public_Void_Int32_AchievementEntryType_PrefabGUID_PrefabGUID_PrefabGUID_JournalCategoryType_Sprite_LocalizationKey_LocalizationKey_LocalizationKey_LocalizationKey_Int32_Il2CppStructArray_1_AchievementSubTaskEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, 100692252);
    }

    public AchievementEntryData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AchievementEntryData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, data));
    }

    public unsafe int ID
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_ID));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_ID)) = value;
      }
    }

    public unsafe AchievementEntryType EntryType
    {
      get
      {
        return *(AchievementEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_EntryType));
      }
      [param: In] set
      {
        *(AchievementEntryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_EntryType)) = value;
      }
    }

    public unsafe PrefabGUID AchievementGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_AchievementGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_AchievementGUID)) = value;
      }
    }

    public unsafe PrefabGUID Dependency
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_Dependency));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_Dependency)) = value;
      }
    }

    public unsafe PrefabGUID RewardGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_RewardGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_RewardGUID)) = value;
      }
    }

    public unsafe JournalCategoryType JournalCategory
    {
      get
      {
        return *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_JournalCategory));
      }
      [param: In] set
      {
        *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_JournalCategory)) = value;
      }
    }

    public unsafe Sprite TooltipSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_TooltipSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_TooltipSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey TooltipText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_TooltipText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_TooltipText)) = value;
      }
    }

    public unsafe LocalizationKey Quest
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_Quest));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_Quest)) = value;
      }
    }

    public unsafe LocalizationKey Flavor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_Flavor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_Flavor)) = value;
      }
    }

    public unsafe LocalizationKey OverrideRewardText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_OverrideRewardText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_OverrideRewardText)) = value;
      }
    }

    public unsafe int RequiredCompletedCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_RequiredCompletedCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_RequiredCompletedCount)) = value;
      }
    }

    public unsafe Il2CppStructArray<AchievementSubTaskEntryData> SubTasks
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_SubTasks));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<AchievementSubTaskEntryData>) null : new Il2CppStructArray<AchievementSubTaskEntryData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntryData.NativeFieldInfoPtr_SubTasks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
