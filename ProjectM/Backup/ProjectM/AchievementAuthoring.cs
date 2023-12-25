// Decompiled with JetBrains decompiler
// Type: ProjectM.AchievementAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class AchievementAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_JournalCategory;
    private static readonly IntPtr NativeFieldInfoPtr_JournalTooltip;
    private static readonly IntPtr NativeFieldInfoPtr_Quest;
    private static readonly IntPtr NativeFieldInfoPtr_Flavor;
    private static readonly IntPtr NativeFieldInfoPtr_Reward;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideRewardText;
    private static readonly IntPtr NativeFieldInfoPtr_AchievementSubTaskPrefabs;
    private static readonly IntPtr NativeFieldInfoPtr_Dependency;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996408, XrefRangeEnd = 996436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementAuthoring()
    {
      Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AchievementAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr);
      AchievementAuthoring.NativeFieldInfoPtr_JournalCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (JournalCategory));
      AchievementAuthoring.NativeFieldInfoPtr_JournalTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (JournalTooltip));
      AchievementAuthoring.NativeFieldInfoPtr_Quest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (Quest));
      AchievementAuthoring.NativeFieldInfoPtr_Flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (Flavor));
      AchievementAuthoring.NativeFieldInfoPtr_Reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (Reward));
      AchievementAuthoring.NativeFieldInfoPtr_OverrideRewardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (OverrideRewardText));
      AchievementAuthoring.NativeFieldInfoPtr_AchievementSubTaskPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (AchievementSubTaskPrefabs));
      AchievementAuthoring.NativeFieldInfoPtr_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, nameof (Dependency));
      AchievementAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, 100677016);
      AchievementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementAuthoring>.NativeClassPtr, 100677017);
    }

    public AchievementAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe JournalCategoryType JournalCategory
    {
      get
      {
        return *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_JournalCategory));
      }
      [param: In] set
      {
        *(JournalCategoryType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_JournalCategory)) = value;
      }
    }

    public unsafe JournalTooltipAsset JournalTooltip
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_JournalTooltip));
        return pointer == IntPtr.Zero ? (JournalTooltipAsset) null : new JournalTooltipAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_JournalTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Quest
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Quest));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Quest)) = value;
      }
    }

    public unsafe LocalizationKey Flavor
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Flavor));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Flavor)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Reward
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Reward));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Reward), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey OverrideRewardText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_OverrideRewardText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_OverrideRewardText)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<AchievementSubTaskAuthoring>> AchievementSubTaskPrefabs
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_AchievementSubTaskPrefabs));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<AchievementSubTaskAuthoring>>) null : new Il2CppReferenceArray<WeakAssetReference<AchievementSubTaskAuthoring>>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_AchievementSubTaskPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Dependency
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Dependency));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementAuthoring.NativeFieldInfoPtr_Dependency), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
