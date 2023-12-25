// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Options_Control_Dropdown
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class Options_Control_Dropdown : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Dropdown;
    private static readonly System.IntPtr NativeFieldInfoPtr_UISoundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverSound;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_List_1_String_Int32_UnityAction_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_List_1_Tuple_2_Guid_String_Int32_UnityAction_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetOptions_Public_Void_List_1_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1164261, RefRangeEnd = 1164273, XrefRangeStart = 1164252, XrefRangeEnd = 1164261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      List<string> options,
      int initialValue,
      UnityAction<int> onValueChanged)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initialValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Dropdown.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_List_1_String_Int32_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164273, XrefRangeEnd = 1164279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> options,
      int initialValue,
      UnityAction<int> onValueChanged)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &initialValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Dropdown.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_List_1_Tuple_2_Guid_String_Int32_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164283, RefRangeEnd = 1164284, XrefRangeStart = 1164279, XrefRangeEnd = 1164283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetOptions(List<string> options, int initialValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initialValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Dropdown.NativeMethodInfoPtr_SetOptions_Public_Void_List_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Dropdown()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Dropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Options_Control_Dropdown()
    {
      Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (Options_Control_Dropdown));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr);
      Options_Control_Dropdown.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, nameof (Name));
      Options_Control_Dropdown.NativeFieldInfoPtr_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, nameof (Dropdown));
      Options_Control_Dropdown.NativeFieldInfoPtr_UISoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, nameof (UISoundMapping));
      Options_Control_Dropdown.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, nameof (ClickSound));
      Options_Control_Dropdown.NativeFieldInfoPtr_HoverSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, nameof (HoverSound));
      Options_Control_Dropdown.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_List_1_String_Int32_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, 100692592);
      Options_Control_Dropdown.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_List_1_Tuple_2_Guid_String_Int32_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, 100692593);
      Options_Control_Dropdown.NativeMethodInfoPtr_SetOptions_Public_Void_List_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, 100692594);
      Options_Control_Dropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Dropdown>.NativeClassPtr, 100692595);
    }

    public Options_Control_Dropdown(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Dropdown Dropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_Dropdown));
        return pointer == System.IntPtr.Zero ? (TMP_Dropdown) null : new TMP_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_Dropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundMapping UISoundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_UISoundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_UISoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType ClickSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_ClickSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_ClickSound)) = value;
      }
    }

    public unsafe UISoundType HoverSound
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_HoverSound));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Dropdown.NativeFieldInfoPtr_HoverSound)) = value;
      }
    }
  }
}
