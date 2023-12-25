// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.FootstepAnimationEventReceiver
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
  public class FootstepAnimationEventReceiver : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HybridModelFootstepComponent;
    private static readonly IntPtr NativeMethodInfoPtr_Footstep_Public_Void_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156333, XrefRangeEnd = 1156335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Footstep(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &index;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FootstepAnimationEventReceiver.NativeMethodInfoPtr_Footstep_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FootstepAnimationEventReceiver()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepAnimationEventReceiver>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FootstepAnimationEventReceiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FootstepAnimationEventReceiver()
    {
      Il2CppClassPointerStore<FootstepAnimationEventReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (FootstepAnimationEventReceiver));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepAnimationEventReceiver>.NativeClassPtr);
      FootstepAnimationEventReceiver.NativeFieldInfoPtr_HybridModelFootstepComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepAnimationEventReceiver>.NativeClassPtr, nameof (HybridModelFootstepComponent));
      FootstepAnimationEventReceiver.NativeMethodInfoPtr_Footstep_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepAnimationEventReceiver>.NativeClassPtr, 100692028);
      FootstepAnimationEventReceiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepAnimationEventReceiver>.NativeClassPtr, 100692029);
    }

    public FootstepAnimationEventReceiver(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridModelFootstepComponent HybridModelFootstepComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FootstepAnimationEventReceiver.NativeFieldInfoPtr_HybridModelFootstepComponent));
        return pointer == IntPtr.Zero ? (HybridModelFootstepComponent) null : new HybridModelFootstepComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FootstepAnimationEventReceiver.NativeFieldInfoPtr_HybridModelFootstepComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
