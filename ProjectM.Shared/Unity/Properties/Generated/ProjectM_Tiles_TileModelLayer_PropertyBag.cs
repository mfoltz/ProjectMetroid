// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Tiles_TileModelLayer_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Tiles_TileModelLayer_PropertyBag : ContainerPropertyBag<TileModelLayer>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806442, XrefRangeEnd = 806455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Tiles_TileModelLayer_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Tiles_TileModelLayer_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Tiles_TileModelLayer_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_Tiles_TileModelLayer_PropertyBag));
      ProjectM_Tiles_TileModelLayer_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag>.NativeClassPtr, 100671550);
    }

    public ProjectM_Tiles_TileModelLayer_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Layer_Property : Property<TileModelLayer, TileModelLayerEnum>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_TileModelLayerEnum_byref_TileModelLayer_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_TileModelLayer_TileModelLayerEnum_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806435, XrefRangeEnd = 806437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806440, RefRangeEnd = 806442, XrefRangeStart = 806437, XrefRangeEnd = 806440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Layer_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe TileModelLayerEnum GetValue(ref TileModelLayer container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_TileModelLayerEnum_byref_TileModelLayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileModelLayerEnum*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref TileModelLayer container, TileModelLayerEnum value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_TileModelLayer_TileModelLayerEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Layer_Property()
      {
        Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag>.NativeClassPtr, nameof (Layer_Property));
        ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property>.NativeClassPtr, 100671551);
        ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property>.NativeClassPtr, 100671552);
        ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property>.NativeClassPtr, 100671553);
        ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_TileModelLayerEnum_byref_TileModelLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property>.NativeClassPtr, 100671554);
        ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_TileModelLayer_TileModelLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Tiles_TileModelLayer_PropertyBag.Layer_Property>.NativeClassPtr, 100671555);
      }

      public Layer_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
