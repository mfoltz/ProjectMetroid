// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitFormationAuthoring
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
  public class UnitFormationAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SmoothPointDistance;
    private static readonly IntPtr NativeFieldInfoPtr_PatrolMaxRotationSpeed;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747470, XrefRangeEnd = 747471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitFormationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitFormationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitFormationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitFormationAuthoring()
    {
      Il2CppClassPointerStore<UnitFormationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitFormationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitFormationAuthoring>.NativeClassPtr);
      UnitFormationAuthoring.NativeFieldInfoPtr_SmoothPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitFormationAuthoring>.NativeClassPtr, nameof (SmoothPointDistance));
      UnitFormationAuthoring.NativeFieldInfoPtr_PatrolMaxRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitFormationAuthoring>.NativeClassPtr, nameof (PatrolMaxRotationSpeed));
      UnitFormationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitFormationAuthoring>.NativeClassPtr, 100665817);
    }

    public UnitFormationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float SmoothPointDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitFormationAuthoring.NativeFieldInfoPtr_SmoothPointDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitFormationAuthoring.NativeFieldInfoPtr_SmoothPointDistance)) = value;
      }
    }

    public unsafe float PatrolMaxRotationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitFormationAuthoring.NativeFieldInfoPtr_PatrolMaxRotationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitFormationAuthoring.NativeFieldInfoPtr_PatrolMaxRotationSpeed)) = value;
      }
    }
  }
}
