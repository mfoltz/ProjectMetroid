// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ExternalAllocationException
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices
{
  public class ExternalAllocationException : AllocationException
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934469, XrefRangeEnd = 934476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ExternalAllocationException(System.IntPtr address, Il2CppSystem.Type type)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &address;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ExternalAllocationException()
    {
      Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (ExternalAllocationException));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr);
      ExternalAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr, 100664234);
    }

    public ExternalAllocationException(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
