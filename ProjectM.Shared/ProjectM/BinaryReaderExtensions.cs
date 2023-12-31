// Decompiled with JetBrains decompiler
// Type: ProjectM.BinaryReaderExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.IO;

#nullable disable
namespace ProjectM
{
  public static class BinaryReaderExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFloat32_Public_Static_Single_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFloat64_Public_Static_Double_BinaryReader_0;

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 763644, RefRangeEnd = 763662, XrefRangeStart = 763644, XrefRangeEnd = 763644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float ReadFloat32(this BinaryReader reader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BinaryReaderExtensions.NativeMethodInfoPtr_ReadFloat32_Public_Static_Single_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763662, RefRangeEnd = 763663, XrefRangeStart = 763662, XrefRangeEnd = 763662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double ReadFloat64(this BinaryReader reader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BinaryReaderExtensions.NativeMethodInfoPtr_ReadFloat64_Public_Static_Double_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(double*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BinaryReaderExtensions()
    {
      Il2CppClassPointerStore<BinaryReaderExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BinaryReaderExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryReaderExtensions>.NativeClassPtr);
      BinaryReaderExtensions.NativeMethodInfoPtr_ReadFloat32_Public_Static_Single_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReaderExtensions>.NativeClassPtr, 100667470);
      BinaryReaderExtensions.NativeMethodInfoPtr_ReadFloat64_Public_Static_Double_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReaderExtensions>.NativeClassPtr, 100667471);
    }

    public BinaryReaderExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
