// Decompiled with JetBrains decompiler
// Type: _PrivateImplementationDetails_
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_6A896A1A52150D33C66EF02908C8CF7EAF8B7900E7B219762D34AC1C85D19DC9;
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
    Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", "<PrivateImplementationDetails>");
    _PrivateImplementationDetails_.NativeFieldInfoPtr_6A896A1A52150D33C66EF02908C8CF7EAF8B7900E7B219762D34AC1C85D19DC9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, nameof (\u0036A896A1A52150D33C66EF02908C8CF7EAF8B7900E7B219762D34AC1C85D19DC9));
    _PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, 100670890);
  }

  public _PrivateImplementationDetails_(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe _PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique \u0036A896A1A52150D33C66EF02908C8CF7EAF8B7900E7B219762D34AC1C85D19DC9
  {
    get
    {
      _PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique b219762D34Ac1C85D19Dc9;
      IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_6A896A1A52150D33C66EF02908C8CF7EAF8B7900E7B219762D34AC1C85D19DC9, (void*) &b219762D34Ac1C85D19Dc9);
      return b219762D34Ac1C85D19Dc9;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_6A896A1A52150D33C66EF02908C8CF7EAF8B7900E7B219762D34AC1C85D19DC9, (void*) &value);
    }
  }

  [ObfuscatedName("<PrivateImplementationDetails>/__StaticArrayInitTypeSize=140")]
  [StructLayout(LayoutKind.Explicit)]
  public struct ValueTypeNPrivateSealedUnique
  {
    static ValueTypeNPrivateSealedUnique()
    {
      Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=140");
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
