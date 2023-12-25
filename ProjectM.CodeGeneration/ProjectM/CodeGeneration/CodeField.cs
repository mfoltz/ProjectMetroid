// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeField
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
  public class CodeField : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Accessors;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttributesOnSameRow;
    private static readonly System.IntPtr NativeFieldInfoPtr__Attributes;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Type_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Type_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634035, XrefRangeEnd = 634062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeField.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634062, XrefRangeEnd = 634071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeAttribute AddAttribute([Optional] Il2CppStringArray parameters)
    {
      if (parameters == null)
        parameters = new Il2CppStringArray(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameters);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeField.MethodInfoStoreGeneric_AddAttribute_Public_CodeAttribute_Il2CppStringArray_0<M0>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeAttribute) null : new CodeAttribute(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634071, XrefRangeEnd = 634077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeAttribute AddAttribute<TAttribute>(string parameters)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameters);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeField.MethodInfoStoreGeneric_AddAttribute_Public_CodeAttribute_String_0<TAttribute>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeAttribute) null : new CodeAttribute(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634077, XrefRangeEnd = 634082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeAttribute AddAttribute(Il2CppSystem.Type attributeType, [Optional] Il2CppStringArray parameters)
    {
      if (parameters == null)
        parameters = new Il2CppStringArray(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attributeType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameters);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeAttribute) null : new CodeAttribute(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634082, XrefRangeEnd = 634084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeAttribute AddAttribute(Il2CppSystem.Type attributeType, string parameters)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attributeType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(parameters);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeAttribute) null : new CodeAttribute(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634084, XrefRangeEnd = 634088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeAttribute AddAttribute(string attributeType, [Optional] Il2CppStringArray parameters)
    {
      if (parameters == null)
        parameters = new Il2CppStringArray(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(attributeType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parameters);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeAttribute) null : new CodeAttribute(pointer);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 634097, RefRangeEnd = 634102, XrefRangeStart = 634088, XrefRangeEnd = 634097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeAttribute AddAttribute(string attributeType, string parameters)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(attributeType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(parameters);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeAttribute) null : new CodeAttribute(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634102, XrefRangeEnd = 634110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeField()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeField>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public CodeAttribute AddAttribute<TAttribute, TAttribute>(params string[] parameters)
    {
      return this.AddAttribute(new Il2CppStringArray(parameters));
    }

    public CodeAttribute AddAttribute(Il2CppSystem.Type attributeType, params string[] parameters)
    {
      return this.AddAttribute(attributeType, new Il2CppStringArray(parameters));
    }

    public CodeAttribute AddAttribute(string attributeType, params string[] parameters)
    {
      return this.AddAttribute(attributeType, new Il2CppStringArray(parameters));
    }

    static CodeField()
    {
      Il2CppClassPointerStore<CodeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeField));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeField>.NativeClassPtr);
      CodeField.NativeFieldInfoPtr_Accessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeField>.NativeClassPtr, nameof (Accessors));
      CodeField.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeField>.NativeClassPtr, nameof (Type));
      CodeField.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeField>.NativeClassPtr, nameof (Name));
      CodeField.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeField>.NativeClassPtr, nameof (DefaultValue));
      CodeField.NativeFieldInfoPtr_AttributesOnSameRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeField>.NativeClassPtr, nameof (AttributesOnSameRow));
      CodeField.NativeFieldInfoPtr__Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeField>.NativeClassPtr, nameof (_Attributes));
      CodeField.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663364);
      CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663365);
      CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663366);
      CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663367);
      CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663368);
      CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663369);
      CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663370);
      CodeField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeField>.NativeClassPtr, 100663371);
    }

    public CodeField(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Accessor Accessors
    {
      get
      {
        return *(Accessor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_Accessors));
      }
      [param: In] set
      {
        *(Accessor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_Accessors)) = value;
      }
    }

    public unsafe string Type
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_Type)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string DefaultValue
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_DefaultValue)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_DefaultValue), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool AttributesOnSameRow
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_AttributesOnSameRow));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr_AttributesOnSameRow)) = value;
      }
    }

    public unsafe List<CodeAttribute> _Attributes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr__Attributes));
        return pointer == System.IntPtr.Zero ? (List<CodeAttribute>) null : new List<CodeAttribute>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeField.NativeFieldInfoPtr__Attributes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_AddAttribute_Public_CodeAttribute_Il2CppStringArray_0<TAttribute>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_Il2CppStringArray_0, Il2CppClassPointerStore<CodeField>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAttribute>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddAttribute_Public_CodeAttribute_String_0<TAttribute>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CodeField.NativeMethodInfoPtr_AddAttribute_Public_CodeAttribute_String_0, Il2CppClassPointerStore<CodeField>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAttribute>.NativeClassPtr))
      }))));
    }
  }
}
