// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventParamPairParamValue
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
  public sealed class LogEventParamPairParamValue : Il2CppSystem.ValueType
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
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamValueType_Public_get_AntiCheatCommonEventParamType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamValueType_Private_set_Void_AntiCheatCommonEventParamType_0;
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
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Vec3f_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Quat_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_LogEventParamPairParamValueInternal_0;

    public unsafe AntiCheatCommonEventParamType ParamValueType
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_ParamValueType_Public_get_AntiCheatCommonEventParamType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonEventParamType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_ParamValueType_Private_set_Void_AntiCheatCommonEventParamType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<System.IntPtr> ClientHandle
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969485, XrefRangeEnd = 969491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_Unboxed_1_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<System.IntPtr>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969491, XrefRangeEnd = 969497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_Unboxed_1_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String String
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 969503, RefRangeEnd = 969504, XrefRangeStart = 969497, XrefRangeEnd = 969503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_String_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 969510, RefRangeEnd = 969513, XrefRangeStart = 969504, XrefRangeEnd = 969510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_String_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<uint> UInt32
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 969519, RefRangeEnd = 969520, XrefRangeStart = 969513, XrefRangeEnd = 969519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_Unboxed_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<uint>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969526, RefRangeEnd = 969528, XrefRangeStart = 969520, XrefRangeEnd = 969526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_Unboxed_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<int> Int32
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 969534, RefRangeEnd = 969535, XrefRangeStart = 969528, XrefRangeEnd = 969534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_Unboxed_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<int>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 969541, RefRangeEnd = 969543, XrefRangeStart = 969535, XrefRangeEnd = 969541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_Unboxed_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<ulong> UInt64
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969543, XrefRangeEnd = 969549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_Unboxed_1_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<ulong>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969549, XrefRangeEnd = 969555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_Unboxed_1_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<long> Int64
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969555, XrefRangeEnd = 969561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_Unboxed_1_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<long>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969561, XrefRangeEnd = 969567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_Unboxed_1_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Vec3f Vec3f
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 969573, RefRangeEnd = 969574, XrefRangeStart = 969567, XrefRangeEnd = 969573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Vec3f*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969574, XrefRangeEnd = 969580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Quat Quat
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969580, XrefRangeEnd = 969586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Quat*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969586, XrefRangeEnd = 969592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969592, XrefRangeEnd = 969601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(System.IntPtr value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969601, XrefRangeEnd = 969602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(Epic.OnlineServices.Utf8String value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969602, XrefRangeEnd = 969604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(string value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969604, XrefRangeEnd = 969608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(uint value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969608, XrefRangeEnd = 969612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(int value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969612, XrefRangeEnd = 969621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969621, XrefRangeEnd = 969630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(long value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969630, XrefRangeEnd = 969636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(Vec3f value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Vec3f_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969636, XrefRangeEnd = 969642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator LogEventParamPairParamValue(Quat value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Quat_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LogEventParamPairParamValue(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 969708, RefRangeEnd = 969709, XrefRangeStart = 969642, XrefRangeEnd = 969708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref LogEventParamPairParamValueInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_Set_Internal_Void_byref_LogEventParamPairParamValueInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LogEventParamPairParamValue()
    {
      Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventParamPairParamValue));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr);
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_ParamValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_ParamValueType));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_ClientHandle));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_String));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_UInt32));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Int32));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_UInt64));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Int64));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_Vec3f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Vec3f));
      LogEventParamPairParamValue.NativeFieldInfoPtr_m_Quat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Quat));
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_ParamValueType_Public_get_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673947);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_ParamValueType_Private_set_Void_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673948);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_Unboxed_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673949);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_Unboxed_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673950);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_String_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673951);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_String_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673952);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_Unboxed_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673953);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_Unboxed_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673954);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673955);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673956);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_Unboxed_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673957);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_Unboxed_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673958);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673959);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_Unboxed_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673960);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673961);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673962);
      LogEventParamPairParamValue.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673963);
      LogEventParamPairParamValue.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673964);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673965);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673966);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673967);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673968);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673969);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673970);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673971);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673972);
      LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673973);
      LogEventParamPairParamValue.NativeMethodInfoPtr_Set_Internal_Void_byref_LogEventParamPairParamValueInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100673974);
    }

    public LogEventParamPairParamValue(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LogEventParamPairParamValue()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, data));
    }

    public unsafe AntiCheatCommonEventParamType m_ParamValueType
    {
      get
      {
        return *(AntiCheatCommonEventParamType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ParamValueType));
      }
      [param: In] set
      {
        *(AntiCheatCommonEventParamType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ParamValueType)) = value;
      }
    }

    public unsafe Nullable_Unboxed<System.IntPtr> m_ClientHandle
    {
      get
      {
        return *(Nullable_Unboxed<System.IntPtr>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ClientHandle));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ClientHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<System.IntPtr>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String m_String
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_String));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_String), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<uint> m_UInt32
    {
      get
      {
        return *(Nullable_Unboxed<uint>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt32));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt32), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<uint>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> m_Int32
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int32));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int32), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<ulong> m_UInt64
    {
      get
      {
        return *(Nullable_Unboxed<ulong>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt64));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt64), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<long> m_Int64
    {
      get
      {
        return *(Nullable_Unboxed<long>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int64));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int64), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<long>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Vec3f m_Vec3f
    {
      get
      {
        return *(Vec3f*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Vec3f));
      }
      [param: In] set
      {
        *(Vec3f*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Vec3f)) = value;
      }
    }

    public unsafe Quat m_Quat
    {
      get
      {
        return *(Quat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Quat));
      }
      [param: In] set
      {
        *(Quat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Quat)) = value;
      }
    }
  }
}
