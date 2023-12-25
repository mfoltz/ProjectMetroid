// Decompiled with JetBrains decompiler
// Type: ResearchGroupEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
public class ResearchGroupEntry : GridSelectionEntry
{
  private static readonly IntPtr NativeFieldInfoPtr_TeachCategory;
  private static readonly IntPtr NativeFieldInfoPtr_ResearchParent;
  private static readonly IntPtr NativeFieldInfoPtr_ResearchEntryPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_ResearchGridSelectionGroup;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ResearchGroupEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ResearchGroupEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ResearchGroupEntry()
  {
    Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ResearchGroupEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr);
    ResearchGroupEntry.NativeFieldInfoPtr_TeachCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr, nameof (TeachCategory));
    ResearchGroupEntry.NativeFieldInfoPtr_ResearchParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr, nameof (ResearchParent));
    ResearchGroupEntry.NativeFieldInfoPtr_ResearchEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr, nameof (ResearchEntryPrefab));
    ResearchGroupEntry.NativeFieldInfoPtr_ResearchGridSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr, nameof (ResearchGridSelectionGroup));
    ResearchGroupEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchGroupEntry>.NativeClassPtr, 100663345);
  }

  public ResearchGroupEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TechCateogry TeachCategory
  {
    get
    {
      return *(TechCateogry*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_TeachCategory));
    }
    [param: In] set
    {
      *(TechCateogry*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_TeachCategory)) = value;
    }
  }

  public unsafe GridLayoutGroup ResearchParent
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_ResearchParent));
      return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_ResearchParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ResearchEntry ResearchEntryPrefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_ResearchEntryPrefab));
      return pointer == IntPtr.Zero ? (ResearchEntry) null : new ResearchEntry(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_ResearchEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GridSelectionGroup<ResearchEntry, ResearchEntry.Data> ResearchGridSelectionGroup
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_ResearchGridSelectionGroup));
      return pointer == IntPtr.Zero ? (GridSelectionGroup<ResearchEntry, ResearchEntry.Data>) null : new GridSelectionGroup<ResearchEntry, ResearchEntry.Data>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchGroupEntry.NativeFieldInfoPtr_ResearchGridSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
