// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CachedArrayAllocationException
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Epic.OnlineServices
{
  public class CachedArrayAllocationException : AllocationException
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934483, XrefRangeEnd = 934495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CachedArrayAllocationException(
      IntPtr address,
      int foundLength,
      int expectedLength)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &address;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &foundLength;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &expectedLength;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CachedArrayAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CachedArrayAllocationException()
    {
      Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (CachedArrayAllocationException));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr);
      CachedArrayAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr, 100664236);
    }

    public CachedArrayAllocationException(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
