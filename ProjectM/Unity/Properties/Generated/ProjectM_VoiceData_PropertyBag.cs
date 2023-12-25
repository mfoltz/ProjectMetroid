// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_VoiceData_PropertyBag
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
  public class ProjectM_VoiceData_PropertyBag : ContainerPropertyBag<VoiceData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171277, XrefRangeEnd = 1171306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_VoiceData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_VoiceData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_VoiceData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_VoiceData_PropertyBag));
      ProjectM_VoiceData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag>.NativeClassPtr, 100693273);
    }

    public ProjectM_VoiceData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class VoiceMapping_Property : Property<VoiceData, VoiceMapping>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_VoiceMapping_byref_VoiceData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_VoiceMapping_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171256, XrefRangeEnd = 1171258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171261, RefRangeEnd = 1171263, XrefRangeStart = 1171258, XrefRangeEnd = 1171261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VoiceMapping_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMapping_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe VoiceMapping GetValue(ref VoiceData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VoiceMapping_byref_VoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VoiceData local = ref container;
        IntPtr pointer1 = ptr;
        VoiceData voiceData = pointer1 == IntPtr.Zero ? (VoiceData) null : new VoiceData(pointer1);
        local = voiceData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (VoiceMapping) null : new VoiceMapping(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref VoiceData container, VoiceMapping value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_VoiceMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VoiceData local = ref container;
        IntPtr pointer = ptr;
        VoiceData voiceData = pointer == IntPtr.Zero ? (VoiceData) null : new VoiceData(pointer);
        local = voiceData;
      }

      static VoiceMapping_Property()
      {
        Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMapping_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag>.NativeClassPtr, nameof (VoiceMapping_Property));
        ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMapping_Property>.NativeClassPtr, 100693274);
        ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMapping_Property>.NativeClassPtr, 100693275);
        ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMapping_Property>.NativeClassPtr, 100693276);
        ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VoiceMapping_byref_VoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMapping_Property>.NativeClassPtr, 100693277);
        ProjectM_VoiceData_PropertyBag.VoiceMapping_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_VoiceMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMapping_Property>.NativeClassPtr, 100693278);
      }

      public VoiceMapping_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class VoiceMappingFemale_Property : Property<VoiceData, VoiceMapping>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_VoiceMapping_byref_VoiceData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_VoiceMapping_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171263, XrefRangeEnd = 1171265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171268, RefRangeEnd = 1171270, XrefRangeStart = 1171265, XrefRangeEnd = 1171268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe VoiceMappingFemale_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe VoiceMapping GetValue(ref VoiceData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VoiceMapping_byref_VoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VoiceData local = ref container;
        IntPtr pointer1 = ptr;
        VoiceData voiceData = pointer1 == IntPtr.Zero ? (VoiceData) null : new VoiceData(pointer1);
        local = voiceData;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (VoiceMapping) null : new VoiceMapping(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref VoiceData container, VoiceMapping value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_VoiceMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VoiceData local = ref container;
        IntPtr pointer = ptr;
        VoiceData voiceData = pointer == IntPtr.Zero ? (VoiceData) null : new VoiceData(pointer);
        local = voiceData;
      }

      static VoiceMappingFemale_Property()
      {
        Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag>.NativeClassPtr, nameof (VoiceMappingFemale_Property));
        ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property>.NativeClassPtr, 100693279);
        ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property>.NativeClassPtr, 100693280);
        ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property>.NativeClassPtr, 100693281);
        ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_VoiceMapping_byref_VoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property>.NativeClassPtr, 100693282);
        ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_VoiceMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.VoiceMappingFemale_Property>.NativeClassPtr, 100693283);
      }

      public VoiceMappingFemale_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class RandomOptions_Property : Property<VoiceData, Il2CppReferenceArray<VoiceMapping>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_VoiceMapping_byref_VoiceData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_Il2CppReferenceArray_1_VoiceMapping_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171270, XrefRangeEnd = 1171272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1171275, RefRangeEnd = 1171277, XrefRangeStart = 1171272, XrefRangeEnd = 1171275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RandomOptions_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.RandomOptions_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppReferenceArray<VoiceMapping> GetValue(ref VoiceData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_VoiceMapping_byref_VoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VoiceData local = ref container;
        IntPtr pointer = ptr;
        VoiceData voiceData = pointer == IntPtr.Zero ? (VoiceData) null : new VoiceData(pointer);
        local = voiceData;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<VoiceMapping>) null : new Il2CppReferenceArray<VoiceMapping>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref VoiceData container,
        Il2CppReferenceArray<VoiceMapping> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_Il2CppReferenceArray_1_VoiceMapping_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref VoiceData local = ref container;
        IntPtr pointer = ptr;
        VoiceData voiceData = pointer == IntPtr.Zero ? (VoiceData) null : new VoiceData(pointer);
        local = voiceData;
      }

      static RandomOptions_Property()
      {
        Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.RandomOptions_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag>.NativeClassPtr, nameof (RandomOptions_Property));
        ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.RandomOptions_Property>.NativeClassPtr, 100693284);
        ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.RandomOptions_Property>.NativeClassPtr, 100693285);
        ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.RandomOptions_Property>.NativeClassPtr, 100693286);
        ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_VoiceMapping_byref_VoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.RandomOptions_Property>.NativeClassPtr, 100693287);
        ProjectM_VoiceData_PropertyBag.RandomOptions_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_VoiceData_Il2CppReferenceArray_1_VoiceMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_VoiceData_PropertyBag.RandomOptions_Property>.NativeClassPtr, 100693288);
      }

      public RandomOptions_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
