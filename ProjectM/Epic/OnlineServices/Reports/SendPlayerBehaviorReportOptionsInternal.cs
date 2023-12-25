// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Reports.SendPlayerBehaviorReportOptionsInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct SendPlayerBehaviorReportOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReporterUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReportedUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Message;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Context;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SendPlayerBehaviorReportOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SendPlayerBehaviorReportOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_ReporterUserId;
    [FieldOffset(16)]
    public System.IntPtr m_ReportedUserId;
    [FieldOffset(24)]
    public PlayerReportsCategory m_Category;
    [FieldOffset(32)]
    public System.IntPtr m_Message;
    [FieldOffset(40)]
    public System.IntPtr m_Context;

    public unsafe ProductUserId ReporterUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943607, XrefRangeEnd = 943611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId ReportedUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943611, XrefRangeEnd = 943615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PlayerReportsCategory Category
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Message
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943615, XrefRangeEnd = 943619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Context
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943619, XrefRangeEnd = 943623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Context_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 943639, RefRangeEnd = 943640, XrefRangeStart = 943623, XrefRangeEnd = 943639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SendPlayerBehaviorReportOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SendPlayerBehaviorReportOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943640, XrefRangeEnd = 943668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<SendPlayerBehaviorReportOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SendPlayerBehaviorReportOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943668, XrefRangeEnd = 943675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SendPlayerBehaviorReportOptionsInternal()
    {
      Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Reports", nameof (SendPlayerBehaviorReportOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr);
      SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_ReporterUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_ReporterUserId));
      SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_ReportedUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_ReportedUserId));
      SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_Category));
      SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_Message));
      SendPlayerBehaviorReportOptionsInternal.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, nameof (m_Context));
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666857);
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666858);
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666859);
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666860);
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_set_Context_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666861);
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SendPlayerBehaviorReportOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666862);
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SendPlayerBehaviorReportOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666863);
      SendPlayerBehaviorReportOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, 100666864);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendPlayerBehaviorReportOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
