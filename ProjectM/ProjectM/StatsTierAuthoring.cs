// Decompiled with JetBrains decompiler
// Type: ProjectM.StatsTierAuthoring
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
  public class StatsTierAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddStats;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildBlob_Public_Void_byref_SpellModTierBlob_BlobBuilder_byref_List_1_SpellModAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1038457, RefRangeEnd = 1038461, XrefRangeStart = 1038442, XrefRangeEnd = 1038457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(StatsTierAuthoring.NativeMethodInfoPtr_BuildBlob_Public_Void_byref_SpellModTierBlob_BlobBuilder_byref_List_1_SpellModAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<SpellModAsset> local = ref spellMods;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<SpellModAsset>) list;
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatsTierAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsTierAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsTierAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StatsTierAuthoring()
    {
      Il2CppClassPointerStore<StatsTierAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StatsTierAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsTierAuthoring>.NativeClassPtr);
      StatsTierAuthoring.NativeFieldInfoPtr_AddStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsTierAuthoring>.NativeClassPtr, nameof (AddStats));
      StatsTierAuthoring.NativeMethodInfoPtr_BuildBlob_Public_Void_byref_SpellModTierBlob_BlobBuilder_byref_List_1_SpellModAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsTierAuthoring>.NativeClassPtr, 100681286);
      StatsTierAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsTierAuthoring>.NativeClassPtr, 100681287);
    }

    public StatsTierAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<SpellModAsset> AddStats
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsTierAuthoring.NativeFieldInfoPtr_AddStats));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModAsset>) null : new Il2CppReferenceArray<SpellModAsset>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsTierAuthoring.NativeFieldInfoPtr_AddStats), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
