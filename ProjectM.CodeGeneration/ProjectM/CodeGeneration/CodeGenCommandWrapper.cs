// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.CodeGenCommandWrapper
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
  public class CodeGenCommandWrapper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Command;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodeGenCommand_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(77)]
    [CachedScanResults(RefRangeStart = 23421, RefRangeEnd = 23498, XrefRangeStart = 23421, XrefRangeEnd = 23498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeGenCommandWrapper(CodeGenCommand command)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeGenCommandWrapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &command;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeGenCommandWrapper.NativeMethodInfoPtr__ctor_Public_Void_CodeGenCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 634615, XrefRangeEnd = 634620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CodeGenCommandWrapper.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CodeGenCommandWrapper()
    {
      Il2CppClassPointerStore<CodeGenCommandWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (CodeGenCommandWrapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeGenCommandWrapper>.NativeClassPtr);
      CodeGenCommandWrapper.NativeFieldInfoPtr_Command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeGenCommandWrapper>.NativeClassPtr, nameof (Command));
      CodeGenCommandWrapper.NativeMethodInfoPtr__ctor_Public_Void_CodeGenCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeGenCommandWrapper>.NativeClassPtr, 100663418);
      CodeGenCommandWrapper.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeGenCommandWrapper>.NativeClassPtr, 100663419);
    }

    public CodeGenCommandWrapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CodeGenCommand Command
    {
      get
      {
        return *(CodeGenCommand*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeGenCommandWrapper.NativeFieldInfoPtr_Command));
      }
      [param: In] set
      {
        *(CodeGenCommand*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeGenCommandWrapper.NativeFieldInfoPtr_Command)) = value;
      }
    }
  }
}
