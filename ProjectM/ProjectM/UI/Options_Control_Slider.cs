// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.Options_Control_Slider
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class Options_Control_Slider : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slider;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnValueChange;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisplayValueTransformer;
    private static readonly System.IntPtr NativeFieldInfoPtr__ValueString;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChange_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1164316, RefRangeEnd = 1164328, XrefRangeStart = 1164284, XrefRangeEnd = 1164316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      LocalizationKey valueKey,
      float minValue,
      float maxValue,
      float initValue,
      UnityAction<float> onValueChange,
      Il2CppSystem.Func<float, float> displayValueTransformer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayValueTransformer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Slider.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164328, XrefRangeEnd = 1164343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValueChange(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Slider.NativeMethodInfoPtr_OnValueChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Slider()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Options_Control_Slider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Options_Control_Slider()
    {
      Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (Options_Control_Slider));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr);
      Options_Control_Slider.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, nameof (Name));
      Options_Control_Slider.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, nameof (Value));
      Options_Control_Slider.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, nameof (Slider));
      Options_Control_Slider.NativeFieldInfoPtr__OnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, nameof (_OnValueChange));
      Options_Control_Slider.NativeFieldInfoPtr__DisplayValueTransformer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, nameof (_DisplayValueTransformer));
      Options_Control_Slider.NativeFieldInfoPtr__ValueString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, nameof (_ValueString));
      Options_Control_Slider.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, 100692596);
      Options_Control_Slider.NativeMethodInfoPtr_OnValueChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, 100692597);
      Options_Control_Slider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Options_Control_Slider>.NativeClassPtr, 100692598);
    }

    public Options_Control_Slider(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Value
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr_Value));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Slider Slider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr_Slider));
        return pointer == System.IntPtr.Zero ? (Slider) null : new Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityAction<float> _OnValueChange
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr__OnValueChange));
        return pointer == System.IntPtr.Zero ? (UnityAction<float>) null : new UnityAction<float>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr__OnValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<float, float> _DisplayValueTransformer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr__DisplayValueTransformer));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<float, float>) null : new Il2CppSystem.Func<float, float>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr__DisplayValueTransformer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedString _ValueString
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr__ValueString);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Options_Control_Slider.NativeFieldInfoPtr__ValueString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
