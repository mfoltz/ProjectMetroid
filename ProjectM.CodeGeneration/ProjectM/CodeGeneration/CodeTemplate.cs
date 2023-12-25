// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeTemplate
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public class CodeTemplate : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__BaseText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indent;
    private static readonly System.IntPtr NativeFieldInfoPtr__TemplateParts;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromFile_Public_Static_CodeTemplate_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromText_Public_Static_CodeTemplate_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Indent_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateSegment_Public_CodeSegment_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateBlock_Public_CodeBlock_String_String_BlockType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Detect_Public_CodeDetect_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Inject_Public_CodeInject_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InjectUsings_Public_CodeUsings_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Fields_Public_CodeFields_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateList_Public_CodeTemplateList_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNewLineBefore_Private_Static_String_String_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 634892, RefRangeEnd = 634894, XrefRangeStart = 634882, XrefRangeEnd = 634892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeTemplate FromFile(string templatePath, CodeTemplateData templateData = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templatePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_FromFile_Public_Static_CodeTemplate_String_CodeTemplateData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 634902, RefRangeEnd = 634909, XrefRangeStart = 634894, XrefRangeEnd = 634902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeTemplate FromText(string baseText, CodeTemplateData templateData = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_FromText_Public_Static_CodeTemplate_String_CodeTemplateData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 634937, RefRangeEnd = 634939, XrefRangeStart = 634909, XrefRangeEnd = 634937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate(string baseText, Indent indent, CodeTemplateData templateData)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &indent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr__ctor_Private_Void_String_Indent_CodeTemplateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634939, XrefRangeEnd = 634955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeSegment TemplateSegment(string templateName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templateName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_TemplateSegment_Public_CodeSegment_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeSegment) null : new CodeSegment(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634955, XrefRangeEnd = 634971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeBlock TemplateBlock(
      string templateName,
      string blockHeader,
      BlockType blockType = BlockType.Default)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templateName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(blockHeader);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blockType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_TemplateBlock_Public_CodeBlock_String_String_BlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeBlock) null : new CodeBlock(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 634990, RefRangeEnd = 634993, XrefRangeStart = 634971, XrefRangeEnd = 634990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeDetect Detect(string id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_Detect_Public_CodeDetect_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeDetect) null : new CodeDetect(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634993, XrefRangeEnd = 635003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeInject Inject(string id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_Inject_Public_CodeInject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeInject) null : new CodeInject(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635003, XrefRangeEnd = 635015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeUsings InjectUsings(string baseUsingsId = "Usings", string additionalUsingsId = "AdditionalUsings")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseUsingsId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(additionalUsingsId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_InjectUsings_Public_CodeUsings_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeUsings) null : new CodeUsings(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635015, XrefRangeEnd = 635043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeFields Fields(string id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_Fields_Public_CodeFields_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeFields) null : new CodeFields(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 635070, RefRangeEnd = 635071, XrefRangeStart = 635043, XrefRangeEnd = 635070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplateList TemplateList(string subTemplateId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(subTemplateId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_TemplateList_Public_CodeTemplateList_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplateList) null : new CodeTemplateList(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635071, XrefRangeEnd = 635080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate SubTemplate(
      CodeTemplateSource sourceTemplate,
      string replaceId,
      CodeTemplateData templateData = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(replaceId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635080, XrefRangeEnd = 635089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate SubTemplate(
      CodeTemplateSource sourceTemplate,
      string replaceId,
      string subTemplateId,
      CodeTemplateData templateData = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(replaceId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subTemplateId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_String_CodeTemplateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635089, XrefRangeEnd = 635107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TemplateText(string templateName, string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templateName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635107, XrefRangeEnd = 635157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeTemplate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 635164, RefRangeEnd = 635165, XrefRangeStart = 635157, XrefRangeEnd = 635164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string RemoveNewLineBefore(string fullCode, int currentIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fullCode);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentIndex;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.NativeMethodInfoPtr_RemoveNewLineBefore_Private_Static_String_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeTemplate()
    {
      Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr);
      CodeTemplate.NativeFieldInfoPtr__BaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, nameof (_BaseText));
      CodeTemplate.NativeFieldInfoPtr_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, nameof (Indent));
      CodeTemplate.NativeFieldInfoPtr__TemplateParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, nameof (_TemplateParts));
      CodeTemplate.NativeMethodInfoPtr_FromFile_Public_Static_CodeTemplate_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663431);
      CodeTemplate.NativeMethodInfoPtr_FromText_Public_Static_CodeTemplate_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663432);
      CodeTemplate.NativeMethodInfoPtr__ctor_Private_Void_String_Indent_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663433);
      CodeTemplate.NativeMethodInfoPtr_TemplateSegment_Public_CodeSegment_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663434);
      CodeTemplate.NativeMethodInfoPtr_TemplateBlock_Public_CodeBlock_String_String_BlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663435);
      CodeTemplate.NativeMethodInfoPtr_Detect_Public_CodeDetect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663436);
      CodeTemplate.NativeMethodInfoPtr_Inject_Public_CodeInject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663437);
      CodeTemplate.NativeMethodInfoPtr_InjectUsings_Public_CodeUsings_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663438);
      CodeTemplate.NativeMethodInfoPtr_Fields_Public_CodeFields_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663439);
      CodeTemplate.NativeMethodInfoPtr_TemplateList_Public_CodeTemplateList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663440);
      CodeTemplate.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663441);
      CodeTemplate.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663442);
      CodeTemplate.NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663443);
      CodeTemplate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663444);
      CodeTemplate.NativeMethodInfoPtr_RemoveNewLineBefore_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, 100663445);
    }

    public CodeTemplate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _BaseText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplate.NativeFieldInfoPtr__BaseText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplate.NativeFieldInfoPtr__BaseText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Indent Indent
    {
      get
      {
        return *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplate.NativeFieldInfoPtr_Indent));
      }
      [param: In] set
      {
        *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplate.NativeFieldInfoPtr_Indent)) = value;
      }
    }

    public unsafe Dictionary<string, ICodePart> _TemplateParts
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplate.NativeFieldInfoPtr__TemplateParts));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, ICodePart>) null : new Dictionary<string, ICodePart>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplate.NativeFieldInfoPtr__TemplateParts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.CodeGeneration.CodeTemplate/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ToString_b__16_0_Internal_Int32_KeyValuePair_2_String_ICodePart_KeyValuePair_2_String_ICodePart_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeTemplate.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CodeTemplate.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634873, XrefRangeEnd = 634882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _ToString_b__16_0(
        KeyValuePair<string, ICodePart> a,
        KeyValuePair<string, ICodePart> b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplate.__c.NativeMethodInfoPtr__ToString_b__16_0_Internal_Int32_KeyValuePair_2_String_ICodePart_KeyValuePair_2_String_ICodePart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<CodeTemplate.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CodeTemplate>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeTemplate.__c>.NativeClassPtr);
        CodeTemplate.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplate.__c>.NativeClassPtr, "<>9");
        CodeTemplate.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplate.__c>.NativeClassPtr, "<>9__16_0");
        CodeTemplate.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate.__c>.NativeClassPtr, 100663447);
        CodeTemplate.__c.NativeMethodInfoPtr__ToString_b__16_0_Internal_Int32_KeyValuePair_2_String_ICodePart_KeyValuePair_2_String_ICodePart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplate.__c>.NativeClassPtr, 100663448);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe CodeTemplate.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CodeTemplate.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (CodeTemplate.__c) null : new CodeTemplate.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CodeTemplate.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<KeyValuePair<string, ICodePart>> __9__16_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CodeTemplate.__c.NativeFieldInfoPtr___9__16_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<KeyValuePair<string, ICodePart>>) null : new Il2CppSystem.Comparison<KeyValuePair<string, ICodePart>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CodeTemplate.__c.NativeFieldInfoPtr___9__16_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
