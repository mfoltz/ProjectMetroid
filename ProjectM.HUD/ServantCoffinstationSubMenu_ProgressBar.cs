// Decompiled with JetBrains decompiler
// Type: ServantCoffinstationSubMenu_ProgressBar
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
public class ServantCoffinstationSubMenu_ProgressBar : StunGUIBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_Image;
  private static readonly IntPtr NativeFieldInfoPtr_Text;
  private static readonly IntPtr NativeFieldInfoPtr_LKey_InProgress;
  private static readonly IntPtr NativeFieldInfoPtr_LKey_Finished;
  private static readonly IntPtr NativeFieldInfoPtr_TimeKeys;
  private static readonly IntPtr NativeFieldInfoPtr_LocalizedTime;
  private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Single_Single_Boolean_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1205749, RefRangeEnd = 1205751, XrefRangeStart = 1205739, XrefRangeEnd = 1205749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh(
    float currentProgress,
    float finishedProgress,
    bool isFinished,
    float multiplier = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &currentProgress;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &finishedProgress;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &isFinished;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &multiplier;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ProgressBar.NativeMethodInfoPtr_Refresh_Public_Void_Single_Single_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(425)]
  [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ServantCoffinstationSubMenu_ProgressBar()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ServantCoffinstationSubMenu_ProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ServantCoffinstationSubMenu_ProgressBar()
  {
    Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ServantCoffinstationSubMenu_ProgressBar));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr);
    ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, nameof (Image));
    ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, nameof (Text));
    ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LKey_InProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, nameof (LKey_InProgress));
    ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LKey_Finished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, nameof (LKey_Finished));
    ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_TimeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, nameof (TimeKeys));
    ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LocalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, nameof (LocalizedTime));
    ServantCoffinstationSubMenu_ProgressBar.NativeMethodInfoPtr_Refresh_Public_Void_Single_Single_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, 100663346);
    ServantCoffinstationSubMenu_ProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantCoffinstationSubMenu_ProgressBar>.NativeClassPtr, 100663347);
  }

  public ServantCoffinstationSubMenu_ProgressBar(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image Image
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_Image));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText Text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_Text));
      return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizationKey LKey_InProgress
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LKey_InProgress));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LKey_InProgress)) = value;
    }
  }

  public unsafe LocalizationKey LKey_Finished
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LKey_Finished));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LKey_Finished)) = value;
    }
  }

  public unsafe LocalizationTimeKeys TimeKeys
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_TimeKeys));
      return pointer == IntPtr.Zero ? (LocalizationTimeKeys) null : new LocalizationTimeKeys(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_TimeKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public LocalizedTimeBuilder LocalizedTime
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LocalizedTime);
      return new LocalizedTimeBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantCoffinstationSubMenu_ProgressBar.NativeFieldInfoPtr_LocalizedTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }
}
