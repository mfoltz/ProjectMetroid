// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Reports.ReportsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Reports
{
  public sealed class ReportsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ReportcontextMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReportmessageMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendplayerbehaviorreportApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerBehaviorReport_Public_Void_byref_SendPlayerBehaviorReportOptions_Object_OnSendPlayerBehaviorReportCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSendPlayerBehaviorReportCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SendPlayerBehaviorReportCompleteCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReportsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReportsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943541, XrefRangeEnd = 943564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendPlayerBehaviorReport(
      ref SendPlayerBehaviorReportOptions options,
      Il2CppSystem.Object clientData,
      OnSendPlayerBehaviorReportCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReportsInterface.NativeMethodInfoPtr_SendPlayerBehaviorReport_Public_Void_byref_SendPlayerBehaviorReportOptions_Object_OnSendPlayerBehaviorReportCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943564, XrefRangeEnd = 943571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSendPlayerBehaviorReportCompleteCallbackInternalImplementation(
      ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReportsInterface.NativeMethodInfoPtr_OnSendPlayerBehaviorReportCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SendPlayerBehaviorReportCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReportsInterface()
    {
      Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Reports", nameof (ReportsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr);
      ReportsInterface.NativeFieldInfoPtr_ReportcontextMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr, nameof (ReportcontextMaxLength));
      ReportsInterface.NativeFieldInfoPtr_ReportmessageMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr, nameof (ReportmessageMaxLength));
      ReportsInterface.NativeFieldInfoPtr_SendplayerbehaviorreportApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr, nameof (SendplayerbehaviorreportApiLatest));
      ReportsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr, 100666828);
      ReportsInterface.NativeMethodInfoPtr_SendPlayerBehaviorReport_Public_Void_byref_SendPlayerBehaviorReportOptions_Object_OnSendPlayerBehaviorReportCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr, 100666830);
      ReportsInterface.NativeMethodInfoPtr_OnSendPlayerBehaviorReportCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SendPlayerBehaviorReportCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportsInterface>.NativeClassPtr, 100666831);
    }

    public ReportsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int ReportcontextMaxLength
    {
      get
      {
        int reportcontextMaxLength;
        IL2CPP.il2cpp_field_static_get_value(ReportsInterface.NativeFieldInfoPtr_ReportcontextMaxLength, (void*) &reportcontextMaxLength);
        return reportcontextMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReportsInterface.NativeFieldInfoPtr_ReportcontextMaxLength, (void*) &value);
      }
    }

    public static unsafe int ReportmessageMaxLength
    {
      get
      {
        int reportmessageMaxLength;
        IL2CPP.il2cpp_field_static_get_value(ReportsInterface.NativeFieldInfoPtr_ReportmessageMaxLength, (void*) &reportmessageMaxLength);
        return reportmessageMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReportsInterface.NativeFieldInfoPtr_ReportmessageMaxLength, (void*) &value);
      }
    }

    public static unsafe int SendplayerbehaviorreportApiLatest
    {
      get
      {
        int sendplayerbehaviorreportApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ReportsInterface.NativeFieldInfoPtr_SendplayerbehaviorreportApiLatest, (void*) &sendplayerbehaviorreportApiLatest);
        return sendplayerbehaviorreportApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReportsInterface.NativeFieldInfoPtr_SendplayerbehaviorreportApiLatest, (void*) &value);
      }
    }
  }
}
