// Decompiled with JetBrains decompiler
// Type: ProjectM.JewelItemAsset
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
  public class JewelItemAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_RootSpellMods;
    private static readonly IntPtr NativeFieldInfoPtr_Tier1;
    private static readonly IntPtr NativeFieldInfoPtr_Tier2;
    private static readonly IntPtr NativeFieldInfoPtr_Tier3;
    private static readonly IntPtr NativeFieldInfoPtr_Tier4;
    private static readonly IntPtr NativeFieldInfoPtr_Shared;
    private static readonly IntPtr NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGeneratorBlob_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1036624, RefRangeEnd = 1036626, XrefRangeStart = 1036570, XrefRangeEnd = 1036624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<SpellModSetGeneratorBlob> BuildBlob(PrefabGUID abilityGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &abilityGuid;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelItemAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGeneratorBlob_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<SpellModSetGeneratorBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JewelItemAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelItemAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JewelItemAsset()
    {
      Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JewelItemAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr);
      JewelItemAsset.NativeFieldInfoPtr_RootSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, nameof (RootSpellMods));
      JewelItemAsset.NativeFieldInfoPtr_Tier1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, nameof (Tier1));
      JewelItemAsset.NativeFieldInfoPtr_Tier2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, nameof (Tier2));
      JewelItemAsset.NativeFieldInfoPtr_Tier3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, nameof (Tier3));
      JewelItemAsset.NativeFieldInfoPtr_Tier4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, nameof (Tier4));
      JewelItemAsset.NativeFieldInfoPtr_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, nameof (Shared));
      JewelItemAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGeneratorBlob_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, 100681119);
      JewelItemAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelItemAsset>.NativeClassPtr, 100681120);
    }

    public JewelItemAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SpellModAsset> RootSpellMods
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_RootSpellMods));
        return pointer == IntPtr.Zero ? (List<SpellModAsset>) null : new List<SpellModAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_RootSpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelTierAuthoring Tier1
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier1));
        return pointer == IntPtr.Zero ? (JewelTierAuthoring) null : new JewelTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelTierAuthoring Tier2
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier2));
        return pointer == IntPtr.Zero ? (JewelTierAuthoring) null : new JewelTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelTierAuthoring Tier3
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier3));
        return pointer == IntPtr.Zero ? (JewelTierAuthoring) null : new JewelTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JewelTierAuthoring Tier4
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier4));
        return pointer == IntPtr.Zero ? (JewelTierAuthoring) null : new JewelTierAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Tier4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<JewelItemAsset> Shared
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Shared));
        return pointer == IntPtr.Zero ? (List<JewelItemAsset>) null : new List<JewelItemAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelItemAsset.NativeFieldInfoPtr_Shared), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
