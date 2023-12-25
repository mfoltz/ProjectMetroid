// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.ActiveSession
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
  public sealed class ActiveSession : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivesessionInfoApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyInfo_Public_Result_byref_ActiveSessionCopyInfoOptions_byref_Nullable_1_ActiveSessionInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRegisteredPlayerByIndex_Public_ProductUserId_byref_ActiveSessionGetRegisteredPlayerByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRegisteredPlayerCount_Public_UInt32_byref_ActiveSessionGetRegisteredPlayerCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActiveSession()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939932, XrefRangeEnd = 939945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyInfo(
      ref ActiveSessionCopyInfoOptions options,
      out Il2CppSystem.Nullable<ActiveSessionInfo> outActiveSessionInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_CopyInfo_Public_Result_byref_ActiveSessionCopyInfoOptions_byref_Nullable_1_ActiveSessionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<ActiveSessionInfo> local = ref outActiveSessionInfo;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<ActiveSessionInfo>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939945, XrefRangeEnd = 939955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProductUserId GetRegisteredPlayerByIndex(
      ref ActiveSessionGetRegisteredPlayerByIndexOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerByIndex_Public_ProductUserId_byref_ActiveSessionGetRegisteredPlayerByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 939962, RefRangeEnd = 939963, XrefRangeStart = 939955, XrefRangeEnd = 939962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetRegisteredPlayerCount(
      ref ActiveSessionGetRegisteredPlayerCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerCount_Public_UInt32_byref_ActiveSessionGetRegisteredPlayerCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 939964, RefRangeEnd = 939966, XrefRangeStart = 939963, XrefRangeEnd = 939964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ActiveSession()
    {
      Il2CppClassPointerStore<ActiveSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (ActiveSession));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr);
      ActiveSession.NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionCopyinfoApiLatest));
      ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionGetregisteredplayerbyindexApiLatest));
      ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionGetregisteredplayercountApiLatest));
      ActiveSession.NativeFieldInfoPtr_ActivesessionInfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionInfoApiLatest));
      ActiveSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665849);
      ActiveSession.NativeMethodInfoPtr_CopyInfo_Public_Result_byref_ActiveSessionCopyInfoOptions_byref_Nullable_1_ActiveSessionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665851);
      ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerByIndex_Public_ProductUserId_byref_ActiveSessionGetRegisteredPlayerByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665852);
      ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerCount_Public_UInt32_byref_ActiveSessionGetRegisteredPlayerCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665853);
      ActiveSession.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665854);
    }

    public ActiveSession(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int ActivesessionCopyinfoApiLatest
    {
      get
      {
        int copyinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest, (void*) &copyinfoApiLatest);
        return copyinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int ActivesessionGetregisteredplayerbyindexApiLatest
    {
      get
      {
        int getregisteredplayerbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest, (void*) &getregisteredplayerbyindexApiLatest);
        return getregisteredplayerbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int ActivesessionGetregisteredplayercountApiLatest
    {
      get
      {
        int getregisteredplayercountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest, (void*) &getregisteredplayercountApiLatest);
        return getregisteredplayercountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest, (void*) &value);
      }
    }

    public static unsafe int ActivesessionInfoApiLatest
    {
      get
      {
        int activesessionInfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionInfoApiLatest, (void*) &activesessionInfoApiLatest);
        return activesessionInfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionInfoApiLatest, (void*) &value);
      }
    }
  }
}
