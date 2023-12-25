// Decompiled with JetBrains decompiler
// Type: _PrivateImplementationDetails_
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 31130, RefRangeEnd = 31147, XrefRangeStart = 31130, XrefRangeEnd = 31147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint ComputeStringHash(string s)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(s);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num);
  }

  static _PrivateImplementationDetails_()
  {
    Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "", "<PrivateImplementationDetails>");
    _PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, 100665869);
  }

  public _PrivateImplementationDetails_(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
