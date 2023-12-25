// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.IOSCredentialsSystemAuthCredentialsOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IOSCredentialsSystemAuthCredentialsOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PresentationContextProviding_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PresentationContextProviding_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PresentationContextProviding_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_IOSCredentialsSystemAuthCredentialsOptionsInternal_0;
    [FieldOffset(0)]
    public System.IntPtr _PresentationContextProviding_k__BackingField;

    public unsafe System.IntPtr PresentationContextProviding
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptions.NativeMethodInfoPtr_get_PresentationContextProviding_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptions.NativeMethodInfoPtr_set_PresentationContextProviding_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 937891, RefRangeEnd = 937897, XrefRangeStart = 937891, XrefRangeEnd = 937897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(
      ref IOSCredentialsSystemAuthCredentialsOptionsInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_IOSCredentialsSystemAuthCredentialsOptionsInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IOSCredentialsSystemAuthCredentialsOptions()
    {
      Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (IOSCredentialsSystemAuthCredentialsOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptions>.NativeClassPtr);
      IOSCredentialsSystemAuthCredentialsOptions.NativeFieldInfoPtr__PresentationContextProviding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptions>.NativeClassPtr, "<PresentationContextProviding>k__BackingField");
      IOSCredentialsSystemAuthCredentialsOptions.NativeMethodInfoPtr_get_PresentationContextProviding_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptions>.NativeClassPtr, 100673748);
      IOSCredentialsSystemAuthCredentialsOptions.NativeMethodInfoPtr_set_PresentationContextProviding_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptions>.NativeClassPtr, 100673749);
      IOSCredentialsSystemAuthCredentialsOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_IOSCredentialsSystemAuthCredentialsOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptions>.NativeClassPtr, 100673750);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
