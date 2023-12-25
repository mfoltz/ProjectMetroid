// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Presentation_ProxyVFXPrefab_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Presentation;
using System;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Presentation_ProxyVFXPrefab_PropertyBag : 
    ContainerPropertyBag<ProxyVFXPrefab>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1172010, RefRangeEnd = 1172011, XrefRangeStart = 1171957, XrefRangeEnd = 1172010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Presentation_ProxyVFXPrefab_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Presentation_ProxyVFXPrefab_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Presentation_ProxyVFXPrefab_PropertyBag));
      ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr, 100693508);
    }

    public ProjectM_Presentation_ProxyVFXPrefab_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class ParticleSystemsBlobAssetRef_Property : 
      Property<ProxyVFXPrefab, BlobAssetReference<ProxyVFXParticleSystemListBlobAsset>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_BlobAssetReference_1_ProxyVFXParticleSystemListBlobAsset_byref_ProxyVFXPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_BlobAssetReference_1_ProxyVFXParticleSystemListBlobAsset_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171903, XrefRangeEnd = 1171905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171908, RefRangeEnd = 1171909, XrefRangeStart = 1171905, XrefRangeEnd = 1171908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ParticleSystemsBlobAssetRef_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe BlobAssetReference<ProxyVFXParticleSystemListBlobAsset> GetValue(
        ref ProxyVFXPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_BlobAssetReference_1_ProxyVFXParticleSystemListBlobAsset_byref_ProxyVFXPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer);
        local = proxyVfxPrefab;
        return *(BlobAssetReference<ProxyVFXParticleSystemListBlobAsset>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ProxyVFXPrefab container,
        BlobAssetReference<ProxyVFXParticleSystemListBlobAsset> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_BlobAssetReference_1_ProxyVFXParticleSystemListBlobAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer);
        local = proxyVfxPrefab;
      }

      static ParticleSystemsBlobAssetRef_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr, nameof (ParticleSystemsBlobAssetRef_Property));
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property>.NativeClassPtr, 100693509);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property>.NativeClassPtr, 100693510);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property>.NativeClassPtr, 100693511);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_BlobAssetReference_1_ProxyVFXParticleSystemListBlobAsset_byref_ProxyVFXPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property>.NativeClassPtr, 100693512);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_BlobAssetReference_1_ProxyVFXParticleSystemListBlobAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.ParticleSystemsBlobAssetRef_Property>.NativeClassPtr, 100693513);
      }

      public ParticleSystemsBlobAssetRef_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Textures_Property : Property<ProxyVFXPrefab, List<Texture>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_Texture_byref_ProxyVFXPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_Texture_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171909, XrefRangeEnd = 1171911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(25), CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171914, RefRangeEnd = 1171915, XrefRangeStart = 1171911, XrefRangeEnd = 1171914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Textures_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<Texture> GetValue(ref ProxyVFXPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_Texture_byref_ProxyVFXPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer1 = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer1 == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer1);
        local = proxyVfxPrefab;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<Texture>) null : new List<Texture>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171915, XrefRangeEnd = 1171921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ProxyVFXPrefab container, List<Texture> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer);
        local = proxyVfxPrefab;
      }

      static Textures_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr, nameof (Textures_Property));
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property>.NativeClassPtr, 100693514);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property>.NativeClassPtr, 100693515);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property>.NativeClassPtr, 100693516);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_Texture_byref_ProxyVFXPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property>.NativeClassPtr, 100693517);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Textures_Property>.NativeClassPtr, 100693518);
      }

      public Textures_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Curves_Property : Property<ProxyVFXPrefab, List<AnimationCurve>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_AnimationCurve_byref_ProxyVFXPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_AnimationCurve_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171921, XrefRangeEnd = 1171923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(25), CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171926, RefRangeEnd = 1171927, XrefRangeStart = 1171923, XrefRangeEnd = 1171926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Curves_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<AnimationCurve> GetValue(ref ProxyVFXPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_AnimationCurve_byref_ProxyVFXPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer1 = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer1 == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer1);
        local = proxyVfxPrefab;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<AnimationCurve>) null : new List<AnimationCurve>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171927, XrefRangeEnd = 1171933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ProxyVFXPrefab container, List<AnimationCurve> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_AnimationCurve_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer);
        local = proxyVfxPrefab;
      }

      static Curves_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr, nameof (Curves_Property));
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property>.NativeClassPtr, 100693519);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property>.NativeClassPtr, 100693520);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property>.NativeClassPtr, 100693521);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_AnimationCurve_byref_ProxyVFXPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property>.NativeClassPtr, 100693522);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Curves_Property>.NativeClassPtr, 100693523);
      }

      public Curves_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Gradients_Property : Property<ProxyVFXPrefab, List<ProxyVFXGradient>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_ProxyVFXGradient_byref_ProxyVFXPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_ProxyVFXGradient_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171933, XrefRangeEnd = 1171935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(25), CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171938, RefRangeEnd = 1171939, XrefRangeStart = 1171935, XrefRangeEnd = 1171938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Gradients_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<ProxyVFXGradient> GetValue(ref ProxyVFXPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_ProxyVFXGradient_byref_ProxyVFXPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer1 = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer1 == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer1);
        local = proxyVfxPrefab;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<ProxyVFXGradient>) null : new List<ProxyVFXGradient>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171939, XrefRangeEnd = 1171945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ProxyVFXPrefab container,
        List<ProxyVFXGradient> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_ProxyVFXGradient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer);
        local = proxyVfxPrefab;
      }

      static Gradients_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr, nameof (Gradients_Property));
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property>.NativeClassPtr, 100693524);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property>.NativeClassPtr, 100693525);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property>.NativeClassPtr, 100693526);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_ProxyVFXGradient_byref_ProxyVFXPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property>.NativeClassPtr, 100693527);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_ProxyVFXGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Gradients_Property>.NativeClassPtr, 100693528);
      }

      public Gradients_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Names_Property : Property<ProxyVFXPrefab, List<string>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_String_byref_ProxyVFXPrefab_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171945, XrefRangeEnd = 1171947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(25), CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1171950, RefRangeEnd = 1171951, XrefRangeStart = 1171947, XrefRangeEnd = 1171950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Names_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe List<string> GetValue(ref ProxyVFXPrefab container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_String_byref_ProxyVFXPrefab_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer1 = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer1 == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer1);
        local = proxyVfxPrefab;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (List<string>) null : new List<string>(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171951, XrefRangeEnd = 1171957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref ProxyVFXPrefab container, List<string> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ProxyVFXPrefab local = ref container;
        IntPtr pointer = ptr;
        ProxyVFXPrefab proxyVfxPrefab = pointer == IntPtr.Zero ? (ProxyVFXPrefab) null : new ProxyVFXPrefab(pointer);
        local = proxyVfxPrefab;
      }

      static Names_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag>.NativeClassPtr, nameof (Names_Property));
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property>.NativeClassPtr, 100693529);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property>.NativeClassPtr, 100693530);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property>.NativeClassPtr, 100693531);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_List_1_String_byref_ProxyVFXPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property>.NativeClassPtr, 100693532);
        ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ProxyVFXPrefab_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_ProxyVFXPrefab_PropertyBag.Names_Property>.NativeClassPtr, 100693533);
      }

      public Names_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
