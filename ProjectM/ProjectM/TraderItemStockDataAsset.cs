// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderItemStockDataAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class TraderItemStockDataAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_StockAmount;
    private static readonly IntPtr NativeFieldInfoPtr_FullRechargeTime;
    private static readonly IntPtr NativeFieldInfoPtr_RechargeInterval;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TraderItemStockDataAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraderItemStockDataAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TraderItemStockDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TraderItemStockDataAsset()
    {
      Il2CppClassPointerStore<TraderItemStockDataAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TraderItemStockDataAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderItemStockDataAsset>.NativeClassPtr);
      TraderItemStockDataAsset.NativeFieldInfoPtr_StockAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemStockDataAsset>.NativeClassPtr, nameof (StockAmount));
      TraderItemStockDataAsset.NativeFieldInfoPtr_FullRechargeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemStockDataAsset>.NativeClassPtr, nameof (FullRechargeTime));
      TraderItemStockDataAsset.NativeFieldInfoPtr_RechargeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemStockDataAsset>.NativeClassPtr, nameof (RechargeInterval));
      TraderItemStockDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraderItemStockDataAsset>.NativeClassPtr, 100676707);
    }

    public TraderItemStockDataAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int StockAmount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemStockDataAsset.NativeFieldInfoPtr_StockAmount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemStockDataAsset.NativeFieldInfoPtr_StockAmount)) = value;
      }
    }

    public unsafe float FullRechargeTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemStockDataAsset.NativeFieldInfoPtr_FullRechargeTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemStockDataAsset.NativeFieldInfoPtr_FullRechargeTime)) = value;
      }
    }

    public unsafe float RechargeInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemStockDataAsset.NativeFieldInfoPtr_RechargeInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraderItemStockDataAsset.NativeFieldInfoPtr_RechargeInterval)) = value;
      }
    }
  }
}
