// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemDataDropGroupAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ItemDataDropGroupAsset : ItemDataBaseAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UIInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_Items;
    private static readonly System.IntPtr NativeFieldInfoPtr_Units;
    private static readonly System.IntPtr NativeFieldInfoPtr_Groups;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedGroups;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertedFromComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDataDropItemEntry_List_1_ItemDataDropGroupAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllUnits_Public_List_1_ItemDataDropUnitEntry_List_1_ItemDataDropGroupAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllGroups_Public_List_1_ItemDataDropGroupEntry_List_1_ItemDataDropGroupAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992184, XrefRangeEnd = 992185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 992223, RefRangeEnd = 992225, XrefRangeStart = 992185, XrefRangeEnd = 992223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<ItemDataDropGroupAsset.ItemDataDropItemEntry> GetAllItems(
      List<ItemDataDropGroupAsset> checkedGroups = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkedGroups);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDataDropItemEntry_List_1_ItemDataDropGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupAsset.ItemDataDropItemEntry>) null : new List<ItemDataDropGroupAsset.ItemDataDropItemEntry>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 992263, RefRangeEnd = 992265, XrefRangeStart = 992225, XrefRangeEnd = 992263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<ItemDataDropGroupAsset.ItemDataDropUnitEntry> GetAllUnits(
      List<ItemDataDropGroupAsset> checkedGroups = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkedGroups);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr_GetAllUnits_Public_List_1_ItemDataDropUnitEntry_List_1_ItemDataDropGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupAsset.ItemDataDropUnitEntry>) null : new List<ItemDataDropGroupAsset.ItemDataDropUnitEntry>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 992303, RefRangeEnd = 992305, XrefRangeStart = 992265, XrefRangeEnd = 992303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<ItemDataDropGroupAsset.ItemDataDropGroupEntry> GetAllGroups(
      List<ItemDataDropGroupAsset> checkedGroups = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkedGroups);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr_GetAllGroups_Public_List_1_ItemDataDropGroupEntry_List_1_ItemDataDropGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupAsset.ItemDataDropGroupEntry>) null : new List<ItemDataDropGroupAsset.ItemDataDropGroupEntry>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992305, XrefRangeEnd = 992394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_Shared_IChunkSummaryDataSource_FillTree(
      ChunkSummaryBuilder summary)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summary);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ItemDataDropGroupAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemDataDropGroupAsset()
    {
      Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ItemDataDropGroupAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr);
      ItemDataDropGroupAsset.NativeFieldInfoPtr_UIInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (UIInfo));
      ItemDataDropGroupAsset.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (Items));
      ItemDataDropGroupAsset.NativeFieldInfoPtr_Units = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (Units));
      ItemDataDropGroupAsset.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (Groups));
      ItemDataDropGroupAsset.NativeFieldInfoPtr_SharedGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (SharedGroups));
      ItemDataDropGroupAsset.NativeFieldInfoPtr_ConvertedFromComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (ConvertedFromComponent));
      ItemDataDropGroupAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (_Guid));
      ItemDataDropGroupAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676602);
      ItemDataDropGroupAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676603);
      ItemDataDropGroupAsset.NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDataDropItemEntry_List_1_ItemDataDropGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676604);
      ItemDataDropGroupAsset.NativeMethodInfoPtr_GetAllUnits_Public_List_1_ItemDataDropUnitEntry_List_1_ItemDataDropGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676605);
      ItemDataDropGroupAsset.NativeMethodInfoPtr_GetAllGroups_Public_List_1_ItemDataDropGroupEntry_List_1_ItemDataDropGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676606);
      ItemDataDropGroupAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676607);
      ItemDataDropGroupAsset.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676608);
      ItemDataDropGroupAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, 100676609);
    }

    public ItemDataDropGroupAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ItemDataDropGroupAsset.ItemDataDropGroupUI UIInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_UIInfo));
        return pointer == System.IntPtr.Zero ? (ItemDataDropGroupAsset.ItemDataDropGroupUI) null : new ItemDataDropGroupAsset.ItemDataDropGroupUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_UIInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemDataDropGroupAsset.ItemDataDropItemEntry> Items
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_Items));
        return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupAsset.ItemDataDropItemEntry>) null : new List<ItemDataDropGroupAsset.ItemDataDropItemEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemDataDropGroupAsset.ItemDataDropUnitEntry> Units
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_Units));
        return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupAsset.ItemDataDropUnitEntry>) null : new List<ItemDataDropGroupAsset.ItemDataDropUnitEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_Units), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemDataDropGroupAsset.ItemDataDropGroupEntry> Groups
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_Groups));
        return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupAsset.ItemDataDropGroupEntry>) null : new List<ItemDataDropGroupAsset.ItemDataDropGroupEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_Groups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemDataDropGroupAsset> SharedGroups
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_SharedGroups));
        return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupAsset>) null : new List<ItemDataDropGroupAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_SharedGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemDataDropGroupComponent ConvertedFromComponent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_ConvertedFromComponent));
        return pointer == System.IntPtr.Zero ? (ItemDataDropGroupComponent) null : new ItemDataDropGroupComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr_ConvertedFromComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public class ItemDataDropItemEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992182, XrefRangeEnd = 992183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ItemDataDropItemEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropItemEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ItemDataDropItemEntry()
      {
        Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropItemEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (ItemDataDropItemEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropItemEntry>.NativeClassPtr);
        ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropItemEntry>.NativeClassPtr, nameof (ItemPrefab));
        ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropItemEntry>.NativeClassPtr, nameof (Quantity));
        ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropItemEntry>.NativeClassPtr, nameof (Weight));
        ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropItemEntry>.NativeClassPtr, 100676610);
      }

      public ItemDataDropItemEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<ItemDataComponent> ItemPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_ItemPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Quantity
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_Quantity));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_Quantity)) = value;
        }
      }

      public unsafe int Weight
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropItemEntry.NativeFieldInfoPtr_Weight)) = value;
        }
      }
    }

    [Serializable]
    public class ItemDataDropUnitEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ItemDataDropUnitEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropUnitEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ItemDataDropUnitEntry()
      {
        Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropUnitEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (ItemDataDropUnitEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropUnitEntry>.NativeClassPtr);
        ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_UnitPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropUnitEntry>.NativeClassPtr, nameof (UnitPrefab));
        ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropUnitEntry>.NativeClassPtr, nameof (Quantity));
        ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropUnitEntry>.NativeClassPtr, nameof (Weight));
        ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropUnitEntry>.NativeClassPtr, 100676611);
      }

      public ItemDataDropUnitEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<UnitSpawnDropComponent> UnitPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_UnitPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<UnitSpawnDropComponent>) null : new WeakAssetReference<UnitSpawnDropComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_UnitPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Quantity
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_Quantity));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_Quantity)) = value;
        }
      }

      public unsafe int Weight
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropUnitEntry.NativeFieldInfoPtr_Weight)) = value;
        }
      }
    }

    [Serializable]
    public class ItemDataDropGroupEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GroupPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992183, XrefRangeEnd = 992184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ItemDataDropGroupEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ItemDataDropGroupEntry()
      {
        Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (ItemDataDropGroupEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupEntry>.NativeClassPtr);
        ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeFieldInfoPtr_GroupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupEntry>.NativeClassPtr, nameof (GroupPrefab));
        ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupEntry>.NativeClassPtr, nameof (Weight));
        ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupEntry>.NativeClassPtr, 100676612);
      }

      public ItemDataDropGroupEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<ItemDataDropGroupAsset> GroupPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeFieldInfoPtr_GroupPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataDropGroupAsset>) null : new WeakAssetReference<ItemDataDropGroupAsset>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeFieldInfoPtr_GroupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Weight
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupEntry.NativeFieldInfoPtr_Weight)) = value;
        }
      }
    }

    [Serializable]
    public class ItemDataDropGroupUI : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_DropGroupName;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ItemDataDropGroupUI()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupUI>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ItemDataDropGroupUI()
      {
        Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemDataDropGroupAsset>.NativeClassPtr, nameof (ItemDataDropGroupUI));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupUI>.NativeClassPtr);
        ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupUI>.NativeClassPtr, nameof (Icon));
        ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeFieldInfoPtr_DropGroupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupUI>.NativeClassPtr, nameof (DropGroupName));
        ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupAsset.ItemDataDropGroupUI>.NativeClassPtr, 100676613);
      }

      public ItemDataDropGroupUI(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe LocalizationKey DropGroupName
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeFieldInfoPtr_DropGroupName));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupAsset.ItemDataDropGroupUI.NativeFieldInfoPtr_DropGroupName)) = value;
        }
      }
    }
  }
}
