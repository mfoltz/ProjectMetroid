// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.InstantiateParticleSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class InstantiateParticleSystem : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_DyeVariationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideOutsideVision;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InstantiateParticleSystem.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InstantiateParticleSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InstantiateParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InstantiateParticleSystem()
    {
      Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (InstantiateParticleSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr);
      InstantiateParticleSystem.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr, nameof (Prefab));
      InstantiateParticleSystem.NativeFieldInfoPtr_PlaybackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr, nameof (PlaybackSpeed));
      InstantiateParticleSystem.NativeFieldInfoPtr_DyeVariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr, nameof (DyeVariationIndex));
      InstantiateParticleSystem.NativeFieldInfoPtr_HideOutsideVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr, nameof (HideOutsideVision));
      InstantiateParticleSystem.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr, 100687517);
      InstantiateParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiateParticleSystem>.NativeClassPtr, 100687518);
    }

    public InstantiateParticleSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_Prefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float PlaybackSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_PlaybackSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_PlaybackSpeed)) = value;
      }
    }

    public unsafe int DyeVariationIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_DyeVariationIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_DyeVariationIndex)) = value;
      }
    }

    public unsafe bool HideOutsideVision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_HideOutsideVision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParticleSystem.NativeFieldInfoPtr_HideOutsideVision)) = value;
      }
    }
  }
}
