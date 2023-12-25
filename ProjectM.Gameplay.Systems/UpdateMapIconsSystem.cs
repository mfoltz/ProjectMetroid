// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateMapIconsSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class UpdateMapIconsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkRange;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399382, XrefRangeEnd = 1399398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateMapIconsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399398, XrefRangeEnd = 1399421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateMapIconsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateMapIconsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateMapIconsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateMapIconsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateMapIconsSystem()
    {
      Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (UpdateMapIconsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr);
      UpdateMapIconsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr, nameof (_Query));
      UpdateMapIconsSystem.NativeFieldInfoPtr__ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr, nameof (_ChunkRange));
      UpdateMapIconsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr, 100667433);
      UpdateMapIconsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr, 100667434);
      UpdateMapIconsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr, 100667435);
      UpdateMapIconsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr, 100667436);
    }

    public UpdateMapIconsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateMapIconsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateMapIconsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe ChunkRange _ChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateMapIconsSystem.NativeFieldInfoPtr__ChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateMapIconsSystem.NativeFieldInfoPtr__ChunkRange)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateMapIconsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapIconTargetEntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapIconPositionType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttached;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<MapIconTargetEntity> MapIconTargetEntityType;
      [FieldOffset(40)]
      public ComponentTypeHandle<MapIconPosition> MapIconPositionType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Attached> GetAttached;
      [FieldOffset(104)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(136)]
      public ComponentDataFromEntity<Rotation> GetRotation;
      [FieldOffset(168)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399349, XrefRangeEnd = 1399382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateMapIconsSystem.UpdateMapIconsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateMapIconsJob()
      {
        Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateMapIconsSystem>.NativeClassPtr, nameof (UpdateMapIconsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr);
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, nameof (EntityType));
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeFieldInfoPtr_MapIconTargetEntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, nameof (MapIconTargetEntityType));
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeFieldInfoPtr_MapIconPositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, nameof (MapIconPositionType));
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeFieldInfoPtr_GetAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, nameof (GetAttached));
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, nameof (GetTranslation));
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeFieldInfoPtr_GetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, nameof (GetRotation));
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, nameof (ChunkRange));
        UpdateMapIconsSystem.UpdateMapIconsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, 100667437);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateMapIconsSystem.UpdateMapIconsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
