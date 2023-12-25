// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeFields
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public class CodeFields : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Template;
    private static readonly System.IntPtr NativeFieldInfoPtr__Elements;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indent;
    private static readonly System.IntPtr NativeFieldInfoPtr_RowBreaksBetweenElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_MakeRegion;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTemplate_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Indent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeField_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeField_Type_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeField_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeField_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeField_Accessor_Type_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeField_Accessor_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeField_Accessor_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634110, XrefRangeEnd = 634118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetTemplate(string id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeFields.NativeMethodInfoPtr_GetTemplate_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634118, XrefRangeEnd = 634126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeFields(Indent indent)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeFields>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &indent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeFields.NativeMethodInfoPtr__ctor_Public_Void_Indent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634126, XrefRangeEnd = 634140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField New()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFields.NativeMethodInfoPtr_New_Public_CodeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeField) null : new CodeField(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634140, XrefRangeEnd = 634141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField New(Il2CppSystem.Type fieldType, string fieldName, string defaultValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeField) null : new CodeField(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634141, XrefRangeEnd = 634142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField New(string fieldType, string fieldName, string defaultValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFields.NativeMethodInfoPtr_New_Public_CodeField_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeField) null : new CodeField(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634142, XrefRangeEnd = 634147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField New<TFieldType>(string fieldName, string defaultValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFields.MethodInfoStoreGeneric_New_Public_CodeField_String_String_0<TFieldType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeField) null : new CodeField(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 634156, RefRangeEnd = 634158, XrefRangeStart = 634147, XrefRangeEnd = 634156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField New(
      Accessor accessor,
      Il2CppSystem.Type fieldType,
      string fieldName,
      string defaultValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &accessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Accessor_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeField) null : new CodeField(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634158, XrefRangeEnd = 634163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField New<TFieldType>(
      Accessor accessor,
      string fieldName,
      string defaultValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &accessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFields.MethodInfoStoreGeneric_New_Public_CodeField_Accessor_String_String_0<TFieldType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeField) null : new CodeField(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 634180, RefRangeEnd = 634183, XrefRangeStart = 634163, XrefRangeEnd = 634180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField New(
      Accessor accessor,
      string fieldType,
      string fieldName,
      string defaultValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &accessor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Accessor_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeField) null : new CodeField(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634183, XrefRangeEnd = 634223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeFields.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeFields()
    {
      Il2CppClassPointerStore<CodeFields>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeFields));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeFields>.NativeClassPtr);
      CodeFields.NativeFieldInfoPtr_Template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, nameof (Template));
      CodeFields.NativeFieldInfoPtr__Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, nameof (_Elements));
      CodeFields.NativeFieldInfoPtr_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, nameof (Indent));
      CodeFields.NativeFieldInfoPtr_RowBreaksBetweenElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, nameof (RowBreaksBetweenElements));
      CodeFields.NativeFieldInfoPtr_MakeRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, nameof (MakeRegion));
      CodeFields.NativeMethodInfoPtr_GetTemplate_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663372);
      CodeFields.NativeMethodInfoPtr__ctor_Public_Void_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663373);
      CodeFields.NativeMethodInfoPtr_New_Public_CodeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663374);
      CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663375);
      CodeFields.NativeMethodInfoPtr_New_Public_CodeField_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663376);
      CodeFields.NativeMethodInfoPtr_New_Public_CodeField_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663377);
      CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Accessor_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663378);
      CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Accessor_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663379);
      CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Accessor_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663380);
      CodeFields.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFields>.NativeClassPtr, 100663381);
    }

    public CodeFields(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string Template
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeFields.NativeFieldInfoPtr_Template, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeFields.NativeFieldInfoPtr_Template, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<CodeField> _Elements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr__Elements));
        return pointer == System.IntPtr.Zero ? (List<CodeField>) null : new List<CodeField>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr__Elements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Indent Indent
    {
      get
      {
        return *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr_Indent));
      }
      [param: In] set
      {
        *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr_Indent)) = value;
      }
    }

    public unsafe int RowBreaksBetweenElements
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr_RowBreaksBetweenElements));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr_RowBreaksBetweenElements)) = value;
      }
    }

    public unsafe bool MakeRegion
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr_MakeRegion));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFields.NativeFieldInfoPtr_MakeRegion)) = value;
      }
    }

    private sealed class MethodInfoStoreGeneric_New_Public_CodeField_String_String_0<TFieldType>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CodeFields.NativeMethodInfoPtr_New_Public_CodeField_String_String_0, Il2CppClassPointerStore<CodeFields>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldType>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_New_Public_CodeField_Accessor_String_String_0<TFieldType>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CodeFields.NativeMethodInfoPtr_New_Public_CodeField_Accessor_String_String_0, Il2CppClassPointerStore<CodeFields>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFieldType>.NativeClassPtr))
      }))));
    }
  }
}
