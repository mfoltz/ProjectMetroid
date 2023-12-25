// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using System;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag : 
    ContainerPropertyBag<GetPlacementResult.Operation>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1170668, RefRangeEnd = 1170669, XrefRangeStart = 1170596, XrefRangeEnd = 1170668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag));
      ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, 100693032);
    }

    public ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class NewRotation_Property : Property<GetPlacementResult.Operation, Rotation>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Rotation_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Rotation_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170476, XrefRangeEnd = 1170478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170481, RefRangeEnd = 1170482, XrefRangeStart = 1170478, XrefRangeEnd = 1170481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NewRotation_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Rotation GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Rotation_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Rotation*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170482, XrefRangeEnd = 1170488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref GetPlacementResult.Operation container,
        Rotation value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Rotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static NewRotation_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (NewRotation_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property>.NativeClassPtr, 100693033);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property>.NativeClassPtr, 100693034);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property>.NativeClassPtr, 100693035);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Rotation_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property>.NativeClassPtr, 100693036);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Rotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewRotation_Property>.NativeClassPtr, 100693037);
      }

      public NewRotation_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class NewTranslation_Property : Property<GetPlacementResult.Operation, Translation>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Translation_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Translation_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170488, XrefRangeEnd = 1170490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170493, RefRangeEnd = 1170494, XrefRangeStart = 1170490, XrefRangeEnd = 1170493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NewTranslation_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Translation GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Translation_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Translation*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170494, XrefRangeEnd = 1170500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref GetPlacementResult.Operation container,
        Translation value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Translation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static NewTranslation_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (NewTranslation_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property>.NativeClassPtr, 100693038);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property>.NativeClassPtr, 100693039);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property>.NativeClassPtr, 100693040);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Translation_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property>.NativeClassPtr, 100693041);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.NewTranslation_Property>.NativeClassPtr, 100693042);
      }

      public NewTranslation_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class CharacterEntity_Property : Property<GetPlacementResult.Operation, Entity>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170500, XrefRangeEnd = 1170502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170505, RefRangeEnd = 1170506, XrefRangeStart = 1170502, XrefRangeEnd = 1170505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CharacterEntity_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Entity GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170506, XrefRangeEnd = 1170512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref GetPlacementResult.Operation container, Entity value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CharacterEntity_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (CharacterEntity_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693043);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693044);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693045);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693046);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693047);
      }

      public CharacterEntity_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TileModelPrefab_Property : Property<GetPlacementResult.Operation, Entity>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170512, XrefRangeEnd = 1170514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170517, RefRangeEnd = 1170518, XrefRangeStart = 1170514, XrefRangeEnd = 1170517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelPrefab_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Entity GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170518, XrefRangeEnd = 1170524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref GetPlacementResult.Operation container, Entity value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelPrefab_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (TileModelPrefab_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property>.NativeClassPtr, 100693048);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property>.NativeClassPtr, 100693049);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property>.NativeClassPtr, 100693050);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property>.NativeClassPtr, 100693051);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.TileModelPrefab_Property>.NativeClassPtr, 100693052);
      }

      public TileModelPrefab_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ExistingEntity_Property : Property<GetPlacementResult.Operation, Entity>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170524, XrefRangeEnd = 1170526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170529, RefRangeEnd = 1170530, XrefRangeStart = 1170526, XrefRangeEnd = 1170529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ExistingEntity_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Entity GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170530, XrefRangeEnd = 1170536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref GetPlacementResult.Operation container, Entity value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ExistingEntity_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (ExistingEntity_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property>.NativeClassPtr, 100693053);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property>.NativeClassPtr, 100693054);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property>.NativeClassPtr, 100693055);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property>.NativeClassPtr, 100693056);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.ExistingEntity_Property>.NativeClassPtr, 100693057);
      }

      public ExistingEntity_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PlacementOperation_Property : 
      Property<GetPlacementResult.Operation, PlacementOperation>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementOperation_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_PlacementOperation_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170536, XrefRangeEnd = 1170538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170541, RefRangeEnd = 1170542, XrefRangeStart = 1170538, XrefRangeEnd = 1170541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PlacementOperation_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PlacementOperation GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementOperation_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlacementOperation*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170542, XrefRangeEnd = 1170548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref GetPlacementResult.Operation container,
        PlacementOperation value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_PlacementOperation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PlacementOperation_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (PlacementOperation_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693058);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693059);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693060);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementOperation_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693061);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_PlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693062);
      }

      public PlacementOperation_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class LogLevel_Property : Property<GetPlacementResult.Operation, PlacementLogLevel>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementLogLevel_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_PlacementLogLevel_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170548, XrefRangeEnd = 1170550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170553, RefRangeEnd = 1170554, XrefRangeStart = 1170550, XrefRangeEnd = 1170553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe LogLevel_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PlacementLogLevel GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementLogLevel_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlacementLogLevel*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170554, XrefRangeEnd = 1170560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref GetPlacementResult.Operation container,
        PlacementLogLevel value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_PlacementLogLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static LogLevel_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (LogLevel_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property>.NativeClassPtr, 100693063);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property>.NativeClassPtr, 100693064);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property>.NativeClassPtr, 100693065);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementLogLevel_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property>.NativeClassPtr, 100693066);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_PlacementLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.LogLevel_Property>.NativeClassPtr, 100693067);
      }

      public LogLevel_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SkipNetworkedChildren_Property : Property<GetPlacementResult.Operation, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170560, XrefRangeEnd = 1170562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170565, RefRangeEnd = 1170566, XrefRangeStart = 1170562, XrefRangeEnd = 1170565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SkipNetworkedChildren_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170566, XrefRangeEnd = 1170572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref GetPlacementResult.Operation container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SkipNetworkedChildren_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (SkipNetworkedChildren_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property>.NativeClassPtr, 100693068);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property>.NativeClassPtr, 100693069);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property>.NativeClassPtr, 100693070);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property>.NativeClassPtr, 100693071);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.SkipNetworkedChildren_Property>.NativeClassPtr, 100693072);
      }

      public SkipNetworkedChildren_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class KeepTeamDuringTransform_Property : Property<GetPlacementResult.Operation, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170572, XrefRangeEnd = 1170574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170577, RefRangeEnd = 1170578, XrefRangeStart = 1170574, XrefRangeEnd = 1170577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe KeepTeamDuringTransform_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170578, XrefRangeEnd = 1170584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref GetPlacementResult.Operation container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static KeepTeamDuringTransform_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (KeepTeamDuringTransform_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693073);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693074);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693075);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693076);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693077);
      }

      public KeepTeamDuringTransform_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PersistanceAllocation_Property : Property<GetPlacementResult.Operation, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170584, XrefRangeEnd = 1170586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170589, RefRangeEnd = 1170590, XrefRangeStart = 1170586, XrefRangeEnd = 1170589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PersistanceAllocation_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref GetPlacementResult.Operation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170590, XrefRangeEnd = 1170596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref GetPlacementResult.Operation container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PersistanceAllocation_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag>.NativeClassPtr, nameof (PersistanceAllocation_Property));
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property>.NativeClassPtr, 100693078);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property>.NativeClassPtr, 100693079);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property>.NativeClassPtr, 100693080);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property>.NativeClassPtr, 100693081);
        ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_Operation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_GetPlacementResult_Operation_PropertyBag.PersistanceAllocation_Property>.NativeClassPtr, 100693082);
      }

      public PersistanceAllocation_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
