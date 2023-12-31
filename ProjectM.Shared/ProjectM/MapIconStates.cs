// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconStates
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
  public sealed class MapIconStates : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NameNotUsed;
    private static readonly System.IntPtr NativeFieldInfoPtr_DrawMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hover;

    static MapIconStates()
    {
      Il2CppClassPointerStore<MapIconStates>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconStates));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr);
      MapIconStates.NativeFieldInfoPtr_NameNotUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, nameof (NameNotUsed));
      MapIconStates.NativeFieldInfoPtr_DrawMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, nameof (DrawMode));
      MapIconStates.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, nameof (Normal));
      MapIconStates.NativeFieldInfoPtr_Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, nameof (Hover));
    }

    public MapIconStates(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MapIconStates()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, data));
    }

    public unsafe string NameNotUsed
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_NameNotUsed)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_NameNotUsed), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe MapIconDrawMode DrawMode
    {
      get
      {
        return *(MapIconDrawMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_DrawMode));
      }
      [param: In] set
      {
        *(MapIconDrawMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_DrawMode)) = value;
      }
    }

    public MapIconOverrideState Normal
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_Normal);
        return new MapIconOverrideState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_Normal), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MapIconOverrideState Hover
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_Hover);
        return new MapIconOverrideState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapIconStates.NativeFieldInfoPtr_Hover), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconOverrideState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
