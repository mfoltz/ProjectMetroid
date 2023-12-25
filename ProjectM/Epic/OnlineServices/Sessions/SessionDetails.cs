// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetails
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  public sealed class SessionDetails : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SessiondetailsAttributeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessiondetailsInfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessiondetailsSettingsApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyInfo_Public_Result_byref_SessionDetailsCopyInfoOptions_byref_Nullable_1_SessionDetailsInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionAttributeByIndex_Public_Result_byref_SessionDetailsCopySessionAttributeByIndexOptions_byref_Nullable_1_SessionDetailsAttribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopySessionAttributeByKey_Public_Result_byref_SessionDetailsCopySessionAttributeByKeyOptions_byref_Nullable_1_SessionDetailsAttribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSessionAttributeCount_Public_UInt32_byref_SessionDetailsGetSessionAttributeCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionDetails()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941474, XrefRangeEnd = 941487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyInfo(
      ref SessionDetailsCopyInfoOptions options,
      out Il2CppSystem.Nullable<SessionDetailsInfo> outSessionInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_byref_SessionDetailsCopyInfoOptions_byref_Nullable_1_SessionDetailsInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<SessionDetailsInfo> local = ref outSessionInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<SessionDetailsInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941487, XrefRangeEnd = 941500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopySessionAttributeByIndex(
      ref SessionDetailsCopySessionAttributeByIndexOptions options,
      out Il2CppSystem.Nullable<SessionDetailsAttribute> outSessionAttribute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByIndex_Public_Result_byref_SessionDetailsCopySessionAttributeByIndexOptions_byref_Nullable_1_SessionDetailsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<SessionDetailsAttribute> local = ref outSessionAttribute;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<SessionDetailsAttribute>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941500, XrefRangeEnd = 941517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopySessionAttributeByKey(
      ref SessionDetailsCopySessionAttributeByKeyOptions options,
      out Il2CppSystem.Nullable<SessionDetailsAttribute> outSessionAttribute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByKey_Public_Result_byref_SessionDetailsCopySessionAttributeByKeyOptions_byref_Nullable_1_SessionDetailsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<SessionDetailsAttribute> local = ref outSessionAttribute;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<SessionDetailsAttribute>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941517, XrefRangeEnd = 941524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetSessionAttributeCount(
      ref SessionDetailsGetSessionAttributeCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_GetSessionAttributeCount_Public_UInt32_byref_SessionDetailsGetSessionAttributeCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941524, XrefRangeEnd = 941525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionDetails()
    {
      Il2CppClassPointerStore<SessionDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetails));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr);
      SessionDetails.NativeFieldInfoPtr_SessiondetailsAttributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsAttributeApiLatest));
      SessionDetails.NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsCopyinfoApiLatest));
      SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsCopysessionattributebyindexApiLatest));
      SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsCopysessionattributebykeyApiLatest));
      SessionDetails.NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsGetsessionattributecountApiLatest));
      SessionDetails.NativeFieldInfoPtr_SessiondetailsInfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsInfoApiLatest));
      SessionDetails.NativeFieldInfoPtr_SessiondetailsSettingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsSettingsApiLatest));
      SessionDetails.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100666325);
      SessionDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_byref_SessionDetailsCopyInfoOptions_byref_Nullable_1_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100666327);
      SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByIndex_Public_Result_byref_SessionDetailsCopySessionAttributeByIndexOptions_byref_Nullable_1_SessionDetailsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100666328);
      SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByKey_Public_Result_byref_SessionDetailsCopySessionAttributeByKeyOptions_byref_Nullable_1_SessionDetailsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100666329);
      SessionDetails.NativeMethodInfoPtr_GetSessionAttributeCount_Public_UInt32_byref_SessionDetailsGetSessionAttributeCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100666330);
      SessionDetails.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100666331);
    }

    public SessionDetails(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SessiondetailsAttributeApiLatest
    {
      get
      {
        int attributeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsAttributeApiLatest, (void*) &attributeApiLatest);
        return attributeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsAttributeApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessiondetailsCopyinfoApiLatest
    {
      get
      {
        int copyinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest, (void*) &copyinfoApiLatest);
        return copyinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessiondetailsCopysessionattributebyindexApiLatest
    {
      get
      {
        int copysessionattributebyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest, (void*) &copysessionattributebyindexApiLatest);
        return copysessionattributebyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessiondetailsCopysessionattributebykeyApiLatest
    {
      get
      {
        int copysessionattributebykeyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest, (void*) &copysessionattributebykeyApiLatest);
        return copysessionattributebykeyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessiondetailsGetsessionattributecountApiLatest
    {
      get
      {
        int getsessionattributecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest, (void*) &getsessionattributecountApiLatest);
        return getsessionattributecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessiondetailsInfoApiLatest
    {
      get
      {
        int sessiondetailsInfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsInfoApiLatest, (void*) &sessiondetailsInfoApiLatest);
        return sessiondetailsInfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsInfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int SessiondetailsSettingsApiLatest
    {
      get
      {
        int settingsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsSettingsApiLatest, (void*) &settingsApiLatest);
        return settingsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsSettingsApiLatest, (void*) &value);
      }
    }
  }
}
