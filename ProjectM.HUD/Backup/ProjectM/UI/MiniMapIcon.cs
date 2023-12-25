// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MiniMapIcon
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public sealed class MiniMapIcon : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_IconColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Static;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClampAtBorder;
    private static readonly System.IntPtr NativeFieldInfoPtr_AngleRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pulsing;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLookAtTarget;

    static MiniMapIcon()
    {
      Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MiniMapIcon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr);
      MiniMapIcon.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (Sprite));
      MiniMapIcon.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (Position));
      MiniMapIcon.NativeFieldInfoPtr_IconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (IconColor));
      MiniMapIcon.NativeFieldInfoPtr_Static = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (Static));
      MiniMapIcon.NativeFieldInfoPtr_ClampAtBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (ClampAtBorder));
      MiniMapIcon.NativeFieldInfoPtr_AngleRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (AngleRotation));
      MiniMapIcon.NativeFieldInfoPtr_Pulsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (Pulsing));
      MiniMapIcon.NativeFieldInfoPtr_IsLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, nameof (IsLookAtTarget));
    }

    public MiniMapIcon(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MiniMapIcon()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapIcon>.NativeClassPtr, data));
    }

    public unsafe Sprite Sprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Sprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 Position
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe Color IconColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_IconColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_IconColor)) = value;
      }
    }

    public unsafe bool Static
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Static));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Static)) = value;
      }
    }

    public unsafe bool ClampAtBorder
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_ClampAtBorder));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_ClampAtBorder)) = value;
      }
    }

    public unsafe float AngleRotation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_AngleRotation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_AngleRotation)) = value;
      }
    }

    public unsafe bool Pulsing
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Pulsing));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_Pulsing)) = value;
      }
    }

    public unsafe bool IsLookAtTarget
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_IsLookAtTarget));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapIcon.NativeFieldInfoPtr_IsLookAtTarget)) = value;
      }
    }
  }
}
