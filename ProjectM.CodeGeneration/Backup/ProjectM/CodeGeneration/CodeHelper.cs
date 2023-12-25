// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeHelper
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
  public static class CodeHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Endl;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEndlIfNotEmpty_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindSection_Public_Static_Boolean_String_String_String_String_byref_String_byref_String_byref_String_byref_Indent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Static_Void_byref_String_ICodePart_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToLocalVariable_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToPrimitiveValue_Public_Static_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNiceName_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNiceName_Public_Static_String_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSuffix_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSuffix_Public_Static_String_Type_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 634364, RefRangeEnd = 634366, XrefRangeStart = 634356, XrefRangeEnd = 634364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string AddEndlIfNotEmpty(string text)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_AddEndlIfNotEmpty_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 634429, RefRangeEnd = 634436, XrefRangeStart = 634366, XrefRangeEnd = 634429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindSection(
      string headerTemplate,
      string footerTemplate,
      string id,
      string originalText,
      out string contents,
      out string indentedContents,
      out string fullContents,
      out Indent indent)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(headerTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(footerTemplate);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(originalText);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      System.IntPtr zero1 = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
      System.IntPtr zero3 = System.IntPtr.Zero;
      System.IntPtr* numPtr4 = &zero3;
      *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref indent;
      System.IntPtr exc;
      System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_TryFindSection_Public_Static_Boolean_String_String_String_String_byref_String_byref_String_byref_String_byref_Indent_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      contents = IL2CPP.Il2CppStringToManaged(zero1);
      indentedContents = IL2CPP.Il2CppStringToManaged(zero2);
      fullContents = IL2CPP.Il2CppStringToManaged(zero3);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 634449, RefRangeEnd = 634451, XrefRangeStart = 634436, XrefRangeEnd = 634449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Append(ref string text, ICodePart row)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr* numPtr3 = &il2Cpp;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) row);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_Append_Public_Static_Void_byref_String_ICodePart_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      text = IL2CPP.Il2CppStringToManaged(il2Cpp);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634451, XrefRangeEnd = 634456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ToLocalVariable(string variableName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(variableName);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_ToLocalVariable_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634456, XrefRangeEnd = 634468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ToPrimitiveValue(Il2CppSystem.Object value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_ToPrimitiveValue_Public_Static_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 634503, RefRangeEnd = 634507, XrefRangeStart = 634468, XrefRangeEnd = 634503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetNiceName(string typeName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeName);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_GetNiceName_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 634512, RefRangeEnd = 634513, XrefRangeStart = 634507, XrefRangeEnd = 634512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetNiceName(Il2CppSystem.Type type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_GetNiceName_Public_Static_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634513, XrefRangeEnd = 634529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetSuffix(string typeName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeName);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_GetSuffix_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634529, XrefRangeEnd = 634548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetSuffix(Il2CppSystem.Type type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CodeHelper.NativeMethodInfoPtr_GetSuffix_Public_Static_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeHelper()
    {
      Il2CppClassPointerStore<CodeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr);
      CodeHelper.NativeFieldInfoPtr_Endl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, nameof (Endl));
      CodeHelper.NativeMethodInfoPtr_AddEndlIfNotEmpty_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663398);
      CodeHelper.NativeMethodInfoPtr_TryFindSection_Public_Static_Boolean_String_String_String_String_byref_String_byref_String_byref_String_byref_Indent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663399);
      CodeHelper.NativeMethodInfoPtr_Append_Public_Static_Void_byref_String_ICodePart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663400);
      CodeHelper.NativeMethodInfoPtr_ToLocalVariable_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663401);
      CodeHelper.NativeMethodInfoPtr_ToPrimitiveValue_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663402);
      CodeHelper.NativeMethodInfoPtr_GetNiceName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663403);
      CodeHelper.NativeMethodInfoPtr_GetNiceName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663404);
      CodeHelper.NativeMethodInfoPtr_GetSuffix_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663405);
      CodeHelper.NativeMethodInfoPtr_GetSuffix_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeHelper>.NativeClassPtr, 100663406);
    }

    public CodeHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string Endl
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(CodeHelper.NativeFieldInfoPtr_Endl, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CodeHelper.NativeFieldInfoPtr_Endl, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
