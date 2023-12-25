// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeTemplateList
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public class CodeTemplateList : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderTemplate;
    private static readonly System.IntPtr NativeFieldInfoPtr_FooterTemplate;
    private static readonly System.IntPtr NativeFieldInfoPtr__Elements;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indent;
    private static readonly System.IntPtr NativeFieldInfoPtr_RowBreaksBetweenElements;
    private static readonly System.IntPtr NativeFieldInfoPtr_RowBreaksAfterFinalElement;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalFullContents_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalInnerContents_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalFullContents_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalFullContents_Private_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalInnerContents_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalInnerContents_Private_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Indent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_CodeTemplate_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_CodeTemplate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Static_CodeTemplateList_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    public unsafe string OriginalFullContents
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr_get_OriginalFullContents_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr_set_OriginalFullContents_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string OriginalInnerContents
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr_get_OriginalInnerContents_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr_set_OriginalInnerContents_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635221, XrefRangeEnd = 635231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplateList(string fullTemplate, string innerTemplate, Indent indent)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fullTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(innerTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &indent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr__ctor_Public_Void_String_String_Indent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635231, XrefRangeEnd = 635235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate New(CodeTemplateData templateData = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr_New_Public_CodeTemplate_CodeTemplateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635235, XrefRangeEnd = 635239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(CodeTemplate template)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) template);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr_Remove_Public_Void_CodeTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635239, XrefRangeEnd = 635259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeTemplateList Find(string baseText, string templateListId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(templateListId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplateList.NativeMethodInfoPtr_Find_Public_Static_CodeTemplateList_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplateList) null : new CodeTemplateList(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635259, XrefRangeEnd = 635280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeTemplateList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeTemplateList()
    {
      Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeTemplateList));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr);
      CodeTemplateList.NativeFieldInfoPtr_HeaderTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, nameof (HeaderTemplate));
      CodeTemplateList.NativeFieldInfoPtr_FooterTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, nameof (FooterTemplate));
      CodeTemplateList.NativeFieldInfoPtr__Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, nameof (_Elements));
      CodeTemplateList.NativeFieldInfoPtr_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, nameof (Indent));
      CodeTemplateList.NativeFieldInfoPtr_RowBreaksBetweenElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, nameof (RowBreaksBetweenElements));
      CodeTemplateList.NativeFieldInfoPtr_RowBreaksAfterFinalElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, nameof (RowBreaksAfterFinalElement));
      CodeTemplateList.NativeFieldInfoPtr__OriginalFullContents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, "<OriginalFullContents>k__BackingField");
      CodeTemplateList.NativeFieldInfoPtr__OriginalInnerContents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, "<OriginalInnerContents>k__BackingField");
      CodeTemplateList.NativeMethodInfoPtr_get_OriginalFullContents_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663452);
      CodeTemplateList.NativeMethodInfoPtr_set_OriginalFullContents_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663453);
      CodeTemplateList.NativeMethodInfoPtr_get_OriginalInnerContents_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663454);
      CodeTemplateList.NativeMethodInfoPtr_set_OriginalInnerContents_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663455);
      CodeTemplateList.NativeMethodInfoPtr__ctor_Public_Void_String_String_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663456);
      CodeTemplateList.NativeMethodInfoPtr_New_Public_CodeTemplate_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663457);
      CodeTemplateList.NativeMethodInfoPtr_Remove_Public_Void_CodeTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663458);
      CodeTemplateList.NativeMethodInfoPtr_Find_Public_Static_CodeTemplateList_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663459);
      CodeTemplateList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateList>.NativeClassPtr, 100663460);
    }

    public CodeTemplateList(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string HeaderTemplate
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeTemplateList.NativeFieldInfoPtr_HeaderTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeTemplateList.NativeFieldInfoPtr_HeaderTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string FooterTemplate
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeTemplateList.NativeFieldInfoPtr_FooterTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeTemplateList.NativeFieldInfoPtr_FooterTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<CodeTemplate> _Elements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr__Elements));
        return pointer == System.IntPtr.Zero ? (List<CodeTemplate>) null : new List<CodeTemplate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr__Elements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Indent Indent
    {
      get
      {
        return *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr_Indent));
      }
      [param: In] set
      {
        *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr_Indent)) = value;
      }
    }

    public unsafe int RowBreaksBetweenElements
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr_RowBreaksBetweenElements));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr_RowBreaksBetweenElements)) = value;
      }
    }

    public unsafe int RowBreaksAfterFinalElement
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr_RowBreaksAfterFinalElement));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr_RowBreaksAfterFinalElement)) = value;
      }
    }

    public unsafe string _OriginalFullContents_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr__OriginalFullContents_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr__OriginalFullContents_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _OriginalInnerContents_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr__OriginalInnerContents_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateList.NativeFieldInfoPtr__OriginalInnerContents_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
