// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class TraderAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MIN_RESTOCK_TIME;
    private static readonly IntPtr NativeFieldInfoPtr_RestockTime;
    private static readonly IntPtr NativeFieldInfoPtr_ItemCollections;
    private static readonly IntPtr NativeFieldInfoPtr_TraderIcon;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProcessCollection_Private_Void_EntityManager_Entity_TraderItemCollectionAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 64928, RefRangeEnd = 64933, XrefRangeStart = 64928, XrefRangeEnd = 64933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TraderAuthoring.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077348, XrefRangeEnd = 1077395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TraderAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077395, XrefRangeEnd = 1077408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TraderAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1077451, RefRangeEnd = 1077452, XrefRangeStart = 1077408, XrefRangeEnd = 1077451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessCollection(
      EntityManager entityManager,
      Entity entity,
      TraderItemCollectionAsset collection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderAuthoring.NativeMethodInfoPtr_ProcessCollection_Private_Void_EntityManager_Entity_TraderItemCollectionAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraderAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraderAuthoring()
    {
      Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TraderAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr);
      TraderAuthoring.NativeFieldInfoPtr_MIN_RESTOCK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, nameof (MIN_RESTOCK_TIME));
      TraderAuthoring.NativeFieldInfoPtr_RestockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, nameof (RestockTime));
      TraderAuthoring.NativeFieldInfoPtr_ItemCollections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, nameof (ItemCollections));
      TraderAuthoring.NativeFieldInfoPtr_TraderIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, nameof (TraderIcon));
      TraderAuthoring.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, nameof (_Guid));
      TraderAuthoring.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, 100684837);
      TraderAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, 100684838);
      TraderAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, 100684839);
      TraderAuthoring.NativeMethodInfoPtr_ProcessCollection_Private_Void_EntityManager_Entity_TraderItemCollectionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, 100684840);
      TraderAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderAuthoring>.NativeClassPtr, 100684841);
    }

    public TraderAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MIN_RESTOCK_TIME
    {
      get
      {
        int minRestockTime;
        IL2CPP.il2cpp_field_static_get_value(TraderAuthoring.NativeFieldInfoPtr_MIN_RESTOCK_TIME, (void*) &minRestockTime);
        return minRestockTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TraderAuthoring.NativeFieldInfoPtr_MIN_RESTOCK_TIME, (void*) &value);
      }
    }

    public unsafe TraderRestockTimeAsset RestockTime
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr_RestockTime));
        return pointer == IntPtr.Zero ? (TraderRestockTimeAsset) null : new TraderRestockTimeAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr_RestockTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TraderItemCollectionAsset> ItemCollections
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr_ItemCollections));
        return pointer == IntPtr.Zero ? (List<TraderItemCollectionAsset>) null : new List<TraderItemCollectionAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr_ItemCollections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite TraderIcon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr_TraderIcon));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr_TraderIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderAuthoring.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
