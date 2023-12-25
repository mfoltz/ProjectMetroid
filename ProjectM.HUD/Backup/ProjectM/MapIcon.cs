// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIcon
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class MapIcon : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_IconSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_IconColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapIcon()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapIcon>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapIcon()
    {
      Il2CppClassPointerStore<MapIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (MapIcon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIcon>.NativeClassPtr);
      MapIcon.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIcon>.NativeClassPtr, nameof (Type));
      MapIcon.NativeFieldInfoPtr_IconSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIcon>.NativeClassPtr, nameof (IconSprite));
      MapIcon.NativeFieldInfoPtr_IconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIcon>.NativeClassPtr, nameof (IconColor));
      MapIcon.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIcon>.NativeClassPtr, nameof (Label));
      MapIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapIcon>.NativeClassPtr, 100663751);
    }

    public MapIcon(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MapIconType Type
    {
      get
      {
        return *(MapIconType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(MapIconType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe Sprite IconSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_IconSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_IconSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color IconColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_IconColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_IconColor)) = value;
      }
    }

    public unsafe LocalizationKey Label
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_Label));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIcon.NativeFieldInfoPtr_Label)) = value;
      }
    }
  }
}
