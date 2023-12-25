// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Reports.SendPlayerBehaviorReportOptions
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
  public sealed class SendPlayerBehaviorReportOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ReporterUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReportedUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Category_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Message_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Context_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReporterUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReportedUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Category_Public_get_PlayerReportsCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Message_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Context_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_Utf8String_0;

    public unsafe ProductUserId ReporterUserId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReporterUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId ReportedUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReportedUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe PlayerReportsCategory Category
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Category_Public_get_PlayerReportsCategory_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlayerReportsCategory*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Message
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Message_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Context
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Context_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Context_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SendPlayerBehaviorReportOptions()
    {
      Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Reports", nameof (SendPlayerBehaviorReportOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr);
      SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReporterUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<ReporterUserId>k__BackingField");
      SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReportedUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<ReportedUserId>k__BackingField");
      SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Category_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<Category>k__BackingField");
      SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<Message>k__BackingField");
      SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Context_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, "<Context>k__BackingField");
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReporterUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666847);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReporterUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666848);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_ReportedUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666849);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_ReportedUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666850);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Category_Public_get_PlayerReportsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666851);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Category_Public_set_Void_PlayerReportsCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666852);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Message_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666853);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Message_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666854);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_get_Context_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666855);
      SendPlayerBehaviorReportOptions.NativeMethodInfoPtr_set_Context_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, 100666856);
    }

    public SendPlayerBehaviorReportOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SendPlayerBehaviorReportOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendPlayerBehaviorReportOptions>.NativeClassPtr, data));
    }

    public unsafe ProductUserId _ReporterUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReporterUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReporterUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProductUserId _ReportedUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReportedUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__ReportedUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlayerReportsCategory _Category_k__BackingField
    {
      get
      {
        return *(PlayerReportsCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Category_k__BackingField));
      }
      [param: In] set
      {
        *(PlayerReportsCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Category_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _Message_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Message_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _Context_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Context_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPlayerBehaviorReportOptions.NativeFieldInfoPtr__Context_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
