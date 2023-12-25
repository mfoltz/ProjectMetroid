// Decompiled with JetBrains decompiler
// Type: ProjectM.HitConsumeFilterAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class HitConsumeFilterAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_TeamFilter;
    private static readonly IntPtr NativeFieldInfoPtr_SpellFilter;
    private static readonly IntPtr NativeMethodInfoPtr_ToFilter_Public_HitConsumeFilter_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1067413, RefRangeEnd = 1067414, XrefRangeStart = 1067413, XrefRangeEnd = 1067413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HitConsumeFilter ToFilter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitConsumeFilterAsset.NativeMethodInfoPtr_ToFilter_Public_HitConsumeFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(HitConsumeFilter*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HitConsumeFilterAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitConsumeFilterAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitConsumeFilterAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HitConsumeFilterAsset()
    {
      Il2CppClassPointerStore<HitConsumeFilterAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HitConsumeFilterAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitConsumeFilterAsset>.NativeClassPtr);
      HitConsumeFilterAsset.NativeFieldInfoPtr_TeamFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitConsumeFilterAsset>.NativeClassPtr, nameof (TeamFilter));
      HitConsumeFilterAsset.NativeFieldInfoPtr_SpellFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitConsumeFilterAsset>.NativeClassPtr, nameof (SpellFilter));
      HitConsumeFilterAsset.NativeMethodInfoPtr_ToFilter_Public_HitConsumeFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitConsumeFilterAsset>.NativeClassPtr, 100683964);
      HitConsumeFilterAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitConsumeFilterAsset>.NativeClassPtr, 100683965);
    }

    public HitConsumeFilterAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TeamFilterEnum TeamFilter
    {
      get
      {
        return *(TeamFilterEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitConsumeFilterAsset.NativeFieldInfoPtr_TeamFilter));
      }
      [param: In] set
      {
        *(TeamFilterEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitConsumeFilterAsset.NativeFieldInfoPtr_TeamFilter)) = value;
      }
    }

    public unsafe SpellFilterEnum SpellFilter
    {
      get
      {
        return *(SpellFilterEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitConsumeFilterAsset.NativeFieldInfoPtr_SpellFilter));
      }
      [param: In] set
      {
        *(SpellFilterEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitConsumeFilterAsset.NativeFieldInfoPtr_SpellFilter)) = value;
      }
    }
  }
}
