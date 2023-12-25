// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventParamPairParamValueInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogEventParamPairParamValueInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamValueType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_String;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UInt32;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Int32;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UInt64;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Int64;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Vec3f;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Quat;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_Unboxed_1_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_Unboxed_1_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_String_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_String_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_Unboxed_1_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_Unboxed_1_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int32_Public_get_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_Unboxed_1_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_Unboxed_1_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int64_Public_get_Nullable_Unboxed_1_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_Unboxed_1_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Quat_Public_get_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventParamPairParamValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventParamPairParamValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogEventParamPairParamValue_0;
    [FieldOffset(0)]
    public AntiCheatCommonEventParamType m_ParamValueType;
    [FieldOffset(8)]
    public System.IntPtr m_ClientHandle;
    [FieldOffset(8)]
    public System.IntPtr m_String;
    [FieldOffset(8)]
    public uint m_UInt32;
    [FieldOffset(8)]
    public int m_Int32;
    [FieldOffset(8)]
    public ulong m_UInt64;
    [FieldOffset(8)]
    public long m_Int64;
    [FieldOffset(8)]
    public Vec3fInternal m_Vec3f;
    [FieldOffset(8)]
    public QuatInternal m_Quat;

    public unsafe Nullable_Unboxed<System.IntPtr> ClientHandle
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969709, XrefRangeEnd = 969715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_Unboxed_1_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<System.IntPtr>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969724, RefRangeEnd = 969726, XrefRangeStart = 969715, XrefRangeEnd = 969724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_Unboxed_1_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String String
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 969732, RefRangeEnd = 969733, XrefRangeStart = 969726, XrefRangeEnd = 969732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_String_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969742, RefRangeEnd = 969744, XrefRangeStart = 969733, XrefRangeEnd = 969742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_String_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<uint> UInt32
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 969750, RefRangeEnd = 969751, XrefRangeStart = 969744, XrefRangeEnd = 969750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_Unboxed_1_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<uint>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969760, RefRangeEnd = 969762, XrefRangeStart = 969751, XrefRangeEnd = 969760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_Unboxed_1_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<int> Int32
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 969768, RefRangeEnd = 969769, XrefRangeStart = 969762, XrefRangeEnd = 969768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_Unboxed_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<int>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969778, RefRangeEnd = 969780, XrefRangeStart = 969769, XrefRangeEnd = 969778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_Unboxed_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<ulong> UInt64
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969780, XrefRangeEnd = 969786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_Unboxed_1_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<ulong>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969795, RefRangeEnd = 969797, XrefRangeStart = 969786, XrefRangeEnd = 969795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_Unboxed_1_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<long> Int64
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969797, XrefRangeEnd = 969803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_Unboxed_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<long>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969812, RefRangeEnd = 969814, XrefRangeStart = 969803, XrefRangeEnd = 969812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_Unboxed_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Vec3f Vec3f
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969814, XrefRangeEnd = 969820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vec3f*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969829, RefRangeEnd = 969831, XrefRangeStart = 969820, XrefRangeEnd = 969829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Quat Quat
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969831, XrefRangeEnd = 969837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Quat*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969846, RefRangeEnd = 969848, XrefRangeStart = 969837, XrefRangeEnd = 969846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969848, XrefRangeEnd = 969884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LogEventParamPairParamValue other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969884, XrefRangeEnd = 969958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LogEventParamPairParamValue> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969958, XrefRangeEnd = 969972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969972, XrefRangeEnd = 969973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LogEventParamPairParamValue output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LogEventParamPairParamValue local = ref output;
      System.IntPtr pointer = zero;
      LogEventParamPairParamValue paramPairParamValue = pointer == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : new LogEventParamPairParamValue(pointer);
      local = paramPairParamValue;
    }

    static LogEventParamPairParamValueInternal()
    {
      Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventParamPairParamValueInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr);
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_ParamValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_ParamValueType));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_ClientHandle));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_String));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_UInt32));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Int32));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_UInt64));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Int64));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Vec3f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Vec3f));
      LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Quat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Quat));
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_Unboxed_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673975);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_Unboxed_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673976);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_String_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673977);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_String_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673978);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_Unboxed_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673979);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_Unboxed_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673980);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673981);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673982);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_Unboxed_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673983);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_Unboxed_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673984);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673985);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673986);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673987);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673988);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673989);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673990);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673991);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673992);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673993);
      LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100673994);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
