// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.WindowsBindings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.Platform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace Epic.OnlineServices
{
  public static class WindowsBindings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_EOS_Platform_Create_Internal_Static_IntPtr_byref_WindowsOptionsInternal_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 936419, RefRangeEnd = 936420, XrefRangeStart = 936417, XrefRangeEnd = 936419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr EOS_Platform_Create(ref WindowsOptionsInternal options)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsBindings.NativeMethodInfoPtr_EOS_Platform_Create_Internal_Static_IntPtr_byref_WindowsOptionsInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WindowsBindings()
    {
      Il2CppClassPointerStore<WindowsBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (WindowsBindings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsBindings>.NativeClassPtr);
      WindowsBindings.NativeMethodInfoPtr_EOS_Platform_Create_Internal_Static_IntPtr_byref_WindowsOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsBindings>.NativeClassPtr, 100664874);
    }

    public WindowsBindings(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
