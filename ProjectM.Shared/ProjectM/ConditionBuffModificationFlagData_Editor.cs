// Decompiled with JetBrains decompiler
// Type: ProjectM.ConditionBuffModificationFlagData_Editor
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
  public sealed class ConditionBuffModificationFlagData_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;

    static ConditionBuffModificationFlagData_Editor()
    {
      Il2CppClassPointerStore<ConditionBuffModificationFlagData_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConditionBuffModificationFlagData_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionBuffModificationFlagData_Editor>.NativeClassPtr);
      ConditionBuffModificationFlagData_Editor.NativeFieldInfoPtr_ModificationTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionBuffModificationFlagData_Editor>.NativeClassPtr, nameof (ModificationTypes));
      ConditionBuffModificationFlagData_Editor.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionBuffModificationFlagData_Editor>.NativeClassPtr, nameof (Conditional));
    }

    public ConditionBuffModificationFlagData_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ConditionBuffModificationFlagData_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConditionBuffModificationFlagData_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionBuffModificationFlagData_Editor>.NativeClassPtr, data));
    }

    public unsafe long ModificationTypes
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionBuffModificationFlagData_Editor.NativeFieldInfoPtr_ModificationTypes));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionBuffModificationFlagData_Editor.NativeFieldInfoPtr_ModificationTypes)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionBuffModificationFlagData_Editor.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionBuffModificationFlagData_Editor.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
