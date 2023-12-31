// Decompiled with JetBrains decompiler
// Type: ProjectM.AnalogInputMapping
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class AnalogInputMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InputType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogInputType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Inverted;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryPositiveKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryPositiveKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryNegativeKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryNegativeKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_Modifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Analog;
    private static readonly System.IntPtr NativeFieldInfoPtr_Deadzone;
    private static readonly System.IntPtr NativeFieldInfoPtr_NegativeButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositiveButton;

    static AnalogInputMapping()
    {
      Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AnalogInputMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr);
      AnalogInputMapping.NativeFieldInfoPtr_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (InputType));
      AnalogInputMapping.NativeFieldInfoPtr_AnalogInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (AnalogInputType));
      AnalogInputMapping.NativeFieldInfoPtr_Inverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (Inverted));
      AnalogInputMapping.NativeFieldInfoPtr_PrimaryPositiveKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (PrimaryPositiveKey));
      AnalogInputMapping.NativeFieldInfoPtr_SecondaryPositiveKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (SecondaryPositiveKey));
      AnalogInputMapping.NativeFieldInfoPtr_PrimaryNegativeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (PrimaryNegativeKey));
      AnalogInputMapping.NativeFieldInfoPtr_SecondaryNegativeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (SecondaryNegativeKey));
      AnalogInputMapping.NativeFieldInfoPtr_Modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (Modifier));
      AnalogInputMapping.NativeFieldInfoPtr_Analog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (Analog));
      AnalogInputMapping.NativeFieldInfoPtr_Deadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (Deadzone));
      AnalogInputMapping.NativeFieldInfoPtr_NegativeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (NegativeButton));
      AnalogInputMapping.NativeFieldInfoPtr_PositiveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, nameof (PositiveButton));
    }

    public AnalogInputMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AnalogInputMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalogInputMapping>.NativeClassPtr, data));
    }

    public unsafe InputType InputType
    {
      get
      {
        return *(InputType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_InputType));
      }
      [param: In] set
      {
        *(InputType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_InputType)) = value;
      }
    }

    public unsafe AnalogInput AnalogInputType
    {
      get
      {
        return *(AnalogInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_AnalogInputType));
      }
      [param: In] set
      {
        *(AnalogInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_AnalogInputType)) = value;
      }
    }

    public unsafe bool Inverted
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Inverted));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Inverted)) = value;
      }
    }

    public unsafe KeyCode PrimaryPositiveKey
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_PrimaryPositiveKey));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_PrimaryPositiveKey)) = value;
      }
    }

    public unsafe KeyCode SecondaryPositiveKey
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_SecondaryPositiveKey));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_SecondaryPositiveKey)) = value;
      }
    }

    public unsafe KeyCode PrimaryNegativeKey
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_PrimaryNegativeKey));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_PrimaryNegativeKey)) = value;
      }
    }

    public unsafe KeyCode SecondaryNegativeKey
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_SecondaryNegativeKey));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_SecondaryNegativeKey)) = value;
      }
    }

    public unsafe float Modifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Modifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Modifier)) = value;
      }
    }

    public unsafe string Analog
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Analog)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Analog), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float Deadzone
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Deadzone));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_Deadzone)) = value;
      }
    }

    public unsafe string NegativeButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_NegativeButton)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_NegativeButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string PositiveButton
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_PositiveButton)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnalogInputMapping.NativeFieldInfoPtr_PositiveButton), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
