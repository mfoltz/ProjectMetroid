// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Network_NetworkSnapshotType_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Network_NetworkSnapshotType_PropertyBag : 
    ContainerPropertyBag<NetworkSnapshotType>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806422, XrefRangeEnd = 806435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Network_NetworkSnapshotType_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Network_NetworkSnapshotType_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Network_NetworkSnapshotType_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_Network_NetworkSnapshotType_PropertyBag));
      ProjectM_Network_NetworkSnapshotType_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag>.NativeClassPtr, 100671544);
    }

    public ProjectM_Network_NetworkSnapshotType_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Value_Property : Property<NetworkSnapshotType, ushort>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_UInt16_byref_NetworkSnapshotType_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NetworkSnapshotType_UInt16_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806415, XrefRangeEnd = 806417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806420, RefRangeEnd = 806422, XrefRangeStart = 806417, XrefRangeEnd = 806420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Value_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe ushort GetValue(ref NetworkSnapshotType container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_UInt16_byref_NetworkSnapshotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref NetworkSnapshotType container, ushort value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NetworkSnapshotType_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Value_Property()
      {
        Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag>.NativeClassPtr, nameof (Value_Property));
        ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property>.NativeClassPtr, 100671545);
        ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property>.NativeClassPtr, 100671546);
        ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property>.NativeClassPtr, 100671547);
        ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_UInt16_byref_NetworkSnapshotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property>.NativeClassPtr, 100671548);
        ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_NetworkSnapshotType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Network_NetworkSnapshotType_PropertyBag.Value_Property>.NativeClassPtr, 100671549);
      }

      public Value_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
