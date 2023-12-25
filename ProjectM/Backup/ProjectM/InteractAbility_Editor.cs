// Decompiled with JetBrains decompiler
// Type: ProjectM.InteractAbility_Editor
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
  public sealed class InteractAbility_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractAbility;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideInteractHUDWhileCasting;

    static InteractAbility_Editor()
    {
      Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InteractAbility_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr);
      InteractAbility_Editor.NativeFieldInfoPtr_InteractAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr, nameof (InteractAbility));
      InteractAbility_Editor.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr, nameof (Importance));
      InteractAbility_Editor.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr, nameof (Conditional));
      InteractAbility_Editor.NativeFieldInfoPtr_HideInteractHUDWhileCasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr, nameof (HideInteractHUDWhileCasting));
    }

    public InteractAbility_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public InteractAbility_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractAbility_Editor>.NativeClassPtr, data));
    }

    public unsafe PrefabGuidComponent InteractAbility
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_InteractAbility));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_InteractAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool HideInteractHUDWhileCasting
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_HideInteractHUDWhileCasting));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractAbility_Editor.NativeFieldInfoPtr_HideInteractHUDWhileCasting)) = value;
      }
    }
  }
}
