// Decompiled with JetBrains decompiler
// Type: ProjectM.SLSEntityCommandBufferSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SLSEntityCommandBufferSystem : EntityCommandBufferSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__QueuedCommandBuffers;
    private static readonly System.IntPtr NativeFieldInfoPtr__FirstRestrictedECB_HardSyncPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr__FirstRestrictedECB_FrameSyncPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr__SyncPointManager;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AssertCommandBuffersCreatedWithinSyncPoints_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatedBeforeRestrictingSyncPoint_Private_Static_Boolean_Nullable_Unboxed_1_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCommandBuffer_Public_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCommandBufferForNextFrame_Public_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewCommandBuffer_Private_Void_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757255, XrefRangeEnd = 757318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SLSEntityCommandBufferSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757318, XrefRangeEnd = 757324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SLSEntityCommandBufferSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 757387, RefRangeEnd = 757388, XrefRangeStart = 757324, XrefRangeEnd = 757387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AssertCommandBuffersCreatedWithinSyncPoints()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SLSEntityCommandBufferSystem.NativeMethodInfoPtr_AssertCommandBuffersCreatedWithinSyncPoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757388, XrefRangeEnd = 757390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CreatedBeforeRestrictingSyncPoint(
      Nullable_Unboxed<int> restrictedValue,
      int currentSyncPoint)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &restrictedValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentSyncPoint;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SLSEntityCommandBufferSystem.NativeMethodInfoPtr_CreatedBeforeRestrictingSyncPoint_Private_Static_Boolean_Nullable_Unboxed_1_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(112)]
    [CachedScanResults(RefRangeStart = 757392, RefRangeEnd = 757504, XrefRangeStart = 757390, XrefRangeEnd = 757392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe EntityCommandBuffer CreateCommandBuffer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SLSEntityCommandBufferSystem.NativeMethodInfoPtr_CreateCommandBuffer_Public_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityCommandBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 757516, RefRangeEnd = 757520, XrefRangeStart = 757504, XrefRangeEnd = 757516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityCommandBuffer CreateCommandBufferForNextFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SLSEntityCommandBufferSystem.NativeMethodInfoPtr_CreateCommandBufferForNextFrame_Public_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityCommandBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 757536, RefRangeEnd = 757540, XrefRangeStart = 757520, XrefRangeEnd = 757536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NewCommandBuffer(
      bool restrictForCurrentSyncPoint_Hard,
      bool restrictForCurrentSyncPoint_Frame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &restrictForCurrentSyncPoint_Hard;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictForCurrentSyncPoint_Frame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SLSEntityCommandBufferSystem.NativeMethodInfoPtr_NewCommandBuffer_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SLSEntityCommandBufferSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SLSEntityCommandBufferSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SLSEntityCommandBufferSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SLSEntityCommandBufferSystem()
    {
      Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SLSEntityCommandBufferSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr);
      SLSEntityCommandBufferSystem.NativeFieldInfoPtr__QueuedCommandBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, nameof (_QueuedCommandBuffers));
      SLSEntityCommandBufferSystem.NativeFieldInfoPtr__FirstRestrictedECB_HardSyncPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, nameof (_FirstRestrictedECB_HardSyncPoint));
      SLSEntityCommandBufferSystem.NativeFieldInfoPtr__FirstRestrictedECB_FrameSyncPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, nameof (_FirstRestrictedECB_FrameSyncPoint));
      SLSEntityCommandBufferSystem.NativeFieldInfoPtr__SyncPointManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, nameof (_SyncPointManager));
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666885);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666886);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_AssertCommandBuffersCreatedWithinSyncPoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666887);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_CreatedBeforeRestrictingSyncPoint_Private_Static_Boolean_Nullable_Unboxed_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666888);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_CreateCommandBuffer_Public_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666889);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_CreateCommandBufferForNextFrame_Public_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666890);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_NewCommandBuffer_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666891);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666892);
      SLSEntityCommandBufferSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, 100666893);
    }

    public SLSEntityCommandBufferSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SLSEntityCommandBufferSystem.QueuedCommandBuffer> _QueuedCommandBuffers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__QueuedCommandBuffers));
        return pointer == System.IntPtr.Zero ? (List<SLSEntityCommandBufferSystem.QueuedCommandBuffer>) null : new List<SLSEntityCommandBufferSystem.QueuedCommandBuffer>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__QueuedCommandBuffers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<int> _FirstRestrictedECB_HardSyncPoint
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__FirstRestrictedECB_HardSyncPoint));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__FirstRestrictedECB_HardSyncPoint), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _FirstRestrictedECB_FrameSyncPoint
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__FirstRestrictedECB_FrameSyncPoint));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__FirstRestrictedECB_FrameSyncPoint), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ECBSyncPointManager _SyncPointManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__SyncPointManager));
        return pointer == System.IntPtr.Zero ? (ECBSyncPointManager) null : new ECBSyncPointManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SLSEntityCommandBufferSystem.NativeFieldInfoPtr__SyncPointManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct QueuedCommandBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RestrictToHardSyncPoint;
      private static readonly System.IntPtr NativeFieldInfoPtr_RestrictToFrameSyncPoint;
      private static readonly System.IntPtr NativeFieldInfoPtr_CreatedBySystem;
      [FieldOffset(0)]
      public Nullable_Unboxed<int> RestrictToHardSyncPoint;
      [FieldOffset(8)]
      public Nullable_Unboxed<int> RestrictToFrameSyncPoint;
      [FieldOffset(16)]
      public SystemTypeId CreatedBySystem;

      static QueuedCommandBuffer()
      {
        Il2CppClassPointerStore<SLSEntityCommandBufferSystem.QueuedCommandBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SLSEntityCommandBufferSystem>.NativeClassPtr, nameof (QueuedCommandBuffer));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SLSEntityCommandBufferSystem.QueuedCommandBuffer>.NativeClassPtr);
        SLSEntityCommandBufferSystem.QueuedCommandBuffer.NativeFieldInfoPtr_RestrictToHardSyncPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SLSEntityCommandBufferSystem.QueuedCommandBuffer>.NativeClassPtr, nameof (RestrictToHardSyncPoint));
        SLSEntityCommandBufferSystem.QueuedCommandBuffer.NativeFieldInfoPtr_RestrictToFrameSyncPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SLSEntityCommandBufferSystem.QueuedCommandBuffer>.NativeClassPtr, nameof (RestrictToFrameSyncPoint));
        SLSEntityCommandBufferSystem.QueuedCommandBuffer.NativeFieldInfoPtr_CreatedBySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SLSEntityCommandBufferSystem.QueuedCommandBuffer>.NativeClassPtr, nameof (CreatedBySystem));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SLSEntityCommandBufferSystem.QueuedCommandBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
