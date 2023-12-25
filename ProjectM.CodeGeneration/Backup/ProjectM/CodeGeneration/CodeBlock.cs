// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeBlock
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
  public class CodeBlock : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indent;
    private static readonly System.IntPtr NativeFieldInfoPtr_Body;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Indent_String_BlockType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubBlock_Public_CodeBlock_String_BlockType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubSegment_Public_CodeSegment_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_CodeTemplateData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Text_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewLine_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewLineIfNotEmpty_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Row_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 633921, RefRangeEnd = 633925, XrefRangeStart = 633911, XrefRangeEnd = 633921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeBlock(Indent indent, string header, BlockType blockType)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &indent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(header);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blockType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr__ctor_Public_Void_Indent_String_BlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633925, XrefRangeEnd = 633938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeBlock SubBlock(string header, BlockType blockType = BlockType.Default)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(header);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &blockType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_SubBlock_Public_CodeBlock_String_BlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeBlock) null : new CodeBlock(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633938, XrefRangeEnd = 633940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeSegment SubSegment(bool newLine = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newLine;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_SubSegment_Public_CodeSegment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeSegment) null : new CodeSegment(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633940, XrefRangeEnd = 633953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate SubTemplate(
      CodeTemplateSource sourceTemplate,
      CodeTemplateData templateData = null,
      bool newLine = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newLine;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_CodeTemplateData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633953, XrefRangeEnd = 633966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate SubTemplate(
      CodeTemplateSource sourceTemplate,
      string subTemplateId,
      CodeTemplateData templateData = null,
      bool newLine = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subTemplateId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newLine;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633966, XrefRangeEnd = 633979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Text(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_Text_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633979, XrefRangeEnd = 633987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NewLine()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_NewLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633987, XrefRangeEnd = 633995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NewLineIfNotEmpty()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_NewLineIfNotEmpty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 633997, RefRangeEnd = 634000, XrefRangeStart = 633995, XrefRangeEnd = 633997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Row(string row)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(row);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_Row_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634000, XrefRangeEnd = 634004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeBlock.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634004, XrefRangeEnd = 634035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeBlock()
    {
      Il2CppClassPointerStore<CodeBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeBlock));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr);
      CodeBlock.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, nameof (Header));
      CodeBlock.NativeFieldInfoPtr_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, nameof (Indent));
      CodeBlock.NativeFieldInfoPtr_Body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, nameof (Body));
      CodeBlock.NativeFieldInfoPtr_BlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, nameof (BlockType));
      CodeBlock.NativeMethodInfoPtr__ctor_Public_Void_Indent_String_BlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663353);
      CodeBlock.NativeMethodInfoPtr_SubBlock_Public_CodeBlock_String_BlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663354);
      CodeBlock.NativeMethodInfoPtr_SubSegment_Public_CodeSegment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663355);
      CodeBlock.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_CodeTemplateData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663356);
      CodeBlock.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663357);
      CodeBlock.NativeMethodInfoPtr_Text_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663358);
      CodeBlock.NativeMethodInfoPtr_NewLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663359);
      CodeBlock.NativeMethodInfoPtr_NewLineIfNotEmpty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663360);
      CodeBlock.NativeMethodInfoPtr_Row_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663361);
      CodeBlock.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663362);
      CodeBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeBlock>.NativeClassPtr, 100663363);
    }

    public CodeBlock(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Header
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_Header)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_Header), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Indent Indent
    {
      get
      {
        return *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_Indent));
      }
      [param: In] set
      {
        *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_Indent)) = value;
      }
    }

    public unsafe CodeSegment Body
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_Body));
        return pointer == System.IntPtr.Zero ? (CodeSegment) null : new CodeSegment(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_Body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlockType BlockType
    {
      get
      {
        return *(BlockType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_BlockType));
      }
      [param: In] set
      {
        *(BlockType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeBlock.NativeFieldInfoPtr_BlockType)) = value;
      }
    }
  }
}
