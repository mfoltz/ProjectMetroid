// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipmentSetElements_Editor
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class EquipmentSetElements_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiredItemsInSet;
    private static readonly System.IntPtr NativeFieldInfoPtr_Buff;

    static EquipmentSetElements_Editor()
    {
      Il2CppClassPointerStore<EquipmentSetElements_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquipmentSetElements_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentSetElements_Editor>.NativeClassPtr);
      EquipmentSetElements_Editor.NativeFieldInfoPtr_RequiredItemsInSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetElements_Editor>.NativeClassPtr, nameof (RequiredItemsInSet));
      EquipmentSetElements_Editor.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetElements_Editor>.NativeClassPtr, nameof (Buff));
    }

    public EquipmentSetElements_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public EquipmentSetElements_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EquipmentSetElements_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipmentSetElements_Editor>.NativeClassPtr, data));
    }

    public unsafe int RequiredItemsInSet
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetElements_Editor.NativeFieldInfoPtr_RequiredItemsInSet));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetElements_Editor.NativeFieldInfoPtr_RequiredItemsInSet)) = value;
      }
    }

    public unsafe PrefabGuidComponent Buff
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetElements_Editor.NativeFieldInfoPtr_Buff));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipmentSetElements_Editor.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
