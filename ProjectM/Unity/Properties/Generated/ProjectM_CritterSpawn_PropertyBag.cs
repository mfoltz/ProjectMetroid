// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_CritterSpawn_PropertyBag
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
  public class ProjectM_CritterSpawn_PropertyBag : ContainerPropertyBag<CritterSpawn>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169770, XrefRangeEnd = 1169799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_CritterSpawn_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_CritterSpawn_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_CritterSpawn_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_CritterSpawn_PropertyBag));
      ProjectM_CritterSpawn_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag>.NativeClassPtr, 100692779);
    }

    public ProjectM_CritterSpawn_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class CritterGUIDs_Property : Property<CritterSpawn, Il2CppStructArray<PrefabGUID>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_CritterSpawn_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Il2CppStructArray_1_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169749, XrefRangeEnd = 1169751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1169754, RefRangeEnd = 1169756, XrefRangeStart = 1169751, XrefRangeEnd = 1169754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CritterGUIDs_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppStructArray<PrefabGUID> GetValue(ref CritterSpawn container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_CritterSpawn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CritterSpawn local = ref container;
        IntPtr pointer = ptr;
        CritterSpawn critterSpawn = pointer == IntPtr.Zero ? (CritterSpawn) null : new CritterSpawn(pointer);
        local = critterSpawn;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<PrefabGUID>) null : new Il2CppStructArray<PrefabGUID>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref CritterSpawn container,
        Il2CppStructArray<PrefabGUID> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Il2CppStructArray_1_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CritterSpawn local = ref container;
        IntPtr pointer = ptr;
        CritterSpawn critterSpawn = pointer == IntPtr.Zero ? (CritterSpawn) null : new CritterSpawn(pointer);
        local = critterSpawn;
      }

      static CritterGUIDs_Property()
      {
        Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag>.NativeClassPtr, nameof (CritterGUIDs_Property));
        ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property>.NativeClassPtr, 100692780);
        ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property>.NativeClassPtr, 100692781);
        ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property>.NativeClassPtr, 100692782);
        ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppStructArray_1_PrefabGUID_byref_CritterSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property>.NativeClassPtr, 100692783);
        ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Il2CppStructArray_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.CritterGUIDs_Property>.NativeClassPtr, 100692784);
      }

      public CritterGUIDs_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class SpawnAreaWidth_Property : Property<CritterSpawn, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_CritterSpawn_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169756, XrefRangeEnd = 1169758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1169761, RefRangeEnd = 1169763, XrefRangeStart = 1169758, XrefRangeEnd = 1169761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnAreaWidth_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref CritterSpawn container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_CritterSpawn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CritterSpawn local = ref container;
        IntPtr pointer = ptr;
        CritterSpawn critterSpawn = pointer == IntPtr.Zero ? (CritterSpawn) null : new CritterSpawn(pointer);
        local = critterSpawn;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref CritterSpawn container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CritterSpawn local = ref container;
        IntPtr pointer = ptr;
        CritterSpawn critterSpawn = pointer == IntPtr.Zero ? (CritterSpawn) null : new CritterSpawn(pointer);
        local = critterSpawn;
      }

      static SpawnAreaWidth_Property()
      {
        Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag>.NativeClassPtr, nameof (SpawnAreaWidth_Property));
        ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property>.NativeClassPtr, 100692785);
        ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property>.NativeClassPtr, 100692786);
        ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property>.NativeClassPtr, 100692787);
        ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_CritterSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property>.NativeClassPtr, 100692788);
        ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.SpawnAreaWidth_Property>.NativeClassPtr, 100692789);
      }

      public SpawnAreaWidth_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class OffsetStrength_Property : Property<CritterSpawn, float>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_CritterSpawn_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Single_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169763, XrefRangeEnd = 1169765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1169768, RefRangeEnd = 1169770, XrefRangeStart = 1169765, XrefRangeEnd = 1169768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OffsetStrength_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe float GetValue(ref CritterSpawn container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_CritterSpawn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CritterSpawn local = ref container;
        IntPtr pointer = ptr;
        CritterSpawn critterSpawn = pointer == IntPtr.Zero ? (CritterSpawn) null : new CritterSpawn(pointer);
        local = critterSpawn;
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref CritterSpawn container, float value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref CritterSpawn local = ref container;
        IntPtr pointer = ptr;
        CritterSpawn critterSpawn = pointer == IntPtr.Zero ? (CritterSpawn) null : new CritterSpawn(pointer);
        local = critterSpawn;
      }

      static OffsetStrength_Property()
      {
        Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag>.NativeClassPtr, nameof (OffsetStrength_Property));
        ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property>.NativeClassPtr, 100692790);
        ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property>.NativeClassPtr, 100692791);
        ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property>.NativeClassPtr, 100692792);
        ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Single_byref_CritterSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property>.NativeClassPtr, 100692793);
        ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_CritterSpawn_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_CritterSpawn_PropertyBag.OffsetStrength_Property>.NativeClassPtr, 100692794);
      }

      public OffsetStrength_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
