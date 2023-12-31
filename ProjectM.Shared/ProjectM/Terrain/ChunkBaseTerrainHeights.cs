// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkBaseTerrainHeights
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
  public struct ChunkBaseTerrainHeights
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CompressedHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Height_Public_get_Single_0;
    [FieldOffset(0)]
    public ushort CompressedHeight;

    public unsafe float Height
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 767181, RefRangeEnd = 767184, XrefRangeStart = 767180, XrefRangeEnd = 767181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkBaseTerrainHeights.NativeMethodInfoPtr_get_Height_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ChunkBaseTerrainHeights()
    {
      Il2CppClassPointerStore<ChunkBaseTerrainHeights>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkBaseTerrainHeights));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkBaseTerrainHeights>.NativeClassPtr);
      ChunkBaseTerrainHeights.NativeFieldInfoPtr_CompressedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkBaseTerrainHeights>.NativeClassPtr, nameof (CompressedHeight));
      ChunkBaseTerrainHeights.NativeMethodInfoPtr_get_Height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkBaseTerrainHeights>.NativeClassPtr, 100667851);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkBaseTerrainHeights>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
