// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitFormationFollowAuthoring
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
  public class UnitFormationFollowAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FollowObject;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitFormationFollowAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitFormationFollowAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitFormationFollowAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitFormationFollowAuthoring()
    {
      Il2CppClassPointerStore<UnitFormationFollowAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitFormationFollowAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitFormationFollowAuthoring>.NativeClassPtr);
      UnitFormationFollowAuthoring.NativeFieldInfoPtr_FollowObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitFormationFollowAuthoring>.NativeClassPtr, nameof (FollowObject));
      UnitFormationFollowAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitFormationFollowAuthoring>.NativeClassPtr, 100665818);
    }

    public UnitFormationFollowAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject FollowObject
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitFormationFollowAuthoring.NativeFieldInfoPtr_FollowObject));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitFormationFollowAuthoring.NativeFieldInfoPtr_FollowObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
