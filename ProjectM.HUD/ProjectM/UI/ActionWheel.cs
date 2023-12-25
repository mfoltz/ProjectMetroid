// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ActionWheel
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ActionWheel : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CachPartCount;
    private static readonly IntPtr NativeFieldInfoPtr_PartDistanceFromCenter;
    private static readonly IntPtr NativeFieldInfoPtr_WheelSpaceBetweenParts;
    private static readonly IntPtr NativeFieldInfoPtr_DisabledPartColor;
    private static readonly IntPtr NativeFieldInfoPtr_LockedPartColor;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockedPartColor;
    private static readonly IntPtr NativeFieldInfoPtr_SelectPartColor;
    private static readonly IntPtr NativeFieldInfoPtr_Parent;
    private static readonly IntPtr NativeFieldInfoPtr_Center;
    private static readonly IntPtr NativeFieldInfoPtr_CenterSize;
    private static readonly IntPtr NativeFieldInfoPtr_Exit;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_ActionWheelPartPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ActionWheelPartImagePrefab;
    private static readonly IntPtr NativeFieldInfoPtr_PartParent;
    private static readonly IntPtr NativeFieldInfoPtr_Shapeshift_NormalForm;
    private static readonly IntPtr NativeFieldInfoPtr_BatLanding;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Undiscovered;
    private static readonly IntPtr NativeFieldInfoPtr__SelectedPart_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__SelectedPartIndex_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr_CenterRect;
    private static readonly IntPtr NativeFieldInfoPtr__ActionWheelPartList;
    private static readonly IntPtr NativeFieldInfoPtr__ActionWheelPartIconList;
    private static readonly IntPtr NativeMethodInfoPtr_get_SelectedPart_Public_get_ActionWheelPart_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_SelectedPart_Public_set_Void_ActionWheelPart_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_SelectedPartIndex_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_SelectedPartIndex_Public_set_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GenerateWheel_Internal_Void_List_1_ActionWheelData_0;
    private static readonly IntPtr NativeMethodInfoPtr_FindDegree_Private_Single_Vector2_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateWheel_Internal_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsVisible_Internal_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe ActionWheelPart SelectedPart
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 148323, RefRangeEnd = 148324, XrefRangeStart = 148323, XrefRangeEnd = 148324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_get_SelectedPart_Public_get_ActionWheelPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (ActionWheelPart) null : new ActionWheelPart(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_set_SelectedPart_Public_set_Void_ActionWheelPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int SelectedPartIndex
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_get_SelectedPartIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_set_SelectedPartIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289402, XrefRangeEnd = 1289422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1289505, RefRangeEnd = 1289508, XrefRangeStart = 1289422, XrefRangeEnd = 1289505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateWheel(List<ActionWheelData> actionList)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionList);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_GenerateWheel_Internal_Void_List_1_ActionWheelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289508, XrefRangeEnd = 1289509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float FindDegree(Vector2 vector)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &vector;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_FindDegree_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1289588, RefRangeEnd = 1289592, XrefRangeStart = 1289509, XrefRangeEnd = 1289588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateWheel(bool isGamepad)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &isGamepad;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_UpdateWheel_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289592, XrefRangeEnd = 1289594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsVisible()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr_IsVisible_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289594, XrefRangeEnd = 1289595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActionWheel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ActionWheel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ActionWheel()
    {
      Il2CppClassPointerStore<ActionWheel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ActionWheel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr);
      ActionWheel.NativeFieldInfoPtr_CachPartCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (CachPartCount));
      ActionWheel.NativeFieldInfoPtr_PartDistanceFromCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (PartDistanceFromCenter));
      ActionWheel.NativeFieldInfoPtr_WheelSpaceBetweenParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (WheelSpaceBetweenParts));
      ActionWheel.NativeFieldInfoPtr_DisabledPartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (DisabledPartColor));
      ActionWheel.NativeFieldInfoPtr_LockedPartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (LockedPartColor));
      ActionWheel.NativeFieldInfoPtr_UnlockedPartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (UnlockedPartColor));
      ActionWheel.NativeFieldInfoPtr_SelectPartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (SelectPartColor));
      ActionWheel.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (Parent));
      ActionWheel.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (Center));
      ActionWheel.NativeFieldInfoPtr_CenterSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (CenterSize));
      ActionWheel.NativeFieldInfoPtr_Exit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (Exit));
      ActionWheel.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (Name));
      ActionWheel.NativeFieldInfoPtr_ActionWheelPartPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (ActionWheelPartPrefab));
      ActionWheel.NativeFieldInfoPtr_ActionWheelPartImagePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (ActionWheelPartImagePrefab));
      ActionWheel.NativeFieldInfoPtr_PartParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (PartParent));
      ActionWheel.NativeFieldInfoPtr_Shapeshift_NormalForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (Shapeshift_NormalForm));
      ActionWheel.NativeFieldInfoPtr_BatLanding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (BatLanding));
      ActionWheel.NativeFieldInfoPtr_LKey_Undiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (LKey_Undiscovered));
      ActionWheel.NativeFieldInfoPtr__SelectedPart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, "<SelectedPart>k__BackingField");
      ActionWheel.NativeFieldInfoPtr__SelectedPartIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, "<SelectedPartIndex>k__BackingField");
      ActionWheel.NativeFieldInfoPtr_CenterRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (CenterRect));
      ActionWheel.NativeFieldInfoPtr__ActionWheelPartList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (_ActionWheelPartList));
      ActionWheel.NativeFieldInfoPtr__ActionWheelPartIconList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, nameof (_ActionWheelPartIconList));
      ActionWheel.NativeMethodInfoPtr_get_SelectedPart_Public_get_ActionWheelPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669764);
      ActionWheel.NativeMethodInfoPtr_set_SelectedPart_Public_set_Void_ActionWheelPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669765);
      ActionWheel.NativeMethodInfoPtr_get_SelectedPartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669766);
      ActionWheel.NativeMethodInfoPtr_set_SelectedPartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669767);
      ActionWheel.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669768);
      ActionWheel.NativeMethodInfoPtr_GenerateWheel_Internal_Void_List_1_ActionWheelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669769);
      ActionWheel.NativeMethodInfoPtr_FindDegree_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669770);
      ActionWheel.NativeMethodInfoPtr_UpdateWheel_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669771);
      ActionWheel.NativeMethodInfoPtr_IsVisible_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669772);
      ActionWheel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionWheel>.NativeClassPtr, 100669773);
    }

    public ActionWheel(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int CachPartCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_CachPartCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_CachPartCount)) = value;
      }
    }

    public unsafe float PartDistanceFromCenter
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_PartDistanceFromCenter));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_PartDistanceFromCenter)) = value;
      }
    }

    public unsafe float WheelSpaceBetweenParts
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_WheelSpaceBetweenParts));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_WheelSpaceBetweenParts)) = value;
      }
    }

    public unsafe Color DisabledPartColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_DisabledPartColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_DisabledPartColor)) = value;
      }
    }

    public unsafe Color LockedPartColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_LockedPartColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_LockedPartColor)) = value;
      }
    }

    public unsafe Color UnlockedPartColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_UnlockedPartColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_UnlockedPartColor)) = value;
      }
    }

    public unsafe Color SelectPartColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_SelectPartColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_SelectPartColor)) = value;
      }
    }

    public unsafe GameObject Parent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Parent));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Center
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Center));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Center), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float CenterSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_CenterSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_CenterSize)) = value;
      }
    }

    public unsafe Image Exit
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Exit));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Exit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Name
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Name));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ActionWheelPart ActionWheelPartPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_ActionWheelPartPrefab));
        return pointer == IntPtr.Zero ? (ActionWheelPart) null : new ActionWheelPart(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_ActionWheelPartPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ActionWheelPartImage ActionWheelPartImagePrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_ActionWheelPartImagePrefab));
        return pointer == IntPtr.Zero ? (ActionWheelPartImage) null : new ActionWheelPartImage(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_ActionWheelPartImagePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform PartParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_PartParent));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_PartParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent Shapeshift_NormalForm
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Shapeshift_NormalForm));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_Shapeshift_NormalForm), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent BatLanding
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_BatLanding));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_BatLanding), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Undiscovered
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_LKey_Undiscovered));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_LKey_Undiscovered)) = value;
      }
    }

    public unsafe ActionWheelPart _SelectedPart_k__BackingField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__SelectedPart_k__BackingField));
        return pointer == IntPtr.Zero ? (ActionWheelPart) null : new ActionWheelPart(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__SelectedPart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _SelectedPartIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__SelectedPartIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__SelectedPartIndex_k__BackingField)) = value;
      }
    }

    public unsafe RectTransform CenterRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_CenterRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr_CenterRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ActionWheelPart> _ActionWheelPartList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__ActionWheelPartList));
        return pointer == IntPtr.Zero ? (List<ActionWheelPart>) null : new List<ActionWheelPart>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__ActionWheelPartList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ActionWheelPartImage> _ActionWheelPartIconList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__ActionWheelPartIconList));
        return pointer == IntPtr.Zero ? (List<ActionWheelPartImage>) null : new List<ActionWheelPartImage>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionWheel.NativeFieldInfoPtr__ActionWheelPartIconList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
