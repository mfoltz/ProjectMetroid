// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SelectorIndexIndicator
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SelectorIndexIndicator : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_Image;
    private static readonly IntPtr NativeFieldInfoPtr_DeselectedColor;
    private static readonly IntPtr NativeFieldInfoPtr_SelectedColor;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectorIndexIndicator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1164680, RefRangeEnd = 1164682, XrefRangeStart = 1164679, XrefRangeEnd = 1164680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSelected(bool selected)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &selected;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectorIndexIndicator.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SelectorIndexIndicator()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectorIndexIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SelectorIndexIndicator()
    {
      Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (SelectorIndexIndicator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr);
      SelectorIndexIndicator.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr, nameof (Image));
      SelectorIndexIndicator.NativeFieldInfoPtr_DeselectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr, nameof (DeselectedColor));
      SelectorIndexIndicator.NativeFieldInfoPtr_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr, nameof (SelectedColor));
      SelectorIndexIndicator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr, 100692613);
      SelectorIndexIndicator.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr, 100692614);
      SelectorIndexIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorIndexIndicator>.NativeClassPtr, 100692615);
    }

    public SelectorIndexIndicator(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Image
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorIndexIndicator.NativeFieldInfoPtr_Image));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectorIndexIndicator.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color DeselectedColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorIndexIndicator.NativeFieldInfoPtr_DeselectedColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorIndexIndicator.NativeFieldInfoPtr_DeselectedColor)) = value;
      }
    }

    public unsafe Color SelectedColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorIndexIndicator.NativeFieldInfoPtr_SelectedColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorIndexIndicator.NativeFieldInfoPtr_SelectedColor)) = value;
      }
    }
  }
}
