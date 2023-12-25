// Decompiled with JetBrains decompiler
// Type: ProjectM.LegendaryItemAsset
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
  public class LegendaryItemAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_StatMods;
    private static readonly IntPtr NativeFieldInfoPtr_Tier1;
    private static readonly IntPtr NativeFieldInfoPtr_Tier2;
    private static readonly IntPtr NativeFieldInfoPtr_Tier3;
    private static readonly IntPtr NativeFieldInfoPtr_Tier4;
    private static readonly IntPtr NativeFieldInfoPtr_Shared;
    private static readonly IntPtr NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGeneratorBlob_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038515, RefRangeEnd = 1038516, XrefRangeStart = 1038461, XrefRangeEnd = 1038515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<SpellModSetGeneratorBlob> BuildBlob()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LegendaryItemAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGeneratorBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<SpellModSetGeneratorBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LegendaryItemAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LegendaryItemAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LegendaryItemAsset()
    {
      Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LegendaryItemAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr);
      LegendaryItemAsset.NativeFieldInfoPtr_StatMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, nameof (StatMods));
      LegendaryItemAsset.NativeFieldInfoPtr_Tier1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, nameof (Tier1));
      LegendaryItemAsset.NativeFieldInfoPtr_Tier2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, nameof (Tier2));
      LegendaryItemAsset.NativeFieldInfoPtr_Tier3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, nameof (Tier3));
      LegendaryItemAsset.NativeFieldInfoPtr_Tier4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, nameof (Tier4));
      LegendaryItemAsset.NativeFieldInfoPtr_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, nameof (Shared));
      LegendaryItemAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGeneratorBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, 100681288);
      LegendaryItemAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegendaryItemAsset>.NativeClassPtr, 100681289);
    }

    public LegendaryItemAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SpellModAsset> StatMods
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_StatMods));
        return pointer == IntPtr.Zero ? (List<SpellModAsset>) null : new List<SpellModAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_StatMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatsTierAuthoring Tier1
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier1));
        return pointer == IntPtr.Zero ? (StatsTierAuthoring) null : new StatsTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatsTierAuthoring Tier2
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier2));
        return pointer == IntPtr.Zero ? (StatsTierAuthoring) null : new StatsTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatsTierAuthoring Tier3
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier3));
        return pointer == IntPtr.Zero ? (StatsTierAuthoring) null : new StatsTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StatsTierAuthoring Tier4
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier4));
        return pointer == IntPtr.Zero ? (StatsTierAuthoring) null : new StatsTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Tier4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<LegendaryItemAsset> Shared
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Shared));
        return pointer == IntPtr.Zero ? (List<LegendaryItemAsset>) null : new List<LegendaryItemAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LegendaryItemAsset.NativeFieldInfoPtr_Shared), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
