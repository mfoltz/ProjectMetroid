// Decompiled with JetBrains decompiler
// Type: ProjectM.SystemInfoHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class SystemInfoHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSystemInformationString_Public_Static_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCPUScore_Private_Static_Int32_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 750482, RefRangeEnd = 750483, XrefRangeStart = 750362, XrefRangeEnd = 750482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetSystemInformationString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SystemInfoHelper.NativeMethodInfoPtr_GetSystemInformationString_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750483, XrefRangeEnd = 750486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetCPUScore()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemInfoHelper.NativeMethodInfoPtr_GetCPUScore_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SystemInfoHelper()
    {
      Il2CppClassPointerStore<SystemInfoHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SystemInfoHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemInfoHelper>.NativeClassPtr);
      SystemInfoHelper.NativeMethodInfoPtr_GetSystemInformationString_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfoHelper>.NativeClassPtr, 100666063);
      SystemInfoHelper.NativeMethodInfoPtr_GetCPUScore_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfoHelper>.NativeClassPtr, 100666064);
    }

    public SystemInfoHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
