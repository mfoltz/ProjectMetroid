// Decompiled with JetBrains decompiler
// Type: ProjectM.AchievementSubTaskAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AchievementSubTaskAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TaskTitle;
    private static readonly IntPtr NativeFieldInfoPtr_ProgressType;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredCompletedCount;
    private static readonly IntPtr NativeFieldInfoPtr_ProgressLinkType;
    private static readonly IntPtr NativeFieldInfoPtr_ReferencedPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ReferencedTech;
    private static readonly IntPtr NativeFieldInfoPtr_EntityCategory;
    private static readonly IntPtr NativeFieldInfoPtr_Condition;
    private static readonly IntPtr NativeFieldInfoPtr_DivideVisualsBy100;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996460, XrefRangeEnd = 996466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AchievementSubTaskAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996466, XrefRangeEnd = 996467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementSubTaskAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementSubTaskAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementSubTaskAuthoring()
    {
      Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AchievementSubTaskAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr);
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_TaskTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (TaskTitle));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_ProgressType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (ProgressType));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_RequiredCompletedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (RequiredCompletedCount));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_ProgressLinkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (ProgressLinkType));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_ReferencedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (ReferencedPrefab));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_ReferencedTech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (ReferencedTech));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_EntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (EntityCategory));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (Condition));
      AchievementSubTaskAuthoring.NativeFieldInfoPtr_DivideVisualsBy100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, nameof (DivideVisualsBy100));
      AchievementSubTaskAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, 100677026);
      AchievementSubTaskAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementSubTaskAuthoring>.NativeClassPtr, 100677027);
    }

    public AchievementSubTaskAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey TaskTitle
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_TaskTitle));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_TaskTitle)) = value;
      }
    }

    public unsafe AchievementProgressType ProgressType
    {
      get
      {
        return *(AchievementProgressType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ProgressType));
      }
      [param: In] set
      {
        *(AchievementProgressType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ProgressType)) = value;
      }
    }

    public unsafe int RequiredCompletedCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_RequiredCompletedCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_RequiredCompletedCount)) = value;
      }
    }

    public unsafe AchievementProgressLinkType ProgressLinkType
    {
      get
      {
        return *(AchievementProgressLinkType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ProgressLinkType));
      }
      [param: In] set
      {
        *(AchievementProgressLinkType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ProgressLinkType)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> ReferencedPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ReferencedPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ReferencedPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<TechDataAsset> ReferencedTech
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ReferencedTech));
        return pointer == IntPtr.Zero ? (WeakAssetReference<TechDataAsset>) null : new WeakAssetReference<TechDataAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_ReferencedTech), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityCategory EntityCategory
    {
      get
      {
        return *(EntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_EntityCategory));
      }
      [param: In] set
      {
        *(EntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_EntityCategory)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Condition
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_Condition));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_Condition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool DivideVisualsBy100
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_DivideVisualsBy100));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubTaskAuthoring.NativeFieldInfoPtr_DivideVisualsBy100)) = value;
      }
    }
  }
}
