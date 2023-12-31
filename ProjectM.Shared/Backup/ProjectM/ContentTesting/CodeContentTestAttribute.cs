// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.CodeContentTestAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.ContentTesting
{
  public class CodeContentTestAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TestName;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHeavyTest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CodeContentTestAttribute(string testName)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeContentTestAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(testName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CodeContentTestAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CodeContentTestAttribute()
    {
      Il2CppClassPointerStore<CodeContentTestAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (CodeContentTestAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeContentTestAttribute>.NativeClassPtr);
      CodeContentTestAttribute.NativeFieldInfoPtr_TestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeContentTestAttribute>.NativeClassPtr, nameof (TestName));
      CodeContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodeContentTestAttribute>.NativeClassPtr, nameof (IsHeavyTest));
      CodeContentTestAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeContentTestAttribute>.NativeClassPtr, 100667680);
    }

    public CodeContentTestAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string TestName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeContentTestAttribute.NativeFieldInfoPtr_TestName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CodeContentTestAttribute.NativeFieldInfoPtr_TestName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool IsHeavyTest
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CodeContentTestAttribute.NativeFieldInfoPtr_IsHeavyTest)) = value;
      }
    }
  }
}
