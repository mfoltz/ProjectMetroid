// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkSpawnRegionRoot
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkSpawnRegionRoot : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkSpawnRegionRoot()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkSpawnRegionRoot>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkSpawnRegionRoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkSpawnRegionRoot()
    {
      Il2CppClassPointerStore<ChunkSpawnRegionRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkSpawnRegionRoot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkSpawnRegionRoot>.NativeClassPtr);
      ChunkSpawnRegionRoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkSpawnRegionRoot>.NativeClassPtr, 100667768);
    }

    public ChunkSpawnRegionRoot(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
