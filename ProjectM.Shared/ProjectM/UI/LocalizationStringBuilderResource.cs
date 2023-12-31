// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizationStringBuilderResource
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class LocalizationStringBuilderResource : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefType;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumFormat;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConstantValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_FieldReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_Component;
    private static readonly System.IntPtr NativeFieldInfoPtr_Modifiers;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValueFromFieldPath_Internal_Static_Object_Object_Object_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetModifiedFloat_Private_Single_Single_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetModifiedInt_Private_Int32_Int32_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetModifiedByte_Private_Byte_Byte_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794757, RefRangeEnd = 794758, XrefRangeStart = 794692, XrefRangeEnd = 794757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Object GetValueFromFieldPath(
      UnityEngine.Object sourceObject,
      UnityEngine.Object c,
      Il2CppStringArray fields)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fields);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizationStringBuilderResource.NativeMethodInfoPtr_GetValueFromFieldPath_Internal_Static_Object_Object_Object_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794769, RefRangeEnd = 794770, XrefRangeStart = 794758, XrefRangeEnd = 794769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetValue(UnityEngine.Object sourceObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LocalizationStringBuilderResource.NativeMethodInfoPtr_GetValue_Public_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794770, XrefRangeEnd = 794778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetModifiedFloat(float inValue, UnityEngine.Object sourceObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizationStringBuilderResource.NativeMethodInfoPtr_GetModifiedFloat_Private_Single_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794778, XrefRangeEnd = 794786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetModifiedInt(int inValue, UnityEngine.Object sourceObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizationStringBuilderResource.NativeMethodInfoPtr_GetModifiedInt_Private_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794786, XrefRangeEnd = 794794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe byte GetModifiedByte(byte inValue, UnityEngine.Object sourceObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizationStringBuilderResource.NativeMethodInfoPtr_GetModifiedByte_Private_Byte_Byte_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizationStringBuilderResource()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizationStringBuilderResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalizationStringBuilderResource()
    {
      Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (LocalizationStringBuilderResource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr);
      LocalizationStringBuilderResource.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (Key));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (Type));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_RefType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (RefType));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_NumFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (NumFormat));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_ConstantValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (ConstantValue));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_ObjectReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (ObjectReference));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_FieldReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (FieldReference));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_Component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (Component));
      LocalizationStringBuilderResource.NativeFieldInfoPtr_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, nameof (Modifiers));
      LocalizationStringBuilderResource.NativeMethodInfoPtr_GetValueFromFieldPath_Internal_Static_Object_Object_Object_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, 100670071);
      LocalizationStringBuilderResource.NativeMethodInfoPtr_GetValue_Public_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, 100670072);
      LocalizationStringBuilderResource.NativeMethodInfoPtr_GetModifiedFloat_Private_Single_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, 100670073);
      LocalizationStringBuilderResource.NativeMethodInfoPtr_GetModifiedInt_Private_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, 100670074);
      LocalizationStringBuilderResource.NativeMethodInfoPtr_GetModifiedByte_Private_Byte_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, 100670075);
      LocalizationStringBuilderResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationStringBuilderResource>.NativeClassPtr, 100670076);
    }

    public LocalizationStringBuilderResource(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Key
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Key)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationStringBuilderResource.ResourceType Type
    {
      get
      {
        return *(LocalizationStringBuilderResource.ResourceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(LocalizationStringBuilderResource.ResourceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe LocalizationStringBuilderResource.ReferenceType RefType
    {
      get
      {
        return *(LocalizationStringBuilderResource.ReferenceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_RefType));
      }
      [param: In] set
      {
        *(LocalizationStringBuilderResource.ReferenceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_RefType)) = value;
      }
    }

    public unsafe LocalizationStringBuilderResource.NumericFormat NumFormat
    {
      get
      {
        return *(LocalizationStringBuilderResource.NumericFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_NumFormat));
      }
      [param: In] set
      {
        *(LocalizationStringBuilderResource.NumericFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_NumFormat)) = value;
      }
    }

    public unsafe string ConstantValue
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_ConstantValue)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_ConstantValue), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GameObject ObjectReference
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_ObjectReference));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_ObjectReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string FieldReference
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_FieldReference)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_FieldReference), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe UnityEngine.Object Component
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Component));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Component), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<LocalizedStringBuilderModifier> Modifiers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Modifiers));
        return pointer == System.IntPtr.Zero ? (List<LocalizedStringBuilderModifier>) null : new List<LocalizedStringBuilderModifier>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationStringBuilderResource.NativeFieldInfoPtr_Modifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum ResourceType
    {
      FieldReference,
      Constant,
    }

    public enum ReferenceType
    {
      Self,
      External,
    }

    public enum NumericFormat
    {
      Default,
      Percent,
      Percent100,
      PercentBase100,
    }
  }
}
