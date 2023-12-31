// Decompiled with JetBrains decompiler
// Type: ProjectM.MapBiome
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
namespace ProjectM
{
  public class MapBiome : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_GroundHeightGradient;
    private static readonly IntPtr NativeFieldInfoPtr_WaterColor;
    private static readonly IntPtr NativeFieldInfoPtr_CollisionColor;
    private static readonly IntPtr NativeFieldInfoPtr_RoadColor;
    private static readonly IntPtr NativeFieldInfoPtr_RoadOutlineColor;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapBiome()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapBiome>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapBiome.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapBiome()
    {
      Il2CppClassPointerStore<MapBiome>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapBiome));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapBiome>.NativeClassPtr);
      MapBiome.NativeFieldInfoPtr_GroundHeightGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapBiome>.NativeClassPtr, nameof (GroundHeightGradient));
      MapBiome.NativeFieldInfoPtr_WaterColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapBiome>.NativeClassPtr, nameof (WaterColor));
      MapBiome.NativeFieldInfoPtr_CollisionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapBiome>.NativeClassPtr, nameof (CollisionColor));
      MapBiome.NativeFieldInfoPtr_RoadColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapBiome>.NativeClassPtr, nameof (RoadColor));
      MapBiome.NativeFieldInfoPtr_RoadOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapBiome>.NativeClassPtr, nameof (RoadOutlineColor));
      MapBiome.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapBiome>.NativeClassPtr, 100667355);
    }

    public MapBiome(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Gradient GroundHeightGradient
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_GroundHeightGradient));
        return pointer == IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_GroundHeightGradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color WaterColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_WaterColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_WaterColor)) = value;
      }
    }

    public unsafe Color CollisionColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_CollisionColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_CollisionColor)) = value;
      }
    }

    public unsafe Color RoadColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_RoadColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_RoadColor)) = value;
      }
    }

    public unsafe Color RoadOutlineColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_RoadOutlineColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapBiome.NativeFieldInfoPtr_RoadOutlineColor)) = value;
      }
    }
  }
}
