// Decompiled with JetBrains decompiler
// Type: ProjectM.EquippableComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Hybrid;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class EquippableComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BuffPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_EquipmentSetAsset;
    private static readonly IntPtr NativeFieldInfoPtr_Model;
    private static readonly IntPtr NativeFieldInfoPtr_FemaleModel;
    private static readonly IntPtr NativeFieldInfoPtr_EquipmentType;
    private static readonly IntPtr NativeFieldInfoPtr_WeaponType;
    private static readonly IntPtr NativeFieldInfoPtr_SCTBrokenText;
    private static readonly IntPtr NativeFieldInfoPtr_HideCharacterHairOnEquip;
    private static readonly IntPtr NativeFieldInfoPtr_HideCharacterFacialFeaturesOnEquip;
    private static readonly IntPtr NativeFieldInfoPtr_HideCharacterHeadOnEquip;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 989433, RefRangeEnd = 989434, XrefRangeStart = 989427, XrefRangeEnd = 989433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(EquippableComponent.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989434, XrefRangeEnd = 989439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EquippableComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EquippableComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquippableComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EquippableComponent()
    {
      Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquippableComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr);
      EquippableComponent.NativeFieldInfoPtr_BuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (BuffPrefab));
      EquippableComponent.NativeFieldInfoPtr_EquipmentSetAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (EquipmentSetAsset));
      EquippableComponent.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (Model));
      EquippableComponent.NativeFieldInfoPtr_FemaleModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (FemaleModel));
      EquippableComponent.NativeFieldInfoPtr_EquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (EquipmentType));
      EquippableComponent.NativeFieldInfoPtr_WeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (WeaponType));
      EquippableComponent.NativeFieldInfoPtr_SCTBrokenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (SCTBrokenText));
      EquippableComponent.NativeFieldInfoPtr_HideCharacterHairOnEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (HideCharacterHairOnEquip));
      EquippableComponent.NativeFieldInfoPtr_HideCharacterFacialFeaturesOnEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (HideCharacterFacialFeaturesOnEquip));
      EquippableComponent.NativeFieldInfoPtr_HideCharacterHeadOnEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, nameof (HideCharacterHeadOnEquip));
      EquippableComponent.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, 100676357);
      EquippableComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, 100676358);
      EquippableComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableComponent>.NativeClassPtr, 100676359);
    }

    public EquippableComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> BuffPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_BuffPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_BuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<ProjectM.EquipmentSetAsset> EquipmentSetAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_EquipmentSetAsset));
        return pointer == IntPtr.Zero ? (WeakAssetReference<ProjectM.EquipmentSetAsset>) null : new WeakAssetReference<ProjectM.EquipmentSetAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_EquipmentSetAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridEquipmentComponent Model
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_Model));
        return pointer == IntPtr.Zero ? (HybridEquipmentComponent) null : new HybridEquipmentComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridEquipmentComponent FemaleModel
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_FemaleModel));
        return pointer == IntPtr.Zero ? (HybridEquipmentComponent) null : new HybridEquipmentComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_FemaleModel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EquipmentType EquipmentType
    {
      get
      {
        return *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_EquipmentType));
      }
      [param: In] set
      {
        *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_EquipmentType)) = value;
      }
    }

    public unsafe WeaponType WeaponType
    {
      get
      {
        return *(WeaponType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_WeaponType));
      }
      [param: In] set
      {
        *(WeaponType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_WeaponType)) = value;
      }
    }

    public unsafe LocalizationKey SCTBrokenText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_SCTBrokenText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_SCTBrokenText)) = value;
      }
    }

    public unsafe bool HideCharacterHairOnEquip
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_HideCharacterHairOnEquip));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_HideCharacterHairOnEquip)) = value;
      }
    }

    public unsafe bool HideCharacterFacialFeaturesOnEquip
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_HideCharacterFacialFeaturesOnEquip));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_HideCharacterFacialFeaturesOnEquip)) = value;
      }
    }

    public unsafe bool HideCharacterHeadOnEquip
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_HideCharacterHeadOnEquip));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquippableComponent.NativeFieldInfoPtr_HideCharacterHeadOnEquip)) = value;
      }
    }
  }
}
