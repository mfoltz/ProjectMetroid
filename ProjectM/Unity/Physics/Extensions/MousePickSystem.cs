// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.MousePickSystem
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
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Physics.Systems;

#nullable disable
namespace Unity.Physics.Extensions
{
  public class MousePickSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_BuildPhysicsWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpringDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr_PickJobHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926179, XrefRangeEnd = 926183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MousePickSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MousePickSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926183, XrefRangeEnd = 926209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MousePickSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926209, XrefRangeEnd = 926212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MousePickSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926212, XrefRangeEnd = 926257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MousePickSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MousePickSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MousePickSystem()
    {
      Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (MousePickSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr);
      MousePickSystem.NativeFieldInfoPtr_k_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, nameof (k_MaxDistance));
      MousePickSystem.NativeFieldInfoPtr_m_MouseGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, nameof (m_MouseGroup));
      MousePickSystem.NativeFieldInfoPtr_m_BuildPhysicsWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, nameof (m_BuildPhysicsWorldSystem));
      MousePickSystem.NativeFieldInfoPtr_SpringDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, nameof (SpringDatas));
      MousePickSystem.NativeFieldInfoPtr_PickJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, nameof (PickJobHandle));
      MousePickSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, 100663995);
      MousePickSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, 100663996);
      MousePickSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, 100663997);
      MousePickSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, 100663998);
      MousePickSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, 100663999);
    }

    public MousePickSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float k_MaxDistance
    {
      get
      {
        float kMaxDistance;
        IL2CPP.il2cpp_field_static_get_value(MousePickSystem.NativeFieldInfoPtr_k_MaxDistance, (void*) &kMaxDistance);
        return kMaxDistance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MousePickSystem.NativeFieldInfoPtr_k_MaxDistance, (void*) &value);
      }
    }

    public unsafe EntityQuery m_MouseGroup
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_m_MouseGroup));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_m_MouseGroup)) = value;
      }
    }

    public unsafe BuildPhysicsWorld m_BuildPhysicsWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_m_BuildPhysicsWorldSystem));
        return pointer == System.IntPtr.Zero ? (BuildPhysicsWorld) null : new BuildPhysicsWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_m_BuildPhysicsWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeArray<MousePickSystem.SpringData> SpringDatas
    {
      get
      {
        return *(NativeArray<MousePickSystem.SpringData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_SpringDatas));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_SpringDatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<MousePickSystem.SpringData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<JobHandle> PickJobHandle
    {
      get
      {
        return *(Nullable_Unboxed<JobHandle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_PickJobHandle));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MousePickSystem.NativeFieldInfoPtr_PickJobHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<JobHandle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpringData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Dragging;
      private static readonly System.IntPtr NativeFieldInfoPtr_PointOnBody;
      private static readonly System.IntPtr NativeFieldInfoPtr_MouseDepth;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public int Dragging;
      [FieldOffset(12)]
      public float3 PointOnBody;
      [FieldOffset(24)]
      public float MouseDepth;

      static SpringData()
      {
        Il2CppClassPointerStore<MousePickSystem.SpringData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, nameof (SpringData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePickSystem.SpringData>.NativeClassPtr);
        MousePickSystem.SpringData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.SpringData>.NativeClassPtr, nameof (Entity));
        MousePickSystem.SpringData.NativeFieldInfoPtr_Dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.SpringData>.NativeClassPtr, nameof (Dragging));
        MousePickSystem.SpringData.NativeFieldInfoPtr_PointOnBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.SpringData>.NativeClassPtr, nameof (PointOnBody));
        MousePickSystem.SpringData.NativeFieldInfoPtr_MouseDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.SpringData>.NativeClassPtr, nameof (MouseDepth));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MousePickSystem.SpringData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Pick
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_NumDynamicBodies;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpringData;
      private static readonly System.IntPtr NativeFieldInfoPtr_RayInput;
      private static readonly System.IntPtr NativeFieldInfoPtr_Near;
      private static readonly System.IntPtr NativeFieldInfoPtr_Forward;
      private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreTriggers;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public CollisionWorld CollisionWorld;
      [FieldOffset(344)]
      public int NumDynamicBodies;
      [FieldOffset(352)]
      public NativeArray<MousePickSystem.SpringData> SpringData;
      [FieldOffset(368)]
      public RaycastInput RayInput;
      [FieldOffset(488)]
      public float Near;
      [FieldOffset(492)]
      public float3 Forward;
      [FieldOffset(504)]
      public bool IgnoreTriggers;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926166, XrefRangeEnd = 926179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MousePickSystem.Pick.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Pick()
      {
        Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MousePickSystem>.NativeClassPtr, nameof (Pick));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr);
        MousePickSystem.Pick.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, nameof (CollisionWorld));
        MousePickSystem.Pick.NativeFieldInfoPtr_NumDynamicBodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, nameof (NumDynamicBodies));
        MousePickSystem.Pick.NativeFieldInfoPtr_SpringData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, nameof (SpringData));
        MousePickSystem.Pick.NativeFieldInfoPtr_RayInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, nameof (RayInput));
        MousePickSystem.Pick.NativeFieldInfoPtr_Near = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, nameof (Near));
        MousePickSystem.Pick.NativeFieldInfoPtr_Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, nameof (Forward));
        MousePickSystem.Pick.NativeFieldInfoPtr_IgnoreTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, nameof (IgnoreTriggers));
        MousePickSystem.Pick.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, 100664000);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MousePickSystem.Pick>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
