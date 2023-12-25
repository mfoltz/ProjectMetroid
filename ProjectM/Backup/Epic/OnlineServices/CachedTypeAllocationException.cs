// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CachedTypeAllocationException
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices
{
  public class CachedTypeAllocationException : AllocationException
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_Type_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934476, XrefRangeEnd = 934483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CachedTypeAllocationException(System.IntPtr address, Il2CppSystem.Type foundType, Il2CppSystem.Type expectedType)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &address;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) foundType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) expectedType);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CachedTypeAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CachedTypeAllocationException()
    {
      Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (CachedTypeAllocationException));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr);
      CachedTypeAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr, 100664235);
    }

    public CachedTypeAllocationException(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
