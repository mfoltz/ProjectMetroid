// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using System;
using UnityEngine;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag : 
    ContainerPropertyBag<SwapArtWhileRaided>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806469, XrefRangeEnd = 806488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag));
      ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag>.NativeClassPtr, 100671556);
    }

    public ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class OverrideMaterial_Property : Property<SwapArtWhileRaided, Material>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwapArtWhileRaided_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwapArtWhileRaided_Material_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806455, XrefRangeEnd = 806457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806460, RefRangeEnd = 806462, XrefRangeStart = 806457, XrefRangeEnd = 806460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OverrideMaterial_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Material GetValue(ref SwapArtWhileRaided container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwapArtWhileRaided_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref SwapArtWhileRaided container, Material value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwapArtWhileRaided_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OverrideMaterial_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag>.NativeClassPtr, nameof (OverrideMaterial_Property));
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property>.NativeClassPtr, 100671557);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property>.NativeClassPtr, 100671558);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property>.NativeClassPtr, 100671559);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwapArtWhileRaided_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property>.NativeClassPtr, 100671560);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwapArtWhileRaided_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OverrideMaterial_Property>.NativeClassPtr, 100671561);
      }

      public OverrideMaterial_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OriginalMaterial_Property : Property<SwapArtWhileRaided, Material>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwapArtWhileRaided_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwapArtWhileRaided_Material_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806462, XrefRangeEnd = 806464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806467, RefRangeEnd = 806469, XrefRangeStart = 806464, XrefRangeEnd = 806467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OriginalMaterial_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Material GetValue(ref SwapArtWhileRaided container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwapArtWhileRaided_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref SwapArtWhileRaided container, Material value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) container);
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwapArtWhileRaided_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OriginalMaterial_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag>.NativeClassPtr, nameof (OriginalMaterial_Property));
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property>.NativeClassPtr, 100671562);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property>.NativeClassPtr, 100671563);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property>.NativeClassPtr, 100671564);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Material_byref_SwapArtWhileRaided_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property>.NativeClassPtr, 100671565);
        ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_SwapArtWhileRaided_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_SwapArtWhileRaided_PropertyBag.OriginalMaterial_Property>.NativeClassPtr, 100671566);
      }

      public OriginalMaterial_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
