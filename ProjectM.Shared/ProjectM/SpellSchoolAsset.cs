// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellSchoolAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SpellSchoolAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ShortName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LongName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffsHeaderColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelevantBuffs;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_TierIcons;
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePrefixes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePostfixes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Abilities;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 461616, RefRangeEnd = 461617, XrefRangeStart = 461616, XrefRangeEnd = 461617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 461616, RefRangeEnd = 461617, XrefRangeStart = 461616, XrefRangeEnd = 461617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728899, XrefRangeEnd = 729038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellSchoolAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellSchoolAsset()
    {
      Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpellSchoolAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr);
      SpellSchoolAsset.NativeFieldInfoPtr_ShortName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (ShortName));
      SpellSchoolAsset.NativeFieldInfoPtr_LongName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (LongName));
      SpellSchoolAsset.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (Description));
      SpellSchoolAsset.NativeFieldInfoPtr_BuffsHeaderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (BuffsHeaderColor));
      SpellSchoolAsset.NativeFieldInfoPtr_RelevantBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (RelevantBuffs));
      SpellSchoolAsset.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (BackgroundImage));
      SpellSchoolAsset.NativeFieldInfoPtr_TierIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (TierIcons));
      SpellSchoolAsset.NativeFieldInfoPtr_NamePrefixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (NamePrefixes));
      SpellSchoolAsset.NativeFieldInfoPtr_NamePostfixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (NamePostfixes));
      SpellSchoolAsset.NativeFieldInfoPtr_Abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (Abilities));
      SpellSchoolAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, nameof (_Guid));
      SpellSchoolAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, 100664544);
      SpellSchoolAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, 100664545);
      SpellSchoolAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, 100664546);
      SpellSchoolAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, 100664547);
    }

    public SpellSchoolAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey ShortName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_ShortName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_ShortName)) = value;
      }
    }

    public unsafe LocalizationKey LongName
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_LongName));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_LongName)) = value;
      }
    }

    public unsafe LocalizationKey Description
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_Description)) = value;
      }
    }

    public unsafe Color BuffsHeaderColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_BuffsHeaderColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_BuffsHeaderColor)) = value;
      }
    }

    public unsafe List<WeakAssetReference<BuffComponent>> RelevantBuffs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_RelevantBuffs));
        return pointer == System.IntPtr.Zero ? (List<WeakAssetReference<BuffComponent>>) null : new List<WeakAssetReference<BuffComponent>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_RelevantBuffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<Sprite> BackgroundImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_BackgroundImage));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<Sprite>) null : new WeakAssetReference<Sprite>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Sprite> TierIcons
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_TierIcons));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_TierIcons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<LocalizationKey> NamePrefixes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_NamePrefixes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<LocalizationKey>) null : new Il2CppStructArray<LocalizationKey>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_NamePrefixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<LocalizationKey> NamePostfixes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_NamePostfixes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<LocalizationKey>) null : new Il2CppStructArray<LocalizationKey>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_NamePostfixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<AbilityGroupComponent>> Abilities
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_Abilities));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<AbilityGroupComponent>>) null : new Il2CppReferenceArray<WeakAssetReference<AbilityGroupComponent>>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr_Abilities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellSchoolAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [ObfuscatedName("ProjectM.SpellSchoolAsset/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__15_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__15_0_Internal_PrefabGUID_WeakAssetReference_1_BuffComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__15_1_Internal_Int32_LocalizationKey_LocalizationKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__15_2_Internal_Int32_LocalizationKey_LocalizationKey_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728897, XrefRangeEnd = 728899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabGUID _Convert_b__15_0(WeakAssetReference<BuffComponent> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.__c.NativeMethodInfoPtr__Convert_b__15_0_Internal_PrefabGUID_WeakAssetReference_1_BuffComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Convert_b__15_1(LocalizationKey x, LocalizationKey y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.__c.NativeMethodInfoPtr__Convert_b__15_1_Internal_Int32_LocalizationKey_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Convert_b__15_2(LocalizationKey x, LocalizationKey y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolAsset.__c.NativeMethodInfoPtr__Convert_b__15_2_Internal_Int32_LocalizationKey_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellSchoolAsset>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr);
        SpellSchoolAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, "<>9");
        SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, "<>9__15_0");
        SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, "<>9__15_1");
        SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, "<>9__15_2");
        SpellSchoolAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, 100664549);
        SpellSchoolAsset.__c.NativeMethodInfoPtr__Convert_b__15_0_Internal_PrefabGUID_WeakAssetReference_1_BuffComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, 100664550);
        SpellSchoolAsset.__c.NativeMethodInfoPtr__Convert_b__15_1_Internal_Int32_LocalizationKey_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, 100664551);
        SpellSchoolAsset.__c.NativeMethodInfoPtr__Convert_b__15_2_Internal_Int32_LocalizationKey_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolAsset.__c>.NativeClassPtr, 100664552);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SpellSchoolAsset.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SpellSchoolAsset.__c) null : new SpellSchoolAsset.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<WeakAssetReference<BuffComponent>, PrefabGUID> __9__15_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<WeakAssetReference<BuffComponent>, PrefabGUID>) null : new Il2CppSystem.Func<WeakAssetReference<BuffComponent>, PrefabGUID>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<LocalizationKey> __9__15_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<LocalizationKey>) null : new Il2CppSystem.Comparison<LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<LocalizationKey> __9__15_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<LocalizationKey>) null : new Il2CppSystem.Comparison<LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpellSchoolAsset.__c.NativeFieldInfoPtr___9__15_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
