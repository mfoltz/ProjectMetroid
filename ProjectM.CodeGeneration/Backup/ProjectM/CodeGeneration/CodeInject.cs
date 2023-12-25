// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeInject
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public class CodeInject : CodeSegment
  {
    private static readonly IntPtr NativeFieldInfoPtr_HeaderTemplate;
    private static readonly IntPtr NativeFieldInfoPtr_FooterTemplate;
    private static readonly IntPtr NativeFieldInfoPtr_ID;
    private static readonly IntPtr NativeFieldInfoPtr_OriginalContents;
    private static readonly IntPtr NativeFieldInfoPtr_OriginalIndentedContents;
    private static readonly IntPtr NativeFieldInfoPtr_OriginalFullContents;
    private static readonly IntPtr NativeFieldInfoPtr_KeepHeaderAndFooter;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Indent_0;
    private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_CodeInject_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634568, XrefRangeEnd = 634573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeInject(
      string id,
      string currentContents,
      string indentedContents,
      string currentFullContents,
      Indent indent)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeInject>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(currentContents);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(indentedContents);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(currentFullContents);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &indent;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeInject.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Indent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 634588, RefRangeEnd = 634592, XrefRangeStart = 634573, XrefRangeEnd = 634588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeInject Find(string baseText, string id)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeInject.NativeMethodInfoPtr_Find_Public_Static_CodeInject_String_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (CodeInject) null : new CodeInject(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634592, XrefRangeEnd = 634608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeInject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeInject()
    {
      Il2CppClassPointerStore<CodeInject>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeInject));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeInject>.NativeClassPtr);
      CodeInject.NativeFieldInfoPtr_HeaderTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, nameof (HeaderTemplate));
      CodeInject.NativeFieldInfoPtr_FooterTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, nameof (FooterTemplate));
      CodeInject.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, nameof (ID));
      CodeInject.NativeFieldInfoPtr_OriginalContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, nameof (OriginalContents));
      CodeInject.NativeFieldInfoPtr_OriginalIndentedContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, nameof (OriginalIndentedContents));
      CodeInject.NativeFieldInfoPtr_OriginalFullContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, nameof (OriginalFullContents));
      CodeInject.NativeFieldInfoPtr_KeepHeaderAndFooter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, nameof (KeepHeaderAndFooter));
      CodeInject.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, 100663412);
      CodeInject.NativeMethodInfoPtr_Find_Public_Static_CodeInject_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, 100663413);
      CodeInject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeInject>.NativeClassPtr, 100663414);
    }

    public CodeInject(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string HeaderTemplate
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeInject.NativeFieldInfoPtr_HeaderTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeInject.NativeFieldInfoPtr_HeaderTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string FooterTemplate
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeInject.NativeFieldInfoPtr_FooterTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeInject.NativeFieldInfoPtr_FooterTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_ID)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OriginalContents
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_OriginalContents)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_OriginalContents), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OriginalIndentedContents
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_OriginalIndentedContents)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_OriginalIndentedContents), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OriginalFullContents
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_OriginalFullContents)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_OriginalFullContents), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool KeepHeaderAndFooter
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_KeepHeaderAndFooter));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeInject.NativeFieldInfoPtr_KeepHeaderAndFooter)) = value;
      }
    }
  }
}
