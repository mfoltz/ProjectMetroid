// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SimpleStunSelectable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SimpleStunSelectable : Selectable
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetSettings;
    private static readonly IntPtr NativeFieldInfoPtr__ForceHilight;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ForceHilight_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_ForceHilight_Public_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_InitInstantHighlight_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_DoFontSwap_Private_Void_TMP_Text_TMP_FontAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_StartColorTween_Private_Void_Graphic_Color_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Image_Sprite_0;
    private static readonly IntPtr NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795508, XrefRangeEnd = 795516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SimpleStunSelectable()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe bool ForceHilight
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr_get_ForceHilight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(22), CachedScanResults(RefRangeStart = 795517, RefRangeEnd = 795539, XrefRangeStart = 795516, XrefRangeEnd = 795517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr_set_ForceHilight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 795539, RefRangeEnd = 795540, XrefRangeStart = 795539, XrefRangeEnd = 795539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitInstantHighlight()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr_InitInstantHighlight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795540, XrefRangeEnd = 795631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DoStateTransition(Selectable.SelectionState state, bool instant)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &state;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &instant;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SimpleStunSelectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 795639, RefRangeEnd = 795644, XrefRangeStart = 795631, XrefRangeEnd = 795639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoFontSwap(TMP_Text text, TMP_FontAsset newFont)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) text);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newFont);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr_DoFontSwap_Private_Void_TMP_Text_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795644, XrefRangeEnd = 795648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartColorTween(
      Graphic graphic,
      Color targetColor,
      float fadeDuration,
      bool instant)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphic);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &targetColor;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &fadeDuration;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &instant;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Graphic_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 795653, RefRangeEnd = 795659, XrefRangeStart = 795648, XrefRangeEnd = 795653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoSpriteSwap(Image image, Sprite newSprite)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newSprite);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Image_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void TriggerAnimation(string triggerName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(triggerName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SimpleStunSelectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SimpleStunSelectable()
    {
      Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (SimpleStunSelectable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr);
      SimpleStunSelectable.NativeFieldInfoPtr_TargetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, nameof (TargetSettings));
      SimpleStunSelectable.NativeFieldInfoPtr__ForceHilight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, nameof (_ForceHilight));
      SimpleStunSelectable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670203);
      SimpleStunSelectable.NativeMethodInfoPtr_get_ForceHilight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670204);
      SimpleStunSelectable.NativeMethodInfoPtr_set_ForceHilight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670205);
      SimpleStunSelectable.NativeMethodInfoPtr_InitInstantHighlight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670206);
      SimpleStunSelectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670207);
      SimpleStunSelectable.NativeMethodInfoPtr_DoFontSwap_Private_Void_TMP_Text_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670208);
      SimpleStunSelectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Graphic_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670209);
      SimpleStunSelectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Image_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670210);
      SimpleStunSelectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleStunSelectable>.NativeClassPtr, 100670211);
    }

    public SimpleStunSelectable(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<ButtonTarget> TargetSettings
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunSelectable.NativeFieldInfoPtr_TargetSettings));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ButtonTarget>) null : new Il2CppReferenceArray<ButtonTarget>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunSelectable.NativeFieldInfoPtr_TargetSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _ForceHilight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunSelectable.NativeFieldInfoPtr__ForceHilight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SimpleStunSelectable.NativeFieldInfoPtr__ForceHilight)) = value;
      }
    }
  }
}
