// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeSegment
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
  public class CodeSegment : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Indent;
    private static readonly System.IntPtr NativeFieldInfoPtr__Rows;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Indent_0;
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

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 634628, RefRangeEnd = 634635, XrefRangeStart = 634620, XrefRangeEnd = 634628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeSegment(Indent indent)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &indent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr__ctor_Public_Void_Indent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 634648, RefRangeEnd = 634651, XrefRangeStart = 634635, XrefRangeEnd = 634648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeBlock SubBlock(string header, BlockType blockType = BlockType.Default)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(header);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &blockType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_SubBlock_Public_CodeBlock_String_BlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeBlock) null : new CodeBlock(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 634664, RefRangeEnd = 634665, XrefRangeStart = 634651, XrefRangeEnd = 634664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeSegment SubSegment(bool newLine = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newLine;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_SubSegment_Public_CodeSegment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeSegment) null : new CodeSegment(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634665, XrefRangeEnd = 634678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_CodeTemplateData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634678, XrefRangeEnd = 634691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634691, XrefRangeEnd = 634704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Text(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_Text_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 634712, RefRangeEnd = 634714, XrefRangeStart = 634704, XrefRangeEnd = 634712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NewLine()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_NewLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634714, XrefRangeEnd = 634722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NewLineIfNotEmpty()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_NewLineIfNotEmpty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(122)]
    [CachedScanResults(RefRangeStart = 634737, RefRangeEnd = 634859, XrefRangeStart = 634722, XrefRangeEnd = 634737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Row(string row)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(row);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_Row_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634859, XrefRangeEnd = 634863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeSegment.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634863, XrefRangeEnd = 634873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeSegment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeSegment()
    {
      Il2CppClassPointerStore<CodeSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeSegment));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr);
      CodeSegment.NativeFieldInfoPtr_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, nameof (Indent));
      CodeSegment.NativeFieldInfoPtr__Rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, nameof (_Rows));
      CodeSegment.NativeMethodInfoPtr__ctor_Public_Void_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663420);
      CodeSegment.NativeMethodInfoPtr_SubBlock_Public_CodeBlock_String_BlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663421);
      CodeSegment.NativeMethodInfoPtr_SubSegment_Public_CodeSegment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663422);
      CodeSegment.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_CodeTemplateData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663423);
      CodeSegment.NativeMethodInfoPtr_SubTemplate_Public_CodeTemplate_CodeTemplateSource_String_CodeTemplateData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663424);
      CodeSegment.NativeMethodInfoPtr_Text_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663425);
      CodeSegment.NativeMethodInfoPtr_NewLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663426);
      CodeSegment.NativeMethodInfoPtr_NewLineIfNotEmpty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663427);
      CodeSegment.NativeMethodInfoPtr_Row_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663428);
      CodeSegment.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663429);
      CodeSegment.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeSegment>.NativeClassPtr, 100663430);
    }

    public CodeSegment(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Indent Indent
    {
      get
      {
        return *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeSegment.NativeFieldInfoPtr_Indent));
      }
      [param: In] set
      {
        *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeSegment.NativeFieldInfoPtr_Indent)) = value;
      }
    }

    public unsafe List<ICodePart> _Rows
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeSegment.NativeFieldInfoPtr__Rows));
        return pointer == System.IntPtr.Zero ? (List<ICodePart>) null : new List<ICodePart>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeSegment.NativeFieldInfoPtr__Rows), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
