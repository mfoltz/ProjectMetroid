// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.IOSCredentialsSystemAuthCredentialsOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IOSCredentialsSystemAuthCredentialsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PresentationContextProviding;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PresentationContextProviding_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PresentationContextProviding_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSCredentialsSystemAuthCredentialsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_IOSCredentialsSystemAuthCredentialsOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PresentationContextProviding;

    public unsafe System.IntPtr PresentationContextProviding
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_get_PresentationContextProviding_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_set_PresentationContextProviding_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 937897, RefRangeEnd = 937902, XrefRangeStart = 937897, XrefRangeEnd = 937902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref IOSCredentialsSystemAuthCredentialsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSCredentialsSystemAuthCredentialsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968841, XrefRangeEnd = 968845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<IOSCredentialsSystemAuthCredentialsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 968845, XrefRangeEnd = 968849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(
      out IOSCredentialsSystemAuthCredentialsOptions output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_IOSCredentialsSystemAuthCredentialsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IOSCredentialsSystemAuthCredentialsOptionsInternal()
    {
      Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Auth", nameof (IOSCredentialsSystemAuthCredentialsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr);
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeFieldInfoPtr_m_PresentationContextProviding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, nameof (m_PresentationContextProviding));
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_get_PresentationContextProviding_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, 100673751);
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_set_PresentationContextProviding_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, 100673752);
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IOSCredentialsSystemAuthCredentialsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, 100673753);
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_IOSCredentialsSystemAuthCredentialsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, 100673754);
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, 100673755);
      IOSCredentialsSystemAuthCredentialsOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_IOSCredentialsSystemAuthCredentialsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, 100673756);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IOSCredentialsSystemAuthCredentialsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
