// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TutorialObjective
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
  public class TutorialObjective : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_KeyMapping;
    private static readonly IntPtr NativeFieldInfoPtr_Text;
    private static readonly IntPtr NativeFieldInfoPtr_KeybindImage;
    private static readonly IntPtr NativeFieldInfoPtr_Button;
    private static readonly IntPtr NativeFieldInfoPtr_AutoCompleteTime;
    private static readonly IntPtr NativeFieldInfoPtr_MinimumActiveTime;
    private static readonly IntPtr NativeFieldInfoPtr_ActivationDelayTime;
    private static readonly IntPtr NativeFieldInfoPtr_ForceUIUpdate;
    private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_TutorialObjectiveType_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateUINextFrame_Public_Abstract_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public virtual unsafe TutorialObjectiveType Type
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialObjective.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_TutorialObjectiveType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TutorialObjectiveType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void UpdateUINextFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialObjective.NativeMethodInfoPtr_UpdateUINextFrame_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TutorialObjective()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialObjective.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TutorialObjective()
    {
      Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TutorialObjective));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr);
      TutorialObjective.NativeFieldInfoPtr_KeyMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (KeyMapping));
      TutorialObjective.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (Text));
      TutorialObjective.NativeFieldInfoPtr_KeybindImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (KeybindImage));
      TutorialObjective.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (Button));
      TutorialObjective.NativeFieldInfoPtr_AutoCompleteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (AutoCompleteTime));
      TutorialObjective.NativeFieldInfoPtr_MinimumActiveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (MinimumActiveTime));
      TutorialObjective.NativeFieldInfoPtr_ActivationDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (ActivationDelayTime));
      TutorialObjective.NativeFieldInfoPtr_ForceUIUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, nameof (ForceUIUpdate));
      TutorialObjective.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_TutorialObjectiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, 100668568);
      TutorialObjective.NativeMethodInfoPtr_UpdateUINextFrame_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, 100668569);
      TutorialObjective.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective>.NativeClassPtr, 100668570);
    }

    public TutorialObjective(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<LocalizationKey> KeyMapping
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_KeyMapping));
        return pointer == IntPtr.Zero ? (List<LocalizationKey>) null : new List<LocalizationKey>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_KeyMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<LocalizedText> Text
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_Text));
        return pointer == IntPtr.Zero ? (List<LocalizedText>) null : new List<LocalizedText>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image KeybindImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_KeybindImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_KeybindImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Button
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_Button));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float AutoCompleteTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_AutoCompleteTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_AutoCompleteTime)) = value;
      }
    }

    public unsafe float MinimumActiveTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_MinimumActiveTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_MinimumActiveTime)) = value;
      }
    }

    public unsafe float ActivationDelayTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_ActivationDelayTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_ActivationDelayTime)) = value;
      }
    }

    public unsafe bool ForceUIUpdate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_ForceUIUpdate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialObjective.NativeFieldInfoPtr_ForceUIUpdate)) = value;
      }
    }
  }
}
