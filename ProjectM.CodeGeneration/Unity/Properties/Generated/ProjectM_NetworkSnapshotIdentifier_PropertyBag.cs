// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_NetworkSnapshotIdentifier_PropertyBag
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_NetworkSnapshotIdentifier_PropertyBag : 
    ContainerPropertyBag<NetworkSnapshotIdentifier>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636349, XrefRangeEnd = 636364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_NetworkSnapshotIdentifier_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_NetworkSnapshotIdentifier_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_NetworkSnapshotIdentifier_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "Unity.Properties.Generated", nameof (ProjectM_NetworkSnapshotIdentifier_PropertyBag));
      ProjectM_NetworkSnapshotIdentifier_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag>.NativeClassPtr, 100663507);
    }

    public ProjectM_NetworkSnapshotIdentifier_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Id_Property : Property<NetworkSnapshotIdentifier, string>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_NetworkSnapshotIdentifier_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NetworkSnapshotIdentifier_String_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636344, XrefRangeEnd = 636346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636346, XrefRangeEnd = 636349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Id_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe string GetValue(ref NetworkSnapshotIdentifier container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_NetworkSnapshotIdentifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref NetworkSnapshotIdentifier local = ref container;
        IntPtr pointer = ptr;
        NetworkSnapshotIdentifier snapshotIdentifier = pointer == IntPtr.Zero ? (NetworkSnapshotIdentifier) null : new NetworkSnapshotIdentifier(pointer);
        local = snapshotIdentifier;
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref NetworkSnapshotIdentifier container, string value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NetworkSnapshotIdentifier_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref NetworkSnapshotIdentifier local = ref container;
        IntPtr pointer = ptr;
        NetworkSnapshotIdentifier snapshotIdentifier = pointer == IntPtr.Zero ? (NetworkSnapshotIdentifier) null : new NetworkSnapshotIdentifier(pointer);
        local = snapshotIdentifier;
      }

      static Id_Property()
      {
        Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag>.NativeClassPtr, nameof (Id_Property));
        ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property>.NativeClassPtr, 100663508);
        ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property>.NativeClassPtr, 100663509);
        ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property>.NativeClassPtr, 100663510);
        ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_String_byref_NetworkSnapshotIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property>.NativeClassPtr, 100663511);
        ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NetworkSnapshotIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_NetworkSnapshotIdentifier_PropertyBag.Id_Property>.NativeClassPtr, 100663512);
      }

      public Id_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
