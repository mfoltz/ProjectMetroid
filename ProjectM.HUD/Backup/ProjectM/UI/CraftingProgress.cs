// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CraftingProgress
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CraftingProgress : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Progress;
    private static readonly IntPtr NativeFieldInfoPtr_Icons;
    private static readonly IntPtr NativeFieldInfoPtr_Action;
    private static readonly IntPtr NativeFieldInfoPtr_Timer;
    private static readonly IntPtr NativeFieldInfoPtr_TimeKeys;
    private static readonly IntPtr NativeFieldInfoPtr_LocalizedTime;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Burning;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_NotActive;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CraftingProgress()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CraftingProgress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CraftingProgress()
    {
      Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CraftingProgress));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr);
      CraftingProgress.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (Progress));
      CraftingProgress.NativeFieldInfoPtr_Icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (Icons));
      CraftingProgress.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (Action));
      CraftingProgress.NativeFieldInfoPtr_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (Timer));
      CraftingProgress.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (TimeKeys));
      CraftingProgress.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (LocalizedTime));
      CraftingProgress.NativeFieldInfoPtr_LKey_Burning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (LKey_Burning));
      CraftingProgress.NativeFieldInfoPtr_LKey_NotActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, nameof (LKey_NotActive));
      CraftingProgress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingProgress>.NativeClassPtr, 100665617);
    }

    public CraftingProgress(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Progress
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Progress));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Progress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Image> Icons
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Icons));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Image>) null : new Il2CppReferenceArray<Image>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Icons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Action
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Action));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Timer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Timer));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_Timer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationTimeKeys TimeKeys
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_TimeKeys));
        return pointer == IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedTimeBuilder LocalizedTime
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_LocalizedTime);
        return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey LKey_Burning
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_LKey_Burning));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_LKey_Burning)) = value;
      }
    }

    public unsafe LocalizationKey LKey_NotActive
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_LKey_NotActive));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CraftingProgress.NativeFieldInfoPtr_LKey_NotActive)) = value;
      }
    }
  }
}
