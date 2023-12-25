// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag : 
    ContainerPropertyBag<HybridModelDyeableSwatch>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172277, XrefRangeEnd = 1172290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag));
      ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag>.NativeClassPtr, 100693600);
    }

    public ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class ColorSwatch_Property : 
      Property<HybridModelDyeableSwatch, BuildMenuDyeSwatchCollectionAsset>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_BuildMenuDyeSwatchCollectionAsset_byref_HybridModelDyeableSwatch_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridModelDyeableSwatch_BuildMenuDyeSwatchCollectionAsset_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172270, XrefRangeEnd = 1172272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172275, RefRangeEnd = 1172277, XrefRangeStart = 1172272, XrefRangeEnd = 1172275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ColorSwatch_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe BuildMenuDyeSwatchCollectionAsset GetValue(
        ref HybridModelDyeableSwatch container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_BuildMenuDyeSwatchCollectionAsset_byref_HybridModelDyeableSwatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref HybridModelDyeableSwatch local = ref container;
        IntPtr pointer1 = ptr;
        HybridModelDyeableSwatch modelDyeableSwatch = pointer1 == IntPtr.Zero ? (HybridModelDyeableSwatch) null : new HybridModelDyeableSwatch(pointer1);
        local = modelDyeableSwatch;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (BuildMenuDyeSwatchCollectionAsset) null : new BuildMenuDyeSwatchCollectionAsset(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref HybridModelDyeableSwatch container,
        BuildMenuDyeSwatchCollectionAsset value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridModelDyeableSwatch_BuildMenuDyeSwatchCollectionAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref HybridModelDyeableSwatch local = ref container;
        IntPtr pointer = ptr;
        HybridModelDyeableSwatch modelDyeableSwatch = pointer == IntPtr.Zero ? (HybridModelDyeableSwatch) null : new HybridModelDyeableSwatch(pointer);
        local = modelDyeableSwatch;
      }

      static ColorSwatch_Property()
      {
        Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag>.NativeClassPtr, nameof (ColorSwatch_Property));
        ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property>.NativeClassPtr, 100693601);
        ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property>.NativeClassPtr, 100693602);
        ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property>.NativeClassPtr, 100693603);
        ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_BuildMenuDyeSwatchCollectionAsset_byref_HybridModelDyeableSwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property>.NativeClassPtr, 100693604);
        ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_HybridModelDyeableSwatch_BuildMenuDyeSwatchCollectionAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CastleBuilding_HybridModelDyeableSwatch_PropertyBag.ColorSwatch_Property>.NativeClassPtr, 100693605);
      }

      public ColorSwatch_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
