// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Terrain_TerrainChunkShared_PropertyBag
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Terrain_TerrainChunkShared_PropertyBag : 
    ContainerPropertyBag<TerrainChunkShared>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806350, XrefRangeEnd = 806363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Terrain_TerrainChunkShared_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Terrain_TerrainChunkShared_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Terrain_TerrainChunkShared_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Unity.Properties.Generated", nameof (ProjectM_Terrain_TerrainChunkShared_PropertyBag));
      ProjectM_Terrain_TerrainChunkShared_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag>.NativeClassPtr, 100671521);
    }

    public ProjectM_Terrain_TerrainChunkShared_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Chunk_Property : Property<TerrainChunkShared, TerrainChunk>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_TerrainChunk_byref_TerrainChunkShared_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_TerrainChunkShared_TerrainChunk_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806343, XrefRangeEnd = 806345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 806348, RefRangeEnd = 806350, XrefRangeStart = 806345, XrefRangeEnd = 806348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Chunk_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe TerrainChunk GetValue(ref TerrainChunkShared container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) ref container;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_TerrainChunk_byref_TerrainChunkShared_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe void SetValue(ref TerrainChunkShared container, TerrainChunk value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref container;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_TerrainChunkShared_TerrainChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Chunk_Property()
      {
        Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag>.NativeClassPtr, nameof (Chunk_Property));
        ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property>.NativeClassPtr, 100671522);
        ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property>.NativeClassPtr, 100671523);
        ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property>.NativeClassPtr, 100671524);
        ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_TerrainChunk_byref_TerrainChunkShared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property>.NativeClassPtr, 100671525);
        ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_TerrainChunkShared_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Terrain_TerrainChunkShared_PropertyBag.Chunk_Property>.NativeClassPtr, 100671526);
      }

      public Chunk_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
