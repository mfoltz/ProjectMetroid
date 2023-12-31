// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_FeatureCollectionComponent_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_FeatureCollectionComponent_PropertyBag : 
    ContainerPropertyBag<FeatureCollectionComponent>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806310, XrefRangeEnd = 806323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_FeatureCollectionComponent_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_FeatureCollectionComponent_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_FeatureCollectionComponent_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_FeatureCollectionComponent_PropertyBag));
      ProjectM_FeatureCollectionComponent_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag>.NativeClassPtr, 100671509);
    }

    public ProjectM_FeatureCollectionComponent_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Asset_Property : Property<FeatureCollectionComponent, FeaturesCollection>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_FeaturesCollection_byref_FeatureCollectionComponent_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_FeatureCollectionComponent_FeaturesCollection_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806303, XrefRangeEnd = 806305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806308, RefRangeEnd = 806310, XrefRangeStart = 806305, XrefRangeEnd = 806308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Asset_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe FeaturesCollection GetValue(ref FeatureCollectionComponent container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_FeaturesCollection_byref_FeatureCollectionComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref FeatureCollectionComponent local = ref container;
        IntPtr pointer1 = ptr;
        FeatureCollectionComponent collectionComponent = pointer1 == IntPtr.Zero ? (FeatureCollectionComponent) null : new FeatureCollectionComponent(pointer1);
        local = collectionComponent;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref FeatureCollectionComponent container,
        FeaturesCollection value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_FeatureCollectionComponent_FeaturesCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref FeatureCollectionComponent local = ref container;
        IntPtr pointer = ptr;
        FeatureCollectionComponent collectionComponent = pointer == IntPtr.Zero ? (FeatureCollectionComponent) null : new FeatureCollectionComponent(pointer);
        local = collectionComponent;
      }

      static Asset_Property()
      {
        Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag>.NativeClassPtr, nameof (Asset_Property));
        ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property>.NativeClassPtr, 100671510);
        ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property>.NativeClassPtr, 100671511);
        ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property>.NativeClassPtr, 100671512);
        ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_FeaturesCollection_byref_FeatureCollectionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property>.NativeClassPtr, 100671513);
        ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_FeatureCollectionComponent_FeaturesCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_FeatureCollectionComponent_PropertyBag.Asset_Property>.NativeClassPtr, 100671514);
      }

      public Asset_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
