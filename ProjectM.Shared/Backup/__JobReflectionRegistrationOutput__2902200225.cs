// Decompiled with JetBrains decompiler
// Type: __JobReflectionRegistrationOutput__2902200225
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
public class __JobReflectionRegistrationOutput__2902200225 : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 803590, XrefRangeEnd = 804338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateJobReflectionData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__2902200225.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804338, XrefRangeEnd = 804347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EarlyInit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__2902200225.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static __JobReflectionRegistrationOutput__2902200225()
  {
    Il2CppClassPointerStore<__JobReflectionRegistrationOutput__2902200225>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (__JobReflectionRegistrationOutput__2902200225));
    __JobReflectionRegistrationOutput__2902200225.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__2902200225>.NativeClassPtr, 100670891);
    __JobReflectionRegistrationOutput__2902200225.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__2902200225>.NativeClassPtr, 100670892);
  }

  public __JobReflectionRegistrationOutput__2902200225(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
