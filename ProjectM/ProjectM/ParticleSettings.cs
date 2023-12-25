// Decompiled with JetBrains decompiler
// Type: ProjectM.ParticleSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.VFX;

#nullable disable
namespace ProjectM
{
  public class ParticleSettings : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticleSystemsInChildren;
    private static readonly System.IntPtr NativeFieldInfoPtr__DecalProjectorInChildren;
    private static readonly System.IntPtr NativeFieldInfoPtr__VisualEffectInChildren;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr_DecalProjectors;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffects;
    private static readonly System.IntPtr NativeFieldInfoPtr_Transform;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCullingSphere;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoundingSphere;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCullingDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_CullingDuration;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnsureChildrenExist_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateParticleSettings_Private_Void_List_1_ParticleSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDecalSettings_Private_Void_List_1_DecalProjector_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateVisualEffectSettings_Private_Void_List_1_VisualEffect_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054229, XrefRangeEnd = 1054231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleSettings.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1054326, RefRangeEnd = 1054328, XrefRangeStart = 1054231, XrefRangeEnd = 1054326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool EnsureChildrenExist()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleSettings.NativeMethodInfoPtr_EnsureChildrenExist_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1054343, RefRangeEnd = 1054345, XrefRangeStart = 1054328, XrefRangeEnd = 1054343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateParticleSettings(List<ParticleSystem> particleSystems)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) particleSystems);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleSettings.NativeMethodInfoPtr_CreateParticleSettings_Private_Void_List_1_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1054360, RefRangeEnd = 1054362, XrefRangeStart = 1054345, XrefRangeEnd = 1054360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateDecalSettings(List<DecalProjector> decalProjectors)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decalProjectors);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleSettings.NativeMethodInfoPtr_CreateDecalSettings_Private_Void_List_1_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1054377, RefRangeEnd = 1054379, XrefRangeStart = 1054362, XrefRangeEnd = 1054377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateVisualEffectSettings(List<VisualEffect> visualEffects)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) visualEffects);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleSettings.NativeMethodInfoPtr_CreateVisualEffectSettings_Private_Void_List_1_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054379, XrefRangeEnd = 1054384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleSettings.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054384, XrefRangeEnd = 1054409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticleSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ParticleSettings()
    {
      Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ParticleSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr);
      ParticleSettings.NativeFieldInfoPtr__ParticleSystemsInChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (_ParticleSystemsInChildren));
      ParticleSettings.NativeFieldInfoPtr__DecalProjectorInChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (_DecalProjectorInChildren));
      ParticleSettings.NativeFieldInfoPtr__VisualEffectInChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (_VisualEffectInChildren));
      ParticleSettings.NativeFieldInfoPtr_ParticleSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (ParticleSystems));
      ParticleSettings.NativeFieldInfoPtr_DecalProjectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (DecalProjectors));
      ParticleSettings.NativeFieldInfoPtr_VisualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (VisualEffects));
      ParticleSettings.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (Transform));
      ParticleSettings.NativeFieldInfoPtr_UseCullingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (UseCullingSphere));
      ParticleSettings.NativeFieldInfoPtr_BoundingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (BoundingSphere));
      ParticleSettings.NativeFieldInfoPtr_UseCullingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (UseCullingDuration));
      ParticleSettings.NativeFieldInfoPtr_CullingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (CullingDuration));
      ParticleSettings.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, 100682945);
      ParticleSettings.NativeMethodInfoPtr_EnsureChildrenExist_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, 100682946);
      ParticleSettings.NativeMethodInfoPtr_CreateParticleSettings_Private_Void_List_1_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, 100682947);
      ParticleSettings.NativeMethodInfoPtr_CreateDecalSettings_Private_Void_List_1_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, 100682948);
      ParticleSettings.NativeMethodInfoPtr_CreateVisualEffectSettings_Private_Void_List_1_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, 100682949);
      ParticleSettings.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, 100682950);
      ParticleSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, 100682951);
    }

    public ParticleSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe List<ParticleSystem> _ParticleSystemsInChildren
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticleSettings.NativeFieldInfoPtr__ParticleSystemsInChildren, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<ParticleSystem>) null : new List<ParticleSystem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticleSettings.NativeFieldInfoPtr__ParticleSystemsInChildren, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<DecalProjector> _DecalProjectorInChildren
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticleSettings.NativeFieldInfoPtr__DecalProjectorInChildren, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<DecalProjector>) null : new List<DecalProjector>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticleSettings.NativeFieldInfoPtr__DecalProjectorInChildren, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<VisualEffect> _VisualEffectInChildren
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticleSettings.NativeFieldInfoPtr__VisualEffectInChildren, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<VisualEffect>) null : new List<VisualEffect>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticleSettings.NativeFieldInfoPtr__VisualEffectInChildren, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ParticleSettings.ParticleSetting> ParticleSystems
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_ParticleSystems));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ParticleSettings.ParticleSetting>) null : new Il2CppReferenceArray<ParticleSettings.ParticleSetting>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_ParticleSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ParticleSettings.DecalSetting> DecalProjectors
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_DecalProjectors));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ParticleSettings.DecalSetting>) null : new Il2CppReferenceArray<ParticleSettings.DecalSetting>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_DecalProjectors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ParticleSettings.VisualEffectSetting> VisualEffects
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_VisualEffects));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ParticleSettings.VisualEffectSetting>) null : new Il2CppReferenceArray<ParticleSettings.VisualEffectSetting>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_VisualEffects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform Transform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_Transform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseCullingSphere
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_UseCullingSphere));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_UseCullingSphere)) = value;
      }
    }

    public unsafe float BoundingSphere
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_BoundingSphere));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_BoundingSphere)) = value;
      }
    }

    public unsafe bool UseCullingDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_UseCullingDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_UseCullingDuration)) = value;
      }
    }

    public unsafe float CullingDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_CullingDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.NativeFieldInfoPtr_CullingDuration)) = value;
      }
    }

    public enum ParticleStopBehaviour
    {
      Clear,
      StopEmit,
    }

    public enum VFXStopBehaviour
    {
      Trail,
      Clear,
    }

    [Serializable]
    public sealed class ParticleSetting : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ParticleSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_StopBehaviour;

      static ParticleSetting()
      {
        Il2CppClassPointerStore<ParticleSettings.ParticleSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (ParticleSetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSettings.ParticleSetting>.NativeClassPtr);
        ParticleSettings.ParticleSetting.NativeFieldInfoPtr_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.ParticleSetting>.NativeClassPtr, nameof (ParticleSystem));
        ParticleSettings.ParticleSetting.NativeFieldInfoPtr_StopBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.ParticleSetting>.NativeClassPtr, nameof (StopBehaviour));
      }

      public ParticleSetting(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ParticleSetting()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSettings.ParticleSetting>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSettings.ParticleSetting>.NativeClassPtr, data));
      }

      public unsafe ParticleSystem ParticleSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.ParticleSetting.NativeFieldInfoPtr_ParticleSystem));
          return pointer == System.IntPtr.Zero ? (ParticleSystem) null : new ParticleSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.ParticleSetting.NativeFieldInfoPtr_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ParticleSettings.ParticleStopBehaviour StopBehaviour
      {
        get
        {
          return *(ParticleSettings.ParticleStopBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.ParticleSetting.NativeFieldInfoPtr_StopBehaviour));
        }
        [param: In] set
        {
          *(ParticleSettings.ParticleStopBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.ParticleSetting.NativeFieldInfoPtr_StopBehaviour)) = value;
        }
      }
    }

    [Serializable]
    public sealed class DecalSetting : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DecalProjector;
      private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartFadeFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceFadeStart;
      private static readonly System.IntPtr NativeFieldInfoPtr_UseFadeOutTimeAsMaxAllowedLifetime;
      private static readonly System.IntPtr NativeFieldInfoPtr_DefaultFadeFactor;

      static DecalSetting()
      {
        Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (DecalSetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr);
        ParticleSettings.DecalSetting.NativeFieldInfoPtr_DecalProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, nameof (DecalProjector));
        ParticleSettings.DecalSetting.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, nameof (FadeOutTime));
        ParticleSettings.DecalSetting.NativeFieldInfoPtr_StartFadeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, nameof (StartFadeFactor));
        ParticleSettings.DecalSetting.NativeFieldInfoPtr_TimeSinceFadeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, nameof (TimeSinceFadeStart));
        ParticleSettings.DecalSetting.NativeFieldInfoPtr_UseFadeOutTimeAsMaxAllowedLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, nameof (UseFadeOutTimeAsMaxAllowedLifetime));
        ParticleSettings.DecalSetting.NativeFieldInfoPtr_DefaultFadeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, nameof (DefaultFadeFactor));
      }

      public DecalSetting(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public DecalSetting()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSettings.DecalSetting>.NativeClassPtr, data));
      }

      public unsafe DecalProjector DecalProjector
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_DecalProjector));
          return pointer == System.IntPtr.Zero ? (DecalProjector) null : new DecalProjector(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_DecalProjector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float FadeOutTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_FadeOutTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_FadeOutTime)) = value;
        }
      }

      public unsafe float StartFadeFactor
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_StartFadeFactor));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_StartFadeFactor)) = value;
        }
      }

      public unsafe float TimeSinceFadeStart
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_TimeSinceFadeStart));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_TimeSinceFadeStart)) = value;
        }
      }

      public unsafe bool UseFadeOutTimeAsMaxAllowedLifetime
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_UseFadeOutTimeAsMaxAllowedLifetime));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_UseFadeOutTimeAsMaxAllowedLifetime)) = value;
        }
      }

      public unsafe float DefaultFadeFactor
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_DefaultFadeFactor));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.DecalSetting.NativeFieldInfoPtr_DefaultFadeFactor)) = value;
        }
      }
    }

    [Serializable]
    public sealed class VisualEffectSetting : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_VisualEffect;
      private static readonly System.IntPtr NativeFieldInfoPtr_StopBehaviour;
      private static readonly System.IntPtr NativeFieldInfoPtr_TrailFadeTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceShouldBeDeleted;

      static VisualEffectSetting()
      {
        Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSettings>.NativeClassPtr, nameof (VisualEffectSetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr);
        ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_VisualEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr, nameof (VisualEffect));
        ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_StopBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr, nameof (StopBehaviour));
        ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_TrailFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr, nameof (TrailFadeTime));
        ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_TimeSinceShouldBeDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr, nameof (TimeSinceShouldBeDeleted));
      }

      public VisualEffectSetting(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public VisualEffectSetting()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSettings.VisualEffectSetting>.NativeClassPtr, data));
      }

      public unsafe VisualEffect VisualEffect
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_VisualEffect));
          return pointer == System.IntPtr.Zero ? (VisualEffect) null : new VisualEffect(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_VisualEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ParticleSettings.VFXStopBehaviour StopBehaviour
      {
        get
        {
          return *(ParticleSettings.VFXStopBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_StopBehaviour));
        }
        [param: In] set
        {
          *(ParticleSettings.VFXStopBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_StopBehaviour)) = value;
        }
      }

      public unsafe float TrailFadeTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_TrailFadeTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_TrailFadeTime)) = value;
        }
      }

      public unsafe float TimeSinceShouldBeDeleted
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_TimeSinceShouldBeDeleted));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleSettings.VisualEffectSetting.NativeFieldInfoPtr_TimeSinceShouldBeDeleted)) = value;
        }
      }
    }
  }
}
