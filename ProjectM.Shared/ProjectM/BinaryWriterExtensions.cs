// Decompiled with JetBrains decompiler
// Type: ProjectM.BinaryWriterExtensions
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
  public static class BinaryWriterExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteFloat32_Public_Static_Void_BinaryWriter_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteFloat64_Public_Static_Void_BinaryWriter_Double_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763641, RefRangeEnd = 763642, XrefRangeStart = 763640, XrefRangeEnd = 763641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteFloat32(this BinaryWriter writer, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BinaryWriterExtensions.NativeMethodInfoPtr_WriteFloat32_Public_Static_Void_BinaryWriter_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763643, RefRangeEnd = 763644, XrefRangeStart = 763642, XrefRangeEnd = 763643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteFloat64(this BinaryWriter writer, double value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BinaryWriterExtensions.NativeMethodInfoPtr_WriteFloat64_Public_Static_Void_BinaryWriter_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BinaryWriterExtensions()
    {
      Il2CppClassPointerStore<BinaryWriterExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BinaryWriterExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryWriterExtensions>.NativeClassPtr);
      BinaryWriterExtensions.NativeMethodInfoPtr_WriteFloat32_Public_Static_Void_BinaryWriter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriterExtensions>.NativeClassPtr, 100667468);
      BinaryWriterExtensions.NativeMethodInfoPtr_WriteFloat64_Public_Static_Void_BinaryWriter_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriterExtensions>.NativeClassPtr, 100667469);
    }

    public BinaryWriterExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
