// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDMenuMapping
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class HUDMenuMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Menu;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;

    static HUDMenuMapping()
    {
      Il2CppClassPointerStore<HUDMenuMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDMenuMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDMenuMapping>.NativeClassPtr);
      HUDMenuMapping.NativeFieldInfoPtr_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDMenuMapping>.NativeClassPtr, nameof (Menu));
      HUDMenuMapping.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDMenuMapping>.NativeClassPtr, nameof (Prefab));
    }

    public HUDMenuMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public HUDMenuMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HUDMenuMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HUDMenuMapping>.NativeClassPtr, data));
    }

    public unsafe HUDMenuType Menu
    {
      get
      {
        return *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDMenuMapping.NativeFieldInfoPtr_Menu));
      }
      [param: In] set
      {
        *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDMenuMapping.NativeFieldInfoPtr_Menu)) = value;
      }
    }

    public unsafe HUDMenu Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDMenuMapping.NativeFieldInfoPtr_Prefab));
        return pointer == System.IntPtr.Zero ? (HUDMenu) null : new HUDMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDMenuMapping.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
