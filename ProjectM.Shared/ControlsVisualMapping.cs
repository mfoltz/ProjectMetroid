// Decompiled with JetBrains decompiler
// Type: ControlsVisualMapping
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ControlsVisualMapping : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_KeysData;
  private static readonly System.IntPtr NativeFieldInfoPtr_ButtonsData;
  private static readonly System.IntPtr NativeFieldInfoPtr_AnalogsData;
  private static readonly System.IntPtr NativeFieldInfoPtr_InputFlagsData;
  private static readonly System.IntPtr NativeFieldInfoPtr_AnalogInputsData;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultAnalogInputMappings;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultKeyInputMappings;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714215, XrefRangeEnd = 714230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControlsVisualMapping()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControlsVisualMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ControlsVisualMapping()
  {
    Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ControlsVisualMapping));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr);
    ControlsVisualMapping.NativeFieldInfoPtr_KeysData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (KeysData));
    ControlsVisualMapping.NativeFieldInfoPtr_ButtonsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (ButtonsData));
    ControlsVisualMapping.NativeFieldInfoPtr_AnalogsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (AnalogsData));
    ControlsVisualMapping.NativeFieldInfoPtr_InputFlagsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (InputFlagsData));
    ControlsVisualMapping.NativeFieldInfoPtr_AnalogInputsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (AnalogInputsData));
    ControlsVisualMapping.NativeFieldInfoPtr_DefaultAnalogInputMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (DefaultAnalogInputMappings));
    ControlsVisualMapping.NativeFieldInfoPtr_DefaultKeyInputMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (DefaultKeyInputMappings));
    ControlsVisualMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, 100663328);
  }

  public ControlsVisualMapping(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<ControlsVisualMapping.KeycodeMapping> KeysData
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_KeysData));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ControlsVisualMapping.KeycodeMapping>) null : new Il2CppReferenceArray<ControlsVisualMapping.KeycodeMapping>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_KeysData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ControlsVisualMapping.ButtonMapping> ButtonsData
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_ButtonsData));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ControlsVisualMapping.ButtonMapping>) null : new Il2CppReferenceArray<ControlsVisualMapping.ButtonMapping>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_ButtonsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ControlsVisualMapping.AnalogMapping> AnalogsData
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_AnalogsData));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ControlsVisualMapping.AnalogMapping>) null : new Il2CppReferenceArray<ControlsVisualMapping.AnalogMapping>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_AnalogsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<ControlsVisualMapping.InputFlagMapping> InputFlagsData
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_InputFlagsData));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ControlsVisualMapping.InputFlagMapping>) null : new Il2CppStructArray<ControlsVisualMapping.InputFlagMapping>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_InputFlagsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<ControlsVisualMapping.AnalogInputMapping> AnalogInputsData
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_AnalogInputsData));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<ControlsVisualMapping.AnalogInputMapping>) null : new Il2CppStructArray<ControlsVisualMapping.AnalogInputMapping>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_AnalogInputsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ProjectM.AnalogInputMapping> DefaultAnalogInputMappings
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_DefaultAnalogInputMappings));
      return pointer == System.IntPtr.Zero ? (List<ProjectM.AnalogInputMapping>) null : new List<ProjectM.AnalogInputMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_DefaultAnalogInputMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<KeyInputMapping> DefaultKeyInputMappings
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_DefaultKeyInputMappings));
      return pointer == System.IntPtr.Zero ? (List<KeyInputMapping>) null : new List<KeyInputMapping>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.NativeFieldInfoPtr_DefaultKeyInputMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class KeycodeMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_KeyCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeySprite;

    static KeycodeMapping()
    {
      Il2CppClassPointerStore<ControlsVisualMapping.KeycodeMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (KeycodeMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsVisualMapping.KeycodeMapping>.NativeClassPtr);
      ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.KeycodeMapping>.NativeClassPtr, nameof (KeyCode));
      ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_TextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.KeycodeMapping>.NativeClassPtr, nameof (TextKey));
      ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_KeySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.KeycodeMapping>.NativeClassPtr, nameof (KeySprite));
    }

    public KeycodeMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public KeycodeMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControlsVisualMapping.KeycodeMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlsVisualMapping.KeycodeMapping>.NativeClassPtr, data));
    }

    public unsafe KeyCode KeyCode
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_KeyCode));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_KeyCode)) = value;
      }
    }

    public unsafe LocalizationKey TextKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_TextKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_TextKey)) = value;
      }
    }

    public unsafe Sprite KeySprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_KeySprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.KeycodeMapping.NativeFieldInfoPtr_KeySprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class ButtonMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonSprite;

    static ButtonMapping()
    {
      Il2CppClassPointerStore<ControlsVisualMapping.ButtonMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (ButtonMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsVisualMapping.ButtonMapping>.NativeClassPtr);
      ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.ButtonMapping>.NativeClassPtr, nameof (ButtonText));
      ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.ButtonMapping>.NativeClassPtr, nameof (ButtonKey));
      ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.ButtonMapping>.NativeClassPtr, nameof (ButtonSprite));
    }

    public ButtonMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ButtonMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControlsVisualMapping.ButtonMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlsVisualMapping.ButtonMapping>.NativeClassPtr, data));
    }

    public unsafe string ButtonText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey ButtonKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonKey)) = value;
      }
    }

    public unsafe Sprite ButtonSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.ButtonMapping.NativeFieldInfoPtr_ButtonSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class AnalogMapping : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogText;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogSprite;

    static AnalogMapping()
    {
      Il2CppClassPointerStore<ControlsVisualMapping.AnalogMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (AnalogMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsVisualMapping.AnalogMapping>.NativeClassPtr);
      ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.AnalogMapping>.NativeClassPtr, nameof (AnalogText));
      ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.AnalogMapping>.NativeClassPtr, nameof (AnalogKey));
      ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.AnalogMapping>.NativeClassPtr, nameof (AnalogSprite));
    }

    public AnalogMapping(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AnalogMapping()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ControlsVisualMapping.AnalogMapping>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlsVisualMapping.AnalogMapping>.NativeClassPtr, data));
    }

    public unsafe string AnalogText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey AnalogKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogKey)) = value;
      }
    }

    public unsafe Sprite AnalogSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControlsVisualMapping.AnalogMapping.NativeFieldInfoPtr_AnalogSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct InputFlagMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InputFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_Input;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputFlagKey;
    [FieldOffset(0)]
    public long InputFlag;
    [FieldOffset(8)]
    public long Input;
    [FieldOffset(16)]
    public LocalizationKey InputFlagKey;

    static InputFlagMapping()
    {
      Il2CppClassPointerStore<ControlsVisualMapping.InputFlagMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (InputFlagMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsVisualMapping.InputFlagMapping>.NativeClassPtr);
      ControlsVisualMapping.InputFlagMapping.NativeFieldInfoPtr_InputFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.InputFlagMapping>.NativeClassPtr, nameof (InputFlag));
      ControlsVisualMapping.InputFlagMapping.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.InputFlagMapping>.NativeClassPtr, nameof (Input));
      ControlsVisualMapping.InputFlagMapping.NativeFieldInfoPtr_InputFlagKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.InputFlagMapping>.NativeClassPtr, nameof (InputFlagKey));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlsVisualMapping.InputFlagMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct AnalogInputMapping
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsPositive;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnalogInputKey;
    [FieldOffset(0)]
    public long AnalogInput;
    [FieldOffset(8)]
    public bool IsPositive;
    [FieldOffset(12)]
    public LocalizationKey AnalogInputKey;

    static AnalogInputMapping()
    {
      Il2CppClassPointerStore<ControlsVisualMapping.AnalogInputMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlsVisualMapping>.NativeClassPtr, nameof (AnalogInputMapping));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsVisualMapping.AnalogInputMapping>.NativeClassPtr);
      ControlsVisualMapping.AnalogInputMapping.NativeFieldInfoPtr_AnalogInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.AnalogInputMapping>.NativeClassPtr, nameof (AnalogInput));
      ControlsVisualMapping.AnalogInputMapping.NativeFieldInfoPtr_IsPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.AnalogInputMapping>.NativeClassPtr, nameof (IsPositive));
      ControlsVisualMapping.AnalogInputMapping.NativeFieldInfoPtr_AnalogInputKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsVisualMapping.AnalogInputMapping>.NativeClassPtr, nameof (AnalogInputKey));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlsVisualMapping.AnalogInputMapping>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
