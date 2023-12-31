// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushData
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

#nullable disable
namespace ProjectM.Tiles
{
  [Serializable]
  public class TileBrushData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Tiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_Brush;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileBrushData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBrushData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileBrushData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileBrushData()
    {
      Il2CppClassPointerStore<TileBrushData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileBrushData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushData>.NativeClassPtr);
      TileBrushData.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushData>.NativeClassPtr, nameof (Tiles));
      TileBrushData.NativeFieldInfoPtr_Brush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBrushData>.NativeClassPtr, nameof (Brush));
      TileBrushData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushData>.NativeClassPtr, 100669878);
    }

    public TileBrushData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<int2> Tiles
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushData.NativeFieldInfoPtr_Tiles));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int2>) null : new Il2CppStructArray<int2>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileBrushData.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileBrushComponent Brush
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileBrushData.NativeFieldInfoPtr_Brush));
        return pointer == System.IntPtr.Zero ? (TileBrushComponent) null : new TileBrushComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileBrushData.NativeFieldInfoPtr_Brush), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
