// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AllocationException
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices
{
  public class AllocationException : Il2CppSystem.Exception
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 934466, RefRangeEnd = 934469, XrefRangeStart = 934462, XrefRangeEnd = 934466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AllocationException(string message)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocationException>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(message);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AllocationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AllocationException()
    {
      Il2CppClassPointerStore<AllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (AllocationException));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocationException>.NativeClassPtr);
      AllocationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocationException>.NativeClassPtr, 100664233);
    }

    public AllocationException(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
