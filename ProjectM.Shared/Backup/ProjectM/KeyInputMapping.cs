// Decompiled with JetBrains decompiler
// Type: ProjectM.KeyInputMapping
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
  public sealed class KeyInputMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InputType;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryKeyCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryKeyCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_Analog;
    private static readonly System.IntPtr NativeFieldInfoPtr_Positive;
    private static readonly System.IntPtr NativeFieldInfoPtr_Deadzone;
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousAnalogDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogInputRepeatDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogInputResetTime;

    static KeyInputMapping()
    {
      Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KeyInputMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr);
      KeyInputMapping.NativeFieldInfoPtr_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (InputType));
      KeyInputMapping.NativeFieldInfoPtr_InputFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (InputFlag));
      KeyInputMapping.NativeFieldInfoPtr_PrimaryKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (PrimaryKeyCode));
      KeyInputMapping.NativeFieldInfoPtr_SecondaryKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (SecondaryKeyCode));
      KeyInputMapping.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (Button));
      KeyInputMapping.NativeFieldInfoPtr_Analog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (Analog));
      KeyInputMapping.NativeFieldInfoPtr_Positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (Positive));
      KeyInputMapping.NativeFieldInfoPtr_Deadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (Deadzone));
      KeyInputMapping.NativeFieldInfoPtr_PreviousAnalogDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (PreviousAnalogDown));
      KeyInputMapping.NativeFieldInfoPtr_AnalogInputRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (AnalogInputRepeatDelay));
      KeyInputMapping.NativeFieldInfoPtr_AnalogInputResetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, nameof (AnalogInputResetTime));
    }

    public KeyInputMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public KeyInputMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyInputMapping>.NativeClassPtr, data));
    }

    public unsafe InputType InputType
    {
      get
      {
        return *(InputType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_InputType));
      }
      [param: In] set
      {
        *(InputType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_InputType)) = value;
      }
    }

    public unsafe InputFlag InputFlag
    {
      get
      {
        return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_InputFlag));
      }
      [param: In] set
      {
        *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_InputFlag)) = value;
      }
    }

    public unsafe KeyCode PrimaryKeyCode
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_PrimaryKeyCode));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_PrimaryKeyCode)) = value;
      }
    }

    public unsafe KeyCode SecondaryKeyCode
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_SecondaryKeyCode));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_SecondaryKeyCode)) = value;
      }
    }

    public unsafe string Button
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Button)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Button), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Analog
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Analog)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Analog), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool Positive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Positive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Positive)) = value;
      }
    }

    public unsafe float Deadzone
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Deadzone));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_Deadzone)) = value;
      }
    }

    public unsafe bool PreviousAnalogDown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_PreviousAnalogDown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_PreviousAnalogDown)) = value;
      }
    }

    public unsafe float AnalogInputRepeatDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_AnalogInputRepeatDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_AnalogInputRepeatDelay)) = value;
      }
    }

    public unsafe float AnalogInputResetTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_AnalogInputResetTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyInputMapping.NativeFieldInfoPtr_AnalogInputResetTime)) = value;
      }
    }
  }
}
