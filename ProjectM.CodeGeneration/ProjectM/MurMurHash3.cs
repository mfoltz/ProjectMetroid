// Decompiled with JetBrains decompiler
// Type: ProjectM.MurMurHash3
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class MurMurHash3 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_seed;
    private static readonly System.IntPtr NativeMethodInfoPtr_Hash_Public_Static_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Hash_Public_Static_Int32_Stream_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_rotl32_Private_Static_UInt32_UInt32_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_fmix_Private_Static_UInt32_UInt32_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 632912, RefRangeEnd = 632915, XrefRangeStart = 632899, XrefRangeEnd = 632912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int Hash(string text)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MurMurHash3.NativeMethodInfoPtr_Hash_Public_Static_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 632928, RefRangeEnd = 632929, XrefRangeStart = 632915, XrefRangeEnd = 632928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int Hash(Stream stream, bool leaveStreamOpen = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stream);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &leaveStreamOpen;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MurMurHash3.NativeMethodInfoPtr_Hash_Public_Static_Int32_Stream_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe uint rotl32(uint x, byte r)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MurMurHash3.NativeMethodInfoPtr_rotl32_Private_Static_UInt32_UInt32_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe uint fmix(uint h)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &h;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MurMurHash3.NativeMethodInfoPtr_fmix_Private_Static_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MurMurHash3()
    {
      Il2CppClassPointerStore<MurMurHash3>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM", nameof (MurMurHash3));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurMurHash3>.NativeClassPtr);
      MurMurHash3.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurMurHash3>.NativeClassPtr, nameof (seed));
      MurMurHash3.NativeMethodInfoPtr_Hash_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurMurHash3>.NativeClassPtr, 100663305);
      MurMurHash3.NativeMethodInfoPtr_Hash_Public_Static_Int32_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurMurHash3>.NativeClassPtr, 100663306);
      MurMurHash3.NativeMethodInfoPtr_rotl32_Private_Static_UInt32_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurMurHash3>.NativeClassPtr, 100663307);
      MurMurHash3.NativeMethodInfoPtr_fmix_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurMurHash3>.NativeClassPtr, 100663308);
    }

    public MurMurHash3(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint seed
    {
      get
      {
        uint seed;
        IL2CPP.il2cpp_field_static_get_value(MurMurHash3.NativeFieldInfoPtr_seed, (void*) &seed);
        return seed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MurMurHash3.NativeFieldInfoPtr_seed, (void*) &value);
      }
    }
  }
}
