// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ViewMapping
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class ViewMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Location;
    private static readonly System.IntPtr NativeFieldInfoPtr_ViewPrefab;

    static ViewMapping()
    {
      Il2CppClassPointerStore<ViewMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ViewMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewMapping>.NativeClassPtr);
      ViewMapping.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewMapping>.NativeClassPtr, nameof (Location));
      ViewMapping.NativeFieldInfoPtr_ViewPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewMapping>.NativeClassPtr, nameof (ViewPrefab));
    }

    public ViewMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ViewMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ViewMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ViewMapping>.NativeClassPtr, data));
    }

    public unsafe ViewLocation Location
    {
      get
      {
        return *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ViewMapping.NativeFieldInfoPtr_Location));
      }
      [param: In] set
      {
        *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ViewMapping.NativeFieldInfoPtr_Location)) = value;
      }
    }

    public unsafe WeakAssetReference<GameObject> ViewPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ViewMapping.NativeFieldInfoPtr_ViewPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ViewMapping.NativeFieldInfoPtr_ViewPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
