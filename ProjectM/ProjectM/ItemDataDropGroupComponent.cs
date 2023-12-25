// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemDataDropGroupComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ItemDataDropGroupComponent : ItemDataBaseComponent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Items;
    private static readonly System.IntPtr NativeFieldInfoPtr_Units;
    private static readonly System.IntPtr NativeFieldInfoPtr_Groups;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertedToAsset;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992394, XrefRangeEnd = 992460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupComponent.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ItemDataDropGroupComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemDataDropGroupComponent()
    {
      Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ItemDataDropGroupComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr);
      ItemDataDropGroupComponent.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, nameof (Items));
      ItemDataDropGroupComponent.NativeFieldInfoPtr_Units = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, nameof (Units));
      ItemDataDropGroupComponent.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, nameof (Groups));
      ItemDataDropGroupComponent.NativeFieldInfoPtr_ConvertedToAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, nameof (ConvertedToAsset));
      ItemDataDropGroupComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, 100676614);
      ItemDataDropGroupComponent.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, 100676615);
      ItemDataDropGroupComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, 100676616);
    }

    public ItemDataDropGroupComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ItemDataDropGroupComponent.ItemDataDropItemEntry> Items
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_Items));
        return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupComponent.ItemDataDropItemEntry>) null : new List<ItemDataDropGroupComponent.ItemDataDropItemEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemDataDropGroupComponent.ItemDataDropUnitEntry> Units
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_Units));
        return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupComponent.ItemDataDropUnitEntry>) null : new List<ItemDataDropGroupComponent.ItemDataDropUnitEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_Units), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ItemDataDropGroupComponent.ItemDataDropGroupEntry> Groups
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_Groups));
        return pointer == System.IntPtr.Zero ? (List<ItemDataDropGroupComponent.ItemDataDropGroupEntry>) null : new List<ItemDataDropGroupComponent.ItemDataDropGroupEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_Groups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ItemDataDropGroupAsset ConvertedToAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_ConvertedToAsset));
        return pointer == System.IntPtr.Zero ? (ItemDataDropGroupAsset) null : new ItemDataDropGroupAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.NativeFieldInfoPtr_ConvertedToAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ItemDataDropItemEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropItemEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ItemDataDropItemEntry()
      {
        Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropItemEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, nameof (ItemDataDropItemEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropItemEntry>.NativeClassPtr);
        ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropItemEntry>.NativeClassPtr, nameof (ItemPrefab));
        ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropItemEntry>.NativeClassPtr, nameof (Quantity));
        ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropItemEntry>.NativeClassPtr, nameof (Weight));
        ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropItemEntry>.NativeClassPtr, 100676617);
      }

      public ItemDataDropItemEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<ItemDataComponent> ItemPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_ItemPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Quantity
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_Quantity));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_Quantity)) = value;
        }
      }

      public unsafe int Weight
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropItemEntry.NativeFieldInfoPtr_Weight)) = value;
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
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropUnitEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ItemDataDropUnitEntry()
      {
        Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropUnitEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, nameof (ItemDataDropUnitEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropUnitEntry>.NativeClassPtr);
        ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_UnitPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropUnitEntry>.NativeClassPtr, nameof (UnitPrefab));
        ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropUnitEntry>.NativeClassPtr, nameof (Quantity));
        ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropUnitEntry>.NativeClassPtr, nameof (Weight));
        ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropUnitEntry>.NativeClassPtr, 100676618);
      }

      public ItemDataDropUnitEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<UnitSpawnDropComponent> UnitPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_UnitPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<UnitSpawnDropComponent>) null : new WeakAssetReference<UnitSpawnDropComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_UnitPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Quantity
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_Quantity));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_Quantity)) = value;
        }
      }

      public unsafe int Weight
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropUnitEntry.NativeFieldInfoPtr_Weight)) = value;
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ItemDataDropGroupEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropGroupEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ItemDataDropGroupEntry()
      {
        Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropGroupEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemDataDropGroupComponent>.NativeClassPtr, nameof (ItemDataDropGroupEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropGroupEntry>.NativeClassPtr);
        ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeFieldInfoPtr_GroupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropGroupEntry>.NativeClassPtr, nameof (GroupPrefab));
        ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropGroupEntry>.NativeClassPtr, nameof (Weight));
        ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDataDropGroupComponent.ItemDataDropGroupEntry>.NativeClassPtr, 100676619);
      }

      public ItemDataDropGroupEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<ItemDataDropGroupComponent> GroupPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeFieldInfoPtr_GroupPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataDropGroupComponent>) null : new WeakAssetReference<ItemDataDropGroupComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeFieldInfoPtr_GroupPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Weight
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeFieldInfoPtr_Weight));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemDataDropGroupComponent.ItemDataDropGroupEntry.NativeFieldInfoPtr_Weight)) = value;
        }
      }
    }
  }
}
