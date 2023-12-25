// Decompiled with JetBrains decompiler
// Type: ProjectM.YieldEssenceOnDeathComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class YieldEssenceOnDeathComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EssenceAssetSettings;
    private static readonly IntPtr NativeFieldInfoPtr_EssenceStatsType;
    private static readonly IntPtr NativeFieldInfoPtr_EssenceSplitAreaRadius;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideEssence;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideStaticEssence;
    private static readonly IntPtr NativeFieldInfoPtr_EssenceItemType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025180, XrefRangeEnd = 1025206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(YieldEssenceOnDeathComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025206, XrefRangeEnd = 1025207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe YieldEssenceOnDeathComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(YieldEssenceOnDeathComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static YieldEssenceOnDeathComponent()
    {
      Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (YieldEssenceOnDeathComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr);
      YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceAssetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, nameof (EssenceAssetSettings));
      YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, nameof (EssenceStatsType));
      YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceSplitAreaRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, nameof (EssenceSplitAreaRadius));
      YieldEssenceOnDeathComponent.NativeFieldInfoPtr_OverrideEssence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, nameof (OverrideEssence));
      YieldEssenceOnDeathComponent.NativeFieldInfoPtr_OverrideStaticEssence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, nameof (OverrideStaticEssence));
      YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, nameof (EssenceItemType));
      YieldEssenceOnDeathComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, 100680123);
      YieldEssenceOnDeathComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldEssenceOnDeathComponent>.NativeClassPtr, 100680124);
    }

    public YieldEssenceOnDeathComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Essence_StatsSettings_Asset EssenceAssetSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceAssetSettings));
        return pointer == IntPtr.Zero ? (Essence_StatsSettings_Asset) null : new Essence_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceAssetSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe XPBaseType EssenceStatsType
    {
      get
      {
        return *(XPBaseType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceStatsType));
      }
      [param: In] set
      {
        *(XPBaseType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceStatsType)) = value;
      }
    }

    public unsafe float EssenceSplitAreaRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceSplitAreaRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceSplitAreaRadius)) = value;
      }
    }

    public unsafe bool OverrideEssence
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_OverrideEssence));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_OverrideEssence)) = value;
      }
    }

    public unsafe int OverrideStaticEssence
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_OverrideStaticEssence));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_OverrideStaticEssence)) = value;
      }
    }

    public unsafe PrefabGuidComponent EssenceItemType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceItemType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(YieldEssenceOnDeathComponent.NativeFieldInfoPtr_EssenceItemType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
