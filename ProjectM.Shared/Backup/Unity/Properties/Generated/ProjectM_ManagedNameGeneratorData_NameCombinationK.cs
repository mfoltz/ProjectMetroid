// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag
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
  public class ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag : 
    ContainerPropertyBag<ManagedNameGeneratorData.NameCombinationKey>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806075, XrefRangeEnd = 806107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag));
      ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag>.NativeClassPtr, 100671420);
    }

    public ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Postfix_Property : Property<ManagedNameGeneratorData.NameCombinationKey, byte>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Byte_byref_NameCombinationKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_Byte_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806047, XrefRangeEnd = 806049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806052, RefRangeEnd = 806054, XrefRangeStart = 806049, XrefRangeEnd = 806052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Postfix_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe byte GetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Byte_byref_NameCombinationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container,
        byte value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Postfix_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag>.NativeClassPtr, nameof (Postfix_Property));
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property>.NativeClassPtr, 100671421);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property>.NativeClassPtr, 100671422);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property>.NativeClassPtr, 100671423);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Byte_byref_NameCombinationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property>.NativeClassPtr, 100671424);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Postfix_Property>.NativeClassPtr, 100671425);
      }

      public Postfix_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Prefix_Property : Property<ManagedNameGeneratorData.NameCombinationKey, byte>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Byte_byref_NameCombinationKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_Byte_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806054, XrefRangeEnd = 806056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806059, RefRangeEnd = 806061, XrefRangeStart = 806056, XrefRangeEnd = 806059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Prefix_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe byte GetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Byte_byref_NameCombinationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container,
        byte value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Prefix_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag>.NativeClassPtr, nameof (Prefix_Property));
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property>.NativeClassPtr, 100671426);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property>.NativeClassPtr, 100671427);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property>.NativeClassPtr, 100671428);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Byte_byref_NameCombinationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property>.NativeClassPtr, 100671429);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.Prefix_Property>.NativeClassPtr, 100671430);
      }

      public Prefix_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PostfixSource_Property : 
      Property<ManagedNameGeneratorData.NameCombinationKey, PrefabGUID>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_NameCombinationKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806061, XrefRangeEnd = 806063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806066, RefRangeEnd = 806068, XrefRangeStart = 806063, XrefRangeEnd = 806066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PostfixSource_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PrefabGUID GetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_NameCombinationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container,
        PrefabGUID value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PostfixSource_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag>.NativeClassPtr, nameof (PostfixSource_Property));
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property>.NativeClassPtr, 100671431);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property>.NativeClassPtr, 100671432);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property>.NativeClassPtr, 100671433);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_NameCombinationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property>.NativeClassPtr, 100671434);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PostfixSource_Property>.NativeClassPtr, 100671435);
      }

      public PostfixSource_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PrefixSource_Property : 
      Property<ManagedNameGeneratorData.NameCombinationKey, PrefabGUID>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_NameCombinationKey_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_PrefabGUID_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806068, XrefRangeEnd = 806070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806073, RefRangeEnd = 806075, XrefRangeStart = 806070, XrefRangeEnd = 806073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefixSource_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe PrefabGUID GetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_NameCombinationKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(
        ref ManagedNameGeneratorData.NameCombinationKey container,
        PrefabGUID value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PrefixSource_Property()
      {
        Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag>.NativeClassPtr, nameof (PrefixSource_Property));
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property>.NativeClassPtr, 100671436);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property>.NativeClassPtr, 100671437);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property>.NativeClassPtr, 100671438);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_PrefabGUID_byref_NameCombinationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property>.NativeClassPtr, 100671439);
        ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NameCombinationKey_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_ManagedNameGeneratorData_NameCombinationKey_PropertyBag.PrefixSource_Property>.NativeClassPtr, 100671440);
      }

      public PrefixSource_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
