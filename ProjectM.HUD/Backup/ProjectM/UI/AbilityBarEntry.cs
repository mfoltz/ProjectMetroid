// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AbilityBarEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Entities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class AbilityBarEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownText;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownFillImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManaFillImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeybindText;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeybindImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargesText;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIconImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_EmptyAblityIconImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargesCooldownImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_GreyScaleMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManaCooldownColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpFillImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentUIState;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsHovered_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHovered_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Nullable_Unboxed_1_Single_InputSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateState_Private_Void_byref_UIState_InputSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool IsHovered
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_set_IsHovered_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212121, XrefRangeEnd = 1212152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 1212208, RefRangeEnd = 1212219, XrefRangeStart = 1212152, XrefRangeEnd = 1212208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      [In] ref AbilityBarEntry.Data data,
      Nullable_Unboxed<float> currentMana,
      InputSystem inputSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentMana;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Nullable_Unboxed_1_Single_InputSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1212264, RefRangeEnd = 1212265, XrefRangeStart = 1212219, XrefRangeEnd = 1212264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateState(ref AbilityBarEntry.UIState newState, InputSystem inputSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) newState);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr_UpdateState_Private_Void_byref_UIState_InputSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityBarEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBarEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityBarEntry()
    {
      Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AbilityBarEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr);
      AbilityBarEntry.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (Alpha));
      AbilityBarEntry.NativeFieldInfoPtr_CooldownText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (CooldownText));
      AbilityBarEntry.NativeFieldInfoPtr_CooldownFillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (CooldownFillImage));
      AbilityBarEntry.NativeFieldInfoPtr_ManaFillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (ManaFillImage));
      AbilityBarEntry.NativeFieldInfoPtr_KeybindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (KeybindText));
      AbilityBarEntry.NativeFieldInfoPtr_KeybindImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (KeybindImage));
      AbilityBarEntry.NativeFieldInfoPtr_ChargesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (ChargesText));
      AbilityBarEntry.NativeFieldInfoPtr_AbilityIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (AbilityIconImage));
      AbilityBarEntry.NativeFieldInfoPtr_EmptyAblityIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (EmptyAblityIconImage));
      AbilityBarEntry.NativeFieldInfoPtr_ChargesCooldownImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (ChargesCooldownImage));
      AbilityBarEntry.NativeFieldInfoPtr_GreyScaleMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (GreyScaleMaterial));
      AbilityBarEntry.NativeFieldInfoPtr_ManaCooldownColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (ManaCooldownColor));
      AbilityBarEntry.NativeFieldInfoPtr_ChargeUpFillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (ChargeUpFillImage));
      AbilityBarEntry.NativeFieldInfoPtr_TooltipEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (TooltipEntity));
      AbilityBarEntry.NativeFieldInfoPtr_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (TooltipAnchor));
      AbilityBarEntry.NativeFieldInfoPtr__CurrentUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (_CurrentUIState));
      AbilityBarEntry.NativeFieldInfoPtr__IsHovered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, "<IsHovered>k__BackingField");
      AbilityBarEntry.NativeFieldInfoPtr_AbilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (AbilityId));
      AbilityBarEntry.NativeFieldInfoPtr_AbilityEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (AbilityEntity));
      AbilityBarEntry.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663832);
      AbilityBarEntry.NativeMethodInfoPtr_set_IsHovered_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663833);
      AbilityBarEntry.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663834);
      AbilityBarEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663835);
      AbilityBarEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663836);
      AbilityBarEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663837);
      AbilityBarEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_Nullable_Unboxed_1_Single_InputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663838);
      AbilityBarEntry.NativeMethodInfoPtr_UpdateState_Private_Void_byref_UIState_InputSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663839);
      AbilityBarEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, 100663840);
    }

    public AbilityBarEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup Alpha
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_Alpha));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_Alpha), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI CooldownText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_CooldownText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_CooldownText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image CooldownFillImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_CooldownFillImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_CooldownFillImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ManaFillImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ManaFillImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ManaFillImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI KeybindText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_KeybindText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_KeybindText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image KeybindImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_KeybindImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_KeybindImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI ChargesText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ChargesText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ChargesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image AbilityIconImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_AbilityIconImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_AbilityIconImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image EmptyAblityIconImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_EmptyAblityIconImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_EmptyAblityIconImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ChargesCooldownImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ChargesCooldownImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ChargesCooldownImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material GreyScaleMaterial
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_GreyScaleMaterial));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_GreyScaleMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color ManaCooldownColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ManaCooldownColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ManaCooldownColor)) = value;
      }
    }

    public unsafe Image ChargeUpFillImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ChargeUpFillImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_ChargeUpFillImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity TooltipEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_TooltipEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_TooltipEntity)) = value;
      }
    }

    public unsafe RectTransform TooltipAnchor
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_TooltipAnchor));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_TooltipAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public AbilityBarEntry.UIState _CurrentUIState
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr__CurrentUIState);
        return new AbilityBarEntry.UIState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr__CurrentUIState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _IsHovered_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr__IsHovered_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr__IsHovered_k__BackingField)) = value;
      }
    }

    public unsafe PrefabGUID AbilityId
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_AbilityId));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_AbilityId)) = value;
      }
    }

    public unsafe Entity AbilityEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_AbilityEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.NativeFieldInfoPtr_AbilityEntity)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ManaCost;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemainingCooldown;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxCooldown;
      private static readonly System.IntPtr NativeFieldInfoPtr_ModifierKeybind;
      private static readonly System.IntPtr NativeFieldInfoPtr_KeyBind;
      private static readonly System.IntPtr NativeFieldInfoPtr_Charges;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChargeTimeFill;
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityId;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityEntity;

      static Data()
      {
        Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr);
        AbilityBarEntry.Data.NativeFieldInfoPtr_ManaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (ManaCost));
        AbilityBarEntry.Data.NativeFieldInfoPtr_RemainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (RemainingCooldown));
        AbilityBarEntry.Data.NativeFieldInfoPtr_MaxCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (MaxCooldown));
        AbilityBarEntry.Data.NativeFieldInfoPtr_ModifierKeybind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (ModifierKeybind));
        AbilityBarEntry.Data.NativeFieldInfoPtr_KeyBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (KeyBind));
        AbilityBarEntry.Data.NativeFieldInfoPtr_Charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (Charges));
        AbilityBarEntry.Data.NativeFieldInfoPtr_ChargeTimeFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (ChargeTimeFill));
        AbilityBarEntry.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (Icon));
        AbilityBarEntry.Data.NativeFieldInfoPtr_AbilityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (AbilityId));
        AbilityBarEntry.Data.NativeFieldInfoPtr_AbilityEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, nameof (AbilityEntity));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBarEntry.Data>.NativeClassPtr, data));
      }

      public unsafe Nullable_Unboxed<float> ManaCost
      {
        get
        {
          return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_ManaCost));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_ManaCost), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe float RemainingCooldown
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_RemainingCooldown));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_RemainingCooldown)) = value;
        }
      }

      public unsafe float MaxCooldown
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_MaxCooldown));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_MaxCooldown)) = value;
        }
      }

      public unsafe InputFlag ModifierKeybind
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_ModifierKeybind));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_ModifierKeybind)) = value;
        }
      }

      public unsafe InputFlag KeyBind
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_KeyBind));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_KeyBind)) = value;
        }
      }

      public unsafe Nullable_Unboxed<int> Charges
      {
        get
        {
          return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_Charges));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_Charges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Nullable_Unboxed<float> ChargeTimeFill
      {
        get
        {
          return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_ChargeTimeFill));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_ChargeTimeFill), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID AbilityId
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_AbilityId));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_AbilityId)) = value;
        }
      }

      public unsafe Entity AbilityEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_AbilityEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.Data.NativeFieldInfoPtr_AbilityEntity)) = value;
        }
      }
    }

    public sealed class UIState : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIconImageMaterial;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIconImageSprite;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChargesText;
      private static readonly System.IntPtr NativeFieldInfoPtr_CooldownText;
      private static readonly System.IntPtr NativeFieldInfoPtr_CooldownTextColor;
      private static readonly System.IntPtr NativeFieldInfoPtr_ModifierKeybind;
      private static readonly System.IntPtr NativeFieldInfoPtr_KeyBind;
      private static readonly System.IntPtr NativeFieldInfoPtr_CachedInputVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameObjectActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_ManaFillImageActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChargesTextActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChargesCooldownActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChargesCooldownImageActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpFillImageActive;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIconImageActive;

      static UIState()
      {
        Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityBarEntry>.NativeClassPtr, nameof (UIState));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr);
        AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (AbilityIconImageMaterial));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (AbilityIconImageSprite));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (ChargesText));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_CooldownText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (CooldownText));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_CooldownTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (CooldownTextColor));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_ModifierKeybind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (ModifierKeybind));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_KeyBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (KeyBind));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_CachedInputVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (CachedInputVersion));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_GameObjectActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (GameObjectActive));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_ManaFillImageActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (ManaFillImageActive));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesTextActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (ChargesTextActive));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesCooldownActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (ChargesCooldownActive));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesCooldownImageActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (ChargesCooldownImageActive));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargeUpFillImageActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (ChargeUpFillImageActive));
        AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, nameof (AbilityIconImageActive));
      }

      public UIState(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public UIState()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBarEntry.UIState>.NativeClassPtr, data));
      }

      public unsafe Material AbilityIconImageMaterial
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageMaterial));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Sprite AbilityIconImageSprite
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageSprite));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string ChargesText
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesText)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesText), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string CooldownText
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_CooldownText)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_CooldownText), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Color CooldownTextColor
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_CooldownTextColor));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_CooldownTextColor)) = value;
        }
      }

      public unsafe InputFlag ModifierKeybind
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ModifierKeybind));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ModifierKeybind)) = value;
        }
      }

      public unsafe InputFlag KeyBind
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_KeyBind));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_KeyBind)) = value;
        }
      }

      public unsafe int CachedInputVersion
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_CachedInputVersion));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_CachedInputVersion)) = value;
        }
      }

      public unsafe bool GameObjectActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_GameObjectActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_GameObjectActive)) = value;
        }
      }

      public unsafe bool ManaFillImageActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ManaFillImageActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ManaFillImageActive)) = value;
        }
      }

      public unsafe bool ChargesTextActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesTextActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesTextActive)) = value;
        }
      }

      public unsafe bool ChargesCooldownActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesCooldownActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesCooldownActive)) = value;
        }
      }

      public unsafe bool ChargesCooldownImageActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesCooldownImageActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargesCooldownImageActive)) = value;
        }
      }

      public unsafe bool ChargeUpFillImageActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargeUpFillImageActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_ChargeUpFillImageActive)) = value;
        }
      }

      public unsafe bool AbilityIconImageActive
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageActive));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityBarEntry.UIState.NativeFieldInfoPtr_AbilityIconImageActive)) = value;
        }
      }
    }
  }
}
