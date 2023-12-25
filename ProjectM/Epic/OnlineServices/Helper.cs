// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Helper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices
{
  public sealed class Helper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_s_Allocations;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_PinnedBuffers;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_Callbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_StaticCallbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_LastClientDataId;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_ClientDatas;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddCallback_Internal_Static_Void_byref_IntPtr_Object_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCallback_Private_Static_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAndRemoveCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStructCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCallbackByNotificationId_Internal_Static_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddStaticCallback_Internal_Static_Void_String_Delegate_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AssignNotificationIdToCallback_Internal_Static_Void_IntPtr_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddClientData_Private_Static_IntPtr_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveClientData_Private_Static_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClientData_Private_Static_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_IntPtr_byref_THandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Handle_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppStructArray_1_Byte_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_String_byref_Il2CppStructArray_1_Byte_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_ArraySegment_1_TArray_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_ArraySegment_1_T_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Int32_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Boolean_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Nullable_Unboxed_1_DateTimeOffset_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Private_Static_Void_Int64_byref_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_ArraySegment_1_TArray_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TTo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Int32_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Boolean_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Int64_byref_Nullable_Unboxed_1_DateTimeOffset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_ArraySegment_1_Byte_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TFrom_byref_Il2CppArrayBase_1_TTo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppStructArray_1_Byte_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_T_byref_T_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_Int32_byref_Nullable_Unboxed_1_Boolean_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_TFrom_byref_Nullable_1_TFrom_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TFrom_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_Unboxed_1_IntPtr_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Utf8String_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TTo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocationCount_Public_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Internal_Static_Void_Il2CppStructArray_1_Byte_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Internal_Static_Void_ArraySegment_1_Byte_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_TDisposable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_IntPtr_TEnum_TEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnsiStringLength_Private_Static_Int32_Il2CppStructArray_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnsiStringLength_Private_Static_Int32_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefault_Internal_Static_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Nullable_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAllocation_Internal_Static_IntPtr_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAllocation_Internal_Static_IntPtr_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Int32_Il2CppArrayBase_1_T_Nullable_Unboxed_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Il2CppArrayBase_1_T_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllocation_Private_Static_Void_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAllocationCache_Private_Static_Boolean_IntPtr_byref_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPinnedBuffer_Private_Static_IntPtr_Il2CppStructArray_1_Byte_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPinnedBuffer_Private_Static_IntPtr_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPinnedBuffer_Internal_Static_IntPtr_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemovePinnedBuffer_Private_Static_Void_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_byref_T_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Object_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Utf8String_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Handle_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_ArraySegment_1_Byte_byref_IntPtr_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_DateTimeOffset_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Boolean_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_String_byref_Il2CppStructArray_1_Byte_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_T_byref_T_TEnum_byref_TEnum_IDisposable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_byref_TEnum_IDisposable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_T_TEnum_byref_TEnum_IDisposable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Handle_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Utf8String_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_Boolean_byref_Int32_TEnum_byref_TEnum_IDisposable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Nullable_1_TFrom_byref_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_TTo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(160)]
    [CachedScanResults(RefRangeStart = 927286, RefRangeEnd = 927446, XrefRangeStart = 927268, XrefRangeEnd = 927286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddCallback(
      out System.IntPtr clientDataAddress,
      Il2CppSystem.Object clientData,
      Il2CppSystem.Delegate publicDelegate,
      Il2CppSystem.Delegate privateDelegate,
      [Optional] Il2CppReferenceArray<Il2CppSystem.Delegate> structDelegates)
    {
      if (structDelegates == null)
        structDelegates = new Il2CppReferenceArray<Il2CppSystem.Delegate>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref clientDataAddress;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) publicDelegate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) privateDelegate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) structDelegates);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddCallback_Internal_Static_Void_byref_IntPtr_Object_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 927460, RefRangeEnd = 927463, XrefRangeStart = 927446, XrefRangeEnd = 927460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveCallback(System.IntPtr clientDataAddress)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &clientDataAddress;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_RemoveCallback_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 927502, RefRangeEnd = 927503, XrefRangeStart = 927463, XrefRangeEnd = 927502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAndRemoveCallback<TCallbackInfoInternal, TCallback, TCallbackInfo>(
      ref TCallbackInfoInternal callbackInfoInternal,
      out TCallback callback,
      out TCallbackInfo callbackInfo)
      where TCallback : class
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callbackInfoInternal);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      TCallback& local1;
      if (!typeof (TCallback).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(TCallback*) &zero1);
      }
      else
        local1 = ref callback;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      TCallbackInfo& local2;
      if (!typeof (TCallbackInfo).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(TCallbackInfo*) &zero2);
      }
      else
        local2 = ref callbackInfo;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetAndRemoveCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0<TCallbackInfoInternal, TCallback, TCallbackInfo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TCallbackInfoInternal local3 = ref callbackInfoInternal;
      System.IntPtr objectPointer1 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallbackInfoInternal>(objectPointer1, false, false);
      local3 = (TCallbackInfoInternal) valueGeneric1;
      if (!typeof (TCallback).IsValueType)
      {
        ref TCallback local4 = ref callback;
        System.IntPtr objectPointer2 = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallback>(objectPointer2, false, false);
        local4 = (TCallback) valueGeneric2;
      }
      if (!typeof (TCallbackInfo).IsValueType)
      {
        ref TCallbackInfo local5 = ref callbackInfo;
        System.IntPtr objectPointer3 = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric3 = objectPointer3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallbackInfo>(objectPointer3, false, false);
        local5 = (TCallbackInfo) valueGeneric3;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 927549, RefRangeEnd = 927550, XrefRangeStart = 927503, XrefRangeEnd = 927549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetStructCallback<TCallbackInfoInternal, TCallback, TCallbackInfo>(
      ref TCallbackInfoInternal callbackInfoInternal,
      out TCallback callback,
      out TCallbackInfo callbackInfo)
      where TCallback : class
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callbackInfoInternal);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      TCallback& local1;
      if (!typeof (TCallback).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(TCallback*) &zero1);
      }
      else
        local1 = ref callback;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero2;
      // ISSUE: variable of a reference type
      TCallbackInfo& local2;
      if (!typeof (TCallbackInfo).IsValueType)
      {
        zero2 = System.IntPtr.Zero;
        local2 = ref (*(TCallbackInfo*) &zero2);
      }
      else
        local2 = ref callbackInfo;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr exc;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetStructCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0<TCallbackInfoInternal, TCallback, TCallbackInfo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TCallbackInfoInternal local3 = ref callbackInfoInternal;
      System.IntPtr objectPointer1 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallbackInfoInternal>(objectPointer1, false, false);
      local3 = (TCallbackInfoInternal) valueGeneric1;
      if (!typeof (TCallback).IsValueType)
      {
        ref TCallback local4 = ref callback;
        System.IntPtr objectPointer2 = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallback>(objectPointer2, false, false);
        local4 = (TCallback) valueGeneric2;
      }
      if (!typeof (TCallbackInfo).IsValueType)
      {
        ref TCallbackInfo local5 = ref callbackInfo;
        System.IntPtr objectPointer3 = zero2;
        // ISSUE: variable of the null type
        __Null valueGeneric3 = objectPointer3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallbackInfo>(objectPointer3, false, false);
        local5 = (TCallbackInfo) valueGeneric3;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(45)]
    [CachedScanResults(RefRangeStart = 927577, RefRangeEnd = 927622, XrefRangeStart = 927550, XrefRangeEnd = 927577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveCallbackByNotificationId(ulong notificationId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_RemoveCallbackByNotificationId_Internal_Static_Void_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 927646, RefRangeEnd = 927647, XrefRangeStart = 927622, XrefRangeEnd = 927646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddStaticCallback(
      string key,
      Il2CppSystem.Delegate publicDelegate,
      Il2CppSystem.Delegate privateDelegate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) publicDelegate);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) privateDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddStaticCallback_Internal_Static_Void_String_Delegate_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 927673, RefRangeEnd = 927674, XrefRangeStart = 927647, XrefRangeEnd = 927673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetStaticCallback<TCallback>(string key, out TCallback callback) where TCallback : class
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TCallback& local1;
      if (!typeof (TCallback).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TCallback*) &zero);
      }
      else
        local1 = ref callback;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0<TCallback>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (TCallback).IsValueType)
      {
        ref TCallback local2 = ref callback;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCallback>(objectPointer, false, false);
        local2 = (TCallback) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(46)]
    [CachedScanResults(RefRangeStart = 927694, RefRangeEnd = 927740, XrefRangeStart = 927674, XrefRangeEnd = 927694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AssignNotificationIdToCallback(
      System.IntPtr clientDataAddress,
      ulong notificationId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &clientDataAddress;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AssignNotificationIdToCallback_Internal_Static_Void_IntPtr_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 927755, RefRangeEnd = 927758, XrefRangeStart = 927740, XrefRangeEnd = 927755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddClientData(Il2CppSystem.Object clientData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddClientData_Private_Static_IntPtr_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 927771, RefRangeEnd = 927774, XrefRangeStart = 927758, XrefRangeEnd = 927771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveClientData(System.IntPtr clientDataAddress)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &clientDataAddress;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_RemoveClientData_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 927787, RefRangeEnd = 927789, XrefRangeStart = 927774, XrefRangeEnd = 927787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Object GetClientData(System.IntPtr clientDataAddress)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &clientDataAddress;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_GetClientData_Private_Static_Object_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927789, XrefRangeEnd = 927792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert<THandle>(System.IntPtr from, out THandle to) where THandle : Handle
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      THandle& local1;
      if (!typeof (THandle).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(THandle*) &zero);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Convert_Private_Static_Void_IntPtr_byref_THandle_0<THandle>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (typeof (THandle).IsValueType)
        return;
      ref THandle local2 = ref to;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<THandle>(objectPointer, false, false);
      local2 = (THandle) valueGeneric;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 927794, RefRangeEnd = 927796, XrefRangeStart = 927792, XrefRangeEnd = 927794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert(Handle from, out System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Handle_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927796, XrefRangeEnd = 927809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert(Il2CppStructArray<byte> from, out string to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppStructArray_1_Byte_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      to = IL2CPP.Il2CppStringToManaged(zero);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927809, XrefRangeEnd = 927822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert(string from, out Il2CppStructArray<byte> to, int fromLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(from);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fromLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_String_byref_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppStructArray<byte> local = ref to;
      System.IntPtr nativeObject = zero;
      Il2CppStructArray<> il2CppStructArray = nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<>) null : new Il2CppStructArray<>(nativeObject);
      local = (Il2CppStructArray<byte>) il2CppStructArray;
    }

    [CallerCount(0)]
    public static unsafe void Convert<TArray>(Il2CppArrayBase<TArray> from, out int to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0<TArray>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void Convert<TArray>(Il2CppArrayBase<TArray> from, out uint to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0<TArray>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void Convert<TArray>(Il2CppSystem.ArraySegment<TArray> from, out int to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) from));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Convert_Private_Static_Void_ArraySegment_1_TArray_byref_Int32_0<TArray>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void Convert<T>(Il2CppSystem.ArraySegment<T> from, out uint to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) from));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Convert_Private_Static_Void_ArraySegment_1_T_byref_UInt32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 927822, RefRangeEnd = 927823, XrefRangeStart = 927822, XrefRangeEnd = 927822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert(int from, out bool to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void Convert(bool from, out int to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Boolean_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927823, XrefRangeEnd = 927833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert(Nullable_Unboxed<Il2CppSystem.DateTimeOffset> from, out long to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Nullable_Unboxed_1_DateTimeOffset_byref_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927833, XrefRangeEnd = 927843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Convert(long from, out Nullable_Unboxed<Il2CppSystem.DateTimeOffset> to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Int64_byref_Nullable_Unboxed_1_DateTimeOffset_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927843, XrefRangeEnd = 927847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TArray>(Il2CppArrayBase<TArray> from, out int to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0<TArray>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927847, XrefRangeEnd = 927850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TArray>(Il2CppArrayBase<TArray> from, out uint to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0<TArray>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 927853, RefRangeEnd = 927854, XrefRangeStart = 927850, XrefRangeEnd = 927853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TArray>(Il2CppSystem.ArraySegment<TArray> from, out uint to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) from));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_ArraySegment_1_TArray_byref_UInt32_0<TArray>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(226)]
    [CachedScanResults(RefRangeStart = 927857, RefRangeEnd = 928083, XrefRangeStart = 927854, XrefRangeEnd = 927857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TTo>(System.IntPtr from, out TTo to) where TTo : Handle
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TTo& local1;
      if (!typeof (TTo).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TTo*) &zero);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_TTo_0<TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (typeof (TTo).IsValueType)
        return;
      ref TTo local2 = ref to;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTo>(objectPointer, false, false);
      local2 = (TTo) valueGeneric;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 928092, RefRangeEnd = 928094, XrefRangeStart = 928083, XrefRangeEnd = 928092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TTo>(ref TFrom from, out TTo to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TTo& local1;
      if (!typeof (TTo).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TTo*) &zero);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_byref_TFrom_byref_TTo_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TFrom local2 = ref from;
      System.IntPtr objectPointer1 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFrom>(objectPointer1, false, false);
      local2 = (TFrom) valueGeneric1;
      if (typeof (TTo).IsValueType)
        return;
      ref TTo local3 = ref to;
      System.IntPtr objectPointer2 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTo>(objectPointer2, false, false);
      local3 = (TTo) valueGeneric2;
    }

    [CallerCount(73)]
    [CachedScanResults(RefRangeStart = 928097, RefRangeEnd = 928170, XrefRangeStart = 928094, XrefRangeEnd = 928097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get(int from, out bool to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928170, XrefRangeEnd = 928173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get(bool from, out int to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Boolean_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 928186, RefRangeEnd = 928202, XrefRangeStart = 928173, XrefRangeEnd = 928186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get(long from, out Nullable_Unboxed<Il2CppSystem.DateTimeOffset> to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Int64_byref_Nullable_Unboxed_1_DateTimeOffset_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928202, XrefRangeEnd = 928206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TTo>(
      System.IntPtr from,
      out Il2CppArrayBase<TTo> to,
      int arrayLength,
      bool isArrayItemAllocated)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_Boolean_0<TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TTo>) il2CppArrayBase;
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 928217, RefRangeEnd = 928220, XrefRangeStart = 928206, XrefRangeEnd = 928217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TTo>(
      System.IntPtr from,
      out Il2CppArrayBase<TTo> to,
      uint arrayLength,
      bool isArrayItemAllocated)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_Boolean_0<TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TTo>) il2CppArrayBase;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928220, XrefRangeEnd = 928228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TTo>(System.IntPtr from, out Il2CppArrayBase<TTo> to, int arrayLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0<TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TTo>) il2CppArrayBase;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 928236, RefRangeEnd = 928237, XrefRangeStart = 928228, XrefRangeEnd = 928236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TTo>(System.IntPtr from, out Il2CppArrayBase<TTo> to, uint arrayLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0<TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TTo>) il2CppArrayBase;
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 928248, RefRangeEnd = 928256, XrefRangeStart = 928237, XrefRangeEnd = 928248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get(System.IntPtr from, out Il2CppSystem.ArraySegment<byte> to, uint arrayLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_ArraySegment_1_Byte_UInt32_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.ArraySegment<byte> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppSystem.ArraySegment<> arraySegment = pointer == System.IntPtr.Zero ? (Il2CppSystem.ArraySegment<>) null : new Il2CppSystem.ArraySegment<>(pointer);
      local = (Il2CppSystem.ArraySegment<byte>) arraySegment;
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 928259, RefRangeEnd = 928263, XrefRangeStart = 928256, XrefRangeEnd = 928259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetHandle<THandle>(
      System.IntPtr from,
      out Il2CppArrayBase<THandle> to,
      uint arrayLength)
      where THandle : Handle
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_GetHandle_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0<THandle>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<THandle> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<THandle>) il2CppArrayBase;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928263, XrefRangeEnd = 928272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TTo>(
      Il2CppArrayBase<TFrom> from,
      out Il2CppArrayBase<TTo> to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_Il2CppArrayBase_1_TFrom_byref_Il2CppArrayBase_1_TTo_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TTo>) il2CppArrayBase;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 928275, RefRangeEnd = 928276, XrefRangeStart = 928272, XrefRangeEnd = 928275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TTo>(
      System.IntPtr from,
      out Il2CppArrayBase<TTo> to,
      int arrayLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TTo>) il2CppArrayBase;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 928288, RefRangeEnd = 928289, XrefRangeStart = 928276, XrefRangeEnd = 928288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TTo>(
      System.IntPtr from,
      out Il2CppArrayBase<TTo> to,
      uint arrayLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TTo>) il2CppArrayBase;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928289, XrefRangeEnd = 928300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TTo>(System.IntPtr from, out Il2CppSystem.Nullable<TTo> to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0<TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<TTo>) nullable;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 928316, RefRangeEnd = 928318, XrefRangeStart = 928300, XrefRangeEnd = 928316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get(Il2CppStructArray<byte> from, out string to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppStructArray_1_Byte_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      to = IL2CPP.Il2CppStringToManaged(zero);
    }

    [CallerCount(306)]
    [CachedScanResults(RefRangeStart = 928323, RefRangeEnd = 928629, XrefRangeStart = 928318, XrefRangeEnd = 928323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get(System.IntPtr from, out Il2CppSystem.Object to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Object_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Object local = ref to;
      System.IntPtr pointer = zero;
      Il2CppSystem.Object @object = pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      local = @object;
    }

    [CallerCount(461)]
    [CachedScanResults(RefRangeStart = 928655, RefRangeEnd = 929116, XrefRangeStart = 928629, XrefRangeEnd = 928655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get(System.IntPtr from, out Utf8String to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Utf8String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Utf8String local = ref to;
      System.IntPtr pointer = zero;
      Utf8String utf8String = pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
      local = utf8String;
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 929128, RefRangeEnd = 929132, XrefRangeStart = 929116, XrefRangeEnd = 929128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<T, TEnum>(
      T from,
      out T to,
      TEnum currentEnum,
      TEnum expectedEnum)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) from;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref from;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local3;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local3 = ref (*(T*) &zero);
      }
      else
        local3 = ref to;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local4;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local5 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local4 = local5 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local5 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local5 as Il2CppObjectBase);
      }
      else
        local4 = ref currentEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local4;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local6;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local7 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local6 = local7 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local7 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local7 as Il2CppObjectBase);
      }
      else
        local6 = ref expectedEnum;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local6;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_T_byref_T_TEnum_TEnum_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (typeof (T).IsValueType)
        return;
      ref T local8 = ref to;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local8 = (T) valueGeneric;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 929146, RefRangeEnd = 929148, XrefRangeStart = 929132, XrefRangeEnd = 929146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TTo, TEnum>(
      ref TFrom from,
      out TTo to,
      TEnum currentEnum,
      TEnum expectedEnum)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TTo& local1;
      if (!typeof (TTo).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TTo*) &zero);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local2;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local3 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local2 = local3 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local3 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local3 as Il2CppObjectBase);
      }
      else
        local2 = ref currentEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local4;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local5 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local4 = local5 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local5 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local5 as Il2CppObjectBase);
      }
      else
        local4 = ref expectedEnum;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_TEnum_0<TFrom, TTo, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TFrom local6 = ref from;
      System.IntPtr objectPointer1 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFrom>(objectPointer1, false, false);
      local6 = (TFrom) valueGeneric1;
      if (typeof (TTo).IsValueType)
        return;
      ref TTo local7 = ref to;
      System.IntPtr objectPointer2 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTo>(objectPointer2, false, false);
      local7 = (TTo) valueGeneric2;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 929167, RefRangeEnd = 929169, XrefRangeStart = 929148, XrefRangeEnd = 929167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TEnum>(
      int from,
      out Nullable_Unboxed<bool> to,
      TEnum currentEnum,
      TEnum expectedEnum)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref currentEnum;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local3;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local4 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref expectedEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_Int32_byref_Nullable_Unboxed_1_Boolean_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 929182, RefRangeEnd = 929186, XrefRangeStart = 929169, XrefRangeEnd = 929182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TEnum>(
      TFrom from,
      out Il2CppSystem.Nullable<TFrom> to,
      TEnum currentEnum,
      TEnum expectedEnum)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TFrom& local1;
      if (!typeof (TFrom).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TFrom> local2 = (object) from;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TFrom&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TFrom&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref from;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr3;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local3;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local4 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref currentEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local5;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local6 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local5 = local6 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local6 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local6 as Il2CppObjectBase);
      }
      else
        local5 = ref expectedEnum;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local5;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_TFrom_byref_Nullable_1_TFrom_TEnum_TEnum_0<TFrom, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<TFrom> local7 = ref to;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local7 = (Il2CppSystem.Nullable<TFrom>) nullable;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 929201, RefRangeEnd = 929203, XrefRangeStart = 929186, XrefRangeEnd = 929201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TEnum>(
      System.IntPtr from,
      out TFrom to,
      TEnum currentEnum,
      TEnum expectedEnum)
      where TFrom : Handle
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &from;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TFrom& local1;
      if (!typeof (TFrom).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TFrom*) &zero);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local2;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local3 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local2 = local3 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local3 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local3 as Il2CppObjectBase);
      }
      else
        local2 = ref currentEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local2;
      System.IntPtr num3 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local4;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local5 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local4 = local5 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local5 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local5 as Il2CppObjectBase);
      }
      else
        local4 = ref expectedEnum;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_TFrom_TEnum_TEnum_0<TFrom, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (typeof (TFrom).IsValueType)
        return;
      ref TFrom local6 = ref to;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFrom>(objectPointer, false, false);
      local6 = (TFrom) valueGeneric;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 929221, RefRangeEnd = 929223, XrefRangeStart = 929203, XrefRangeEnd = 929221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TEnum>(
      System.IntPtr from,
      out Nullable_Unboxed<System.IntPtr> to,
      TEnum currentEnum,
      TEnum expectedEnum)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref currentEnum;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local3;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local4 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref expectedEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Nullable_Unboxed_1_IntPtr_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 929242, RefRangeEnd = 929247, XrefRangeStart = 929223, XrefRangeEnd = 929242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TEnum>(
      System.IntPtr from,
      out Utf8String to,
      TEnum currentEnum,
      TEnum expectedEnum)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref currentEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local3;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local4 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref expectedEnum;
      *(System.IntPtr*) num3 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Utf8String_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Utf8String local5 = ref to;
      System.IntPtr pointer = zero;
      Utf8String utf8String = pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
      local5 = utf8String;
    }

    [CallerCount(0)]
    public static unsafe void Get<TFrom, TTo>(System.IntPtr from, out TTo to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TTo& local1;
      if (!typeof (TTo).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TTo*) &zero);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_TTo_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (typeof (TTo).IsValueType)
        return;
      ref TTo local2 = ref to;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTo>(objectPointer, false, false);
      local2 = (TTo) valueGeneric;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 929255, RefRangeEnd = 929257, XrefRangeStart = 929247, XrefRangeEnd = 929255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TTo>(System.IntPtr from, out Il2CppSystem.Nullable<TTo> to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<TTo> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<TTo>) nullable;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929257, XrefRangeEnd = 929258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Get<TFrom, TTo>(
      ref TFrom from,
      out TTo to,
      out System.IntPtr clientDataAddress)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TTo& local1;
      if (!typeof (TTo).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TTo*) &zero);
      }
      else
        local1 = ref to;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref clientDataAddress;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Get_Internal_Static_Void_byref_TFrom_byref_TTo_byref_IntPtr_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TFrom local2 = ref from;
      System.IntPtr objectPointer1 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFrom>(objectPointer1, false, false);
      local2 = (TFrom) valueGeneric1;
      if (typeof (TTo).IsValueType)
        return;
      ref TTo local3 = ref to;
      System.IntPtr objectPointer2 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTo>(objectPointer2, false, false);
      local3 = (TTo) valueGeneric2;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929258, XrefRangeEnd = 929295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetAllocationCount()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_GetAllocationCount_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929295, XrefRangeEnd = 929301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Copy(Il2CppStructArray<byte> from, System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Copy_Internal_Static_Void_Il2CppStructArray_1_Byte_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929301, XrefRangeEnd = 929310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Copy(Il2CppSystem.ArraySegment<byte> from, System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) from));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Copy_Internal_Static_Void_ArraySegment_1_Byte_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1157)]
    [CachedScanResults(RefRangeStart = 929315, RefRangeEnd = 930472, XrefRangeStart = 929310, XrefRangeEnd = 929315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Dispose(ref System.IntPtr value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 930473, RefRangeEnd = 930474, XrefRangeStart = 930472, XrefRangeEnd = 930473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Dispose<TDisposable>(ref TDisposable disposable)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Dispose_Internal_Static_Void_byref_TDisposable_0<TDisposable>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TDisposable local = ref disposable;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TDisposable>(objectPointer, false, false);
      local = (TDisposable) valueGeneric;
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 930487, RefRangeEnd = 930493, XrefRangeStart = 930474, XrefRangeEnd = 930487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Dispose<TEnum>(
      ref System.IntPtr value,
      TEnum currentEnum,
      TEnum expectedEnum)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) currentEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref currentEnum;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local3;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local4 = (object) expectedEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref expectedEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Dispose_Internal_Static_Void_byref_IntPtr_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930493, XrefRangeEnd = 930494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetAnsiStringLength(Il2CppStructArray<byte> bytes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bytes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_GetAnsiStringLength_Private_Static_Int32_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930494, XrefRangeEnd = 930499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetAnsiStringLength(System.IntPtr address)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &address;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_GetAnsiStringLength_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 533439, RefRangeEnd = 533493, XrefRangeStart = 533439, XrefRangeEnd = 533493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T GetDefault<T>()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_GetDefault_Internal_Static_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930499, XrefRangeEnd = 930524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllocation<T>(System.IntPtr source, out T target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &source;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref target;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (typeof (T).IsValueType)
        return;
      ref T local2 = ref target;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local2 = (T) valueGeneric;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930524, XrefRangeEnd = 930550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllocation<T>(System.IntPtr source, out Il2CppSystem.Nullable<T> target)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &source;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_Nullable_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<T> local = ref target;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<T>) nullable;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930550, XrefRangeEnd = 930574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllocation<THandle>(
      System.IntPtr source,
      out Il2CppArrayBase<THandle> target,
      int arrayLength)
      where THandle : Handle
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &source;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0<THandle>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<THandle> local = ref target;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<THandle>) il2CppArrayBase;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930574, XrefRangeEnd = 930598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllocation<T>(
      System.IntPtr from,
      out Il2CppArrayBase<T> to,
      int arrayLength,
      bool isArrayItemAllocated)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<T> local = ref to;
      System.IntPtr pointer = zero;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<T>) il2CppArrayBase;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930598, XrefRangeEnd = 930621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetAllocation(System.IntPtr source, out Utf8String target)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &source;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Utf8String_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Utf8String local = ref target;
      System.IntPtr pointer = zero;
      Utf8String utf8String = pointer == System.IntPtr.Zero ? (Utf8String) null : new Utf8String(pointer);
      local = utf8String;
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 930641, RefRangeEnd = 930663, XrefRangeStart = 930621, XrefRangeEnd = 930641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddAllocation(int size)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &size;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddAllocation_Internal_Static_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 930667, RefRangeEnd = 930671, XrefRangeStart = 930663, XrefRangeEnd = 930667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddAllocation(uint size)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &size;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddAllocation_Internal_Static_IntPtr_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930671, XrefRangeEnd = 930695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddAllocation<T>(int size, T cache)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &size;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) cache;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref cache;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_AddAllocation_Private_Static_IntPtr_Int32_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930695, XrefRangeEnd = 930716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddAllocation<T>(
      int size,
      Il2CppArrayBase<T> cache,
      Nullable_Unboxed<bool> isArrayItemAllocated)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &size;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cache);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_AddAllocation_Private_Static_IntPtr_Int32_Il2CppArrayBase_1_T_Nullable_Unboxed_1_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930716, XrefRangeEnd = 930793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddAllocation<T>(
      Il2CppArrayBase<T> array,
      bool isArrayItemAllocated)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) array);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_AddAllocation_Private_Static_IntPtr_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 930863, RefRangeEnd = 930868, XrefRangeStart = 930793, XrefRangeEnd = 930863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveAllocation(ref System.IntPtr address)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref address;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_RemoveAllocation_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 930885, RefRangeEnd = 930889, XrefRangeStart = 930868, XrefRangeEnd = 930885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAllocationCache(System.IntPtr address, out Il2CppSystem.Object cache)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &address;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_TryGetAllocationCache_Private_Static_Boolean_IntPtr_byref_Object_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Object local = ref cache;
      System.IntPtr pointer = zero;
      Il2CppSystem.Object @object = pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      local = @object;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 930928, RefRangeEnd = 930932, XrefRangeStart = 930889, XrefRangeEnd = 930928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddPinnedBuffer(Il2CppStructArray<byte> buffer, int offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddPinnedBuffer_Private_Static_IntPtr_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 930938, RefRangeEnd = 930939, XrefRangeStart = 930932, XrefRangeEnd = 930938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddPinnedBuffer(Utf8String str)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) str);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddPinnedBuffer_Private_Static_IntPtr_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 930945, RefRangeEnd = 930950, XrefRangeStart = 930939, XrefRangeEnd = 930945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe System.IntPtr AddPinnedBuffer(Il2CppSystem.ArraySegment<byte> array)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) array));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_AddPinnedBuffer_Internal_Static_IntPtr_ArraySegment_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 930978, RefRangeEnd = 930983, XrefRangeStart = 930950, XrefRangeEnd = 930978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemovePinnedBuffer(ref System.IntPtr address)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref address;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_RemovePinnedBuffer_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(47)]
    [CachedScanResults(RefRangeStart = 927105, RefRangeEnd = 927152, XrefRangeStart = 927105, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(ref T from, ref T to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr1;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
      System.IntPtr* numPtr4 = &ptr2;
      *(System.IntPtr*) num = (System.IntPtr) numPtr4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_T_byref_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local1 = ref from;
      System.IntPtr objectPointer1 = ptr1;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer1, false, false);
      local1 = (T) valueGeneric1;
      ref T local2 = ref to;
      System.IntPtr objectPointer2 = ptr2;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer2, false, false);
      local2 = (T) valueGeneric2;
    }

    [CallerCount(459)]
    [CachedScanResults(RefRangeStart = 930988, RefRangeEnd = 931447, XrefRangeStart = 930983, XrefRangeEnd = 930988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(Il2CppSystem.Object from, ref System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Object_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1166)]
    [CachedScanResults(RefRangeStart = 931462, RefRangeEnd = 932628, XrefRangeStart = 931447, XrefRangeEnd = 931462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(Utf8String from, ref System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Utf8String_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1251)]
    [CachedScanResults(RefRangeStart = 932633, RefRangeEnd = 933884, XrefRangeStart = 932628, XrefRangeEnd = 932633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(Handle from, ref System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Handle_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 933896, RefRangeEnd = 933898, XrefRangeStart = 933884, XrefRangeEnd = 933896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(Nullable_Unboxed<T> from, ref System.IntPtr to) where T : unmanaged
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_IntPtr_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933898, XrefRangeEnd = 933902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(
      Il2CppArrayBase<T> from,
      ref System.IntPtr to,
      bool isArrayItemAllocated)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(38)]
    [CachedScanResults(RefRangeStart = 933915, RefRangeEnd = 933953, XrefRangeStart = 933902, XrefRangeEnd = 933915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(Il2CppSystem.ArraySegment<byte> from, ref System.IntPtr to, out uint arrayLength)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) from));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_ArraySegment_1_Byte_byref_IntPtr_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933953, XrefRangeEnd = 933962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(Il2CppArrayBase<T> from, ref System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933962, XrefRangeEnd = 933978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(
      Il2CppArrayBase<T> from,
      ref System.IntPtr to,
      bool isArrayItemAllocated,
      out int arrayLength)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933978, XrefRangeEnd = 933981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(
      Il2CppArrayBase<T> from,
      ref System.IntPtr to,
      bool isArrayItemAllocated,
      out uint arrayLength)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_UInt32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933981, XrefRangeEnd = 933989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(Il2CppArrayBase<T> from, ref System.IntPtr to, out int arrayLength)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 933997, RefRangeEnd = 933998, XrefRangeStart = 933989, XrefRangeEnd = 933997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T>(Il2CppArrayBase<T> from, ref System.IntPtr to, out uint arrayLength)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_UInt32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(45)]
    [CachedScanResults(RefRangeStart = 934011, RefRangeEnd = 934056, XrefRangeStart = 933998, XrefRangeEnd = 934011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(Nullable_Unboxed<Il2CppSystem.DateTimeOffset> from, ref long to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_DateTimeOffset_byref_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(205)]
    [CachedScanResults(RefRangeStart = 934059, RefRangeEnd = 934264, XrefRangeStart = 934056, XrefRangeEnd = 934059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(bool from, ref int to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Boolean_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 934280, RefRangeEnd = 934283, XrefRangeStart = 934264, XrefRangeEnd = 934280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(string from, ref Il2CppStructArray<byte> to, int stringLength)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) to);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stringLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_String_byref_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 934291, RefRangeEnd = 934293, XrefRangeStart = 934283, XrefRangeEnd = 934291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T, TEnum>(
      T from,
      ref T to,
      TEnum fromEnum,
      ref TEnum toEnum,
      Il2CppSystem.IDisposable disposable = null)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) from;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref from;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
      System.IntPtr* numPtr3 = &ptr1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr3;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local3;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local4 = (object) fromEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref fromEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local3;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toEnum);
      System.IntPtr* numPtr4 = &ptr2;
      *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_T_byref_T_TEnum_byref_TEnum_IDisposable_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local5 = ref to;
      System.IntPtr objectPointer1 = ptr1;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer1, false, false);
      local5 = (T) valueGeneric1;
      ref TEnum local6 = ref toEnum;
      System.IntPtr objectPointer2 = ptr2;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(objectPointer2, false, false);
      local6 = (TEnum) valueGeneric2;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 934299, RefRangeEnd = 934300, XrefRangeStart = 934293, XrefRangeEnd = 934299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TFrom, TEnum, TTo>(
      ref TFrom from,
      ref TTo to,
      TEnum fromEnum,
      ref TEnum toEnum,
      Il2CppSystem.IDisposable disposable = null)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr1;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
      System.IntPtr* numPtr4 = &ptr2;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) fromEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref fromEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toEnum);
      System.IntPtr* numPtr5 = &ptr3;
      *(System.IntPtr*) num3 = (System.IntPtr) numPtr5;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_byref_TEnum_IDisposable_0<TFrom, TEnum, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TFrom local3 = ref from;
      System.IntPtr objectPointer1 = ptr1;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFrom>(objectPointer1, false, false);
      local3 = (TFrom) valueGeneric1;
      ref TTo local4 = ref to;
      System.IntPtr objectPointer2 = ptr2;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTo>(objectPointer2, false, false);
      local4 = (TTo) valueGeneric2;
      ref TEnum local5 = ref toEnum;
      System.IntPtr objectPointer3 = ptr3;
      // ISSUE: variable of the null type
      __Null valueGeneric3 = objectPointer3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(objectPointer3, false, false);
      local5 = (TEnum) valueGeneric3;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 934307, RefRangeEnd = 934309, XrefRangeStart = 934300, XrefRangeEnd = 934307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<T, TEnum>(
      Nullable_Unboxed<T> from,
      ref T to,
      TEnum fromEnum,
      ref TEnum toEnum,
      Il2CppSystem.IDisposable disposable = null)
      where T : unmanaged
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = (System.IntPtr) &from;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
      System.IntPtr* numPtr2 = &ptr1;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) fromEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref fromEnum;
      *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
      System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toEnum);
      System.IntPtr* numPtr3 = &ptr2;
      *(System.IntPtr*) num3 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_T_TEnum_byref_TEnum_IDisposable_0<T, TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref T local3 = ref to;
      System.IntPtr objectPointer1 = ptr1;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer1, false, false);
      local3 = (T) valueGeneric1;
      ref TEnum local4 = ref toEnum;
      System.IntPtr objectPointer2 = ptr2;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(objectPointer2, false, false);
      local4 = (TEnum) valueGeneric2;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 934318, RefRangeEnd = 934320, XrefRangeStart = 934309, XrefRangeEnd = 934318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TEnum>(
      Handle from,
      ref System.IntPtr to,
      TEnum fromEnum,
      ref TEnum toEnum,
      Il2CppSystem.IDisposable disposable = null)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) fromEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref fromEnum;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toEnum);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Handle_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TEnum local3 = ref toEnum;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(objectPointer, false, false);
      local3 = (TEnum) valueGeneric;
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 934329, RefRangeEnd = 934334, XrefRangeStart = 934320, XrefRangeEnd = 934329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TEnum>(
      Utf8String from,
      ref System.IntPtr to,
      TEnum fromEnum,
      ref TEnum toEnum,
      Il2CppSystem.IDisposable disposable = null)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) fromEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref fromEnum;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toEnum);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Utf8String_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TEnum local3 = ref toEnum;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(objectPointer, false, false);
      local3 = (TEnum) valueGeneric;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 934345, RefRangeEnd = 934347, XrefRangeStart = 934334, XrefRangeEnd = 934345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TEnum>(
      Nullable_Unboxed<bool> from,
      ref int to,
      TEnum fromEnum,
      ref TEnum toEnum,
      Il2CppSystem.IDisposable disposable = null)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TEnum& local1;
      if (!typeof (TEnum).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEnum> local2 = (object) fromEnum;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref fromEnum;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toEnum);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) disposable);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_Nullable_Unboxed_1_Boolean_byref_Int32_TEnum_byref_TEnum_IDisposable_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TEnum local3 = ref toEnum;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEnum>(objectPointer, false, false);
      local3 = (TEnum) valueGeneric;
    }

    [CallerCount(0)]
    public static unsafe void Set<TFrom, TIntermediate>(ref TFrom from, ref System.IntPtr to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_TFrom_byref_IntPtr_0<TFrom, TIntermediate>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TFrom local = ref from;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFrom>(objectPointer, false, false);
      local = (TFrom) valueGeneric;
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 934363, RefRangeEnd = 934366, XrefRangeStart = 934347, XrefRangeEnd = 934363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TFrom, TIntermediate>(ref Il2CppSystem.Nullable<TFrom> from, ref System.IntPtr to)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) from);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_Nullable_1_TFrom_byref_IntPtr_0<TFrom, TIntermediate>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 934384, RefRangeEnd = 934387, XrefRangeStart = 934366, XrefRangeEnd = 934384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TFrom, TTo>(ref TFrom from, ref TTo to)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr1;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
      System.IntPtr* numPtr4 = &ptr2;
      *(System.IntPtr*) num = (System.IntPtr) numPtr4;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_TFrom_byref_TTo_0<TFrom, TTo>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TFrom local1 = ref from;
      System.IntPtr objectPointer1 = ptr1;
      // ISSUE: variable of the null type
      __Null valueGeneric1 = objectPointer1 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TFrom>(objectPointer1, false, false);
      local1 = (TFrom) valueGeneric1;
      ref TTo local2 = ref to;
      System.IntPtr objectPointer2 = ptr2;
      // ISSUE: variable of the null type
      __Null valueGeneric2 = objectPointer2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TTo>(objectPointer2, false, false);
      local2 = (TTo) valueGeneric2;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934387, XrefRangeEnd = 934394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TFrom, TIntermediate>(
      ref Il2CppArrayBase<TFrom> from,
      ref System.IntPtr to,
      out int arrayLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_Int32_0<TFrom, TIntermediate>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TFrom> local = ref from;
      System.IntPtr pointer = ptr;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TFrom>) il2CppArrayBase;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 934397, RefRangeEnd = 934398, XrefRangeStart = 934394, XrefRangeEnd = 934397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set<TFrom, TIntermediate>(
      ref Il2CppArrayBase<TFrom> from,
      ref System.IntPtr to,
      out uint arrayLength)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref to;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref arrayLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_UInt32_0<TFrom, TIntermediate>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppArrayBase<TFrom> local = ref from;
      System.IntPtr pointer = ptr;
      Il2CppArrayBase<> il2CppArrayBase = pointer == System.IntPtr.Zero ? (Il2CppArrayBase<>) null : new Il2CppArrayBase<>(pointer);
      local = (Il2CppArrayBase<TFrom>) il2CppArrayBase;
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Helper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Helper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public static void AddCallback(
      out System.IntPtr clientDataAddress,
      Il2CppSystem.Object clientData,
      Il2CppSystem.Delegate publicDelegate,
      Il2CppSystem.Delegate privateDelegate,
      params Il2CppSystem.Delegate[] structDelegates)
    {
      Helper.AddCallback(out clientDataAddress, clientData, publicDelegate, privateDelegate, new Il2CppReferenceArray<Il2CppSystem.Delegate>(structDelegates));
    }

    static Helper()
    {
      Il2CppClassPointerStore<Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (Helper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper>.NativeClassPtr);
      Helper.NativeFieldInfoPtr_s_Allocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_Allocations));
      Helper.NativeFieldInfoPtr_s_PinnedBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_PinnedBuffers));
      Helper.NativeFieldInfoPtr_s_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_Callbacks));
      Helper.NativeFieldInfoPtr_s_StaticCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_StaticCallbacks));
      Helper.NativeFieldInfoPtr_s_LastClientDataId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_LastClientDataId));
      Helper.NativeFieldInfoPtr_s_ClientDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (s_ClientDatas));
      Helper.NativeMethodInfoPtr_AddCallback_Internal_Static_Void_byref_IntPtr_Object_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664084);
      Helper.NativeMethodInfoPtr_RemoveCallback_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664085);
      Helper.NativeMethodInfoPtr_TryGetAndRemoveCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664086);
      Helper.NativeMethodInfoPtr_TryGetStructCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664087);
      Helper.NativeMethodInfoPtr_RemoveCallbackByNotificationId_Internal_Static_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664088);
      Helper.NativeMethodInfoPtr_AddStaticCallback_Internal_Static_Void_String_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664089);
      Helper.NativeMethodInfoPtr_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664090);
      Helper.NativeMethodInfoPtr_AssignNotificationIdToCallback_Internal_Static_Void_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664091);
      Helper.NativeMethodInfoPtr_AddClientData_Private_Static_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664092);
      Helper.NativeMethodInfoPtr_RemoveClientData_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664093);
      Helper.NativeMethodInfoPtr_GetClientData_Private_Static_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664094);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_IntPtr_byref_THandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664095);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Handle_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664096);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppStructArray_1_Byte_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664097);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_String_byref_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664098);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664099);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664100);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_ArraySegment_1_TArray_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664101);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_ArraySegment_1_T_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664102);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664103);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664104);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Nullable_Unboxed_1_DateTimeOffset_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664105);
      Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Int64_byref_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664106);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664107);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664108);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_ArraySegment_1_TArray_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664109);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664110);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664111);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664112);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664113);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Int64_byref_Nullable_Unboxed_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664114);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664115);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664116);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664117);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664118);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_ArraySegment_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664119);
      Helper.NativeMethodInfoPtr_GetHandle_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664120);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TFrom_byref_Il2CppArrayBase_1_TTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664121);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664122);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664123);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664124);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppStructArray_1_Byte_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664125);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664126);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664127);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_T_byref_T_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664128);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664129);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Int32_byref_Nullable_Unboxed_1_Boolean_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664130);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_TFrom_byref_Nullable_1_TFrom_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664131);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TFrom_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664132);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_Unboxed_1_IntPtr_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664133);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Utf8String_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664134);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664135);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664136);
      Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664137);
      Helper.NativeMethodInfoPtr_GetAllocationCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664138);
      Helper.NativeMethodInfoPtr_Copy_Internal_Static_Void_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664139);
      Helper.NativeMethodInfoPtr_Copy_Internal_Static_Void_ArraySegment_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664140);
      Helper.NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664141);
      Helper.NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_TDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664142);
      Helper.NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_IntPtr_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664143);
      Helper.NativeMethodInfoPtr_GetAnsiStringLength_Private_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664144);
      Helper.NativeMethodInfoPtr_GetAnsiStringLength_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664145);
      Helper.NativeMethodInfoPtr_GetDefault_Internal_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664146);
      Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664147);
      Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664148);
      Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664149);
      Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664150);
      Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664151);
      Helper.NativeMethodInfoPtr_AddAllocation_Internal_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664152);
      Helper.NativeMethodInfoPtr_AddAllocation_Internal_Static_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664153);
      Helper.NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664154);
      Helper.NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Int32_Il2CppArrayBase_1_T_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664155);
      Helper.NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664156);
      Helper.NativeMethodInfoPtr_RemoveAllocation_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664157);
      Helper.NativeMethodInfoPtr_TryGetAllocationCache_Private_Static_Boolean_IntPtr_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664158);
      Helper.NativeMethodInfoPtr_AddPinnedBuffer_Private_Static_IntPtr_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664159);
      Helper.NativeMethodInfoPtr_AddPinnedBuffer_Private_Static_IntPtr_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664160);
      Helper.NativeMethodInfoPtr_AddPinnedBuffer_Internal_Static_IntPtr_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664161);
      Helper.NativeMethodInfoPtr_RemovePinnedBuffer_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664162);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664163);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Object_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664164);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Utf8String_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664165);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Handle_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664166);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664167);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664168);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_ArraySegment_1_Byte_byref_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664169);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664170);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664171);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664172);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664173);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664174);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_DateTimeOffset_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664175);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664176);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_String_byref_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664177);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_T_byref_T_TEnum_byref_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664178);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_byref_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664179);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_T_TEnum_byref_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664180);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Handle_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664181);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Utf8String_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664182);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_Boolean_byref_Int32_TEnum_byref_TEnum_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664183);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664184);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Nullable_1_TFrom_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664185);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_TTo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664186);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664187);
      Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664188);
      Helper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper>.NativeClassPtr, 100664189);
    }

    public Helper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Dictionary<System.IntPtr, Helper.Allocation> s_Allocations
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_Allocations, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<System.IntPtr, Helper.Allocation>) null : new Dictionary<System.IntPtr, Helper.Allocation>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_Allocations, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Dictionary<System.IntPtr, Helper.PinnedBuffer> s_PinnedBuffers
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_PinnedBuffers, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<System.IntPtr, Helper.PinnedBuffer>) null : new Dictionary<System.IntPtr, Helper.PinnedBuffer>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_PinnedBuffers, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Dictionary<System.IntPtr, Helper.DelegateHolder> s_Callbacks
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_Callbacks, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<System.IntPtr, Helper.DelegateHolder>) null : new Dictionary<System.IntPtr, Helper.DelegateHolder>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_Callbacks, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Dictionary<string, Helper.DelegateHolder> s_StaticCallbacks
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_StaticCallbacks, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<string, Helper.DelegateHolder>) null : new Dictionary<string, Helper.DelegateHolder>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_StaticCallbacks, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe long s_LastClientDataId
    {
      get
      {
        long lastClientDataId;
        IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_LastClientDataId, (void*) &lastClientDataId);
        return lastClientDataId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_LastClientDataId, (void*) &value);
      }
    }

    public static unsafe Dictionary<System.IntPtr, Il2CppSystem.Object> s_ClientDatas
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Helper.NativeFieldInfoPtr_s_ClientDatas, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<System.IntPtr, Il2CppSystem.Object>) null : new Dictionary<System.IntPtr, Il2CppSystem.Object>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Helper.NativeFieldInfoPtr_s_ClientDatas, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Allocation : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Size_k__BackingField;
      private static readonly System.IntPtr NativeFieldInfoPtr__Cache_k__BackingField;
      private static readonly System.IntPtr NativeFieldInfoPtr__IsArrayItemAllocated_k__BackingField;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Size_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Cache_Public_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_Cache_Private_set_Void_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsArrayItemAllocated_Public_get_Nullable_Unboxed_1_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_IsArrayItemAllocated_Private_set_Void_Nullable_Unboxed_1_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_Nullable_Unboxed_1_Boolean_0;

      public unsafe int Size
      {
        [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_get_Size_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe Il2CppSystem.Object Cache
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_get_Cache_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_set_Cache_Private_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe Nullable_Unboxed<bool> IsArrayItemAllocated
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_get_IsArrayItemAllocated_Public_get_Nullable_Unboxed_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Nullable_Unboxed<bool>*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr_set_IsArrayItemAllocated_Private_set_Void_Nullable_Unboxed_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 927239, RefRangeEnd = 927242, XrefRangeStart = 927238, XrefRangeEnd = 927239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Allocation(int size, Il2CppSystem.Object cache, Nullable_Unboxed<bool> isArrayItemAllocated = default (Nullable_Unboxed<bool>))
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &size;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cache);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isArrayItemAllocated;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Helper.Allocation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_Nullable_Unboxed_1_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Allocation()
      {
        Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (Allocation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr);
        Helper.Allocation.NativeFieldInfoPtr__Size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, "<Size>k__BackingField");
        Helper.Allocation.NativeFieldInfoPtr__Cache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, "<Cache>k__BackingField");
        Helper.Allocation.NativeFieldInfoPtr__IsArrayItemAllocated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, "<IsArrayItemAllocated>k__BackingField");
        Helper.Allocation.NativeMethodInfoPtr_get_Size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100664191);
        Helper.Allocation.NativeMethodInfoPtr_set_Size_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100664192);
        Helper.Allocation.NativeMethodInfoPtr_get_Cache_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100664193);
        Helper.Allocation.NativeMethodInfoPtr_set_Cache_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100664194);
        Helper.Allocation.NativeMethodInfoPtr_get_IsArrayItemAllocated_Public_get_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100664195);
        Helper.Allocation.NativeMethodInfoPtr_set_IsArrayItemAllocated_Private_set_Void_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100664196);
        Helper.Allocation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_Nullable_Unboxed_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, 100664197);
      }

      public Allocation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Allocation()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Helper.Allocation>.NativeClassPtr, data));
      }

      public unsafe int _Size_k__BackingField
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__Size_k__BackingField));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__Size_k__BackingField)) = value;
        }
      }

      public unsafe Il2CppSystem.Object _Cache_k__BackingField
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__Cache_k__BackingField));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__Cache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Nullable_Unboxed<bool> _IsArrayItemAllocated_k__BackingField
      {
        get
        {
          return *(Nullable_Unboxed<bool>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__IsArrayItemAllocated_k__BackingField));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.Allocation.NativeFieldInfoPtr__IsArrayItemAllocated_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PinnedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Handle_k__BackingField;
      private static readonly System.IntPtr NativeFieldInfoPtr__RefCount_k__BackingField;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Handle_Public_get_GCHandle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_Handle_Private_set_Void_GCHandle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_RefCount_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_RefCount_Public_set_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GCHandle_0;
      [FieldOffset(0)]
      public Il2CppSystem.Runtime.InteropServices.GCHandle _Handle_k__BackingField;
      [FieldOffset(4)]
      public int _RefCount_k__BackingField;

      public unsafe Il2CppSystem.Runtime.InteropServices.GCHandle Handle
      {
        [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.PinnedBuffer.NativeMethodInfoPtr_get_Handle_Public_get_GCHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Il2CppSystem.Runtime.InteropServices.GCHandle*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.PinnedBuffer.NativeMethodInfoPtr_set_Handle_Private_set_Void_GCHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe int RefCount
      {
        [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.PinnedBuffer.NativeMethodInfoPtr_get_RefCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.PinnedBuffer.NativeMethodInfoPtr_set_RefCount_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 927242, RefRangeEnd = 927243, XrefRangeStart = 927242, XrefRangeEnd = 927242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PinnedBuffer(Il2CppSystem.Runtime.InteropServices.GCHandle handle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &handle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Helper.PinnedBuffer.NativeMethodInfoPtr__ctor_Public_Void_GCHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PinnedBuffer()
      {
        Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (PinnedBuffer));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr);
        Helper.PinnedBuffer.NativeFieldInfoPtr__Handle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, "<Handle>k__BackingField");
        Helper.PinnedBuffer.NativeFieldInfoPtr__RefCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, "<RefCount>k__BackingField");
        Helper.PinnedBuffer.NativeMethodInfoPtr_get_Handle_Public_get_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, 100664198);
        Helper.PinnedBuffer.NativeMethodInfoPtr_set_Handle_Private_set_Void_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, 100664199);
        Helper.PinnedBuffer.NativeMethodInfoPtr_get_RefCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, 100664200);
        Helper.PinnedBuffer.NativeMethodInfoPtr_set_RefCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, 100664201);
        Helper.PinnedBuffer.NativeMethodInfoPtr__ctor_Public_Void_GCHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, 100664202);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Helper.PinnedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class DelegateHolder : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__Public_k__BackingField;
      private static readonly System.IntPtr NativeFieldInfoPtr__Private_k__BackingField;
      private static readonly System.IntPtr NativeFieldInfoPtr__StructDelegates_k__BackingField;
      private static readonly System.IntPtr NativeFieldInfoPtr__NotificationId_k__BackingField;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Public_Public_get_Delegate_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_Public_Private_set_Void_Delegate_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Private_Public_get_Delegate_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_Private_Private_set_Void_Delegate_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_StructDelegates_Public_get_Il2CppReferenceArray_1_Delegate_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_StructDelegates_Private_set_Void_Il2CppReferenceArray_1_Delegate_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_NotificationId_Public_get_Nullable_Unboxed_1_UInt64_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_NotificationId_Public_set_Void_Nullable_Unboxed_1_UInt64_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0;

      public unsafe Il2CppSystem.Delegate Public
      {
        [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_Public_Public_get_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : new Il2CppSystem.Delegate(pointer);
        }
        [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_Public_Private_set_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe Il2CppSystem.Delegate Private
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_Private_Public_get_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : new Il2CppSystem.Delegate(pointer);
        }
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_Private_Private_set_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe Il2CppReferenceArray<Il2CppSystem.Delegate> StructDelegates
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_StructDelegates_Public_get_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr nativeObject = num;
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Delegate>) null : new Il2CppReferenceArray<Il2CppSystem.Delegate>(nativeObject);
        }
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_StructDelegates_Private_set_Void_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      public unsafe Nullable_Unboxed<ulong> NotificationId
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_get_NotificationId_Public_get_Nullable_Unboxed_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Nullable_Unboxed<ulong>*) IL2CPP.il2cpp_object_unbox(num);
        }
        [CallerCount(4), CachedScanResults(RefRangeStart = 632378, RefRangeEnd = 632382, XrefRangeStart = 632378, XrefRangeEnd = 632382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &value;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr_set_NotificationId_Public_set_Void_Nullable_Unboxed_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 455756, RefRangeEnd = 455761, XrefRangeStart = 455756, XrefRangeEnd = 455761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DelegateHolder(
        Il2CppSystem.Delegate publicDelegate,
        Il2CppSystem.Delegate privateDelegate,
        [Optional] Il2CppReferenceArray<Il2CppSystem.Delegate> structDelegates)
      {
        if (structDelegates == null)
          structDelegates = new Il2CppReferenceArray<Il2CppSystem.Delegate>(0L);
        // ISSUE: explicit constructor call
        this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr));
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) publicDelegate);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) privateDelegate);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) structDelegates);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Helper.DelegateHolder.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public DelegateHolder(
        Il2CppSystem.Delegate publicDelegate,
        Il2CppSystem.Delegate privateDelegate,
        params Il2CppSystem.Delegate[] structDelegates)
        : this(publicDelegate, privateDelegate, new Il2CppReferenceArray<Il2CppSystem.Delegate>(structDelegates))
      {
      }

      static DelegateHolder()
      {
        Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, nameof (DelegateHolder));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr);
        Helper.DelegateHolder.NativeFieldInfoPtr__Public_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<Public>k__BackingField");
        Helper.DelegateHolder.NativeFieldInfoPtr__Private_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<Private>k__BackingField");
        Helper.DelegateHolder.NativeFieldInfoPtr__StructDelegates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<StructDelegates>k__BackingField");
        Helper.DelegateHolder.NativeFieldInfoPtr__NotificationId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, "<NotificationId>k__BackingField");
        Helper.DelegateHolder.NativeMethodInfoPtr_get_Public_Public_get_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664203);
        Helper.DelegateHolder.NativeMethodInfoPtr_set_Public_Private_set_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664204);
        Helper.DelegateHolder.NativeMethodInfoPtr_get_Private_Public_get_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664205);
        Helper.DelegateHolder.NativeMethodInfoPtr_set_Private_Private_set_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664206);
        Helper.DelegateHolder.NativeMethodInfoPtr_get_StructDelegates_Public_get_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664207);
        Helper.DelegateHolder.NativeMethodInfoPtr_set_StructDelegates_Private_set_Void_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664208);
        Helper.DelegateHolder.NativeMethodInfoPtr_get_NotificationId_Public_get_Nullable_Unboxed_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664209);
        Helper.DelegateHolder.NativeMethodInfoPtr_set_NotificationId_Public_set_Void_Nullable_Unboxed_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664210);
        Helper.DelegateHolder.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.DelegateHolder>.NativeClassPtr, 100664211);
      }

      public DelegateHolder(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Delegate _Public_k__BackingField
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Public_k__BackingField));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : new Il2CppSystem.Delegate(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Public_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Delegate _Private_k__BackingField
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Private_k__BackingField));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Delegate) null : new Il2CppSystem.Delegate(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__Private_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<Il2CppSystem.Delegate> _StructDelegates_k__BackingField
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__StructDelegates_k__BackingField));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Delegate>) null : new Il2CppReferenceArray<Il2CppSystem.Delegate>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__StructDelegates_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Nullable_Unboxed<ulong> _NotificationId_k__BackingField
      {
        get
        {
          return *(Nullable_Unboxed<ulong>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__NotificationId_k__BackingField));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.DelegateHolder.NativeFieldInfoPtr__NotificationId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("Epic.OnlineServices.Helper/<>c__3`3")]
    [Serializable]
    public sealed class __c__3<TCallbackInfoInternal, TCallback, TCallbackInfo> : Il2CppSystem.Object
      where TCallback : class
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryGetStructCallback_b__3_0_Internal_Boolean_Delegate_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__3()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927243, XrefRangeEnd = 927264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _TryGetStructCallback_b__3_0(Il2CppSystem.Delegate structDelegate)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) structDelegate);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeMethodInfoPtr__TryGetStructCallback_b__3_0_Internal_Boolean_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__3()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, "<>c__3`3"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfoInternal>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>>.NativeClassPtr);
        Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>>.NativeClassPtr, "<>9");
        Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>>.NativeClassPtr, "<>9__3_0");
        Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>>.NativeClassPtr, 100664213);
        Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeMethodInfoPtr__TryGetStructCallback_b__3_0_Internal_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>>.NativeClassPtr, 100664214);
      }

      public __c__3(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo> __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>) null : new Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Il2CppSystem.Delegate, bool> __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Delegate, bool>) null : new Il2CppSystem.Func<Il2CppSystem.Delegate, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Helper.__c__3<TCallbackInfoInternal, TCallback, TCallbackInfo>.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("Epic.OnlineServices.Helper/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_notificationId;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RemoveCallbackByNotificationId_b__0_Internal_Boolean_KeyValuePair_2_IntPtr_DelegateHolder_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Helper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927264, XrefRangeEnd = 927267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _RemoveCallbackByNotificationId_b__0(
        KeyValuePair<System.IntPtr, Helper.DelegateHolder> pair)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) pair));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.__c__DisplayClass4_0.NativeMethodInfoPtr__RemoveCallbackByNotificationId_b__0_Internal_Boolean_KeyValuePair_2_IntPtr_DelegateHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<Helper.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.__c__DisplayClass4_0>.NativeClassPtr);
        Helper.__c__DisplayClass4_0.NativeFieldInfoPtr_notificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c__DisplayClass4_0>.NativeClassPtr, nameof (notificationId));
        Helper.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__DisplayClass4_0>.NativeClassPtr, 100664215);
        Helper.__c__DisplayClass4_0.NativeMethodInfoPtr__RemoveCallbackByNotificationId_b__0_Internal_Boolean_KeyValuePair_2_IntPtr_DelegateHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c__DisplayClass4_0>.NativeClassPtr, 100664216);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ulong notificationId
      {
        get
        {
          return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.__c__DisplayClass4_0.NativeFieldInfoPtr_notificationId));
        }
        [param: In] set
        {
          *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Helper.__c__DisplayClass4_0.NativeFieldInfoPtr_notificationId)) = value;
        }
      }
    }

    [ObfuscatedName("Epic.OnlineServices.Helper/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__63_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetAllocationCount_b__63_0_Internal_Int32_Int32_KeyValuePair_Unboxed_2_IntPtr_PinnedBuffer_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Helper.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Helper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927267, XrefRangeEnd = 927268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _GetAllocationCount_b__63_0(
        int acc,
        KeyValuePair_Unboxed<System.IntPtr, Helper.PinnedBuffer> x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &acc;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Helper.__c.NativeMethodInfoPtr__GetAllocationCount_b__63_0_Internal_Int32_Int32_KeyValuePair_Unboxed_2_IntPtr_PinnedBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<Helper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Helper>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Helper.__c>.NativeClassPtr);
        Helper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c>.NativeClassPtr, "<>9");
        Helper.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Helper.__c>.NativeClassPtr, "<>9__63_0");
        Helper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c>.NativeClassPtr, 100664218);
        Helper.__c.NativeMethodInfoPtr__GetAllocationCount_b__63_0_Internal_Int32_Int32_KeyValuePair_Unboxed_2_IntPtr_PinnedBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Helper.__c>.NativeClassPtr, 100664219);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe Helper.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Helper.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Helper.__c) null : new Helper.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Helper.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<int, KeyValuePair_Unboxed<System.IntPtr, Helper.PinnedBuffer>, int> __9__63_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Helper.__c.NativeFieldInfoPtr___9__63_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, KeyValuePair_Unboxed<System.IntPtr, Helper.PinnedBuffer>, int>) null : new Il2CppSystem.Func<int, KeyValuePair_Unboxed<System.IntPtr, Helper.PinnedBuffer>, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Helper.__c.NativeFieldInfoPtr___9__63_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_TryGetAndRemoveCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0<TCallbackInfoInternal, TCallback, TCallbackInfo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetAndRemoveCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfoInternal>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetStructCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0<TCallbackInfoInternal, TCallback, TCallbackInfo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetStructCallback_Internal_Static_Boolean_byref_TCallbackInfoInternal_byref_TCallback_byref_TCallbackInfo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfoInternal>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackInfo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0<TCallback>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_TryGetStaticCallback_Internal_Static_Boolean_String_byref_TCallback_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallback>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Convert_Private_Static_Void_IntPtr_byref_THandle_0<THandle>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_IntPtr_byref_THandle_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<THandle>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0<TArray>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0<TArray>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Convert_Private_Static_Void_ArraySegment_1_TArray_byref_Int32_0<TArray>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_ArraySegment_1_TArray_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Convert_Private_Static_Void_ArraySegment_1_T_byref_UInt32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Convert_Private_Static_Void_ArraySegment_1_T_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0<TArray>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0<TArray>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TArray_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_ArraySegment_1_TArray_byref_UInt32_0<TArray>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_ArraySegment_1_TArray_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArray>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_TTo_0<TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TTo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_byref_TFrom_byref_TTo_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_Boolean_0<TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_Boolean_0<TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0<TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0<TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetHandle_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0<THandle>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_GetHandle_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<THandle>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_Il2CppArrayBase_1_TFrom_byref_Il2CppArrayBase_1_TTo_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Il2CppArrayBase_1_TFrom_byref_Il2CppArrayBase_1_TTo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Il2CppArrayBase_1_TTo_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0<TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_T_byref_T_TEnum_TEnum_0<T, TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_T_byref_T_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_TEnum_0<TFrom, TTo, TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_Int32_byref_Nullable_Unboxed_1_Boolean_TEnum_TEnum_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_Int32_byref_Nullable_Unboxed_1_Boolean_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_TFrom_byref_Nullable_1_TFrom_TEnum_TEnum_0<TFrom, TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_TFrom_byref_Nullable_1_TFrom_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_TFrom_TEnum_TEnum_0<TFrom, TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TFrom_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Nullable_Unboxed_1_IntPtr_TEnum_TEnum_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_Unboxed_1_IntPtr_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Utf8String_TEnum_TEnum_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Utf8String_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_TTo_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_TTo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_IntPtr_byref_Nullable_1_TTo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Get_Internal_Static_Void_byref_TFrom_byref_TTo_byref_IntPtr_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Get_Internal_Static_Void_byref_TFrom_byref_TTo_byref_IntPtr_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Dispose_Internal_Static_Void_byref_TDisposable_0<TDisposable>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_TDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDisposable>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Dispose_Internal_Static_Void_byref_IntPtr_TEnum_TEnum_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Dispose_Internal_Static_Void_byref_IntPtr_TEnum_TEnum_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetDefault_Internal_Static_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_GetDefault_Internal_Static_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_Nullable_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Nullable_1_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0<THandle>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_THandle_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<THandle>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_GetAllocation_Private_Static_Void_IntPtr_byref_Il2CppArrayBase_1_T_Int32_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddAllocation_Private_Static_IntPtr_Int32_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Int32_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddAllocation_Private_Static_IntPtr_Int32_Il2CppArrayBase_1_T_Nullable_Unboxed_1_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Int32_Il2CppArrayBase_1_T_Nullable_Unboxed_1_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AddAllocation_Private_Static_IntPtr_Il2CppArrayBase_1_T_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_AddAllocation_Private_Static_IntPtr_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_T_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_IntPtr_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_IntPtr_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_UInt32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_Boolean_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_UInt32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Il2CppArrayBase_1_T_byref_IntPtr_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_T_byref_T_TEnum_byref_TEnum_IDisposable_0<T, TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_T_byref_T_TEnum_byref_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_byref_TEnum_IDisposable_0<TFrom, TEnum, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_TTo_TEnum_byref_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_T_TEnum_byref_TEnum_IDisposable_0<T, TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_T_byref_T_TEnum_byref_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Handle_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Handle_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Utf8String_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Utf8String_byref_IntPtr_TEnum_byref_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_Nullable_Unboxed_1_Boolean_byref_Int32_TEnum_byref_TEnum_IDisposable_0<TEnum>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_Nullable_Unboxed_1_Boolean_byref_Int32_TEnum_byref_TEnum_IDisposable_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_TFrom_byref_IntPtr_0<TFrom, TIntermediate>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_IntPtr_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TIntermediate>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_Nullable_1_TFrom_byref_IntPtr_0<TFrom, TIntermediate>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Nullable_1_TFrom_byref_IntPtr_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TIntermediate>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_TFrom_byref_TTo_0<TFrom, TTo>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_TFrom_byref_TTo_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTo>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_Int32_0<TFrom, TIntermediate>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_Int32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TIntermediate>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_UInt32_0<TFrom, TIntermediate>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Helper.NativeMethodInfoPtr_Set_Internal_Static_Void_byref_Il2CppArrayBase_1_TFrom_byref_IntPtr_byref_UInt32_0, Il2CppClassPointerStore<Helper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFrom>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TIntermediate>.NativeClassPtr))
      }))));
    }
  }
}
