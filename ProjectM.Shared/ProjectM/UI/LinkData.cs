// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LinkData
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

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class LinkData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_URL;
    private static readonly System.IntPtr NativeFieldInfoPtr_IconNormal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tooltip;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795310, XrefRangeEnd = 795311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinkData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinkData()
    {
      Il2CppClassPointerStore<LinkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (LinkData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkData>.NativeClassPtr);
      LinkData.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkData>.NativeClassPtr, nameof (Enabled));
      LinkData.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkData>.NativeClassPtr, nameof (URL));
      LinkData.NativeFieldInfoPtr_IconNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkData>.NativeClassPtr, nameof (IconNormal));
      LinkData.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkData>.NativeClassPtr, nameof (Tooltip));
      LinkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkData>.NativeClassPtr, 100670155);
    }

    public LinkData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Enabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_Enabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_Enabled)) = value;
      }
    }

    public unsafe string URL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_URL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_URL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Sprite IconNormal
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_IconNormal));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_IconNormal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey Tooltip
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_Tooltip));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkData.NativeFieldInfoPtr_Tooltip)) = value;
      }
    }
  }
}
