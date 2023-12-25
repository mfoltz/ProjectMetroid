// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.IOSBindings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.Auth;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices
{
  public static class IOSBindings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_EOS_Auth_Login_Internal_Static_Void_IntPtr_byref_IOSLoginOptionsInternal_IntPtr_OnLoginCallbackInternal_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 936362, RefRangeEnd = 936363, XrefRangeStart = 936360, XrefRangeEnd = 936362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EOS_Auth_Login(
      System.IntPtr handle,
      ref IOSLoginOptionsInternal options,
      System.IntPtr clientData,
      OnLoginCallbackInternal completionDelegate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &handle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &clientData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSBindings.NativeMethodInfoPtr_EOS_Auth_Login_Internal_Static_Void_IntPtr_byref_IOSLoginOptionsInternal_IntPtr_OnLoginCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IOSBindings()
    {
      Il2CppClassPointerStore<IOSBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (IOSBindings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSBindings>.NativeClassPtr);
      IOSBindings.NativeMethodInfoPtr_EOS_Auth_Login_Internal_Static_Void_IntPtr_byref_IOSLoginOptionsInternal_IntPtr_OnLoginCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSBindings>.NativeClassPtr, 100664834);
    }

    public IOSBindings(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
