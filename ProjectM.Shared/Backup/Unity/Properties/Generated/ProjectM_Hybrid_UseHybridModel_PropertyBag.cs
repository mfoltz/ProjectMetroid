// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Hybrid_UseHybridModel_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM;
using ProjectM.Hybrid;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Hybrid_UseHybridModel_PropertyBag : ContainerPropertyBag<UseHybridModel>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806563, XrefRangeEnd = 806600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Hybrid_UseHybridModel_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Hybrid_UseHybridModel_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Hybrid_UseHybridModel_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_Hybrid_UseHybridModel_PropertyBag));
      ProjectM_Hybrid_UseHybridModel_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag>.NativeClassPtr, 100671583);
    }

    public ProjectM_Hybrid_UseHybridModel_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Prefabs_Property : Property<UseHybridModel, Il2CppStructArray<AssetGuid>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_AssetGuid_byref_UseHybridModel_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_Il2CppStructArray_1_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806535, XrefRangeEnd = 806537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806540, RefRangeEnd = 806542, XrefRangeStart = 806537, XrefRangeEnd = 806540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Prefabs_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppStructArray<AssetGuid> GetValue(ref UseHybridModel container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_AssetGuid_byref_UseHybridModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer = ptr;
        UseHybridModel useHybridModel = pointer == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer);
        local = useHybridModel;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<AssetGuid>) null : new Il2CppStructArray<AssetGuid>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref UseHybridModel container,
        Il2CppStructArray<AssetGuid> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_Il2CppStructArray_1_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer = ptr;
        UseHybridModel useHybridModel = pointer == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer);
        local = useHybridModel;
      }

      static Prefabs_Property()
      {
        Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag>.NativeClassPtr, nameof (Prefabs_Property));
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property>.NativeClassPtr, 100671584);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property>.NativeClassPtr, 100671585);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property>.NativeClassPtr, 100671586);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_AssetGuid_byref_UseHybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property>.NativeClassPtr, 100671587);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_Il2CppStructArray_1_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Prefabs_Property>.NativeClassPtr, 100671588);
      }

      public Prefabs_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Override_Property : Property<UseHybridModel, AssetGuid>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_UseHybridModel_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_AssetGuid_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806542, XrefRangeEnd = 806544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806547, RefRangeEnd = 806549, XrefRangeStart = 806544, XrefRangeEnd = 806547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Override_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe AssetGuid GetValue(ref UseHybridModel container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_UseHybridModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer = ptr;
        UseHybridModel useHybridModel = pointer == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer);
        local = useHybridModel;
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref UseHybridModel container, AssetGuid value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_AssetGuid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer = ptr;
        UseHybridModel useHybridModel = pointer == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer);
        local = useHybridModel;
      }

      static Override_Property()
      {
        Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag>.NativeClassPtr, nameof (Override_Property));
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property>.NativeClassPtr, 100671589);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property>.NativeClassPtr, 100671590);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property>.NativeClassPtr, 100671591);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_AssetGuid_byref_UseHybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property>.NativeClassPtr, 100671592);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.Override_Property>.NativeClassPtr, 100671593);
      }

      public Override_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SkinColorCollection_Property : 
      Property<UseHybridModel, NPCServantSkinColorCollection>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_NPCServantSkinColorCollection_byref_UseHybridModel_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_NPCServantSkinColorCollection_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806549, XrefRangeEnd = 806551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806554, RefRangeEnd = 806556, XrefRangeStart = 806551, XrefRangeEnd = 806554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SkinColorCollection_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe NPCServantSkinColorCollection GetValue(ref UseHybridModel container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NPCServantSkinColorCollection_byref_UseHybridModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer1 = ptr;
        UseHybridModel useHybridModel = pointer1 == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer1);
        local = useHybridModel;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (NPCServantSkinColorCollection) null : new NPCServantSkinColorCollection(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref UseHybridModel container,
        NPCServantSkinColorCollection value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_NPCServantSkinColorCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer = ptr;
        UseHybridModel useHybridModel = pointer == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer);
        local = useHybridModel;
      }

      static SkinColorCollection_Property()
      {
        Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag>.NativeClassPtr, nameof (SkinColorCollection_Property));
        ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property>.NativeClassPtr, 100671594);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property>.NativeClassPtr, 100671595);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property>.NativeClassPtr, 100671596);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_NPCServantSkinColorCollection_byref_UseHybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property>.NativeClassPtr, 100671597);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_NPCServantSkinColorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.SkinColorCollection_Property>.NativeClassPtr, 100671598);
      }

      public SkinColorCollection_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class UseSkinColorCollection_Property : Property<UseHybridModel, bool>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_UseHybridModel_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_Boolean_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806556, XrefRangeEnd = 806558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806561, RefRangeEnd = 806563, XrefRangeStart = 806558, XrefRangeEnd = 806561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UseSkinColorCollection_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe bool GetValue(ref UseHybridModel container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_UseHybridModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer = ptr;
        UseHybridModel useHybridModel = pointer == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer);
        local = useHybridModel;
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref UseHybridModel container, bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref UseHybridModel local = ref container;
        IntPtr pointer = ptr;
        UseHybridModel useHybridModel = pointer == IntPtr.Zero ? (UseHybridModel) null : new UseHybridModel(pointer);
        local = useHybridModel;
      }

      static UseSkinColorCollection_Property()
      {
        Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag>.NativeClassPtr, nameof (UseSkinColorCollection_Property));
        ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property>.NativeClassPtr, 100671599);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property>.NativeClassPtr, 100671600);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property>.NativeClassPtr, 100671601);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Boolean_byref_UseHybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property>.NativeClassPtr, 100671602);
        ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_UseHybridModel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Hybrid_UseHybridModel_PropertyBag.UseSkinColorCollection_Property>.NativeClassPtr, 100671603);
      }

      public UseSkinColorCollection_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
