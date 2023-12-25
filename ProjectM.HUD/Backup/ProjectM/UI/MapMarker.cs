// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapMarker
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class MapMarker : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Highlight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sieged;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerSprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_Sprite_CastleDecay;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_DecayedCastle;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_CastleDecay;
    private static readonly System.IntPtr NativeFieldInfoPtr_HighlightAnimator;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextElement1;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextElement2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label2;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hover;
    private static readonly System.IntPtr NativeFieldInfoPtr__DrawMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__IconData;
    private static readonly System.IntPtr NativeFieldInfoPtr__IconStates;
    private static readonly System.IntPtr NativeFieldInfoPtr__Reset;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnClick;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnHover;
    private static readonly System.IntPtr NativeFieldInfoPtr__RaycastResults;
    private static readonly System.IntPtr NativeFieldInfoPtr__PointerData;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TransitionToHover_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TransitionToStandard_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Vector3_Quaternion_ManagedMapIconData_MapIconData_LabelOverrides_Boolean_MapIconDrawMode_Nullable_Unboxed_1_Single_MapIconClickAction_Action_1_Boolean_Boolean_Boolean_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_Vector3_Rotation_ManagedMapIconData_MapIconData_LabelOverrides_Boolean_MapIconDrawMode_Nullable_Unboxed_1_Single_MapIconClickAction_Boolean_Boolean_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetIconData_Private_Void_ManagedMapIconData_MapIconDrawMode_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckReset_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIconStatesDataFrom_Private_MapIconStates_MapIconDrawMode_ManagedMapIconData_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeMapIconOverrideState_Private_MapIconOverrideState_MapIconState_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeMapIconOverrideState_Private_MapIconOverrideState_MapIconState_MapIconOverrideState_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetIconState_Private_Boolean_MapIconDrawMode_ManagedMapIconData_Sprite_byref_MapIconStates_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267774, XrefRangeEnd = 1267777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267777, XrefRangeEnd = 1267780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267780, XrefRangeEnd = 1267792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1267794, RefRangeEnd = 1267795, XrefRangeStart = 1267792, XrefRangeEnd = 1267794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TransitionToHover(bool instant = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &instant;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_TransitionToHover_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1267797, RefRangeEnd = 1267799, XrefRangeStart = 1267795, XrefRangeEnd = 1267797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TransitionToStandard(bool instant = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &instant;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_TransitionToStandard_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1267906, RefRangeEnd = 1267908, XrefRangeStart = 1267799, XrefRangeEnd = 1267906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      Vector3 anchoredPosition,
      Quaternion iconRotation,
      ManagedMapIconData managedMapIconData,
      MapIconData mapIconData,
      LabelOverrides labelOverrides,
      bool showLabelIfExists,
      MapIconDrawMode mapIconDrawMode,
      Nullable_Unboxed<float> alphaOverride,
      MapIconClickAction onClick = null,
      Il2CppSystem.Action<bool> onHover = null,
      bool isMinimap = true,
      bool showSiege = false,
      Sprite overridenCastleIcon = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[13];
      numPtr[0] = (System.IntPtr) &anchoredPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &iconRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedMapIconData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mapIconData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &labelOverrides;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &showLabelIfExists;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &mapIconDrawMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &alphaOverride;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) onClick));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onHover);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &isMinimap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &showSiege;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overridenCastleIcon);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_SetData_Public_Void_Vector3_Quaternion_ManagedMapIconData_MapIconData_LabelOverrides_Boolean_MapIconDrawMode_Nullable_Unboxed_1_Single_MapIconClickAction_Action_1_Boolean_Boolean_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267908, XrefRangeEnd = 1267916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      Vector3 anchoredPosition,
      Rotation rotationInWorld,
      ManagedMapIconData managedMapIconData,
      MapIconData mapIconData,
      LabelOverrides labelOverrides,
      bool showLabelIfExists,
      MapIconDrawMode mapIconDrawMode,
      Nullable_Unboxed<float> alphaOverride,
      MapIconClickAction onClickAction = null,
      bool isMinimap = true,
      bool showSiege = false,
      Sprite overridenCastleIcon = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &anchoredPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotationInWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedMapIconData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mapIconData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &labelOverrides;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &showLabelIfExists;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &mapIconDrawMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &alphaOverride;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) onClickAction));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &isMinimap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &showSiege;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overridenCastleIcon);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_SetData_Public_Void_Vector3_Rotation_ManagedMapIconData_MapIconData_LabelOverrides_Boolean_MapIconDrawMode_Nullable_Unboxed_1_Single_MapIconClickAction_Boolean_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1267928, RefRangeEnd = 1267929, XrefRangeStart = 1267916, XrefRangeEnd = 1267928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetIconData(
      ManagedMapIconData mapIconData,
      MapIconDrawMode iconDrawMode,
      Sprite overridenCastleIcon)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapIconData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &iconDrawMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overridenCastleIcon);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_SetIconData_Private_Void_ManagedMapIconData_MapIconDrawMode_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267929, XrefRangeEnd = 1267931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckReset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_CheckReset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1267960, RefRangeEnd = 1267962, XrefRangeStart = 1267931, XrefRangeEnd = 1267960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_IsHovered_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267962, XrefRangeEnd = 1267969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapIconStates GetIconStatesDataFrom(
      MapIconDrawMode iconDrawMode,
      ManagedMapIconData iconData,
      Sprite overridenCastleIcon)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &iconDrawMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) iconData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overridenCastleIcon);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_GetIconStatesDataFrom_Private_MapIconStates_MapIconDrawMode_ManagedMapIconData_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new MapIconStates(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1267979, RefRangeEnd = 1267983, XrefRangeStart = 1267969, XrefRangeEnd = 1267979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapIconOverrideState MakeMapIconOverrideState(
      MapIconState state,
      Sprite overridenCastleIcon)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overridenCastleIcon);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_MakeMapIconOverrideState_Private_MapIconOverrideState_MapIconState_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new MapIconOverrideState(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1268006, RefRangeEnd = 1268008, XrefRangeStart = 1267983, XrefRangeEnd = 1268006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapIconOverrideState MakeMapIconOverrideState(
      MapIconState state,
      MapIconOverrideState stateOverride,
      Sprite overridenCastleIcon)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) stateOverride));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overridenCastleIcon);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_MakeMapIconOverrideState_Private_MapIconOverrideState_MapIconState_MapIconOverrideState_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new MapIconOverrideState(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1268015, RefRangeEnd = 1268017, XrefRangeStart = 1268008, XrefRangeEnd = 1268015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetIconState(
      MapIconDrawMode iconDrawMode,
      ManagedMapIconData iconData,
      Sprite overridenCastleIcon,
      out MapIconStates mapIconStates)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &iconDrawMode;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) iconData);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) overridenCastleIcon);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr_TryGetIconState_Private_Boolean_MapIconDrawMode_ManagedMapIconData_Sprite_byref_MapIconStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref MapIconStates local = ref mapIconStates;
      System.IntPtr pointer = zero;
      MapIconStates mapIconStates1 = pointer == System.IntPtr.Zero ? (MapIconStates) null : new MapIconStates(pointer);
      local = mapIconStates1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268017, XrefRangeEnd = 1268028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapMarker()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapMarker>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapMarker()
    {
      Il2CppClassPointerStore<MapMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapMarker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapMarker>.NativeClassPtr);
      MapMarker.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (CanvasGroup));
      MapMarker.NativeFieldInfoPtr_PositionRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (PositionRect));
      MapMarker.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (Icon));
      MapMarker.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (Highlight));
      MapMarker.NativeFieldInfoPtr_Sieged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (Sieged));
      MapMarker.NativeFieldInfoPtr_PlayerSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (PlayerSprite));
      MapMarker.NativeFieldInfoPtr_Sprite_CastleDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (Sprite_CastleDecay));
      MapMarker.NativeFieldInfoPtr_LKey_DecayedCastle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (LKey_DecayedCastle));
      MapMarker.NativeFieldInfoPtr_Color_CastleDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (Color_CastleDecay));
      MapMarker.NativeFieldInfoPtr_HighlightAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (HighlightAnimator));
      MapMarker.NativeFieldInfoPtr_TextElement1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (TextElement1));
      MapMarker.NativeFieldInfoPtr_TextElement2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (TextElement2));
      MapMarker.NativeFieldInfoPtr_Label1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (Label1));
      MapMarker.NativeFieldInfoPtr_Label2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (Label2));
      MapMarker.NativeFieldInfoPtr__Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_Hover));
      MapMarker.NativeFieldInfoPtr__DrawMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_DrawMode));
      MapMarker.NativeFieldInfoPtr__IconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_IconData));
      MapMarker.NativeFieldInfoPtr__IconStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_IconStates));
      MapMarker.NativeFieldInfoPtr__Reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_Reset));
      MapMarker.NativeFieldInfoPtr__OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_OnClick));
      MapMarker.NativeFieldInfoPtr__OnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_OnHover));
      MapMarker.NativeFieldInfoPtr__RaycastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_RaycastResults));
      MapMarker.NativeFieldInfoPtr__PointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, nameof (_PointerData));
      MapMarker.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667712);
      MapMarker.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667713);
      MapMarker.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667714);
      MapMarker.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667715);
      MapMarker.NativeMethodInfoPtr_TransitionToHover_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667716);
      MapMarker.NativeMethodInfoPtr_TransitionToStandard_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667717);
      MapMarker.NativeMethodInfoPtr_SetData_Public_Void_Vector3_Quaternion_ManagedMapIconData_MapIconData_LabelOverrides_Boolean_MapIconDrawMode_Nullable_Unboxed_1_Single_MapIconClickAction_Action_1_Boolean_Boolean_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667718);
      MapMarker.NativeMethodInfoPtr_SetData_Public_Void_Vector3_Rotation_ManagedMapIconData_MapIconData_LabelOverrides_Boolean_MapIconDrawMode_Nullable_Unboxed_1_Single_MapIconClickAction_Boolean_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667719);
      MapMarker.NativeMethodInfoPtr_SetIconData_Private_Void_ManagedMapIconData_MapIconDrawMode_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667720);
      MapMarker.NativeMethodInfoPtr_CheckReset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667721);
      MapMarker.NativeMethodInfoPtr_IsHovered_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667722);
      MapMarker.NativeMethodInfoPtr_GetIconStatesDataFrom_Private_MapIconStates_MapIconDrawMode_ManagedMapIconData_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667723);
      MapMarker.NativeMethodInfoPtr_MakeMapIconOverrideState_Private_MapIconOverrideState_MapIconState_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667724);
      MapMarker.NativeMethodInfoPtr_MakeMapIconOverrideState_Private_MapIconOverrideState_MapIconState_MapIconOverrideState_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667725);
      MapMarker.NativeMethodInfoPtr_TryGetIconState_Private_Boolean_MapIconDrawMode_ManagedMapIconData_Sprite_byref_MapIconStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667726);
      MapMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapMarker>.NativeClassPtr, 100667727);
    }

    public MapMarker(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup CanvasGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_CanvasGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform PositionRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_PositionRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_PositionRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Highlight
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Highlight));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Sieged
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Sieged));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Sieged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite PlayerSprite
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_PlayerSprite));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_PlayerSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Sprite_CastleDecay
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Sprite_CastleDecay));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Sprite_CastleDecay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_DecayedCastle
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_LKey_DecayedCastle));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_LKey_DecayedCastle)) = value;
      }
    }

    public unsafe Color Color_CastleDecay
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Color_CastleDecay));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Color_CastleDecay)) = value;
      }
    }

    public unsafe Animator HighlightAnimator
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_HighlightAnimator));
        return pointer == System.IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_HighlightAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text TextElement1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_TextElement1));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_TextElement1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text TextElement2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_TextElement2));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_TextElement2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Label1));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Label1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Label2));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr_Label2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Hover
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__Hover));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__Hover)) = value;
      }
    }

    public unsafe MapIconDrawMode _DrawMode
    {
      get
      {
        return *(MapIconDrawMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__DrawMode));
      }
      [param: In] set
      {
        *(MapIconDrawMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__DrawMode)) = value;
      }
    }

    public unsafe ManagedMapIconData _IconData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__IconData));
        return pointer == System.IntPtr.Zero ? (ManagedMapIconData) null : new ManagedMapIconData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__IconData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public MapIconStates _IconStates
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__IconStates);
        return new MapIconStates(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__IconStates), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconStates>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _Reset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__Reset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__Reset)) = value;
      }
    }

    public MapIconClickAction _OnClick
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__OnClick);
        return new MapIconClickAction(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__OnClick), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapIconClickAction>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Il2CppSystem.Action<bool> _OnHover
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__OnHover));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : new Il2CppSystem.Action<bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__OnHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<RaycastResult> _RaycastResults
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(MapMarker.NativeFieldInfoPtr__RaycastResults, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<RaycastResult>) null : new List<RaycastResult>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapMarker.NativeFieldInfoPtr__RaycastResults, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PointerEventData _PointerData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__PointerData));
        return pointer == System.IntPtr.Zero ? (PointerEventData) null : new PointerEventData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapMarker.NativeFieldInfoPtr__PointerData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
