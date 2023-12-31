// Decompiled with JetBrains decompiler
// Type: ProjectM.UISound
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
  public sealed class UISound : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Mapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;

    static UISound()
    {
      Il2CppClassPointerStore<UISound>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UISound));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISound>.NativeClassPtr);
      UISound.NativeFieldInfoPtr_Mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISound>.NativeClassPtr, nameof (Mapping));
      UISound.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISound>.NativeClassPtr, nameof (Type));
    }

    public UISound(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public UISound()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UISound>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UISound>.NativeClassPtr, data));
    }

    public unsafe UISoundMapping Mapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISound.NativeFieldInfoPtr_Mapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISound.NativeFieldInfoPtr_Mapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType Type
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISound.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISound.NativeFieldInfoPtr_Type)) = value;
      }
    }
  }
}
