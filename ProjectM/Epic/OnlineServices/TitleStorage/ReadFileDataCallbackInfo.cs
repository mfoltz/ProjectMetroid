﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.ReadFileDataCallbackInfo
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.TitleStorage
{
  public sealed class ReadFileDataCallbackInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Filename_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TotalFileSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsLastChunk_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DataChunk_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Filename_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalFileSizeBytes_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TotalFileSizeBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLastChunk_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLastChunk_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DataChunk_Public_get_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DataChunk_Public_set_Void_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_ReadFileDataCallbackInfoInternal_0;

    public virtual unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Filename
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_Filename_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint TotalFileSizeBytes
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_TotalFileSizeBytes_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_TotalFileSizeBytes_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsLastChunk
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_IsLastChunk_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_IsLastChunk_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.ArraySegment<byte> DataChunk
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 29043, RefRangeEnd = 29047, XrefRangeStart = 29043, XrefRangeEnd = 29047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_DataChunk_Public_get_ArraySegment_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.ArraySegment<byte>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938932, XrefRangeEnd = 938933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_DataChunk_Public_set_Void_ArraySegment_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Nullable_Unboxed<Result> GetResultCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<Result>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 938954, RefRangeEnd = 938955, XrefRangeStart = 938933, XrefRangeEnd = 938954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref ReadFileDataCallbackInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReadFileDataCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_ReadFileDataCallbackInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReadFileDataCallbackInfo()
    {
      Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.TitleStorage", nameof (ReadFileDataCallbackInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr);
      ReadFileDataCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, "<ClientData>k__BackingField");
      ReadFileDataCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, "<LocalUserId>k__BackingField");
      ReadFileDataCallbackInfo.NativeFieldInfoPtr__Filename_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, "<Filename>k__BackingField");
      ReadFileDataCallbackInfo.NativeFieldInfoPtr__TotalFileSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, "<TotalFileSizeBytes>k__BackingField");
      ReadFileDataCallbackInfo.NativeFieldInfoPtr__IsLastChunk_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, "<IsLastChunk>k__BackingField");
      ReadFileDataCallbackInfo.NativeFieldInfoPtr__DataChunk_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, "<DataChunk>k__BackingField");
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665620);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665621);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665622);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665623);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_Filename_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665624);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665625);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_TotalFileSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665626);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_TotalFileSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665627);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_IsLastChunk_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665628);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_IsLastChunk_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665629);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_get_DataChunk_Public_get_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665630);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_set_DataChunk_Public_set_Void_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665631);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_Unboxed_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665632);
      ReadFileDataCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_ReadFileDataCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, 100665633);
    }

    public ReadFileDataCallbackInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ReadFileDataCallbackInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadFileDataCallbackInfo>.NativeClassPtr, data));
    }

    public unsafe Il2CppSystem.Object _ClientData_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProductUserId _LocalUserId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _Filename_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__Filename_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__Filename_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe uint _TotalFileSizeBytes_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__TotalFileSizeBytes_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__TotalFileSizeBytes_k__BackingField)) = value;
      }
    }

    public unsafe bool _IsLastChunk_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__IsLastChunk_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__IsLastChunk_k__BackingField)) = value;
      }
    }

    public Il2CppSystem.ArraySegment<byte> _DataChunk_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__DataChunk_k__BackingField);
        return new Il2CppSystem.ArraySegment<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ArraySegment<byte>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReadFileDataCallbackInfo.NativeFieldInfoPtr__DataChunk_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ArraySegment<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
