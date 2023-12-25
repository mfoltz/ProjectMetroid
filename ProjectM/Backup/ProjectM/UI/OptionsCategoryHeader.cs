// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OptionsCategoryHeader
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
  public class OptionsCategoryHeader : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161535, XrefRangeEnd = 1161536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetText(LocalizationKey localizationKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &localizationKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsCategoryHeader.NativeMethodInfoPtr_SetText_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OptionsCategoryHeader()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsCategoryHeader>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsCategoryHeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OptionsCategoryHeader()
    {
      Il2CppClassPointerStore<OptionsCategoryHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (OptionsCategoryHeader));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsCategoryHeader>.NativeClassPtr);
      OptionsCategoryHeader.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCategoryHeader>.NativeClassPtr, nameof (HeaderText));
      OptionsCategoryHeader.NativeMethodInfoPtr_SetText_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCategoryHeader>.NativeClassPtr, 100692383);
      OptionsCategoryHeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCategoryHeader>.NativeClassPtr, 100692384);
    }

    public OptionsCategoryHeader(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsCategoryHeader.NativeFieldInfoPtr_HeaderText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsCategoryHeader.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
