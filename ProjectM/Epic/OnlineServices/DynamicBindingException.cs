// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.DynamicBindingException
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices
{
  public class DynamicBindingException : Il2CppSystem.Exception
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934495, XrefRangeEnd = 934502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DynamicBindingException(string bindingName)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(bindingName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DynamicBindingException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DynamicBindingException()
    {
      Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (DynamicBindingException));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr);
      DynamicBindingException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr, 100664237);
    }

    public DynamicBindingException(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
