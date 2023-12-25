// Decompiled with JetBrains decompiler
// Type: __JobReflectionRegistrationOutput__1370248550
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
public class __JobReflectionRegistrationOutput__1370248550 : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347195, XrefRangeEnd = 1347921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateJobReflectionData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1370248550.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347921, XrefRangeEnd = 1347928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EarlyInit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1370248550.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static __JobReflectionRegistrationOutput__1370248550()
  {
    Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1370248550>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "", nameof (__JobReflectionRegistrationOutput__1370248550));
    __JobReflectionRegistrationOutput__1370248550.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1370248550>.NativeClassPtr, 100665697);
    __JobReflectionRegistrationOutput__1370248550.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1370248550>.NativeClassPtr, 100665698);
  }

  public __JobReflectionRegistrationOutput__1370248550(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
