// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SimpleStunButton
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Stunlock.Fmod;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class SimpleStunButton : SimpleStunSelectable
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableHoverOnDisable;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OnClick;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OnDoubleClick;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SoundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClickSoundType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HoverSoundType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClickSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HoverSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalTooltipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledTooltipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TooltipAnchor;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TooltipPivot;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TooltipOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisableTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NoDisabledTooltip;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnBeginDragAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEndDragAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDropAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHovered;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalTooltipText_Public_get_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NormalTooltipText_Public_set_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisabledTooltipText_Public_get_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DisabledTooltipText_Public_set_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisableTooltip_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DoDisabledTooltip_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_onDoubleClick_Public_get_ButtonClickedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_onDoubleClick_Public_set_Void_ButtonClickedEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTooltipPosition_Private_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Press_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayClickSound_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

    public unsafe LocalizationKey NormalTooltipText
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_get_NormalTooltipText_Public_get_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_set_NormalTooltipText_Public_set_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LocalizationKey DisabledTooltipText
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_get_DisabledTooltipText_Public_get_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_set_DisabledTooltipText_Public_set_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool DisableTooltip
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_get_DisableTooltip_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool DoDisabledTooltip
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_get_DoDisabledTooltip_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795400, RefRangeEnd = 795401, XrefRangeStart = 795383, XrefRangeEnd = 795400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SimpleStunButton()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe SimpleStunButton.ButtonClickedEvent onClick
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SimpleStunButton.ButtonClickedEvent) null : new SimpleStunButton.ButtonClickedEvent(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SimpleStunButton.ButtonClickedEvent onDoubleClick
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_get_onDoubleClick_Public_get_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SimpleStunButton.ButtonClickedEvent) null : new SimpleStunButton.ButtonClickedEvent(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_set_onDoubleClick_Public_set_Void_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795401, XrefRangeEnd = 795407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795407, XrefRangeEnd = 795408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimpleStunButton.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795408, XrefRangeEnd = 795410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetTooltipPosition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_GetTooltipPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 795415, RefRangeEnd = 795417, XrefRangeStart = 795410, XrefRangeEnd = 795415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Press()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795442, RefRangeEnd = 795443, XrefRangeStart = 795417, XrefRangeEnd = 795442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayClickSound()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_PlayClickSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795443, XrefRangeEnd = 795448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimpleStunButton.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795448, XrefRangeEnd = 795455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnSubmit(BaseEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimpleStunButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795475, RefRangeEnd = 795476, XrefRangeStart = 795455, XrefRangeEnd = 795475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimpleStunButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795477, RefRangeEnd = 795478, XrefRangeStart = 795476, XrefRangeEnd = 795477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimpleStunButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795478, XrefRangeEnd = 795483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator OnFinishSubmit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795483, XrefRangeEnd = 795486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDrop(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnDrag(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795486, XrefRangeEnd = 795489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnBeginDrag(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SimpleStunButton()
    {
      Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (SimpleStunButton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr);
      SimpleStunButton.NativeFieldInfoPtr_DisableHoverOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (DisableHoverOnDisable));
      SimpleStunButton.NativeFieldInfoPtr_m_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_OnClick));
      SimpleStunButton.NativeFieldInfoPtr_m_OnDoubleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_OnDoubleClick));
      SimpleStunButton.NativeFieldInfoPtr_m_SoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_SoundMapping));
      SimpleStunButton.NativeFieldInfoPtr_m_ClickSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_ClickSoundType));
      SimpleStunButton.NativeFieldInfoPtr_m_HoverSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_HoverSoundType));
      SimpleStunButton.NativeFieldInfoPtr_m_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_ClickSound));
      SimpleStunButton.NativeFieldInfoPtr_m_HoverSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_HoverSound));
      SimpleStunButton.NativeFieldInfoPtr_m_NormalTooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_NormalTooltipText));
      SimpleStunButton.NativeFieldInfoPtr_m_DisabledTooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_DisabledTooltipText));
      SimpleStunButton.NativeFieldInfoPtr_m_TooltipAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_TooltipAnchor));
      SimpleStunButton.NativeFieldInfoPtr_m_TooltipPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_TooltipPivot));
      SimpleStunButton.NativeFieldInfoPtr_m_TooltipOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_TooltipOffset));
      SimpleStunButton.NativeFieldInfoPtr_m_DisableTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_DisableTooltip));
      SimpleStunButton.NativeFieldInfoPtr_m_NoDisabledTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (m_NoDisabledTooltip));
      SimpleStunButton.NativeFieldInfoPtr_OnBeginDragAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (OnBeginDragAction));
      SimpleStunButton.NativeFieldInfoPtr_OnEndDragAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (OnEndDragAction));
      SimpleStunButton.NativeFieldInfoPtr_OnDropAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (OnDropAction));
      SimpleStunButton.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (IsHovered));
      SimpleStunButton.NativeMethodInfoPtr_get_NormalTooltipText_Public_get_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670171);
      SimpleStunButton.NativeMethodInfoPtr_set_NormalTooltipText_Public_set_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670172);
      SimpleStunButton.NativeMethodInfoPtr_get_DisabledTooltipText_Public_get_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670173);
      SimpleStunButton.NativeMethodInfoPtr_set_DisabledTooltipText_Public_set_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670174);
      SimpleStunButton.NativeMethodInfoPtr_get_DisableTooltip_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670175);
      SimpleStunButton.NativeMethodInfoPtr_get_DoDisabledTooltip_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670176);
      SimpleStunButton.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670177);
      SimpleStunButton.NativeMethodInfoPtr_get_onClick_Public_get_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670178);
      SimpleStunButton.NativeMethodInfoPtr_set_onClick_Public_set_Void_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670179);
      SimpleStunButton.NativeMethodInfoPtr_get_onDoubleClick_Public_get_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670180);
      SimpleStunButton.NativeMethodInfoPtr_set_onDoubleClick_Public_set_Void_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670181);
      SimpleStunButton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670182);
      SimpleStunButton.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670183);
      SimpleStunButton.NativeMethodInfoPtr_GetTooltipPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670184);
      SimpleStunButton.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670185);
      SimpleStunButton.NativeMethodInfoPtr_PlayClickSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670186);
      SimpleStunButton.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670187);
      SimpleStunButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670188);
      SimpleStunButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670189);
      SimpleStunButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670190);
      SimpleStunButton.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670191);
      SimpleStunButton.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670192);
      SimpleStunButton.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670193);
      SimpleStunButton.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, 100670194);
    }

    public SimpleStunButton(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool DisableHoverOnDisable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_DisableHoverOnDisable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_DisableHoverOnDisable)) = value;
      }
    }

    public unsafe SimpleStunButton.ButtonClickedEvent m_OnClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_OnClick));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton.ButtonClickedEvent) null : new SimpleStunButton.ButtonClickedEvent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_OnClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton.ButtonClickedEvent m_OnDoubleClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_OnDoubleClick));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton.ButtonClickedEvent) null : new SimpleStunButton.ButtonClickedEvent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_OnDoubleClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundMapping m_SoundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_SoundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_SoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType m_ClickSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_ClickSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_ClickSoundType)) = value;
      }
    }

    public unsafe UISoundType m_HoverSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_HoverSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_HoverSoundType)) = value;
      }
    }

    public FmodEvent m_ClickSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_ClickSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_ClickSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public FmodEvent m_HoverSound
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_HoverSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_HoverSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey m_NormalTooltipText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_NormalTooltipText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_NormalTooltipText)) = value;
      }
    }

    public unsafe LocalizationKey m_DisabledTooltipText
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_DisabledTooltipText));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_DisabledTooltipText)) = value;
      }
    }

    public unsafe PivotPresets m_TooltipAnchor
    {
      get
      {
        return *(PivotPresets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_TooltipAnchor));
      }
      [param: In] set
      {
        *(PivotPresets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_TooltipAnchor)) = value;
      }
    }

    public unsafe PivotPresets m_TooltipPivot
    {
      get
      {
        return *(PivotPresets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_TooltipPivot));
      }
      [param: In] set
      {
        *(PivotPresets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_TooltipPivot)) = value;
      }
    }

    public unsafe Vector2 m_TooltipOffset
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_TooltipOffset));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_TooltipOffset)) = value;
      }
    }

    public unsafe bool m_DisableTooltip
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_DisableTooltip));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_DisableTooltip)) = value;
      }
    }

    public unsafe bool m_NoDisabledTooltip
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_NoDisabledTooltip));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_m_NoDisabledTooltip)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<SimpleStunButton> OnBeginDragAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_OnBeginDragAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SimpleStunButton>) null : new Il2CppSystem.Action<SimpleStunButton>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_OnBeginDragAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<SimpleStunButton> OnEndDragAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_OnEndDragAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SimpleStunButton>) null : new Il2CppSystem.Action<SimpleStunButton>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_OnEndDragAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<SimpleStunButton> OnDropAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_OnDropAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SimpleStunButton>) null : new Il2CppSystem.Action<SimpleStunButton>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_OnDropAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsHovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_IsHovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton.NativeFieldInfoPtr_IsHovered)) = value;
      }
    }

    [Serializable]
    public class ButtonClickedEvent : UnityEvent
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 307906, RefRangeEnd = 307911, XrefRangeStart = 307906, XrefRangeEnd = 307911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ButtonClickedEvent()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleStunButton.ButtonClickedEvent>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton.ButtonClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ButtonClickedEvent()
      {
        Il2CppClassPointerStore<SimpleStunButton.ButtonClickedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, nameof (ButtonClickedEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleStunButton.ButtonClickedEvent>.NativeClassPtr);
        SimpleStunButton.ButtonClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton.ButtonClickedEvent>.NativeClassPtr, 100670195);
      }

      public ButtonClickedEvent(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("ProjectM.UI.SimpleStunButton/<OnFinishSubmit>d__46")]
    public sealed class _OnFinishSubmit_d__46 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__fadeTime_5__2;
      private static readonly System.IntPtr NativeFieldInfoPtr__elapsedTime_5__3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(77)]
      [CachedScanResults(RefRangeStart = 23421, RefRangeEnd = 23498, XrefRangeStart = 23421, XrefRangeEnd = 23498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _OnFinishSubmit_d__46(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &_param1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795378, XrefRangeEnd = 795383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _OnFinishSubmit_d__46()
      {
        Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleStunButton>.NativeClassPtr, "<OnFinishSubmit>d__46");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr);
        SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, "<>1__state");
        SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, "<>2__current");
        SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, "<>4__this");
        SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr__fadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, "<fadeTime>5__2");
        SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr__elapsedTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, "<elapsedTime>5__3");
        SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, 100670196);
        SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, 100670197);
        SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, 100670198);
        SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, 100670199);
        SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, 100670200);
        SimpleStunButton._OnFinishSubmit_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunButton._OnFinishSubmit_d__46>.NativeClassPtr, 100670201);
      }

      public _OnFinishSubmit_d__46(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SimpleStunButton __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float _fadeTime_5__2
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr__fadeTime_5__2));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr__fadeTime_5__2)) = value;
        }
      }

      public unsafe float _elapsedTime_5__3
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr__elapsedTime_5__3));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunButton._OnFinishSubmit_d__46.NativeFieldInfoPtr__elapsedTime_5__3)) = value;
        }
      }
    }
  }
}
