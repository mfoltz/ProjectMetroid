// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_BuildMenuPlacementOperation_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.CastleBuilding.Placement;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_BuildMenuPlacementOperation_PropertyBag : 
    ContainerPropertyBag<BuildMenuPlacementOperation>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170443, XrefRangeEnd = 1170476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_BuildMenuPlacementOperation_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_BuildMenuPlacementOperation_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_BuildMenuPlacementOperation_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_BuildMenuPlacementOperation_PropertyBag));
      ProjectM_BuildMenuPlacementOperation_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag>.NativeClassPtr, 100693011);
    }

    public ProjectM_BuildMenuPlacementOperation_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class LastPlacementOperation_Property : 
      Property<BuildMenuPlacementOperation, GetPlacementResult.Operation>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Operation_byref_BuildMenuPlacementOperation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Operation_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170415, XrefRangeEnd = 1170417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1170420, RefRangeEnd = 1170422, XrefRangeStart = 1170417, XrefRangeEnd = 1170420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe LastPlacementOperation_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe GetPlacementResult.Operation GetValue(
        ref BuildMenuPlacementOperation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Operation_byref_BuildMenuPlacementOperation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
        return *(GetPlacementResult.Operation*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref BuildMenuPlacementOperation container,
        GetPlacementResult.Operation value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Operation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
      }

      static LastPlacementOperation_Property()
      {
        Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag>.NativeClassPtr, nameof (LastPlacementOperation_Property));
        ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property>.NativeClassPtr, 100693012);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property>.NativeClassPtr, 100693013);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property>.NativeClassPtr, 100693014);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Operation_byref_BuildMenuPlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property>.NativeClassPtr, 100693015);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.LastPlacementOperation_Property>.NativeClassPtr, 100693016);
      }

      public LastPlacementOperation_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class CurrentPlacementResult_Property : 
      Property<BuildMenuPlacementOperation, PlacementResult>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementResult_byref_BuildMenuPlacementOperation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_PlacementResult_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170422, XrefRangeEnd = 1170424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1170427, RefRangeEnd = 1170429, XrefRangeStart = 1170424, XrefRangeEnd = 1170427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CurrentPlacementResult_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PlacementResult GetValue(ref BuildMenuPlacementOperation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementResult_byref_BuildMenuPlacementOperation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
        return *(PlacementResult*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref BuildMenuPlacementOperation container,
        PlacementResult value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_PlacementResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
      }

      static CurrentPlacementResult_Property()
      {
        Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag>.NativeClassPtr, nameof (CurrentPlacementResult_Property));
        ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property>.NativeClassPtr, 100693017);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property>.NativeClassPtr, 100693018);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property>.NativeClassPtr, 100693019);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PlacementResult_byref_BuildMenuPlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property>.NativeClassPtr, 100693020);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_PlacementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.CurrentPlacementResult_Property>.NativeClassPtr, 100693021);
      }

      public CurrentPlacementResult_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class KeepPlacementResultForNextFrame_Property : 
      Property<BuildMenuPlacementOperation, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_BuildMenuPlacementOperation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170429, XrefRangeEnd = 1170431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1170434, RefRangeEnd = 1170436, XrefRangeStart = 1170431, XrefRangeEnd = 1170434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe KeepPlacementResultForNextFrame_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref BuildMenuPlacementOperation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_BuildMenuPlacementOperation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref BuildMenuPlacementOperation container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
      }

      static KeepPlacementResultForNextFrame_Property()
      {
        Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag>.NativeClassPtr, nameof (KeepPlacementResultForNextFrame_Property));
        ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property>.NativeClassPtr, 100693022);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property>.NativeClassPtr, 100693023);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property>.NativeClassPtr, 100693024);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_BuildMenuPlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property>.NativeClassPtr, 100693025);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.KeepPlacementResultForNextFrame_Property>.NativeClassPtr, 100693026);
      }

      public KeepPlacementResultForNextFrame_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class DismantleTargetBlocked_Property : Property<BuildMenuPlacementOperation, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_BuildMenuPlacementOperation_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170436, XrefRangeEnd = 1170438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1170441, RefRangeEnd = 1170443, XrefRangeStart = 1170438, XrefRangeEnd = 1170441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DismantleTargetBlocked_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref BuildMenuPlacementOperation container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_BuildMenuPlacementOperation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref BuildMenuPlacementOperation container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref BuildMenuPlacementOperation local = ref container;
        IntPtr pointer = ptr;
        BuildMenuPlacementOperation placementOperation = pointer == IntPtr.Zero ? (BuildMenuPlacementOperation) null : new BuildMenuPlacementOperation(pointer);
        local = placementOperation;
      }

      static DismantleTargetBlocked_Property()
      {
        Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag>.NativeClassPtr, nameof (DismantleTargetBlocked_Property));
        ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property>.NativeClassPtr, 100693027);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property>.NativeClassPtr, 100693028);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property>.NativeClassPtr, 100693029);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_BuildMenuPlacementOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property>.NativeClassPtr, 100693030);
        ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_BuildMenuPlacementOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_BuildMenuPlacementOperation_PropertyBag.DismantleTargetBlocked_Property>.NativeClassPtr, 100693031);
      }

      public DismantleTargetBlocked_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
