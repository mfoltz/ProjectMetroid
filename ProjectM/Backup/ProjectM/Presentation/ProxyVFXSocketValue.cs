// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyVFXSocketValue
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ProxyVFXSocketValue
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Int4Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float1Value_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float1Value_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float2Value_Public_get_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float2Value_Public_set_Void_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float3Value_Public_get_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float3Value_Public_set_Void_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float4Value_Public_get_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float4Value_Public_set_Void_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int1Value_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int1Value_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int2Value_Public_get_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int2Value_Public_set_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BoolValue_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_BoolValue_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromStruct_Public_Static_ProxyVFXSocketValue_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AsUnion_Public_Union_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float3_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int2_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int4_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_int4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ProxyVFXSocketValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Boolean_0;
    [FieldOffset(0)]
    public int4 Int4Value;

    public unsafe float Float1Value
    {
      [CallerCount(20), CachedScanResults(RefRangeStart = 637509, RefRangeEnd = 637529, XrefRangeStart = 637509, XrefRangeEnd = 637529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float1Value_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111935, XrefRangeEnd = 1111936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float1Value_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float2 Float2Value
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 637553, RefRangeEnd = 637555, XrefRangeStart = 637553, XrefRangeEnd = 637555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float2Value_Public_get_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111936, XrefRangeEnd = 1111937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float2Value_Public_set_Void_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float3 Float3Value
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 637559, RefRangeEnd = 637564, XrefRangeStart = 637559, XrefRangeEnd = 637564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float3Value_Public_get_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float3*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111937, XrefRangeEnd = 1111938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float3Value_Public_set_Void_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float4 Float4Value
    {
      [CallerCount(46), CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float4Value_Public_get_float4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float4*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111938, XrefRangeEnd = 1111939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float4Value_Public_set_Void_float4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int Int1Value
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_get_Int1Value_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111939, XrefRangeEnd = 1111940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_set_Int1Value_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int2 Int2Value
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 637591, RefRangeEnd = 637593, XrefRangeStart = 637591, XrefRangeEnd = 637593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_get_Int2Value_Public_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_set_Int2Value_Public_set_Void_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool BoolValue
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_get_BoolValue_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111940, XrefRangeEnd = 1111941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_set_BoolValue_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProxyVFXSocketValue(int4 int4Value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &int4Value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr__ctor_Public_Void_int4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe ProxyVFXSocketValue FromStruct<T>(T value)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.MethodInfoStoreGeneric_FromStruct_Public_Static_ProxyVFXSocketValue_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(46)]
    [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProxyVFXSocketValue.Union AsUnion()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_AsUnion_Public_Union_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue.Union*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 254814, RefRangeEnd = 254815, XrefRangeStart = 254814, XrefRangeEnd = 254815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 637509, RefRangeEnd = 637529, XrefRangeStart = 637509, XrefRangeEnd = 637529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator float(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111941, XrefRangeEnd = 1111942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(float a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 637553, RefRangeEnd = 637555, XrefRangeStart = 637553, XrefRangeEnd = 637555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator float2(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111942, XrefRangeEnd = 1111943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(float2 a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 637559, RefRangeEnd = 637564, XrefRangeStart = 637559, XrefRangeEnd = 637564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator float3(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111943, XrefRangeEnd = 1111944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(float3 a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(46)]
    [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator float4(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float4*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111944, XrefRangeEnd = 1111945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(float4 a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator int(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111945, XrefRangeEnd = 1111946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(int a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 637591, RefRangeEnd = 637593, XrefRangeStart = 637591, XrefRangeEnd = 637593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator int2(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_int2_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(int2 a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(46)]
    [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator int4(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_int4_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int4*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(int4 a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_int4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator bool(ProxyVFXSocketValue a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ProxyVFXSocketValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111946, XrefRangeEnd = 1111947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator ProxyVFXSocketValue(bool a)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &a;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ProxyVFXSocketValue()
    {
      Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyVFXSocketValue));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr);
      ProxyVFXSocketValue.NativeFieldInfoPtr_Int4Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, nameof (Int4Value));
      ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float1Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688015);
      ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float1Value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688016);
      ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float2Value_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688017);
      ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float2Value_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688018);
      ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float3Value_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688019);
      ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float3Value_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688020);
      ProxyVFXSocketValue.NativeMethodInfoPtr_get_Float4Value_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688021);
      ProxyVFXSocketValue.NativeMethodInfoPtr_set_Float4Value_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688022);
      ProxyVFXSocketValue.NativeMethodInfoPtr_get_Int1Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688023);
      ProxyVFXSocketValue.NativeMethodInfoPtr_set_Int1Value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688024);
      ProxyVFXSocketValue.NativeMethodInfoPtr_get_Int2Value_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688025);
      ProxyVFXSocketValue.NativeMethodInfoPtr_set_Int2Value_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688026);
      ProxyVFXSocketValue.NativeMethodInfoPtr_get_BoolValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688027);
      ProxyVFXSocketValue.NativeMethodInfoPtr_set_BoolValue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688028);
      ProxyVFXSocketValue.NativeMethodInfoPtr__ctor_Public_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688029);
      ProxyVFXSocketValue.NativeMethodInfoPtr_FromStruct_Public_Static_ProxyVFXSocketValue_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688030);
      ProxyVFXSocketValue.NativeMethodInfoPtr_AsUnion_Public_Union_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688031);
      ProxyVFXSocketValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688032);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688033);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688034);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688035);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688036);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_float3_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688037);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688038);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688039);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688040);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688041);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688042);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_int2_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688043);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688044);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_int4_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688045);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688046);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688047);
      ProxyVFXSocketValue.NativeMethodInfoPtr_op_Implicit_Public_Static_ProxyVFXSocketValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, 100688048);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Union
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Float1Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Float2Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Float3Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Float4Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Int1Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Int2Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_Int4Value;
      private static readonly System.IntPtr NativeFieldInfoPtr_BoolValue;
      private static readonly System.IntPtr NativeMethodInfoPtr_AsSocketDefault_Public_ProxyVFXSocketValue_0;
      [FieldOffset(0)]
      public float Float1Value;
      [FieldOffset(0)]
      public float2 Float2Value;
      [FieldOffset(0)]
      public float3 Float3Value;
      [FieldOffset(0)]
      public float4 Float4Value;
      [FieldOffset(0)]
      public int Int1Value;
      [FieldOffset(0)]
      public int2 Int2Value;
      [FieldOffset(0)]
      public int4 Int4Value;
      [FieldOffset(0)]
      public bool BoolValue;

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ProxyVFXSocketValue AsSocketDefault()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXSocketValue.Union.NativeMethodInfoPtr_AsSocketDefault_Public_ProxyVFXSocketValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ProxyVFXSocketValue*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Union()
      {
        Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr, nameof (Union));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr);
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_Float1Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (Float1Value));
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_Float2Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (Float2Value));
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_Float3Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (Float3Value));
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_Float4Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (Float4Value));
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_Int1Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (Int1Value));
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_Int2Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (Int2Value));
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_Int4Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (Int4Value));
        ProxyVFXSocketValue.Union.NativeFieldInfoPtr_BoolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, nameof (BoolValue));
        ProxyVFXSocketValue.Union.NativeMethodInfoPtr_AsSocketDefault_Public_ProxyVFXSocketValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, 100688049);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProxyVFXSocketValue.Union>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_FromStruct_Public_Static_ProxyVFXSocketValue_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ProxyVFXSocketValue.NativeMethodInfoPtr_FromStruct_Public_Static_ProxyVFXSocketValue_T_0, Il2CppClassPointerStore<ProxyVFXSocketValue>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
