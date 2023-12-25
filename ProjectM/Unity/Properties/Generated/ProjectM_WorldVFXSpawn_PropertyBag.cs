// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_WorldVFXSpawn_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using System;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_WorldVFXSpawn_PropertyBag : ContainerPropertyBag<WorldVFXSpawn>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171334, XrefRangeEnd = 1171371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_WorldVFXSpawn_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_WorldVFXSpawn_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_WorldVFXSpawn_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_WorldVFXSpawn_PropertyBag));
      ProjectM_WorldVFXSpawn_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag>.NativeClassPtr, 100693289);
    }

    public ProjectM_WorldVFXSpawn_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class SpawnedVisualEffect_Property : Property<WorldVFXSpawn, GameObject>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_WorldVFXSpawn_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_GameObject_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171306, XrefRangeEnd = 1171308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171311, RefRangeEnd = 1171313, XrefRangeStart = 1171308, XrefRangeEnd = 1171311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnedVisualEffect_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GameObject GetValue(ref WorldVFXSpawn container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_WorldVFXSpawn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer1 = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer1 == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer1);
        local = worldVfxSpawn;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (GameObject) null : new GameObject(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref WorldVFXSpawn container, GameObject value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer);
        local = worldVfxSpawn;
      }

      static SpawnedVisualEffect_Property()
      {
        Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag>.NativeClassPtr, nameof (SpawnedVisualEffect_Property));
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property>.NativeClassPtr, 100693290);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property>.NativeClassPtr, 100693291);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property>.NativeClassPtr, 100693292);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_GameObject_byref_WorldVFXSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property>.NativeClassPtr, 100693293);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnedVisualEffect_Property>.NativeClassPtr, 100693294);
      }

      public SpawnedVisualEffect_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class VFXSpawnTranslationOffsets_Property : 
      Property<WorldVFXSpawn, Il2CppStructArray<float3>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_float3_byref_WorldVFXSpawn_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_Il2CppStructArray_1_float3_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171313, XrefRangeEnd = 1171315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171318, RefRangeEnd = 1171320, XrefRangeStart = 1171315, XrefRangeEnd = 1171318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VFXSpawnTranslationOffsets_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppStructArray<float3> GetValue(ref WorldVFXSpawn container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_float3_byref_WorldVFXSpawn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer);
        local = worldVfxSpawn;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<float3>) null : new Il2CppStructArray<float3>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref WorldVFXSpawn container,
        Il2CppStructArray<float3> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_Il2CppStructArray_1_float3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer);
        local = worldVfxSpawn;
      }

      static VFXSpawnTranslationOffsets_Property()
      {
        Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag>.NativeClassPtr, nameof (VFXSpawnTranslationOffsets_Property));
        ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property>.NativeClassPtr, 100693295);
        ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property>.NativeClassPtr, 100693296);
        ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property>.NativeClassPtr, 100693297);
        ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_float3_byref_WorldVFXSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property>.NativeClassPtr, 100693298);
        ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_Il2CppStructArray_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.VFXSpawnTranslationOffsets_Property>.NativeClassPtr, 100693299);
      }

      public VFXSpawnTranslationOffsets_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SpawnCooldownOffsetRange_Property : Property<WorldVFXSpawn, float2>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_float2_byref_WorldVFXSpawn_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_float2_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171320, XrefRangeEnd = 1171322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171325, RefRangeEnd = 1171327, XrefRangeStart = 1171322, XrefRangeEnd = 1171325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnCooldownOffsetRange_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float2 GetValue(ref WorldVFXSpawn container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float2_byref_WorldVFXSpawn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer);
        local = worldVfxSpawn;
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref WorldVFXSpawn container, float2 value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_float2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer);
        local = worldVfxSpawn;
      }

      static SpawnCooldownOffsetRange_Property()
      {
        Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag>.NativeClassPtr, nameof (SpawnCooldownOffsetRange_Property));
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property>.NativeClassPtr, 100693300);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property>.NativeClassPtr, 100693301);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property>.NativeClassPtr, 100693302);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_float2_byref_WorldVFXSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property>.NativeClassPtr, 100693303);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldownOffsetRange_Property>.NativeClassPtr, 100693304);
      }

      public SpawnCooldownOffsetRange_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SpawnCooldown_Property : Property<WorldVFXSpawn, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_WorldVFXSpawn_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171327, XrefRangeEnd = 1171329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171332, RefRangeEnd = 1171334, XrefRangeStart = 1171329, XrefRangeEnd = 1171332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnCooldown_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref WorldVFXSpawn container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_WorldVFXSpawn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer);
        local = worldVfxSpawn;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref WorldVFXSpawn container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref WorldVFXSpawn local = ref container;
        IntPtr pointer = ptr;
        WorldVFXSpawn worldVfxSpawn = pointer == IntPtr.Zero ? (WorldVFXSpawn) null : new WorldVFXSpawn(pointer);
        local = worldVfxSpawn;
      }

      static SpawnCooldown_Property()
      {
        Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag>.NativeClassPtr, nameof (SpawnCooldown_Property));
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property>.NativeClassPtr, 100693305);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property>.NativeClassPtr, 100693306);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property>.NativeClassPtr, 100693307);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_WorldVFXSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property>.NativeClassPtr, 100693308);
        ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_WorldVFXSpawn_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_WorldVFXSpawn_PropertyBag.SpawnCooldown_Property>.NativeClassPtr, 100693309);
      }

      public SpawnCooldown_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
