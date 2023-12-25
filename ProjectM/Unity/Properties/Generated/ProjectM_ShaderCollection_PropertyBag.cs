// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ShaderCollection_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_ShaderCollection_PropertyBag : ContainerPropertyBag<ShaderCollection>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171169, XrefRangeEnd = 1171185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ShaderCollection_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ShaderCollection_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ShaderCollection_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_ShaderCollection_PropertyBag));
      ProjectM_ShaderCollection_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag>.NativeClassPtr, 100693245);
    }

    public ProjectM_ShaderCollection_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class ShaderVariants_Property : 
      Property<ShaderCollection, Il2CppReferenceArray<ShaderVar>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_ShaderVar_byref_ShaderCollection_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ShaderCollection_Il2CppReferenceArray_1_ShaderVar_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171162, XrefRangeEnd = 1171164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171167, RefRangeEnd = 1171169, XrefRangeStart = 1171164, XrefRangeEnd = 1171167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ShaderVariants_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppReferenceArray<ShaderVar> GetValue(ref ShaderCollection container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_ShaderVar_byref_ShaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ShaderCollection local = ref container;
        IntPtr pointer = ptr;
        ShaderCollection shaderCollection = pointer == IntPtr.Zero ? (ShaderCollection) null : new ShaderCollection(pointer);
        local = shaderCollection;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ShaderVar>) null : new Il2CppReferenceArray<ShaderVar>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref ShaderCollection container,
        Il2CppReferenceArray<ShaderVar> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ShaderCollection_Il2CppReferenceArray_1_ShaderVar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref ShaderCollection local = ref container;
        IntPtr pointer = ptr;
        ShaderCollection shaderCollection = pointer == IntPtr.Zero ? (ShaderCollection) null : new ShaderCollection(pointer);
        local = shaderCollection;
      }

      static ShaderVariants_Property()
      {
        Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag>.NativeClassPtr, nameof (ShaderVariants_Property));
        ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property>.NativeClassPtr, 100693246);
        ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property>.NativeClassPtr, 100693247);
        ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property>.NativeClassPtr, 100693248);
        ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_ShaderVar_byref_ShaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property>.NativeClassPtr, 100693249);
        ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_ShaderCollection_Il2CppReferenceArray_1_ShaderVar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ShaderCollection_PropertyBag.ShaderVariants_Property>.NativeClassPtr, 100693250);
      }

      public ShaderVariants_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
