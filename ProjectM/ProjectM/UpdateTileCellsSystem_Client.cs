// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateTileCellsSystem_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class UpdateTileCellsSystem_Client : UpdateTileCellsSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyTileCellGrid;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileCellsToUpdate;
    private static readonly System.IntPtr NativeFieldInfoPtr_SUPPORTED_TILE_TYPES;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_41;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075879, XrefRangeEnd = 1075886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075886, XrefRangeEnd = 1075895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075895, XrefRangeEnd = 1075927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075927, XrefRangeEnd = 1075931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateTileCellsSystem_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075931, XrefRangeEnd = 1075939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateTileCellsSystem_Client()
    {
      Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UpdateTileCellsSystem_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr);
      UpdateTileCellsSystem_Client.NativeFieldInfoPtr__DirtyTileCellGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, nameof (_DirtyTileCellGrid));
      UpdateTileCellsSystem_Client.NativeFieldInfoPtr__TileCellsToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, nameof (_TileCellsToUpdate));
      UpdateTileCellsSystem_Client.NativeFieldInfoPtr_SUPPORTED_TILE_TYPES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, nameof (SUPPORTED_TILE_TYPES));
      UpdateTileCellsSystem_Client.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_41 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_41));
      UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, 100684730);
      UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, 100684731);
      UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, 100684732);
      UpdateTileCellsSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, 100684733);
      UpdateTileCellsSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, 100684734);
    }

    public UpdateTileCellsSystem_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeArray<TileType> _DirtyTileCellGrid
    {
      get
      {
        return *(NativeArray<TileType>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem_Client.NativeFieldInfoPtr__DirtyTileCellGrid));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem_Client.NativeFieldInfoPtr__DirtyTileCellGrid), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<TileType>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<DirtyTileCell> _TileCellsToUpdate
    {
      get
      {
        return *(NativeList<DirtyTileCell>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem_Client.NativeFieldInfoPtr__TileCellsToUpdate));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem_Client.NativeFieldInfoPtr__TileCellsToUpdate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DirtyTileCell>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe TileType SUPPORTED_TILE_TYPES
    {
      get
      {
        TileType supportedTileTypes;
        IL2CPP.il2cpp_field_static_get_value(UpdateTileCellsSystem_Client.NativeFieldInfoPtr_SUPPORTED_TILE_TYPES, (void*) &supportedTileTypes);
        return supportedTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UpdateTileCellsSystem_Client.NativeFieldInfoPtr_SUPPORTED_TILE_TYPES, (void*) &value);
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_41
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem_Client.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_41));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTileCellsSystem_Client.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_41)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ProcessDirtyCellsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TileCellsToUpdate;
      private static readonly System.IntPtr NativeFieldInfoPtr_DirtyCells;
      private static readonly System.IntPtr NativeFieldInfoPtr_DirtyTileCells;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalUserPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdateRadius;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public NativeList<DirtyTileCell> TileCellsToUpdate;
      [FieldOffset(16)]
      public NativeList<DirtyTileCell> DirtyCells;
      [FieldOffset(32)]
      public NativeArray<TileType> DirtyTileCells;
      [FieldOffset(48)]
      public TileWorld TileWorld;
      [FieldOffset(72)]
      public float2 LocalUserPosition;
      [FieldOffset(80)]
      public float UpdateRadius;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075839, XrefRangeEnd = 1075879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ProcessDirtyCellsJob()
      {
        Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTileCellsSystem_Client>.NativeClassPtr, nameof (ProcessDirtyCellsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr);
        UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeFieldInfoPtr_TileCellsToUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, nameof (TileCellsToUpdate));
        UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeFieldInfoPtr_DirtyCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, nameof (DirtyCells));
        UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeFieldInfoPtr_DirtyTileCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, nameof (DirtyTileCells));
        UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, nameof (TileWorld));
        UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeFieldInfoPtr_LocalUserPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, nameof (LocalUserPosition));
        UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeFieldInfoPtr_UpdateRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, nameof (UpdateRadius));
        UpdateTileCellsSystem_Client.ProcessDirtyCellsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, 100684735);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTileCellsSystem_Client.ProcessDirtyCellsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
