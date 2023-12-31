// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkMapZoneRoot
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
  public class ChunkMapZoneRoot : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DrawMapZones;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkMapZoneRoot()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkMapZoneRoot>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkMapZoneRoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkMapZoneRoot()
    {
      Il2CppClassPointerStore<ChunkMapZoneRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkMapZoneRoot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkMapZoneRoot>.NativeClassPtr);
      ChunkMapZoneRoot.NativeFieldInfoPtr_DrawMapZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkMapZoneRoot>.NativeClassPtr, nameof (DrawMapZones));
      ChunkMapZoneRoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkMapZoneRoot>.NativeClassPtr, 100667793);
    }

    public ChunkMapZoneRoot(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool DrawMapZones
    {
      get
      {
        bool drawMapZones;
        IL2CPP.il2cpp_field_static_get_value(ChunkMapZoneRoot.NativeFieldInfoPtr_DrawMapZones, (void*) &drawMapZones);
        return drawMapZones;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ChunkMapZoneRoot.NativeFieldInfoPtr_DrawMapZones, (void*) &value);
      }
    }
  }
}
