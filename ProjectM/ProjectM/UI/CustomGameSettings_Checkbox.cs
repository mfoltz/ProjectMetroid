// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CustomGameSettings_Checkbox
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CustomGameSettings_Checkbox : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Modified;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Toggle;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnValueChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_clickSoundType;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayClickSound_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Boolean_Boolean_Action_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_Nullable_Unboxed_1_LocalizationKey_Boolean_Boolean_Action_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Toggle_OnValueChange_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool Value
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1160937, RefRangeEnd = 1160938, XrefRangeStart = 1160937, XrefRangeEnd = 1160937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160938, XrefRangeEnd = 1160955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayClickSound()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.NativeMethodInfoPtr_PlayClickSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1161000, RefRangeEnd = 1161006, XrefRangeStart = 1160955, XrefRangeEnd = 1161000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      Nullable_Unboxed<LocalizationKey> tooltipKey,
      bool defValue,
      bool initValue,
      Il2CppSystem.Action<bool> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Boolean_Boolean_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1161050, RefRangeEnd = 1161051, XrefRangeStart = 1161006, XrefRangeEnd = 1161050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      string text,
      Nullable_Unboxed<LocalizationKey> tooltipKey,
      bool defValue,
      bool initValue,
      Il2CppSystem.Action<bool> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.NativeMethodInfoPtr_Initialize_Public_Void_String_Nullable_Unboxed_1_LocalizationKey_Boolean_Boolean_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1161055, RefRangeEnd = 1161059, XrefRangeStart = 1161051, XrefRangeEnd = 1161055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetModified(bool modified, bool initDiff)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &modified;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initDiff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161059, XrefRangeEnd = 1161062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Toggle_OnValueChange(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.NativeMethodInfoPtr_Toggle_OnValueChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Checkbox()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomGameSettings_Checkbox()
    {
      Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (CustomGameSettings_Checkbox));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr);
      CustomGameSettings_Checkbox.NativeFieldInfoPtr_Modified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (Modified));
      CustomGameSettings_Checkbox.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (HeaderText));
      CustomGameSettings_Checkbox.NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (Toggle));
      CustomGameSettings_Checkbox.NativeFieldInfoPtr_InfoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (InfoButton));
      CustomGameSettings_Checkbox.NativeFieldInfoPtr_ResetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (ResetButton));
      CustomGameSettings_Checkbox.NativeFieldInfoPtr__OnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (_OnValueChange));
      CustomGameSettings_Checkbox.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (soundMapping));
      CustomGameSettings_Checkbox.NativeFieldInfoPtr_clickSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, nameof (clickSoundType));
      CustomGameSettings_Checkbox.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, 100692318);
      CustomGameSettings_Checkbox.NativeMethodInfoPtr_PlayClickSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, 100692319);
      CustomGameSettings_Checkbox.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Boolean_Boolean_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, 100692320);
      CustomGameSettings_Checkbox.NativeMethodInfoPtr_Initialize_Public_Void_String_Nullable_Unboxed_1_LocalizationKey_Boolean_Boolean_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, 100692321);
      CustomGameSettings_Checkbox.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, 100692322);
      CustomGameSettings_Checkbox.NativeMethodInfoPtr_Toggle_OnValueChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, 100692323);
      CustomGameSettings_Checkbox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, 100692324);
    }

    public CustomGameSettings_Checkbox(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Modified
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_Modified));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_Modified), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle Toggle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_Toggle));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_Toggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InfoButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_InfoButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_InfoButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ResetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_ResetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_ResetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<bool> _OnValueChange
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr__OnValueChange));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : new Il2CppSystem.Action<bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr__OnValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundMapping soundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_soundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType clickSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_clickSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.NativeFieldInfoPtr_clickSoundType)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.CustomGameSettings_Checkbox/<>c__DisplayClass11_0")]
    public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass11_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160935, XrefRangeEnd = 1160937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Initialize_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass11_0>.NativeClassPtr);
        CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
        CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass11_0>.NativeClassPtr, nameof (defValue));
        CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass11_0>.NativeClassPtr, 100692325);
        CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass11_0>.NativeClassPtr, 100692326);
      }

      public __c__DisplayClass11_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CustomGameSettings_Checkbox __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool defValue
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass11_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.CustomGameSettings_Checkbox/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Initialize_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomGameSettings_Checkbox>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass12_0>.NativeClassPtr);
        CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
        CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass12_0>.NativeClassPtr, nameof (defValue));
        CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass12_0>.NativeClassPtr, 100692327);
        CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Checkbox.__c__DisplayClass12_0>.NativeClassPtr, 100692328);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CustomGameSettings_Checkbox __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Checkbox) null : new CustomGameSettings_Checkbox(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool defValue
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Checkbox.__c__DisplayClass12_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }
    }
  }
}
