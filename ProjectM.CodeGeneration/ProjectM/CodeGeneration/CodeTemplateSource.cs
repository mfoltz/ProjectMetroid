// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeTemplateSource
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
  public class CodeTemplateSource : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderTemplate;
    private static readonly System.IntPtr NativeFieldInfoPtr_FooterTemplate;
    private static readonly System.IntPtr NativeFieldInfoPtr__BaseText;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromFile_Public_Static_CodeTemplateSource_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromText_Public_Static_CodeTemplateSource_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindSubTemplate_Private_Static_Boolean_String_String_byref_String_byref_Indent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Instansiate_Public_CodeTemplate_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Instansiate_Public_CodeTemplate_String_CodeTemplateData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635280, XrefRangeEnd = 635287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeTemplateSource FromFile(string templatePath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templatePath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplateSource.NativeMethodInfoPtr_FromFile_Public_Static_CodeTemplateSource_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplateSource) null : new CodeTemplateSource(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635287, XrefRangeEnd = 635292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CodeTemplateSource FromText(string baseText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplateSource.NativeMethodInfoPtr_FromText_Public_Static_CodeTemplateSource_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplateSource) null : new CodeTemplateSource(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635292, XrefRangeEnd = 635301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindSubTemplate(
      string baseText,
      string subTemplateId,
      out string subTemplate,
      out Indent indent)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(subTemplateId);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref indent;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CodeTemplateSource.NativeMethodInfoPtr_TryFindSubTemplate_Private_Static_Boolean_String_String_byref_String_byref_Indent_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      subTemplate = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 39465, RefRangeEnd = 39591, XrefRangeStart = 39465, XrefRangeEnd = 39591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplateSource(string baseText)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeTemplateSource.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635301, XrefRangeEnd = 635302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate Instansiate(CodeTemplateData templateData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplateSource.NativeMethodInfoPtr_Instansiate_Public_CodeTemplate_CodeTemplateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 635321, RefRangeEnd = 635325, XrefRangeStart = 635302, XrefRangeEnd = 635321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplate Instansiate(string subTemplateId, CodeTemplateData templateData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(subTemplateId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) templateData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplateSource.NativeMethodInfoPtr_Instansiate_Public_CodeTemplate_String_CodeTemplateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplate) null : new CodeTemplate(pointer);
    }

    static CodeTemplateSource()
    {
      Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeTemplateSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr);
      CodeTemplateSource.NativeFieldInfoPtr_HeaderTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, nameof (HeaderTemplate));
      CodeTemplateSource.NativeFieldInfoPtr_FooterTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, nameof (FooterTemplate));
      CodeTemplateSource.NativeFieldInfoPtr__BaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, nameof (_BaseText));
      CodeTemplateSource.NativeMethodInfoPtr_FromFile_Public_Static_CodeTemplateSource_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, 100663462);
      CodeTemplateSource.NativeMethodInfoPtr_FromText_Public_Static_CodeTemplateSource_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, 100663463);
      CodeTemplateSource.NativeMethodInfoPtr_TryFindSubTemplate_Private_Static_Boolean_String_String_byref_String_byref_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, 100663464);
      CodeTemplateSource.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, 100663465);
      CodeTemplateSource.NativeMethodInfoPtr_Instansiate_Public_CodeTemplate_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, 100663466);
      CodeTemplateSource.NativeMethodInfoPtr_Instansiate_Public_CodeTemplate_String_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateSource>.NativeClassPtr, 100663467);
    }

    public CodeTemplateSource(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string HeaderTemplate
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeTemplateSource.NativeFieldInfoPtr_HeaderTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeTemplateSource.NativeFieldInfoPtr_HeaderTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string FooterTemplate
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeTemplateSource.NativeFieldInfoPtr_FooterTemplate, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeTemplateSource.NativeFieldInfoPtr_FooterTemplate, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _BaseText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateSource.NativeFieldInfoPtr__BaseText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateSource.NativeFieldInfoPtr__BaseText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
