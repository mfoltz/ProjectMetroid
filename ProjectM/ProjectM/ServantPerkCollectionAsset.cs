// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantPerkCollectionAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ServantPerkCollectionAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FactionPerks;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodTypePerks;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993079, XrefRangeEnd = 993100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantPerkCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantPerkCollectionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantPerkCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantPerkCollectionAsset()
    {
      Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantPerkCollectionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr);
      ServantPerkCollectionAsset.NativeFieldInfoPtr_FactionPerks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr, nameof (FactionPerks));
      ServantPerkCollectionAsset.NativeFieldInfoPtr_BloodTypePerks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr, nameof (BloodTypePerks));
      ServantPerkCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr, 100676681);
      ServantPerkCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr, 100676682);
    }

    public ServantPerkCollectionAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<ServantPerkCollectionAsset.FactionPerk_Editor> FactionPerks
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.NativeFieldInfoPtr_FactionPerks));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ServantPerkCollectionAsset.FactionPerk_Editor>) null : new Il2CppReferenceArray<ServantPerkCollectionAsset.FactionPerk_Editor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.NativeFieldInfoPtr_FactionPerks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ServantPerkCollectionAsset.BloodTypePerk_Editor> BloodTypePerks
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.NativeFieldInfoPtr_BloodTypePerks));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ServantPerkCollectionAsset.BloodTypePerk_Editor>) null : new Il2CppReferenceArray<ServantPerkCollectionAsset.BloodTypePerk_Editor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.NativeFieldInfoPtr_BloodTypePerks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class FactionPerk_Editor : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Faction;
      private static readonly System.IntPtr NativeFieldInfoPtr_PerkAsset;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FactionPerk_Editor()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantPerkCollectionAsset.FactionPerk_Editor>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantPerkCollectionAsset.FactionPerk_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FactionPerk_Editor()
      {
        Il2CppClassPointerStore<ServantPerkCollectionAsset.FactionPerk_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr, nameof (FactionPerk_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPerkCollectionAsset.FactionPerk_Editor>.NativeClassPtr);
        ServantPerkCollectionAsset.FactionPerk_Editor.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPerkCollectionAsset.FactionPerk_Editor>.NativeClassPtr, nameof (Faction));
        ServantPerkCollectionAsset.FactionPerk_Editor.NativeFieldInfoPtr_PerkAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPerkCollectionAsset.FactionPerk_Editor>.NativeClassPtr, nameof (PerkAsset));
        ServantPerkCollectionAsset.FactionPerk_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPerkCollectionAsset.FactionPerk_Editor>.NativeClassPtr, 100676683);
      }

      public FactionPerk_Editor(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe FactionAsset Faction
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.FactionPerk_Editor.NativeFieldInfoPtr_Faction));
          return pointer == System.IntPtr.Zero ? (FactionAsset) null : new FactionAsset(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.FactionPerk_Editor.NativeFieldInfoPtr_Faction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WeakAssetReference<PerkDataAsset> PerkAsset
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.FactionPerk_Editor.NativeFieldInfoPtr_PerkAsset));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<PerkDataAsset>) null : new WeakAssetReference<PerkDataAsset>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.FactionPerk_Editor.NativeFieldInfoPtr_PerkAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [Serializable]
    public class BloodTypePerk_Editor : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_BloodType;
      private static readonly System.IntPtr NativeFieldInfoPtr_PerkAsset;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BloodTypePerk_Editor()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantPerkCollectionAsset.BloodTypePerk_Editor>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BloodTypePerk_Editor()
      {
        Il2CppClassPointerStore<ServantPerkCollectionAsset.BloodTypePerk_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantPerkCollectionAsset>.NativeClassPtr, nameof (BloodTypePerk_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPerkCollectionAsset.BloodTypePerk_Editor>.NativeClassPtr);
        ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeFieldInfoPtr_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPerkCollectionAsset.BloodTypePerk_Editor>.NativeClassPtr, nameof (BloodType));
        ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeFieldInfoPtr_PerkAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPerkCollectionAsset.BloodTypePerk_Editor>.NativeClassPtr, nameof (PerkAsset));
        ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPerkCollectionAsset.BloodTypePerk_Editor>.NativeClassPtr, 100676684);
      }

      public BloodTypePerk_Editor(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe UnitBloodType BloodType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeFieldInfoPtr_BloodType));
          return pointer == System.IntPtr.Zero ? (UnitBloodType) null : new UnitBloodType(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeFieldInfoPtr_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WeakAssetReference<PerkDataAsset> PerkAsset
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeFieldInfoPtr_PerkAsset));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<PerkDataAsset>) null : new WeakAssetReference<PerkDataAsset>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPerkCollectionAsset.BloodTypePerk_Editor.NativeFieldInfoPtr_PerkAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
