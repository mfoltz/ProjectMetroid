// Decompiled with JetBrains decompiler
// Type: ProjectM.JewelTierAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class JewelTierAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddSpellMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomTierData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomTierData;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildBlob_Public_Void_byref_SpellModTierBlob_BlobBuilder_byref_List_1_SpellModAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1036565, RefRangeEnd = 1036569, XrefRangeStart = 1036550, XrefRangeEnd = 1036565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildBlob(
      ref SpellModTierBlob spellModTier,
      BlobBuilder builder,
      ref List<SpellModAsset> spellMods)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) ref spellModTier;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &builder;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spellMods);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelTierAuthoring.NativeMethodInfoPtr_BuildBlob_Public_Void_byref_SpellModTierBlob_BlobBuilder_byref_List_1_SpellModAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SpellModAsset> local = ref spellMods;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SpellModAsset>) list;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036569, XrefRangeEnd = 1036570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JewelTierAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelTierAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JewelTierAuthoring()
    {
      Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JewelTierAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr);
      JewelTierAuthoring.NativeFieldInfoPtr_AddSpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr, nameof (AddSpellMods));
      JewelTierAuthoring.NativeFieldInfoPtr_UseCustomTierData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr, nameof (UseCustomTierData));
      JewelTierAuthoring.NativeFieldInfoPtr_CustomTierData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr, nameof (CustomTierData));
      JewelTierAuthoring.NativeMethodInfoPtr_BuildBlob_Public_Void_byref_SpellModTierBlob_BlobBuilder_byref_List_1_SpellModAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr, 100681117);
      JewelTierAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelTierAuthoring>.NativeClassPtr, 100681118);
    }

    public JewelTierAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<SpellModAsset> AddSpellMods
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelTierAuthoring.NativeFieldInfoPtr_AddSpellMods));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModAsset>) null : new Il2CppReferenceArray<SpellModAsset>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelTierAuthoring.NativeFieldInfoPtr_AddSpellMods), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseCustomTierData
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelTierAuthoring.NativeFieldInfoPtr_UseCustomTierData));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelTierAuthoring.NativeFieldInfoPtr_UseCustomTierData)) = value;
      }
    }

    public unsafe SpellModSetTierData CustomTierData
    {
      get
      {
        return *(SpellModSetTierData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelTierAuthoring.NativeFieldInfoPtr_CustomTierData));
      }
      [param: In] set
      {
        *(SpellModSetTierData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelTierAuthoring.NativeFieldInfoPtr_CustomTierData)) = value;
      }
    }
  }
}
