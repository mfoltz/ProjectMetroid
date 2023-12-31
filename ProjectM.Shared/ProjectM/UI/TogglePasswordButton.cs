// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TogglePasswordButton
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class TogglePasswordButton : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Button;
    private static readonly IntPtr NativeFieldInfoPtr_ButtonImage;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Show;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_Hide;
    private static readonly IntPtr NativeFieldInfoPtr_LK_ShowPassword;
    private static readonly IntPtr NativeFieldInfoPtr_LK_HidePassword;
    private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 795677, RefRangeEnd = 795680, XrefRangeStart = 795672, XrefRangeEnd = 795677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetState(bool showPassword, bool streamerMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &showPassword;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &streamerMode;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TogglePasswordButton.NativeMethodInfoPtr_SetState_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TogglePasswordButton()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TogglePasswordButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TogglePasswordButton()
    {
      Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (TogglePasswordButton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr);
      TogglePasswordButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, nameof (Button));
      TogglePasswordButton.NativeFieldInfoPtr_ButtonImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, nameof (ButtonImage));
      TogglePasswordButton.NativeFieldInfoPtr_Icon_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, nameof (Icon_Show));
      TogglePasswordButton.NativeFieldInfoPtr_Icon_Hide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, nameof (Icon_Hide));
      TogglePasswordButton.NativeFieldInfoPtr_LK_ShowPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, nameof (LK_ShowPassword));
      TogglePasswordButton.NativeFieldInfoPtr_LK_HidePassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, nameof (LK_HidePassword));
      TogglePasswordButton.NativeMethodInfoPtr_SetState_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, 100670215);
      TogglePasswordButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TogglePasswordButton>.NativeClassPtr, 100670216);
    }

    public TogglePasswordButton(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_Button));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ButtonImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_ButtonImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_ButtonImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Show
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_Icon_Show));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_Icon_Show), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_Hide
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_Icon_Hide));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_Icon_Hide), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_ShowPassword
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_LK_ShowPassword));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_LK_ShowPassword)) = value;
      }
    }

    public unsafe LocalizationKey LK_HidePassword
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_LK_HidePassword));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TogglePasswordButton.NativeFieldInfoPtr_LK_HidePassword)) = value;
      }
    }
  }
}
