// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.GlobalSpellModSettingsAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Shared
{
  public class GlobalSpellModSettingsAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Tiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePostfixes;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettingType;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPrefabGUID_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGlobalTierData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 748888, RefRangeEnd = 748893, XrefRangeStart = 748888, XrefRangeEnd = 748893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalSpellModSettingsAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798330, XrefRangeEnd = 798336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalSpellModSettingsAsset.NativeMethodInfoPtr_CopyPrefabGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798396, RefRangeEnd = 798397, XrefRangeStart = 798336, XrefRangeEnd = 798396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<SpellModSetGlobalTierData> BuildBlob()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalSpellModSettingsAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGlobalTierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<SpellModSetGlobalTierData>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798397, XrefRangeEnd = 798402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalSpellModSettingsAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GlobalSpellModSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GlobalSpellModSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GlobalSpellModSettingsAsset()
    {
      Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (GlobalSpellModSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr);
      GlobalSpellModSettingsAsset.NativeFieldInfoPtr_Tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, nameof (Tiers));
      GlobalSpellModSettingsAsset.NativeFieldInfoPtr_WeaponTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, nameof (WeaponTypes));
      GlobalSpellModSettingsAsset.NativeFieldInfoPtr_NamePostfixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, nameof (NamePostfixes));
      GlobalSpellModSettingsAsset.NativeFieldInfoPtr_SettingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, nameof (SettingType));
      GlobalSpellModSettingsAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, nameof (_Guid));
      GlobalSpellModSettingsAsset.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, 100670380);
      GlobalSpellModSettingsAsset.NativeMethodInfoPtr_CopyPrefabGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, 100670381);
      GlobalSpellModSettingsAsset.NativeMethodInfoPtr_BuildBlob_Public_BlobAssetReference_1_SpellModSetGlobalTierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, 100670382);
      GlobalSpellModSettingsAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, 100670383);
      GlobalSpellModSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, 100670384);
    }

    public GlobalSpellModSettingsAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<SpellModSetTierData> Tiers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_Tiers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<SpellModSetTierData>) null : new Il2CppStructArray<SpellModSetTierData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_Tiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<SpellModWeaponTypeData> WeaponTypes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_WeaponTypes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<SpellModWeaponTypeData>) null : new Il2CppStructArray<SpellModWeaponTypeData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_WeaponTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<LocalizationKey> NamePostfixes
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_NamePostfixes));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<LocalizationKey>) null : new Il2CppStructArray<LocalizationKey>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_NamePostfixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModGlobalTierBlobReference.ModSettingType SettingType
    {
      get
      {
        return *(SpellModGlobalTierBlobReference.ModSettingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_SettingType));
      }
      [param: In] set
      {
        *(SpellModGlobalTierBlobReference.ModSettingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr_SettingType)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalSpellModSettingsAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [ObfuscatedName("ProjectM.Shared.GlobalSpellModSettingsAsset/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildBlob_b__8_0_Internal_Int32_LocalizationKey_LocalizationKey_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalSpellModSettingsAsset.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GlobalSpellModSettingsAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _BuildBlob_b__8_0(LocalizationKey x, LocalizationKey y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GlobalSpellModSettingsAsset.__c.NativeMethodInfoPtr__BuildBlob_b__8_0_Internal_Int32_LocalizationKey_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<GlobalSpellModSettingsAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalSpellModSettingsAsset>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalSpellModSettingsAsset.__c>.NativeClassPtr);
        GlobalSpellModSettingsAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSpellModSettingsAsset.__c>.NativeClassPtr, "<>9");
        GlobalSpellModSettingsAsset.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalSpellModSettingsAsset.__c>.NativeClassPtr, "<>9__8_0");
        GlobalSpellModSettingsAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSpellModSettingsAsset.__c>.NativeClassPtr, 100670386);
        GlobalSpellModSettingsAsset.__c.NativeMethodInfoPtr__BuildBlob_b__8_0_Internal_Int32_LocalizationKey_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalSpellModSettingsAsset.__c>.NativeClassPtr, 100670387);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GlobalSpellModSettingsAsset.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GlobalSpellModSettingsAsset.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (GlobalSpellModSettingsAsset.__c) null : new GlobalSpellModSettingsAsset.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GlobalSpellModSettingsAsset.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<LocalizationKey> __9__8_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GlobalSpellModSettingsAsset.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<LocalizationKey>) null : new Il2CppSystem.Comparison<LocalizationKey>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GlobalSpellModSettingsAsset.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
