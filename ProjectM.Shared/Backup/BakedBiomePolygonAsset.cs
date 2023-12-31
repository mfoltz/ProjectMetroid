// Decompiled with JetBrains decompiler
// Type: BakedBiomePolygonAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class BakedBiomePolygonAsset : ScriptableObject
{
  private static readonly IntPtr NativeFieldInfoPtr_BiomePolygonMaskArray;
  private static readonly IntPtr NativeFieldInfoPtr_OceanPolygonMaskArray;
  private static readonly IntPtr NativeFieldInfoPtr_Biomes;
  private static readonly IntPtr NativeFieldInfoPtr_OceanColors;
  private static readonly IntPtr NativeFieldInfoPtr_BiomeIndices;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BakedBiomePolygonAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BakedBiomePolygonAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BakedBiomePolygonAsset()
  {
    Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (BakedBiomePolygonAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr);
    BakedBiomePolygonAsset.NativeFieldInfoPtr_BiomePolygonMaskArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr, nameof (BiomePolygonMaskArray));
    BakedBiomePolygonAsset.NativeFieldInfoPtr_OceanPolygonMaskArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr, nameof (OceanPolygonMaskArray));
    BakedBiomePolygonAsset.NativeFieldInfoPtr_Biomes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr, nameof (Biomes));
    BakedBiomePolygonAsset.NativeFieldInfoPtr_OceanColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr, nameof (OceanColors));
    BakedBiomePolygonAsset.NativeFieldInfoPtr_BiomeIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr, nameof (BiomeIndices));
    BakedBiomePolygonAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BakedBiomePolygonAsset>.NativeClassPtr, 100663336);
  }

  public BakedBiomePolygonAsset(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Texture2DArray BiomePolygonMaskArray
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_BiomePolygonMaskArray));
      return pointer == IntPtr.Zero ? (Texture2DArray) null : new Texture2DArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_BiomePolygonMaskArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2DArray OceanPolygonMaskArray
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_OceanPolygonMaskArray));
      return pointer == IntPtr.Zero ? (Texture2DArray) null : new Texture2DArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_OceanPolygonMaskArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<MapBiome> Biomes
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_Biomes));
      return pointer == IntPtr.Zero ? (List<MapBiome>) null : new List<MapBiome>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_Biomes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Color> OceanColors
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_OceanColors));
      return pointer == IntPtr.Zero ? (List<Color>) null : new List<Color>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_OceanColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> BiomeIndices
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_BiomeIndices));
      return pointer == IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BakedBiomePolygonAsset.NativeFieldInfoPtr_BiomeIndices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
