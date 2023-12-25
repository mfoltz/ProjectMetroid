// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpriteMaterialCombo
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
  public sealed class SpriteMaterialCombo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_Material;

    static SpriteMaterialCombo()
    {
      Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpriteMaterialCombo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr);
      SpriteMaterialCombo.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, nameof (Sprite));
      SpriteMaterialCombo.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, nameof (Material));
    }

    public SpriteMaterialCombo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SpriteMaterialCombo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteMaterialCombo>.NativeClassPtr, data));
    }

    public unsafe WeakAssetReference<UnityEngine.Sprite> Sprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteMaterialCombo.NativeFieldInfoPtr_Sprite));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<UnityEngine.Sprite>) null : new WeakAssetReference<UnityEngine.Sprite>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteMaterialCombo.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material Material
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteMaterialCombo.NativeFieldInfoPtr_Material));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteMaterialCombo.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
