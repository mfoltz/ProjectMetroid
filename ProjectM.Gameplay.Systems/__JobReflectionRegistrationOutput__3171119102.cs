// Decompiled with JetBrains decompiler
// Type: __JobReflectionRegistrationOutput__3171119102
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
public class __JobReflectionRegistrationOutput__3171119102 : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1469223, XrefRangeEnd = 1473547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateJobReflectionData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__3171119102.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1473547, XrefRangeEnd = 1473558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EarlyInit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__3171119102.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static __JobReflectionRegistrationOutput__3171119102()
  {
    Il2CppClassPointerStore<__JobReflectionRegistrationOutput__3171119102>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "", nameof (__JobReflectionRegistrationOutput__3171119102));
    __JobReflectionRegistrationOutput__3171119102.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__3171119102>.NativeClassPtr, 100674507);
    __JobReflectionRegistrationOutput__3171119102.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__3171119102>.NativeClassPtr, 100674508);
  }

  public __JobReflectionRegistrationOutput__3171119102(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
