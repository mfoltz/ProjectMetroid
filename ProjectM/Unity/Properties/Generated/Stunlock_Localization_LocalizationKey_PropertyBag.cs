// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.Stunlock_Localization_LocalizationKey_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using Stunlock.Localization;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class Stunlock_Localization_LocalizationKey_PropertyBag : 
    ContainerPropertyBag<LocalizationKey>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1169894, RefRangeEnd = 1169895, XrefRangeStart = 1169881, XrefRangeEnd = 1169894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Stunlock_Localization_LocalizationKey_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Stunlock_Localization_LocalizationKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Stunlock_Localization_LocalizationKey_PropertyBag()
    {
      Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (Stunlock_Localization_LocalizationKey_PropertyBag));
      Stunlock_Localization_LocalizationKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag>.NativeClassPtr, 100692821);
    }

    public Stunlock_Localization_LocalizationKey_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Key_Property : Property<LocalizationKey, AssetGuid>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_LocalizationKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizationKey_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169875, XrefRangeEnd = 1169877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1169880, RefRangeEnd = 1169881, XrefRangeStart = 1169877, XrefRangeEnd = 1169880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Key_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AssetGuid GetValue(ref LocalizationKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_LocalizationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref LocalizationKey container, AssetGuid value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizationKey_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Key_Property()
      {
        Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag>.NativeClassPtr, nameof (Key_Property));
        Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property>.NativeClassPtr, 100692822);
        Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property>.NativeClassPtr, 100692823);
        Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property>.NativeClassPtr, 100692824);
        Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property>.NativeClassPtr, 100692825);
        Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_LocalizationKey_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stunlock_Localization_LocalizationKey_PropertyBag.Key_Property>.NativeClassPtr, 100692826);
      }

      public Key_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
