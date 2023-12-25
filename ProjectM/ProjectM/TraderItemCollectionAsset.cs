// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderItemCollectionAsset
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
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class TraderItemCollectionAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCountRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_TradeItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_Collections;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 993337, RefRangeEnd = 993339, XrefRangeStart = 993305, XrefRangeEnd = 993337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(Entity entity, EntityManager dstManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderItemCollectionAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraderItemCollectionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderItemCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraderItemCollectionAsset()
    {
      Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TraderItemCollectionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr);
      TraderItemCollectionAsset.NativeFieldInfoPtr_ItemCountRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr, nameof (ItemCountRange));
      TraderItemCollectionAsset.NativeFieldInfoPtr_TradeItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr, nameof (TradeItems));
      TraderItemCollectionAsset.NativeFieldInfoPtr_Collections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr, nameof (Collections));
      TraderItemCollectionAsset.NativeMethodInfoPtr_Convert_Public_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr, 100676700);
      TraderItemCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr, 100676701);
    }

    public TraderItemCollectionAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int2 ItemCountRange
    {
      get
      {
        return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemCollectionAsset.NativeFieldInfoPtr_ItemCountRange));
      }
      [param: In] set
      {
        *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemCollectionAsset.NativeFieldInfoPtr_ItemCountRange)) = value;
      }
    }

    public unsafe List<TraderEntry_Editor> TradeItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemCollectionAsset.NativeFieldInfoPtr_TradeItems));
        return pointer == System.IntPtr.Zero ? (List<TraderEntry_Editor>) null : new List<TraderEntry_Editor>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemCollectionAsset.NativeFieldInfoPtr_TradeItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TraderItemCollectionAsset> Collections
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemCollectionAsset.NativeFieldInfoPtr_Collections));
        return pointer == System.IntPtr.Zero ? (List<TraderItemCollectionAsset>) null : new List<TraderItemCollectionAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraderItemCollectionAsset.NativeFieldInfoPtr_Collections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct StockData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_StockAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_FullRechargeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_RechargeInterval;
      [FieldOffset(0)]
      public int StockAmount;
      [FieldOffset(4)]
      public float FullRechargeTime;
      [FieldOffset(8)]
      public float RechargeInterval;

      static StockData()
      {
        Il2CppClassPointerStore<TraderItemCollectionAsset.StockData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TraderItemCollectionAsset>.NativeClassPtr, nameof (StockData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderItemCollectionAsset.StockData>.NativeClassPtr);
        TraderItemCollectionAsset.StockData.NativeFieldInfoPtr_StockAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemCollectionAsset.StockData>.NativeClassPtr, nameof (StockAmount));
        TraderItemCollectionAsset.StockData.NativeFieldInfoPtr_FullRechargeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemCollectionAsset.StockData>.NativeClassPtr, nameof (FullRechargeTime));
        TraderItemCollectionAsset.StockData.NativeFieldInfoPtr_RechargeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemCollectionAsset.StockData>.NativeClassPtr, nameof (RechargeInterval));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderItemCollectionAsset.StockData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
