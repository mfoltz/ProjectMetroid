// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Extensions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace Epic.OnlineServices
{
  public static class Extensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934398, XrefRangeEnd = 934402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsOperationComplete(this Result result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934402, XrefRangeEnd = 934410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ToHexString(this Il2CppStructArray<byte> byteArray)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) byteArray);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static Extensions()
    {
      Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (Extensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
      Extensions.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664220);
      Extensions.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100664221);
    }

    public Extensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
