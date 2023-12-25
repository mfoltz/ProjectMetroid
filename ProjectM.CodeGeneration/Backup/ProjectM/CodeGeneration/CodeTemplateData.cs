// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeTemplateData
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
  public class CodeTemplateData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TemplatedData;
    private static readonly System.IntPtr NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateBranch_Public_CodeTemplateData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635165, XrefRangeEnd = 635183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TemplateText(string templateId, string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(templateId);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeTemplateData.NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635183, XrefRangeEnd = 635213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplateData CreateBranch()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CodeTemplateData.NativeMethodInfoPtr_CreateBranch_Public_CodeTemplateData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CodeTemplateData) null : new CodeTemplateData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 635213, XrefRangeEnd = 635221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeTemplateData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeTemplateData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeTemplateData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CodeTemplateData()
    {
      Il2CppClassPointerStore<CodeTemplateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeTemplateData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeTemplateData>.NativeClassPtr);
      CodeTemplateData.NativeFieldInfoPtr_TemplatedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeTemplateData>.NativeClassPtr, nameof (TemplatedData));
      CodeTemplateData.NativeMethodInfoPtr_TemplateText_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateData>.NativeClassPtr, 100663449);
      CodeTemplateData.NativeMethodInfoPtr_CreateBranch_Public_CodeTemplateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateData>.NativeClassPtr, 100663450);
      CodeTemplateData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeTemplateData>.NativeClassPtr, 100663451);
    }

    public CodeTemplateData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<string, ICodePart> TemplatedData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateData.NativeFieldInfoPtr_TemplatedData));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, ICodePart>) null : new Dictionary<string, ICodePart>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeTemplateData.NativeFieldInfoPtr_TemplatedData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
