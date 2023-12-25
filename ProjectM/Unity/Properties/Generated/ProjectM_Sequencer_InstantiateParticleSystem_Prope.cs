// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag : 
    ContainerPropertyBag<InstantiateParticleSystem>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171431, XrefRangeEnd = 1171465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag));
      ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag>.NativeClassPtr, 100693321);
    }

    public ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Prefab_Property : Property<InstantiateParticleSystem, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_InstantiateParticleSystem_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171403, XrefRangeEnd = 1171405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171408, RefRangeEnd = 1171410, XrefRangeStart = 1171405, XrefRangeEnd = 1171408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Prefab_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref InstantiateParticleSystem container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_InstantiateParticleSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer1 = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer1 == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer1);
        local = instantiateParticleSystem;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref InstantiateParticleSystem container,
        GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer);
        local = instantiateParticleSystem;
      }

      static Prefab_Property()
      {
        Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag>.NativeClassPtr, nameof (Prefab_Property));
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property>.NativeClassPtr, 100693322);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property>.NativeClassPtr, 100693323);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property>.NativeClassPtr, 100693324);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_InstantiateParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property>.NativeClassPtr, 100693325);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.Prefab_Property>.NativeClassPtr, 100693326);
      }

      public Prefab_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PlaybackSpeed_Property : Property<InstantiateParticleSystem, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InstantiateParticleSystem_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171410, XrefRangeEnd = 1171412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171415, RefRangeEnd = 1171417, XrefRangeStart = 1171412, XrefRangeEnd = 1171415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PlaybackSpeed_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref InstantiateParticleSystem container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InstantiateParticleSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer);
        local = instantiateParticleSystem;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref InstantiateParticleSystem container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer);
        local = instantiateParticleSystem;
      }

      static PlaybackSpeed_Property()
      {
        Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag>.NativeClassPtr, nameof (PlaybackSpeed_Property));
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property>.NativeClassPtr, 100693327);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property>.NativeClassPtr, 100693328);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property>.NativeClassPtr, 100693329);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_InstantiateParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property>.NativeClassPtr, 100693330);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.PlaybackSpeed_Property>.NativeClassPtr, 100693331);
      }

      public PlaybackSpeed_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class DyeVariationIndex_Property : Property<InstantiateParticleSystem, int>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_InstantiateParticleSystem_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Int32_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171417, XrefRangeEnd = 1171419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171422, RefRangeEnd = 1171424, XrefRangeStart = 1171419, XrefRangeEnd = 1171422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DyeVariationIndex_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe int GetValue(ref InstantiateParticleSystem container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_InstantiateParticleSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer);
        local = instantiateParticleSystem;
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref InstantiateParticleSystem container, int value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer);
        local = instantiateParticleSystem;
      }

      static DyeVariationIndex_Property()
      {
        Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag>.NativeClassPtr, nameof (DyeVariationIndex_Property));
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property>.NativeClassPtr, 100693332);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property>.NativeClassPtr, 100693333);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property>.NativeClassPtr, 100693334);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Int32_byref_InstantiateParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property>.NativeClassPtr, 100693335);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.DyeVariationIndex_Property>.NativeClassPtr, 100693336);
      }

      public DyeVariationIndex_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class HideOutsideVision_Property : Property<InstantiateParticleSystem, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_InstantiateParticleSystem_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171424, XrefRangeEnd = 1171426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171429, RefRangeEnd = 1171431, XrefRangeStart = 1171426, XrefRangeEnd = 1171429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HideOutsideVision_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref InstantiateParticleSystem container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_InstantiateParticleSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer);
        local = instantiateParticleSystem;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref InstantiateParticleSystem container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref InstantiateParticleSystem local = ref container;
        IntPtr pointer = ptr;
        InstantiateParticleSystem instantiateParticleSystem = pointer == IntPtr.Zero ? (InstantiateParticleSystem) null : new InstantiateParticleSystem(pointer);
        local = instantiateParticleSystem;
      }

      static HideOutsideVision_Property()
      {
        Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag>.NativeClassPtr, nameof (HideOutsideVision_Property));
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property>.NativeClassPtr, 100693337);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property>.NativeClassPtr, 100693338);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property>.NativeClassPtr, 100693339);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_InstantiateParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property>.NativeClassPtr, 100693340);
        ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_InstantiateParticleSystem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Sequencer_InstantiateParticleSystem_PropertyBag.HideOutsideVision_Property>.NativeClassPtr, 100693341);
      }

      public HideOutsideVision_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
