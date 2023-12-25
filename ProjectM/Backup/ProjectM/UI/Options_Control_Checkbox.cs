// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Options_Control_Checkbox
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class Options_Control_Checkbox : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_Toggle;
    private static readonly IntPtr NativeFieldInfoPtr_UISoundMapping;
    private static readonly IntPtr NativeFieldInfoPtr_ClickSound;
    private static readonly IntPtr NativeFieldInfoPtr_HoverSound;
    private static readonly IntPtr NativeFieldInfoPtr__OnValueChange;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Boolean_UnityAction_1_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnValueChange_Private_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164226, XrefRangeEnd = 1164242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      bool initValue,
      UnityAction<bool> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &textKey;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &initValue;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Checkbox.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Boolean_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164242, XrefRangeEnd = 1164252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValueChange(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &newValue;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Checkbox.NativeMethodInfoPtr_OnValueChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Checkbox()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Checkbox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Options_Control_Checkbox()
    {
      Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (Options_Control_Checkbox));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr);
      Options_Control_Checkbox.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, nameof (Name));
      Options_Control_Checkbox.NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, nameof (Toggle));
      Options_Control_Checkbox.NativeFieldInfoPtr_UISoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, nameof (UISoundMapping));
      Options_Control_Checkbox.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, nameof (ClickSound));
      Options_Control_Checkbox.NativeFieldInfoPtr_HoverSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, nameof (HoverSound));
      Options_Control_Checkbox.NativeFieldInfoPtr__OnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, nameof (_OnValueChange));
      Options_Control_Checkbox.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Boolean_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, 100692589);
      Options_Control_Checkbox.NativeMethodInfoPtr_OnValueChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, 100692590);
      Options_Control_Checkbox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Checkbox>.NativeClassPtr, 100692591);
    }

    public Options_Control_Checkbox(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Name
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_Name));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle Toggle
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_Toggle));
        return pointer == IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_Toggle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundMapping UISoundMapping
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_UISoundMapping));
        return pointer == IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_UISoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType ClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_ClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_ClickSound)) = value;
      }
    }

    public unsafe UISoundType HoverSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_HoverSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr_HoverSound)) = value;
      }
    }

    public unsafe UnityAction<bool> _OnValueChange
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr__OnValueChange));
        return pointer == IntPtr.Zero ? (UnityAction<bool>) null : new UnityAction<bool>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Checkbox.NativeFieldInfoPtr__OnValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
