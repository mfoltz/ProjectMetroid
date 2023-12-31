// Decompiled with JetBrains decompiler
// Type: ProjectM.CharacterCustomizationSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CharacterCustomizationSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_SkintoneColors;
    private static readonly IntPtr NativeFieldInfoPtr_EyeColors;
    private static readonly IntPtr NativeFieldInfoPtr_HairColors;
    private static readonly IntPtr NativeFieldInfoPtr_MaleFaces;
    private static readonly IntPtr NativeFieldInfoPtr_MaleHairs;
    private static readonly IntPtr NativeFieldInfoPtr_MaleFeatures;
    private static readonly IntPtr NativeFieldInfoPtr_MaleAccessories;
    private static readonly IntPtr NativeFieldInfoPtr_FemaleFaces;
    private static readonly IntPtr NativeFieldInfoPtr_FemaleHairs;
    private static readonly IntPtr NativeFieldInfoPtr_FemaleFeatures;
    private static readonly IntPtr NativeFieldInfoPtr_FemaleAccessories;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722792, XrefRangeEnd = 722793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSettings.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722793, XrefRangeEnd = 722869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterCustomizationSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterCustomizationSettings()
    {
      Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CharacterCustomizationSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr);
      CharacterCustomizationSettings.NativeFieldInfoPtr_SkintoneColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (SkintoneColors));
      CharacterCustomizationSettings.NativeFieldInfoPtr_EyeColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (EyeColors));
      CharacterCustomizationSettings.NativeFieldInfoPtr_HairColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (HairColors));
      CharacterCustomizationSettings.NativeFieldInfoPtr_MaleFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (MaleFaces));
      CharacterCustomizationSettings.NativeFieldInfoPtr_MaleHairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (MaleHairs));
      CharacterCustomizationSettings.NativeFieldInfoPtr_MaleFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (MaleFeatures));
      CharacterCustomizationSettings.NativeFieldInfoPtr_MaleAccessories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (MaleAccessories));
      CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (FemaleFaces));
      CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleHairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (FemaleHairs));
      CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (FemaleFeatures));
      CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleAccessories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (FemaleAccessories));
      CharacterCustomizationSettings.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, nameof (_Guid));
      CharacterCustomizationSettings.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, 100663855);
      CharacterCustomizationSettings.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, 100663856);
      CharacterCustomizationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSettings>.NativeClassPtr, 100663857);
    }

    public CharacterCustomizationSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ColorCollection SkintoneColors
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_SkintoneColors));
        return pointer == IntPtr.Zero ? (ColorCollection) null : new ColorCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_SkintoneColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorCollection EyeColors
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_EyeColors));
        return pointer == IntPtr.Zero ? (ColorCollection) null : new ColorCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_EyeColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorCollection HairColors
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_HairColors));
        return pointer == IntPtr.Zero ? (ColorCollection) null : new ColorCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_HairColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection MaleFaces
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleFaces));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleFaces), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection MaleHairs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleHairs));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleHairs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection MaleFeatures
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleFeatures));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleFeatures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection MaleAccessories
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleAccessories));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_MaleAccessories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection FemaleFaces
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleFaces));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleFaces), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection FemaleHairs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleHairs));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleHairs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection FemaleFeatures
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleFeatures));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleFeatures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection FemaleAccessories
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleAccessories));
        return pointer == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr_FemaleAccessories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSettings.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
