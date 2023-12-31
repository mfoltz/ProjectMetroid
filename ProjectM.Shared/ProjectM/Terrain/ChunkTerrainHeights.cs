// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkTerrainHeights
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkTerrainHeights
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CompressedHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;
    [FieldOffset(0)]
    public ushort CompressedHeight;

    public unsafe float Height
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 767181, RefRangeEnd = 767184, XrefRangeStart = 767181, XrefRangeEnd = 767184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkTerrainHeights.NativeMethodInfoPtr_get_Height_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 184798, RefRangeEnd = 184809, XrefRangeStart = 184798, XrefRangeEnd = 184809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkTerrainHeights(ushort value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkTerrainHeights.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkTerrainHeights()
    {
      Il2CppClassPointerStore<ChunkTerrainHeights>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkTerrainHeights));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkTerrainHeights>.NativeClassPtr);
      ChunkTerrainHeights.NativeFieldInfoPtr_CompressedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkTerrainHeights>.NativeClassPtr, nameof (CompressedHeight));
      ChunkTerrainHeights.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkTerrainHeights>.NativeClassPtr, 100667852);
      ChunkTerrainHeights.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkTerrainHeights>.NativeClassPtr, 100667853);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkTerrainHeights>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
