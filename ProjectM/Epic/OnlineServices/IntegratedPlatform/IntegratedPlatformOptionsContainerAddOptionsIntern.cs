// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.IntegratedPlatform.IntegratedPlatformOptionsContainerAddOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.IntegratedPlatform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IntegratedPlatformOptionsContainerAddOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Options;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Options_Public_set_Void_Nullable_1_Options_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IntegratedPlatformOptionsContainerAddOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IntegratedPlatformOptionsContainerAddOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Options;

    public unsafe Il2CppSystem.Nullable<Epic.OnlineServices.IntegratedPlatform.Options> Options
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960276, XrefRangeEnd = 960282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_set_Options_Public_set_Void_Nullable_1_Options_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960282, XrefRangeEnd = 960288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref IntegratedPlatformOptionsContainerAddOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IntegratedPlatformOptionsContainerAddOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960288, XrefRangeEnd = 960298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<IntegratedPlatformOptionsContainerAddOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IntegratedPlatformOptionsContainerAddOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960298, XrefRangeEnd = 960302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IntegratedPlatformOptionsContainerAddOptionsInternal()
    {
      Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.IntegratedPlatform", nameof (IntegratedPlatformOptionsContainerAddOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr);
      IntegratedPlatformOptionsContainerAddOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      IntegratedPlatformOptionsContainerAddOptionsInternal.NativeFieldInfoPtr_m_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr, nameof (m_Options));
      IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_set_Options_Public_set_Void_Nullable_1_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr, 100671402);
      IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_IntegratedPlatformOptionsContainerAddOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr, 100671403);
      IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_IntegratedPlatformOptionsContainerAddOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr, 100671404);
      IntegratedPlatformOptionsContainerAddOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr, 100671405);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntegratedPlatformOptionsContainerAddOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
