// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.HttpService.HttpServiceUtils
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network.HttpService
{
  public static class HttpServiceUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Serializer;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SendFormatting_Public_Static_get_Formatting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SendFormatting_Public_Static_set_Void_Formatting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryReadObject_Public_Static_Boolean_Stream_Encoding_byref_T_byref_Exception_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadObject_Public_Static_T_Stream_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadObject_Private_Static_T_Stream_Encoding_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadObject_Public_Static_T_HttpListenerContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_Void_Stream_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ObjectResponse_Public_Static_Void_HttpListenerContext_T_0;

    public static unsafe Formatting SendFormatting
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1155197, RefRangeEnd = 1155198, XrefRangeStart = 1155192, XrefRangeEnd = 1155197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.NativeMethodInfoPtr_get_SendFormatting_Public_Static_get_Formatting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Formatting*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 1155203, RefRangeEnd = 1155205, XrefRangeStart = 1155198, XrefRangeEnd = 1155203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.NativeMethodInfoPtr_set_SendFormatting_Public_Static_set_Void_Formatting_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155205, XrefRangeEnd = 1155244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryReadObject<T>(
      Stream stream,
      Encoding encoding,
      out T obj,
      out Il2CppSystem.Exception exc)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) encoding);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero1 = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero1);
      }
      else
        local1 = ref obj;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero2 = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero2;
      *(System.IntPtr*) num2 = (System.IntPtr) numPtr2;
      System.IntPtr exc1;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.MethodInfoStoreGeneric_TryReadObject_Public_Static_Boolean_Stream_Encoding_byref_T_byref_Exception_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc1);
      Il2CppException.RaiseExceptionIfNecessary(exc1);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref obj;
        System.IntPtr objectPointer = zero1;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      ref Il2CppSystem.Exception local3 = ref exc;
      System.IntPtr pointer = zero2;
      Il2CppSystem.Exception exception = pointer == System.IntPtr.Zero ? (Il2CppSystem.Exception) null : new Il2CppSystem.Exception(pointer);
      local3 = exception;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155244, XrefRangeEnd = 1155251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T ReadObject<T>(Stream stream, string charSet)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(charSet);
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.MethodInfoStoreGeneric_ReadObject_Public_Static_T_Stream_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155251, XrefRangeEnd = 1155254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T ReadObject<T>(Stream stream, Encoding encoding)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) encoding);
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.MethodInfoStoreGeneric_ReadObject_Private_Static_T_Stream_Encoding_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1155267, RefRangeEnd = 1155269, XrefRangeStart = 1155254, XrefRangeEnd = 1155267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T ReadObject<T>(HttpListenerContext context)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.MethodInfoStoreGeneric_ReadObject_Public_Static_T_HttpListenerContext_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155269, XrefRangeEnd = 1155297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeObject<T>(Stream stream, T obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) obj;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref obj;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.MethodInfoStoreGeneric_SerializeObject_Public_Static_Void_Stream_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1155308, RefRangeEnd = 1155309, XrefRangeStart = 1155297, XrefRangeEnd = 1155308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ObjectResponse<T>(HttpListenerContext context, T obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) obj;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref obj;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HttpServiceUtils.MethodInfoStoreGeneric_ObjectResponse_Public_Static_Void_HttpListenerContext_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HttpServiceUtils()
    {
      Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network.HttpService", nameof (HttpServiceUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr);
      HttpServiceUtils.NativeFieldInfoPtr__Serializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, nameof (_Serializer));
      HttpServiceUtils.NativeMethodInfoPtr_get_SendFormatting_Public_Static_get_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691902);
      HttpServiceUtils.NativeMethodInfoPtr_set_SendFormatting_Public_Static_set_Void_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691903);
      HttpServiceUtils.NativeMethodInfoPtr_TryReadObject_Public_Static_Boolean_Stream_Encoding_byref_T_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691904);
      HttpServiceUtils.NativeMethodInfoPtr_ReadObject_Public_Static_T_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691905);
      HttpServiceUtils.NativeMethodInfoPtr_ReadObject_Private_Static_T_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691906);
      HttpServiceUtils.NativeMethodInfoPtr_ReadObject_Public_Static_T_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691907);
      HttpServiceUtils.NativeMethodInfoPtr_SerializeObject_Public_Static_Void_Stream_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691908);
      HttpServiceUtils.NativeMethodInfoPtr_ObjectResponse_Public_Static_Void_HttpListenerContext_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr, 100691909);
    }

    public HttpServiceUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe JsonSerializer _Serializer
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(HttpServiceUtils.NativeFieldInfoPtr__Serializer, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (JsonSerializer) null : new JsonSerializer(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HttpServiceUtils.NativeFieldInfoPtr__Serializer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_TryReadObject_Public_Static_Boolean_Stream_Encoding_byref_T_byref_Exception_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpServiceUtils.NativeMethodInfoPtr_TryReadObject_Public_Static_Boolean_Stream_Encoding_byref_T_byref_Exception_0, Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadObject_Public_Static_T_Stream_String_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpServiceUtils.NativeMethodInfoPtr_ReadObject_Public_Static_T_Stream_String_0, Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadObject_Private_Static_T_Stream_Encoding_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpServiceUtils.NativeMethodInfoPtr_ReadObject_Private_Static_T_Stream_Encoding_0, Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadObject_Public_Static_T_HttpListenerContext_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpServiceUtils.NativeMethodInfoPtr_ReadObject_Public_Static_T_HttpListenerContext_0, Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SerializeObject_Public_Static_Void_Stream_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpServiceUtils.NativeMethodInfoPtr_SerializeObject_Public_Static_Void_Stream_T_0, Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ObjectResponse_Public_Static_Void_HttpListenerContext_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(HttpServiceUtils.NativeMethodInfoPtr_ObjectResponse_Public_Static_Void_HttpListenerContext_T_0, Il2CppClassPointerStore<HttpServiceUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
