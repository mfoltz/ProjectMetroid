// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AndroidBindings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.Platform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace Epic.OnlineServices
{
  public static class AndroidBindings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_EOS_Initialize_Internal_Static_Result_byref_AndroidInitializeOptionsInternal_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 934581, RefRangeEnd = 934582, XrefRangeStart = 934579, XrefRangeEnd = 934581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result EOS_Initialize(ref AndroidInitializeOptionsInternal options)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AndroidBindings.NativeMethodInfoPtr_EOS_Initialize_Internal_Static_Result_byref_AndroidInitializeOptionsInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AndroidBindings()
    {
      Il2CppClassPointerStore<AndroidBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (AndroidBindings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidBindings>.NativeClassPtr);
      AndroidBindings.NativeMethodInfoPtr_EOS_Initialize_Internal_Static_Result_byref_AndroidInitializeOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidBindings>.NativeClassPtr, 100664266);
    }

    public AndroidBindings(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
