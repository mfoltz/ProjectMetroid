// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeDetect
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public class CodeDetect : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderTemplate;
    private static readonly System.IntPtr NativeFieldInfoPtr_FooterTemplate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Contents;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndentedContents;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullContents;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indent;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Indent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Static_CodeDetect_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634548, XrefRangeEnd = 634553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeDetect(
      string id,
      string currentContents,
      string indentedContents,
      string currentFullContents,
      Indent indent)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(currentContents);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(indentedContents);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(currentFullContents);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &indent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeDetect.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Indent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634553, XrefRangeEnd = 634568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeDetect Find(string baseText, string id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeDetect.NativeMethodInfoPtr_Find_Public_Static_CodeDetect_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeDetect) null : new CodeDetect(pointer);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeDetect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeDetect()
    {
      Il2CppClassPointerStore<CodeDetect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeDetect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr);
      CodeDetect.NativeFieldInfoPtr_HeaderTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, nameof (HeaderTemplate));
      CodeDetect.NativeFieldInfoPtr_FooterTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, nameof (FooterTemplate));
      CodeDetect.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, nameof (ID));
      CodeDetect.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, nameof (Contents));
      CodeDetect.NativeFieldInfoPtr_IndentedContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, nameof (IndentedContents));
      CodeDetect.NativeFieldInfoPtr_FullContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, nameof (FullContents));
      CodeDetect.NativeFieldInfoPtr_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, nameof (Indent));
      CodeDetect.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, 100663408);
      CodeDetect.NativeMethodInfoPtr_Find_Public_Static_CodeDetect_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, 100663409);
      CodeDetect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeDetect>.NativeClassPtr, 100663410);
    }

    public CodeDetect(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string HeaderTemplate
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeDetect.NativeFieldInfoPtr_HeaderTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeDetect.NativeFieldInfoPtr_HeaderTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string FooterTemplate
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeDetect.NativeFieldInfoPtr_FooterTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeDetect.NativeFieldInfoPtr_FooterTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ID
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_ID)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Contents
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_Contents)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_Contents), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string IndentedContents
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_IndentedContents)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_IndentedContents), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string FullContents
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_FullContents)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_FullContents), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Indent Indent
    {
      get
      {
        return *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_Indent));
      }
      [param: In] set
      {
        *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeDetect.NativeFieldInfoPtr_Indent)) = value;
      }
    }
  }
}
