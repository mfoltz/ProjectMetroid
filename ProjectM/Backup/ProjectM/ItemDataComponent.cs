// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemDataComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ItemDataComponent : ItemDataBaseComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_MaxAmount;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_DescriptionBuilder;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_DropItem;
    private static readonly IntPtr NativeFieldInfoPtr_ItemType;
    private static readonly IntPtr NativeFieldInfoPtr_DropItemArcPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SoulBound;
    private static readonly IntPtr NativeFieldInfoPtr_RemoveOnConsume;
    private static readonly IntPtr NativeFieldInfoPtr_IsComplexItem;
    private static readonly IntPtr NativeFieldInfoPtr_ItemCategory;
    private static readonly IntPtr NativeFieldInfoPtr_SilverValue;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Virtual_Final_New_Texture_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992119, XrefRangeEnd = 992176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ItemDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ItemDataComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992176, XrefRangeEnd = 992181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Texture GetIcon()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemDataComponent.NativeMethodInfoPtr_GetIcon_Public_Virtual_Final_New_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Texture) null : new Texture(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992181, XrefRangeEnd = 992182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ItemDataComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemDataComponent()
    {
      Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ItemDataComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr);
      ItemDataComponent.NativeFieldInfoPtr_MaxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (MaxAmount));
      ItemDataComponent.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (Name));
      ItemDataComponent.NativeFieldInfoPtr_DescriptionBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (DescriptionBuilder));
      ItemDataComponent.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (Icon));
      ItemDataComponent.NativeFieldInfoPtr_DropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (DropItem));
      ItemDataComponent.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (ItemType));
      ItemDataComponent.NativeFieldInfoPtr_DropItemArcPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (DropItemArcPrefab));
      ItemDataComponent.NativeFieldInfoPtr_SoulBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (SoulBound));
      ItemDataComponent.NativeFieldInfoPtr_RemoveOnConsume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (RemoveOnConsume));
      ItemDataComponent.NativeFieldInfoPtr_IsComplexItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (IsComplexItem));
      ItemDataComponent.NativeFieldInfoPtr_ItemCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (ItemCategory));
      ItemDataComponent.NativeFieldInfoPtr_SilverValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, nameof (SilverValue));
      ItemDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, 100676598);
      ItemDataComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, 100676599);
      ItemDataComponent.NativeMethodInfoPtr_GetIcon_Public_Virtual_Final_New_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, 100676600);
      ItemDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataComponent>.NativeClassPtr, 100676601);
    }

    public ItemDataComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int MaxAmount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_MaxAmount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_MaxAmount)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizedStringBuilder DescriptionBuilder
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_DescriptionBuilder));
        return pointer == IntPtr.Zero ? (LocalizedStringBuilder) null : new LocalizedStringBuilder(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_DescriptionBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> DropItem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_DropItem));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_DropItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemType ItemType
    {
      get
      {
        return *(ItemType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_ItemType));
      }
      [param: In] set
      {
        *(ItemType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_ItemType)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> DropItemArcPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_DropItemArcPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_DropItemArcPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool SoulBound
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_SoulBound));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_SoulBound)) = value;
      }
    }

    public unsafe bool RemoveOnConsume
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_RemoveOnConsume));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_RemoveOnConsume)) = value;
      }
    }

    public unsafe bool IsComplexItem
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_IsComplexItem));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_IsComplexItem)) = value;
      }
    }

    public unsafe long ItemCategory
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_ItemCategory));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_ItemCategory)) = value;
      }
    }

    public unsafe float SilverValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_SilverValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataComponent.NativeFieldInfoPtr_SilverValue)) = value;
      }
    }
  }
}
