// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Common
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices
{
  public sealed class Common : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidNotificationid;
    private static readonly System.IntPtr NativeFieldInfoPtr_IptUnknown;
    private static readonly System.IntPtr NativeFieldInfoPtr_PagequeryApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PagequeryMaxcountDefault;
    private static readonly System.IntPtr NativeFieldInfoPtr_PagequeryMaxcountMaximum;
    private static readonly System.IntPtr NativeFieldInfoPtr_PaginationApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_Utf8String_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_Result_ArraySegment_1_Byte_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_Utf8String_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 936266, RefRangeEnd = 936268, XrefRangeStart = 936261, XrefRangeEnd = 936266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsOperationComplete(Result result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936268, XrefRangeEnd = 936273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Utf8String ToString(Result result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Utf8String_Result_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 936283, RefRangeEnd = 936284, XrefRangeStart = 936273, XrefRangeEnd = 936283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result ToString(Il2CppSystem.ArraySegment<byte> byteArray, out Utf8String outBuffer)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) byteArray));
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Result_ArraySegment_1_Byte_byref_Utf8String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Utf8String utf8String = pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 936297, RefRangeEnd = 936298, XrefRangeStart = 936284, XrefRangeEnd = 936297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Utf8String ToString(Il2CppSystem.ArraySegment<byte> byteArray)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) byteArray));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Utf8String_ArraySegment_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Common()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Common()
    {
      Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (Common));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr);
      Epic.OnlineServices.Common.NativeFieldInfoPtr_InvalidNotificationid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (InvalidNotificationid));
      Epic.OnlineServices.Common.NativeFieldInfoPtr_IptUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (IptUnknown));
      Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PagequeryApiLatest));
      Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PagequeryMaxcountDefault));
      Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PagequeryMaxcountMaximum));
      Epic.OnlineServices.Common.NativeFieldInfoPtr_PaginationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PaginationApiLatest));
      Epic.OnlineServices.Common.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664813);
      Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Utf8String_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664814);
      Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Result_ArraySegment_1_Byte_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664815);
      Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Utf8String_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664816);
      Epic.OnlineServices.Common.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664817);
    }

    public Common(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ulong InvalidNotificationid
    {
      get
      {
        ulong invalidNotificationid;
        IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_InvalidNotificationid, (void*) &invalidNotificationid);
        return invalidNotificationid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_InvalidNotificationid, (void*) &value);
      }
    }

    public static unsafe Utf8String IptUnknown
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_IptUnknown, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_IptUnknown, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int PagequeryApiLatest
    {
      get
      {
        int pagequeryApiLatest;
        IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryApiLatest, (void*) &pagequeryApiLatest);
        return pagequeryApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryApiLatest, (void*) &value);
      }
    }

    public static unsafe int PagequeryMaxcountDefault
    {
      get
      {
        int pagequeryMaxcountDefault;
        IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountDefault, (void*) &pagequeryMaxcountDefault);
        return pagequeryMaxcountDefault;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountDefault, (void*) &value);
      }
    }

    public static unsafe int PagequeryMaxcountMaximum
    {
      get
      {
        int pagequeryMaxcountMaximum;
        IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountMaximum, (void*) &pagequeryMaxcountMaximum);
        return pagequeryMaxcountMaximum;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountMaximum, (void*) &value);
      }
    }

    public static unsafe int PaginationApiLatest
    {
      get
      {
        int paginationApiLatest;
        IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PaginationApiLatest, (void*) &paginationApiLatest);
        return paginationApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PaginationApiLatest, (void*) &value);
      }
    }
  }
}
