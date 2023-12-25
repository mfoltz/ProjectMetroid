// Decompiled with JetBrains decompiler
// Type: ProjectM.KillSystemClient
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class KillSystemClient : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesToAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesToRemove;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004686, XrefRangeEnd = 1004702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillSystemClient.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004702, XrefRangeEnd = 1004708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillSystemClient.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004708, XrefRangeEnd = 1004754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillSystemClient.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KillSystemClient()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KillSystemClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillSystemClient.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KillSystemClient()
    {
      Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (KillSystemClient));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr);
      KillSystemClient.NativeFieldInfoPtr__EntitiesToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, nameof (_EntitiesToAdd));
      KillSystemClient.NativeFieldInfoPtr__EntitiesToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, nameof (_EntitiesToRemove));
      KillSystemClient.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, nameof (_Query));
      KillSystemClient.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, 100677917);
      KillSystemClient.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, 100677918);
      KillSystemClient.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, 100677919);
      KillSystemClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, 100677920);
      KillSystemClient.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, 100677921);
    }

    public KillSystemClient(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<ValueTuple_Unboxed<Entity, Dead>> _EntitiesToAdd
    {
      get
      {
        return *(NativeList<ValueTuple_Unboxed<Entity, Dead>>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillSystemClient.NativeFieldInfoPtr__EntitiesToAdd));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillSystemClient.NativeFieldInfoPtr__EntitiesToAdd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ValueTuple_Unboxed<Entity, Dead>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _EntitiesToRemove
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillSystemClient.NativeFieldInfoPtr__EntitiesToRemove));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillSystemClient.NativeFieldInfoPtr__EntitiesToRemove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillSystemClient.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillSystemClient.NativeFieldInfoPtr__Query)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AddRemoveDeadJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesToAdd;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesToRemove;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastSystemVersion;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DeadType;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthType;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthConstantsType;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public NativeList<ValueTuple_Unboxed<Entity, Dead>> EntitiesToAdd;
      [FieldOffset(16)]
      public NativeList<Entity> EntitiesToRemove;
      [FieldOffset(32)]
      public uint LastSystemVersion;
      [FieldOffset(36)]
      public EntityTypeHandle EntityType;
      [FieldOffset(40)]
      public ComponentTypeHandle<Dead> DeadType;
      [FieldOffset(72)]
      public ComponentTypeHandle<Health> HealthType;
      [FieldOffset(104)]
      public ComponentTypeHandle<HealthConstants> HealthConstantsType;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004663, XrefRangeEnd = 1004686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(KillSystemClient.AddRemoveDeadJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AddRemoveDeadJob()
      {
        Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillSystemClient>.NativeClassPtr, nameof (AddRemoveDeadJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr);
        KillSystemClient.AddRemoveDeadJob.NativeFieldInfoPtr_EntitiesToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, nameof (EntitiesToAdd));
        KillSystemClient.AddRemoveDeadJob.NativeFieldInfoPtr_EntitiesToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, nameof (EntitiesToRemove));
        KillSystemClient.AddRemoveDeadJob.NativeFieldInfoPtr_LastSystemVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, nameof (LastSystemVersion));
        KillSystemClient.AddRemoveDeadJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, nameof (EntityType));
        KillSystemClient.AddRemoveDeadJob.NativeFieldInfoPtr_DeadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, nameof (DeadType));
        KillSystemClient.AddRemoveDeadJob.NativeFieldInfoPtr_HealthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, nameof (HealthType));
        KillSystemClient.AddRemoveDeadJob.NativeFieldInfoPtr_HealthConstantsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, nameof (HealthConstantsType));
        KillSystemClient.AddRemoveDeadJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, 100677922);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillSystemClient.AddRemoveDeadJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
