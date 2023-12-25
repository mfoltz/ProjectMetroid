// Decompiled with JetBrains decompiler
// Type: ProjectM.ResetTransform
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public sealed class ResetTransform : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BoneReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetRotation;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoResetTransform_Public_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1063402, RefRangeEnd = 1063403, XrefRangeStart = 1063395, XrefRangeEnd = 1063402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ResetTransform(Transform boneRef)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) boneRef);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResetTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1063409, RefRangeEnd = 1063410, XrefRangeStart = 1063403, XrefRangeEnd = 1063409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool DoResetTransform()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResetTransform.NativeMethodInfoPtr_DoResetTransform_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ResetTransform()
    {
      Il2CppClassPointerStore<ResetTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ResetTransform));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr);
      ResetTransform.NativeFieldInfoPtr_BoneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr, nameof (BoneReference));
      ResetTransform.NativeFieldInfoPtr_ResetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr, nameof (ResetPosition));
      ResetTransform.NativeFieldInfoPtr_ResetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr, nameof (ResetRotation));
      ResetTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr, 100683490);
      ResetTransform.NativeMethodInfoPtr_DoResetTransform_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr, 100683491);
    }

    public ResetTransform(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ResetTransform()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResetTransform>.NativeClassPtr, data));
    }

    public unsafe Transform BoneReference
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResetTransform.NativeFieldInfoPtr_BoneReference));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResetTransform.NativeFieldInfoPtr_BoneReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 ResetPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResetTransform.NativeFieldInfoPtr_ResetPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResetTransform.NativeFieldInfoPtr_ResetPosition)) = value;
      }
    }

    public unsafe Quaternion ResetRotation
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResetTransform.NativeFieldInfoPtr_ResetRotation));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResetTransform.NativeFieldInfoPtr_ResetRotation)) = value;
      }
    }
  }
}
