﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.HideFriendsCallbackInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI
{
  public sealed class HideFriendsCallbackInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ResultCode_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_HideFriendsCallbackInfoInternal_0;

    public unsafe Result ResultCode
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Result*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId LocalUserId
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937485, XrefRangeEnd = 937488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Nullable_Unboxed<Result> GetResultCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<Result>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937488, XrefRangeEnd = 937492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref HideFriendsCallbackInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HideFriendsCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_HideFriendsCallbackInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HideFriendsCallbackInfo()
    {
      Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (HideFriendsCallbackInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr);
      HideFriendsCallbackInfo.NativeFieldInfoPtr__ResultCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, "<ResultCode>k__BackingField");
      HideFriendsCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, "<ClientData>k__BackingField");
      HideFriendsCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, "<LocalUserId>k__BackingField");
      HideFriendsCallbackInfo.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665157);
      HideFriendsCallbackInfo.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665158);
      HideFriendsCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665159);
      HideFriendsCallbackInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665160);
      HideFriendsCallbackInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665161);
      HideFriendsCallbackInfo.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665162);
      HideFriendsCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665163);
      HideFriendsCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_HideFriendsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, 100665164);
    }

    public HideFriendsCallbackInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public HideFriendsCallbackInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideFriendsCallbackInfo>.NativeClassPtr, data));
    }

    public unsafe Result _ResultCode_k__BackingField
    {
      get
      {
        return *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideFriendsCallbackInfo.NativeFieldInfoPtr__ResultCode_k__BackingField));
      }
      [param: In] set
      {
        *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideFriendsCallbackInfo.NativeFieldInfoPtr__ResultCode_k__BackingField)) = value;
      }
    }

    public unsafe Il2CppSystem.Object _ClientData_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideFriendsCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideFriendsCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EpicAccountId _LocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HideFriendsCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HideFriendsCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
