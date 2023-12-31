// Decompiled with JetBrains decompiler
// Type: ProjectM.FootstepComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class FootstepComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FootstepEvent;
    private static readonly IntPtr NativeFieldInfoPtr_PlayWhenNotMoving;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720238, XrefRangeEnd = 720242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FootstepComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FootstepComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FootstepComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FootstepComponent()
    {
      Il2CppClassPointerStore<FootstepComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FootstepComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepComponent>.NativeClassPtr);
      FootstepComponent.NativeFieldInfoPtr_FootstepEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepComponent>.NativeClassPtr, nameof (FootstepEvent));
      FootstepComponent.NativeFieldInfoPtr_PlayWhenNotMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepComponent>.NativeClassPtr, nameof (PlayWhenNotMoving));
      FootstepComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepComponent>.NativeClassPtr, 100663660);
      FootstepComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepComponent>.NativeClassPtr, 100663661);
    }

    public FootstepComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public FmodEvent FootstepEvent
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FootstepComponent.NativeFieldInfoPtr_FootstepEvent);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FootstepComponent.NativeFieldInfoPtr_FootstepEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe bool PlayWhenNotMoving
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FootstepComponent.NativeFieldInfoPtr_PlayWhenNotMoving));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FootstepComponent.NativeFieldInfoPtr_PlayWhenNotMoving)) = value;
      }
    }
  }
}
