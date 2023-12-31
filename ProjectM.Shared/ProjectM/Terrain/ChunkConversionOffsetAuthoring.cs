// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkConversionOffsetAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkConversionOffsetAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Coordinate;
    private static readonly IntPtr NativeFieldInfoPtr_ConversionRotation;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkConversionOffsetAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkConversionOffsetAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkConversionOffsetAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkConversionOffsetAuthoring()
    {
      Il2CppClassPointerStore<ChunkConversionOffsetAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkConversionOffsetAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkConversionOffsetAuthoring>.NativeClassPtr);
      ChunkConversionOffsetAuthoring.NativeFieldInfoPtr_Coordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkConversionOffsetAuthoring>.NativeClassPtr, nameof (Coordinate));
      ChunkConversionOffsetAuthoring.NativeFieldInfoPtr_ConversionRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkConversionOffsetAuthoring>.NativeClassPtr, nameof (ConversionRotation));
      ChunkConversionOffsetAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkConversionOffsetAuthoring>.NativeClassPtr, 100667705);
    }

    public ChunkConversionOffsetAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainChunk Coordinate
    {
      get
      {
        return *(TerrainChunk*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkConversionOffsetAuthoring.NativeFieldInfoPtr_Coordinate));
      }
      [param: In] set
      {
        *(TerrainChunk*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkConversionOffsetAuthoring.NativeFieldInfoPtr_Coordinate)) = value;
      }
    }

    public unsafe OrthogonalRotation ConversionRotation
    {
      get
      {
        return *(OrthogonalRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkConversionOffsetAuthoring.NativeFieldInfoPtr_ConversionRotation));
      }
      [param: In] set
      {
        *(OrthogonalRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkConversionOffsetAuthoring.NativeFieldInfoPtr_ConversionRotation)) = value;
      }
    }
  }
}
