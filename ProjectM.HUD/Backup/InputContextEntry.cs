// Decompiled with JetBrains decompiler
// Type: InputContextEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class InputContextEntry : UIEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_KeybindImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_KeybindText;
  private static readonly System.IntPtr NativeFieldInfoPtr_ActionText;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 1205958, RefRangeEnd = 1205978, XrefRangeStart = 1205931, XrefRangeEnd = 1205958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(InputContextEntry.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputContextEntry.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(41)]
  [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputContextEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputContextEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InputContextEntry()
  {
    Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (InputContextEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr);
    InputContextEntry.NativeFieldInfoPtr_KeybindImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr, nameof (KeybindImage));
    InputContextEntry.NativeFieldInfoPtr_KeybindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr, nameof (KeybindText));
    InputContextEntry.NativeFieldInfoPtr_ActionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr, nameof (ActionText));
    InputContextEntry.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr, 100663364);
    InputContextEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr, 100663365);
  }

  public InputContextEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image KeybindImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.NativeFieldInfoPtr_KeybindImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.NativeFieldInfoPtr_KeybindImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText KeybindText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.NativeFieldInfoPtr_KeybindText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.NativeFieldInfoPtr_KeybindText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText ActionText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.NativeFieldInfoPtr_ActionText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.NativeFieldInfoPtr_ActionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Data : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_KeybindImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeybindText;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActionKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color;

    static Data()
    {
      Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputContextEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr);
      InputContextEntry.Data.NativeFieldInfoPtr_KeybindImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr, nameof (KeybindImage));
      InputContextEntry.Data.NativeFieldInfoPtr_KeybindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr, nameof (KeybindText));
      InputContextEntry.Data.NativeFieldInfoPtr_ActionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr, nameof (ActionKey));
      InputContextEntry.Data.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr, nameof (Value));
      InputContextEntry.Data.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr, nameof (Color));
    }

    public Data(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Data()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputContextEntry.Data>.NativeClassPtr, data));
    }

    public unsafe Sprite KeybindImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_KeybindImage));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_KeybindImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string KeybindText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_KeybindText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_KeybindText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe LocalizationKey ActionKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_ActionKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_ActionKey)) = value;
      }
    }

    public unsafe Nullable_Unboxed<float> Value
    {
      get
      {
        return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_Value));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Color Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextEntry.Data.NativeFieldInfoPtr_Color)) = value;
      }
    }
  }
}
