// Decompiled with JetBrains decompiler
// Type: ProjectM.AnimationCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Malee;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class AnimationCollection : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PARAMETER_PREFIX;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalHitReactions;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollectionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdleAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadyAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocomotionSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimatorLayers;
    private static readonly System.IntPtr NativeFieldInfoPtr_Controllers;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditiveAnimationClips;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomizedAnimationClips;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationList;
    private static readonly System.IntPtr NativeMethodInfoPtr_SortAnimationList_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAnimationClip_Public_Boolean_String_byref_AnimationClip_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetController_Public_Boolean_AnimationClip_byref_RuntimeAnimatorController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977089, XrefRangeEnd = 977093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SortAnimationList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimationCollection.NativeMethodInfoPtr_SortAnimationList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977093, XrefRangeEnd = 977102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAnimationClip(string animationName, out AnimationClip animationClip)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(animationName);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.NativeMethodInfoPtr_TryGetAnimationClip_Public_Boolean_String_byref_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AnimationClip local = ref animationClip;
      System.IntPtr pointer = zero;
      AnimationClip animationClip1 = pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
      local = animationClip1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977102, XrefRangeEnd = 977117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetController(
      AnimationClip animationClip,
      out RuntimeAnimatorController controller)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animationClip);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.NativeMethodInfoPtr_TryGetController_Public_Boolean_AnimationClip_byref_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref RuntimeAnimatorController local = ref controller;
      System.IntPtr pointer = zero;
      RuntimeAnimatorController animatorController = pointer == System.IntPtr.Zero ? (RuntimeAnimatorController) null : new RuntimeAnimatorController(pointer);
      local = animatorController;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977117, XrefRangeEnd = 977149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimationCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimationCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnimationCollection()
    {
      Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AnimationCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr);
      AnimationCollection.NativeFieldInfoPtr_PARAMETER_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (PARAMETER_PREFIX));
      AnimationCollection.NativeFieldInfoPtr_DirectionalHitReactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (DirectionalHitReactions));
      AnimationCollection.NativeFieldInfoPtr_CollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (CollectionType));
      AnimationCollection.NativeFieldInfoPtr_IdleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (IdleAnimation));
      AnimationCollection.NativeFieldInfoPtr_ReadyAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (ReadyAnimation));
      AnimationCollection.NativeFieldInfoPtr_LocomotionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (LocomotionSettings));
      AnimationCollection.NativeFieldInfoPtr_AnimatorLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AnimatorLayers));
      AnimationCollection.NativeFieldInfoPtr_Controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (Controllers));
      AnimationCollection.NativeFieldInfoPtr_AdditiveAnimationClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AdditiveAnimationClips));
      AnimationCollection.NativeFieldInfoPtr_RandomizedAnimationClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (RandomizedAnimationClips));
      AnimationCollection.NativeFieldInfoPtr_AnimationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AnimationList));
      AnimationCollection.NativeMethodInfoPtr_SortAnimationList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, 100675503);
      AnimationCollection.NativeMethodInfoPtr_TryGetAnimationClip_Public_Boolean_String_byref_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, 100675504);
      AnimationCollection.NativeMethodInfoPtr_TryGetController_Public_Boolean_AnimationClip_byref_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, 100675505);
      AnimationCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, 100675506);
    }

    public AnimationCollection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string PARAMETER_PREFIX
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(AnimationCollection.NativeFieldInfoPtr_PARAMETER_PREFIX, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AnimationCollection.NativeFieldInfoPtr_PARAMETER_PREFIX, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppReferenceArray<AnimationClip> DirectionalHitReactions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_DirectionalHitReactions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AnimationClip>) null : new Il2CppReferenceArray<AnimationClip>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_DirectionalHitReactions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCollection.CollectionTypes CollectionType
    {
      get
      {
        return *(AnimationCollection.CollectionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_CollectionType));
      }
      [param: In] set
      {
        *(AnimationCollection.CollectionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_CollectionType)) = value;
      }
    }

    public unsafe AnimationClip IdleAnimation
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_IdleAnimation));
        return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_IdleAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationClip ReadyAnimation
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_ReadyAnimation));
        return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_ReadyAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AnimationCollection.ControllerSettingsCollection> LocomotionSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_LocomotionSettings));
        return pointer == System.IntPtr.Zero ? (List<AnimationCollection.ControllerSettingsCollection>) null : new List<AnimationCollection.ControllerSettingsCollection>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_LocomotionSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCollection.LayersArray AnimatorLayers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_AnimatorLayers));
        return pointer == System.IntPtr.Zero ? (AnimationCollection.LayersArray) null : new AnimationCollection.LayersArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_AnimatorLayers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCollection.AnimationControllerArray Controllers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_Controllers));
        return pointer == System.IntPtr.Zero ? (AnimationCollection.AnimationControllerArray) null : new AnimationCollection.AnimationControllerArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_Controllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCollection.AdditiveAnimationArray AdditiveAnimationClips
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_AdditiveAnimationClips));
        return pointer == System.IntPtr.Zero ? (AnimationCollection.AdditiveAnimationArray) null : new AnimationCollection.AdditiveAnimationArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_AdditiveAnimationClips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCollection.RandomizedAnimationArray RandomizedAnimationClips
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_RandomizedAnimationClips));
        return pointer == System.IntPtr.Zero ? (AnimationCollection.RandomizedAnimationArray) null : new AnimationCollection.RandomizedAnimationArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_RandomizedAnimationClips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AnimationCollection.AdvancedAnimation> AnimationList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_AnimationList));
        return pointer == System.IntPtr.Zero ? (List<AnimationCollection.AdvancedAnimation>) null : new List<AnimationCollection.AdvancedAnimation>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.NativeFieldInfoPtr_AnimationList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum CollectionTypes
    {
      Normal,
      Vampire,
      Object,
    }

    public enum LocomotionSetupType
    {
      None,
      State,
      StateBlendTree,
      BlendTree,
      SimpleBlendTree,
    }

    [Serializable]
    public sealed class Animation : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnimationClip;
      private static readonly System.IntPtr NativeFieldInfoPtr_EndStance;
      private static readonly System.IntPtr NativeFieldInfoPtr_LockDominantFootOnExit;
      private static readonly System.IntPtr NativeFieldInfoPtr_MountedSpineIK;
      private static readonly System.IntPtr NativeFieldInfoPtr_MountedLeftArmIK;
      private static readonly System.IntPtr NativeFieldInfoPtr_MountedRightArmIK;

      static Animation()
      {
        Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (Animation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr);
        AnimationCollection.Animation.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, nameof (Name));
        AnimationCollection.Animation.NativeFieldInfoPtr_AnimationClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, nameof (AnimationClip));
        AnimationCollection.Animation.NativeFieldInfoPtr_EndStance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, nameof (EndStance));
        AnimationCollection.Animation.NativeFieldInfoPtr_LockDominantFootOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, nameof (LockDominantFootOnExit));
        AnimationCollection.Animation.NativeFieldInfoPtr_MountedSpineIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, nameof (MountedSpineIK));
        AnimationCollection.Animation.NativeFieldInfoPtr_MountedLeftArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, nameof (MountedLeftArmIK));
        AnimationCollection.Animation.NativeFieldInfoPtr_MountedRightArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, nameof (MountedRightArmIK));
      }

      public Animation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Animation()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationCollection.Animation>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe AnimationClip AnimationClip
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_AnimationClip));
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_AnimationClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AnimationCollection.EndStance EndStance
      {
        get
        {
          return *(AnimationCollection.EndStance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_EndStance));
        }
        [param: In] set
        {
          *(AnimationCollection.EndStance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_EndStance)) = value;
        }
      }

      public unsafe bool LockDominantFootOnExit
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_LockDominantFootOnExit));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_LockDominantFootOnExit)) = value;
        }
      }

      public unsafe bool MountedSpineIK
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_MountedSpineIK));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_MountedSpineIK)) = value;
        }
      }

      public unsafe bool MountedLeftArmIK
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_MountedLeftArmIK));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_MountedLeftArmIK)) = value;
        }
      }

      public unsafe bool MountedRightArmIK
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_MountedRightArmIK));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.Animation.NativeFieldInfoPtr_MountedRightArmIK)) = value;
        }
      }
    }

    [Serializable]
    public sealed class AdditiveAnimation : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnimationClip;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsRepresentative;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsExpanded;

      static AdditiveAnimation()
      {
        Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AdditiveAnimation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr);
        AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr, nameof (Name));
        AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_AnimationClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr, nameof (AnimationClip));
        AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_IsRepresentative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr, nameof (IsRepresentative));
        AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_IsExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr, nameof (IsExpanded));
      }

      public AdditiveAnimation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AdditiveAnimation()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimation>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe AnimationClip AnimationClip
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_AnimationClip));
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_AnimationClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool IsRepresentative
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_IsRepresentative));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_IsRepresentative)) = value;
        }
      }

      public unsafe bool IsExpanded
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_IsExpanded));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdditiveAnimation.NativeFieldInfoPtr_IsExpanded)) = value;
        }
      }
    }

    [Serializable]
    public sealed class RandomAnimation : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Animations;

      static RandomAnimation()
      {
        Il2CppClassPointerStore<AnimationCollection.RandomAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (RandomAnimation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.RandomAnimation>.NativeClassPtr);
        AnimationCollection.RandomAnimation.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.RandomAnimation>.NativeClassPtr, nameof (Name));
        AnimationCollection.RandomAnimation.NativeFieldInfoPtr_Animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.RandomAnimation>.NativeClassPtr, nameof (Animations));
      }

      public RandomAnimation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RandomAnimation()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnimationCollection.RandomAnimation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationCollection.RandomAnimation>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.RandomAnimation.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.RandomAnimation.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Il2CppReferenceArray<AnimationCollection.Animation> Animations
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.RandomAnimation.NativeFieldInfoPtr_Animations));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AnimationCollection.Animation>) null : new Il2CppReferenceArray<AnimationCollection.Animation>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.RandomAnimation.NativeFieldInfoPtr_Animations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [Serializable]
    public sealed class SimpleAnimation : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AnimationClip;
      private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
      private static readonly System.IntPtr NativeFieldInfoPtr_Threshold;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsBlend;

      static SimpleAnimation()
      {
        Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (SimpleAnimation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr);
        AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_AnimationClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr, nameof (AnimationClip));
        AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr, nameof (Speed));
        AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr, nameof (Threshold));
        AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_IsBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr, nameof (IsBlend));
      }

      public SimpleAnimation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SimpleAnimation()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationCollection.SimpleAnimation>.NativeClassPtr, data));
      }

      public unsafe AnimationClip AnimationClip
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_AnimationClip));
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_AnimationClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float Speed
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_Speed));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_Speed)) = value;
        }
      }

      public unsafe float Threshold
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_Threshold));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_Threshold)) = value;
        }
      }

      public unsafe bool IsBlend
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_IsBlend));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.SimpleAnimation.NativeFieldInfoPtr_IsBlend)) = value;
        }
      }
    }

    [Serializable]
    public class AdvancedAnimationClip : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnimationClips;
      private static readonly System.IntPtr NativeFieldInfoPtr_Threshold;
      private static readonly System.IntPtr NativeFieldInfoPtr_Parameter;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimationClip_Public_get_AnimationClip_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Speed_Public_get_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationClip_Public_Void_AnimationClip_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Il2CppReferenceArray_1_SimpleAnimation_0;

      public unsafe AnimationClip AnimationClip
      {
        [CallerCount(4), CachedScanResults(RefRangeStart = 883395, RefRangeEnd = 883399, XrefRangeStart = 883395, XrefRangeEnd = 883399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr_get_AnimationClip_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
      }

      public unsafe float Speed
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr_get_Speed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(float*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977036, XrefRangeEnd = 977042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetAnimationClip(AnimationClip clip)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr_SetAnimationClip_Public_Void_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977042, XrefRangeEnd = 977051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AdvancedAnimationClip()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 106036, RefRangeEnd = 106039, XrefRangeStart = 106036, XrefRangeEnd = 106039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AdvancedAnimationClip(
        AnimationCollection.AdvancedAnimationClip.AnimationType type,
        [Optional] Il2CppReferenceArray<AnimationCollection.SimpleAnimation> animationClips)
      {
        if (animationClips == null)
          animationClips = (Il2CppReferenceArray<AnimationCollection.SimpleAnimation>) new Il2CppStructArray<AnimationCollection.SimpleAnimation>(0L);
        // ISSUE: explicit constructor call
        this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr));
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &type;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animationClips);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Il2CppReferenceArray_1_SimpleAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public AdvancedAnimationClip(
        AnimationCollection.AdvancedAnimationClip.AnimationType type,
        params AnimationCollection.SimpleAnimation[] animationClips)
        : this(type, new Il2CppReferenceArray<AnimationCollection.SimpleAnimation>(animationClips))
      {
      }

      static AdvancedAnimationClip()
      {
        Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AdvancedAnimationClip));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr);
        AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, nameof (Type));
        AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_AnimationClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, nameof (AnimationClips));
        AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, nameof (Threshold));
        AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, nameof (Parameter));
        AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr_get_AnimationClip_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, 100675507);
        AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr_get_Speed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, 100675508);
        AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr_SetAnimationClip_Public_Void_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, 100675509);
        AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, 100675510);
        AnimationCollection.AdvancedAnimationClip.NativeMethodInfoPtr__ctor_Public_Void_AnimationType_Il2CppReferenceArray_1_SimpleAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimationClip>.NativeClassPtr, 100675511);
      }

      public AdvancedAnimationClip(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe AnimationCollection.AdvancedAnimationClip.AnimationType Type
      {
        get
        {
          return *(AnimationCollection.AdvancedAnimationClip.AnimationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(AnimationCollection.AdvancedAnimationClip.AnimationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public unsafe Il2CppReferenceArray<AnimationCollection.SimpleAnimation> AnimationClips
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_AnimationClips));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AnimationCollection.SimpleAnimation>) null : new Il2CppReferenceArray<AnimationCollection.SimpleAnimation>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_AnimationClips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float Threshold
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Threshold));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Threshold)) = value;
        }
      }

      public unsafe string Parameter
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Parameter)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimationClip.NativeFieldInfoPtr_Parameter), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public enum AnimationType
      {
        Single,
        Multi,
        Blend,
        Locked,
      }
    }

    [Serializable]
    public class AdvancedAnimation : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_AdvancedAnimationClip;
      private static readonly System.IntPtr NativeFieldInfoPtr_MountedSpineIK;
      private static readonly System.IntPtr NativeFieldInfoPtr_MountedLeftArmIK;
      private static readonly System.IntPtr NativeFieldInfoPtr_MountedRightArmIK;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsExpanded;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimationClip_Public_AnimationClip_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AnimationClip_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AdvancedAnimation_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 977051, RefRangeEnd = 977053, XrefRangeStart = 977051, XrefRangeEnd = 977051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AnimationClip GetAnimationClip()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimation.NativeMethodInfoPtr_GetAnimationClip_Public_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977053, XrefRangeEnd = 977071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AdvancedAnimation(string name, AnimationClip clip)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimation.NativeMethodInfoPtr__ctor_Public_Void_String_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977071, XrefRangeEnd = 977073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(AnimationCollection.AdvancedAnimation aa)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aa);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdvancedAnimation.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AdvancedAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static AdvancedAnimation()
      {
        Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AdvancedAnimation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr);
        AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, nameof (Name));
        AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_AdvancedAnimationClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, nameof (AdvancedAnimationClip));
        AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedSpineIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, nameof (MountedSpineIK));
        AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedLeftArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, nameof (MountedLeftArmIK));
        AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedRightArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, nameof (MountedRightArmIK));
        AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_IsExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, nameof (IsExpanded));
        AnimationCollection.AdvancedAnimation.NativeMethodInfoPtr_GetAnimationClip_Public_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, 100675512);
        AnimationCollection.AdvancedAnimation.NativeMethodInfoPtr__ctor_Public_Void_String_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, 100675513);
        AnimationCollection.AdvancedAnimation.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AdvancedAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdvancedAnimation>.NativeClassPtr, 100675514);
      }

      public AdvancedAnimation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe AnimationCollection.AdvancedAnimationClip AdvancedAnimationClip
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_AdvancedAnimationClip));
          return pointer == System.IntPtr.Zero ? (AnimationCollection.AdvancedAnimationClip) null : new AnimationCollection.AdvancedAnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_AdvancedAnimationClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool MountedSpineIK
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedSpineIK));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedSpineIK)) = value;
        }
      }

      public unsafe bool MountedLeftArmIK
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedLeftArmIK));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedLeftArmIK)) = value;
        }
      }

      public unsafe bool MountedRightArmIK
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedRightArmIK));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_MountedRightArmIK)) = value;
        }
      }

      public unsafe bool IsExpanded
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_IsExpanded));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.AdvancedAnimation.NativeFieldInfoPtr_IsExpanded)) = value;
        }
      }
    }

    [Serializable]
    public class ControllerSettingsCollection : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Controller;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocomotionSetup;
      private static readonly System.IntPtr NativeFieldInfoPtr_WalkState;
      private static readonly System.IntPtr NativeFieldInfoPtr_RunState;
      private static readonly System.IntPtr NativeFieldInfoPtr_IdleState;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReadyState;
      private static readonly System.IntPtr NativeFieldInfoPtr_IdlePose;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReadyPose;
      private static readonly System.IntPtr NativeFieldInfoPtr_WalkAnimationVelocity;
      private static readonly System.IntPtr NativeFieldInfoPtr_RunAnimationVelocity;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsExpanded;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverrideAnimations;
      private static readonly System.IntPtr NativeFieldInfoPtr_IdleToRunTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_IdleToWalkTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_IdleToReadyTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReadyToRunTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReadyToWalkTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReadyToIdleTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_RunToIdleTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_RunToReadyTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_RunToWalkTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_WalkToIdleTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_WalkToReadyTransitionTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_WalkToRunTransitionTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IdleAnimation_Public_get_AnimationClip_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_ReadyAnimation_Public_get_AnimationClip_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      public unsafe AnimationClip IdleAnimation
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.ControllerSettingsCollection.NativeMethodInfoPtr_get_IdleAnimation_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
      }

      public unsafe AnimationClip ReadyAnimation
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimationCollection.ControllerSettingsCollection.NativeMethodInfoPtr_get_ReadyAnimation_Public_get_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
      }

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ControllerSettingsCollection()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.ControllerSettingsCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ControllerSettingsCollection()
      {
        Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (ControllerSettingsCollection));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr);
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (Controller));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_LocomotionSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (LocomotionSetup));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (WalkState));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (RunState));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (IdleState));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (ReadyState));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdlePose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (IdlePose));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (ReadyPose));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkAnimationVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (WalkAnimationVelocity));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunAnimationVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (RunAnimationVelocity));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IsExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (IsExpanded));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_OverrideAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (OverrideAnimations));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToRunTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (IdleToRunTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToWalkTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (IdleToWalkTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToReadyTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (IdleToReadyTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToRunTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (ReadyToRunTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToWalkTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (ReadyToWalkTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToIdleTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (ReadyToIdleTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToIdleTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (RunToIdleTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToReadyTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (RunToReadyTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToWalkTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (RunToWalkTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToIdleTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (WalkToIdleTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToReadyTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (WalkToReadyTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToRunTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (WalkToRunTransitionTime));
        AnimationCollection.ControllerSettingsCollection.NativeMethodInfoPtr_get_IdleAnimation_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, 100675515);
        AnimationCollection.ControllerSettingsCollection.NativeMethodInfoPtr_get_ReadyAnimation_Public_get_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, 100675516);
        AnimationCollection.ControllerSettingsCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, 100675517);
      }

      public ControllerSettingsCollection(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe RuntimeAnimatorController Controller
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_Controller));
          return pointer == System.IntPtr.Zero ? (RuntimeAnimatorController) null : new RuntimeAnimatorController(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AnimationCollection.LocomotionSetupType LocomotionSetup
      {
        get
        {
          return *(AnimationCollection.LocomotionSetupType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_LocomotionSetup));
        }
        [param: In] set
        {
          *(AnimationCollection.LocomotionSetupType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_LocomotionSetup)) = value;
        }
      }

      public unsafe AnimationCollection.AdvancedAnimationClip WalkState
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkState));
          return pointer == System.IntPtr.Zero ? (AnimationCollection.AdvancedAnimationClip) null : new AnimationCollection.AdvancedAnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AnimationCollection.AdvancedAnimationClip RunState
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunState));
          return pointer == System.IntPtr.Zero ? (AnimationCollection.AdvancedAnimationClip) null : new AnimationCollection.AdvancedAnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AnimationCollection.AdvancedAnimationClip IdleState
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleState));
          return pointer == System.IntPtr.Zero ? (AnimationCollection.AdvancedAnimationClip) null : new AnimationCollection.AdvancedAnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AnimationCollection.AdvancedAnimationClip ReadyState
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyState));
          return pointer == System.IntPtr.Zero ? (AnimationCollection.AdvancedAnimationClip) null : new AnimationCollection.AdvancedAnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AnimationClip IdlePose
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdlePose));
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdlePose), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AnimationClip ReadyPose
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyPose));
          return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyPose), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float WalkAnimationVelocity
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkAnimationVelocity));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkAnimationVelocity)) = value;
        }
      }

      public unsafe float RunAnimationVelocity
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunAnimationVelocity));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunAnimationVelocity)) = value;
        }
      }

      public unsafe bool IsExpanded
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IsExpanded));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IsExpanded)) = value;
        }
      }

      public unsafe List<AnimationCollection.ControllerSettingsCollection.OverrideAnimation> OverrideAnimations
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_OverrideAnimations));
          return pointer == System.IntPtr.Zero ? (List<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>) null : new List<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_OverrideAnimations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float IdleToRunTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToRunTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToRunTransitionTime)) = value;
        }
      }

      public unsafe float IdleToWalkTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToWalkTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToWalkTransitionTime)) = value;
        }
      }

      public unsafe float IdleToReadyTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToReadyTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_IdleToReadyTransitionTime)) = value;
        }
      }

      public unsafe float ReadyToRunTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToRunTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToRunTransitionTime)) = value;
        }
      }

      public unsafe float ReadyToWalkTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToWalkTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToWalkTransitionTime)) = value;
        }
      }

      public unsafe float ReadyToIdleTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToIdleTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_ReadyToIdleTransitionTime)) = value;
        }
      }

      public unsafe float RunToIdleTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToIdleTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToIdleTransitionTime)) = value;
        }
      }

      public unsafe float RunToReadyTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToReadyTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToReadyTransitionTime)) = value;
        }
      }

      public unsafe float RunToWalkTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToWalkTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_RunToWalkTransitionTime)) = value;
        }
      }

      public unsafe float WalkToIdleTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToIdleTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToIdleTransitionTime)) = value;
        }
      }

      public unsafe float WalkToReadyTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToReadyTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToReadyTransitionTime)) = value;
        }
      }

      public unsafe float WalkToRunTransitionTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToRunTransitionTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.NativeFieldInfoPtr_WalkToRunTransitionTime)) = value;
        }
      }

      [Serializable]
      public sealed class OverrideAnimation : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Name;
        private static readonly System.IntPtr NativeFieldInfoPtr_AnimationClip;

        static OverrideAnimation()
        {
          Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection>.NativeClassPtr, nameof (OverrideAnimation));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>.NativeClassPtr);
          AnimationCollection.ControllerSettingsCollection.OverrideAnimation.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>.NativeClassPtr, nameof (Name));
          AnimationCollection.ControllerSettingsCollection.OverrideAnimation.NativeFieldInfoPtr_AnimationClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>.NativeClassPtr, nameof (AnimationClip));
        }

        public OverrideAnimation(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public OverrideAnimation()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationCollection.ControllerSettingsCollection.OverrideAnimation>.NativeClassPtr, data));
        }

        public unsafe string Name
        {
          get
          {
            return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.OverrideAnimation.NativeFieldInfoPtr_Name)));
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.OverrideAnimation.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
          }
        }

        public unsafe AnimationClip AnimationClip
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.OverrideAnimation.NativeFieldInfoPtr_AnimationClip));
            return pointer == System.IntPtr.Zero ? (AnimationClip) null : new AnimationClip(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AnimationCollection.ControllerSettingsCollection.OverrideAnimation.NativeFieldInfoPtr_AnimationClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }
      }
    }

    [Serializable]
    public class LayersArray : ReorderableArray<string>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 977076, RefRangeEnd = 977077, XrefRangeStart = 977073, XrefRangeEnd = 977076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe LayersArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.LayersArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.LayersArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static LayersArray()
      {
        Il2CppClassPointerStore<AnimationCollection.LayersArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (LayersArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.LayersArray>.NativeClassPtr);
        AnimationCollection.LayersArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.LayersArray>.NativeClassPtr, 100675518);
      }

      public LayersArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class AnimationControllerArray : ReorderableArray<RuntimeAnimatorController>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 977080, RefRangeEnd = 977081, XrefRangeStart = 977077, XrefRangeEnd = 977080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AnimationControllerArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.AnimationControllerArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AnimationControllerArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AnimationControllerArray()
      {
        Il2CppClassPointerStore<AnimationCollection.AnimationControllerArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AnimationControllerArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.AnimationControllerArray>.NativeClassPtr);
        AnimationCollection.AnimationControllerArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AnimationControllerArray>.NativeClassPtr, 100675519);
      }

      public AnimationControllerArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class AdditiveAnimationArray : ReorderableArray<AnimationCollection.AdditiveAnimation>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 977084, RefRangeEnd = 977085, XrefRangeStart = 977081, XrefRangeEnd = 977084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AdditiveAnimationArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimationArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.AdditiveAnimationArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AdditiveAnimationArray()
      {
        Il2CppClassPointerStore<AnimationCollection.AdditiveAnimationArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (AdditiveAnimationArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimationArray>.NativeClassPtr);
        AnimationCollection.AdditiveAnimationArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.AdditiveAnimationArray>.NativeClassPtr, 100675520);
      }

      public AdditiveAnimationArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class RandomizedAnimationArray : ReorderableArray<AnimationCollection.RandomAnimation>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 977088, RefRangeEnd = 977089, XrefRangeStart = 977085, XrefRangeEnd = 977088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RandomizedAnimationArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCollection.RandomizedAnimationArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimationCollection.RandomizedAnimationArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RandomizedAnimationArray()
      {
        Il2CppClassPointerStore<AnimationCollection.RandomizedAnimationArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCollection>.NativeClassPtr, nameof (RandomizedAnimationArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCollection.RandomizedAnimationArray>.NativeClassPtr);
        AnimationCollection.RandomizedAnimationArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCollection.RandomizedAnimationArray>.NativeClassPtr, 100675521);
      }

      public RandomizedAnimationArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public enum EndStance
    {
      Parallel,
      LeftFootForwardRightFootBack,
      RightFootForwardLeftFootBack,
    }
  }
}
