// Decompiled with JetBrains decompiler
// Type: FeedAnimatorFloatParams_FromDistance
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class FeedAnimatorFloatParams_FromDistance : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Feeds;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912076, XrefRangeEnd = 912082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FeedAnimatorFloatParams_FromDistance.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FeedAnimatorFloatParams_FromDistance()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(FeedAnimatorFloatParams_FromDistance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static FeedAnimatorFloatParams_FromDistance()
  {
    Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (FeedAnimatorFloatParams_FromDistance));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance>.NativeClassPtr);
    FeedAnimatorFloatParams_FromDistance.NativeFieldInfoPtr_Feeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance>.NativeClassPtr, nameof (Feeds));
    FeedAnimatorFloatParams_FromDistance.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance>.NativeClassPtr, 100663332);
    FeedAnimatorFloatParams_FromDistance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance>.NativeClassPtr, 100663333);
  }

  public FeedAnimatorFloatParams_FromDistance(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<FeedAnimatorFloatParams_FromDistance.Feed> Feeds
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.NativeFieldInfoPtr_Feeds));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<FeedAnimatorFloatParams_FromDistance.Feed>) null : new Il2CppReferenceArray<FeedAnimatorFloatParams_FromDistance.Feed>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.NativeFieldInfoPtr_Feeds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Feed : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DistancePointA;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistancePointB;
    private static readonly System.IntPtr NativeFieldInfoPtr_InMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_InMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Animator;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParameterName;

    static Feed()
    {
      Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance>.NativeClassPtr, nameof (Feed));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr);
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_DistancePointA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (DistancePointA));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_DistancePointB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (DistancePointB));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_InMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (InMin));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_InMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (InMax));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (OutMin));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (OutMax));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (OutMultiplier));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (Animator));
      FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, nameof (ParameterName));
    }

    public Feed(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Feed()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FeedAnimatorFloatParams_FromDistance.Feed>.NativeClassPtr, data));
    }

    public unsafe Transform DistancePointA
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_DistancePointA));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_DistancePointA), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform DistancePointB
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_DistancePointB));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_DistancePointB), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float InMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_InMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_InMin)) = value;
      }
    }

    public unsafe float InMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_InMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_InMax)) = value;
      }
    }

    public unsafe float OutMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMin)) = value;
      }
    }

    public unsafe float OutMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMax)) = value;
      }
    }

    public unsafe AnimationCurve OutMultiplier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMultiplier));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_OutMultiplier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Animator Animator
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_Animator));
        return pointer == System.IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string ParameterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_ParameterName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedAnimatorFloatParams_FromDistance.Feed.NativeFieldInfoPtr_ParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
