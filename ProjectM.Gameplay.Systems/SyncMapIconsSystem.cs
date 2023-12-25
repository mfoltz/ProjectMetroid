// Decompiled with JetBrains decompiler
// Type: ProjectM.SyncMapIconsSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class SyncMapIconsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UserActivityGridSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedTeams;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedAllies;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkRange;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399290, XrefRangeEnd = 1399319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncMapIconsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399319, XrefRangeEnd = 1399327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncMapIconsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399327, XrefRangeEnd = 1399349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncMapIconsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SyncMapIconsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncMapIconsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SyncMapIconsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SyncMapIconsSystem()
    {
      Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (SyncMapIconsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr);
      SyncMapIconsSystem.NativeFieldInfoPtr__UserActivityGridSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, nameof (_UserActivityGridSystem));
      SyncMapIconsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, nameof (_Query));
      SyncMapIconsSystem.NativeFieldInfoPtr__CachedTeams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, nameof (_CachedTeams));
      SyncMapIconsSystem.NativeFieldInfoPtr__CachedAllies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, nameof (_CachedAllies));
      SyncMapIconsSystem.NativeFieldInfoPtr__CachedUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, nameof (_CachedUsers));
      SyncMapIconsSystem.NativeFieldInfoPtr__ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, nameof (_ChunkRange));
      SyncMapIconsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, 100667427);
      SyncMapIconsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, 100667428);
      SyncMapIconsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, 100667429);
      SyncMapIconsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, 100667430);
      SyncMapIconsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, 100667431);
    }

    public SyncMapIconsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UserActivityGridSystem _UserActivityGridSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__UserActivityGridSystem));
        return pointer == System.IntPtr.Zero ? (UserActivityGridSystem) null : new UserActivityGridSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__UserActivityGridSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe NativeList<Entity> _CachedTeams
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__CachedTeams));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__CachedTeams), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _CachedAllies
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__CachedAllies));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__CachedAllies), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<int> _CachedUsers
    {
      get
      {
        return *(NativeList<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__CachedUsers));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__CachedUsers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChunkRange _ChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__ChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SyncMapIconsSystem.NativeFieldInfoPtr__ChunkRange)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SyncMapIconJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MapIconDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TeamReferenceType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetConnectedUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_OnlySyncToUserBitMaskType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UserActivityGrid;
      private static readonly System.IntPtr NativeFieldInfoPtr_CachedAllies;
      private static readonly System.IntPtr NativeFieldInfoPtr_CachedUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<MapIconData> MapIconDataType;
      [FieldOffset(32)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(64)]
      public ComponentTypeHandle<TeamReference> TeamReferenceType;
      [FieldOffset(96)]
      public ComponentDataFromEntity<ConnectedUser> GetConnectedUser;
      [FieldOffset(128)]
      public ComponentTypeHandle<OnlySyncToUserBitMask> OnlySyncToUserBitMaskType;
      [FieldOffset(160)]
      public UserActivityGrid UserActivityGrid;
      [FieldOffset(304)]
      public NativeList<Entity> CachedAllies;
      [FieldOffset(320)]
      public NativeList<int> CachedUsers;
      [FieldOffset(336)]
      public EntityManager EntityManager;
      [FieldOffset(344)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399243, XrefRangeEnd = 1399290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SyncMapIconsSystem.SyncMapIconJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SyncMapIconJob()
      {
        Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncMapIconsSystem>.NativeClassPtr, nameof (SyncMapIconJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr);
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_MapIconDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (MapIconDataType));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (TranslationType));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_TeamReferenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (TeamReferenceType));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_GetConnectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (GetConnectedUser));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_OnlySyncToUserBitMaskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (OnlySyncToUserBitMaskType));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_UserActivityGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (UserActivityGrid));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_CachedAllies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (CachedAllies));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_CachedUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (CachedUsers));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (EntityManager));
        SyncMapIconsSystem.SyncMapIconJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, nameof (ChunkRange));
        SyncMapIconsSystem.SyncMapIconJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, 100667432);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncMapIconsSystem.SyncMapIconJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
