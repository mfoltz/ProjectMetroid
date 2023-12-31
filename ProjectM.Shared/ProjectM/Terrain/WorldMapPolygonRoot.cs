// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldMapPolygonRoot
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
  public class WorldMapPolygonRoot : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BlendDistBiomePolygon;
    private static readonly IntPtr NativeFieldInfoPtr_BlendDistOceanPolygon;
    private static readonly IntPtr NativeFieldInfoPtr_DrawPolygons;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768224, XrefRangeEnd = 768225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldMapPolygonRoot()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldMapPolygonRoot>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldMapPolygonRoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldMapPolygonRoot()
    {
      Il2CppClassPointerStore<WorldMapPolygonRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldMapPolygonRoot));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldMapPolygonRoot>.NativeClassPtr);
      WorldMapPolygonRoot.NativeFieldInfoPtr_BlendDistBiomePolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldMapPolygonRoot>.NativeClassPtr, nameof (BlendDistBiomePolygon));
      WorldMapPolygonRoot.NativeFieldInfoPtr_BlendDistOceanPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldMapPolygonRoot>.NativeClassPtr, nameof (BlendDistOceanPolygon));
      WorldMapPolygonRoot.NativeFieldInfoPtr_DrawPolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldMapPolygonRoot>.NativeClassPtr, nameof (DrawPolygons));
      WorldMapPolygonRoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldMapPolygonRoot>.NativeClassPtr, 100667962);
    }

    public WorldMapPolygonRoot(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float BlendDistBiomePolygon
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldMapPolygonRoot.NativeFieldInfoPtr_BlendDistBiomePolygon));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldMapPolygonRoot.NativeFieldInfoPtr_BlendDistBiomePolygon)) = value;
      }
    }

    public unsafe float BlendDistOceanPolygon
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldMapPolygonRoot.NativeFieldInfoPtr_BlendDistOceanPolygon));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldMapPolygonRoot.NativeFieldInfoPtr_BlendDistOceanPolygon)) = value;
      }
    }

    public static unsafe bool DrawPolygons
    {
      get
      {
        bool drawPolygons;
        IL2CPP.il2cpp_field_static_get_value(WorldMapPolygonRoot.NativeFieldInfoPtr_DrawPolygons, (void*) &drawPolygons);
        return drawPolygons;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WorldMapPolygonRoot.NativeFieldInfoPtr_DrawPolygons, (void*) &value);
      }
    }
  }
}
