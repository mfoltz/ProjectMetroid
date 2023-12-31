// Decompiled with JetBrains decompiler
// Type: ProjectM.MapZoneMaskAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class MapZoneMaskAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_ZoneBitMask;
    private static readonly IntPtr NativeFieldInfoPtr_Width;
    private static readonly IntPtr NativeFieldInfoPtr_Height;
    private static readonly IntPtr NativeFieldInfoPtr_BlurSigma;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapZoneMaskAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneMaskAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapZoneMaskAsset()
    {
      Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapZoneMaskAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr);
      MapZoneMaskAsset.NativeFieldInfoPtr_ZoneBitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr, nameof (ZoneBitMask));
      MapZoneMaskAsset.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr, nameof (Width));
      MapZoneMaskAsset.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr, nameof (Height));
      MapZoneMaskAsset.NativeFieldInfoPtr_BlurSigma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr, nameof (BlurSigma));
      MapZoneMaskAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneMaskAsset>.NativeClassPtr, 100665477);
    }

    public MapZoneMaskAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<int4> ZoneBitMask
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_ZoneBitMask));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<int4>) null : new Il2CppStructArray<int4>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_ZoneBitMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Width
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_Width));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_Width)) = value;
      }
    }

    public unsafe int Height
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_Height));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_Height)) = value;
      }
    }

    public unsafe int BlurSigma
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_BlurSigma));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneMaskAsset.NativeFieldInfoPtr_BlurSigma)) = value;
      }
    }
  }
}
