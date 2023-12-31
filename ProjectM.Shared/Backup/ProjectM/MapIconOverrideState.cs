// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconOverrideState
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
  public sealed class MapIconOverrideState : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubHeader;

    static MapIconOverrideState()
    {
      Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconOverrideState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr);
      MapIconOverrideState.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, nameof (Icon));
      MapIconOverrideState.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, nameof (Header));
      MapIconOverrideState.NativeFieldInfoPtr_SubHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, nameof (SubHeader));
    }

    public MapIconOverrideState(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MapIconOverrideState()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, data));
    }

    public MapIconIconOverrideSettings Icon
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconOverrideState.NativeFieldInfoPtr_Icon);
        return new MapIconIconOverrideSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconIconOverrideSettings>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconOverrideState.NativeFieldInfoPtr_Icon), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconIconOverrideSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe MapIconLabelOverrideSettings Header
    {
      get
      {
        return *(MapIconLabelOverrideSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconOverrideState.NativeFieldInfoPtr_Header));
      }
      [param: In] set
      {
        *(MapIconLabelOverrideSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconOverrideState.NativeFieldInfoPtr_Header)) = value;
      }
    }

    public unsafe MapIconLabelOverrideSettings SubHeader
    {
      get
      {
        return *(MapIconLabelOverrideSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconOverrideState.NativeFieldInfoPtr_SubHeader));
      }
      [param: In] set
      {
        *(MapIconLabelOverrideSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconOverrideState.NativeFieldInfoPtr_SubHeader)) = value;
      }
    }
  }
}
