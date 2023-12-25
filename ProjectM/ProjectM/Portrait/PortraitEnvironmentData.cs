// Decompiled with JetBrains decompiler
// Type: ProjectM.Portrait.PortraitEnvironmentData
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
namespace ProjectM.Portrait
{
  [Serializable]
  public class PortraitEnvironmentData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybModelIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114673, XrefRangeEnd = 1114675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PortraitEnvironmentData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PortraitEnvironmentData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PortraitEnvironmentData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PortraitEnvironmentData()
    {
      Il2CppClassPointerStore<PortraitEnvironmentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Portrait", nameof (PortraitEnvironmentData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PortraitEnvironmentData>.NativeClassPtr);
      PortraitEnvironmentData.NativeFieldInfoPtr_MaskColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortraitEnvironmentData>.NativeClassPtr, nameof (MaskColor));
      PortraitEnvironmentData.NativeFieldInfoPtr_HybModelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortraitEnvironmentData>.NativeClassPtr, nameof (HybModelIndex));
      PortraitEnvironmentData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortraitEnvironmentData>.NativeClassPtr, 100688237);
    }

    public PortraitEnvironmentData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color MaskColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitEnvironmentData.NativeFieldInfoPtr_MaskColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitEnvironmentData.NativeFieldInfoPtr_MaskColor)) = value;
      }
    }

    public unsafe int HybModelIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitEnvironmentData.NativeFieldInfoPtr_HybModelIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitEnvironmentData.NativeFieldInfoPtr_HybModelIndex)) = value;
      }
    }
  }
}
