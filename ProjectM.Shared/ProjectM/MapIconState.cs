// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class MapIconState : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubHeader;

    static MapIconState()
    {
      Il2CppClassPointerStore<MapIconState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconState>.NativeClassPtr);
      MapIconState.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, nameof (Icon));
      MapIconState.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, nameof (Header));
      MapIconState.NativeFieldInfoPtr_SubHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, nameof (SubHeader));
    }

    public MapIconState(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MapIconState()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconState>.NativeClassPtr, data));
    }

    public MapIconIconSettings Icon
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconState.NativeFieldInfoPtr_Icon);
        return new MapIconIconSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconState.NativeFieldInfoPtr_Icon), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconIconSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe MapIconLabelSettings Header
    {
      get
      {
        return *(MapIconLabelSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconState.NativeFieldInfoPtr_Header));
      }
      [param: In] set
      {
        *(MapIconLabelSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconState.NativeFieldInfoPtr_Header)) = value;
      }
    }

    public unsafe MapIconLabelSettings SubHeader
    {
      get
      {
        return *(MapIconLabelSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconState.NativeFieldInfoPtr_SubHeader));
      }
      [param: In] set
      {
        *(MapIconLabelSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconState.NativeFieldInfoPtr_SubHeader)) = value;
      }
    }
  }
}
