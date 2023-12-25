// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeFile
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
  public class CodeFile : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CodeTemplate;
    private static readonly System.IntPtr NativeFieldInfoPtr__TargetPath;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromTemplate_Public_Static_CodeFile_String_CodeTemplateSource_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromTemplateFile_Public_Static_CodeFile_String_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromTemplateText_Public_Static_CodeFile_String_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromCodeFile_Public_Static_CodeFile_String_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_CodeTemplate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateSegment_Public_CodeSegment_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateBlock_Public_CodeBlock_String_String_BlockType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Detect_Public_CodeDetect_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Inject_Public_CodeInject_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InjectUsings_Public_CodeUsings_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Fields_Public_CodeFields_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateList_Public_CodeTemplateList_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634223, XrefRangeEnd = 634230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeFile FromTemplate(
      string targetPath,
      CodeTemplateSource sourceTemplate,
      string subTemplateId = null,
      CodeTemplateData templateData = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subTemplateId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_FromTemplate_Public_Static_CodeFile_String_CodeTemplateSource_String_CodeTemplateData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeFile) null : new CodeFile(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634230, XrefRangeEnd = 634237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeFile FromTemplateFile(
      string targetPath,
      string templatePath,
      CodeTemplateData templateData = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(templatePath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_FromTemplateFile_Public_Static_CodeFile_String_String_CodeTemplateData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeFile) null : new CodeFile(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634237, XrefRangeEnd = 634244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeFile FromTemplateText(
      string targetPath,
      string templateText,
      CodeTemplateData templateData = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(templateText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_FromTemplateText_Public_Static_CodeFile_String_String_CodeTemplateData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeFile) null : new CodeFile(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634244, XrefRangeEnd = 634251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeFile FromCodeFile(string targetPath, CodeTemplateData templateData = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_FromCodeFile_Public_Static_CodeFile_String_CodeTemplateData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeFile) null : new CodeFile(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 166542, RefRangeEnd = 166544, XrefRangeStart = 166542, XrefRangeEnd = 166544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeFile(string targetPath, CodeTemplate codeTemplate)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeFile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) codeTemplate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr__ctor_Private_Void_String_CodeTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634251, XrefRangeEnd = 634252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Save()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 165722, RefRangeEnd = 165723, XrefRangeStart = 165722, XrefRangeEnd = 165723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeFile.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634252, XrefRangeEnd = 634268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeSegment TemplateSegment(string templateName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templateName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_TemplateSegment_Public_CodeSegment_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeSegment) null : new CodeSegment(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634268, XrefRangeEnd = 634284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_TemplateBlock_Public_CodeBlock_String_String_BlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeBlock) null : new CodeBlock(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634284, XrefRangeEnd = 634286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeDetect Detect(string id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_Detect_Public_CodeDetect_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeDetect) null : new CodeDetect(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634286, XrefRangeEnd = 634296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeInject Inject(string id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_Inject_Public_CodeInject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeInject) null : new CodeInject(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634296, XrefRangeEnd = 634308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeUsings InjectUsings(string baseUsingsId = "Usings", string additionalUsingsId = "AdditionalUsings")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseUsingsId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(additionalUsingsId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_InjectUsings_Public_CodeUsings_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeUsings) null : new CodeUsings(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634308, XrefRangeEnd = 634336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeFields Fields(string id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_Fields_Public_CodeFields_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeFields) null : new CodeFields(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634336, XrefRangeEnd = 634338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplateList TemplateList(string subTemplateId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(subTemplateId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_TemplateList_Public_CodeTemplateList_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplateList) null : new CodeTemplateList(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634338, XrefRangeEnd = 634356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TemplateText(string templateName, string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templateName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeFile.NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CodeFile()
    {
      Il2CppClassPointerStore<CodeFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeFile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeFile>.NativeClassPtr);
      CodeFile.NativeFieldInfoPtr__CodeTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, nameof (_CodeTemplate));
      CodeFile.NativeFieldInfoPtr__TargetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, nameof (_TargetPath));
      CodeFile.NativeMethodInfoPtr_FromTemplate_Public_Static_CodeFile_String_CodeTemplateSource_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663383);
      CodeFile.NativeMethodInfoPtr_FromTemplateFile_Public_Static_CodeFile_String_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663384);
      CodeFile.NativeMethodInfoPtr_FromTemplateText_Public_Static_CodeFile_String_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663385);
      CodeFile.NativeMethodInfoPtr_FromCodeFile_Public_Static_CodeFile_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663386);
      CodeFile.NativeMethodInfoPtr__ctor_Private_Void_String_CodeTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663387);
      CodeFile.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663388);
      CodeFile.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663389);
      CodeFile.NativeMethodInfoPtr_TemplateSegment_Public_CodeSegment_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663390);
      CodeFile.NativeMethodInfoPtr_TemplateBlock_Public_CodeBlock_String_String_BlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663391);
      CodeFile.NativeMethodInfoPtr_Detect_Public_CodeDetect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663392);
      CodeFile.NativeMethodInfoPtr_Inject_Public_CodeInject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663393);
      CodeFile.NativeMethodInfoPtr_InjectUsings_Public_CodeUsings_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663394);
      CodeFile.NativeMethodInfoPtr_Fields_Public_CodeFields_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663395);
      CodeFile.NativeMethodInfoPtr_TemplateList_Public_CodeTemplateList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663396);
      CodeFile.NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeFile>.NativeClassPtr, 100663397);
    }

    public CodeFile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CodeTemplate _CodeTemplate
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFile.NativeFieldInfoPtr__CodeTemplate));
        return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeFile.NativeFieldInfoPtr__CodeTemplate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _TargetPath
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeFile.NativeFieldInfoPtr__TargetPath)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeFile.NativeFieldInfoPtr__TargetPath), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
