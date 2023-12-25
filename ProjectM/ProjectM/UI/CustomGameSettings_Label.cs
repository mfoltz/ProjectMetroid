// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CustomGameSettings_Label
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class CustomGameSettings_Label : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1161226, RefRangeEnd = 1161238, XrefRangeStart = 1161225, XrefRangeEnd = 1161226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &textKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Label.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Label()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Label>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Label.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomGameSettings_Label()
    {
      Il2CppClassPointerStore<CustomGameSettings_Label>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (CustomGameSettings_Label));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Label>.NativeClassPtr);
      CustomGameSettings_Label.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Label>.NativeClassPtr, nameof (HeaderText));
      CustomGameSettings_Label.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Label>.NativeClassPtr, 100692348);
      CustomGameSettings_Label.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Label>.NativeClassPtr, 100692349);
    }

    public CustomGameSettings_Label(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Label.NativeFieldInfoPtr_HeaderText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Label.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
