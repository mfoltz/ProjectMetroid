// Decompiled with JetBrains decompiler
// Type: ProjectM.Portrait.PortraitData
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
  public class PortraitData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CamTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CamRotationEuler;
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationEuler;
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114671, RefRangeEnd = 1114672, XrefRangeStart = 1114668, XrefRangeEnd = 1114671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PortraitData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PortraitData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PortraitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PortraitData()
    {
      Il2CppClassPointerStore<PortraitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Portrait", nameof (PortraitData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PortraitData>.NativeClassPtr);
      PortraitData.NativeFieldInfoPtr_CamTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortraitData>.NativeClassPtr, nameof (CamTranslation));
      PortraitData.NativeFieldInfoPtr_CamRotationEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortraitData>.NativeClassPtr, nameof (CamRotationEuler));
      PortraitData.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortraitData>.NativeClassPtr, nameof (Translation));
      PortraitData.NativeFieldInfoPtr_RotationEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortraitData>.NativeClassPtr, nameof (RotationEuler));
      PortraitData.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortraitData>.NativeClassPtr, nameof (Scale));
      PortraitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortraitData>.NativeClassPtr, 100688235);
    }

    public PortraitData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 CamTranslation
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_CamTranslation));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_CamTranslation)) = value;
      }
    }

    public unsafe Vector3 CamRotationEuler
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_CamRotationEuler));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_CamRotationEuler)) = value;
      }
    }

    public unsafe Vector3 Translation
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_Translation));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_Translation)) = value;
      }
    }

    public unsafe Vector3 RotationEuler
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_RotationEuler));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_RotationEuler)) = value;
      }
    }

    public unsafe Vector3 Scale
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_Scale));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortraitData.NativeFieldInfoPtr_Scale)) = value;
      }
    }
  }
}
