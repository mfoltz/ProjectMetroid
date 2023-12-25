// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeText
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
  public class CodeText : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indent;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Indent_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634608, XrefRangeEnd = 634610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeText(Indent indent, string text)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeText>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &indent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeText.NativeMethodInfoPtr__ctor_Public_Void_Indent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634610, XrefRangeEnd = 634615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeText.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeText()
    {
      Il2CppClassPointerStore<CodeText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeText));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeText>.NativeClassPtr);
      CodeText.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeText>.NativeClassPtr, nameof (Text));
      CodeText.NativeFieldInfoPtr_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeText>.NativeClassPtr, nameof (Indent));
      CodeText.NativeMethodInfoPtr__ctor_Public_Void_Indent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeText>.NativeClassPtr, 100663416);
      CodeText.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeText>.NativeClassPtr, 100663417);
    }

    public CodeText(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeText.NativeFieldInfoPtr_Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeText.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Indent Indent
    {
      get
      {
        return *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeText.NativeFieldInfoPtr_Indent));
      }
      [param: In] set
      {
        *(Indent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeText.NativeFieldInfoPtr_Indent)) = value;
      }
    }
  }
}
