// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.MetricsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics
{
  public sealed class MetricsInterface : Handle
  {
    private static readonly IntPtr NativeFieldInfoPtr_BeginplayersessionApiLatest;
    private static readonly IntPtr NativeFieldInfoPtr_EndplayersessionApiLatest;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_BeginPlayerSession_Public_Result_byref_BeginPlayerSessionOptions_0;
    private static readonly IntPtr NativeMethodInfoPtr_EndPlayerSession_Public_Result_byref_EndPlayerSessionOptions_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MetricsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MetricsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953595, XrefRangeEnd = 953603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result BeginPlayerSession(ref BeginPlayerSessionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetricsInterface.NativeMethodInfoPtr_BeginPlayerSession_Public_Result_byref_BeginPlayerSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953603, XrefRangeEnd = 953611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result EndPlayerSession(ref EndPlayerSessionOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MetricsInterface.NativeMethodInfoPtr_EndPlayerSession_Public_Result_byref_EndPlayerSessionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MetricsInterface()
    {
      Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Metrics", nameof (MetricsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr);
      MetricsInterface.NativeFieldInfoPtr_BeginplayersessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, nameof (BeginplayersessionApiLatest));
      MetricsInterface.NativeFieldInfoPtr_EndplayersessionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, nameof (EndplayersessionApiLatest));
      MetricsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, 100669550);
      MetricsInterface.NativeMethodInfoPtr_BeginPlayerSession_Public_Result_byref_BeginPlayerSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, 100669552);
      MetricsInterface.NativeMethodInfoPtr_EndPlayerSession_Public_Result_byref_EndPlayerSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetricsInterface>.NativeClassPtr, 100669553);
    }

    public MetricsInterface(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int BeginplayersessionApiLatest
    {
      get
      {
        int beginplayersessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(MetricsInterface.NativeFieldInfoPtr_BeginplayersessionApiLatest, (void*) &beginplayersessionApiLatest);
        return beginplayersessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MetricsInterface.NativeFieldInfoPtr_BeginplayersessionApiLatest, (void*) &value);
      }
    }

    public static unsafe int EndplayersessionApiLatest
    {
      get
      {
        int endplayersessionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(MetricsInterface.NativeFieldInfoPtr_EndplayersessionApiLatest, (void*) &endplayersessionApiLatest);
        return endplayersessionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MetricsInterface.NativeFieldInfoPtr_EndplayersessionApiLatest, (void*) &value);
      }
    }
  }
}
