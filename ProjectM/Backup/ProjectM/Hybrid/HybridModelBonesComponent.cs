// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelBonesComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelBonesComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Bones;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBone_Public_Boolean_HybridBoneEnum_byref_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1157410, RefRangeEnd = 1157411, XrefRangeStart = 1157408, XrefRangeEnd = 1157410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBone(HybridBoneEnum boneToGet, out Transform boneTransform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &boneToGet;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HybridModelBonesComponent.NativeMethodInfoPtr_TryGetBone_Public_Boolean_HybridBoneEnum_byref_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Transform local = ref boneTransform;
      System.IntPtr pointer = zero;
      Transform transform = pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      local = transform;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157411, XrefRangeEnd = 1157416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelBonesComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelBonesComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelBonesComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelBonesComponent()
    {
      Il2CppClassPointerStore<HybridModelBonesComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelBonesComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelBonesComponent>.NativeClassPtr);
      HybridModelBonesComponent.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelBonesComponent>.NativeClassPtr, nameof (Bones));
      HybridModelBonesComponent.NativeMethodInfoPtr_TryGetBone_Public_Boolean_HybridBoneEnum_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelBonesComponent>.NativeClassPtr, 100692133);
      HybridModelBonesComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelBonesComponent>.NativeClassPtr, 100692134);
    }

    public HybridModelBonesComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<HybridModelBonesComponent.HybridBone> Bones
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelBonesComponent.NativeFieldInfoPtr_Bones));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridModelBonesComponent.HybridBone>) null : new Il2CppReferenceArray<HybridModelBonesComponent.HybridBone>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelBonesComponent.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class HybridBone : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Bone;
      private static readonly System.IntPtr NativeFieldInfoPtr_Transform;

      static HybridBone()
      {
        Il2CppClassPointerStore<HybridModelBonesComponent.HybridBone>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelBonesComponent>.NativeClassPtr, nameof (HybridBone));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelBonesComponent.HybridBone>.NativeClassPtr);
        HybridModelBonesComponent.HybridBone.NativeFieldInfoPtr_Bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelBonesComponent.HybridBone>.NativeClassPtr, nameof (Bone));
        HybridModelBonesComponent.HybridBone.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelBonesComponent.HybridBone>.NativeClassPtr, nameof (Transform));
      }

      public HybridBone(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public HybridBone()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridModelBonesComponent.HybridBone>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelBonesComponent.HybridBone>.NativeClassPtr, data));
      }

      public unsafe HybridBoneEnum Bone
      {
        get
        {
          return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelBonesComponent.HybridBone.NativeFieldInfoPtr_Bone));
        }
        [param: In] set
        {
          *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelBonesComponent.HybridBone.NativeFieldInfoPtr_Bone)) = value;
        }
      }

      public unsafe Transform Transform
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelBonesComponent.HybridBone.NativeFieldInfoPtr_Transform));
          return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelBonesComponent.HybridBone.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
