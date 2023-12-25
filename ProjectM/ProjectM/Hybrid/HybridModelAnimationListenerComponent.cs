// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelAnimationListenerComponent
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
namespace ProjectM.Hybrid
{
  public class HybridModelAnimationListenerComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Animator;
    private static readonly IntPtr NativeFieldInfoPtr_UseOverrideController;
    private static readonly IntPtr NativeFieldInfoPtr_AnimationRemappingAsset;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_String_Int32_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157342, XrefRangeEnd = 1157368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationListenerComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1157394, RefRangeEnd = 1157396, XrefRangeStart = 1157368, XrefRangeEnd = 1157394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Play(
      string animationName,
      int layer,
      float blendTime,
      float normalizedTime,
      float speed)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(animationName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &layer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &blendTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &normalizedTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &speed;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationListenerComponent.NativeMethodInfoPtr_Play_Public_Void_String_Int32_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157396, XrefRangeEnd = 1157400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationListenerComponent.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelAnimationListenerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationListenerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelAnimationListenerComponent()
    {
      Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelAnimationListenerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr);
      HybridModelAnimationListenerComponent.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr, nameof (Animator));
      HybridModelAnimationListenerComponent.NativeFieldInfoPtr_UseOverrideController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr, nameof (UseOverrideController));
      HybridModelAnimationListenerComponent.NativeFieldInfoPtr_AnimationRemappingAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr, nameof (AnimationRemappingAsset));
      HybridModelAnimationListenerComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr, 100692128);
      HybridModelAnimationListenerComponent.NativeMethodInfoPtr_Play_Public_Void_String_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr, 100692129);
      HybridModelAnimationListenerComponent.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr, 100692130);
      HybridModelAnimationListenerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationListenerComponent>.NativeClassPtr, 100692131);
    }

    public HybridModelAnimationListenerComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Animator Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationListenerComponent.NativeFieldInfoPtr_Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationListenerComponent.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseOverrideController
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationListenerComponent.NativeFieldInfoPtr_UseOverrideController));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationListenerComponent.NativeFieldInfoPtr_UseOverrideController)) = value;
      }
    }

    public unsafe HybridModelAnimationRemappingAsset AnimationRemappingAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationListenerComponent.NativeFieldInfoPtr_AnimationRemappingAsset));
        return pointer == IntPtr.Zero ? (HybridModelAnimationRemappingAsset) null : new HybridModelAnimationRemappingAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationListenerComponent.NativeFieldInfoPtr_AnimationRemappingAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
