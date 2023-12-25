// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyWhenNoCharacterNearbyAfterDurationSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DestroyWhenNoCharacterNearbyAfterDurationSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013092, XrefRangeEnd = 1013121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013121, XrefRangeEnd = 1013137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyWhenNoCharacterNearbyAfterDurationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013137, XrefRangeEnd = 1013145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyWhenNoCharacterNearbyAfterDurationSystem()
    {
      Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DestroyWhenNoCharacterNearbyAfterDurationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr);
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, nameof (_Query));
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, nameof (_ChunkRange));
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, nameof (_DestroyBarrier));
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerTime_16));
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, 100678965);
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, 100678966);
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, 100678967);
      DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, 100678968);
    }

    public DestroyWhenNoCharacterNearbyAfterDurationSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe ChunkRange _ChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__ChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__ChunkRange)) = value;
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerTime_16
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyWhenNoCharacterNearbyAfterDurationSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerTime_16)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CheckDestroyJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DisabledDueToNoPlayersInRangeType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DestroyWhenNoCharacterNearbyAfterDurationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public double ElapsedTime;
      [FieldOffset(8)]
      public ChunkRange ChunkRange;
      [FieldOffset(20)]
      public EntityTypeHandle EntityType;
      [FieldOffset(24)]
      public ComponentTypeHandle<DisabledDueToNoPlayersInRange> DisabledDueToNoPlayersInRangeType;
      [FieldOffset(56)]
      public ComponentTypeHandle<DestroyWhenNoCharacterNearbyAfterDuration> DestroyWhenNoCharacterNearbyAfterDurationType;
      [FieldOffset(88)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013080, XrefRangeEnd = 1013092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CheckDestroyJob()
      {
        Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem>.NativeClassPtr, nameof (CheckDestroyJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr);
        DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, nameof (ElapsedTime));
        DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, nameof (ChunkRange));
        DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, nameof (EntityType));
        DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeFieldInfoPtr_DisabledDueToNoPlayersInRangeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, nameof (DisabledDueToNoPlayersInRangeType));
        DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeFieldInfoPtr_DestroyWhenNoCharacterNearbyAfterDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, nameof (DestroyWhenNoCharacterNearbyAfterDurationType));
        DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, nameof (CommandBuffer));
        DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, 100678969);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyWhenNoCharacterNearbyAfterDurationSystem.CheckDestroyJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
