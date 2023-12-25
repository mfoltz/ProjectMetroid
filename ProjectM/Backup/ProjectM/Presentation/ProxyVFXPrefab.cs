// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ProxyVFXPrefab
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.VFX;

#nullable disable
namespace ProjectM.Presentation
{
  public class ProxyVFXPrefab : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParticleSystemsBlobAssetRef;
    private static readonly System.IntPtr NativeFieldInfoPtr_Textures;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curves;
    private static readonly System.IntPtr NativeFieldInfoPtr_Gradients;
    private static readonly System.IntPtr NativeFieldInfoPtr_Names;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionString;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyVFXPrefab_Il2CppReferenceArray_1_VisualEffect_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppReferenceArray_1_VisualEffect_ProxyVFXPrefab_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXPrefab.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1112104, RefRangeEnd = 1112105, XrefRangeStart = 1111947, XrefRangeEnd = 1112104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ProxyVFXPrefab CopyFrom(Il2CppReferenceArray<VisualEffect> visualEffects)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) visualEffects);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProxyVFXPrefab.NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyVFXPrefab_Il2CppReferenceArray_1_VisualEffect_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1112192, RefRangeEnd = 1112193, XrefRangeStart = 1112105, XrefRangeEnd = 1112192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyTo(
      Il2CppReferenceArray<VisualEffect> visualEffects,
      ProxyVFXPrefab data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) visualEffects);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyVFXPrefab.NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppReferenceArray_1_VisualEffect_ProxyVFXPrefab_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1112222, RefRangeEnd = 1112223, XrefRangeStart = 1112193, XrefRangeEnd = 1112222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProxyVFXPrefab()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProxyVFXPrefab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProxyVFXPrefab()
    {
      Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ProxyVFXPrefab));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr);
      ProxyVFXPrefab.NativeFieldInfoPtr_ParticleSystemsBlobAssetRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, nameof (ParticleSystemsBlobAssetRef));
      ProxyVFXPrefab.NativeFieldInfoPtr_Textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, nameof (Textures));
      ProxyVFXPrefab.NativeFieldInfoPtr_Curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, nameof (Curves));
      ProxyVFXPrefab.NativeFieldInfoPtr_Gradients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, nameof (Gradients));
      ProxyVFXPrefab.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, nameof (Names));
      ProxyVFXPrefab.NativeFieldInfoPtr_DescriptionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, nameof (DescriptionString));
      ProxyVFXPrefab.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, 100688050);
      ProxyVFXPrefab.NativeMethodInfoPtr_CopyFrom_Public_Static_ProxyVFXPrefab_Il2CppReferenceArray_1_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, 100688051);
      ProxyVFXPrefab.NativeMethodInfoPtr_CopyTo_Public_Static_Void_Il2CppReferenceArray_1_VisualEffect_ProxyVFXPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, 100688052);
      ProxyVFXPrefab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyVFXPrefab>.NativeClassPtr, 100688053);
    }

    public ProxyVFXPrefab(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BlobAssetReference<ProxyVFXParticleSystemListBlobAsset> ParticleSystemsBlobAssetRef
    {
      get
      {
        return *(BlobAssetReference<ProxyVFXParticleSystemListBlobAsset>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_ParticleSystemsBlobAssetRef));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_ParticleSystemsBlobAssetRef), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlobAssetReference<ProxyVFXParticleSystemListBlobAsset>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<Texture> Textures
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Textures));
        return pointer == System.IntPtr.Zero ? (List<Texture>) null : new List<Texture>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Textures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AnimationCurve> Curves
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Curves));
        return pointer == System.IntPtr.Zero ? (List<AnimationCurve>) null : new List<AnimationCurve>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Curves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ProxyVFXGradient> Gradients
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Gradients));
        return pointer == System.IntPtr.Zero ? (List<ProxyVFXGradient>) null : new List<ProxyVFXGradient>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Gradients), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> Names
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Names));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProxyVFXPrefab.NativeFieldInfoPtr_Names), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe string DescriptionString
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ProxyVFXPrefab.NativeFieldInfoPtr_DescriptionString, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ProxyVFXPrefab.NativeFieldInfoPtr_DescriptionString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
