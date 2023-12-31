// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedStringBuilderModifier
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class LocalizedStringBuilderModifier : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModifierType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_RefType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConstantValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_FieldReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_Component;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Single_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 794689, RefRangeEnd = 794692, XrefRangeStart = 794677, XrefRangeEnd = 794689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetValue(UnityEngine.Object sourceObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizedStringBuilderModifier.NativeMethodInfoPtr_GetValue_Public_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedStringBuilderModifier()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizedStringBuilderModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalizedStringBuilderModifier()
    {
      Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (LocalizedStringBuilderModifier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr);
      LocalizedStringBuilderModifier.NativeFieldInfoPtr_ModifierType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, nameof (ModifierType));
      LocalizedStringBuilderModifier.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, nameof (Type));
      LocalizedStringBuilderModifier.NativeFieldInfoPtr_RefType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, nameof (RefType));
      LocalizedStringBuilderModifier.NativeFieldInfoPtr_ConstantValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, nameof (ConstantValue));
      LocalizedStringBuilderModifier.NativeFieldInfoPtr_ObjectReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, nameof (ObjectReference));
      LocalizedStringBuilderModifier.NativeFieldInfoPtr_FieldReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, nameof (FieldReference));
      LocalizedStringBuilderModifier.NativeFieldInfoPtr_Component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, nameof (Component));
      LocalizedStringBuilderModifier.NativeMethodInfoPtr_GetValue_Public_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, 100670069);
      LocalizedStringBuilderModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringBuilderModifier>.NativeClassPtr, 100670070);
    }

    public LocalizedStringBuilderModifier(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedStringBuilderModifier.BuilderModifierType ModifierType
    {
      get
      {
        return *(LocalizedStringBuilderModifier.BuilderModifierType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_ModifierType));
      }
      [param: In] set
      {
        *(LocalizedStringBuilderModifier.BuilderModifierType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_ModifierType)) = value;
      }
    }

    public unsafe LocalizationStringBuilderResource.ResourceType Type
    {
      get
      {
        return *(LocalizationStringBuilderResource.ResourceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(LocalizationStringBuilderResource.ResourceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe LocalizationStringBuilderResource.ReferenceType RefType
    {
      get
      {
        return *(LocalizationStringBuilderResource.ReferenceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_RefType));
      }
      [param: In] set
      {
        *(LocalizationStringBuilderResource.ReferenceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_RefType)) = value;
      }
    }

    public unsafe float ConstantValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_ConstantValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_ConstantValue)) = value;
      }
    }

    public unsafe GameObject ObjectReference
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_ObjectReference));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_ObjectReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string FieldReference
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_FieldReference)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_FieldReference), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe UnityEngine.Object Component
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_Component));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringBuilderModifier.NativeFieldInfoPtr_Component), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum BuilderModifierType
    {
      Add,
      Multiply,
      Subtract,
      Divide,
    }
  }
}
