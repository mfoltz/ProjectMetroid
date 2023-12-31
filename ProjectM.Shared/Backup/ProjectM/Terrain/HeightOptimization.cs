// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.HeightOptimization
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  public static class HeightOptimization : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompressRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToCompressedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToUncompressedMultiplier;
    private static readonly System.IntPtr NativeMethodInfoPtr_Compress_Public_Static_UInt16_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Decompress_Public_Static_Single_UInt16_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 767124, RefRangeEnd = 767132, XrefRangeStart = 767122, XrefRangeEnd = 767124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ushort Compress(float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HeightOptimization.NativeMethodInfoPtr_Compress_Public_Static_UInt16_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(48)]
    [CachedScanResults(RefRangeStart = 767132, RefRangeEnd = 767180, XrefRangeStart = 767132, XrefRangeEnd = 767132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float Decompress(ushort compressedHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &compressedHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HeightOptimization.NativeMethodInfoPtr_Decompress_Public_Static_Single_UInt16_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static HeightOptimization()
    {
      Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (HeightOptimization));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr);
      HeightOptimization.NativeFieldInfoPtr_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, nameof (MaxHeight));
      HeightOptimization.NativeFieldInfoPtr_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, nameof (MinHeight));
      HeightOptimization.NativeFieldInfoPtr_HeightDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, nameof (HeightDiff));
      HeightOptimization.NativeFieldInfoPtr_CompressRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, nameof (CompressRange));
      HeightOptimization.NativeFieldInfoPtr_ToCompressedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, nameof (ToCompressedMultiplier));
      HeightOptimization.NativeFieldInfoPtr_ToUncompressedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, nameof (ToUncompressedMultiplier));
      HeightOptimization.NativeMethodInfoPtr_Compress_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, 100667849);
      HeightOptimization.NativeMethodInfoPtr_Decompress_Public_Static_Single_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightOptimization>.NativeClassPtr, 100667850);
    }

    public HeightOptimization(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MaxHeight
    {
      get
      {
        int maxHeight;
        IL2CPP.il2cpp_field_static_get_value(HeightOptimization.NativeFieldInfoPtr_MaxHeight, (void*) &maxHeight);
        return maxHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeightOptimization.NativeFieldInfoPtr_MaxHeight, (void*) &value);
      }
    }

    public static unsafe int MinHeight
    {
      get
      {
        int minHeight;
        IL2CPP.il2cpp_field_static_get_value(HeightOptimization.NativeFieldInfoPtr_MinHeight, (void*) &minHeight);
        return minHeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeightOptimization.NativeFieldInfoPtr_MinHeight, (void*) &value);
      }
    }

    public static unsafe int HeightDiff
    {
      get
      {
        int heightDiff;
        IL2CPP.il2cpp_field_static_get_value(HeightOptimization.NativeFieldInfoPtr_HeightDiff, (void*) &heightDiff);
        return heightDiff;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeightOptimization.NativeFieldInfoPtr_HeightDiff, (void*) &value);
      }
    }

    public static unsafe int CompressRange
    {
      get
      {
        int compressRange;
        IL2CPP.il2cpp_field_static_get_value(HeightOptimization.NativeFieldInfoPtr_CompressRange, (void*) &compressRange);
        return compressRange;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeightOptimization.NativeFieldInfoPtr_CompressRange, (void*) &value);
      }
    }

    public static unsafe float ToCompressedMultiplier
    {
      get
      {
        float compressedMultiplier;
        IL2CPP.il2cpp_field_static_get_value(HeightOptimization.NativeFieldInfoPtr_ToCompressedMultiplier, (void*) &compressedMultiplier);
        return compressedMultiplier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeightOptimization.NativeFieldInfoPtr_ToCompressedMultiplier, (void*) &value);
      }
    }

    public static unsafe float ToUncompressedMultiplier
    {
      get
      {
        float uncompressedMultiplier;
        IL2CPP.il2cpp_field_static_get_value(HeightOptimization.NativeFieldInfoPtr_ToUncompressedMultiplier, (void*) &uncompressedMultiplier);
        return uncompressedMultiplier;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HeightOptimization.NativeFieldInfoPtr_ToUncompressedMultiplier, (void*) &value);
      }
    }
  }
}
