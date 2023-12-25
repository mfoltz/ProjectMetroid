// Decompiled with JetBrains decompiler
// Type: ProjectM.DropTableDataAsset
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
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DropTableDataAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DropItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelicType;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropGroups;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedDropTables;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllDropItems_Public_List_1_DropTableEntryItem_List_1_DropTableDataAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllDropGroups_Public_List_1_DropTableEntryGroup_List_1_DropTableDataAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 992595, RefRangeEnd = 992604, XrefRangeStart = 992595, XrefRangeEnd = 992604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 992595, RefRangeEnd = 992604, XrefRangeStart = 992595, XrefRangeEnd = 992604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1015504, RefRangeEnd = 1015505, XrefRangeStart = 1015466, XrefRangeEnd = 1015504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<DropTableDataAsset.DropTableEntryItem> GetAllDropItems(
      List<DropTableDataAsset> checkedShared = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkedShared);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr_GetAllDropItems_Public_List_1_DropTableEntryItem_List_1_DropTableDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<DropTableDataAsset.DropTableEntryItem>) null : new List<DropTableDataAsset.DropTableEntryItem>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1015543, RefRangeEnd = 1015544, XrefRangeStart = 1015505, XrefRangeEnd = 1015543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<DropTableDataAsset.DropTableEntryGroup> GetAllDropGroups(
      List<DropTableDataAsset> checkedShared = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkedShared);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr_GetAllDropGroups_Public_List_1_DropTableEntryGroup_List_1_DropTableDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<DropTableDataAsset.DropTableEntryGroup>) null : new List<DropTableDataAsset.DropTableEntryGroup>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015544, XrefRangeEnd = 1015552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015552, XrefRangeEnd = 1015568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValidate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropTableDataAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropTableDataAsset()
    {
      Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropTableDataAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr);
      DropTableDataAsset.NativeFieldInfoPtr_DropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (DropItems));
      DropTableDataAsset.NativeFieldInfoPtr_RelicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (RelicType));
      DropTableDataAsset.NativeFieldInfoPtr_DropGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (DropGroups));
      DropTableDataAsset.NativeFieldInfoPtr_SharedDropTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (SharedDropTables));
      DropTableDataAsset.NativeFieldInfoPtr_DropTableLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (DropTableLevel));
      DropTableDataAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (_Guid));
      DropTableDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679182);
      DropTableDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679183);
      DropTableDataAsset.NativeMethodInfoPtr_GetAllDropItems_Public_List_1_DropTableEntryItem_List_1_DropTableDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679184);
      DropTableDataAsset.NativeMethodInfoPtr_GetAllDropGroups_Public_List_1_DropTableEntryGroup_List_1_DropTableDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679185);
      DropTableDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679186);
      DropTableDataAsset.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679187);
      DropTableDataAsset.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679188);
      DropTableDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, 100679189);
    }

    public DropTableDataAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<DropTableDataAsset.DropTableEntryItem> DropItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_DropItems));
        return pointer == System.IntPtr.Zero ? (List<DropTableDataAsset.DropTableEntryItem>) null : new List<DropTableDataAsset.DropTableEntryItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_DropItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RelicType RelicType
    {
      get
      {
        return *(RelicType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_RelicType));
      }
      [param: In] set
      {
        *(RelicType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_RelicType)) = value;
      }
    }

    public unsafe List<DropTableDataAsset.DropTableEntryGroup> DropGroups
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_DropGroups));
        return pointer == System.IntPtr.Zero ? (List<DropTableDataAsset.DropTableEntryGroup>) null : new List<DropTableDataAsset.DropTableEntryGroup>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_DropGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<DropTableDataAsset> SharedDropTables
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_SharedDropTables));
        return pointer == System.IntPtr.Zero ? (List<DropTableDataAsset>) null : new List<DropTableDataAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_SharedDropTables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int DropTableLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_DropTableLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr_DropTableLevel)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public class DropTableEntryItem : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DropItem;
      private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;
      private static readonly System.IntPtr NativeFieldInfoPtr_DropRate;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015465, XrefRangeEnd = 1015466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DropTableEntryItem()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryItem>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.DropTableEntryItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DropTableEntryItem()
      {
        Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (DropTableEntryItem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryItem>.NativeClassPtr);
        DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_DropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryItem>.NativeClassPtr, nameof (DropItem));
        DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryItem>.NativeClassPtr, nameof (Quantity));
        DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_DropRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryItem>.NativeClassPtr, nameof (DropRate));
        DropTableDataAsset.DropTableEntryItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryItem>.NativeClassPtr, 100679190);
      }

      public DropTableEntryItem(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<ItemDataBaseComponent> DropItem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_DropItem));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataBaseComponent>) null : new WeakAssetReference<ItemDataBaseComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_DropItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Quantity
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_Quantity));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_Quantity)) = value;
        }
      }

      public unsafe float DropRate
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_DropRate));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryItem.NativeFieldInfoPtr_DropRate)) = value;
        }
      }
    }

    [Serializable]
    public class DropTableEntryGroup : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DropGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;
      private static readonly System.IntPtr NativeFieldInfoPtr_DropRate;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DropTableEntryGroup()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryGroup>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropTableDataAsset.DropTableEntryGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DropTableEntryGroup()
      {
        Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropTableDataAsset>.NativeClassPtr, nameof (DropTableEntryGroup));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryGroup>.NativeClassPtr);
        DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_DropGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryGroup>.NativeClassPtr, nameof (DropGroup));
        DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryGroup>.NativeClassPtr, nameof (Quantity));
        DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_DropRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryGroup>.NativeClassPtr, nameof (DropRate));
        DropTableDataAsset.DropTableEntryGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableDataAsset.DropTableEntryGroup>.NativeClassPtr, 100679191);
      }

      public DropTableEntryGroup(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WeakAssetReference<ItemDataDropGroupAsset> DropGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_DropGroup));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataDropGroupAsset>) null : new WeakAssetReference<ItemDataDropGroupAsset>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_DropGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Quantity
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_Quantity));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_Quantity)) = value;
        }
      }

      public unsafe float DropRate
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_DropRate));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableDataAsset.DropTableEntryGroup.NativeFieldInfoPtr_DropRate)) = value;
        }
      }
    }
  }
}
