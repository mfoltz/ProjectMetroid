// Decompiled with JetBrains decompiler
// Type: ProjectM.SunBehaviour
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
  public class SunBehaviour : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SunParent;
    private static readonly IntPtr NativeFieldInfoPtr_HighestEulerX;
    private static readonly IntPtr NativeFieldInfoPtr_LowestEulerX;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073936, XrefRangeEnd = 1073937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SunBehaviour()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SunBehaviour>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SunBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SunBehaviour()
    {
      Il2CppClassPointerStore<SunBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SunBehaviour));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunBehaviour>.NativeClassPtr);
      SunBehaviour.NativeFieldInfoPtr_SunParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunBehaviour>.NativeClassPtr, nameof (SunParent));
      SunBehaviour.NativeFieldInfoPtr_HighestEulerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunBehaviour>.NativeClassPtr, nameof (HighestEulerX));
      SunBehaviour.NativeFieldInfoPtr_LowestEulerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunBehaviour>.NativeClassPtr, nameof (LowestEulerX));
      SunBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SunBehaviour>.NativeClassPtr, 100684616);
    }

    public SunBehaviour(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform SunParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SunBehaviour.NativeFieldInfoPtr_SunParent));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SunBehaviour.NativeFieldInfoPtr_SunParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float HighestEulerX
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SunBehaviour.NativeFieldInfoPtr_HighestEulerX));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SunBehaviour.NativeFieldInfoPtr_HighestEulerX)) = value;
      }
    }

    public unsafe float LowestEulerX
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SunBehaviour.NativeFieldInfoPtr_LowestEulerX));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SunBehaviour.NativeFieldInfoPtr_LowestEulerX)) = value;
      }
    }
  }
}
