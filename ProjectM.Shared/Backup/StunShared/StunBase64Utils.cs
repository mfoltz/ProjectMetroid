// Decompiled with JetBrains decompiler
// Type: StunShared.StunBase64Utils
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace StunShared
{
  public static class StunBase64Utils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DecodeSafe_Public_Static_Il2CppStructArray_1_Byte_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EncodeSafe_Public_Static_String_Il2CppStructArray_1_Byte_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 717466, RefRangeEnd = 717467, XrefRangeStart = 717453, XrefRangeEnd = 717466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStructArray<byte> DecodeSafe(string input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunBase64Utils.NativeMethodInfoPtr_DecodeSafe_Public_Static_Il2CppStructArray_1_Byte_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 717480, RefRangeEnd = 717481, XrefRangeStart = 717467, XrefRangeEnd = 717480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string EncodeSafe(Il2CppStructArray<byte> input)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) input);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StunBase64Utils.NativeMethodInfoPtr_EncodeSafe_Public_Static_String_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static StunBase64Utils()
    {
      Il2CppClassPointerStore<StunBase64Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared", nameof (StunBase64Utils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunBase64Utils>.NativeClassPtr);
      StunBase64Utils.NativeMethodInfoPtr_DecodeSafe_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunBase64Utils>.NativeClassPtr, 100663542);
      StunBase64Utils.NativeMethodInfoPtr_EncodeSafe_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunBase64Utils>.NativeClassPtr, 100663543);
    }

    public StunBase64Utils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
