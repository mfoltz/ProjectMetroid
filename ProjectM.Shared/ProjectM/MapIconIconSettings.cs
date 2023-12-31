// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconIconSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class MapIconIconSettings : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransitionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_SizeOverride;

    static MapIconIconSettings()
    {
      Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconIconSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr);
      MapIconIconSettings.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, nameof (Sprite));
      MapIconIconSettings.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, nameof (Color));
      MapIconIconSettings.NativeFieldInfoPtr_TransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, nameof (TransitionTime));
      MapIconIconSettings.NativeFieldInfoPtr_OverrideSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, nameof (OverrideSize));
      MapIconIconSettings.NativeFieldInfoPtr_SizeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, nameof (SizeOverride));
    }

    public MapIconIconSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MapIconIconSettings()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, data));
    }

    public unsafe Sprite Sprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_Sprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_Color)) = value;
      }
    }

    public unsafe float TransitionTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_TransitionTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_TransitionTime)) = value;
      }
    }

    public unsafe bool OverrideSize
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_OverrideSize));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_OverrideSize)) = value;
      }
    }

    public unsafe Vector2 SizeOverride
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_SizeOverride));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconIconSettings.NativeFieldInfoPtr_SizeOverride)) = value;
      }
    }
  }
}
