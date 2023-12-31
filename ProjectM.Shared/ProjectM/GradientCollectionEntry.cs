// Decompiled with JetBrains decompiler
// Type: ProjectM.GradientCollectionEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class GradientCollectionEntry : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitGradient;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mode;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 746965, RefRangeEnd = 746966, XrefRangeStart = 746945, XrefRangeEnd = 746965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GradientCollectionEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientCollectionEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GradientCollectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GradientCollectionEntry()
    {
      Il2CppClassPointerStore<GradientCollectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GradientCollectionEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientCollectionEntry>.NativeClassPtr);
      GradientCollectionEntry.NativeFieldInfoPtr_UnitGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientCollectionEntry>.NativeClassPtr, nameof (UnitGradient));
      GradientCollectionEntry.NativeFieldInfoPtr_UnitColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientCollectionEntry>.NativeClassPtr, nameof (UnitColor));
      GradientCollectionEntry.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientCollectionEntry>.NativeClassPtr, nameof (Mode));
      GradientCollectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientCollectionEntry>.NativeClassPtr, 100665762);
    }

    public GradientCollectionEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Gradient UnitGradient
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GradientCollectionEntry.NativeFieldInfoPtr_UnitGradient));
        return pointer == System.IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GradientCollectionEntry.NativeFieldInfoPtr_UnitGradient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color UnitColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GradientCollectionEntry.NativeFieldInfoPtr_UnitColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GradientCollectionEntry.NativeFieldInfoPtr_UnitColor)) = value;
      }
    }

    public unsafe GradientCollectionEntryMode Mode
    {
      get
      {
        return *(GradientCollectionEntryMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GradientCollectionEntry.NativeFieldInfoPtr_Mode));
      }
      [param: In] set
      {
        *(GradientCollectionEntryMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GradientCollectionEntry.NativeFieldInfoPtr_Mode)) = value;
      }
    }
  }
}
