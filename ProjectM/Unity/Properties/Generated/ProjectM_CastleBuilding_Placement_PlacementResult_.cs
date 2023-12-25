// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM;
using ProjectM.CastleBuilding.Placement;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag : 
    ContainerPropertyBag<PlacementResult>
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1170966, RefRangeEnd = 1170967, XrefRangeStart = 1170877, XrefRangeEnd = 1170966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag));
      ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, 100693128);
    }

    public ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public class HasResult_Property : Property<PlacementResult, bool>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170805, XrefRangeEnd = 1170807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170810, RefRangeEnd = 1170811, XrefRangeStart = 1170807, XrefRangeEnd = 1170810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HasResult_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref PlacementResult container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HasResult_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (HasResult_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property>.NativeClassPtr, 100693129);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property>.NativeClassPtr, 100693130);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property>.NativeClassPtr, 100693131);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property>.NativeClassPtr, 100693132);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.HasResult_Property>.NativeClassPtr, 100693133);
      }

      public HasResult_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PlacementOperation_Property : Property<PlacementResult, PlacementOperation>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementOperation_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_PlacementOperation_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170811, XrefRangeEnd = 1170813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170816, RefRangeEnd = 1170817, XrefRangeStart = 1170813, XrefRangeEnd = 1170816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PlacementOperation_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PlacementOperation GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementOperation_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PlacementOperation*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref PlacementResult container, PlacementOperation value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_PlacementOperation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PlacementOperation_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (PlacementOperation_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693134);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693135);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693136);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementOperation_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693137);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_PlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.PlacementOperation_Property>.NativeClassPtr, 100693138);
      }

      public PlacementOperation_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class CharacterEntity_Property : Property<PlacementResult, Entity>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Entity_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170817, XrefRangeEnd = 1170819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170822, RefRangeEnd = 1170823, XrefRangeStart = 1170819, XrefRangeEnd = 1170822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CharacterEntity_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Entity GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref PlacementResult container, Entity value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CharacterEntity_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (CharacterEntity_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693139);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693140);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693141);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Entity_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693142);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.CharacterEntity_Property>.NativeClassPtr, 100693143);
      }

      public CharacterEntity_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class UserTeam_Property : Property<PlacementResult, Nullable_Unboxed<Team>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Nullable_Unboxed_1_Team_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Nullable_Unboxed_1_Team_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170823, XrefRangeEnd = 1170825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170828, RefRangeEnd = 1170829, XrefRangeStart = 1170825, XrefRangeEnd = 1170828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UserTeam_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Nullable_Unboxed<Team> GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Nullable_Unboxed_1_Team_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<Team>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        Nullable_Unboxed<Team> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Nullable_Unboxed_1_Team_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UserTeam_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (UserTeam_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property>.NativeClassPtr, 100693144);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property>.NativeClassPtr, 100693145);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property>.NativeClassPtr, 100693146);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Nullable_Unboxed_1_Team_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property>.NativeClassPtr, 100693147);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Nullable_Unboxed_1_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.UserTeam_Property>.NativeClassPtr, 100693148);
      }

      public UserTeam_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class KeepTeamDuringTransform_Property : Property<PlacementResult, bool>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170829, XrefRangeEnd = 1170831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170834, RefRangeEnd = 1170835, XrefRangeStart = 1170831, XrefRangeEnd = 1170834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe KeepTeamDuringTransform_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref PlacementResult container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static KeepTeamDuringTransform_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (KeepTeamDuringTransform_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693149);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693150);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693151);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693152);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.KeepTeamDuringTransform_Property>.NativeClassPtr, 100693153);
      }

      public KeepTeamDuringTransform_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TileModelsToCreate_Property : 
      Property<PlacementResult, NativeList<CreateTileModelData>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_CreateTileModelData_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_CreateTileModelData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170835, XrefRangeEnd = 1170837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170840, RefRangeEnd = 1170841, XrefRangeStart = 1170837, XrefRangeEnd = 1170840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelsToCreate_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NativeList<CreateTileModelData> GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_CreateTileModelData_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<CreateTileModelData>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        NativeList<CreateTileModelData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_CreateTileModelData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelsToCreate_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (TileModelsToCreate_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property>.NativeClassPtr, 100693154);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property>.NativeClassPtr, 100693155);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property>.NativeClassPtr, 100693156);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_CreateTileModelData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property>.NativeClassPtr, 100693157);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_CreateTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToCreate_Property>.NativeClassPtr, 100693158);
      }

      public TileModelsToCreate_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TileModelsToMove_Property : Property<PlacementResult, NativeList<MoveTileModelData>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_MoveTileModelData_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_MoveTileModelData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170841, XrefRangeEnd = 1170843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170846, RefRangeEnd = 1170847, XrefRangeStart = 1170843, XrefRangeEnd = 1170846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelsToMove_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NativeList<MoveTileModelData> GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_MoveTileModelData_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<MoveTileModelData>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        NativeList<MoveTileModelData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_MoveTileModelData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelsToMove_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (TileModelsToMove_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property>.NativeClassPtr, 100693159);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property>.NativeClassPtr, 100693160);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property>.NativeClassPtr, 100693161);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_MoveTileModelData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property>.NativeClassPtr, 100693162);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_MoveTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToMove_Property>.NativeClassPtr, 100693163);
      }

      public TileModelsToMove_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TileModelsToBlock_Property : 
      Property<PlacementResult, NativeList<BlockedTileModelData>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_BlockedTileModelData_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_BlockedTileModelData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170847, XrefRangeEnd = 1170849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170852, RefRangeEnd = 1170853, XrefRangeStart = 1170849, XrefRangeEnd = 1170852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelsToBlock_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NativeList<BlockedTileModelData> GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_BlockedTileModelData_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<BlockedTileModelData>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        NativeList<BlockedTileModelData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_BlockedTileModelData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelsToBlock_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (TileModelsToBlock_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property>.NativeClassPtr, 100693164);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property>.NativeClassPtr, 100693165);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property>.NativeClassPtr, 100693166);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_BlockedTileModelData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property>.NativeClassPtr, 100693167);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_BlockedTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToBlock_Property>.NativeClassPtr, 100693168);
      }

      public TileModelsToBlock_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class BlockReasonsPerBlockedTileModel_Property : 
      Property<PlacementResult, NativeMultiHashMap<int, TileModelBlockReasonData>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NativeMultiHashMap_2_Int32_TileModelBlockReasonData_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeMultiHashMap_2_Int32_TileModelBlockReasonData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170853, XrefRangeEnd = 1170855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170858, RefRangeEnd = 1170859, XrefRangeStart = 1170855, XrefRangeEnd = 1170858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BlockReasonsPerBlockedTileModel_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NativeMultiHashMap<int, TileModelBlockReasonData> GetValue(
        ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeMultiHashMap_2_Int32_TileModelBlockReasonData_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeMultiHashMap<int, TileModelBlockReasonData>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        NativeMultiHashMap<int, TileModelBlockReasonData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeMultiHashMap_2_Int32_TileModelBlockReasonData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BlockReasonsPerBlockedTileModel_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (BlockReasonsPerBlockedTileModel_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property>.NativeClassPtr, 100693169);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property>.NativeClassPtr, 100693170);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property>.NativeClassPtr, 100693171);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeMultiHashMap_2_Int32_TileModelBlockReasonData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property>.NativeClassPtr, 100693172);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeMultiHashMap_2_Int32_TileModelBlockReasonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.BlockReasonsPerBlockedTileModel_Property>.NativeClassPtr, 100693173);
      }

      public BlockReasonsPerBlockedTileModel_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TileModelsToDestroy_Property : 
      Property<PlacementResult, NativeList<DestroyTileModelData>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_DestroyTileModelData_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_DestroyTileModelData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170859, XrefRangeEnd = 1170861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170864, RefRangeEnd = 1170865, XrefRangeStart = 1170861, XrefRangeEnd = 1170864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelsToDestroy_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NativeList<DestroyTileModelData> GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_DestroyTileModelData_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<DestroyTileModelData>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        NativeList<DestroyTileModelData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_DestroyTileModelData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelsToDestroy_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (TileModelsToDestroy_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property>.NativeClassPtr, 100693174);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property>.NativeClassPtr, 100693175);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property>.NativeClassPtr, 100693176);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_DestroyTileModelData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property>.NativeClassPtr, 100693177);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_DestroyTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDestroy_Property>.NativeClassPtr, 100693178);
      }

      public TileModelsToDestroy_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TileModelsToAttach_Property : 
      Property<PlacementResult, NativeList<AttachTileModelData>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_AttachTileModelData_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_AttachTileModelData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170865, XrefRangeEnd = 1170867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170870, RefRangeEnd = 1170871, XrefRangeStart = 1170867, XrefRangeEnd = 1170870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelsToAttach_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NativeList<AttachTileModelData> GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_AttachTileModelData_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<AttachTileModelData>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        NativeList<AttachTileModelData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_AttachTileModelData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelsToAttach_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (TileModelsToAttach_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property>.NativeClassPtr, 100693179);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property>.NativeClassPtr, 100693180);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property>.NativeClassPtr, 100693181);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_AttachTileModelData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property>.NativeClassPtr, 100693182);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_AttachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToAttach_Property>.NativeClassPtr, 100693183);
      }

      public TileModelsToAttach_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class TileModelsToDetach_Property : 
      Property<PlacementResult, NativeList<DetachTileModelData>>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_DetachTileModelData_byref_PlacementResult_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_DetachTileModelData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170871, XrefRangeEnd = 1170873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1170876, RefRangeEnd = 1170877, XrefRangeStart = 1170873, XrefRangeEnd = 1170876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileModelsToDetach_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NativeList<DetachTileModelData> GetValue(ref PlacementResult container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref container;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_DetachTileModelData_byref_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<DetachTileModelData>*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref PlacementResult container,
        NativeList<DetachTileModelData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref container;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_DetachTileModelData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileModelsToDetach_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag>.NativeClassPtr, nameof (TileModelsToDetach_Property));
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property>.NativeClassPtr, 100693184);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property>.NativeClassPtr, 100693185);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property>.NativeClassPtr, 100693186);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NativeList_1_DetachTileModelData_byref_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property>.NativeClassPtr, 100693187);
        ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_PlacementResult_NativeList_1_DetachTileModelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_Placement_PlacementResult_PropertyBag.TileModelsToDetach_Property>.NativeClassPtr, 100693188);
      }

      public TileModelsToDetach_Property(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
