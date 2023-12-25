// Decompiled with JetBrains decompiler
// Type: __JobReflectionRegistrationOutput__1899807040
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
public class __JobReflectionRegistrationOutput__1899807040 : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164849, XrefRangeEnd = 1169272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateJobReflectionData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1899807040.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169272, XrefRangeEnd = 1169279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EarlyInit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1899807040.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static __JobReflectionRegistrationOutput__1899807040()
  {
    Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1899807040>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (__JobReflectionRegistrationOutput__1899807040));
    __JobReflectionRegistrationOutput__1899807040.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1899807040>.NativeClassPtr, 100692633);
    __JobReflectionRegistrationOutput__1899807040.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1899807040>.NativeClassPtr, 100692634);
  }

  public __JobReflectionRegistrationOutput__1899807040(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
