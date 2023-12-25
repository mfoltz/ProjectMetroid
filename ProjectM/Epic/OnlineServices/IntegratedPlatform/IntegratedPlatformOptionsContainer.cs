// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.IntegratedPlatform.IntegratedPlatformOptionsContainer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.IntegratedPlatform
{
  public sealed class IntegratedPlatformOptionsContainer : Handle
  {
    private static readonly IntPtr NativeFieldInfoPtr_IntegratedplatformoptionscontainerAddApiLatest;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Result_byref_IntegratedPlatformOptionsContainerAddOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntegratedPlatformOptionsContainer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedPlatformOptionsContainer>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformOptionsContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960261, XrefRangeEnd = 960274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result Add(
      ref IntegratedPlatformOptionsContainerAddOptions inOptions)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) inOptions);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformOptionsContainer.NativeMethodInfoPtr_Add_Public_Result_byref_IntegratedPlatformOptionsContainerAddOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960274, XrefRangeEnd = 960275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformOptionsContainer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IntegratedPlatformOptionsContainer()
    {
      Il2CppClassPointerStore<IntegratedPlatformOptionsContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.IntegratedPlatform", nameof (IntegratedPlatformOptionsContainer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedPlatformOptionsContainer>.NativeClassPtr);
      IntegratedPlatformOptionsContainer.NativeFieldInfoPtr_IntegratedplatformoptionscontainerAddApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedPlatformOptionsContainer>.NativeClassPtr, nameof (IntegratedplatformoptionscontainerAddApiLatest));
      IntegratedPlatformOptionsContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformOptionsContainer>.NativeClassPtr, 100671396);
      IntegratedPlatformOptionsContainer.NativeMethodInfoPtr_Add_Public_Result_byref_IntegratedPlatformOptionsContainerAddOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformOptionsContainer>.NativeClassPtr, 100671398);
      IntegratedPlatformOptionsContainer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformOptionsContainer>.NativeClassPtr, 100671399);
    }

    public IntegratedPlatformOptionsContainer(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int IntegratedplatformoptionscontainerAddApiLatest
    {
      get
      {
        int integratedplatformoptionscontainerAddApiLatest;
        IL2CPP.il2cpp_field_static_get_value(IntegratedPlatformOptionsContainer.NativeFieldInfoPtr_IntegratedplatformoptionscontainerAddApiLatest, (void*) &integratedplatformoptionscontainerAddApiLatest);
        return integratedplatformoptionscontainerAddApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IntegratedPlatformOptionsContainer.NativeFieldInfoPtr_IntegratedplatformoptionscontainerAddApiLatest, (void*) &value);
      }
    }
  }
}
